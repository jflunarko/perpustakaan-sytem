Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmRegister
    Dim conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True")
    Dim query As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "INSERT INTO Mahasiswa (nim, nama, password, gender, kelas, usia, fakultas, prodi) VALUES (@nim, @nama, @password, @gender, @kelas, @usia, @fakultas, @prodi)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NIM", Trim(txtNim.Text))
            cmd.Parameters.AddWithValue("@password", Trim(txtPassword.Text))
            cmd.Parameters.AddWithValue("@nama", Trim(txtNama.Text))
            cmd.Parameters.AddWithValue("@gender", Trim(cboGender.Text))
            cmd.Parameters.AddWithValue("@kelas", Trim(txtKelas.Text))
            cmd.Parameters.AddWithValue("@usia", CInt(Trim(txtUsia.Text)))
            cmd.Parameters.AddWithValue("@fakultas", Trim(txtFakultas.Text))
            cmd.Parameters.AddWithValue("@prodi", Trim(txtProdi.Text))
            cmd.ExecuteNonQuery()

            MessageBox.Show("User has been registered")
            Dim loginForm As New FrmLogin()
            loginForm.Show()
            Me.Hide()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click

    End Sub

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        FrmLogin.Show()
        Me.Close()
    End Sub
End Class