Imports System.Data.SqlClient
Imports System.Data

Public Class FrmMahasiswa
    Dim conn As New SqlConnection
    Dim query As String

    Public Sub Connect()
        conn.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True"
    End Sub

    Sub Clear()
        txtNim.Text = ""
        txtNama.Text = ""
        txtGender.Text = ""
        txtKelas.Text = ""
        txtUsia.Text = ""
        txtProdi.Text = ""
        txtFakultas.Text = ""
    End Sub
    Private Sub LoadAllData()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT * FROM Mahasiswa"
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
    Private Sub FrmMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpustakaanDataSet9.Mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.PerpustakaanDataSet9.Mahasiswa)

        Connect()
        LoadAllData()
        Clear()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Check if the record exists
            Dim cmdCheck As New SqlCommand("SELECT * FROM Mahasiswa WHERE nim = @nim", conn)
            cmdCheck.Parameters.AddWithValue("@nim", Trim(txtNim.Text))
            Dim drOpen As SqlDataReader = cmdCheck.ExecuteReader()

            If drOpen.HasRows Then
                MessageBox.Show("Record already exists. Use the Update button to modify the record.")
            Else
                ' Insert new record
                query = "INSERT INTO Mahasiswa (nim, nama, gender, kelas, usia, fakultas, prodi) VALUES (@nim, @nama, @gender, @kelas, @usia, @fakultas, @prodi)"
                drOpen.Close()

                ' Execute Insert command
                Dim cmdSave As New SqlCommand(query, conn)
                cmdSave.Parameters.AddWithValue("@nim", Trim(txtNim.Text))
                cmdSave.Parameters.AddWithValue("@nama", Trim(txtNama.Text))
                cmdSave.Parameters.AddWithValue("@gender", Trim(txtGender.Text))
                cmdSave.Parameters.AddWithValue("@kelas", Trim(txtKelas.Text))
                cmdSave.Parameters.AddWithValue("@usia", CInt(Trim(txtUsia.Text)))
                cmdSave.Parameters.AddWithValue("@fakultas", Trim(txtFakultas.Text))
                cmdSave.Parameters.AddWithValue("@prodi", Trim(txtProdi.Text))
                cmdSave.ExecuteNonQuery()

                MessageBox.Show("Data Has Been Saved")
                Clear()
                txtNim.Select()
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
            Dim cmdCheck As New SqlCommand("SELECT * FROM Mahasiswa WHERE nim = @nim", conn)
            cmdCheck.Parameters.AddWithValue("@nim", Trim(txtNim.Text))
            Dim drOpen As SqlDataReader = cmdCheck.ExecuteReader()

            If drOpen.HasRows Then
                drOpen.Close()

                ' Build the update query dynamically based on which fields have new values
                query = "UPDATE Mahasiswa SET "
                Dim params As New List(Of SqlParameter)
                Dim updates As New List(Of String)

                If Not String.IsNullOrEmpty(txtNama.Text) Then
                    updates.Add("nama = @nama")
                    params.Add(New SqlParameter("@nama", Trim(txtNama.Text)))
                End If

                If Not String.IsNullOrEmpty(txtGender.Text) Then
                    updates.Add("gender = @gender")
                    params.Add(New SqlParameter("@gender", Trim(txtGender.Text)))
                End If

                If Not String.IsNullOrEmpty(txtKelas.Text) Then
                    updates.Add("kelas = @kelas")
                    params.Add(New SqlParameter("@kelas", Trim(txtKelas.Text)))
                End If

                If Not String.IsNullOrEmpty(txtUsia.Text) Then
                    updates.Add("usia = @usia")
                    params.Add(New SqlParameter("@usia", CInt(Trim(txtUsia.Text))))
                End If

                If Not String.IsNullOrEmpty(txtFakultas.Text) Then
                    updates.Add("fakultas = @fakultas")
                    params.Add(New SqlParameter("@fakultas", Trim(txtFakultas.Text)))
                End If

                If Not String.IsNullOrEmpty(txtProdi.Text) Then
                    updates.Add("prodi = @prodi")
                    params.Add(New SqlParameter("@prodi", Trim(txtProdi.Text)))
                End If

                ' If there are fields to update
                If updates.Count > 0 Then
                    query &= String.Join(", ", updates)
                    query &= " WHERE nim = @nim"

                    ' Execute Update command
                    Dim cmdUpdate As New SqlCommand(query, conn)
                    cmdUpdate.Parameters.AddWithValue("@nim", Trim(txtNim.Text))
                    cmdUpdate.Parameters.AddRange(params.ToArray())
                    cmdUpdate.ExecuteNonQuery()

                    MessageBox.Show("Data Has Been Updated")
                Else
                    MessageBox.Show("No fields to update")
                End If

                Clear()
                txtNim.Select()
                LoadAllData() ' Refresh data grid
            Else
                MessageBox.Show("No record found with the given NIM")
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

            ' Delete record based on NIM
            query = "DELETE FROM Mahasiswa WHERE nim = @nim"
            Dim cmdDelete As New SqlCommand(query, conn)
            cmdDelete.Parameters.AddWithValue("@nim", Trim(txtNim.Text))
            Dim rowsAffected As Integer = cmdDelete.ExecuteNonQuery()

            conn.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Data Has Been Deleted")
                Clear()
                txtNim.Select()
                LoadAllData() ' Refresh data grid
            Else
                MessageBox.Show("No record found with the given NIM")
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

            query = "SELECT * FROM Mahasiswa WHERE nim = @nim"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nim", Trim(txtNim.Text))
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
            Else
                MessageBox.Show("No record found with the given NIM")
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