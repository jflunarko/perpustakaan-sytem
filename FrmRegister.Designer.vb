<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegister))
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.txtFakultas = New System.Windows.Forms.TextBox()
        Me.txtKelas = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsia = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblProdi = New System.Windows.Forms.Label()
        Me.lblKelas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProdi
        '
        Me.txtProdi.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtProdi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProdi.Location = New System.Drawing.Point(337, 50)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(153, 20)
        Me.txtProdi.TabIndex = 50
        '
        'txtFakultas
        '
        Me.txtFakultas.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtFakultas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFakultas.Location = New System.Drawing.Point(337, 75)
        Me.txtFakultas.Name = "txtFakultas"
        Me.txtFakultas.Size = New System.Drawing.Size(153, 20)
        Me.txtFakultas.TabIndex = 49
        '
        'txtKelas
        '
        Me.txtKelas.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtKelas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKelas.Location = New System.Drawing.Point(337, 22)
        Me.txtKelas.Name = "txtKelas"
        Me.txtKelas.Size = New System.Drawing.Size(153, 20)
        Me.txtKelas.TabIndex = 48
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNama.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNama.Location = New System.Drawing.Point(79, 72)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(153, 20)
        Me.txtNama.TabIndex = 47
        '
        'txtUsia
        '
        Me.txtUsia.BackColor = System.Drawing.SystemColors.Menu
        Me.txtUsia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsia.Location = New System.Drawing.Point(79, 100)
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(153, 20)
        Me.txtUsia.TabIndex = 46
        '
        'txtNim
        '
        Me.txtNim.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNim.Location = New System.Drawing.Point(79, 20)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(153, 20)
        Me.txtNim.TabIndex = 44
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(79, 46)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(153, 20)
        Me.txtPassword.TabIndex = 43
        '
        'lblUsia
        '
        Me.lblUsia.AutoSize = True
        Me.lblUsia.BackColor = System.Drawing.Color.Transparent
        Me.lblUsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsia.Location = New System.Drawing.Point(40, 99)
        Me.lblUsia.Name = "lblUsia"
        Me.lblUsia.Size = New System.Drawing.Size(38, 18)
        Me.lblUsia.TabIndex = 54
        Me.lblUsia.Text = "Usia"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(21, 125)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(57, 18)
        Me.lblGender.TabIndex = 53
        Me.lblGender.Text = "Gender"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(30, 74)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(48, 18)
        Me.lblNama.TabIndex = 52
        Me.lblNama.Text = "Nama"
        '
        'lblNim
        '
        Me.lblNim.AutoSize = True
        Me.lblNim.BackColor = System.Drawing.Color.Transparent
        Me.lblNim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNim.Location = New System.Drawing.Point(43, 19)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(35, 18)
        Me.lblNim.TabIndex = 51
        Me.lblNim.Text = "NIM"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.BackColor = System.Drawing.Color.Transparent
        Me.lblFakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFakultas.Location = New System.Drawing.Point(267, 77)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(64, 18)
        Me.lblFakultas.TabIndex = 57
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblProdi
        '
        Me.lblProdi.AutoSize = True
        Me.lblProdi.BackColor = System.Drawing.Color.Transparent
        Me.lblProdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdi.Location = New System.Drawing.Point(288, 49)
        Me.lblProdi.Name = "lblProdi"
        Me.lblProdi.Size = New System.Drawing.Size(43, 18)
        Me.lblProdi.TabIndex = 56
        Me.lblProdi.Text = "Prodi"
        '
        'lblKelas
        '
        Me.lblKelas.AutoSize = True
        Me.lblKelas.BackColor = System.Drawing.Color.Transparent
        Me.lblKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKelas.Location = New System.Drawing.Point(288, 21)
        Me.lblKelas.Name = "lblKelas"
        Me.lblKelas.Size = New System.Drawing.Size(45, 18)
        Me.lblKelas.TabIndex = 55
        Me.lblKelas.Text = "Kelas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Password"
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.SystemColors.Menu
        Me.cboGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Laki - laki", "Perempuan"})
        Me.cboGender.Location = New System.Drawing.Point(79, 126)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(153, 21)
        Me.cboGender.TabIndex = 59
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(410, 147)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(80, 33)
        Me.btnRegister.TabIndex = 60
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRegister.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(201, 9)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(103, 32)
        Me.lblRegister.TabIndex = 64
        Me.lblRegister.Text = "Register"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.linkLogin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboGender)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.lblFakultas)
        Me.Panel1.Controls.Add(Me.lblProdi)
        Me.Panel1.Controls.Add(Me.lblKelas)
        Me.Panel1.Controls.Add(Me.lblUsia)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Controls.Add(Me.lblNim)
        Me.Panel1.Controls.Add(Me.txtProdi)
        Me.Panel1.Controls.Add(Me.txtFakultas)
        Me.Panel1.Controls.Add(Me.txtKelas)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.txtUsia)
        Me.Panel1.Controls.Add(Me.txtNim)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(5, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 194)
        Me.Panel1.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(7, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Sudah Punya Akun? Login Sekarang"
        '
        'linkLogin
        '
        Me.linkLogin.AutoSize = True
        Me.linkLogin.Location = New System.Drawing.Point(107, 172)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(33, 13)
        Me.linkLogin.TabIndex = 62
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Login"
        '
        'FrmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(516, 275)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRegister)
        Me.Name = "FrmRegister"
        Me.Text = "FrmRegister"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProdi As TextBox
    Friend WithEvents txtFakultas As TextBox
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUsia As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblFakultas As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblKelas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblRegister As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents linkLogin As LinkLabel
End Class
