﻿
Imports System.Data.OleDb

Public Class formGenre
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            openConnection()
            Dim query = "INSERT INTO tbl_genre(`genre_name`) VALUES (@GENRE)"
            Dim cmd = New OleDbCommand(query, conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@GENRE", tbDepartment.Text)

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox("Successfully Save!", vbInformation)
            Else
                MsgBox("Failed to Save Data!", vbCritical)
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