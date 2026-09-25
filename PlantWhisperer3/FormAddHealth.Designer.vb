<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddHealth
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnClose = New Guna.UI2.WinForms.Guna2PictureBox()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnAddLog = New Guna.UI2.WinForms.Guna2Button()
        txtPlantName = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtDiagnose = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtPlantId = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpDate
        ' 
        dtpDate.BackColor = Color.White
        dtpDate.Checked = True
        dtpDate.CustomFormat = "ddd, d MMM yyyy"
        dtpDate.CustomizableEdges = CustomizableEdges1
        dtpDate.FillColor = Color.White
        dtpDate.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.Location = New Point(23, 162)
        dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDate.Name = "dtpDate"
        dtpDate.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        dtpDate.Size = New Size(209, 30)
        dtpDate.TabIndex = 19
        dtpDate.Value = New Date(2026, 6, 18, 0, 11, 35, 478)
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.CustomizableEdges = CustomizableEdges3
        btnClose.FillColor = Color.Transparent
        btnClose.Image = My.Resources.Resources.closes
        btnClose.ImageRotate = 0F
        btnClose.Location = New Point(336, 12)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnClose.Size = New Size(28, 23)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 18
        btnClose.TabStop = False
        btnClose.UseTransparentBackground = True
        ' 
        ' btnCancel
        ' 
        btnCancel.BorderColor = Color.FromArgb(CByte(157), CByte(176), CByte(150))
        btnCancel.BorderThickness = 1
        btnCancel.CustomizableEdges = CustomizableEdges5
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.FromArgb(CByte(248), CByte(251), CByte(249))
        btnCancel.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.FromArgb(CByte(157), CByte(176), CByte(150))
        btnCancel.Location = New Point(269, 286)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnCancel.Size = New Size(95, 32)
        btnCancel.TabIndex = 17
        btnCancel.Text = "Cancel"
        ' 
        ' btnAddLog
        ' 
        btnAddLog.CustomizableEdges = CustomizableEdges7
        btnAddLog.DisabledState.BorderColor = Color.DarkGray
        btnAddLog.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddLog.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddLog.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddLog.FillColor = Color.FromArgb(CByte(157), CByte(176), CByte(150))
        btnAddLog.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddLog.ForeColor = Color.White
        btnAddLog.Location = New Point(168, 286)
        btnAddLog.Name = "btnAddLog"
        btnAddLog.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAddLog.Size = New Size(95, 32)
        btnAddLog.TabIndex = 16
        btnAddLog.Text = "Add Log"
        ' 
        ' txtPlantName
        ' 
        txtPlantName.CustomizableEdges = CustomizableEdges9
        txtPlantName.DefaultText = ""
        txtPlantName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPlantName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPlantName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPlantName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPlantName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPlantName.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPlantName.ForeColor = Color.Black
        txtPlantName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPlantName.Location = New Point(23, 91)
        txtPlantName.Name = "txtPlantName"
        txtPlantName.PlaceholderText = ""
        txtPlantName.SelectedText = ""
        txtPlantName.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtPlantName.Size = New Size(209, 32)
        txtPlantName.TabIndex = 15
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel3.ForeColor = Color.Black
        Guna2HtmlLabel3.Location = New Point(23, 130)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(46, 26)
        Guna2HtmlLabel3.TabIndex = 14
        Guna2HtmlLabel3.Text = "Date :"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.Black
        Guna2HtmlLabel2.Location = New Point(23, 61)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(126, 26)
        Guna2HtmlLabel2.TabIndex = 13
        Guna2HtmlLabel2.Text = "Plant Name & ID"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Quicksand SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.Black
        Guna2HtmlLabel1.Location = New Point(95, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(181, 33)
        Guna2HtmlLabel1.TabIndex = 12
        Guna2HtmlLabel1.Text = "Plant Disease Log"
        ' 
        ' txtDiagnose
        ' 
        txtDiagnose.CustomizableEdges = CustomizableEdges11
        txtDiagnose.DefaultText = ""
        txtDiagnose.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtDiagnose.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtDiagnose.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtDiagnose.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtDiagnose.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtDiagnose.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDiagnose.ForeColor = Color.Black
        txtDiagnose.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtDiagnose.Location = New Point(23, 236)
        txtDiagnose.Name = "txtDiagnose"
        txtDiagnose.PlaceholderText = ""
        txtDiagnose.SelectedText = ""
        txtDiagnose.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txtDiagnose.Size = New Size(348, 32)
        txtDiagnose.TabIndex = 21
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel4.ForeColor = Color.Black
        Guna2HtmlLabel4.Location = New Point(23, 204)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(81, 26)
        Guna2HtmlLabel4.TabIndex = 20
        Guna2HtmlLabel4.Text = "Diagnose :"
        ' 
        ' txtPlantId
        ' 
        txtPlantId.CustomizableEdges = CustomizableEdges13
        txtPlantId.DefaultText = ""
        txtPlantId.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPlantId.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPlantId.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPlantId.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPlantId.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPlantId.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPlantId.ForeColor = Color.Black
        txtPlantId.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPlantId.Location = New Point(260, 91)
        txtPlantId.Name = "txtPlantId"
        txtPlantId.PlaceholderText = ""
        txtPlantId.SelectedText = ""
        txtPlantId.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        txtPlantId.Size = New Size(111, 32)
        txtPlantId.TabIndex = 22
        ' 
        ' Guna2HtmlLabel5
        ' 
        Guna2HtmlLabel5.BackColor = Color.Transparent
        Guna2HtmlLabel5.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel5.ForeColor = Color.Black
        Guna2HtmlLabel5.Location = New Point(241, 93)
        Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Guna2HtmlLabel5.Size = New Size(9, 26)
        Guna2HtmlLabel5.TabIndex = 23
        Guna2HtmlLabel5.Text = "-"
        ' 
        ' FormAddHealth
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(251), CByte(249))
        ClientSize = New Size(388, 330)
        Controls.Add(Guna2HtmlLabel5)
        Controls.Add(txtPlantId)
        Controls.Add(txtDiagnose)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(dtpDate)
        Controls.Add(btnClose)
        Controls.Add(btnCancel)
        Controls.Add(btnAddLog)
        Controls.Add(txtPlantName)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormAddHealth"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddLog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPlantName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDiagnose As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPlantId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
