Imports System.Data.OleDb

Public Class formPublisher
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            conn.Open()
            Dim query = "INSERT INTO tbl_publisher(`name`, `email`, `contact_number`, `address`, `country`)
                        VALUES(@Name, @Email, @ContactNumber, @Address, @Country)"


            Dim cmd = New OleDbCommand(query, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", tbName.Text)
                .Parameters.AddWithValue("@Email", tbEmail.Text)
                .Parameters.AddWithValue("@ContactNumber", tbContact.Text)
                .Parameters.AddWithValue("@Address", tbAddress.Text)
                .Parameters.AddWithValue("@Country", tbCountry.Text)
            End With

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Successfully Saved!", vbInformation)
            Else
                MsgBox("Failed to save data", vbCritical)
            End If

        Catch ex As Exception
            MsgBox("An error occured " & ex.Message, vbCritical)
        End Try
        conn.Close()
        Me.Dispose()

    End Sub

End Class