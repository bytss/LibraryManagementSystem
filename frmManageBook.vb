Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class frmManageBook

    Private departementSuggestionList As New List(Of String)()
    Private genreSuggestionList As New List(Of String)()
    Private authorsSuggestionList As New List(Of String)()
    Private publisherSuggestionList As New List(Of String)()
    Private def As String = "Default"

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initConnection()
        ' load department list
        loadDepartmentList()
        ' load department suggestions
        loadDepartmentSuggestions()

        ' load genre suggestions
        loadGenreSuggestions()
        ' load author suggestions
        loadAuthorSuggestions()
        ' load publisher suggestions
        loadPublisherSuggestions()

        ' load books
        loadBooks()

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
            openConnection()
            Dim query As String
            If cbDepartment.Text = "Default" Then
                query = "SELECT * from tbl_books"
            Else
                query = "SELECT * from tbl_books WHERE department=@Department"
            End If
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Department", cbDepartment.Text)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader

            While Reader.Read
                Dim isbn = Reader("isbn")
                Dim bookName = Reader("title")
                Dim author = Reader("author")

                Dim totalCopies = Reader("total_copies")
                Dim remainingCopies = Reader("remaining_copies")


                dgvBooks.Rows.Add(isbn, bookName, author, totalCopies, remainingCopies)
            End While

            Reader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading books: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub loadDepartmentList()

        Try
            cbDepartment.Items.Clear()
            cbDepartment.Items.Add("Default")
            cbDepartment.Text = "Default"
            openConnection()
            Dim query = "SELECT DISTINCT department_name FROM tbl_department"
            Dim command = New OleDbCommand(query, conn)
            Dim dbReader As OleDbDataReader = command.ExecuteReader

            While dbReader.Read
                cbDepartment.Items.Add(dbReader("department_name").ToString())
            End While
            dbReader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading suggestion: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub


    Private Sub loadDepartmentSuggestions()

        Try
            departementSuggestionList.Clear()
            openConnection()
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
            openConnection()
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
            openConnection()
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
        closeConnection()
    End Sub

    Private Sub loadPublisherSuggestions()

        Try
            openConnection()
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
        closeConnection()
    End Sub

    Private Sub saveBooks()
        Dim selectedDate As DateTime = publishDatePicker.Value
        Try
            openConnection()
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
        ClearFields()

        Dim isbn = dgvBooks.CurrentRow.Cells(1).Value

        Try
            openConnection()

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
        closeConnection()
    End Sub

    Private Sub updateBook(isbn As String)
        Dim selectedDate As DateTime = publishDatePicker.Value
        Try
            openConnection()
            Dim query = "UPDATE tbl_books SET `isbn` = @ISBN, `title` = @Title, `description` = @Description, `total_copies` = @TotalCopies, 
                      `remaining_copies` = @RemainingCopies, `author` = @Author, `genre` = @Genre, `publisher` = @Publisher, 
                      `department` = @Department, `date_of_published` = @PublishedDate WHERE `isbn` = @ISBN"

            Dim cmd = New OleDbCommand(query, conn)

            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@ISBN", isbn)
                .Parameters.AddWithValue("@Title", tbBookName.Text)
                .Parameters.AddWithValue("@Description", tbDesciption.Text)
                .Parameters.AddWithValue("@TotalCopies", tbCopies.Text)
                .Parameters.AddWithValue("@RemainingCopies", tbCopies.Text)
                .Parameters.AddWithValue("@Author", tbAuthorEmail.Text)
                .Parameters.AddWithValue("@Genre", tbGenre.Text)
                .Parameters.AddWithValue("@Publisher", tbPubEmail.Text)
                .Parameters.AddWithValue("@Department", tbDepartment.Text)
                .Parameters.AddWithValue("@PublishedDate", publishDatePicker.Value)
            End With

            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Successfully updated!", vbInformation)
                loadBooks()
            Else
                MsgBox("Failed to update!", vbCritical)
            End If

        Catch ex As Exception
            MsgBox("An error occurred, " & ex.Message, vbCritical)
        End Try
        closeConnection()
        ClearFields()
    End Sub

    Private Sub DeleteBook(isbn As String)

        If isNullOrEmpty(isbn) Then
            MsgBox("Please enter an ISBN to delete.", vbExclamation)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                openConnection()
                Dim query As String = "DELETE FROM tbl_books WHERE `isbn` = @ISBN"
                Dim cmd As New OleDbCommand(query, conn)

                cmd.Parameters.AddWithValue("@ISBN", isbn)

                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Book deleted successfully!", vbInformation)
                    ClearFields()
                    loadBooks()
                Else
                    MsgBox("Failed to delete the book.", vbCritical)
                End If

            Catch ex As Exception
                MsgBox("An error occurred, " & ex.Message, vbCritical)
            Finally
                closeConnection()
            End Try
        End If
    End Sub

    Private Function IsISBNAlreadyExists(isbn As String) As Boolean
        Try
            openConnection()
            Dim query As String = "SELECT COUNT(*) FROM tbl_books WHERE `isbn` = @ISBN"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ISBN", isbn)

            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("An error occurred while checking the ISBN: " & ex.Message, vbCritical)
            Return False
        Finally
            closeConnection()
        End Try
    End Function


    Private Sub ClearFields()
        tbIsbn.Text = ""
        tbBookName.Text = ""
        tbDesciption.Text = ""
        tbCopies.Text = ""
        tbAuthorEmail.Text = ""
        tbGenre.Text = ""
        tbPubEmail.Text = ""
        tbDepartment.Text = ""
        publishDatePicker.Value = DateTime.Now 'Set the date picker to the current date or any default date you prefer
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
            tbAuthorContact.Text = "true"
            Try
                openConnection()

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
                    tbAuthorContact.Text = contact
                    tbAuthorAddress.Text = address & ", " & country
                Else
                    MsgBox("Not found!", vbCritical)
                End If

            Catch ex As Exception
                MsgBox("An error occured, " & ex.Message, vbCritical)
            End Try
            closeConnection()
        End If
    End Sub

    Private Function isValidate() As Boolean
        If isNullOrEmpty(tbIsbn.Text) Then
            MsgBox("ISBN cannot be empty!", vbExclamation)
        ElseIf isNullOrEmpty(tbBookName.Text) Then
            MsgBox("Book Name cannot be empty!", vbExclamation)
        ElseIf isNullOrEmpty(tbCopies.Text) Then
            MsgBox("Copies cannot be empty!", vbExclamation)
        ElseIf isNullOrEmpty(tbAuthorName.Text) Then
            MsgBox("Author cannot be empty!", vbExclamation)
        Else
            ' for validation
            Return True
        End If
        Return False
    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        formPublisher.ShowDialog()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        formGenre.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If IsISBNAlreadyExists(tbIsbn.Text.ToString.Trim) Then
            MsgBox("The ISBN already exists in the database.", vbExclamation)
        ElseIf isValidate Then
            saveBooks()
        End If

    End Sub

    Private Sub tbPubName_TextChanged(sender As Object, e As EventArgs) Handles tbPubName.TextChanged
        Dim publisher = tbPubName.Text

        ' Check if the suggestions list contains the search term
        Dim isTermInSuggestions As Boolean = publisherSuggestionList.Contains(publisher)

        If isTermInSuggestions Then
            Try
                openConnection()

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
            closeConnection()
        End If
    End Sub

    Private Sub dgvBooks_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick
        Dim isbn = dgvBooks.CurrentRow.Cells(0).Value.ToString().Trim()

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            openConnection()

            Dim query = "SELECT b.isbn, b.title, b.description, b.total_copies, b.genre, b.department, b.date_of_published, " &
            "a.last_name, a.first_name, a.middle_initial, a.email, a.contact_number, a.address, " &
            "p.publisher_name, p.email AS publisher_email, p.contact_number AS publisher_contact_number, p.address AS publisher_address " &
            "FROM (tbl_books AS b " &
            "INNER JOIN tbl_authors AS a ON b.author = a.email) " &
            "INNER JOIN tbl_publishers AS p ON b.publisher = p.email " &
            "WHERE b.isbn = @Criteria"


            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Criteria", isbn.ToString)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                ' Access the retrieved data using reader
                Dim bookIsbn As String = reader("isbn").ToString()
                Dim title As String = reader("title").ToString()
                Dim description As String = reader("description").ToString()
                Dim totalCopies As Integer = Convert.ToInt32(reader("total_copies"))
                Dim genre As String = reader("genre").ToString()
                Dim department As String = reader("department").ToString()
                Dim publishedDate As DateTime = Convert.ToDateTime(reader("date_of_published"))

                Dim authorLastName As String = reader("last_name").ToString()
                Dim authorFirstName As String = reader("first_name").ToString()
                Dim authorMiddleInitial As String = reader("middle_initial").ToString()
                Dim authorEmail As String = reader("email").ToString()
                Dim authorContactNumber As String = reader("contact_number").ToString()
                Dim authorAddress As String = reader("address").ToString()


                Dim publisherName As String = reader("publisher_name").ToString()
                Dim publisherEmail As String = reader("publisher_email").ToString()
                Dim publisherContactNumber As String = reader("publisher_contact_number").ToString()
                Dim publisherAddress As String = reader("publisher_address").ToString()

                ' Do something with the retrieved data...
                tbIsbn.Text = bookIsbn
                tbBookName.Text = title
                tbDesciption.Text = description
                tbCopies.Text = totalCopies
                tbGenre.Text = genre
                tbDepartment.Text = department
                publishDatePicker.Value = publishedDate

                tbAuthorName.Text = authorLastName & ", " & authorFirstName & " " & authorMiddleInitial
                tbAuthorEmail.Text = authorEmail
                tbAuthorContact.Text = authorContactNumber
                tbAuthorAddress.Text = authorAddress

                tbPubName.Text = publisherName
                tbPubEmail.Text = publisherEmail
                tbPubContact.Text = publisherContactNumber
                tbPubAddress.Text = publisherAddress
            Else
                MsgBox("Not found")
            End If
        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        loadBooks()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim isbn = dgvBooks.CurrentRow.Cells(0).Value
        updateBook(isbn)
    End Sub

    Private Sub cbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartment.SelectedIndexChanged
        loadBooks()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        If Not isNullOrEmpty(tbSearch.Text) Then
            ' clear item books
            dgvBooks.Rows.Clear()

            Try
                openConnection()
                Dim query As String
                Dim cmd
                If cbDepartment.Text.Equals(def) Then
                    query = "SELECT * FROM tbl_books " &
                    "WHERE (title LIKE '%' + @SearchTerm + '%' OR " &
                    "description LIKE '%' + @SearchTerm + '%')"
                    cmd = New OleDbCommand(query, conn)
                Else
                    query = "SELECT * FROM tbl_books WHERE (department=@Department AND " &
                            "(title LIKE '%' + @SearchTerm + '%' OR " &
                            "description LIKE '%' + @SearchTerm + '%'))"
                    cmd = New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Department", cbDepartment.Text)
                End If
                cmd.Parameters.AddWithValue("@SearchTerm", tbSearch.Text)

                Dim Reader As OleDbDataReader = cmd.ExecuteReader

                While Reader.Read
                    Dim isbn = Reader("isbn")
                    Dim bookName = Reader("title")
                    Dim author = Reader("author")

                    Dim totalCopies = Reader("total_copies")
                    Dim remainingCopies = Reader("remaining_copies")


                    dgvBooks.Rows.Add(isbn, bookName, author, totalCopies, remainingCopies)
                End While

                Reader.Close()
            Catch ex As Exception
                MsgBox("An error occured, loading books: " & ex.Message, vbCritical)
            End Try
            closeConnection()
        Else
            loadBooks()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim isbn = dgvBooks.CurrentRow.Cells(0).Value.ToString().Trim()
        DeleteBook(isbn)
    End Sub
End Class