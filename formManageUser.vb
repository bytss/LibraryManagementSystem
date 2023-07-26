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
                Dim userId = reader("user_id")
                Dim firstName = reader("first_name")
                Dim middleName = reader("middle_name")
                Dim lastName = reader("last_name")
                Dim fullName = lastName & ", " & firstName & " " & middleName
                Dim role = reader("role")
                Dim lastLogin = reader("last_login")

                dgvUsers.Rows.Add(userId, fullName, role, lastLogin)
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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        clear()

        Dim userId = dgvUsers.CurrentRow.Cells(0).Value

        tbUsername.Text = userId

        Try
            conn.Open()

            Dim query = "SELECT * from tbl_users WHERE user_id=@UserId"
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


End Class