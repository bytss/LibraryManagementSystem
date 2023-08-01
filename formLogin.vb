Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.IO

Public Class formLogin

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initConnection()
        tbLoginPassword.UseSystemPasswordChar = True
    End Sub

    Sub loadpic()

        Try
            openConnection()
            Dim cmd = New OleDbCommand("Select * from tbl_users where username=@Username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Username", tbLoginUsername.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read() Then
                Dim lastName = reader("last_name")
                Dim firstName = reader("first_name")
                Dim middleName = reader("middle_name")

                With MainPanel
                    .lbLoginName.Text = lastName & ", " & firstName & " " & middleName
                    .lblRole.Text = reader("role")
                End With
                ' load photo
                If Not reader.IsDBNull("photo") Then
                    Dim imageBytes As Byte() = DirectCast(reader("photo"), Byte())
                    Dim imageStream As New MemoryStream(imageBytes)
                    MainPanel.mainProfilePhoto.Image = Image.FromStream(imageStream)
                Else
                    MainPanel.mainProfilePhoto.Image = formManageUser.profilePhoto.ErrorImage
                End If
                reader.Close()
            Else
                MainPanel.mainProfilePhoto.Image = Nothing
                MessageBox.Show("No image found.")
            End If

        Catch ex As Exception
            MsgBox("An error occured, " & ex.Message)
        End Try
        'conn.Close()
    End Sub

    Sub reset()
        tbLoginUsername.Text = ""
        tbLoginPassword.Text = ""
    End Sub

    Public Function isAdmin() As Boolean
        Try
            openConnection()
            Dim query = "SELECT username, role FROM tbl_users WHERE (username=@Username AND role=@Role)"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", tbLoginUsername.Text)
            cmd.Parameters.AddWithValue("@Role", "Admin")
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            isAdmin = reader.Read
            closeConnection()
            Return isAdmin
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub verifyLogin()
        Try
            openConnection()

            Dim query = "SELECT * FROM tbl_users WHERE username = @Username"
            Dim cmd = New OleDbCommand(query, conn)

            With cmd
                .Parameters.AddWithValue("@Username", tbLoginUsername.Text)
            End With

            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Dim storedHashedPassword As String = reader("password").ToString()
                Dim storedSalt As String = reader("salt").ToString()
                Dim enteredPassword As String = tbLoginPassword.Text.ToString

                ' Verify the entered password by hashing it with the stored salt and comparing the result with the stored hashed password
                Dim isPasswordValid As Boolean = PasswordHashing.VerifyPassword(enteredPassword, storedHashedPassword, storedSalt)

                If isPasswordValid Then
                    Me.Hide()
                    closeConnection()
                    loadpic()
                    MainPanel.Show()
                Else
                    MsgBox("Invalid credentials!", vbCritical)
                End If
            Else
                MsgBox("Invalid credentials!", vbCritical)
            End If
        Catch ex As Exception
            ' Handle any exceptions here
        Finally
            closeConnection()
        End Try

    End Sub

    Private Sub btm_login_Click_1(sender As Object, e As EventArgs) Handles btm_login.Click
        verifyLogin()
    End Sub

    Private Sub Check_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Check_showpass.CheckedChanged
        If Check_showpass.Checked = True Then
            tbLoginPassword.UseSystemPasswordChar = False
        Else
            tbLoginPassword.UseSystemPasswordChar = True

        End If
    End Sub
End Class
