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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        combo_user = New Guna.UI2.WinForms.Guna2ComboBox()
        txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        btm_login = New Guna.UI2.WinForms.Guna2Button()
        Check_showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = Me
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' combo_user
        ' 
        combo_user.BackColor = Color.Transparent
        combo_user.BorderRadius = 5
        combo_user.BorderThickness = 0
        combo_user.CustomizableEdges = CustomizableEdges11
        combo_user.DrawMode = DrawMode.OwnerDrawFixed
        combo_user.DropDownStyle = ComboBoxStyle.DropDownList
        combo_user.FillColor = SystemColors.Menu
        combo_user.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        combo_user.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        combo_user.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        combo_user.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        combo_user.ItemHeight = 30
        combo_user.Location = New Point(68, 130)
        combo_user.Margin = New Padding(4, 3, 4, 3)
        combo_user.Name = "combo_user"
        combo_user.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        combo_user.Size = New Size(233, 36)
        combo_user.TabIndex = 1
        combo_user.TextOffset = New Point(5, 0)
        ' 
        ' txt_password
        ' 
        txt_password.BorderRadius = 5
        txt_password.BorderThickness = 0
        txt_password.Cursor = Cursors.IBeam
        txt_password.CustomizableEdges = CustomizableEdges9
        txt_password.DefaultText = ""
        txt_password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.FillColor = SystemColors.Menu
        txt_password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_password.Location = New Point(68, 205)
        txt_password.Margin = New Padding(4, 3, 4, 3)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "●"c
        txt_password.PlaceholderText = ""
        txt_password.SelectedText = ""
        txt_password.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txt_password.Size = New Size(233, 42)
        txt_password.TabIndex = 2
        txt_password.TextOffset = New Point(5, 0)
        txt_password.UseSystemPasswordChar = True
        ' 
        ' btm_login
        ' 
        btm_login.Animated = True
        btm_login.AnimatedGIF = True
        btm_login.BorderRadius = 5
        btm_login.CustomizableEdges = CustomizableEdges7
        btm_login.DisabledState.BorderColor = Color.DarkGray
        btm_login.DisabledState.CustomBorderColor = Color.DarkGray
        btm_login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btm_login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btm_login.FillColor = Color.Maroon
        btm_login.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btm_login.ForeColor = Color.White
        btm_login.Location = New Point(117, 284)
        btm_login.Margin = New Padding(4, 3, 4, 3)
        btm_login.Name = "btm_login"
        btm_login.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btm_login.Size = New Size(142, 37)
        btm_login.TabIndex = 3
        btm_login.Text = "Login"
        ' 
        ' Check_showpass
        ' 
        Check_showpass.Animated = True
        Check_showpass.AutoSize = True
        Check_showpass.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Check_showpass.CheckedState.BorderRadius = 3
        Check_showpass.CheckedState.BorderThickness = 0
        Check_showpass.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Check_showpass.Location = New Point(273, 219)
        Check_showpass.Margin = New Padding(4, 3, 4, 3)
        Check_showpass.Name = "Check_showpass"
        Check_showpass.Size = New Size(15, 14)
        Check_showpass.TabIndex = 4
        Check_showpass.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Check_showpass.UncheckedState.BorderRadius = 3
        Check_showpass.UncheckedState.BorderThickness = 0
        Check_showpass.UncheckedState.FillColor = Color.Silver
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(112, 40)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 21)
        Label1.TabIndex = 5
        Label1.Text = "Login Here !"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(78, 107)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 6
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(78, 185)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(362, 6)
        Panel1.TabIndex = 8
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(362, 370)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Check_showpass)
        Controls.Add(btm_login)
        Controls.Add(txt_password)
        Controls.Add(combo_user)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "formLogin"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents combo_user As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Check_showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btm_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
End Class
