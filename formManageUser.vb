Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class formManageUser

    Private departementSuggestionList As New List(Of String)()
    Private genreSuggestionList As New List(Of String)()
    Private authorsSuggestionList As New List(Of String)()
    Private publisherSuggestionList As New List(Of String)()

    Private Sub manageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        tbPassword.UseSystemPasswordChar = True
        loadUsers()
        loadRoles()
    End Sub

    Private Sub loadUsers()
        ' clear item books
        dgvUsers.Rows.Clear()

        Try
            conn.Open()
            Dim query = "SELECT * from tbl_users"
            Dim cmd = New OleDbCommand(query, conn)
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
            conn.Open()
            Dim query = "INSERT INTO tbl_users(`last_name`, `first_name`, `middle_name`, `contact`, `email`, `username`, `password`, `role`, `address`, `photo`) 
                        VALUES(@LastName, @FistName, @MiddleName, @Contact, @Email, @Username, @Password, @Role, @Address, @Profile)"
            Dim cmd = New OleDbCommand(query, conn)

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            profilePhoto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()


            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@LastName", tbLastName.Text)
                .Parameters.AddWithValue("@FistName", tbFirstName.Text)
                .Parameters.AddWithValue("@MiddleName", tbMiddleName.Text)
                .Parameters.AddWithValue("@Contact", tbUserContact.Text)
                .Parameters.AddWithValue("@Email", tbUserEmail.Text)
                .Parameters.AddWithValue("@Username", tbUsername.Text)
                .Parameters.AddWithValue("@Password", CipherUtils.EncryptPassword(tbLastName.Text))
                .Parameters.AddWithValue("@Role", cbRoles.Text)
                .Parameters.AddWithValue("@Address", tbUserAddress.Text)
                .Parameters.AddWithValue("@Profile", picture)
            End With

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox(" Successfully Save!", vbInformation)
            Else
                MsgBox(" An error occured, could not save", vbInformation)
            End If

        Catch ex As Exception
            MsgBox(" An error occured, could not save" & ex.Message, vbInformation)
        End Try
        closeConnection()
        loadUsers()
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        clear()

        Dim userId = dgvUsers.CurrentRow.Cells(0).Value



        Try
            conn.Open()

            Dim query = "SELECT * from tbl_users WHERE username=@UserId"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserId", userId.ToString)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim lastName = reader("last_name").ToString
                Dim firstName = reader("first_name").ToString
                Dim middleName = reader("middle_name").ToString
                Dim role = reader("role").ToString
                Dim email = reader("email").ToString
                Dim contact = reader("contact").ToString
                Dim address = reader("address").ToString


                tbLastName.Text = lastName
                tbFirstName.Text = firstName
                tbMiddleName.Text = middleName
                cbRoles.Text = role
                tbUserEmail.Text = email
                tbUserContact.Text = contact
                tbUserAddress.Text = address
                tbPassword.Text = "Password is encrypted"
            End If

        Catch ex As Exception
            MsgBox("An error occured, " * ex.Message, vbCritical)
        End Try
        conn.Close()
    End Sub

    Private Sub clear()
        tbLastName.Text = ""
        tbFirstName.Text = ""
        tbMiddleName.Text = ""
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        If isNullOrEmpty(tbLastName.Text) Then
            MsgBox("Last Name could not be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbFirstName.Text) Then
            MsgBox("First Name could not be empty!", vbCritical)
        ElseIf isNullOrEmpty(cbRoles.Text) Then
            MsgBox("Roles could not be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbUsername.Text) Then
            MsgBox("UserName could not be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbPassword.Text) Then
            MsgBox("Password could not be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbUserEmail.Text) Then
            MsgBox("Email could not be empty!", vbCritical)
        Else
            saveUsers()
        End If
    End Sub

    Private Function isNullOrEmpty(field As String) As Boolean
        Return String.IsNullOrEmpty(field)
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
            profilePhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            OpenFileDialog1.FileName = OpenFileDialog1.FileName

        End If
    End Sub
End Class