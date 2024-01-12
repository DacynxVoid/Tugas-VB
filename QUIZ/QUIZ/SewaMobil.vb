Imports System.Reflection.Emit

Public Class RentalMobil
    Public hargamobil, hargalayanan As Integer

    Sub hitung()
        Dim lamasewa, jumlah As Integer

        lamasewa = Sewa.Text

        If ComLay.Text = "Dengan Supir" Then
            jumlah = (hargalayanan + hargamobil) * lamasewa
        Else
            jumlah = hargamobil * lamasewa
        End If

        SewaMobil2.Nama.Text = (Me.Nama.Text)
        SewaMobil2.Noiden.Text = (Me.Noiden.Text)
        SewaMobil2.NoHp.Text = (Me.NoHp.Text)
        SewaMobil2.JenisMobil.Text = (Me.ComMob.Text)
        SewaMobil2.Layanan.Text = (Me.ComLay.Text)
        SewaMobil2.Lama.Text = (Me.Sewa.Text) & " Hari"
        SewaMobil2.Total.Text = "Rp. " & jumlah
        SewaMobil2.Show()
    End Sub

    Sub cekdatakosong()
        If Nama.Text = "" Then
            MessageBox.Show("Data Nama harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Nama.Focus()
        ElseIf Noiden.Text = "" Then
            MessageBox.Show("Data Identitas harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Noiden.Focus()
        ElseIf NoHp.Text = "" Then
            MessageBox.Show("No HP harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NoHp.Focus()
        ElseIf ComMob.Text = "" Then
            MessageBox.Show("Jenis Kendaraan harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComMob.Focus()
        ElseIf ComLay.Text = "" Then
            MessageBox.Show("Data Layanan harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComLay.Focus()
        ElseIf Sewa.Text = "" Then
            MessageBox.Show("Lama Sewa harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Sewa.Focus()
        Else
            Call hitung()
        End If
    End Sub

    Private Sub ComMob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComMob.SelectedIndexChanged
        Select Case ComMob.Text
            Case " "
                Label9.Text = "Rp.-"
            Case "Toyota Avanza"
                Label9.Text = "Rp. 240.000 / hari"
                hargamobil = 240000
            Case "Toyota Calya"
                Label9.Text = "Rp. 210.000 / hari"
                hargamobil = 210000
            Case "Toyota Inova"
                Label9.Text = "Rp. 340.000 / hari"
                hargamobil = 340000
            Case "Daihatsu Xenia"
                Label9.Text = "Rp. 230.000 / hari"
                hargamobil = 230000
            Case "Daihatsu  Sigra"
                Label9.Text = "Rp. 200.000 / hari"
                hargamobil = 200000
            Case "Honda Brio"
                Label9.Text = "Rp. 230.000 / hari"
                hargamobil = 230000
            Case "Honda  Mobilio"
                Label9.Text = "Rp. 240.000 / hari"
                hargamobil = 240000
            Case "Mitsubishi Xpander"
                Label9.Text = "Rp. 300.000 / hari"
                hargamobil = 300000

        End Select
    End Sub

    Private Sub ComLay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComLay.SelectedIndexChanged
        Select Case ComLay.Text
            Case " "
                Label10.Text = "Rp -"
            Case "Lepas Kunci"
                Label10.Text = "Free"
            Case "Dengan Supir"
                Label10.Text = "Rp. 150.000 / hari"
                hargalayanan = 150000
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call cekdatakosong()
    End Sub


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Clear.Click
        Nama.Text = ""
        Noiden.Text = ""
        NoHp.Text = ""
        Sewa.Text = ""
        ComLay.Text = " "
        ComMob.Text = " "
    End Sub
End Class