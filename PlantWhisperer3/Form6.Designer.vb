<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnClose = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnHitung = New Guna.UI2.WinForms.Guna2Button()
        cbJenis = New ComboBox()
        cbPot = New ComboBox()
        cbCuaca = New ComboBox()
        txtHasil = New Guna.UI2.WinForms.Guna2TextBox()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.CustomizableEdges = CustomizableEdges1
        btnClose.FillColor = Color.Transparent
        btnClose.Image = My.Resources.Resources.closes
        btnClose.ImageRotate = 0F
        btnClose.Location = New Point(414, 12)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnClose.Size = New Size(28, 23)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 30
        btnClose.TabStop = False
        btnClose.UseTransparentBackground = True
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Quicksand SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.Black
        Guna2HtmlLabel1.Location = New Point(129, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(173, 33)
        Guna2HtmlLabel1.TabIndex = 29
        Guna2HtmlLabel1.Text = "Water Calculator"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.Black
        Guna2HtmlLabel2.Location = New Point(47, 63)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(125, 26)
        Guna2HtmlLabel2.TabIndex = 31
        Guna2HtmlLabel2.Text = "Jenis Tanaman :"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel3.ForeColor = Color.Black
        Guna2HtmlLabel3.Location = New Point(47, 105)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(68, 26)
        Guna2HtmlLabel3.TabIndex = 32
        Guna2HtmlLabel3.Text = "Pot Size :"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel4.ForeColor = Color.Black
        Guna2HtmlLabel4.Location = New Point(47, 148)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(57, 26)
        Guna2HtmlLabel4.TabIndex = 33
        Guna2HtmlLabel4.Text = "Cuaca :"
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel5.ForeColor = Color.Black
        Guna2HtmlLabel5.Location = New Point(47, 192)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(47, 26)
        Guna2HtmlLabel5.TabIndex = 34
        Guna2HtmlLabel5.Text = "Hasil :"
        ' 
        ' Guna2HtmlLabel7
        ' 
        Guna2HtmlLabel7.BackColor = Color.Transparent
        Guna2HtmlLabel7.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel7.Location = New Point(266, 200)
        Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Guna2HtmlLabel7.Size = New Size(31, 27)
        Guna2HtmlLabel7.TabIndex = 39
        Guna2HtmlLabel7.Text = "mL"
        ' 
        ' btnHitung
        ' 
        btnHitung.CustomizableEdges = CustomizableEdges3
        btnHitung.DisabledState.BorderColor = Color.DarkGray
        btnHitung.DisabledState.CustomBorderColor = Color.DarkGray
        btnHitung.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHitung.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHitung.FillColor = Color.FromArgb(CByte(157), CByte(176), CByte(150))
        btnHitung.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHitung.ForeColor = Color.White
        btnHitung.Location = New Point(335, 195)
        btnHitung.Name = "btnHitung"
        btnHitung.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnHitung.Size = New Size(95, 32)
        btnHitung.TabIndex = 40
        btnHitung.Text = "Hitung!"
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Items.AddRange(New Object() {"Sukulen", "Bunga", "Obat / Tropis", "Sayuran"})
        cbJenis.Location = New Point(181, 66)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(178, 23)
        cbJenis.TabIndex = 42
        ' 
        ' cbPot
        ' 
        cbPot.FormattingEnabled = True
        cbPot.Items.AddRange(New Object() {"Kecil (10-12 cm)", "Sedang (18-20 cm)", "Besar (25-30 cm)", "Ekstra Besar (40 cm)"})
        cbPot.Location = New Point(181, 108)
        cbPot.Name = "cbPot"
        cbPot.Size = New Size(249, 23)
        cbPot.TabIndex = 43
        ' 
        ' cbCuaca
        ' 
        cbCuaca.FormattingEnabled = True
        cbCuaca.Items.AddRange(New Object() {"Cerah ", "Mendung", "Kemarau", "Hujan"})
        cbCuaca.Location = New Point(181, 151)
        cbCuaca.Name = "cbCuaca"
        cbCuaca.Size = New Size(178, 23)
        cbCuaca.TabIndex = 44
        ' 
        ' txtHasil
        ' 
        txtHasil.CustomizableEdges = CustomizableEdges5
        txtHasil.DefaultText = ""
        txtHasil.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtHasil.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtHasil.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtHasil.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtHasil.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtHasil.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtHasil.HoverState.BorderColor = Color.White
        txtHasil.Location = New Point(181, 195)
        txtHasil.Margin = New Padding(4, 4, 4, 4)
        txtHasil.Name = "txtHasil"
        txtHasil.PlaceholderText = ""
        txtHasil.ReadOnly = True
        txtHasil.SelectedText = ""
        txtHasil.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtHasil.Size = New Size(78, 32)
        txtHasil.TabIndex = 45
        txtHasil.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(251), CByte(249))
        ClientSize = New Size(454, 255)
        Controls.Add(txtHasil)
        Controls.Add(cbCuaca)
        Controls.Add(cbPot)
        Controls.Add(cbJenis)
        Controls.Add(btnHitung)
        Controls.Add(Guna2HtmlLabel7)
        Controls.Add(Guna2HtmlLabel5)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(btnClose)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form6"
        Text = "Form6"
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnHitung As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents cbPot As ComboBox
    Friend WithEvents cbCuaca As ComboBox
    Friend WithEvents txtHasil As Guna.UI2.WinForms.Guna2TextBox
End Class
