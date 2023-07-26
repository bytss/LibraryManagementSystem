Imports System.Data.OleDb

Public Class formIssueBook

    Private departmentSuggestionList As New List(Of String)()
    Private bookSuggestionList As New List(Of String)()

    Private Sub formIssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        loadBookSuggestions()
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


    Private Sub loadBookSuggestions()

        Try
            bookSuggestionList.Clear()
            conn.Open()
            Dim query = "SELECT DISTINCT title FROM tbl_books"
            Dim command = New OleDbCommand(query, conn)
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
            Else
                MsgBox("Sorry, the patron information could not be found", vbCritical)
                clear()
            End If

        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        conn.Close()
    End Sub

    Private Sub loadHistory()
        Try
            conn.Open()
            Dim query = "Select * from tbl_books where email=" & tbEmail.Text
            Dim cmd = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim patronId


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim id = tbSchoolId.Text

        If String.IsNullOrEmpty(id) Then
            MsgBox("An error occured, identity number cannot be empty!", vbCritical)
        Else
            searchPatron(id)
        End If

    End Sub


End Class