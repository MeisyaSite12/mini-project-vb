Public Class Form6
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If (cbPot.SelectedIndex = -1 Or cbJenis.SelectedIndex = -1 Or cbCuaca.SelectedIndex = -1) Then
            MsgBox("Data tidak boleh kosong!")
        Else
            Dim refPenyiraman(,) As Double = {
                  {50, 250, 700, 1500},    ' Baris 0: Sukulen
                  {75, 375, 1050, 2250},   ' Baris 1: Bunga
                  {100, 500, 1400, 3000},  ' Baris 2: TOGA/Tropis
                  {125, 625, 1750, 3750}   ' Baris 3: Sayur
             }

            Dim barisTanaman = cbJenis.SelectedIndex
            Dim kolomPot = cbPot.SelectedIndex
            Dim cuaca = cbCuaca.GetItemText(cbCuaca.SelectedItem)

            Dim namaTanaman = ""
            Select Case barisTanaman
                Case 0 : namaTanaman = "Sukulen"
                Case 1 : namaTanaman = "Bunga"
                Case 2 : namaTanaman = "TOGA / Tropis"
                Case 3 : namaTanaman = "Sayuran"
            End Select

            Dim ukuranPot = ""
            Select Case kolomPot
                Case 0 : ukuranPot = "Kecil (10-12 cm)"
                Case 1 : ukuranPot = "Sedang (18-20 cm)"
                Case 2 : ukuranPot = "Besar (25-30 cm)"
                Case 3 : ukuranPot = "Ekstra Besar (40 cm)"
            End Select

            Dim hasilAir = refPenyiraman(barisTanaman, kolomPot)

            If cuaca = "Mendung" OrElse cuaca = "Hujan" Then
                hasilAir *= 0.5
            ElseIf cuaca = "Kemarau" Then
                hasilAir *= 1.2
            Else
                hasilAir *= 1.0
            End If

            txtHasil.Text = hasilAir.ToString
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class