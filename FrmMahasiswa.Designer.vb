<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMahasiswa
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
        Me.components = New System.ComponentModel.Container()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.lblUsia = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblProdi = New System.Windows.Forms.Label()
        Me.lblKelas = New System.Windows.Forms.Label()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.txtFakultas = New System.Windows.Forms.TextBox()
        Me.txtKelas = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PerpustakaanDataSet9 = New WindowsApp1.perpustakaanDataSet9()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New WindowsApp1.perpustakaanDataSet9TableAdapters.MahasiswaTableAdapter()
        Me.NIMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FakultasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(133, 305)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(203, 22)
        Me.txtNama.TabIndex = 23
        '
        'txtUsia
        '
        Me.txtUsia.Location = New System.Drawing.Point(133, 337)
        Me.txtUsia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(203, 22)
        Me.txtUsia.TabIndex = 22
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(133, 369)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(203, 22)
        Me.txtGender.TabIndex = 21
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(133, 273)
        Me.txtNim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(203, 22)
        Me.txtNim.TabIndex = 20
        '
        'lblUsia
        '
        Me.lblUsia.AutoSize = True
        Me.lblUsia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsia.Location = New System.Drawing.Point(61, 337)
        Me.lblUsia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsia.Name = "lblUsia"
        Me.lblUsia.Size = New System.Drawing.Size(46, 24)
        Me.lblUsia.TabIndex = 19
        Me.lblUsia.Text = "Usia"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(36, 369)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(74, 24)
        Me.lblGender.TabIndex = 18
        Me.lblGender.Text = "Gender"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(48, 304)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(60, 24)
        Me.lblNama.TabIndex = 17
        Me.lblNama.Text = "Nama"
        '
        'lblNim
        '
        Me.lblNim.AutoSize = True
        Me.lblNim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNim.Location = New System.Drawing.Point(65, 273)
        Me.lblNim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(44, 24)
        Me.lblNim.TabIndex = 16
        Me.lblNim.Text = "NIM"
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(627, 404)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(107, 41)
        Me.btnCari.TabIndex = 15
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(512, 404)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(107, 41)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(741, 404)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(107, 41)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(397, 404)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(107, 41)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Simpan"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFakultas.Location = New System.Drawing.Point(405, 340)
        Me.lblFakultas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(79, 24)
        Me.lblFakultas.TabIndex = 26
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblProdi
        '
        Me.lblProdi.AutoSize = True
        Me.lblProdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdi.Location = New System.Drawing.Point(405, 304)
        Me.lblProdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProdi.Name = "lblProdi"
        Me.lblProdi.Size = New System.Drawing.Size(54, 24)
        Me.lblProdi.TabIndex = 25
        Me.lblProdi.Text = "Prodi"
        '
        'lblKelas
        '
        Me.lblKelas.AutoSize = True
        Me.lblKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKelas.Location = New System.Drawing.Point(405, 272)
        Me.lblKelas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKelas.Name = "lblKelas"
        Me.lblKelas.Size = New System.Drawing.Size(56, 24)
        Me.lblKelas.TabIndex = 24
        Me.lblKelas.Text = "Kelas"
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(527, 306)
        Me.txtProdi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(203, 22)
        Me.txtProdi.TabIndex = 29
        '
        'txtFakultas
        '
        Me.txtFakultas.Location = New System.Drawing.Point(527, 338)
        Me.txtFakultas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFakultas.Name = "txtFakultas"
        Me.txtFakultas.Size = New System.Drawing.Size(203, 22)
        Me.txtFakultas.TabIndex = 28
        '
        'txtKelas
        '
        Me.txtKelas.Location = New System.Drawing.Point(527, 274)
        Me.txtKelas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKelas.Name = "txtKelas"
        Me.txtKelas.Size = New System.Drawing.Size(203, 22)
        Me.txtKelas.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIMDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.UsiaDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.KelasDataGridViewTextBoxColumn, Me.FakultasDataGridViewTextBoxColumn, Me.ProdiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MahasiswaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1055, 240)
        Me.DataGridView1.TabIndex = 30
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(945, 274)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 31)
        Me.btnBack.TabIndex = 73
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PerpustakaanDataSet9
        '
        Me.PerpustakaanDataSet9.DataSetName = "perpustakaanDataSet9"
        Me.PerpustakaanDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "Mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.PerpustakaanDataSet9
        '
        'MahasiswaTableAdapter
        '
        Me.MahasiswaTableAdapter.ClearBeforeFill = True
        '
        'NIMDataGridViewTextBoxColumn
        '
        Me.NIMDataGridViewTextBoxColumn.DataPropertyName = "NIM"
        Me.NIMDataGridViewTextBoxColumn.HeaderText = "NIM"
        Me.NIMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NIMDataGridViewTextBoxColumn.Name = "NIMDataGridViewTextBoxColumn"
        Me.NIMDataGridViewTextBoxColumn.Width = 125
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'UsiaDataGridViewTextBoxColumn
        '
        Me.UsiaDataGridViewTextBoxColumn.DataPropertyName = "Usia"
        Me.UsiaDataGridViewTextBoxColumn.HeaderText = "Usia"
        Me.UsiaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsiaDataGridViewTextBoxColumn.Name = "UsiaDataGridViewTextBoxColumn"
        Me.UsiaDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'KelasDataGridViewTextBoxColumn
        '
        Me.KelasDataGridViewTextBoxColumn.DataPropertyName = "Kelas"
        Me.KelasDataGridViewTextBoxColumn.HeaderText = "Kelas"
        Me.KelasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KelasDataGridViewTextBoxColumn.Name = "KelasDataGridViewTextBoxColumn"
        Me.KelasDataGridViewTextBoxColumn.Width = 125
        '
        'FakultasDataGridViewTextBoxColumn
        '
        Me.FakultasDataGridViewTextBoxColumn.DataPropertyName = "Fakultas"
        Me.FakultasDataGridViewTextBoxColumn.HeaderText = "Fakultas"
        Me.FakultasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FakultasDataGridViewTextBoxColumn.Name = "FakultasDataGridViewTextBoxColumn"
        Me.FakultasDataGridViewTextBoxColumn.Width = 125
        '
        'ProdiDataGridViewTextBoxColumn
        '
        Me.ProdiDataGridViewTextBoxColumn.DataPropertyName = "Prodi"
        Me.ProdiDataGridViewTextBoxColumn.HeaderText = "Prodi"
        Me.ProdiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProdiDataGridViewTextBoxColumn.Name = "ProdiDataGridViewTextBoxColumn"
        Me.ProdiDataGridViewTextBoxColumn.Width = 125
        '
        'FrmMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 459)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.txtFakultas)
        Me.Controls.Add(Me.txtKelas)
        Me.Controls.Add(Me.lblFakultas)
        Me.Controls.Add(Me.lblProdi)
        Me.Controls.Add(Me.lblKelas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtUsia)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.lblUsia)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNim)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCreate)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMahasiswa"
        Me.Text = "Data Mahasiswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblUsia As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblFakultas As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblKelas As Label
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents txtFakultas As TextBox
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents PerpustakaanDataSet9 As perpustakaanDataSet9
    Friend WithEvents MahasiswaBindingSource As BindingSource
    Friend WithEvents MahasiswaTableAdapter As perpustakaanDataSet9TableAdapters.MahasiswaTableAdapter
    Friend WithEvents NIMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KelasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FakultasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
