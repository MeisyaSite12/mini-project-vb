<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_task
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
        time = New Guna.UI2.WinForms.Guna2HtmlLabel()
        title = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2vSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        numdate = New Guna.UI2.WinForms.Guna2TextBox()
        daydate = New Guna.UI2.WinForms.Guna2TextBox()
        lblStatus = New Guna.UI2.WinForms.Guna2TextBox()
        delayTimer = New Timer(components)
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 12
        Guna2Elipse1.TargetControl = Me
        ' 
        ' time
        ' 
        time.BackColor = Color.Transparent
        time.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        time.ForeColor = SystemColors.ControlDark
        time.Location = New Point(336, 45)
        time.Name = "time"
        time.Size = New Size(71, 21)
        time.TabIndex = 23
        time.Text = "12.10 am"
        ' 
        ' title
        ' 
        title.BackColor = Color.Transparent
        title.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.ForeColor = Color.Black
        title.Location = New Point(92, 12)
        title.Name = "title"
        title.Size = New Size(185, 27)
        title.TabIndex = 22
        title.Text = "Petik bunga mawar"
        ' 
        ' Guna2vSeparator1
        ' 
        Guna2vSeparator1.BackColor = Color.Transparent
        Guna2vSeparator1.FillColor = Color.FromArgb(CByte(212), CByte(210), CByte(210))
        Guna2vSeparator1.FillThickness = 2
        Guna2vSeparator1.Location = New Point(67, 9)
        Guna2vSeparator1.Name = "Guna2vSeparator1"
        Guna2vSeparator1.Size = New Size(10, 56)
        Guna2vSeparator1.TabIndex = 21
        ' 
        ' numdate
        ' 
        numdate.BorderColor = Color.Empty
        numdate.BorderThickness = 0
        numdate.CustomizableEdges = CustomizableEdges5
        numdate.DefaultText = ""
        numdate.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        numdate.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        numdate.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        numdate.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        numdate.FillColor = Color.FromArgb(CByte(241), CByte(244), CByte(242))
        numdate.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        numdate.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numdate.ForeColor = Color.Black
        numdate.HoverState.BorderColor = Color.White
        numdate.Location = New Point(6, 7)
        numdate.Margin = New Padding(7)
        numdate.Name = "numdate"
        numdate.PlaceholderForeColor = Color.Black
        numdate.PlaceholderText = "20"
        numdate.ReadOnly = True
        numdate.SelectedText = ""
        numdate.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        numdate.Size = New Size(58, 32)
        numdate.TabIndex = 47
        numdate.TextAlign = HorizontalAlignment.Center
        ' 
        ' daydate
        ' 
        daydate.BorderColor = Color.Empty
        daydate.BorderThickness = 0
        daydate.CustomizableEdges = CustomizableEdges3
        daydate.DefaultText = ""
        daydate.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        daydate.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        daydate.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        daydate.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        daydate.FillColor = Color.FromArgb(CByte(241), CByte(244), CByte(242))
        daydate.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        daydate.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        daydate.ForeColor = SystemColors.ActiveBorder
        daydate.HoverState.BorderColor = Color.White
        daydate.Location = New Point(7, 33)
        daydate.Margin = New Padding(7)
        daydate.Name = "daydate"
        daydate.PlaceholderForeColor = SystemColors.ActiveBorder
        daydate.PlaceholderText = "Fri"
        daydate.ReadOnly = True
        daydate.SelectedText = ""
        daydate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        daydate.Size = New Size(58, 32)
        daydate.TabIndex = 48
        daydate.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.FromArgb(CByte(241), CByte(244), CByte(242))
        lblStatus.BorderColor = Color.Empty
        lblStatus.BorderRadius = 8
        lblStatus.BorderThickness = 0
        lblStatus.CustomizableEdges = CustomizableEdges1
        lblStatus.DefaultText = ""
        lblStatus.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        lblStatus.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        lblStatus.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        lblStatus.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        lblStatus.FillColor = Color.FromArgb(CByte(210), CByte(221), CByte(232))
        lblStatus.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        lblStatus.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.ActiveBorder
        lblStatus.HoverState.BorderColor = Color.White
        lblStatus.Location = New Point(92, 45)
        lblStatus.Margin = New Padding(8)
        lblStatus.Name = "lblStatus"
        lblStatus.PlaceholderForeColor = Color.FromArgb(CByte(73), CByte(105), CByte(184))
        lblStatus.PlaceholderText = "Upcoming"
        lblStatus.ReadOnly = True
        lblStatus.SelectedText = ""
        lblStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        lblStatus.Size = New Size(90, 20)
        lblStatus.TabIndex = 49
        lblStatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' delayTimer
        ' 
        ' 
        ' uc_task
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(244), CByte(242))
        Controls.Add(lblStatus)
        Controls.Add(daydate)
        Controls.Add(numdate)
        Controls.Add(time)
        Controls.Add(title)
        Controls.Add(Guna2vSeparator1)
        Name = "uc_task"
        Size = New Size(427, 75)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents time As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents title As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2vSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents numdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents daydate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents delayTimer As Timer

End Class
