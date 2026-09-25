Imports System.Data.SQLite

Public Class FormAddTask

    Public LastInsertedId As Long = 0
    Public LastActivity As String = ""
    Public LastDate As String = ""
    Public LastTime As String = ""

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtActivity.Text = "" Then
            MsgBox("Activity tidak boleh kosong!")
            Return
        End If

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "INSERT INTO tb_tasks (activity, task_date, task_time, status) 
                                 VALUES (@activity, @task_date, @task_time, @status)"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@activity", txtActivity.Text)
                cmd.Parameters.AddWithValue("@task_date", txtDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@task_time", txtTime.Value.ToString("HH:mm"))
                cmd.Parameters.AddWithValue("@status", "Upcoming")
                cmd.ExecuteNonQuery()
            End Using

            Using cmdId As New SQLiteCommand("SELECT last_insert_rowid()", conn)
                LastInsertedId = Convert.ToInt64(cmdId.ExecuteScalar())
            End Using
        End Using

        ' Simpan data untuk di-pass ke UC
        LastActivity = txtActivity.Text
        LastDate = txtDate.Value.ToString("yyyy-MM-dd")
        LastTime = txtTime.Value.ToString("HH:mm")

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class