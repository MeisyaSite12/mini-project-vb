Imports System.IO

Public Class UcOverview

    Private toolTipOverview As New ToolTip()
    Private tooltipText As String = ""

    Public Sub New()
        InitializeComponent()
        SetupHoverTooltip()
    End Sub

    Private Sub SetupHoverTooltip()
        toolTipOverview.AutoPopDelay = 5000
        toolTipOverview.InitialDelay = 200
        toolTipOverview.ReshowDelay = 100
        toolTipOverview.ShowAlways = True

        AddHandler pbOverview.MouseMove, AddressOf pbOverview_MouseMove
    End Sub

    Public Sub SetData(title As String, note As String, imageBytes As Byte())
        tooltipText = title & Environment.NewLine & """" & note & """"

        If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
            Using ms As New MemoryStream(imageBytes)
                pbOverview.Image = Image.FromStream(ms)
            End Using
            pbOverview.Refresh()
        End If
    End Sub

    Private lastTooltipPos As Point = Point.Empty

    Private Sub pbOverview_MouseMove(sender As Object, e As MouseEventArgs)
        If Math.Abs(e.X - lastTooltipPos.X) > 15 OrElse Math.Abs(e.Y - lastTooltipPos.Y) > 15 Then
            toolTipOverview.Show(tooltipText, pbOverview, e.X + 15, e.Y + 15, 3000)
            lastTooltipPos = New Point(e.X, e.Y)
        End If
    End Sub
End Class