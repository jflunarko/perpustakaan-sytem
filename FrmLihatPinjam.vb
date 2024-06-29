Imports System.Data.SqlClient

Public Class FrmLihatPinjam
    Dim conn As New SqlConnection
    Dim query As String
    Private nimMahasiswa As String

    ' Constructor to accept NIM
    Public Sub New(nim As String)
        InitializeComponent()
        nimMahasiswa = nim
        txtJudul.ReadOnly = True
        txtSisa.ReadOnly = True
    End Sub

    ' Initialize the database connection
    Public Sub Connect()
        conn.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True"
    End Sub

    ' Load event for the form
    Private Sub FrmLihatPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet9.Pinjam' table. You can move, or remove it, as needed.
        Me.PinjamTableAdapter1.Fill(Me.PerpustakaanDataSet9.Pinjam)
        Connect()
        LoadPinjamData() ' Load borrowing data when the form loads
    End Sub

    ' Load borrowing data into the DataGridView based on the logged-in NIM
    Private Sub LoadPinjamData()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT * FROM Pinjam WHERE nim_mahasiswa = @nim_mahasiswa"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nim_mahasiswa", nimMahasiswa)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvPinjam.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Handle the "Lihat Buku" button click event
    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        Try
            If txtId.Text.Trim() <> "" Then
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()

                ' Fetch borrow details based on the entered id_pinjam
                query = "SELECT * FROM Pinjam WHERE id = @id_pinjam AND nim_mahasiswa = @nim_mahasiswa"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id_pinjam", txtId.Text.Trim())
                cmd.Parameters.AddWithValue("@nim_mahasiswa", nimMahasiswa)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    Dim kodeBuku As String = reader("kode_buku").ToString()
                    Dim tglPinjam As DateTime = DateTime.Parse(reader("tgl_pinjam").ToString())
                    Dim durasiPinjam As Integer = Integer.Parse(reader("durasi_pinjam").ToString().Split(" "c)(0))
                    Dim tglKembali As DateTime = tglPinjam.AddDays(durasiPinjam)
                    Dim remainingDays As Integer = (tglKembali - DateTime.Today).Days
                    txtSisa.Text = remainingDays.ToString()

                    reader.Close()

                    ' Fetch book details based on the kode_buku
                    query = "SELECT * FROM Buku WHERE kode_buku = @kode_buku"
                    Dim cmdBuku As New SqlCommand(query, conn)
                    cmdBuku.Parameters.AddWithValue("@kode_buku", kodeBuku)
                    Dim readerBuku As SqlDataReader = cmdBuku.ExecuteReader()

                    If readerBuku.HasRows Then
                        readerBuku.Read()
                        txtJudul.Text = readerBuku("judul_buku").ToString()
                        readerBuku.Close()
                    Else
                        MessageBox.Show("No book found with the given code")
                    End If
                Else
                    MessageBox.Show("No borrowing record found with the given id")
                End If

                conn.Close()
            Else
                MessageBox.Show("Please enter an id")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmMenu As New FrmMenu(nimMahasiswa)
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Dim frmPinjam As New FrmPinjam(nimMahasiswa)
        frmPinjam.Show()
        Me.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim frmKembali As New FrmKembali(nimMahasiswa)
        frmKembali.Show()
        Me.Hide()
    End Sub

    Private Sub dgvPinjam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPinjam.CellContentClick

    End Sub
End Class