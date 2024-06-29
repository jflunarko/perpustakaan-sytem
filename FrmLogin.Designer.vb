<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.linkDaftar = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNim
        '
        Me.txtNim.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNim.Location = New System.Drawing.Point(28, 84)
        Me.txtNim.Multiline = True
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(258, 20)
        Me.txtNim.TabIndex = 35
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPassword.Location = New System.Drawing.Point(28, 133)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(258, 20)
        Me.txtPassword.TabIndex = 34
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.BackColor = System.Drawing.Color.White
        Me.lblTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelepon.Location = New System.Drawing.Point(25, 115)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(61, 15)
        Me.lblTelepon.TabIndex = 33
        Me.lblTelepon.Text = "Password"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.White
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(25, 66)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(30, 15)
        Me.lblNama.TabIndex = 32
        Me.lblNama.Text = "NIM"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DimGray
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.Location = New System.Drawing.Point(28, 179)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(258, 33)
        Me.btnLogin.TabIndex = 36
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Mau Pinjam Buku? Segera Daftar Sekarang"
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogin.Controls.Add(Me.linkDaftar)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtNim)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Controls.Add(Me.lblNama)
        Me.pnlLogin.Controls.Add(Me.lblTelepon)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.pnlLogin.Location = New System.Drawing.Point(12, 44)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(331, 253)
        Me.pnlLogin.TabIndex = 63
        '
        'linkDaftar
        '
        Me.linkDaftar.AutoSize = True
        Me.linkDaftar.Location = New System.Drawing.Point(182, 215)
        Me.linkDaftar.Name = "linkDaftar"
        Me.linkDaftar.Size = New System.Drawing.Size(36, 13)
        Me.linkDaftar.TabIndex = 64
        Me.linkDaftar.TabStop = True
        Me.linkDaftar.Text = "Daftar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 22)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Login "
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(593, 360)
        Me.Controls.Add(Me.pnlLogin)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents linkDaftar As LinkLabel
End Class
