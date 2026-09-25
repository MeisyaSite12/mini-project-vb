Imports System.Data.SQLite

Public Class Gallery

    Private Sub Gallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UploadArea.Margin = New Padding(8)
        LoadGalleryCards()
    End Sub

    Private Sub Dashboard_MouseClick(sender As Object, e As MouseEventArgs) Handles Dashboard.MouseClick
        Dim form1 As New Dashboard()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub UploadArea_MouseClick(sender As Object, e As MouseEventArgs) Handles UploadArea.MouseClick
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            ofd.Title = "Pilih gambar"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim formUpload As New FormUpload(ofd.FileName)
                If formUpload.ShowDialog(Me) = DialogResult.OK Then
                    LoadGalleryCards()
                End If
            End If
        End Using
    End Sub

    Private Sub LoadGalleryCards(Optional keyword As String = "")
        FlowLayoutPanelGallery.Controls.Clear()
        FlowLayoutPanelGallery.Controls.Add(UploadArea)
        FlowLayoutPanelGallery.Controls.SetChildIndex(UploadArea, 0)

        Using conn As New SQLiteConnection(koneksiString)
            conn.Open()
            Dim sql As String = "SELECT * FROM tb_gallery"

            If keyword <> "" Then
                sql &= " WHERE judul LIKE @kw OR deskripsi LIKE @kw OR gallery_date LIKE @kw"
            End If
            sql &= " ORDER BY id DESC"

            Using cmd As New SQLiteCommand(sql, conn)
                If keyword <> "" Then
                    cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                End If

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim imgBytes As Byte() = DirectCast(reader("foto"), Byte())
                        TambahGalleryCard(
                            Convert.ToInt64(reader("id")),
                            reader("judul").ToString(),
                            reader("gallery_date").ToString(),
                            reader("deskripsi").ToString(),
                            imgBytes
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub TambahGalleryCard(id As Long, title As String, photoDate As String, note As String, imgBytes As Byte())
        Dim card As New UcGallery()
        card.SetData(id, title, photoDate, note, imgBytes)
        card.Margin = New Padding(8)

        AddHandler card.OnDeleted, Sub(galleryId As Long)
                                       LoadGalleryCards(txtSearch.Text.Trim())
                                   End Sub

        FlowLayoutPanelGallery.Controls.Add(card)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadGalleryCards(txtSearch.Text.Trim())
    End Sub

End Class