Public Class Nilai
    Sub hitung()
        Dim NilaiTGS As Byte
        Dim NilaiUTS As Byte
        Dim NilaiUAS As Byte
        Dim NilaiAKR As Byte
        Dim Stat As String

        NilaiTGS = Val(TGS.Text)
        NilaiTGS = (NilaiTGS * 20) / 100

        NilaiUTS = Val(UTS.Text)
        NilaiUTS = (NilaiUTS * 30) / 100

        NilaiUAS = Val(UAS.Text)
        NilaiUAS = (NilaiUAS * 50) / 100

        NilaiAKR = NilaiTGS + NilaiUTS + NilaiUAS

        If NilaiAKR >= 60 Then
            Stat = "Lulus"
        Else
            Stat = "Tidak Lulus"
        End If

        Dim list(4) As String
        list(0) = NIM.Text
        list(1) = Nama.Text
        list(2) = Kelas.Text
        list(3) = NilaiAKR
        list(4) = Stat

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(list(0))
        listitem.SubItems.Add(list(1))
        listitem.SubItems.Add(list(2))
        listitem.SubItems.Add(list(3))
        listitem.SubItems.Add(list(4))
        Nama.Text = ""
        NIM.Text = ""
        Kelas.Text = ""
        TGS.Text = ""
        UAS.Text = ""
        UTS.Text = ""
        Nama.Focus()
    End Sub
    Sub cekdatakosong()
        If NIM.Text = "" Then
            MessageBox.Show("NIM Harus di isi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NIM.Focus()
        ElseIf Nama.Text = "" Then
            MessageBox.Show("Nama Harus di isi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Nama.Focus()
        ElseIf Kelas.Text = "" Then
            MessageBox.Show("Kelas Harus di isi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Kelas.Focus()
        ElseIf TGS.Text = "" Then
            MessageBox.Show("Masukan Nilai Tugas terlebih dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TGS.Focus()
        ElseIf UAS.Text = "" Then
            MessageBox.Show("Masukan Nilai UAS terlebih dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UAS.Focus()
        ElseIf UTS.Text = "" Then
            MessageBox.Show("Masukan Nilai UTS terlebih dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UTS.Focus()
        Else
            Call hitung()
        End If
    End Sub

    Private Sub Nilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM", 100)
        ListView1.Columns.Add("NAMA", 100)
        ListView1.Columns.Add("KELAS", 100)
        ListView1.Columns.Add("NILAI", 50)
        ListView1.Columns.Add("STATUS", 100)
        Nama.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call cekdatakosong()
    End Sub


End Class