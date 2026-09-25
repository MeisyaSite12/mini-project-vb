Imports System.Data.SQLite
Imports System.IO

Module DatabaseModule

    Public koneksiString As String = "Data Source=" & Application.StartupPath & "\plantwhisperer.db;Version=3;"

    Public Sub InitDatabase()
        Dim dbPath As String = Application.StartupPath & "\plantwhisperer.db"

        ' Buat file db kalau belum ada
        If Not File.Exists(dbPath) Then
            SQLiteConnection.CreateFile(dbPath)
        End If

        'Database Smart Care Reminder
        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "CREATE TABLE IF NOT EXISTS tb_tasks (
                                    id          INTEGER PRIMARY KEY AUTOINCREMENT,
                                    activity    TEXT NOT NULL,
                                    task_date   TEXT NOT NULL,
                                    task_time   TEXT NOT NULL,
                                    status      TEXT NOT NULL DEFAULT 'Upcoming'
                                 )"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        'Database Health Care Reminder
        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "CREATE TABLE IF NOT EXISTS tb_disease_log (
                                    id          INTEGER PRIMARY KEY AUTOINCREMENT,
                                    plant_name  TEXT NOT NULL,
                                    plant_id    TEXT NOT NULL,
                                    log_date    TEXT NOT NULL,
                                    diagnose    TEXT NOT NULL,
                                    status      TEXT NOT NULL DEFAULT 'Sick'
                                 )"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        'Database Gallery
        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "CREATE TABLE IF NOT EXISTS tb_gallery (
                                  id            INTEGER PRIMARY KEY AUTOINCREMENT,  
                                  judul         TEXT,  
                                  deskripsi     TEXT, 
                                  foto          BLOB,
                                  gallery_date  TEXT
                                 )"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

End Module
