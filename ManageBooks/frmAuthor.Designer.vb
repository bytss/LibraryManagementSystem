<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthor
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
        components = New ComponentModel.Container()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        btm_save = New Guna.UI2.WinForms.Guna2Button()
        txt_productcode = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        SuspendLayout()
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.TargetControl = Me
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.ShadowColor = Color.Silver
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' btm_save
        ' 
        btm_save.Animated = True
        btm_save.AnimatedGIF = True
        btm_save.BorderRadius = 5
        btm_save.CheckedState.Parent = btm_save
        btm_save.CustomImages.Parent = btm_save
        btm_save.DisabledState.BorderColor = Color.DarkGray
        btm_save.DisabledState.CustomBorderColor = Color.DarkGray
        btm_save.DisabledState.FillColor = Color.FromArgb(169, 169, 169)
        btm_save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141)
        btm_save.DisabledState.Parent = btm_save
        btm_save.FillColor = Color.FromArgb(67, 195, 248)
        btm_save.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btm_save.ForeColor = Color.White
        btm_save.HoverState.Parent = btm_save
        btm_save.Location = New Point(315, 67)
        btm_save.Name = "btm_save"
        btm_save.ShadowDecoration.Parent = btm_save
        btm_save.Size = New Size(86, 32)
        btm_save.TabIndex = 25
        btm_save.Text = "Save"
        ' 
        ' txt_productcode
        ' 
        txt_productcode.Animated = True
        txt_productcode.Cursor = Cursors.IBeam
        txt_productcode.DefaultText = ""
        txt_productcode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208)
        txt_productcode.DisabledState.FillColor = Color.FromArgb(226, 226, 226)
        txt_productcode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138)
        txt_productcode.DisabledState.Parent = txt_productcode
        txt_productcode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138)
        txt_productcode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
        txt_productcode.FocusedState.Parent = txt_productcode
        txt_productcode.Font = New Font("Segoe UI", 9F)
        txt_productcode.HoverState.BorderColor = Color.FromArgb(94, 148, 255)
        txt_productcode.HoverState.Parent = txt_productcode
        txt_productcode.Location = New Point(29, 63)
        txt_productcode.Margin = New Padding(80, 3, 3, 3)
        txt_productcode.Name = "txt_productcode"
        txt_productcode.Padding = New Padding(5, 0, 0, 0)
        txt_productcode.PasswordChar = ChrW(0)
        txt_productcode.PlaceholderText = "UOM"
        txt_productcode.SelectedText = ""
        txt_productcode.ShadowDecoration.Parent = txt_productcode
        txt_productcode.Size = New Size(267, 36)
        txt_productcode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txt_productcode.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Nirmala UI Semilight", 8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.ForeColor = Color.FromArgb(67, 195, 248)
        Label2.Location = New Point(330, 9)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(10)
        Label2.Size = New Size(71, 33)
        Label2.TabIndex = 23
        Label2.Text = "[ close ]"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Nirmala UI Semilight", 10F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10)
        Label1.Size = New Size(132, 39)
        Label1.TabIndex = 22
        Label1.Text = "Add New UOM"
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.Interval = 250
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' uomfrm
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(406, 120)
        Controls.Add(btm_save)
        Controls.Add(txt_productcode)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "uomfrm"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_productcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
