<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogin
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formLogin))
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        tbLoginUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Check_showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        btm_login = New Guna.UI2.WinForms.Guna2Button()
        tbLoginPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Me
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(tbLoginUsername)
        Panel2.Controls.Add(Check_showpass)
        Panel2.Controls.Add(btm_login)
        Panel2.Controls.Add(tbLoginPassword)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(354, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(336, 370)
        Panel2.TabIndex = 35
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(77, 25)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(185, 107)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 49
        PictureBox2.TabStop = False
        ' 
        ' tbLoginUsername
        ' 
        tbLoginUsername.Animated = True
        tbLoginUsername.Cursor = Cursors.IBeam
        tbLoginUsername.CustomizableEdges = CustomizableEdges1
        tbLoginUsername.DefaultText = ""
        tbLoginUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbLoginUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbLoginUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLoginUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLoginUsername.FillColor = SystemColors.MenuBar
        tbLoginUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLoginUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbLoginUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLoginUsername.Location = New Point(53, 155)
        tbLoginUsername.Margin = New Padding(4, 3, 4, 3)
        tbLoginUsername.Name = "tbLoginUsername"
        tbLoginUsername.PasswordChar = ChrW(0)
        tbLoginUsername.PlaceholderText = "Username"
        tbLoginUsername.SelectedText = ""
        tbLoginUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        tbLoginUsername.Size = New Size(233, 42)
        tbLoginUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbLoginUsername.TabIndex = 47
        ' 
        ' Check_showpass
        ' 
        Check_showpass.Animated = True
        Check_showpass.AutoSize = True
        Check_showpass.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Check_showpass.CheckedState.BorderRadius = 3
        Check_showpass.CheckedState.BorderThickness = 0
        Check_showpass.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Check_showpass.Location = New Point(256, 227)
        Check_showpass.Margin = New Padding(4, 3, 4, 3)
        Check_showpass.Name = "Check_showpass"
        Check_showpass.Size = New Size(15, 14)
        Check_showpass.TabIndex = 43
        Check_showpass.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Check_showpass.UncheckedState.BorderRadius = 3
        Check_showpass.UncheckedState.BorderThickness = 0
        Check_showpass.UncheckedState.FillColor = Color.Silver
        ' 
        ' btm_login
        ' 
        btm_login.Animated = True
        btm_login.AnimatedGIF = True
        btm_login.BorderRadius = 5
        btm_login.CustomizableEdges = CustomizableEdges3
        btm_login.DisabledState.BorderColor = Color.DarkGray
        btm_login.DisabledState.CustomBorderColor = Color.DarkGray
        btm_login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btm_login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btm_login.FillColor = Color.Maroon
        btm_login.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btm_login.ForeColor = Color.White
        btm_login.Location = New Point(53, 275)
        btm_login.Margin = New Padding(4, 3, 4, 3)
        btm_login.Name = "btm_login"
        btm_login.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btm_login.Size = New Size(233, 37)
        btm_login.TabIndex = 42
        btm_login.Text = "Login"
        ' 
        ' tbLoginPassword
        ' 
        tbLoginPassword.Animated = True
        tbLoginPassword.Cursor = Cursors.IBeam
        tbLoginPassword.CustomizableEdges = CustomizableEdges5
        tbLoginPassword.DefaultText = ""
        tbLoginPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        tbLoginPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        tbLoginPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLoginPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        tbLoginPassword.FillColor = SystemColors.MenuBar
        tbLoginPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLoginPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbLoginPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        tbLoginPassword.Location = New Point(53, 212)
        tbLoginPassword.Margin = New Padding(4, 3, 4, 3)
        tbLoginPassword.Name = "tbLoginPassword"
        tbLoginPassword.PasswordChar = ChrW(0)
        tbLoginPassword.PlaceholderText = "Password"
        tbLoginPassword.SelectedText = ""
        tbLoginPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        tbLoginPassword.Size = New Size(233, 42)
        tbLoginPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        tbLoginPassword.TabIndex = 48
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(354, 370)
        Panel3.TabIndex = 36
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(354, 370)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(690, 370)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "formLogin"
        StartPosition = FormStartPosition.CenterScreen
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tbLoginUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Check_showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btm_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbLoginPassword As Guna.UI2.WinForms.Guna2TextBox
End Class
