Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BookHotel
    Public hargakamar, hargalayanan As Integer


    Sub hitung()
        Dim lamainap, jumlah As Integer

        lamainap = Sewa.Text

        If ComLayan.Text = "Include Breakfast" Then
            jumlah = (hargalayanan + hargakamar) * lamainap
        Else
            jumlah = hargakamar * lamainap
        End If

        SewaHotel2.Nama.Text = (Me.Nama.Text)
        SewaHotel2.Noiden.Text = (Me.Noiden.Text)
        SewaHotel2.NoHp.Text = (Me.NoHp.Text)
        SewaHotel2.JenisKamar.Text = (Me.ComKam.Text)
        SewaHotel2.Layanan.Text = (Me.ComLayan.Text)
        SewaHotel2.Lama.Text = (Me.Sewa.Text) & " Hari"
        SewaHotel2.Total.Text = "Rp. " & jumlah
        SewaHotel2.Show()
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
        ElseIf ComKam.Text = "" Then
            MessageBox.Show("Jenis Kamar harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComKam.Focus()
        ElseIf ComLayan.Text = "" Then
            MessageBox.Show("Data Layanan harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComLayan.Focus()
        ElseIf Sewa.Text = "" Then
            MessageBox.Show("Lama Menginap harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Sewa.Focus()
        Else
            Call hitung()
        End If
    End Sub

    Private Sub ComKam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComKam.SelectedIndexChanged
        Select Case ComKam.Text
            Case " "
                Label9.Text = "Rp -"
            Case "Standard Room"
                Label9.Text = "Rp. 200.000"
                hargakamar = 200000
            Case "Superior Room"
                Label9.Text = "Rp. 300.000"
                hargakamar = 300000
            Case "Deluxe Room"
                Label9.Text = "Rp. 350.000"
                hargakamar = 350000
            Case "Suite Room"
                Label9.Text = "Rp. 550.000"
                hargakamar = 550000
        End Select

    End Sub

    Private Sub ComLayan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComLayan.SelectedIndexChanged
        Select Case ComLayan.Text
            Case " "
                Label10.Text = "Rp -"
            Case "Tanpa Breakfast"
                Label10.Text = "-"
            Case "Include Breakfast"
                If ComKam.Text = "Suite Room" And ComLayan.Text = "Include Breakfast" Then
                    Label10.Text = "Free"
                    hargalayanan = 0
                Else
                    Label10.Text = "Rp. 20.000 / hari"
                    hargalayanan = 20000
                End If


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
        ComLayan.Text = " "
        ComKam.Text = " "

    End Sub
End Class