<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMember))
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.cmbPaket = New System.Windows.Forms.ComboBox()
        Me.cmbDurasi = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnPerpanjang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.BackColor = System.Drawing.Color.Transparent
        Me.lblTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelepon.Location = New System.Drawing.Point(229, 154)
        Me.lblTelepon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(63, 24)
        Me.lblTelepon.TabIndex = 46
        Me.lblTelepon.Text = "Durasi"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(229, 122)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(56, 24)
        Me.lblNama.TabIndex = 45
        Me.lblNama.Text = "Paket"
        '
        'cmbPaket
        '
        Me.cmbPaket.FormattingEnabled = True
        Me.cmbPaket.Location = New System.Drawing.Point(310, 120)
        Me.cmbPaket.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPaket.Name = "cmbPaket"
        Me.cmbPaket.Size = New System.Drawing.Size(160, 24)
        Me.cmbPaket.TabIndex = 48
        '
        'cmbDurasi
        '
        Me.cmbDurasi.FormattingEnabled = True
        Me.cmbDurasi.Location = New System.Drawing.Point(310, 157)
        Me.cmbDurasi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDurasi.Name = "cmbDurasi"
        Me.cmbDurasi.Size = New System.Drawing.Size(160, 24)
        Me.cmbDurasi.TabIndex = 49
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(310, 207)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(171, 22)
        Me.txtHarga.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 204)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Harga"
        '
        'btnDaftar
        '
        Me.btnDaftar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDaftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.Location = New System.Drawing.Point(469, 256)
        Me.btnDaftar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(107, 41)
        Me.btnDaftar.TabIndex = 53
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(264, 256)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(154, 41)
        Me.btnBatal.TabIndex = 54
        Me.btnBatal.Text = "Batal Member"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnPerpanjang
        '
        Me.btnPerpanjang.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPerpanjang.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPerpanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerpanjang.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPerpanjang.Location = New System.Drawing.Point(504, 13)
        Me.btnPerpanjang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPerpanjang.Name = "btnPerpanjang"
        Me.btnPerpanjang.Size = New System.Drawing.Size(225, 41)
        Me.btnPerpanjang.TabIndex = 57
        Me.btnPerpanjang.Text = "Perpanjang Member"
        Me.btnPerpanjang.UseVisualStyleBackColor = False
        '
        'FrmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(742, 339)
        Me.Controls.Add(Me.btnPerpanjang)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnDaftar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.cmbDurasi)
        Me.Controls.Add(Me.cmbPaket)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblNama)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMember"
        Me.Text = "FrmMember"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents cmbPaket As ComboBox
    Friend WithEvents cmbDurasi As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDaftar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnPerpanjang As Button
End Class
