<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuku
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPenulis = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPenulis = New System.Windows.Forms.TextBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PerpustakaanDataSet9 = New WindowsApp1.perpustakaanDataSet9()
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BukuTableAdapter = New WindowsApp1.perpustakaanDataSet9TableAdapters.BukuTableAdapter()
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(423, 294)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(107, 41)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Simpan"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(175, 438)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(107, 41)
        Me.btnHapus.TabIndex = 1
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(423, 347)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(107, 41)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(289, 438)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(107, 41)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKode.Location = New System.Drawing.Point(63, 294)
        Me.lblKode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(103, 24)
        Me.lblKode.TabIndex = 4
        Me.lblKode.Text = "Kode Buku"
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(63, 326)
        Me.lblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(104, 24)
        Me.lblJudul.TabIndex = 5
        Me.lblJudul.Text = "Judul Buku"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(108, 390)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(56, 24)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Stock"
        '
        'lblPenulis
        '
        Me.lblPenulis.AutoSize = True
        Me.lblPenulis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenulis.Location = New System.Drawing.Point(96, 356)
        Me.lblPenulis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenulis.Name = "lblPenulis"
        Me.lblPenulis.Size = New System.Drawing.Size(72, 24)
        Me.lblPenulis.TabIndex = 7
        Me.lblPenulis.Text = "Penulis"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(192, 292)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(203, 22)
        Me.txtKode.TabIndex = 8
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(192, 388)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(203, 22)
        Me.txtStock.TabIndex = 9
        '
        'txtPenulis
        '
        Me.txtPenulis.Location = New System.Drawing.Point(192, 356)
        Me.txtPenulis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPenulis.Name = "txtPenulis"
        Me.txtPenulis.Size = New System.Drawing.Size(203, 22)
        Me.txtPenulis.TabIndex = 10
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(192, 324)
        Me.txtJudul.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(203, 22)
        Me.txtJudul.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebukuDataGridViewTextBoxColumn, Me.JudulbukuDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PenulisDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(59, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(632, 265)
        Me.DataGridView1.TabIndex = 12
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(740, 443)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 31)
        Me.btnBack.TabIndex = 72
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PerpustakaanDataSet9
        '
        Me.PerpustakaanDataSet9.DataSetName = "perpustakaanDataSet9"
        Me.PerpustakaanDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "Buku"
        Me.BukuBindingSource.DataSource = Me.PerpustakaanDataSet9
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'KodebukuDataGridViewTextBoxColumn
        '
        Me.KodebukuDataGridViewTextBoxColumn.DataPropertyName = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.HeaderText = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KodebukuDataGridViewTextBoxColumn.Name = "KodebukuDataGridViewTextBoxColumn"
        Me.KodebukuDataGridViewTextBoxColumn.Width = 125
        '
        'JudulbukuDataGridViewTextBoxColumn
        '
        Me.JudulbukuDataGridViewTextBoxColumn.DataPropertyName = "judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.HeaderText = "judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.JudulbukuDataGridViewTextBoxColumn.Name = "JudulbukuDataGridViewTextBoxColumn"
        Me.JudulbukuDataGridViewTextBoxColumn.Width = 125
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "stock"
        Me.StockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.Width = 125
        '
        'PenulisDataGridViewTextBoxColumn
        '
        Me.PenulisDataGridViewTextBoxColumn.DataPropertyName = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.HeaderText = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PenulisDataGridViewTextBoxColumn.Name = "PenulisDataGridViewTextBoxColumn"
        Me.PenulisDataGridViewTextBoxColumn.Width = 125
        '
        'FrmBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 583)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.txtPenulis)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.lblPenulis)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCreate)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmBuku"
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents lblKode As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPenulis As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents PerpustakaanDataSet9 As perpustakaanDataSet9
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents BukuTableAdapter As perpustakaanDataSet9TableAdapters.BukuTableAdapter
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenulisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
