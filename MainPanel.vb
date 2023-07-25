Public Class MainPanel
    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        With formHomePanel
            .TopLevel = False
            Panel1.Controls.Add(formHomePanel)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_customerMaster_Click(sender As Object, e As EventArgs) Handles btn_customerMaster.Click
        With frmManageBook
            .TopLevel = False
            Panel1.Controls.Add(frmManageBook)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_inbound_Click(sender As Object, e As EventArgs) Handles btn_inbound.Click

    End Sub
End Class