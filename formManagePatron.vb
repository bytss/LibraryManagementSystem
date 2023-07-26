﻿Imports System.Data.OleDb


Public Class formManagePatron

    Private Sub formManagePatron_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
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
            conn.Open()
            Dim query = "SELECT * FROM tbl_patrons"
            Dim cmd = New OleDbCommand(query, conn)
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

        End Try
        closeConnection()
    End Sub


    Private Sub savePatron()
        Try
            conn.Open()
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
        End Try
        closeConnection()
    End Sub

    Private Sub btm_save_Click(sender As Object, e As EventArgs) Handles btm_save.Click
        If isNullOrEmpty(tbPatronEmail.Text) Then
            MsgBox("email cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbLastName.text) Then
            MsgBox("Last Name cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(tbFirstName.text) Then
            MsgBox("First Name cannot be empty!", vbCritical)
        ElseIf isNullOrEmpty(cbCategory.text) Then
            MsgBox("Category must have selected!", vbCritical)
        ElseIf isNullOrEmpty(tbSchoolId.text) Then
            MsgBox("Identity Number cannot be empty!", vbCritical)
        Else
            savePatron()
        End If
    End Sub

    Private Sub dgvPatronList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatronList.CellContentClick

    End Sub
End Class