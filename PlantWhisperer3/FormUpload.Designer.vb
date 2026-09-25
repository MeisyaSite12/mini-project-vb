<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpload
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
        txtNote = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnClose = New Guna.UI2.WinForms.Guna2PictureBox()
        btnAddPhoto = New Guna.UI2.WinForms.Guna2Button()
        txtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtSource = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNote
        ' 
        txtNote.CustomizableEdges = CustomizableEdges1
        txtNote.DefaultText = ""
        txtNote.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtNote.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtNote.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNote.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNote.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNote.Font = New Font("Segoe UI", 9F)
        txtNote.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNote.Location = New Point(18, 229)
        txtNote.Multiline = True
        txtNote.Name = "txtNote"
        txtNote.PlaceholderText = ""
        txtNote.SelectedText = ""
        txtNote.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtNote.Size = New Size(348, 73)
        txtNote.TabIndex = 31
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel4.ForeColor = Color.Black
        Guna2HtmlLabel4.Location = New Point(18, 199)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(46, 26)
        Guna2HtmlLabel4.TabIndex = 30
        Guna2HtmlLabel4.Text = "Note :"
        ' 
        ' txtDate
        ' 
        txtDate.BackColor = Color.White
        txtDate.Checked = True
        txtDate.CustomFormat = "ddd, d MMM yyyy"
        txtDate.CustomizableEdges = CustomizableEdges3
        txtDate.FillColor = Color.White
        txtDate.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDate.Format = DateTimePickerFormat.Custom
        txtDate.Location = New Point(18, 159)
        txtDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        txtDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        txtDate.Name = "txtDate"
        txtDate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtDate.Size = New Size(209, 30)
        txtDate.TabIndex = 29
        txtDate.Value = New Date(2026, 6, 18, 0, 11, 35, 478)
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.CustomizableEdges = CustomizableEdges5
        btnClose.FillColor = Color.Transparent
        btnClose.Image = My.Resources.Resources.closes
        btnClose.ImageRotate = 0F
        btnClose.Location = New Point(340, 12)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnClose.Size = New Size(28, 23)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 28
        btnClose.TabStop = False
        btnClose.UseTransparentBackground = True
        ' 
        ' btnAddPhoto
        ' 
        btnAddPhoto.CustomizableEdges = CustomizableEdges7
        btnAddPhoto.DisabledState.BorderColor = Color.DarkGray
        btnAddPhoto.DisabledState.CustomBorderColor = Color.DarkGray
        btnAddPhoto.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAddPhoto.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAddPhoto.FillColor = Color.FromArgb(CByte(157), CByte(176), CByte(150))
        btnAddPhoto.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPhoto.ForeColor = Color.White
        btnAddPhoto.Location = New Point(18, 354)
        btnAddPhoto.Name = "btnAddPhoto"
        btnAddPhoto.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAddPhoto.Size = New Size(348, 32)
        btnAddPhoto.TabIndex = 26
        btnAddPhoto.Text = "Add a New Photo"
        ' 
        ' txtTitle
        ' 
        txtTitle.CustomizableEdges = CustomizableEdges9
        txtTitle.DefaultText = ""
        txtTitle.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtTitle.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtTitle.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTitle.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTitle.Font = New Font("Segoe UI", 9F)
        txtTitle.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTitle.Location = New Point(18, 92)
        txtTitle.Name = "txtTitle"
        txtTitle.PlaceholderText = ""
        txtTitle.SelectedText = ""
        txtTitle.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtTitle.Size = New Size(348, 30)
        txtTitle.TabIndex = 25
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel3.ForeColor = Color.Black
        Guna2HtmlLabel3.Location = New Point(18, 127)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(46, 26)
        Guna2HtmlLabel3.TabIndex = 24
        Guna2HtmlLabel3.Text = "Date :"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.Black
        Guna2HtmlLabel2.Location = New Point(18, 62)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(41, 26)
        Guna2HtmlLabel2.TabIndex = 23
        Guna2HtmlLabel2.Text = "Title :"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Quicksand SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.Black
        Guna2HtmlLabel1.Location = New Point(120, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(134, 33)
        Guna2HtmlLabel1.TabIndex = 22
        Guna2HtmlLabel1.Text = "Upload a File"
        ' 
        ' txtSource
        ' 
        txtSource.BackColor = Color.Transparent
        txtSource.Font = New Font("Quicksand", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSource.ForeColor = Color.Black
        txtSource.Location = New Point(18, 308)
        txtSource.Name = "txtSource"
        txtSource.Size = New Size(61, 26)
        txtSource.TabIndex = 32
        txtSource.Text = "Source :"
        ' 
        ' FormUpload
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(251), CByte(249))
        ClientSize = New Size(385, 398)
        Controls.Add(txtSource)
        Controls.Add(txtNote)
        Controls.Add(Guna2HtmlLabel4)
        Controls.Add(txtDate)
        Controls.Add(btnClose)
        Controls.Add(btnAddPhoto)
        Controls.Add(txtTitle)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormUpload"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNote As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnAddPhoto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSource As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
