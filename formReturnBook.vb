Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Reflection.PortableExecutable
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class formReturnBook
    Private Sub formReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initConnection()
    End Sub

    Private Sub loadHistory(email As String)
        dgvIssuedHistory.Rows.Clear()

        Try
            openConnection()
            Dim query = "SELECT * FROM tbl_history WHERE patron = @PatronEmail"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@PatronEmail", email)
            Dim reader As OleDbDataReader = cmd.ExecuteReader


            While reader.Read
                Dim id = reader("history_id")
                Dim isbn = reader("book_isbn")
                Dim copies = reader("copies")
                Dim dateIssued = reader("date_issued")
                Dim isNotReturned = reader.IsDBNull("date_returned")

                Dim queryBook = "SELECT * FROM tbl_books WHERE isbn = @BookIsbn"
                Dim bookCmd = New OleDbCommand(queryBook, conn)
                bookCmd.Parameters.AddWithValue("@BookIsbn", isbn)

                Dim bookReader As OleDbDataReader = bookCmd.ExecuteReader

                If bookReader.Read And isNotReturned Then
                    Dim bookName = bookReader("title")
                    Dim description = bookReader("description")

                    dgvIssuedHistory.Rows.Add(id, bookName, description, copies, dateIssued, If(isNotReturned, "No", reader("date_returned")))
                End If

                bookReader.Close()
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("An error " & ex.Message)

        End Try
    End Sub

    Private Sub returnBook()
        ' To get the current date only
        Dim currentDate As Date = Date.Today

        Try
            openConnection()

            ' get selected row
            Dim selectedRow = dgvIssuedHistory.SelectedCells(0).RowIndex

            ' extract id
            Dim historyId = dgvIssuedHistory.Rows(selectedRow).Cells(0).Value
            Dim isbn = dgvIssuedHistory.Rows(selectedRow).Cells(1).Value
            Dim bookName = dgvIssuedHistory.Rows(selectedRow).Cells(2).Value
            Dim copies = dgvIssuedHistory.Rows(selectedRow).Cells(3).Value

            Dim query = "UPDATE tbl_history SET date_returned=" & currentDate & " WHERE history_id =" & CInt(historyId)
            Dim command = New OleDbCommand(query, conn)

            Dim bookQuery = "UPDATE tbl_books SET remaining_copies = remaining_copies + @BookCopies WHERE title = @BookIsbn"
            Dim bookCommand = New OleDbCommand(bookQuery, conn)
            With bookCommand
                .Parameters.AddWithValue("@BookCopies", copies)
                .Parameters.AddWithValue("@BookIsbn", isbn)
            End With

            If command.ExecuteNonQuery And bookCommand.ExecuteNonQuery Then
                MsgBox("Successfully Returned! ", vbInformation)
                closeConnection()
            Else
                MsgBox("An error occured, cannot returned book ", vbCritical)
            End If

        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub searchBook(searchTerm As String)

        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In dgvIssuedHistory.Rows
            ' Reset the row's visibility in case it was previously hidden by another search
            row.Visible = True

            ' Check each cell's value in the current row for the search term
            Dim foundMatch As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchTerm) Then
                    ' If a match is found, mark the flag as true and break out of the inner loop
                    foundMatch = True
                    Exit For
                End If
            Next

            ' If no match was found in any cell of the row, hide the row
            If Not foundMatch Then
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            openConnection()
            Dim query = "SELECT * FROM tbl_patrons WHERE patron_id=@Patron"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Patron", tbSearchId.Text)

            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim email = reader("email")
                ' load photo
                If Not reader.IsDBNull("profile_photo") Then
                    Dim imageBytes As Byte() = DirectCast(reader("profile_photo"), Byte())
                    Dim imageStream As New MemoryStream(imageBytes)
                    profilePhoto.Image = Image.FromStream(imageStream)
                Else
                    profilePhoto.Image = formManageUser.profilePhoto.ErrorImage
                End If
                loadHistory(email)
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("An error occured email ," & ex.Message, vbCritical)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If dgvIssuedHistory.SelectedRows.Count = 0 Then
            MsgBox("An error occured, no row selected!", vbCritical)
        Else
            returnBook()
        End If

    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        If Not isNullOrEmpty(tbSearch.Text) Then
            Dim searchTerm As String = tbSearch.Text.Trim()
            searchBook(searchTerm)
        End If
    End Sub

    Private Sub GetHistoryData(id As String)

        Try
            openConnection()

            Dim query As String = "SELECT h.history_id, h.issued_by, b.isbn, b.title, b.description, u.last_name, u.first_name, u.middle_name, u.username, h.copies " &
                          "FROM (tbl_history AS h " &
                          "INNER JOIN tbl_books AS b ON h.book_isbn = b.isbn) " &
                          "INNER JOIN tbl_users AS u ON h.issued_by = u.username " &
                          "WHERE h.history_id = @ID"

            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", id)

            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim title As String = reader("title").ToString()
                Dim description As String = reader("description").ToString()

                Dim lastName As String = reader("last_name").ToString()
                Dim firstName As String = reader("first_name").ToString()
                Dim middleName As String = reader("middle_name").ToString()
                Dim fullName = lastName & ", " & firstName & " " & middleName

                Dim copies As Integer = reader("copies")

                tbReturnIssuedBy.Text = fullName
                tbReturnBookName.Text = title
                tbReturnBookDescription.Text = description
                tbReturnBookCopies.Text = copies
            Else
                MsgBox("No records found.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("An error occurred while retrieving data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeConnection()
        End Try
    End Sub


    Private Sub dgvIssuedHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIssuedHistory.CellContentClick

        Dim id = dgvIssuedHistory.CurrentRow.Cells(0).Value
        GetHistoryData(id.ToString)
    End Sub


End Class