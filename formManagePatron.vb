Imports System.Data.OleDb


Public Class formManagePatron

    Private Sub formManagePatron_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initConnection()
        loadCategory()
        loadPatrons()
    End Sub

    Private Sub loadCategory()
        cbCategory.Items.Clear()
        cbCategory.Items.Add("Student")
        cbCategory.Items.Add("Faculty")
        cbCategory.Items.Add("Alumni")
    End Sub

    Private Sub loadPatrons()
        Try
            dgvPatronList.Rows.Clear()
            openConnection()
            Dim query = "SELECT * FROM tbl_patrons"
            Dim cmd = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            ' must check first if the data grid view has column
            If dgvPatronList.ColumnCount > 0 Then
                While reader.Read
                    Dim patronId = reader("patron_id")
                    Dim lastName = reader("last_name")
                    Dim firstName = reader("first_name")
                    Dim middleName = reader("middle_name")
                    Dim fullName = lastName & ", " & firstName & " " & middleName
                    Dim category = reader("category")
                    Dim isVerified = reader("is_verified")

                    dgvPatronList.Rows.Add(patronId, fullName, category, isVerified)
                End While
            End If

        Catch ex As Exception
            MsgBox("An error occured, loading patron: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub


    Private Sub savePatron()
        Try
            openConnection()
            Dim query = "INSERT INTO tbl_patrons(`last_name`, `first_name`, `middle_name`, `category`, `address`, `email`, `contact`, `is_verified`, `patron_id`)
                            VALUES(@LastName, @FirstName, @MiddleName, @Category, @Address, @Email, @Contact, @IsVerified, @PatronId)"

            Dim cmd = New OleDbCommand(query, conn)

            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@LastName", tbLastName.Text)
                .Parameters.AddWithValue("@FirstName", tbFirstName.Text)
                .Parameters.AddWithValue("@MiddleName", tbMiddlename.Text)
                .Parameters.AddWithValue("@Category", cbCategory.Text)
                .Parameters.AddWithValue("@Address", tbPatronAddress.Text)
                .Parameters.AddWithValue("@Email", tbPatronEmail.Text)
                .Parameters.AddWithValue("@Contact", tbPatronContact.Text)
                .Parameters.AddWithValue("@IsVerified", radioVerified.Checked)
                .Parameters.AddWithValue("@PatronId", tbSchoolId.Text)
            End With

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Successfully Save!", vbInformation)
            Else
                MsgBox("Failed to Save!", vbCritical)
            End If

        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        Finally
            closeConnection()
            ClearFields()
            loadPatrons()
        End Try
    End Sub

    Private Sub UpdatePatron(patronId As String)
        Try
            openConnection()
            Dim query = "UPDATE tbl_patrons SET `last_name` = @LastName, `first_name` = @FirstName, `middle_name` = @MiddleName, 
                     `category` = @Category, `address` = @Address, `email` = @Email, `contact` = @Contact, `is_verified` = @IsVerified 
                     WHERE `patron_id` = @PatronId"

            Dim cmd = New OleDbCommand(query, conn)

            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@LastName", tbLastName.Text)
                .Parameters.AddWithValue("@FirstName", tbFirstName.Text)
                .Parameters.AddWithValue("@MiddleName", tbMiddlename.Text)
                .Parameters.AddWithValue("@Category", cbCategory.Text)
                .Parameters.AddWithValue("@Address", tbPatronAddress.Text)
                .Parameters.AddWithValue("@Email", tbPatronEmail.Text)
                .Parameters.AddWithValue("@Contact", tbPatronContact.Text)
                .Parameters.AddWithValue("@IsVerified", radioVerified.Checked)
                .Parameters.AddWithValue("@PatronId", patronId)
            End With

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Successfully updated!", vbInformation)
            Else
                MsgBox("Failed to update!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox("An error occurred, " & ex.Message, vbCritical)
        Finally
            closeConnection()
            ClearFields()
            loadPatrons()
        End Try

    End Sub

    Private Sub DeletePatron(patronId As String)
        ' Show a confirmation dialog before proceeding with the deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this patron?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                openConnection()
                Dim query = "DELETE FROM tbl_patrons WHERE `patron_id` = @PatronId"

                Dim cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@PatronId", patronId)

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Successfully deleted!", vbInformation)
                Else
                    MsgBox("Failed to delete!", vbCritical)
                End If
            Catch ex As Exception
                MsgBox("An error occurred, " & ex.Message, vbCritical)
            Finally
                closeConnection()
                loadPatrons()
            End Try
        End If
    End Sub



    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        If Not isNullOrEmpty(tbSearch.Text) Then
            Try
                dgvPatronList.Rows.Clear()
                openConnection()
                Dim query = "SELECT * FROM tbl_patrons " &
                              "WHERE last_name LIKE '%' + @SearchTerm + '%' OR " &
                              "first_name LIKE '%' + @SearchTerm + '%' OR " &
                              "middle_name LIKE '%' + @SearchTerm + '%'"

                Dim cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@SearchTerm", tbSearch.Text)
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                While reader.Read
                    Dim patronId = reader("patron_id")
                    Dim lastName = reader("last_name")
                    Dim firstName = reader("first_name")
                    Dim middleName = reader("middle_name")
                    Dim fullName = lastName & ", " & firstName & " " & middleName
                    Dim category = reader("category")
                    Dim isVerified = reader("is_verified")

                    dgvPatronList.Rows.Add(patronId, fullName, category, isVerified)
                End While

            Catch ex As Exception
                MsgBox("An error occured, loading patrons: " & ex.Message, vbCritical)
            Finally
                closeConnection()
            End Try

        Else
            loadPatrons()
        End If

    End Sub

    Private Function IsPatronIdAlreadyExists(patronId As String) As Boolean
        Try
            openConnection()
            Dim query As String = "SELECT COUNT(*) FROM tbl_patrons WHERE `patron_id` = @PatronId"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@PatronId", patronId)

            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("An error occurred while checking the Patron ID: " & ex.Message, vbCritical)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Private Function IsEmailAlreadyExists(email As String) As Boolean
        Try
            openConnection()
            Dim query As String = "SELECT COUNT(*) FROM tbl_patrons WHERE `email` = @Email"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", email)

            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("An error occurred while checking the Email: " & ex.Message, vbCritical)
            Return False
        Finally
            closeConnection()
        End Try
    End Function


    Private Sub ClearFields()
        tbLastName.Text = ""
        tbFirstName.Text = ""
        tbMiddlename.Text = ""
        cbCategory.SelectedIndex = -1
        tbPatronAddress.Text = ""
        tbPatronEmail.Text = ""
        tbPatronContact.Text = ""
        radioVerified.Checked = False
        tbSchoolId.Text = ""
    End Sub

    Private Sub dgvPatronList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatronList.CellContentClick
        ClearFields()

        Dim patronId = dgvPatronList.CurrentRow.Cells(0).Value

        Try
            openConnection()

            Dim query = "SELECT * from tbl_patrons WHERE patron_id=@PatronId"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@PatronId", patronId.ToString)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim lastName = reader("last_name").ToString
                Dim firstName = reader("first_name").ToString
                Dim middleName = reader("middle_name").ToString

                Dim category = reader("category").ToString
                Dim id = reader("patron_id").ToString
                Dim isVerified = reader("is_verified")
                Dim address = reader("address").ToString
                Dim contact = reader("contact").ToString
                Dim email = reader("email").ToString

                tbLastName.Text = lastName
                tbFirstName.Text = firstName
                tbMiddlename.Text = middleName

                cbCategory.Text = category
                tbSchoolId.Text = id
                radioVerified.Checked = isVerified
                radioIsNotVerified.Checked = Not isVerified
                tbPatronContact.Text = contact
                tbPatronEmail.Text = email
                tbPatronAddress.Text = address

            End If

        Catch ex As Exception
            MsgBox("An error occured, " * ex.Message, vbCritical)
        End Try
        conn.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isNullOrEmpty(tbPatronEmail.Text) Then
            MsgBox("email cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbLastName.Text) Then
            MsgBox("Last Name cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbFirstName.Text) Then
            MsgBox("First Name cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(cbCategory.Text) Then
            MsgBox("Category must have selected!", vbCritical)
        ElseIf isNullOrEmpty(tbSchoolId.Text) Then
            MsgBox("Identity Number cannot be empty!", vbCritical)
        ElseIf IsPatronIdAlreadyExists(tbSchoolId.Text) Then
            MsgBox("The  id exists in the database.", vbExclamation)
        ElseIf IsEmailAlreadyExists(tbPatronEmail.Text) Then
            MsgBox("The email already exists in the database.", vbExclamation)
        Else
            savePatron()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim patronId = dgvPatronList.CurrentRow.Cells(0).Value
        If isNullOrEmpty(tbPatronEmail.Text) Then
            MsgBox("email cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbLastName.Text) Then
            MsgBox("Last Name cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbFirstName.Text) Then
            MsgBox("First Name cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(cbCategory.Text) Then
            MsgBox("Category must have selected!", vbCritical)
        ElseIf isNullOrEmpty(tbSchoolId.Text) Then
            MsgBox("Identity Number cannot be empty!", vbCritical)
        Else
            UpdatePatron(patronId)
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim patronId = dgvPatronList.CurrentRow.Cells(0).Value
        DeletePatron(patronId)
    End Sub
End Class