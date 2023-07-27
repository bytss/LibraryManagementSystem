Imports System.Data.OleDb

Public Class formHomePanel
    Private Sub formHomePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initConnection()
        loadData()
        countBooks()
        countPatrons()
        countIssuedBooks()
        countUsers()
    End Sub

    Private Sub countBooks()
        Try
            openConnection()
            Dim query As String = "SELECT COUNT(*) FROM tbl_books"
            Dim cmd = New OleDbCommand(query, conn)

            Dim count As Integer = CInt(cmd.ExecuteScalar())
            lblTotalBooks.Text = count
        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub countPatrons()
        Try
            openConnection()
            Dim query As String = "SELECT COUNT(*) FROM tbl_patrons"
            Dim cmd = New OleDbCommand(query, conn)

            Dim count As Integer = CInt(cmd.ExecuteScalar())
            lblTotalPatrons.Text = count
        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub countUsers()
        Try
            openConnection()
            Dim query As String = "SELECT COUNT(*) FROM tbl_users"
            Dim cmd = New OleDbCommand(query, conn)

            Dim count As Integer = CInt(cmd.ExecuteScalar())
            lblTotalUsers.Text = count
        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub countIssuedBooks()
        Try
            openConnection()
            Dim query As String = "SELECT COUNT(*) FROM tbl_history"
            Dim cmd = New OleDbCommand(query, conn)

            Dim count As Integer = CInt(cmd.ExecuteScalar())
            lblTotalIssuedBook.Text = count
        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Sub loadData()
        ' add try catch to catch exception or errors
        Try
            openConnection()

            Dim bookIndex As Integer

            dgvHistory.Rows.Clear()
            Dim command = New OleDbCommand("select * from tbl_history", conn)
            Dim dr = command.ExecuteReader

            While dr.Read

                bookIndex += 1
                Dim isbn = dr("book_isbn")
                Dim issuedBy = dr("issued_by")
                Dim patron = dr("patron")
                Dim action As String

                If dr.IsDBNull("date_returned") Then
                    action = "Not Yet Return"
                Else
                    action = "Returned"
                End If


                Dim bookQuery = "SELECT isbn, title FROM tbl_books WHERE isbn=@BookIsbn"
                Dim bookCmd = New OleDbCommand(bookQuery, conn)
                bookCmd.Parameters.AddWithValue("@BookIsbn", isbn)
                Dim bookReader = bookCmd.ExecuteReader

                If bookReader.Read Then
                    Dim bookName = bookReader("title")

                    dgvHistory.Rows.Add(
                        bookIndex,
                        isbn,
                        bookName,
                        issuedBy,
                        action
                    )
                End If

            End While

        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
            closeConnection()
        End Try
        closeConnection()
    End Sub


End Class