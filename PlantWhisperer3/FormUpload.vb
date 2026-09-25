Imports System.Data.SQLite
Imports System.IO

Public Class FormUpload

    Public LastInsertedId As Long = 0
    Public LastTitle As String = ""
    Public LastDate As String = ""
    Public LastNote As String = ""
    Public LastImageBytes As Byte() = Nothing

    Private selectedFilePath As String = ""

    Public Sub New(filePath As String)
        InitializeComponent()
        selectedFilePath = filePath
    End Sub

    Private Sub btnAddPhoto_Click(sender As Object, e As EventArgs) Handles btnAddPhoto.Click
        If txtTitle.Text = "" Then
            MsgBox("Title tidak boleh kosong!")
            Return
        End If

        Dim imageBytes As Byte() = File.ReadAllBytes(selectedFilePath)

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "INSERT INTO tb_gallery (judul, gallery_date, deskripsi, foto) 
                                 VALUES (@judul, @gallery_date, @deskripsi, @foto)"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@judul", txtTitle.Text)
                cmd.Parameters.AddWithValue("@gallery_date", txtDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@deskripsi", txtNote.Text)
                cmd.Parameters.AddWithValue("@foto", imageBytes)
                cmd.ExecuteNonQuery()
            End Using

            Using cmdId As New SQLiteCommand("SELECT last_insert_rowid()", conn)
                LastInsertedId = Convert.ToInt64(cmdId.ExecuteScalar())
            End Using
        End Using

        LastTitle = txtTitle.Text
        LastDate = txtDate.Value.ToString("yyyy-MM-dd")
        LastNote = txtNote.Text
        LastImageBytes = imageBytes

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class