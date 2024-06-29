Imports System.Data.SqlClient
Imports System.Data

Public Class FrmPinjam
    Dim conn As New SqlConnection
    Dim query As String
    Private nimMahasiswa As String

    ' Constructor to accept NIM
    Public Sub New(nim As String)
        InitializeComponent()
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        nimMahasiswa = nim
    End Sub

    ' Initialize the database connection
    Public Sub Connect()
        conn.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True"
    End Sub

    ' Clear input fields
    Sub Clear()
        txtJudul.Text = ""
        txtPenulis.Text = ""
        txtKode.Text = ""
        txtPinjam.Text = ""
        ComboBox1.SelectedIndex = -1 ' Clear selected item in ComboBox
    End Sub

    ' Load event for the form
    Private Sub FrmPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        LoadAllData() ' Load all book data when the form loads
        Clear()
    End Sub

    ' Load all book data into the DataGridView
    Private Sub LoadAllData()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT * FROM Buku"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Handle search button click event
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT * FROM Buku WHERE judul_buku LIKE @judul_buku AND penulis LIKE @penulis"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@judul_buku", "%" & Trim(txtJudul.Text) & "%")
            cmd.Parameters.AddWithValue("@penulis", "%" & Trim(txtPenulis.Text) & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Handle borrow button click event
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Check if the student has already borrowed this book
            query = "SELECT * FROM Pinjam WHERE kode_buku = @kode_buku AND nim_mahasiswa = @nim_mahasiswa AND status = 'belum dikembalikkan'"
            Dim cmdCheckBorrow As New SqlCommand(query, conn)
            cmdCheckBorrow.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
            cmdCheckBorrow.Parameters.AddWithValue("@nim_mahasiswa", nimMahasiswa)
            Dim drBorrow As SqlDataReader = cmdCheckBorrow.ExecuteReader()

            If drBorrow.HasRows Then
                MessageBox.Show("You have already borrowed this book and have not returned it yet.")
                drBorrow.Close()
                conn.Close()
                Return
            End If
            drBorrow.Close()

            ' Check if the book is available
            query = "SELECT stock FROM Buku WHERE kode_buku = @kode_buku"
            Dim cmdCheck As New SqlCommand(query, conn)
            cmdCheck.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
            Dim drOpen As SqlDataReader = cmdCheck.ExecuteReader()

            If drOpen.HasRows Then
                drOpen.Read()
                Dim stock As Integer = Convert.ToInt32(drOpen("stock"))
                drOpen.Close()

                If stock > 0 Then
                    ' Insert borrow record into Pinjam table
                    Dim tglPinjam As DateTime = DateTime.Parse(txtPinjam.Text)
                    Dim durasiPinjam As String = ComboBox1.SelectedItem.ToString()

                    query = "INSERT INTO Pinjam (kode_buku, nim_mahasiswa, tgl_pinjam, durasi_pinjam, status) VALUES (@kode_buku, @nim_mahasiswa, @tgl_pinjam, @durasi_pinjam, 'Belum di Kembaliin')"
                    Dim cmdPinjam As New SqlCommand(query, conn)
                    cmdPinjam.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
                    cmdPinjam.Parameters.AddWithValue("@nim_mahasiswa", nimMahasiswa)
                    cmdPinjam.Parameters.AddWithValue("@tgl_pinjam", tglPinjam)
                    cmdPinjam.Parameters.AddWithValue("@durasi_pinjam", durasiPinjam)
                    cmdPinjam.ExecuteNonQuery()

                    ' Update the stock of the borrowed book
                    query = "UPDATE Buku SET stock = stock - 1 WHERE kode_buku = @kode_buku"
                    Dim cmdUpdateStock As New SqlCommand(query, conn)
                    cmdUpdateStock.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
                    cmdUpdateStock.ExecuteNonQuery()

                    MessageBox.Show("Book has been borrowed")
                    Clear()
                    LoadAllData() ' Refresh data grid
                Else
                    MessageBox.Show("Book is not available")
                End If
            Else
                MessageBox.Show("No book found with the given code")
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Handle date selection event from the MonthCalendar
    Private Sub monthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        txtPinjam.Text = e.Start.ToShortDateString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmMenu As New FrmMenu(nimMahasiswa)
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub linkLihat_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLihat.LinkClicked
        Dim frmLihatPinjam As New FrmLihatPinjam(nimMahasiswa)
        frmLihatPinjam.Show()
        Me.Hide()
    End Sub
End Class
