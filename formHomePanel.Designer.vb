﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHomePanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label8 = New Label()
        Label6 = New Label()
        lblTotalPatrons = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        lblTotalUsers = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        lblTotalIssuedBook = New Label()
        Label2 = New Label()
        lblTotalBooks = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        dgvHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        index = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(34, 20)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(178, 48)
        Label8.TabIndex = 49
        Label8.Text = "Dashboard"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(34, 220)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 39)
        Label6.TabIndex = 44
        Label6.Text = "History"
        ' 
        ' lblTotalPatrons
        ' 
        lblTotalPatrons.AutoSize = True
        lblTotalPatrons.Font = New Font("Poppins", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalPatrons.ForeColor = Color.White
        lblTotalPatrons.Location = New Point(23, 48)
        lblTotalPatrons.Margin = New Padding(4, 0, 4, 0)
        lblTotalPatrons.Name = "lblTotalPatrons"
        lblTotalPatrons.Size = New Size(64, 56)
        lblTotalPatrons.TabIndex = 6
        lblTotalPatrons.Text = "00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(23, 10)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 28)
        Label5.TabIndex = 5
        Label5.Text = "Total Patrons"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Crimson
        Panel4.Controls.Add(lblTotalPatrons)
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(795, 82)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(233, 115)
        Panel4.TabIndex = 45
        ' 
        ' lblTotalUsers
        ' 
        lblTotalUsers.AutoSize = True
        lblTotalUsers.Font = New Font("Poppins", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalUsers.ForeColor = Color.White
        lblTotalUsers.Location = New Point(23, 48)
        lblTotalUsers.Margin = New Padding(4, 0, 4, 0)
        lblTotalUsers.Name = "lblTotalUsers"
        lblTotalUsers.Size = New Size(64, 56)
        lblTotalUsers.TabIndex = 6
        lblTotalUsers.Text = "00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(23, 10)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 28)
        Label3.TabIndex = 5
        Label3.Text = "Total Users"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Controls.Add(lblTotalUsers)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(539, 82)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(233, 115)
        Panel3.TabIndex = 42
        ' 
        ' lblTotalIssuedBook
        ' 
        lblTotalIssuedBook.AutoSize = True
        lblTotalIssuedBook.Font = New Font("Poppins", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalIssuedBook.ForeColor = Color.White
        lblTotalIssuedBook.Location = New Point(17, 48)
        lblTotalIssuedBook.Margin = New Padding(4, 0, 4, 0)
        lblTotalIssuedBook.Name = "lblTotalIssuedBook"
        lblTotalIssuedBook.Size = New Size(64, 56)
        lblTotalIssuedBook.TabIndex = 5
        lblTotalIssuedBook.Text = "00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(17, 11)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 28)
        Label2.TabIndex = 4
        Label2.Text = "Total Issued Book"
        ' 
        ' lblTotalBooks
        ' 
        lblTotalBooks.AutoSize = True
        lblTotalBooks.Font = New Font("Poppins", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotalBooks.ForeColor = Color.White
        lblTotalBooks.Location = New Point(9, 48)
        lblTotalBooks.Margin = New Padding(4, 0, 4, 0)
        lblTotalBooks.Name = "lblTotalBooks"
        lblTotalBooks.Size = New Size(64, 56)
        lblTotalBooks.TabIndex = 4
        lblTotalBooks.Text = "00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(9, 12)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 28)
        Label1.TabIndex = 3
        Label1.Text = "Total Books"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(lblTotalBooks)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(35, 82)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 115)
        Panel1.TabIndex = 40
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Firebrick
        Panel2.Controls.Add(lblTotalIssuedBook)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(287, 82)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(233, 115)
        Panel2.TabIndex = 41
        ' 
        ' dgvHistory
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvHistory.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Maroon
        DataGridViewCellStyle2.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvHistory.ColumnHeadersHeight = 35
        dgvHistory.Columns.AddRange(New DataGridViewColumn() {index, Column1, Column2, Column3, Column5})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvHistory.DefaultCellStyle = DataGridViewCellStyle3
        dgvHistory.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistory.Location = New Point(34, 262)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.RowHeadersVisible = False
        dgvHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.SelectionBackColor = Color.IndianRed
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        dgvHistory.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvHistory.RowTemplate.Height = 25
        dgvHistory.Size = New Size(993, 403)
        dgvHistory.TabIndex = 64
        dgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvHistory.ThemeStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvHistory.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvHistory.ThemeStyle.HeaderStyle.Height = 35
        dgvHistory.ThemeStyle.ReadOnly = False
        dgvHistory.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvHistory.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dgvHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvHistory.ThemeStyle.RowsStyle.Height = 25
        dgvHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' index
        ' 
        index.HeaderText = "#"
        index.Name = "index"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ISBN"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Book Name"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Issued By"
        Column3.Name = "Column3"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Action"
        Column5.Name = "Column5"
        ' 
        ' formHomePanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1074, 698)
        Controls.Add(dgvHistory)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "formHomePanel"
        StartPosition = FormStartPosition.CenterScreen
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalPatrons As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTotalUsers As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTotalIssuedBook As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalBooks As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents index As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
