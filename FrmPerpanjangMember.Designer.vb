<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerpanjangMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPerpanjangMember))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.cmbDurasi = New System.Windows.Forms.ComboBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.btnPerpanjang = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHarga.Location = New System.Drawing.Point(153, 67)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(203, 22)
        Me.txtHarga.TabIndex = 54
        '
        'cmbDurasi
        '
        Me.cmbDurasi.BackColor = System.Drawing.Color.PaleTurquoise
        Me.cmbDurasi.FormattingEnabled = True
        Me.cmbDurasi.Location = New System.Drawing.Point(153, 35)
        Me.cmbDurasi.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDurasi.Name = "cmbDurasi"
        Me.cmbDurasi.Size = New System.Drawing.Size(160, 24)
        Me.cmbDurasi.TabIndex = 53
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.BackColor = System.Drawing.Color.Transparent
        Me.lblTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelepon.Location = New System.Drawing.Point(50, 34)
        Me.lblTelepon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(63, 24)
        Me.lblTelepon.TabIndex = 52
        Me.lblTelepon.Text = "Durasi"
        '
        'btnPerpanjang
        '
        Me.btnPerpanjang.BackColor = System.Drawing.Color.MintCream
        Me.btnPerpanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerpanjang.Location = New System.Drawing.Point(153, 110)
        Me.btnPerpanjang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPerpanjang.Name = "btnPerpanjang"
        Me.btnPerpanjang.Size = New System.Drawing.Size(225, 41)
        Me.btnPerpanjang.TabIndex = 56
        Me.btnPerpanjang.Text = "Perpanjang Member"
        Me.btnPerpanjang.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(422, 171)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(92, 29)
        Me.btnMenu.TabIndex = 66
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'FrmPerpanjangMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(560, 232)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnPerpanjang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.cmbDurasi)
        Me.Controls.Add(Me.lblTelepon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPerpanjangMember"
        Me.Text = "FrmPerpanjangMember"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cmbDurasi As ComboBox
    Friend WithEvents lblTelepon As Label
    Friend WithEvents btnPerpanjang As Button
    Friend WithEvents btnMenu As Button
End Class
