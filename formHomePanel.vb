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

            dvgHistory.Rows.Clear()
            Dim command = New OleDbCommand("select * from tbl_history", conn)
            Dim dr = command.ExecuteReader

            While dr.Read
                bookIndex += 1
                dvgHistory.Rows.Add(
                    bookIndex,
                    dr.Item("book_id").ToString,
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

    Private Sub dvgHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgHistory.CellContentClick

    End Sub
End Class