
Imports System.Data.SQLite

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDatabase()
        LoadCards(cmbFilter.SelectedItem.ToString())
        LoadHealthCards()
        LoadOverviewCards()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()
        LoadCards("All", keyword)
        LoadHealthCards(keyword)
        LoadOverviewCards(keyword)
    End Sub

    Private Sub LoadCards(Optional filter As String = "All", Optional keyword As String = "")
        FlowLayoutPanel1.Controls.Clear()

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "SELECT * FROM tb_tasks WHERE 1=1"

            If filter <> "All" Then
                sql &= " AND status = @status"
            End If

            If keyword <> "" Then
                sql &= " AND (activity LIKE @kw OR task_date LIKE @kw OR status LIKE @kw)"
            End If

            sql &= " ORDER BY task_date ASC"

            Using cmd As New SQLiteCommand(sql, conn)
                If filter <> "All" Then
                    cmd.Parameters.AddWithValue("@status", filter)
                End If
                If keyword <> "" Then
                    cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                End If

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        TambahCard(
                        Convert.ToInt64(reader("id")),
                        reader("activity").ToString(),
                        reader("task_date").ToString(),
                        reader("task_time").ToString(),
                        reader("status").ToString()
                    )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub TambahCard(id As Long, activity As String, taskDate As String, taskTime As String, status As String)
        Dim card As New uc_task()
        card.SetData(id, activity, taskDate, taskTime, status)

        AddHandler card.OnCardDeleted, Sub(taskId As Long)
                                           LoadCards()
                                       End Sub

        FlowLayoutPanel1.Controls.Add(card)
    End Sub

    Private Sub LoadHealthCards(Optional keyword As String = "")
        FlowLayoutPanelHealth.Controls.Clear()

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "SELECT * FROM tb_disease_log WHERE status = 'Sick'"

            If keyword <> "" Then
                sql &= " AND (plant_name LIKE @kw OR plant_id LIKE @kw OR diagnose LIKE @kw OR log_date LIKE @kw)"
            End If

            sql &= " ORDER BY log_date ASC"

            Using cmd As New SQLiteCommand(sql, conn)
                If keyword <> "" Then
                    cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                End If

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        TambahHealthCard(
                        Convert.ToInt64(reader("id")),
                        reader("plant_name").ToString(),
                        reader("plant_id").ToString(),
                        reader("log_date").ToString(),
                        reader("diagnose").ToString()
                    )
                    End While
                End Using
            End Using
        End Using

        UpdateSickCount()
    End Sub

    Private Sub TambahHealthCard(id As Long, plantName As String, plantId As String, logDate As String, diagnose As String)
        Dim card As New UcHealthCard()
        card.SetData(id, plantName, plantId, logDate, diagnose)

        AddHandler card.OnHealed, Sub(logId As Long)
                                      LoadHealthCards()
                                  End Sub

        FlowLayoutPanelHealth.Controls.Add(card)
    End Sub

    Private Sub UpdateSickCount()
        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Using cmd As New SQLiteCommand("SELECT COUNT(*) FROM tb_disease_log WHERE status = 'Sick'", conn)
                lblSickCount.Text = cmd.ExecuteScalar().ToString()
            End Using
        End Using
    End Sub

    Private Sub LoadOverviewCards(Optional keyword As String = "")
        FlowLayoutPanelOverview.Controls.Clear()

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "SELECT * FROM tb_gallery WHERE 1=1"

            If keyword <> "" Then
                sql &= " AND (judul LIKE @kw OR deskripsi LIKE @kw OR gallery_date LIKE @kw)"
            End If

            sql &= " ORDER BY id DESC LIMIT 5"

            Using cmd As New SQLiteCommand(sql, conn)
                If keyword <> "" Then
                    cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                End If

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim imgBytes As Byte() = DirectCast(reader("foto"), Byte())
                        TambahOverviewCard(
                        reader("judul").ToString(),
                        reader("deskripsi").ToString(),
                        imgBytes
                    )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub TambahOverviewCard(title As String, note As String, imgBytes As Byte())
        Dim card As New UcOverview()
        card.SetData(title, note, imgBytes)
        card.Margin = New Padding(8)
        FlowLayoutPanelOverview.Controls.Add(card)
    End Sub

    Private Sub toGallery_MouseClick(sender As Object, e As MouseEventArgs) Handles toGallery.MouseClick
        Dim form2 As New Gallery()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim form6 As New Form6()
        form6.Show()
    End Sub

    Private Sub btnPopTask_Click(sender As Object, e As EventArgs) Handles btnPopTask.Click
        Dim formAdd As New FormAddTask()
        If formAdd.ShowDialog(Me) = DialogResult.OK Then
            TambahCard(
            formAdd.LastInsertedId,
            formAdd.LastActivity,
            formAdd.LastDate,
            formAdd.LastTime,
            "Upcoming"
        )
        End If
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        Dim selected As String = cmbFilter.SelectedItem.ToString()
        LoadCards(selected)
    End Sub

    Private Sub btnPopHealth_Click(sender As Object, e As EventArgs) Handles btnPopHealth.Click
        Dim formLog As New FormAddHealth()
        If formLog.ShowDialog(Me) = DialogResult.OK Then
            TambahHealthCard(
            formLog.LastInsertedId,
            formLog.LastPlantName,
            formLog.LastPlantId,
            formLog.LastDate,
            formLog.LastDiagnose
        )
            UpdateSickCount()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class