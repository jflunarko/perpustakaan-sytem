<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.btnPinjam = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.btnPerpanjang = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPinjam
        '
        Me.btnPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPinjam.Location = New System.Drawing.Point(16, 15)
        Me.btnPinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Size = New System.Drawing.Size(120, 52)
        Me.btnPinjam.TabIndex = 61
        Me.btnPinjam.Text = "Pinjam Buku"
        Me.btnPinjam.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(16, 75)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(120, 52)
        Me.btnKembali.TabIndex = 62
        Me.btnKembali.Text = "Kembaliin Buku"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 135)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 52)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Lihat Buku "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(225, 205)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(147, 31)
        Me.btnLogOut.TabIndex = 64
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnMember
        '
        Me.btnMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMember.Location = New System.Drawing.Point(144, 15)
        Me.btnMember.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(120, 52)
        Me.btnMember.TabIndex = 65
        Me.btnMember.Text = "Daftar Member"
        Me.btnMember.UseVisualStyleBackColor = True
        '
        'btnPerpanjang
        '
        Me.btnPerpanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerpanjang.Location = New System.Drawing.Point(144, 75)
        Me.btnPerpanjang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPerpanjang.Name = "btnPerpanjang"
        Me.btnPerpanjang.Size = New System.Drawing.Size(120, 52)
        Me.btnPerpanjang.TabIndex = 66
        Me.btnPerpanjang.Text = "Perpanjang Member"
        Me.btnPerpanjang.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.Location = New System.Drawing.Point(144, 135)
        Me.btnBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(120, 52)
        Me.btnBooking.TabIndex = 67
        Me.btnBooking.Text = "Booking Tempat"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnDonate
        '
        Me.btnDonate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonate.Location = New System.Drawing.Point(272, 15)
        Me.btnDonate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(120, 52)
        Me.btnDonate.TabIndex = 68
        Me.btnDonate.Text = "Donate Buku"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 249)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.btnPerpanjang)
        Me.Controls.Add(Me.btnMember)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnPinjam)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMenu"
        Me.Text = "FrmMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnMember As Button
    Friend WithEvents btnPerpanjang As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnDonate As Button
End Class
