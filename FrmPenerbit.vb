Imports System.Data.SqlClient
Imports System.Data
Public Class FrmPenerbit
    Dim conn As New SqlConnection
    Dim query As String

    Public Sub Connect()
        conn.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True"
    End Sub

    Sub Clear()
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelepon.Text = ""
    End Sub
    Private Sub LoadAllData()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT * FROM Penerbit"
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
    Private Sub FrmPenerbit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet9.Penerbit' table. You can move, or remove it, as needed.
        Me.PenerbitTableAdapter.Fill(Me.PerpustakaanDataSet9.Penerbit)

        Connect()
        LoadAllData() ' Load all data when the form loads
        Clear()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Insert new record
            query = "INSERT INTO Penerbit (nama, alamat, telepon) VALUES (@nama, @alamat, @telepon)"
            Dim cmdSave As New SqlCommand(query, conn)
            cmdSave.Parameters.AddWithValue("@nama", Trim(txtNama.Text))
            cmdSave.Parameters.AddWithValue("@alamat", Trim(txtAlamat.Text))
            cmdSave.Parameters.AddWithValue("@telepon", Trim(txtTelepon.Text))
            cmdSave.ExecuteNonQuery()

            MessageBox.Show("Data Has Been Saved")
            Clear()
            LoadAllData() ' Refresh data grid

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
            Dim cmdCheck As New SqlCommand("SELECT * FROM Penerbit WHERE id = @id", conn)
            cmdCheck.Parameters.AddWithValue("@id", Trim(txtId.Text))
            Dim drOpen As SqlDataReader = cmdCheck.ExecuteReader()

            If drOpen.HasRows Then
                drOpen.Close()

                ' Update existing record
                query = "UPDATE Penerbit SET " &
                        "nama = @nama, " &
                        "alamat = @alamat, " &
                        "telepon = @telepon " &
                        "WHERE id = @id"

                Dim cmdUpdate As New SqlCommand(query, conn)
                cmdUpdate.Parameters.AddWithValue("@id", Trim(txtId.Text))
                cmdUpdate.Parameters.AddWithValue("@nama", Trim(txtNama.Text))
                cmdUpdate.Parameters.AddWithValue("@alamat", Trim(txtAlamat.Text))
                cmdUpdate.Parameters.AddWithValue("@telepon", Trim(txtTelepon.Text))
                cmdUpdate.ExecuteNonQuery()

                MessageBox.Show("Data Has Been Updated")
                Clear()
                LoadAllData() ' Refresh data grid
            Else
                MessageBox.Show("No record found with the given ID")
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

            ' Delete record based on ID
            query = "DELETE FROM Penerbit WHERE id = @id"
            Dim cmdDelete As New SqlCommand(query, conn)
            cmdDelete.Parameters.AddWithValue("@id", Trim(txtId.Text))
            Dim rowsAffected As Integer = cmdDelete.ExecuteNonQuery()

            conn.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Data Has Been Deleted")
                Clear()
                LoadAllData() ' Refresh data grid
            Else
                MessageBox.Show("No record found with the given ID")
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

            query = "SELECT * FROM Penerbit Where id = @id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", Trim(txtId.Text))
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmMaster.Show()
        Me.Hide()
    End Sub
End Class