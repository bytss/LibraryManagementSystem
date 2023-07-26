Imports System.Data.OleDb
Imports System.IO

Public Class formLogin


    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        tbLoginPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btm_login_Click(sender As Object, e As EventArgs) Handles btm_login.Click

        Try
            conn.Open()
            Dim query = "SELECT * FROM tbl_users WHERE (username = @Username AND password = @Password)"
            Dim cmd = New OleDbCommand(query, conn)
            With cmd
                .Parameters.AddWithValue("@Username", tbLoginUsername.Text)
                .Parameters.AddWithValue("@Password", tbLoginPassword.Text)
            End With
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read Then
                Me.Hide()
                MainPanel.Show()
                loadpic()
            Else
                MsgBox("Invalid credentials !", vbCritical)
            End If
        Catch ex As Exception

        End Try
        conn.Close()
    End Sub

    Sub loadpic()
        Dim picture() As Byte
        Try
            conn.Open()
            Dim cmd = New OleDbCommand("Select * from tbl_users where username=@Username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Username", "bananax")
            Dim reader As OleDbDataReader = cmd.ExecuteReader

            If reader.Read() Then
                Dim imageBytes As Byte() = DirectCast(reader("photo"), Byte())
                Dim imageStream As New MemoryStream(imageBytes)
                With MainPanel
                    .mainProfilePhoto.Image = Image.FromStream(imageStream)
                End With
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

    Private Sub Check_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles Check_showpass.CheckedChanged
        If Check_showpass.Checked = True Then
            tbLoginPassword.UseSystemPasswordChar = False
        Else
            tbLoginPassword.UseSystemPasswordChar = True

        End If
    End Sub
End Class
