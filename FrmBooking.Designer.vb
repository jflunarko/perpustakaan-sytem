<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBooking
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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.cmbRuang = New System.Windows.Forms.ComboBox()
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.cmbWaktu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(152, 42)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(203, 22)
        Me.txtNama.TabIndex = 30
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(18, 71)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(115, 24)
        Me.lblJenis.TabIndex = 27
        Me.lblJenis.Text = "Jenis Ruang"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(18, 39)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(60, 24)
        Me.lblNama.TabIndex = 26
        Me.lblNama.Text = "Nama"
        '
        'cmbRuang
        '
        Me.cmbRuang.FormattingEnabled = True
        Me.cmbRuang.Location = New System.Drawing.Point(152, 74)
        Me.cmbRuang.Name = "cmbRuang"
        Me.cmbRuang.Size = New System.Drawing.Size(121, 24)
        Me.cmbRuang.TabIndex = 31
        '
        'btnLihat
        '
        Me.btnLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.Location = New System.Drawing.Point(379, 138)
        Me.btnLihat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Size = New System.Drawing.Size(136, 33)
        Me.btnLihat.TabIndex = 65
        Me.btnLihat.Text = "Booking"
        Me.btnLihat.UseVisualStyleBackColor = True
        '
        'cmbWaktu
        '
        Me.cmbWaktu.FormattingEnabled = True
        Me.cmbWaktu.Location = New System.Drawing.Point(152, 104)
        Me.cmbWaktu.Name = "cmbWaktu"
        Me.cmbWaktu.Size = New System.Drawing.Size(121, 24)
        Me.cmbWaktu.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Waktu"
        '
        'FrmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 184)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbWaktu)
        Me.Controls.Add(Me.btnLihat)
        Me.Controls.Add(Me.cmbRuang)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.lblNama)
        Me.Name = "FrmBooking"
        Me.Text = "FrmBooking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents cmbRuang As ComboBox
    Friend WithEvents btnLihat As Button
    Friend WithEvents cmbWaktu As ComboBox
    Friend WithEvents Label1 As Label
End Class
