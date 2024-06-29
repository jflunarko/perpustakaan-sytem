Imports System.Data.SqlClient

Public Class FrmKembali
    Dim conn As New SqlConnection
    Dim query As String
    Private nimMahasiswa As String

    ' Constructor to accept NIM
    Public Sub New(nim As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nimMahasiswa = nim
    End Sub

    ' Initialize the database connection
    Public Sub Connect()
        conn.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True"
    End Sub

    ' Load event for the form
    Private Sub FrmKembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        cmbKerusakan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKerusakan.Items.AddRange(New String() {"Tidak Ada", "Rusak", "Hilang"})
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

    ' Handle date selection event from the MonthCalendar
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        txtKembali.Text = e.Start.ToShortDateString()
        CalculateFine()
    End Sub

    ' Handle the selection change event for cmbKerusakan
    Private Sub cmbKerusakan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKerusakan.SelectedIndexChanged
        CalculateFine()
    End Sub

    ' Calculate the fine based on the return date and damage type
    Private Sub CalculateFine()
        ' Ensure the required fields are filled
        If String.IsNullOrEmpty(txtKembali.Text) OrElse String.IsNullOrEmpty(txtId.Text) Then
            txtDenda.Text = "Rp. 0"
            Return
        End If

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Fetch borrow details to calculate the due date
            query = "SELECT tgl_pinjam, durasi_pinjam FROM Pinjam WHERE id = @id_pinjam"
            Dim cmdFetchBorrow As New SqlCommand(query, conn)
            cmdFetchBorrow.Parameters.AddWithValue("@id_pinjam", txtId.Text)
            Dim drPinjam As SqlDataReader = cmdFetchBorrow.ExecuteReader()

            If drPinjam.HasRows Then
                drPinjam.Read()

                Dim tglPinjam As DateTime = DateTime.Parse(drPinjam("tgl_pinjam").ToString())
                Dim durasiPinjam As String = drPinjam("durasi_pinjam").ToString()

                Dim dueDate As DateTime

                ' Calculate the due date based on the borrow duration
                Select Case durasiPinjam
                    Case "1 Hari"
                        dueDate = tglPinjam.AddDays(1)
                    Case "2 Hari"
                        dueDate = tglPinjam.AddDays(2)
                    Case "3 Hari"
                        dueDate = tglPinjam.AddDays(3)
                    Case "4 Hari"
                        dueDate = tglPinjam.AddDays(4)
                    Case "5 Hari"
                        dueDate = tglPinjam.AddDays(5)
                    Case "6 Hari"
                        dueDate = tglPinjam.AddDays(6)
                    Case "7 Hari"
                        dueDate = tglPinjam.AddDays(7)
                    Case Else
                        dueDate = tglPinjam ' Default to borrow date if duration is not recognized
                End Select

                drPinjam.Close()

                Dim tglKembali As DateTime = DateTime.Parse(txtKembali.Text)
                Dim denda As Decimal = 0

                ' Check if the return date is after the due date
                If tglKembali > dueDate Then
                    denda += 15000 ' Add late fee of Rp. 15,000
                End If

                ' Add the fine based on damage type, if selected
                If cmbKerusakan.SelectedItem IsNot Nothing Then
                    Select Case cmbKerusakan.SelectedItem.ToString()
                        Case "Tidak Ada"
                            denda += 0
                        Case "Rusak"
                            denda += 15000
                        Case "Hilang"
                            denda += 50000
                    End Select
                End If

                txtDenda.Text = "Rp. " & denda.ToString("N0")
            Else
                drPinjam.Close()
                txtDenda.Text = "Rp. 0"
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            txtDenda.Text = "Rp. 0"
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Handle the return button click event
    Private Sub btnBalikin_Click(sender As Object, e As EventArgs) Handles btnBalikin.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim tglKembali As DateTime = DateTime.Parse(txtKembali.Text)
            Dim idPinjam As String = txtId.Text
            Dim jenisKerusakan As String = If(cmbKerusakan.SelectedItem IsNot Nothing, cmbKerusakan.SelectedItem.ToString(), "Tidak Ada")
            Dim denda As Decimal = Decimal.Parse(txtDenda.Text.Replace("Rp. ", "").Replace(".", ""))

            ' Begin a transaction
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                ' Check if the id_pinjam already exists in the Kembali table
                query = "SELECT COUNT(*) FROM Kembali WHERE id_pinjam = @id_pinjam"
                Dim cmdCheckDuplicate As New SqlCommand(query, conn, transaction)
                cmdCheckDuplicate.Parameters.AddWithValue("@id_pinjam", idPinjam)
                Dim count As Integer = Convert.ToInt32(cmdCheckDuplicate.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This book has already been returned.")
                    transaction.Rollback()
                    Return
                End If

                ' Insert return record into Kembali table
                query = "INSERT INTO Kembali (id_pinjam, nim_mahasiswa, tgl_kembali, jenis_kerusakan, denda) VALUES (@id_pinjam, @nim_mahasiswa, @tgl_kembali, @jenis_kerusakan, @denda)"
                Dim cmdKembali As New SqlCommand(query, conn, transaction)
                cmdKembali.Parameters.AddWithValue("@id_pinjam", idPinjam)
                cmdKembali.Parameters.AddWithValue("@nim_mahasiswa", nimMahasiswa)
                cmdKembali.Parameters.AddWithValue("@tgl_kembali", tglKembali)
                cmdKembali.Parameters.AddWithValue("@jenis_kerusakan", jenisKerusakan)
                cmdKembali.Parameters.AddWithValue("@denda", denda)
                cmdKembali.ExecuteNonQuery()

                ' Update the stock of the returned book
                query = "UPDATE Buku SET stock = stock + 1 WHERE kode_buku = (SELECT kode_buku FROM Pinjam WHERE id = @id_pinjam)"
                Dim cmdUpdateStock As New SqlCommand(query, conn, transaction)
                cmdUpdateStock.Parameters.AddWithValue("@id_pinjam", idPinjam)
                cmdUpdateStock.ExecuteNonQuery()

                ' Update the status of the borrow record
                query = "UPDATE Pinjam SET status = 'Selesai' WHERE id = @id_pinjam"
                Dim cmdUpdateStatus As New SqlCommand(query, conn, transaction)
                cmdUpdateStatus.Parameters.AddWithValue("@id_pinjam", idPinjam)
                cmdUpdateStatus.ExecuteNonQuery()

                ' Commit the transaction
                transaction.Commit()

                MessageBox.Show("Book has been returned")
                Clear()
                LoadPinjamData() ' Reload the borrowing data after returning the book
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Clear input fields
    Sub Clear()
        txtKembali.Text = ""
        txtId.Text = ""
        cmbKerusakan.SelectedIndex = -1
        txtDenda.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmMenu As New FrmMenu(nimMahasiswa)
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub linkPinjam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkPinjam.LinkClicked
        Dim frmPinjam As New FrmPinjam(nimMahasiswa)
        frmPinjam.Show()
        Me.Hide()

    End Sub
End Class
