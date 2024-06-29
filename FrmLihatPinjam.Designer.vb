<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLihatPinjam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLihatPinjam))
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.txtSisa = New System.Windows.Forms.TextBox()
        Me.lblPenulis = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPinjam = New System.Windows.Forms.Button()
        Me.dgvPinjam = New System.Windows.Forms.DataGridView()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.PerpustakaanDataSet8 = New WindowsApp1.perpustakaanDataSet8()
        Me.KembaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KembaliTableAdapter = New WindowsApp1.perpustakaanDataSet8TableAdapters.KembaliTableAdapter()
        Me.PinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PinjamTableAdapter = New WindowsApp1.perpustakaanDataSet8TableAdapters.PinjamTableAdapter()
        Me.PinjamBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDataSet9 = New WindowsApp1.perpustakaanDataSet9()
        Me.PerpustakaanDataSet9BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PinjamBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PinjamTableAdapter1 = New WindowsApp1.perpustakaanDataSet9TableAdapters.PinjamTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NimmahasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglpinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurasipinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PerpustakaanDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KembaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinjamBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet9BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinjamBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLihat
        '
        Me.btnLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.Location = New System.Drawing.Point(283, 174)
        Me.btnLihat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Size = New System.Drawing.Size(120, 41)
        Me.btnLihat.TabIndex = 64
        Me.btnLihat.Text = "Lihat Buku"
        Me.btnLihat.UseVisualStyleBackColor = True
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(200, 100)
        Me.txtJudul.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(203, 22)
        Me.txtJudul.TabIndex = 68
        '
        'txtSisa
        '
        Me.txtSisa.Location = New System.Drawing.Point(200, 132)
        Me.txtSisa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.Size = New System.Drawing.Size(203, 22)
        Me.txtSisa.TabIndex = 67
        '
        'lblPenulis
        '
        Me.lblPenulis.AutoSize = True
        Me.lblPenulis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenulis.Location = New System.Drawing.Point(15, 71)
        Me.lblPenulis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenulis.Name = "lblPenulis"
        Me.lblPenulis.Size = New System.Drawing.Size(68, 18)
        Me.lblPenulis.TabIndex = 66
        Me.lblPenulis.Text = "Id Pinjam"
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(15, 133)
        Me.lblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(119, 18)
        Me.lblJudul.TabIndex = 65
        Me.lblJudul.Text = "Sisa Berapa Hari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Judul Buku"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(200, 68)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(203, 22)
        Me.txtId.TabIndex = 70
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(840, 406)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 31)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPinjam
        '
        Me.btnPinjam.BackColor = System.Drawing.Color.LightCoral
        Me.btnPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPinjam.Location = New System.Drawing.Point(736, 208)
        Me.btnPinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Size = New System.Drawing.Size(185, 39)
        Me.btnPinjam.TabIndex = 72
        Me.btnPinjam.Text = "Pinjam Buku"
        Me.btnPinjam.UseVisualStyleBackColor = False
        '
        'dgvPinjam
        '
        Me.dgvPinjam.AutoGenerateColumns = False
        Me.dgvPinjam.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPinjam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.KodebukuDataGridViewTextBoxColumn, Me.NimmahasiswaDataGridViewTextBoxColumn, Me.TglpinjamDataGridViewTextBoxColumn, Me.DurasipinjamDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvPinjam.DataSource = Me.PinjamBindingSource2
        Me.dgvPinjam.GridColor = System.Drawing.Color.RosyBrown
        Me.dgvPinjam.Location = New System.Drawing.Point(16, 15)
        Me.dgvPinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvPinjam.Name = "dgvPinjam"
        Me.dgvPinjam.RowHeadersWidth = 51
        Me.dgvPinjam.Size = New System.Drawing.Size(905, 185)
        Me.dgvPinjam.TabIndex = 73
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.LightCoral
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(736, 255)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(185, 39)
        Me.btnKembali.TabIndex = 74
        Me.btnKembali.Text = "Balikin Buku"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Pink
        Me.Panel1.Controls.Add(Me.lblCheck)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtJudul)
        Me.Panel1.Controls.Add(Me.txtSisa)
        Me.Panel1.Controls.Add(Me.lblPenulis)
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.btnLihat)
        Me.Panel1.Location = New System.Drawing.Point(16, 215)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 222)
        Me.Panel1.TabIndex = 75
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheck.Location = New System.Drawing.Point(276, 15)
        Me.lblCheck.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(119, 25)
        Me.lblCheck.TabIndex = 71
        Me.lblCheck.Text = "Check Buku"
        '
        'PerpustakaanDataSet8
        '
        Me.PerpustakaanDataSet8.DataSetName = "perpustakaanDataSet8"
        Me.PerpustakaanDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KembaliBindingSource
        '
        Me.KembaliBindingSource.DataMember = "Kembali"
        Me.KembaliBindingSource.DataSource = Me.PerpustakaanDataSet8
        '
        'KembaliTableAdapter
        '
        Me.KembaliTableAdapter.ClearBeforeFill = True
        '
        'PinjamBindingSource
        '
        Me.PinjamBindingSource.DataMember = "Pinjam"
        Me.PinjamBindingSource.DataSource = Me.PerpustakaanDataSet8
        '
        'PinjamTableAdapter
        '
        Me.PinjamTableAdapter.ClearBeforeFill = True
        '
        'PinjamBindingSource1
        '
        Me.PinjamBindingSource1.DataMember = "Pinjam"
        Me.PinjamBindingSource1.DataSource = Me.PerpustakaanDataSet8
        '
        'PerpustakaanDataSet9
        '
        Me.PerpustakaanDataSet9.DataSetName = "perpustakaanDataSet9"
        Me.PerpustakaanDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PerpustakaanDataSet9BindingSource
        '
        Me.PerpustakaanDataSet9BindingSource.DataSource = Me.PerpustakaanDataSet9
        Me.PerpustakaanDataSet9BindingSource.Position = 0
        '
        'PinjamBindingSource2
        '
        Me.PinjamBindingSource2.DataMember = "Pinjam"
        Me.PinjamBindingSource2.DataSource = Me.PerpustakaanDataSet9BindingSource
        '
        'PinjamTableAdapter1
        '
        Me.PinjamTableAdapter1.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'KodebukuDataGridViewTextBoxColumn
        '
        Me.KodebukuDataGridViewTextBoxColumn.DataPropertyName = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.HeaderText = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodebukuDataGridViewTextBoxColumn.Name = "KodebukuDataGridViewTextBoxColumn"
        Me.KodebukuDataGridViewTextBoxColumn.Width = 125
        '
        'NimmahasiswaDataGridViewTextBoxColumn
        '
        Me.NimmahasiswaDataGridViewTextBoxColumn.DataPropertyName = "nim_mahasiswa"
        Me.NimmahasiswaDataGridViewTextBoxColumn.HeaderText = "nim_mahasiswa"
        Me.NimmahasiswaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NimmahasiswaDataGridViewTextBoxColumn.Name = "NimmahasiswaDataGridViewTextBoxColumn"
        Me.NimmahasiswaDataGridViewTextBoxColumn.Width = 125
        '
        'TglpinjamDataGridViewTextBoxColumn
        '
        Me.TglpinjamDataGridViewTextBoxColumn.DataPropertyName = "tgl_pinjam"
        Me.TglpinjamDataGridViewTextBoxColumn.HeaderText = "tgl_pinjam"
        Me.TglpinjamDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TglpinjamDataGridViewTextBoxColumn.Name = "TglpinjamDataGridViewTextBoxColumn"
        Me.TglpinjamDataGridViewTextBoxColumn.Width = 125
        '
        'DurasipinjamDataGridViewTextBoxColumn
        '
        Me.DurasipinjamDataGridViewTextBoxColumn.DataPropertyName = "durasi_pinjam"
        Me.DurasipinjamDataGridViewTextBoxColumn.HeaderText = "durasi_pinjam"
        Me.DurasipinjamDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DurasipinjamDataGridViewTextBoxColumn.Name = "DurasipinjamDataGridViewTextBoxColumn"
        Me.DurasipinjamDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 125
        '
        'FrmLihatPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(961, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.dgvPinjam)
        Me.Controls.Add(Me.btnPinjam)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmLihatPinjam"
        Me.Text = "FrmLihatPinjam"
        CType(Me.dgvPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PerpustakaanDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KembaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinjamBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet9BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinjamBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLihat As Button
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtSisa As TextBox
    Friend WithEvents lblPenulis As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPinjam As Button
    Friend WithEvents dgvPinjam As DataGridView
    Friend WithEvents btnKembali As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCheck As Label
    Friend WithEvents PerpustakaanDataSet8 As perpustakaanDataSet8
    Friend WithEvents KembaliBindingSource As BindingSource
    Friend WithEvents KembaliTableAdapter As perpustakaanDataSet8TableAdapters.KembaliTableAdapter
    Friend WithEvents PinjamBindingSource As BindingSource
    Friend WithEvents PinjamTableAdapter As perpustakaanDataSet8TableAdapters.PinjamTableAdapter
    Friend WithEvents PinjamBindingSource1 As BindingSource
    Friend WithEvents PerpustakaanDataSet9BindingSource As BindingSource
    Friend WithEvents PerpustakaanDataSet9 As perpustakaanDataSet9
    Friend WithEvents PinjamBindingSource2 As BindingSource
    Friend WithEvents PinjamTableAdapter1 As perpustakaanDataSet9TableAdapters.PinjamTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NimmahasiswaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglpinjamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurasipinjamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
