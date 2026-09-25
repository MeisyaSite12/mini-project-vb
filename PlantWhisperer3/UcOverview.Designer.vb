<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcOverview
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pbOverview = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(pbOverview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 24
        Guna2Elipse1.TargetControl = Me
        ' 
        ' pbOverview
        ' 
        pbOverview.BorderRadius = 24
        pbOverview.CustomizableEdges = CustomizableEdges1
        pbOverview.ImageRotate = 0F
        pbOverview.Location = New Point(0, 0)
        pbOverview.Name = "pbOverview"
        pbOverview.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pbOverview.Size = New Size(248, 155)
        pbOverview.SizeMode = PictureBoxSizeMode.StretchImage
        pbOverview.TabIndex = 0
        pbOverview.TabStop = False
        ' 
        ' UcOverview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(228), CByte(233), CByte(226))
        Controls.Add(pbOverview)
        Name = "UcOverview"
        Size = New Size(248, 155)
        CType(pbOverview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pbOverview As Guna.UI2.WinForms.Guna2PictureBox

End Class
