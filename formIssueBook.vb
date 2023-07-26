﻿Imports System.Data.OleDb
Imports System.Net

Public Class formIssueBook

    Private departmentSuggestionList As New List(Of String)()
    Private bookSuggestionList As New List(Of String)()
    Dim def As String = "Default"

    Private Sub formIssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        tbIssueDepartment.Text = def
        loadBookSuggestions(def)
        loadDepartmentSuggestions()

        ' Department's Suggestions
        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbIssueDepartment.AutoCompleteMode = AutoCompleteMode.Suggest
        tbIssueDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim autoCompleteCollection As New AutoCompleteStringCollection()
        autoCompleteCollection.AddRange(departmentSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbIssueDepartment.AutoCompleteCustomSource = autoCompleteCollection

        ' Books's Suggestions
        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbIssueBookName.AutoCompleteMode = AutoCompleteMode.Suggest
        tbIssueBookName.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim bookAutoCompletionList As New AutoCompleteStringCollection()
        bookAutoCompletionList.AddRange(bookSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbIssueBookName.AutoCompleteCustomSource = bookAutoCompletionList
    End Sub

    Private Sub clear()

        tbPatronName.Text = ""
        tbEmail.Text = ""
        tbPatronContact.Text = ""
    End Sub

    Private Sub loadDepartmentSuggestions()

        Try
            departmentSuggestionList.Clear()
            departmentSuggestionList.Add(def)
            conn.Open()
            Dim query = "SELECT DISTINCT department_name FROM tbl_department"
            Dim command = New OleDbCommand(query, conn)
            Dim dbReader As OleDbDataReader = command.ExecuteReader

            While dbReader.Read
                departmentSuggestionList.Add(dbReader("department_name").ToString())
            End While
            dbReader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading suggestion: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub


    Private Sub loadBookSuggestions(department As String)
        Try
            bookSuggestionList.Clear()
            conn.Open()
            Dim query As String

            If def.Equals(department) Then
                query = "SELECT DISTINCT title FROM tbl_books"
            Else
                query = "SELECT DISTINCT title, department FROM tbl_books WHERE department=@Department"
            End If

            Dim command = New OleDbCommand(query, conn)
            command.Parameters.AddWithValue("@Department", department)

            Dim dbReader As OleDbDataReader = command.ExecuteReader

            While dbReader.Read
                bookSuggestionList.Add(dbReader("title").ToString())
            End While
            dbReader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading suggestion: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub


    Private Sub searchPatron(patronId As String)
        Try
            conn.Open()

            Dim query = "Select * from tbl_patrons WHERE patron_id = @PatronId"
            Dim cmd = New OleDbCommand(query, conn)

            cmd.Parameters.AddWithValue("@PatronId", patronId)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read() Then
                Dim lastName = reader("last_name")
                Dim firstName = reader("first_name")
                Dim middleName = reader("middle_name")
                Dim email = reader("email")
                Dim contact = reader("contact")

                tbPatronName.Text = lastName & ", " & firstName & " " & middleName
                tbEmail.Text = email
                tbPatronContact.Text = contact
                closeConnection()
                loadHistory()
            Else
                MsgBox("Sorry, the patron information could not be found", vbCritical)
                clear()
            End If

        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub



    Private Sub loadHistory()
        dgvIssueHistory.Rows.Clear()

        Try
            conn.Open()
            Dim query = "SELECT * FROM tbl_history WHERE patron = @PatronEmail"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@PatronEmail", tbEmail.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            Dim historyIndex As Integer = 0
            While reader.Read

                Dim isbn = reader("book_isbn")
                Dim copies = reader("copies")
                Dim isReturn = reader("date_returned")

                Dim queryBook = "SELECT * FROM tbl_books WHERE isbn = @BookIsbn"
                Dim bookCmd = New OleDbCommand(queryBook, conn)
                bookCmd.Parameters.AddWithValue("@BookIsbn", isbn)

                Dim bookReader As OleDbDataReader = bookCmd.ExecuteReader

                If bookReader.Read Then
                    historyIndex += 1
                    Dim bookName = bookReader("title")
                    Dim description = bookReader("description")

                    dgvIssueHistory.Rows.Add(historyIndex, bookName, description, copies, isReturn)
                End If
                bookReader.Close()
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("An error " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id = tbSchoolId.Text

        If isNullOrEmpty(id) Then
            MsgBox("An error occured, identity number cannot be empty!", vbCritical)
        Else
            searchPatron(id)
        End If

    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click
        If isNullOrEmpty(tbIssueCopies.Text) Then
            MsgBox("Copies must not empty!", vbCritical)
        ElseIf CInt(tbIssueCopies.Text) > 3 Then
            MsgBox("An error occured, the total book copies exceed", vbCritical)
        Else
            ' To get the current date only
            Dim currentDate As Date = Date.Today
            Try
                conn.Open()
                Dim insertQuery = "INSERT INTO tbl_history(`patron`, `book_isbn`, `date_issued`, `issued_by`, `copies`) 
                                VALUES(@Patron, @ISBN, @DateIssued, @IssuedBy, @Copies)"

                Dim cmd = New OleDbCommand(insertQuery, conn)

                Dim query = "SELECT b.isbn, a.email, a.last_name, a.first_name " &
                             "FROM tbl_books AS b " &
                             "INNER JOIN tbl_authors AS a ON b.author = a.email " &
                             "WHERE b.title = @BookName"

                Dim queryCmd = New OleDbCommand(query, conn)
                Dim author = tbAuthor.Text.Split(", ")
                With queryCmd
                    ' .Parameters.AddWithValue("@AuthorLastName", author(0))
                    ' .Parameters.AddWithValue("@AuthorFirstName", author(1))
                    .Parameters.AddWithValue("@BookName", tbIssueBookName.Text)
                End With

                Dim reader As OleDbDataReader = queryCmd.ExecuteReader

                If reader.Read Then
                    Dim isbn = reader("isbn")

                    With cmd
                        .Parameters.AddWithValue("@Patron", tbEmail.Text)
                        .Parameters.AddWithValue("@ISBN", isbn)
                        .Parameters.AddWithValue("@DateIssued", currentDate)
                        .Parameters.AddWithValue("@IssuedBy", "pupbataan")
                        .Parameters.AddWithValue("@Copies", tbIssueCopies.Text)
                    End With

                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Successfully Added!", vbInformation)
                        closeConnection()
                        loadHistory()
                    Else
                        MsgBox("Could not add", vbCritical)
                    End If

                Else
                    MsgBox("Not found ", vbCritical)
                End If
            Catch ex As Exception
                MsgBox("An error occured " & ex.Message, vbCritical)
            End Try
            closeConnection()
        End If
    End Sub

    Private Sub tbIssueDepartment_TextChanged(sender As Object, e As EventArgs) Handles tbIssueDepartment.TextChanged
        Dim department = tbIssueDepartment.Text

        ' Check if the suggestions list contains the search term
        Dim isTermInSuggestions As Boolean = departmentSuggestionList.Contains(department)

        If isTermInSuggestions Then
            loadBookSuggestions(department)
        End If
    End Sub

    Private Sub tbIssueBookName_TextChanged(sender As Object, e As EventArgs) Handles tbIssueBookName.TextChanged
        Dim bookName = tbIssueBookName.Text

        ' Check if the suggestions list contains the search term
        Dim isTermInSuggestions As Boolean = bookSuggestionList.Contains(bookName)

        If isTermInSuggestions Then
            Try
                conn.Open()
                Dim query = "SELECT b.description, a.last_name, a.first_name, a.middle_initial " &
                             "FROM tbl_books AS b " &
                             "INNER JOIN tbl_authors AS a ON b.author = a.email " &
                             "WHERE b.title = @Criteria"

                Dim cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@Criteria", bookName)
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                If reader.Read Then
                    Dim description As String = reader("description").ToString()
                    Dim lastName As String = reader("last_name").ToString()
                    Dim firstName As String = reader("first_name").ToString()
                    Dim middleInitial As String = reader("middle_initial").ToString()

                    tbDescription.Text = description
                    tbAuthor.Text = lastName & ", " & firstName & " " & middleInitial
                Else
                    MsgBox("Not Found", vbCritical)
                End If

            Catch ex As Exception
                MsgBox("Not Found " & ex.Message, vbInformation)
            End Try
            closeConnection()
        End If

    End Sub
End Class