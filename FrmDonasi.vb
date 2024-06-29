Imports System.Data.SqlClient

Public Class FrmDonasi
    Private nimMahasiswa As String
    Dim conn As New SqlConnection
    Dim query As String

    Public Sub New(nim As String)
        InitializeComponent()
        nimMahasiswa = nim
    End Sub
    Private Sub FrmDonasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class