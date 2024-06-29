Public Class FrmMenu
    Private nimMahasiswa As String
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Dim frmPinjam As New FrmPinjam(nimMahasiswa)
        frmPinjam.Show()
        Me.Hide()
    End Sub
    ' Constructor to accept NIM
    Public Sub New(nim As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nimMahasiswa = nim
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim frmKembali As New FrmKembali(nimMahasiswa)
        frmKembali.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmLihatPinjam As New FrmLihatPinjam(nimMahasiswa)
        frmLihatPinjam.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        FrmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        Dim frmMember As New FrmMember(nimMahasiswa)
        frmMember.Show()
        Me.Hide()
    End Sub
    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Dim frmDonasi As New FrmDonasi(nimMahasiswa)
        frmDonasi.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Dim frmBooking As New FrmBooking(nimMahasiswa)
        frmBooking.Show()
        Me.Hide()

    End Sub

    Private Sub btnPerpanjang_Click(sender As Object, e As EventArgs) Handles btnPerpanjang.Click
        Dim FrmPerpanjangMember As New FrmPerpanjangMember(nimMahasiswa)
        FrmPerpanjangMember.Show()
        Me.Hide()
    End Sub
End Class