<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKembali
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKembali))
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbKerusakan = New System.Windows.Forms.ComboBox()
        Me.txtDenda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBalikin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvPinjam = New System.Windows.Forms.DataGridView()
        Me.PerpustakaanDataSet7 = New WindowsApp1.perpustakaanDataSet7()
        Me.PinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PinjamTableAdapter = New WindowsApp1.perpustakaanDataSet7TableAdapters.PinjamTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NimmahasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglpinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurasipinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkPinjam = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Location = New System.Drawing.Point(388, 42)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(153, 20)
        Me.txtId.TabIndex = 19
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJudul.Location = New System.Drawing.Point(269, 42)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(71, 18)
        Me.lblJudul.TabIndex = 16
        Me.lblJudul.Text = "ID Pinjam"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(8, 13)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(267, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tgl Kembaliin"
        '
        'txtKembali
        '
        Me.txtKembali.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtKembali.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKembali.Location = New System.Drawing.Point(388, 16)
        Me.txtKembali.Multiline = True
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(153, 20)
        Me.txtKembali.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(267, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Jenis Kerusakan"
        '
        'cmbKerusakan
        '
        Me.cmbKerusakan.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbKerusakan.FormattingEnabled = True
        Me.cmbKerusakan.Location = New System.Drawing.Point(388, 68)
        Me.cmbKerusakan.Name = "cmbKerusakan"
        Me.cmbKerusakan.Size = New System.Drawing.Size(121, 21)
        Me.cmbKerusakan.TabIndex = 29
        '
        'txtDenda
        '
        Me.txtDenda.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDenda.Location = New System.Drawing.Point(388, 95)
        Me.txtDenda.Multiline = True
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(153, 20)
        Me.txtDenda.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(267, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Denda"
        '
        'btnBalikin
        '
        Me.btnBalikin.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnBalikin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBalikin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalikin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBalikin.Location = New System.Drawing.Point(461, 126)
        Me.btnBalikin.Name = "btnBalikin"
        Me.btnBalikin.Size = New System.Drawing.Size(80, 33)
        Me.btnBalikin.TabIndex = 32
        Me.btnBalikin.Text = "Balikin"
        Me.btnBalikin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(652, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 30)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvPinjam
        '
        Me.dgvPinjam.AutoGenerateColumns = False
        Me.dgvPinjam.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.dgvPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPinjam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.KodebukuDataGridViewTextBoxColumn, Me.NimmahasiswaDataGridViewTextBoxColumn, Me.TglpinjamDataGridViewTextBoxColumn, Me.DurasipinjamDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvPinjam.DataSource = Me.PinjamBindingSource
        Me.dgvPinjam.Location = New System.Drawing.Point(12, 12)
        Me.dgvPinjam.Name = "dgvPinjam"
        Me.dgvPinjam.Size = New System.Drawing.Size(643, 166)
        Me.dgvPinjam.TabIndex = 34
        '
        'PerpustakaanDataSet7
        '
        Me.PerpustakaanDataSet7.DataSetName = "perpustakaanDataSet7"
        Me.PerpustakaanDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PinjamBindingSource
        '
        Me.PinjamBindingSource.DataMember = "Pinjam"
        Me.PinjamBindingSource.DataSource = Me.PerpustakaanDataSet7
        '
        'PinjamTableAdapter
        '
        Me.PinjamTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodebukuDataGridViewTextBoxColumn
        '
        Me.KodebukuDataGridViewTextBoxColumn.DataPropertyName = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.HeaderText = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.Name = "KodebukuDataGridViewTextBoxColumn"
        '
        'NimmahasiswaDataGridViewTextBoxColumn
        '
        Me.NimmahasiswaDataGridViewTextBoxColumn.DataPropertyName = "nim_mahasiswa"
        Me.NimmahasiswaDataGridViewTextBoxColumn.HeaderText = "nim_mahasiswa"
        Me.NimmahasiswaDataGridViewTextBoxColumn.Name = "NimmahasiswaDataGridViewTextBoxColumn"
        '
        'TglpinjamDataGridViewTextBoxColumn
        '
        Me.TglpinjamDataGridViewTextBoxColumn.DataPropertyName = "tgl_pinjam"
        Me.TglpinjamDataGridViewTextBoxColumn.HeaderText = "tgl_pinjam"
        Me.TglpinjamDataGridViewTextBoxColumn.Name = "TglpinjamDataGridViewTextBoxColumn"
        '
        'DurasipinjamDataGridViewTextBoxColumn
        '
        Me.DurasipinjamDataGridViewTextBoxColumn.DataPropertyName = "durasi_pinjam"
        Me.DurasipinjamDataGridViewTextBoxColumn.HeaderText = "durasi_pinjam"
        Me.DurasipinjamDataGridViewTextBoxColumn.Name = "DurasipinjamDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.linkPinjam)
        Me.Panel1.Controls.Add(Me.btnBalikin)
        Me.Panel1.Controls.Add(Me.txtDenda)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbKerusakan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtKembali)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Location = New System.Drawing.Point(8, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 186)
        Me.Panel1.TabIndex = 35
        '
        'linkPinjam
        '
        Me.linkPinjam.AutoSize = True
        Me.linkPinjam.Location = New System.Drawing.Point(446, 167)
        Me.linkPinjam.Name = "linkPinjam"
        Me.linkPinjam.Size = New System.Drawing.Size(95, 13)
        Me.linkPinjam.TabIndex = 33
        Me.linkPinjam.TabStop = True
        Me.linkPinjam.Text = "Pinjam Buku Lain?"
        '
        'FrmKembali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(742, 386)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvPinjam)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmKembali"
        Me.Text = "FrmKembali"
        CType(Me.dgvPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbKerusakan As ComboBox
    Friend WithEvents txtDenda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBalikin As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvPinjam As DataGridView
    Friend WithEvents PerpustakaanDataSet7 As perpustakaanDataSet7
    Friend WithEvents PinjamBindingSource As BindingSource
    Friend WithEvents PinjamTableAdapter As perpustakaanDataSet7TableAdapters.PinjamTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NimmahasiswaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglpinjamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurasipinjamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents linkPinjam As LinkLabel
End Class
