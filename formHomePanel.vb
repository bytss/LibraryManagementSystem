Imports System.Data.OleDb

Public Class formHomePanel
    Private Sub formHomePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        loadData()
    End Sub


    Sub loadData()
        ' add try catch to catch exception or errors
        Try
            conn.Open()

            Dim bookIndex As Integer

            dgvHistory.Rows.Clear()
            Dim command = New OleDbCommand("select * from tbl_history", conn)
            Dim dr = command.ExecuteReader

            While dr.Read
                bookIndex += 1
                dgvHistory.Rows.Add(
                    bookIndex,
                    dr.Item("isbn").ToString,
                    dr.Item("issued_by").ToString,
                    dr.Item("issued_by").ToString,
                    dr.Item("issued_by").ToString(),
                    dr.Item("issued_by").ToString()
                )
            End While

        Catch ex As Exception
            closeConnection()
        End Try
        closeConnection()
    End Sub


End Class