<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcGallery
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pbGallery = New Guna.UI2.WinForms.Guna2PictureBox()
        txtName = New Guna.UI2.WinForms.Guna2TextBox()
        txtNote = New Guna.UI2.WinForms.Guna2TextBox()
        CType(pbGallery, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 16
        Guna2Elipse1.TargetControl = Me
        ' 
        ' pbGallery
        ' 
        pbGallery.BackColor = Color.Transparent
        pbGallery.BorderRadius = 16
        pbGallery.CustomizableEdges = CustomizableEdges5
        pbGallery.FillColor = Color.Transparent
        pbGallery.ImageRotate = 0F
        pbGallery.Location = New Point(0, 0)
        pbGallery.Name = "pbGallery"
        pbGallery.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pbGallery.Size = New Size(284, 155)
        pbGallery.SizeMode = PictureBoxSizeMode.StretchImage
        pbGallery.TabIndex = 20
        pbGallery.TabStop = False
        pbGallery.UseTransparentBackground = True
        ' 
        ' txtName
        ' 
        txtName.BorderColor = Color.Empty
        txtName.BorderThickness = 0
        txtName.CustomizableEdges = CustomizableEdges3
        txtName.DefaultText = ""
        txtName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtName.FillColor = Color.FromArgb(CByte(228), CByte(233), CByte(226))
        txtName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtName.Font = New Font("Tahoma", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.ForeColor = Color.Black
        txtName.HoverState.BorderColor = Color.White
        txtName.Location = New Point(4, 161)
        txtName.Margin = New Padding(4)
        txtName.Name = "txtName"
        txtName.PlaceholderForeColor = Color.Black
        txtName.PlaceholderText = "Day 120 - Vibrant"
        txtName.ReadOnly = True
        txtName.SelectedText = ""
        txtName.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtName.Size = New Size(276, 30)
        txtName.TabIndex = 46
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNote
        ' 
        txtNote.BorderColor = Color.Empty
        txtNote.BorderThickness = 0
        txtNote.CustomizableEdges = CustomizableEdges1
        txtNote.DefaultText = ""
        txtNote.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtNote.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtNote.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNote.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNote.FillColor = Color.FromArgb(CByte(228), CByte(233), CByte(226))
        txtNote.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNote.Font = New Font("Tahoma", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNote.ForeColor = Color.Black
        txtNote.HoverState.BorderColor = Color.White
        txtNote.Location = New Point(4, 187)
        txtNote.Margin = New Padding(4)
        txtNote.Name = "txtNote"
        txtNote.PlaceholderForeColor = Color.Black
        txtNote.PlaceholderText = """To my beloved fruit"""
        txtNote.ReadOnly = True
        txtNote.SelectedText = ""
        txtNote.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtNote.Size = New Size(276, 30)
        txtNote.TabIndex = 47
        txtNote.TextAlign = HorizontalAlignment.Center
        ' 
        ' UcGallery
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(228), CByte(233), CByte(226))
        Controls.Add(txtNote)
        Controls.Add(txtName)
        Controls.Add(pbGallery)
        Margin = New Padding(3, 0, 3, 3)
        Name = "UcGallery"
        Size = New Size(284, 226)
        CType(pbGallery, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pbGallery As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNote As Guna.UI2.WinForms.Guna2TextBox

End Class
