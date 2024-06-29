Imports System.Data.SqlClient

Public Class FrmPerpanjangMember
    Private nimMahasiswa As String
    Dim conn As New SqlConnection
    Dim query As String

    ' Constructor to accept NIM
    Public Sub New(nim As String)
        InitializeComponent()
        nimMahasiswa = nim
    End Sub

    ' Initialize the database connection
    Public Sub Connect()
        conn.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True"
    End Sub

    ' Load event for the form
    Private Sub FrmPerpanjangMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        cmbDurasi.Items.AddRange(New String() {"1 Bulan", "2 Bulan"})
        cmbDurasi.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    ' Handle selection change events for ComboBox
    Private Sub cmbDurasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDurasi.SelectedIndexChanged
        CalculateHarga()
    End Sub

    ' Calculate the price based on the selected duration
    Private Sub CalculateHarga()
        If cmbDurasi.SelectedIndex = -1 Then
            txtHarga.Text = ""
            Return
        End If

        Dim durasi As Integer
        Select Case cmbDurasi.SelectedItem.ToString()
            Case "1 Bulan"
                durasi = 1
            Case "2 Bulan"
                durasi = 2
        End Select

        ' Assuming the base price for extension is fixed, e.g., Rp. 50.000 per month
        Dim hargaPerBulan As Decimal = 50000
        Dim totalHarga As Decimal = hargaPerBulan * durasi
        txtHarga.Text = "Rp. " & totalHarga.ToString("N0")
    End Sub

    ' Handle the extend membership button click event
    Private Sub btnPerpanjang_Click(sender As Object, e As EventArgs) Handles btnPerpanjang.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim durasi As String = cmbDurasi.SelectedItem.ToString()
            Dim harga As Decimal = Decimal.Parse(txtHarga.Text.Replace("Rp. ", "").Replace(".", ""))

            ' Calculate additional sisa_waktu in months
            Dim additionalSisaWaktu As Integer
            Select Case durasi
                Case "1 Bulan"
                    additionalSisaWaktu = 1
                Case "2 Bulan"
                    additionalSisaWaktu = 2
            End Select

            ' Update the existing member data with the extended duration and price
            query = "UPDATE Member SET sisa_waktu = sisa_waktu + @additionalSisaWaktu, harga = harga + @harga WHERE nim = @nim AND status = 'Active'"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nim", nimMahasiswa)
            cmd.Parameters.AddWithValue("@additionalSisaWaktu", additionalSisaWaktu)
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Membership has been extended with a price of " & txtHarga.Text)
            Clear()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Clear input fields
    Sub Clear()
        cmbDurasi.SelectedIndex = -1
        txtHarga.Text = ""
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim frmMenu As New FrmMenu(nimMahasiswa)
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class
