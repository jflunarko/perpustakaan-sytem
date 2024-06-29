Imports System.Data.SqlClient
Imports System.Data

Public Class FrmBuku
    Dim conn As New SqlConnection
    Dim query As String

    Public Sub Connect()
        conn.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True"
    End Sub

    Sub Clear()
        txtKode.Text = ""
        txtJudul.Text = ""
        txtPenulis.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub FrmBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet9.Buku' table. You can move, or remove it, as needed.
        Me.BukuTableAdapter.Fill(Me.PerpustakaanDataSet9.Buku)

        Connect()
        LoadAllData() ' Load all data when the form loads
        Clear()
    End Sub

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

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Check if the record exists
            Dim cmdCheck As New SqlCommand("SELECT * FROM Buku WHERE kode_buku = @kode_buku", conn)
            cmdCheck.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
            Dim drOpen As SqlDataReader = cmdCheck.ExecuteReader()

            If drOpen.HasRows Then
                MessageBox.Show("Record already exists. Use the Update button to modify the record.")
            Else
                ' Insert new record
                query = "INSERT INTO Buku (kode_buku, judul_buku, stock, penulis) VALUES (@kode_buku, @judul_buku, @stock, @penulis)"
                drOpen.Close()

                ' Execute Insert command
                Dim cmdSave As New SqlCommand(query, conn)
                cmdSave.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
                cmdSave.Parameters.AddWithValue("@judul_buku", Trim(txtJudul.Text))
                cmdSave.Parameters.AddWithValue("@stock", CInt(Trim(txtStock.Text)))
                cmdSave.Parameters.AddWithValue("@penulis", Trim(txtPenulis.Text))
                cmdSave.ExecuteNonQuery()

                MessageBox.Show("Data Has Been Saved")
                Clear()
                txtKode.Select()
                LoadAllData() ' Refresh data grid
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Check if the record exists
            Dim cmdCheck As New SqlCommand("SELECT * FROM Buku WHERE kode_buku = @kode_buku", conn)
            cmdCheck.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
            Dim drOpen As SqlDataReader = cmdCheck.ExecuteReader()

            If drOpen.HasRows Then
                drOpen.Close()

                ' Update existing record
                query = "UPDATE Buku SET " &
                        "judul_buku = @judul_buku, " &
                        "stock = @stock, " &
                        "penulis = @penulis " &
                        "WHERE kode_buku = @kode_buku"

                ' Execute Update command
                Dim cmdUpdate As New SqlCommand(query, conn)
                cmdUpdate.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
                cmdUpdate.Parameters.AddWithValue("@judul_buku", Trim(txtJudul.Text))
                cmdUpdate.Parameters.AddWithValue("@stock", CInt(Trim(txtStock.Text)))
                cmdUpdate.Parameters.AddWithValue("@penulis", Trim(txtPenulis.Text))
                cmdUpdate.ExecuteNonQuery()

                MessageBox.Show("Data Has Been Updated")
                Clear()
                txtKode.Select()
                LoadAllData() ' Refresh data grid
            Else
                MessageBox.Show("No record found with the given Kode Buku")
                drOpen.Close()
            End If

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Delete record based on kode_buku
            query = "DELETE FROM Buku WHERE kode_buku = @kode_buku"
            Dim cmdDelete As New SqlCommand(query, conn)
            cmdDelete.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
            Dim rowsAffected As Integer = cmdDelete.ExecuteNonQuery()

            conn.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Data Has Been Deleted")
                Clear()
                txtKode.Select()
                LoadAllData() ' Refresh data grid
            Else
                MessageBox.Show("No record found with the given Kode Buku")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT * FROM Buku WHERE kode_buku = @kode_buku"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kode_buku", Trim(txtKode.Text))
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
            Else
                MessageBox.Show("No record found with the given Kode Buku")
                Clear()
                LoadAllData() ' Load all data if no specific record is found
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmMaster.Show()
        Me.Hide()
    End Sub
End Class