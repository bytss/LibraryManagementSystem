<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managestock
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        btn_back = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewImageColumn()
        txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        combo_productGroup = New Guna.UI2.WinForms.Guna2ComboBox()
        btm_Print = New Guna.UI2.WinForms.Guna2Button()
        Btn_Export = New Guna.UI2.WinForms.Guna2Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btn_back)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1074, 69)
        Panel1.TabIndex = 10
        ' 
        ' btn_back
        ' 
        btn_back.Animated = True
        btn_back.AutoRoundedCorners = True
        btn_back.BorderRadius = 15
        btn_back.Cursor = Cursors.Hand
        btn_back.CustomizableEdges = CustomizableEdges1
        btn_back.DisabledState.BorderColor = Color.DarkGray
        btn_back.DisabledState.CustomBorderColor = Color.DarkGray
        btn_back.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_back.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_back.FillColor = Color.FromArgb(CByte(67), CByte(195), CByte(248))
        btn_back.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btn_back.ForeColor = Color.White
        btn_back.Location = New Point(47, 18)
        btn_back.Margin = New Padding(4, 3, 4, 3)
        btn_back.Name = "btn_back"
        btn_back.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btn_back.Size = New Size(33, 32)
        btn_back.TabIndex = 16
        btn_back.Text = "<"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Nirmala UI Semilight", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(128, 5)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(12, 12, 12, 12)
        Label1.Size = New Size(166, 52)
        Label1.TabIndex = 5
        Label1.Text = "Manage Stock"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = Color.DimGray
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column9, Column5, Column7, Column6, Column8})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Gray
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.GridColor = SystemColors.ControlLight
        DataGridView1.Location = New Point(86, 165)
        DataGridView1.Margin = New Padding(6, 6, 6, 6)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(864, 441)
        DataGridView1.TabIndex = 26
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "ProductCode"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 112
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "ProductName"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 71
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        Column9.DefaultCellStyle = DataGridViewCellStyle2
        Column9.HeaderText = "Stock Qty"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 92
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "UOM"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 64
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Location"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 84
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Price"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Visible = False
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Barcode"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Visible = False
        ' 
        ' txt_search
        ' 
        txt_search.Animated = True
        txt_search.Cursor = Cursors.IBeam
        txt_search.CustomizableEdges = CustomizableEdges3
        txt_search.DefaultText = ""
        txt_search.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_search.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_search.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_search.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_search.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_search.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txt_search.Location = New Point(435, 91)
        txt_search.Margin = New Padding(4, 3, 4, 3)
        txt_search.Name = "txt_search"
        txt_search.PasswordChar = ChrW(0)
        txt_search.PlaceholderText = "Search Here ..."
        txt_search.SelectedText = ""
        txt_search.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txt_search.Size = New Size(344, 42)
        txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txt_search.TabIndex = 29
        ' 
        ' combo_productGroup
        ' 
        combo_productGroup.BackColor = Color.Transparent
        combo_productGroup.CustomizableEdges = CustomizableEdges5
        combo_productGroup.DrawMode = DrawMode.OwnerDrawFixed
        combo_productGroup.DropDownStyle = ComboBoxStyle.DropDownList
        combo_productGroup.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        combo_productGroup.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        combo_productGroup.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        combo_productGroup.ForeColor = Color.DimGray
        combo_productGroup.FormattingEnabled = True
        combo_productGroup.ItemHeight = 30
        combo_productGroup.Items.AddRange(New Object() {"ALL", "Steel Tubes", "Steel Sheet", "Raw Material"})
        combo_productGroup.Location = New Point(88, 91)
        combo_productGroup.Margin = New Padding(4, 3, 4, 3)
        combo_productGroup.Name = "combo_productGroup"
        combo_productGroup.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        combo_productGroup.Size = New Size(304, 36)
        combo_productGroup.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        combo_productGroup.TabIndex = 30
        combo_productGroup.TextOffset = New Point(20, 0)
        ' 
        ' btm_Print
        ' 
        btm_Print.Animated = True
        btm_Print.AnimatedGIF = True
        btm_Print.BorderRadius = 5
        btm_Print.CustomizableEdges = CustomizableEdges7
        btm_Print.DisabledState.BorderColor = Color.DarkGray
        btm_Print.DisabledState.CustomBorderColor = Color.DarkGray
        btm_Print.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btm_Print.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btm_Print.FillColor = Color.FromArgb(CByte(67), CByte(195), CByte(248))
        btm_Print.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btm_Print.ForeColor = Color.White
        btm_Print.Location = New Point(850, 629)
        btm_Print.Margin = New Padding(4, 3, 4, 3)
        btm_Print.Name = "btm_Print"
        btm_Print.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btm_Print.Size = New Size(100, 37)
        btm_Print.TabIndex = 31
        btm_Print.Text = "Print"
        ' 
        ' Btn_Export
        ' 
        Btn_Export.Animated = True
        Btn_Export.AnimatedGIF = True
        Btn_Export.BorderRadius = 5
        Btn_Export.CustomizableEdges = CustomizableEdges9
        Btn_Export.DisabledState.BorderColor = Color.DarkGray
        Btn_Export.DisabledState.CustomBorderColor = Color.DarkGray
        Btn_Export.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Btn_Export.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Btn_Export.FillColor = Color.FromArgb(CByte(67), CByte(195), CByte(248))
        Btn_Export.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Export.ForeColor = Color.White
        Btn_Export.ImageAlign = HorizontalAlignment.Left
        Btn_Export.Location = New Point(726, 629)
        Btn_Export.Margin = New Padding(4, 3, 4, 3)
        Btn_Export.Name = "Btn_Export"
        Btn_Export.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Btn_Export.Size = New Size(100, 37)
        Btn_Export.TabIndex = 32
        Btn_Export.Text = "Export"
        ' 
        ' managestock
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1074, 698)
        Controls.Add(Btn_Export)
        Controls.Add(btm_Print)
        Controls.Add(combo_productGroup)
        Controls.Add(txt_search)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "managestock"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents combo_productGroup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btm_Print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Export As Guna.UI2.WinForms.Guna2Button
End Class
