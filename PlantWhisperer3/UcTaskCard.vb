Imports System.Data.SQLite
Imports System.Diagnostics.Eventing.Reader

Public Class uc_task

    Public TaskId As Long = 0
    Public Event OnCardClicked(id As Long, activity As String, status As String)
    Public Event OnCardDeleted(id As Long)

    Private currentStatus As String = "Upcoming"

    Public Sub SetData(id As Long, activity As String, taskDate As String, taskTime As String, taskStatus As String)
        TaskId = id

        Dim tgl As Date = Date.ParseExact(taskDate, "yyyy-MM-dd", Nothing)
        numdate.Text = tgl.Day.ToString()
        daydate.Text = tgl.ToString("ddd")
        title.Text = activity
        time.Text = Date.ParseExact(taskTime, "HH:mm", Nothing).ToString("hh:mm tt")
        currentStatus = taskStatus
        SetStatus(currentStatus)
    End Sub

    Private Sub SetStatus(status As String)
        Select Case status
            Case "Upcoming"
                lblStatus.Text = "Upcoming"
                lblStatus.FillColor = Color.FromArgb(210, 221, 232)
                lblStatus.ForeColor = Color.FromArgb(73, 105, 184)
                title.Font = New Font(title.Font, FontStyle.Regular)

            Case "Cancelled"
                lblStatus.Text = "Cancelled"
                lblStatus.FillColor = Color.FromArgb(242, 211, 211)
                lblStatus.ForeColor = Color.FromArgb(219, 98, 99)
                title.Font = New Font(title.Font, FontStyle.Regular)

            Case "Completed"
                lblStatus.Text = "Completed"
                lblStatus.FillColor = Color.FromArgb(216, 237, 196)
                lblStatus.ForeColor = Color.FromArgb(127, 159, 96)
                title.Font = New Font(title.Font, FontStyle.Strikeout)
        End Select
    End Sub

    ' Klik kiri = cycle status: Upcoming -> Cancelled -> Completed
    Private Sub uc_task_Click(sender As Object, e As EventArgs) Handles Me.Click
        If delayTimer.Enabled Then Return   ' cegah klik berulang saat sudah dalam proses delay hapus

        Select Case currentStatus
            Case "Upcoming"
                currentStatus = "Cancelled"
                UpdateStatusDB("Cancelled")
                SetStatus("Cancelled")

            Case "Cancelled"
                currentStatus = "Completed"
                UpdateStatusDB("Completed")
                SetStatus("Completed")

                delayTimer.Interval = 5000
                delayTimer.Start()

            Case "Completed"

        End Select
    End Sub

    Private Sub UpdateStatusDB(newStatus As String)
        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Using cmd As New SQLiteCommand("UPDATE tb_tasks SET status = @status WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@id", TaskId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Using cmd As New SQLiteCommand("DELETE FROM tb_tasks WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@id", TaskId)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        RaiseEvent OnCardDeleted(TaskId)
    End Sub

    Private Sub uc_task_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim confirm = MsgBox("Hapus task ini?", MsgBoxStyle.YesNo, "Konfirmasi")
            If confirm = MsgBoxResult.Yes Then
                Using conn As New SQLiteConnection(koneksiString)
                    conn.Open()
                    Using cmd As New SQLiteCommand("DELETE FROM tb_tasks WHERE id = @id", conn)
                        cmd.Parameters.AddWithValue("@id", TaskId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                RaiseEvent OnCardDeleted(TaskId)
            End If
        End If
    End Sub

End Class