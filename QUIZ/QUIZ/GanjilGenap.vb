Public Class GanjilGenap

    Sub hitung()
        Dim i As Integer

        For i = TextBox1.Text To TextBox2.Text
            If i Mod 2 = 0 Then
                ListGenap.Items.Add(i)
                labelhasil.Text = "Angka " & i & " adalah bilangan Genap"
            Else
                ListGanjil.Items.Add(i)
                labelhasil.Text = "Angka " & i & " adalah bilangan Ganjil"
            End If

        Next
    End Sub

    Sub cekdatakosong()
        If TextBox1.Text = "" Then
            MessageBox.Show("Data harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Data harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
        Else
            Call hitung()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call cekdatakosong()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListGanjil.Items.Clear()
        ListGenap.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
End Class