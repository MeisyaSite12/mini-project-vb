Imports System.Data.SQLite
Imports System.IO

Public Class UcGallery

    Public GalleryId As Long = 0
    Public Event OnDeleted(id As Long)

    Public Sub SetData(id As Long, title As String, photoDate As String, note As String, imageBytes As Byte())
        Me.GalleryId = id

        txtName.Text = title
        txtNote.Text = """" & note & """"

        If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
            Using ms As New MemoryStream(imageBytes)
                pbGallery.Image = Image.FromStream(ms)
            End Using
        End If
    End Sub

    Private Sub pbGallery_MouseClick(sender As Object, e As MouseEventArgs) Handles pbGallery.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim confirm = MsgBox("Hapus foto ini?", MsgBoxStyle.YesNo, "Konfirmasi")
            If confirm = MsgBoxResult.Yes Then
                Using conn As New SQLiteConnection(koneksiString)
                    conn.Open()
                    Using cmd As New SQLiteCommand("DELETE FROM tb_gallery WHERE id = @id", conn)
                        cmd.Parameters.AddWithValue("@id", GalleryId)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                RaiseEvent OnDeleted(GalleryId)
            End If
        End If
    End Sub

End Class