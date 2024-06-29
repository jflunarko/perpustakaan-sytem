
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmLogin
    Dim conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True")
    Dim query As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            query = "SELECT password, NIM FROM Mahasiswa WHERE NIM = @NIM"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@NIM", Trim(txtNim.Text))
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim storedPassword As String = reader("password").ToString()
                Dim enteredPassword As String = txtPassword.Text

                If storedPassword = enteredPassword Then
                    MessageBox.Show("Login successful")
                    Dim nim As String = reader("NIM").ToString()
                    Dim frmMenu As New FrmMenu(nim)
                    frmMenu.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid NIM or Password")
                End If
            Else
                MessageBox.Show("Invalid NIM or Password")
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub linkDaftar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDaftar.LinkClicked
        FrmRegister.Show()
        Me.Hide()
    End Sub

End Class