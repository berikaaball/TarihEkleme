Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim veritipi As String() = {"Gün", "Hafta", "Ay", "Yıl"}
        CBoxTip.Items.AddRange(veritipi)
    End Sub

    Private Sub BtnTarihEkle_Click(sender As Object, e As EventArgs) Handles BtnTarihEkle.Click
        Dim ilktarih, sonuctarih As Date
        Dim tip As String
        Dim veri As Double

        ilktarih = DTPİlkTarih.Value
        tip = CBoxTip.Items.ToString()
        veri = TBoxVeri.Text

        Select Case CBoxTip.SelectedItem
            Case "Gün"
                sonuctarih = DateAdd(DateInterval.Day, veri, ilktarih)
            Case "Hafta"
                sonuctarih = DateAdd(DateInterval.WeekOfYear, veri, ilktarih)
            Case "Ay"
                sonuctarih = DateAdd(DateInterval.Month, veri, ilktarih)
            Case "Yıl"
                sonuctarih = DateAdd(DateInterval.Year, veri, ilktarih)
            Case Else
                MessageBox.Show("Bir veri tipi seçtiğinizden emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        DTPSonTarih.Value = sonuctarih

    End Sub
End Class
