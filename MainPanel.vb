Imports System.Windows

Public Class MainPanel

    Private Sub MainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With formHomePanel
            .TopLevel = False
            Panel1.Controls.Add(formHomePanel)
            .BringToFront()
            .Show()
        End With
        ' btn_manageuser.Visible = formLogin.isAdmin
        ' formLogin.loadpic()
    End Sub

    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        With formHomePanel
            .TopLevel = False
            Panel1.Controls.Add(formHomePanel)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnManagePatron_Click(sender As Object, e As EventArgs) Handles btnManagePatron.Click
        With formManagePatron
            .TopLevel = False
            Panel1.Controls.Add(formManagePatron)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnManageBooks_Click(sender As Object, e As EventArgs) Handles btnManageBooks.Click
        With frmManageBook
            .TopLevel = False
            Panel1.Controls.Add(frmManageBook)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        With formIssueBook
            .TopLevel = False
            Panel1.Controls.Add(formIssueBook)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        With formReturnBook
            .TopLevel = False
            Panel1.Controls.Add(formReturnBook)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_manageuser_Click(sender As Object, e As EventArgs) Handles btn_manageuser.Click
        With formManageUser
            .TopLevel = False
            Panel1.Controls.Add(formManageUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Dispose()
        formLogin.reset()
        formLogin.Show()
    End Sub


End Class