﻿Imports System.Data.OleDb
Imports System.IO

Public Class formManageUser

    Private departementSuggestionList As New List(Of String)()
    Private genreSuggestionList As New List(Of String)()
    Private authorsSuggestionList As New List(Of String)()
    Private publisherSuggestionList As New List(Of String)()
    Private selectedImagePath As String


    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initConnection()
        tbPassword.UseSystemPasswordChar = True
        loadUsers()
        loadRoles()
    End Sub

    Private Sub loadUsers()
        Try
            ' clear item books
            dgvUsers.Rows.Clear()
            openConnection()
            Dim query = "SELECT * from tbl_users"
            Dim cmd = New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader


            ' must check first if the data grid view has column
            If dgvUsers.ColumnCount > 0 Then
                While reader.Read
                    Dim username = reader("username")
                    Dim firstName = reader("first_name")
                    Dim middleName = reader("middle_name")
                    Dim lastName = reader("last_name")
                    Dim fullName = lastName & ", " & firstName & " " & middleName
                    Dim role = reader("role")
                    Dim lastLogin = reader("last_login")

                    dgvUsers.Rows.Add(username, fullName, role, lastLogin)
                End While
            End If


            reader.Close()
        Catch ex As Exception
            MsgBox("An error occured, loading books: " & ex.Message, vbCritical)
        End Try
        closeConnection()
    End Sub

    Private Sub loadRoles()
        Try
            cbRoles.Items.Clear()

            cbRoles.Items.Add("Staff")
            cbRoles.Items.Add("Admin")
        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message, vbCritical)
        End Try
    End Sub


    Private Sub saveUsers()
        Try
            openConnection()
            Dim query = "INSERT INTO tbl_users(`last_name`, `first_name`, `middle_name`, `contact`, `email`, `username`, `password`, `salt`, `role`, `address`, `photo`) 
                        VALUES(@LastName, @FistName, @MiddleName, @Contact, @Email, @Username, @Salt, @Password, @Role, @Address, @Profile)"

            Dim cmd = New OleDbCommand(query, conn)

            ' Generate a random salt for the user
            Dim salt As String = PasswordHashing.GenerateSalt()

            ' Get the user's password (entered during registration or password update)
            Dim password As String = tbPassword.Text.ToString

            ' Hash the password along with the salt
            Dim hashedPassword As String = PasswordHashing.HashPassword(password, salt)

            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@LastName", tbLastName.Text)
                .Parameters.AddWithValue("@FistName", tbFirstName.Text)
                .Parameters.AddWithValue("@MiddleName", tbMiddleName.Text)
                .Parameters.AddWithValue("@Contact", tbUserContact.Text)
                .Parameters.AddWithValue("@Email", tbUserEmail.Text)
                .Parameters.AddWithValue("@Username", tbUsername.Text)
                .Parameters.AddWithValue("@Password", hashedPassword)
                .Parameters.AddWithValue("@Salt", salt)
                .Parameters.AddWithValue("@Role", cbRoles.Text)
                .Parameters.AddWithValue("@Address", tbUserAddress.Text)
                .Parameters.AddWithValue("@Profile", If(File.Exists(selectedImagePath), File.ReadAllBytes(selectedImagePath), DBNull.Value))
            End With

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox(" Successfully Save!", vbInformation)
            Else
                MsgBox(" An error occured, could not save", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(" An error occured, could not save" & ex.Message, vbInformation)
        Finally
            closeConnection()
            loadUsers()
            ClearFields()
        End Try
    End Sub

    Private Sub updateUsers(userId As String)
        Try
            openConnection()

            Dim query = "UPDATE tbl_users " &
                    "SET `last_name` = @LastName, " &
                    "`first_name` = @FirstName, " &
                    "`middle_name` = @MiddleName, " &
                    "`contact` = @Contact, " &
                    "`email` = @Email, " &
                    "`username` = @Username, " &
                    "`password` = @Password, " &
                    "`salt` = @Salt, " &
                    "`role` = @Role, " &
                    "`address` = @Address "

            ' Check if the profile photo has been selected
            If Not String.IsNullOrEmpty(selectedImagePath) AndAlso File.Exists(selectedImagePath) Then
                query += ", `photo` = @ProfilePhoto"
            End If

            query += " WHERE `username` = @UserId"

            Dim cmd = New OleDbCommand(query, conn)

            Dim photoBytes As Byte() = If(File.Exists(selectedImagePath), File.ReadAllBytes(selectedImagePath), Nothing)

            ' Generate a random salt for the user
            Dim salt As String = PasswordHashing.GenerateSalt()

            ' Get the user's password (entered during registration or password update)
            Dim password As String = tbPassword.Text.ToString

            ' Hash the password along with the salt
            Dim hashedPassword As String = PasswordHashing.HashPassword(password, salt)


            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@LastName", tbLastName.Text)
                .Parameters.AddWithValue("@FirstName", tbFirstName.Text)
                .Parameters.AddWithValue("@MiddleName", tbMiddleName.Text)
                .Parameters.AddWithValue("@Contact", tbUserContact.Text)
                .Parameters.AddWithValue("@Email", tbUserEmail.Text)
                .Parameters.AddWithValue("@Username", tbUsername.Text)
                .Parameters.AddWithValue("@Password", hashedPassword) ' Note: This is not a secure way to handle passwords. Consider using proper password hashing and storage methods.
                .Parameters.AddWithValue("@Salt", salt)
                .Parameters.AddWithValue("@Role", cbRoles.Text)
                .Parameters.AddWithValue("@Address", tbUserAddress.Text)
                ' Check if the profile photo has been selected
                If Not String.IsNullOrEmpty(selectedImagePath) AndAlso File.Exists(selectedImagePath) Then
                    .Parameters.AddWithValue("@ProfilePhoto", photoBytes)
                End If

                .Parameters.AddWithValue("@UserId", userId)
            End With

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox(" Successfully Updated!", vbInformation)
            Else
                MsgBox(" An error occurred, could not update", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(" An error occurred, could not update" & ex.Message, vbInformation)
        Finally
            closeConnection()
            loadUsers()
            ClearFields()
        End Try
    End Sub




    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        ClearFields()

        Dim userId = dgvUsers.CurrentRow.Cells(0).Value

        Try
            openConnection()

            Dim query = "SELECT * from tbl_users WHERE username=@UserId"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserId", userId.ToString)
            Dim reader As OleDbDataReader = cmd.ExecuteReader


            If reader.Read Then

                Dim username = reader("username").ToString
                Dim lastName = reader("last_name").ToString
                Dim firstName = reader("first_name").ToString
                Dim middleName = reader("middle_name").ToString
                Dim role = reader("role").ToString
                Dim email = reader("email").ToString
                Dim contact = reader("contact").ToString
                Dim address = reader("address").ToString

                tbUsername.Text = username
                tbLastName.Text = lastName
                tbFirstName.Text = firstName
                tbMiddleName.Text = middleName
                cbRoles.Text = role
                tbUserEmail.Text = email
                tbUserContact.Text = contact
                tbUserAddress.Text = address
                tbPassword.Text = "Password is encrypted"

                ' load photo
                If Not reader.IsDBNull("photo") Then
                    Dim imageBytes As Byte() = DirectCast(reader("photo"), Byte())
                    Dim imageStream As New MemoryStream(imageBytes)
                    profilePhoto.Image = Image.FromStream(imageStream)
                Else
                    profilePhoto.Image = profilePhoto.ErrorImage
                End If

            End If

        Catch ex As Exception
            MsgBox("An error occured, " * ex.Message, vbCritical)
        Finally
            closeConnection()
        End Try

    End Sub

    Private Sub deleteUser(userId As String)
        Try
            ' Display a confirmation dialog before proceeding with deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If the user confirms the deletion, proceed with the deletion
            If result = DialogResult.Yes Then
                openConnection()

                Dim query = "DELETE FROM tbl_users WHERE `username` = @UserId"

                Dim cmd = New OleDbCommand(query, conn)

                With cmd
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@UserId", userId)
                End With

                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Successfully deleted the user!", vbInformation)
                Else
                    MsgBox("No records were deleted.", vbExclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox("An error occurred, could not delete the user: " & ex.Message, vbCritical)
        Finally
            closeConnection()
            loadUsers()
        End Try
    End Sub



    Private Sub ClearFields()
        tbUsername.Text = ""
        tbLastName.Text = ""
        tbFirstName.Text = ""
        tbMiddleName.Text = ""
        tbUserContact.Text = ""
        tbUserEmail.Text = ""
        tbPassword.Text = ""
        cbRoles.SelectedIndex = -1
        tbUserAddress.Text = ""
        selectedImagePath = ""
        ' You can also clear the profile photo, if applicable
        ' profilePictureBox.Image = Nothing
    End Sub

    Private Function isExisted(userEmail As String) As Boolean
        Try
            openConnection()
            Dim query = "Select COUNT(*) FROM tbl_users WHERE Email = @Email"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", userEmail)

            Dim result As Integer = CInt(cmd.ExecuteScalar())

            Return result > 0
        Catch ex As Exception
            Return False
        End Try
        closeConnection()
    End Function

    Private Function isValidate() As Boolean
        If isNullOrEmpty(tbLastName.Text) Then
            MsgBox("Last Name could Not be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbFirstName.Text) Then
            MsgBox("First Name could Not be empty!", vbCritical)
        ElseIf isNullOrEmpty(cbRoles.Text) Then
            MsgBox("Roles could Not be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbUsername.Text) Then
            MsgBox("Username could Not be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbPassword.Text) Then
            MsgBox("Password could Not be empty!", vbCritical)
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub Check_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Check_showpass.CheckedChanged
        If Check_showpass.Checked = True Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        OpenFileDialog1.Filter = "Choose Images(*.JPG,*.PNG,*.JPEG,*.GIF)|*.JPG;*.PNG;*.JPEG*.GIF|ALL FILES(*.*)|*.*"

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            selectedImagePath = OpenFileDialog1.FileName
            profilePhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            OpenFileDialog1.FileName = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearchUser.TextChanged
        If Not isNullOrEmpty(tbSearchUser.Text) Then
            Try
                ' clear item books
                dgvUsers.Rows.Clear()
                openConnection()
                Dim query = "Select * FROM tbl_users " &
                              "WHERE username Like '%' + @SearchTerm + '%' OR " &
                              "last_name LIKE '%' + @SearchTerm + '%' OR " &
                              "first_name LIKE '%' + @SearchTerm + '%' OR " &
                              "middle_name LIKE '%' + @SearchTerm + '%'"
                Dim cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@SearchTerm", tbSearchUser.Text)
                Dim reader As OleDbDataReader = cmd.ExecuteReader

                While reader.Read
                    Dim username = reader("username")
                    Dim firstName = reader("first_name")
                    Dim middleName = reader("middle_name")
                    Dim lastName = reader("last_name")
                    Dim fullName = lastName & ", " & firstName & " " & middleName
                    Dim role = reader("role")
                    Dim lastLogin = reader("last_login")

                    dgvUsers.Rows.Add(username, fullName, role, lastLogin)
                End While

                reader.Close()
            Catch ex As Exception
                MsgBox("An error occured, loading users: " & ex.Message, vbCritical)
            End Try
            closeConnection()
        Else
            loadUsers()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isNullOrEmpty(tbUserEmail.Text) Then
            MsgBox("Email could Not be empty!", vbCritical)
        ElseIf isExisted(tbUserEmail.Text) Then
            MsgBox("Email is already registered! ", vbCritical)
        ElseIf isValidate() Then
            saveUsers()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim username = dgvUsers.CurrentRow.Cells(0).Value
        If isNullOrEmpty(tbUserEmail.Text) Then
            MsgBox("Email could Not be empty!", vbCritical)
        Else
            updateUsers(username.ToString())
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim username = dgvUsers.CurrentRow.Cells(0).Value
        deleteUser(username.ToString)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
End Class