﻿Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class frmManageBook

    Private departementSuggestionList As New List(Of String)()
    Private genreSuggestionList As New List(Of String)()
    Private authorsSuggestionList As New List(Of String)()
    Private publisherSuggestionList As New List(Of String)()

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        loadBooks()
        ' load department suggestions
        loadDepartmentSuggestions()
        ' load genre suggestions
        loadGenreSuggestions()
        ' load author suggestions
        loadAuthorSuggestions()
        ' load publisher suggestions
        loadPublisherSuggestions()

        ' Department's Suggestions
        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest
        tbDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim autoCompleteCollection As New AutoCompleteStringCollection()
        autoCompleteCollection.AddRange(departementSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbDepartment.AutoCompleteCustomSource = autoCompleteCollection

        ' Genre
        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbGenre.AutoCompleteMode = AutoCompleteMode.Suggest
        tbGenre.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim genreAutoComplete As New AutoCompleteStringCollection()
        genreAutoComplete.AddRange(genreSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbGenre.AutoCompleteCustomSource = genreAutoComplete

        ' Author
        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbAuthorName.AutoCompleteMode = AutoCompleteMode.Suggest
        tbAuthorName.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim authorAutoComplete As New AutoCompleteStringCollection()
        authorAutoComplete.AddRange(authorsSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbAuthorName.AutoCompleteCustomSource = authorAutoComplete

        ' Publisher
        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbPubName.AutoCompleteMode = AutoCompleteMode.Suggest
        tbPubName.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim publisherAutoComplete As New AutoCompleteStringCollection()
        publisherAutoComplete.AddRange(publisherSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbPubName.AutoCompleteCustomSource = publisherAutoComplete
    End Sub

    Private Sub loadBooks()
        ' clear item books
        dgvBooks.Rows.Clear()

        Try
            conn.Open()
            Dim query = "SELECT * from tbl_books"
            Dim cmd = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            While reader.Read
                Dim isbn = reader("isbn")
                Dim bookName = reader("title")
                Dim author = reader("author")

                Dim totalCopies = reader("total_copies")
                Dim remainingCopies = reader("remaining_copies")


                dgvBooks.Rows.Add(isbn, bookName, author, totalCopies, remainingCopies)
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading books: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub loadDepartmentSuggestions()

        Try
            departementSuggestionList.Clear()
            conn.Open()
            Dim query = "SELECT DISTINCT department_name FROM tbl_department"
            Dim command = New OleDbCommand(query, conn)
            Dim dbReader As OleDbDataReader = command.ExecuteReader

            While dbReader.Read
                departementSuggestionList.Add(dbReader("department_name").ToString())
            End While
            dbReader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading suggestion: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub loadGenreSuggestions()
        Try
            genreSuggestionList.Clear()
            ' add data
            genreSuggestionList.Add("Fantasy")
            genreSuggestionList.Add("Educational")
            genreSuggestionList.Add("Novel")
            conn.Open()
            Dim query = "SELECT DISTINCT genre_name FROM tbl_genres"
            Dim command = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = command.ExecuteReader

            While reader.Read
                genreSuggestionList.Add(reader("genre_name").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading suggestion: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub loadAuthorSuggestions()
        Try
            conn.Open()
            authorsSuggestionList.Clear()

            Dim query = "SELECT * FROM tbl_authors"
            Dim command = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = command.ExecuteReader

            While reader.Read
                Dim lastName = reader("last_name")
                Dim FirstName = reader("first_name")

                authorsSuggestionList.Add(lastName & ", " & FirstName)
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("An erro occured, author suggestions: " & ex.Message, vbCritical)
        End Try
        conn.Close()
    End Sub

    Private Sub loadPublisherSuggestions()

        Try
            conn.Open()
            publisherSuggestionList.Clear()

            Dim query = "SELECT * FROM tbl_publishers"
            Dim command = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = command.ExecuteReader

            While reader.Read
                Dim name = reader("publisher_name")

                publisherSuggestionList.Add(name)
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("An erro occured, pub suggestions: " & ex.Message, vbCritical)
        End Try
        conn.Close()
    End Sub

    Private Sub saveBooks()
        Dim selectedDate As DateTime = publishDatePicker.Value
        Try
            conn.Open()
            Dim query = "INSERT INTO tbl_books(`isbn`, `title`, `description`, `total_copies`, `remaining_copies`, `author`, `genre`, `publisher`, `department`, `date_of_published`) 
                            VALUES(@ISBN, @Title, @Description, @TotalCopies, @RemainingCopies, @Author, @Genre, @Publisher, @Department, @PublishedDate)"
            Dim cmd = New OleDbCommand(query, conn)

            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@ISBN", tbIsbn.Text)
                .Parameters.AddWithValue("@Title", tbBookName.Text)
                .Parameters.AddWithValue("@Description", tbDesciption.Text)
                .Parameters.AddWithValue("@TotalCopies", tbCopies.Text)
                .Parameters.AddWithValue("@RemainingCopies", tbCopies.Text)
                .Parameters.AddWithValue("@Author", tbAuthorEmail.Text)
                .Parameters.AddWithValue("@Genre", tbGenre.Text)
                .Parameters.AddWithValue("@Publisher", tbPubEmail.Text)
                .Parameters.AddWithValue("@Department", tbDepartment.Text)
                .Parameters.AddWithValue("@PublishedDate", OleDbType.Date).Value = publishDatePicker.Value.ToString
            End With

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Successfully Save!", vbInformation)
                closeConnection()
                loadBooks()
            Else
                MsgBox("Failed to save!", vbCritical)
            End If

        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        clear()

        Dim isbn = dgvBooks.CurrentRow.Cells(1).Value

        Try
            conn.Open()

            Dim query = "SELECT * from tbl_books WHERE isbn=@ISBN"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ISBN", isbn.ToString)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim bookName = reader("title")
                Dim copies = reader("total_copies")
                Dim description = reader("description")

                tbIsbn.Text = isbn
                tbBookName.Text = bookName.ToString
                tbCopies.Text = copies.ToString
                tbDesciption.Text = description.ToString

            End If


        Catch ex As Exception
            MsgBox("An error occured, " * ex.Message, vbCritical)
        End Try
        conn.Close()
    End Sub

    Private Sub clear()
        tbIsbn.Text = ""
        tbBookName.Text = ""
        tbCopies.Text = ""
    End Sub

    Private Sub btn_addDepartment_Click(sender As Object, e As EventArgs) Handles btn_addDepartment.Click
        frmDepartment.ShowDialog()
    End Sub

    Private Sub btnAddAuthor_Click(sender As Object, e As EventArgs) Handles btnAddAuthor.Click
        formAuthor.ShowDialog()
    End Sub

    Private Sub tbAuthorName_TextChanged(sender As Object, e As EventArgs) Handles tbAuthorName.TextChanged
        Dim author = tbAuthorName.Text

        ' Check if the suggestions list contains the search term
        Dim isTermInSuggestions As Boolean = authorsSuggestionList.Contains(author)

        If isTermInSuggestions Then
            tbContact.Text = "true"
            Try
                conn.Open()

                Dim splitAuthorName = author.Split(", ")
                Dim query = "SELECT * FROM tbl_authors WHERE last_name LIKE @LastName AND first_name LIKE @FirstName"
                Dim cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@LastName", "%" & splitAuthorName(0) & "%")
                cmd.Parameters.AddWithValue("@FirstName", "%" & splitAuthorName(1) & "%")
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                If reader.Read Then
                    Dim email = reader("email").ToString
                    Dim contact = reader("contact_number").ToString
                    Dim address = reader("address").ToString
                    Dim country = reader("country").ToString

                    tbAuthorEmail.Text = email
                    tbContact.Text = contact
                    tbAddress.Text = address & ", " & country
                Else
                    MsgBox("Not found!", vbCritical)
                End If

            Catch ex As Exception
                MsgBox("An error occured, " & ex.Message, vbCritical)
            End Try
            conn.Close()

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        formPublisher.ShowDialog()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        formGenre.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isNullOrEmpty(tbIsbn.Text) Then
            MsgBox("ISBN cannot be empty!")
        ElseIf isNullOrEmpty(tbBookName.Text) Then
            MsgBox("Book Name cannot be empty!")
        ElseIf isNullOrEmpty(tbCopies.Text) Then
            MsgBox("Copies cannot be empty!")
        ElseIf isNullOrEmpty(tbAuthorName.Text) Then
            MsgBox("Author cannot be empty!")
        Else
            saveBooks()
        End If

    End Sub

    Private Sub tbPubName_TextChanged(sender As Object, e As EventArgs) Handles tbPubName.TextChanged
        Dim publisher = tbPubName.Text

        ' Check if the suggestions list contains the search term
        Dim isTermInSuggestions As Boolean = publisherSuggestionList.Contains(publisher)

        If isTermInSuggestions Then
            Try
                conn.Open()

                Dim query = "SELECT * FROM tbl_publishers WHERE publisher_name LIKE @PublisherName"
                Dim cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@PublisherName", "%" & publisher & "%")
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                If reader.Read Then
                    Dim email = reader("email").ToString
                    Dim contact = reader("contact_number").ToString
                    Dim address = reader("address").ToString
                    Dim country = reader("country").ToString

                    tbPubEmail.Text = email
                    tbPubContact.Text = contact
                    tbPubAddress.Text = address & ", " & country
                Else
                    MsgBox("Not found!", vbCritical)
                End If

            Catch ex As Exception
                MsgBox("An error occured, " & ex.Message, vbCritical)
            End Try
            conn.Close()

        End If
    End Sub

    Private Sub dgvBooks_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick

    End Sub
End Class