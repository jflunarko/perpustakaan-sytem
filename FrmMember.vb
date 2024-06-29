Imports System.Data.SqlClient

Public Class FrmMember
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

    ' Clear input fields
    Sub Clear()
        cmbPaket.Text = ""
        cmbDurasi.Text = ""
        txtHarga.Text = ""
    End Sub

    ' Load event for the form
    Private Sub FrmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        Clear()
        cmbPaket.Items.AddRange(New String() {"Basic", "VIP", "Deluxe"})
        cmbDurasi.Items.AddRange(New String() {"1 Bulan", "2 Bulan", "3 Bulan", "1 Tahun"})

        ' Set ComboBox styles
        cmbPaket.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDurasi.DropDownStyle = ComboBoxStyle.DropDownList

        CheckExistingMembership()
    End Sub

    ' Check if the student is already registered
    Private Sub CheckExistingMembership()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT COUNT(*) FROM Member WHERE nim = @nim AND status = 'Active'"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nim", nimMahasiswa)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("You are already registered.")
                DisableRegistration()
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Disable the registration fields and button
    Private Sub DisableRegistration()
        cmbPaket.Enabled = False
        cmbDurasi.Enabled = False
        txtHarga.Enabled = False
        btnDaftar.Enabled = False
    End Sub

    ' Enable the registration fields and button
    Private Sub EnableRegistration()
        cmbPaket.Enabled = True
        cmbDurasi.Enabled = True
        btnDaftar.Enabled = True
    End Sub

    ' Handle selection change events for ComboBoxes
    Private Sub cmbPaket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaket.SelectedIndexChanged, cmbDurasi.SelectedIndexChanged
        CalculateHarga()
    End Sub

    ' Calculate the price based on the selected package and duration
    Private Sub CalculateHarga()
        If cmbPaket.SelectedIndex = -1 OrElse cmbDurasi.SelectedIndex = -1 Then
            txtHarga.Text = ""
            Return
        End If

        Dim hargaPaket As Decimal
        Select Case cmbPaket.SelectedItem.ToString()
            Case "Basic"
                hargaPaket = 50000
            Case "VIP"
                hargaPaket = 100000
            Case "Deluxe"
                hargaPaket = 150000
        End Select

        Dim durasi As Integer
        Select Case cmbDurasi.SelectedItem.ToString()
            Case "1 Bulan"
                durasi = 1
            Case "2 Bulan"
                durasi = 2
            Case "3 Bulan"
                durasi = 3
            Case "1 Tahun"
                durasi = 12
        End Select

        Dim totalHarga As Decimal = hargaPaket * durasi
        txtHarga.Text = "Rp. " & totalHarga.ToString("N0")
    End Sub

    ' Handle the registration button click event
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim paket As String = cmbPaket.SelectedItem.ToString()
            Dim durasi As String = cmbDurasi.SelectedItem.ToString()
            Dim harga As Decimal = Decimal.Parse(txtHarga.Text.Replace("Rp. ", "").Replace(".", ""))

            ' Calculate sisa_waktu in months
            Dim sisaWaktu As Integer
            Select Case durasi
                Case "1 Bulan"
                    sisaWaktu = 1
                Case "2 Bulan"
                    sisaWaktu = 2
                Case "3 Bulan"
                    sisaWaktu = 3
                Case "1 Tahun"
                    sisaWaktu = 12
            End Select

            ' Insert the new member data into the Member table
            query = "INSERT INTO Member (nim, paket, waktu, harga, sisa_waktu, status) VALUES (@nim, @paket, @durasi, @harga, @sisa_waktu, 'Active')"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nim", nimMahasiswa)
            cmd.Parameters.AddWithValue("@paket", paket)
            cmd.Parameters.AddWithValue("@durasi", durasi)
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@sisa_waktu", sisaWaktu)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Pendaftaran berhasil dengan harga " & txtHarga.Text)
            Clear()
            DisableRegistration()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Handle the cancel membership button click event
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Update the member status to 'Cancelled'
            query = "UPDATE Member SET status = 'Cancelled' WHERE nim = @nim AND status = 'Active'"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nim", nimMahasiswa)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Membership has been cancelled.")
            Clear()
            EnableRegistration()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnPerpanjang_Click(sender As Object, e As EventArgs) Handles btnPerpanjang.Click
        Dim FrmPerpanjangMember As New FrmPerpanjangMember(nimMahasiswa)
        FrmPerpanjangMember.Show()
        Me.Hide()
    End Sub
End Class
