﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPublisher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        Guna2ShadowForm2 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Label2 = New Label()
        Label1 = New Label()
        Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        tbName = New Guna.UI2.WinForms.Guna2TextBox()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(components)
        tbCountry = New Guna.UI2.WinForms.Guna2TextBox()
        tbContact = New Guna.UI2.WinForms.Guna2TextBox()
        tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        tbAddress = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.ShadowColor = Color.Silver
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.Interval = 250
        ' 
        ' Guna2ShadowForm2
        ' 
        Guna2ShadowForm2.ShadowColor = Color.Silver
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(414, 21)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(12)
        Label2.Size = New Size(88, 43)
        Label2.TabIndex = 45
        Label2.Text = "[ close ]"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(13, 21)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(12)
        Label1.Size = New Size(158, 52)
        Label1.TabIndex = 44
        Label1.Text = "Add Publisher"
        ' 
        ' Guna2AnimateWindow2
        ' 
        Guna2AnimateWindow2.Interval = 250
        ' 
        ' tbName
        ' 
        tbName.Animated = True
        tbName.Cursor = Cursors.IBeam
        tbName.CustomizableEdges = CustomizableEdges13
        tbName.DefaultText = ""
        tbName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbName.FillColor = SystemColors.Menu
        tbName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbName.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbName.Location = New Point(25, 78)
        tbName.Margin = New Padding(4, 3, 4, 3)
        tbName.Name = "tbName"
        tbName.PasswordChar = ChrW(0)
        tbName.PlaceholderText = "Name"
        tbName.SelectedText = ""
        tbName.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        tbName.Size = New Size(477, 42)
        tbName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbName.TabIndex = 47
        ' 
        ' btnSave
        ' 
        btnSave.Animated = True
        btnSave.AnimatedGIF = True
        btnSave.BorderRadius = 5
        btnSave.CustomizableEdges = CustomizableEdges15
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.Maroon
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(369, 256)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnSave.Size = New Size(133, 42)
        btnSave.TabIndex = 46
        btnSave.Text = "Save"
        ' 
        ' Guna2DragControl2
        ' 
        Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl2.UseTransparentDrag = True
        ' 
        ' tbCountry
        ' 
        tbCountry.Animated = True
        tbCountry.Cursor = Cursors.IBeam
        tbCountry.CustomizableEdges = CustomizableEdges17
        tbCountry.DefaultText = ""
        tbCountry.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbCountry.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbCountry.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCountry.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbCountry.FillColor = SystemColors.Menu
        tbCountry.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCountry.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbCountry.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbCountry.Location = New Point(369, 194)
        tbCountry.Margin = New Padding(4, 3, 4, 3)
        tbCountry.Name = "tbCountry"
        tbCountry.PasswordChar = ChrW(0)
        tbCountry.PlaceholderText = "Country"
        tbCountry.SelectedText = ""
        tbCountry.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        tbCountry.Size = New Size(133, 42)
        tbCountry.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbCountry.TabIndex = 53
        ' 
        ' tbContact
        ' 
        tbContact.Animated = True
        tbContact.Cursor = Cursors.IBeam
        tbContact.CustomizableEdges = CustomizableEdges19
        tbContact.DefaultText = ""
        tbContact.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbContact.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbContact.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbContact.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbContact.FillColor = SystemColors.Menu
        tbContact.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbContact.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbContact.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbContact.Location = New Point(274, 136)
        tbContact.Margin = New Padding(4, 3, 4, 3)
        tbContact.Name = "tbContact"
        tbContact.PasswordChar = ChrW(0)
        tbContact.PlaceholderText = "Contact"
        tbContact.SelectedText = ""
        tbContact.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        tbContact.Size = New Size(228, 42)
        tbContact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbContact.TabIndex = 52
        ' 
        ' tbEmail
        ' 
        tbEmail.Animated = True
        tbEmail.Cursor = Cursors.IBeam
        tbEmail.CustomizableEdges = CustomizableEdges21
        tbEmail.DefaultText = ""
        tbEmail.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbEmail.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbEmail.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbEmail.FillColor = SystemColors.Menu
        tbEmail.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbEmail.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbEmail.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbEmail.Location = New Point(25, 136)
        tbEmail.Margin = New Padding(4, 3, 4, 3)
        tbEmail.Name = "tbEmail"
        tbEmail.PasswordChar = ChrW(0)
        tbEmail.PlaceholderText = "Email"
        tbEmail.SelectedText = ""
        tbEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        tbEmail.Size = New Size(228, 42)
        tbEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbEmail.TabIndex = 48
        ' 
        ' tbAddress
        ' 
        tbAddress.Animated = True
        tbAddress.Cursor = Cursors.IBeam
        tbAddress.CustomizableEdges = CustomizableEdges23
        tbAddress.DefaultText = ""
        tbAddress.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbAddress.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbAddress.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbAddress.FillColor = SystemColors.Menu
        tbAddress.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbAddress.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbAddress.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbAddress.Location = New Point(25, 194)
        tbAddress.Margin = New Padding(4, 3, 4, 3)
        tbAddress.Name = "tbAddress"
        tbAddress.PasswordChar = ChrW(0)
        tbAddress.PlaceholderText = "Address"
        tbAddress.SelectedText = ""
        tbAddress.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        tbAddress.Size = New Size(336, 42)
        tbAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbAddress.TabIndex = 50
        ' 
        ' formPublisher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(545, 319)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbEmail)
        Controls.Add(tbName)
        Controls.Add(btnSave)
        Controls.Add(tbCountry)
        Controls.Add(tbContact)
        Controls.Add(tbAddress)
        FormBorderStyle = FormBorderStyle.None
        Name = "formPublisher"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ShadowForm2 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents tbName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents tbCountry As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbAddress As Guna.UI2.WinForms.Guna2TextBox
End Class
