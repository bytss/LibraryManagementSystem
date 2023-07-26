<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartment
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        labelClose = New Label()
        btn_save = New Guna.UI2.WinForms.Guna2Button()
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        tbDepartment = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(13, 14)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(12)
        Label1.Size = New Size(184, 52)
        Label1.TabIndex = 6
        Label1.Text = "Add Department"
        ' 
        ' labelClose
        ' 
        labelClose.AutoSize = True
        labelClose.Cursor = Cursors.Hand
        labelClose.FlatStyle = FlatStyle.Flat
        labelClose.Font = New Font("Nirmala UI Semilight", 8F, FontStyle.Bold, GraphicsUnit.Point)
        labelClose.ForeColor = Color.Maroon
        labelClose.Location = New Point(384, 10)
        labelClose.Margin = New Padding(4, 0, 4, 0)
        labelClose.Name = "labelClose"
        labelClose.Padding = New Padding(12)
        labelClose.Size = New Size(75, 37)
        labelClose.TabIndex = 7
        labelClose.Text = "[ close ]"
        ' 
        ' btn_save
        ' 
        btn_save.Animated = True
        btn_save.AnimatedGIF = True
        btn_save.BorderRadius = 5
        btn_save.CustomizableEdges = CustomizableEdges1
        btn_save.DisabledState.BorderColor = Color.DarkGray
        btn_save.DisabledState.CustomBorderColor = Color.DarkGray
        btn_save.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_save.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_save.FillColor = Color.Maroon
        btn_save.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_save.ForeColor = Color.White
        btn_save.Location = New Point(366, 69)
        btn_save.Margin = New Padding(4, 3, 4, 3)
        btn_save.Name = "btn_save"
        btn_save.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn_save.Size = New Size(100, 43)
        btn_save.TabIndex = 21
        btn_save.Text = "Save"
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.ShadowColor = Color.Silver
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Me
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2AnimateWindow1
        ' 
        Guna2AnimateWindow1.TargetForm = Me
        ' 
        ' tbDepartment
        ' 
        tbDepartment.Animated = True
        tbDepartment.Cursor = Cursors.IBeam
        tbDepartment.CustomizableEdges = CustomizableEdges3
        tbDepartment.DefaultText = ""
        tbDepartment.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbDepartment.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbDepartment.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbDepartment.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbDepartment.FillColor = SystemColors.Menu
        tbDepartment.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbDepartment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbDepartment.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbDepartment.Location = New Point(29, 69)
        tbDepartment.Margin = New Padding(4, 3, 4, 3)
        tbDepartment.Name = "tbDepartment"
        tbDepartment.PasswordChar = ChrW(0)
        tbDepartment.PlaceholderText = "Name"
        tbDepartment.SelectedText = ""
        tbDepartment.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        tbDepartment.Size = New Size(329, 42)
        tbDepartment.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbDepartment.TabIndex = 33
        ' 
        ' frmDepartment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(489, 159)
        Controls.Add(tbDepartment)
        Controls.Add(btn_save)
        Controls.Add(labelClose)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmDepartment"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents labelClose As Label
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents tbDepartment As Guna.UI2.WinForms.Guna2TextBox
End Class
