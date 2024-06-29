Public Class FrmMaster
    Private Sub btnBuku_Click(sender As Object, e As EventArgs) Handles btnBuku.Click
        FrmBuku.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMahasiswa_Click(sender As Object, e As EventArgs) Handles btnMahasiswa.Click
        FrmMahasiswa.Show()
        Me.Hide()
    End Sub

    Private Sub btnDonatur_Click(sender As Object, e As EventArgs) Handles btnDonatur.Click
        FrmDonatur.Show()
        Me.Hide()

    End Sub



    Private Sub btnPenerbit_Click_1(sender As Object, e As EventArgs) Handles btnPenerbit.Click
        FrmPenerbit.Show()
        Me.Hide()

    End Sub

    Private Sub btnRuangan_Click(sender As Object, e As EventArgs) Handles btnRuangan.Click
        FrmRuangan.Show()
        Me.Hide()
    End Sub
End Class