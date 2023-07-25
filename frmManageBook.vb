Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class frmManageBook

    Private departementSuggestionList As New List(Of String)()
    Private genreSuggestionList As New List(Of String)()

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        loadBooks()
        ' load department suggestions
        loadDepartmentSuggestions()
        ' load genre suggestions
        loadGenreSuggestions()


        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest
        tbDepartment.AutoCompleteSource = AutoCompleteSource.CustomSource


        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim autoCompleteCollection As New AutoCompleteStringCollection()
        autoCompleteCollection.AddRange(departementSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbDepartment.AutoCompleteCustomSource = autoCompleteCollection


        ' Set the AutoCompleteMode and AutoCompleteSource properties
        tbGenre.AutoCompleteMode = AutoCompleteMode.Suggest
        tbGenre.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Create a new AutoCompleteStringCollection and add the data to it
        Dim genreAutoComplete As New AutoCompleteStringCollection()
        genreAutoComplete.AddRange(genreSuggestionList.ToArray())

        ' Assign the AutoCompleteCustomSource to the TextBox
        tbGenre.AutoCompleteCustomSource = genreAutoComplete
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
                Dim id = reader("id")
                Dim isbn = reader("isbn")
                Dim bookName = reader("title")
                Dim author = reader("author")
                Dim totalCopies = reader("total_copies")
                Dim remainingCopies = reader("remaining_copies")

                Dim queryAuthor = "Select * from tbl_authors WHERE author_id=" & author
                Dim cmdAuthor = New OleDbCommand(queryAuthor, conn)
                Dim readAuthor As OleDbDataReader = cmdAuthor.ExecuteReader

                If readAuthor.Read Then
                    Dim authorFname = readAuthor("first_name")
                    Dim authorLname = readAuthor("last_name")

                    dgvBooks.Rows.Add(
                        id,
                        isbn,
                        bookName,
                        authorFname & ", " & authorLname,
                        totalCopies,
                        remainingCopies
                    )
                End If
            End While


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
            Dim query = "SELECT DISTINCT genre_name FROM tbl_genre"
            Dim command = New OleDbCommand(query, conn)
            Dim dbReader As OleDbDataReader = command.ExecuteReader

            While dbReader.Read
                genreSuggestionList.Add(dbReader("genre_name").ToString())
            End While

        Catch ex As Exception
            MsgBox("An error occured, loading suggestion: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick
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
End Class