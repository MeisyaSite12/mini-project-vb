Imports System.Data.SQLite

Public Class UcHealthCard

    Public LogId As Long = 0
    Public Event OnHealed(id As Long)

    Public Sub SetData(id As Long, plantName As String, plantId As String, logDate As String, diagnose As String)
        Me.LogId = id

        lblTitle.Text = plantName & " - " & plantId

        Dim tgl As Date = Date.ParseExact(logDate, "yyyy-MM-dd", Nothing)
        lblDiagnose.Text = diagnose
        lblDate.Text = "- " & tgl.ToString("d MMMM")
    End Sub

    Private Sub cbHealth_CheckedChanged(sender As Object, e As EventArgs) Handles cbHealth.CheckedChanged
        If cbHealth.Checked Then
            ' Nonaktifkan checkbox supaya tidak diklik ulang selama jeda
            cbHealth.Enabled = False

            ' Update status ke DB segera (bukan tunggu timer, supaya konsisten kalau form ditutup duluan)
            Using conn As New SQLiteConnection(koneksiString)
                conn.Open()
                Using cmd As New SQLiteCommand("UPDATE tb_disease_log SET status = 'Healed' WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", LogId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Beri jeda visual sebelum card dihapus dari tampilan
            delayTimer.Interval = 5000   ' 2 detik, sesuaikan sesuai kebutuhan
            delayTimer.Start()
        End If
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        RaiseEvent OnHealed(LogId)
    End Sub

End Class