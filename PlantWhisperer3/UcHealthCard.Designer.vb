<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcHealthCard
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
        cbHealth = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblDiagnose = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        delayTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' cbHealth
        ' 
        cbHealth.CheckedState.BorderColor = Color.DarkGray
        cbHealth.CheckedState.BorderRadius = 2
        cbHealth.CheckedState.BorderThickness = 0
        cbHealth.CheckedState.FillColor = Color.FromArgb(CByte(157), CByte(176), CByte(150))
        cbHealth.CustomizableEdges = CustomizableEdges1
        cbHealth.Location = New Point(55, 14)
        cbHealth.Name = "cbHealth"
        cbHealth.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cbHealth.Size = New Size(20, 20)
        cbHealth.TabIndex = 24
        cbHealth.Text = "Guna2CustomCheckBox1"
        cbHealth.UncheckedState.BorderColor = Color.DarkGray
        cbHealth.UncheckedState.BorderRadius = 2
        cbHealth.UncheckedState.BorderThickness = 2
        cbHealth.UncheckedState.FillColor = Color.Transparent
        ' 
        ' lblDate
        ' 
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.Black
        lblDate.Location = New Point(237, 26)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(70, 21)
        lblDate.TabIndex = 23
        lblDate.Text = "- 10 June "
        ' 
        ' lblDiagnose
        ' 
        lblDiagnose.BackColor = Color.Transparent
        lblDiagnose.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDiagnose.ForeColor = SystemColors.ControlDark
        lblDiagnose.Location = New Point(97, 26)
        lblDiagnose.Name = "lblDiagnose"
        lblDiagnose.Size = New Size(128, 21)
        lblDiagnose.TabIndex = 22
        lblDiagnose.Text = "Pembusukan akar  "
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(97, 4)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(134, 21)
        lblTitle.TabIndex = 21
        lblTitle.Text = "Water Lily - P0001"
        ' 
        ' UcHealthCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(cbHealth)
        Controls.Add(lblDate)
        Controls.Add(lblDiagnose)
        Controls.Add(lblTitle)
        Name = "UcHealthCard"
        Size = New Size(362, 50)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbHealth As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDiagnose As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents delayTimer As Timer

End Class
