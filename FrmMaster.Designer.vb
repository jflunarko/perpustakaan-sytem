<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBuku = New System.Windows.Forms.Button()
        Me.btnMahasiswa = New System.Windows.Forms.Button()
        Me.btnDonatur = New System.Windows.Forms.Button()
        Me.btnPenerbit = New System.Windows.Forms.Button()
        Me.btnRuangan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBuku
        '
        Me.btnBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuku.Location = New System.Drawing.Point(9, 108)
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(109, 42)
        Me.btnBuku.TabIndex = 65
        Me.btnBuku.Text = "Form Buku"
        Me.btnBuku.UseVisualStyleBackColor = True
        '
        'btnMahasiswa
        '
        Me.btnMahasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMahasiswa.Location = New System.Drawing.Point(84, 12)
        Me.btnMahasiswa.Name = "btnMahasiswa"
        Me.btnMahasiswa.Size = New System.Drawing.Size(109, 42)
        Me.btnMahasiswa.TabIndex = 66
        Me.btnMahasiswa.Text = "Form Mahasiswa"
        Me.btnMahasiswa.UseVisualStyleBackColor = True
        '
        'btnDonatur
        '
        Me.btnDonatur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonatur.Location = New System.Drawing.Point(211, 71)
        Me.btnDonatur.Name = "btnDonatur"
        Me.btnDonatur.Size = New System.Drawing.Size(109, 42)
        Me.btnDonatur.TabIndex = 67
        Me.btnDonatur.Text = "Form Donatur"
        Me.btnDonatur.UseVisualStyleBackColor = True
        '
        'btnPenerbit
        '
        Me.btnPenerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenerbit.Location = New System.Drawing.Point(384, 13)
        Me.btnPenerbit.Name = "btnPenerbit"
        Me.btnPenerbit.Size = New System.Drawing.Size(109, 42)
        Me.btnPenerbit.TabIndex = 70
        Me.btnPenerbit.Text = "Form Penerbit"
        Me.btnPenerbit.UseVisualStyleBackColor = True
        '
        'btnRuangan
        '
        Me.btnRuangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuangan.Location = New System.Drawing.Point(473, 108)
        Me.btnRuangan.Name = "btnRuangan"
        Me.btnRuangan.Size = New System.Drawing.Size(109, 42)
        Me.btnRuangan.TabIndex = 71
        Me.btnRuangan.Text = "Form Ruangan"
        Me.btnRuangan.UseVisualStyleBackColor = True
        '
        'FrmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 162)
        Me.Controls.Add(Me.btnRuangan)
        Me.Controls.Add(Me.btnPenerbit)
        Me.Controls.Add(Me.btnDonatur)
        Me.Controls.Add(Me.btnMahasiswa)
        Me.Controls.Add(Me.btnBuku)
        Me.Name = "FrmMaster"
        Me.Text = "FrmMaster"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuku As Button
    Friend WithEvents btnMahasiswa As Button
    Friend WithEvents btnDonatur As Button
    Friend WithEvents btnPenerbit As Button
    Friend WithEvents btnRuangan As Button
End Class
