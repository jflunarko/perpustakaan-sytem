<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPinjam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPinjam))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.txtPenulis = New System.Windows.Forms.TextBox()
        Me.lblPenulis = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnPinjam = New System.Windows.Forms.Button()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtPinjam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.linkLihat = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpustakaanDataSet4 = New WindowsApp1.perpustakaanDataSet4()
        Me.BukuTableAdapter = New WindowsApp1.perpustakaanDataSet4TableAdapters.BukuTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpustakaanDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Peru
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebukuDataGridViewTextBoxColumn, Me.JudulbukuDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PenulisDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(612, 178)
        Me.DataGridView1.TabIndex = 0
        '
        'txtJudul
        '
        Me.txtJudul.BackColor = System.Drawing.Color.Tan
        Me.txtJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJudul.Location = New System.Drawing.Point(160, 210)
        Me.txtJudul.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(203, 22)
        Me.txtJudul.TabIndex = 15
        '
        'txtPenulis
        '
        Me.txtPenulis.BackColor = System.Drawing.Color.Tan
        Me.txtPenulis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenulis.Location = New System.Drawing.Point(160, 242)
        Me.txtPenulis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPenulis.Name = "txtPenulis"
        Me.txtPenulis.Size = New System.Drawing.Size(203, 22)
        Me.txtPenulis.TabIndex = 14
        '
        'lblPenulis
        '
        Me.lblPenulis.AutoSize = True
        Me.lblPenulis.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lblPenulis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPenulis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenulis.Location = New System.Drawing.Point(75, 240)
        Me.lblPenulis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenulis.Name = "lblPenulis"
        Me.lblPenulis.Size = New System.Drawing.Size(74, 26)
        Me.lblPenulis.TabIndex = 13
        Me.lblPenulis.Text = "Penulis"
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lblJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(41, 210)
        Me.lblJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(106, 26)
        Me.lblJudul.TabIndex = 12
        Me.lblJudul.Text = "Judul Buku"
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(257, 288)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(107, 41)
        Me.btnCari.TabIndex = 16
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnPinjam
        '
        Me.btnPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPinjam.Location = New System.Drawing.Point(275, 314)
        Me.btnPinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Size = New System.Drawing.Size(107, 41)
        Me.btnPinjam.TabIndex = 17
        Me.btnPinjam.Text = "Pinjam"
        Me.btnPinjam.UseVisualStyleBackColor = True
        '
        'txtKode
        '
        Me.txtKode.BackColor = System.Drawing.Color.Linen
        Me.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKode.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtKode.Location = New System.Drawing.Point(177, 287)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(203, 22)
        Me.txtKode.TabIndex = 21
        '
        'txtPinjam
        '
        Me.txtPinjam.BackColor = System.Drawing.Color.Linen
        Me.txtPinjam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPinjam.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPinjam.Location = New System.Drawing.Point(177, 220)
        Me.txtPinjam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPinjam.Name = "txtPinjam"
        Me.txtPinjam.Size = New System.Drawing.Size(203, 22)
        Me.txtPinjam.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 289)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Kode Buku"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(51, 10)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 220)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 24)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Tgl Pinjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 257)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Lama Pinjam"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Linen
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1 Hari", "2 Hari", "3 Hari", "4 Hari", "5 Hari", "6 Hari", "7 Hari"})
        Me.ComboBox1.Location = New System.Drawing.Point(177, 254)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 420)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 37)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'linkLihat
        '
        Me.linkLihat.AutoSize = True
        Me.linkLihat.Location = New System.Drawing.Point(153, 358)
        Me.linkLihat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkLihat.Name = "linkLihat"
        Me.linkLihat.Size = New System.Drawing.Size(212, 16)
        Me.linkLihat.TabIndex = 30
        Me.linkLihat.TabStop = True
        Me.linkLihat.Text = "Lihat Buku Yang Sedang di Pinjam"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.Controls.Add(Me.linkLihat)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtKode)
        Me.Panel1.Controls.Add(Me.txtPinjam)
        Me.Panel1.Controls.Add(Me.btnPinjam)
        Me.Panel1.Location = New System.Drawing.Point(652, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 414)
        Me.Panel1.TabIndex = 31
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
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "Buku"
        Me.BukuBindingSource.DataSource = Me.PerpustakaanDataSet4
        '
        'PerpustakaanDataSet4
        '
        Me.PerpustakaanDataSet4.DataSetName = "perpustakaanDataSet4"
        Me.PerpustakaanDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'FrmPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1075, 465)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.txtPenulis)
        Me.Controls.Add(Me.lblPenulis)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPinjam"
        Me.Text = "FrmPinjam"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpustakaanDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PerpustakaanDataSet4 As perpustakaanDataSet4
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents BukuTableAdapter As perpustakaanDataSet4TableAdapters.BukuTableAdapter
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenulisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents lblPenulis As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents btnPinjam As Button
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtPinjam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents linkLihat As LinkLabel
    Friend WithEvents Panel1 As Panel
End Class
