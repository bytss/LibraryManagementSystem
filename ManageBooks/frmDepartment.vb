
Imports System.Data.OleDb

Public Class frmDepartment
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            conn.Open()
            Dim query = "INSERT INTO tbl_department(`department_name`) VALUES (@Department)"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Department", tbDepartment.Text)

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("New Department Save Successfully !", vbInformation)
            Else
                MsgBox("New Department Save Failed !", vbCritical)
            End If
        Catch ex As Exception
            MsgBox("AN erro occured " & ex.Message, vbCritical)
        End Try
        conn.Close()
        Me.Dispose()
    End Sub

    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Me.Dispose()
    End Sub
End Class