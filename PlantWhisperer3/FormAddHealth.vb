Imports System.Data.SQLite

Public Class FormAddHealth
    Public LastInsertedId As Long = 0
    Public LastPlantName As String = ""
    Public LastPlantId As String = ""
    Public LastDate As String = ""
    Public LastDiagnose As String = ""

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddLog.Click
        If txtPlantName.Text = "" Or txtPlantId.Text = "" Or txtDiagnose.Text = "" Then
            MsgBox("Data tidak boleh kosong!")
            Return
        End If

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "INSERT INTO tb_disease_log (plant_name, plant_id, log_date, diagnose, status) 
                                 VALUES (@plant_name, @plant_id, @log_date, @diagnose, @status)"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@plant_name", txtPlantName.Text)
                cmd.Parameters.AddWithValue("@plant_id", txtPlantId.Text)
                cmd.Parameters.AddWithValue("@log_date", dtpDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@diagnose", txtDiagnose.Text)
                cmd.Parameters.AddWithValue("@status", "Sick")
                cmd.ExecuteNonQuery()
            End Using

            Using cmdId As New SQLiteCommand("SELECT last_insert_rowid()", conn)
                LastInsertedId = Convert.ToInt64(cmdId.ExecuteScalar())
            End Using
        End Using

        LastPlantName = txtPlantName.Text
        LastPlantId = txtPlantId.Text
        LastDate = dtpDate.Value.ToString("yyyy-MM-dd")
        LastDiagnose = txtDiagnose.Text


        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class