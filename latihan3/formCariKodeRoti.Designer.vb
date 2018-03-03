<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCariKodeRoti
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tabelDataRoti = New System.Windows.Forms.DataGridView()
        Me.KoderotiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamarotiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RotiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TheBreadShopDataSet = New latihan3.TheBreadShopDataSet()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.RotiTableAdapter = New latihan3.TheBreadShopDataSetTableAdapters.rotiTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelHeaderRoti = New System.Windows.Forms.Panel()
        Me.btnEditRoti = New System.Windows.Forms.Button()
        Me.btnHapusRoti = New System.Windows.Forms.Button()
        Me.txCariRoti = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        CType(Me.tabelDataRoti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TheBreadShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelHeaderRoti.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(448, 98)
        Me.PanelHeader.TabIndex = 2
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(448, 30)
        Me.PanelWindowBar.TabIndex = 1
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(418, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 8
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(162, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Roti"
        '
        'Label33
        '
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(10, 438)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(428, 10)
        Me.Label33.TabIndex = 12
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(10, 98)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(428, 10)
        Me.Label34.TabIndex = 11
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(438, 98)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(10, 350)
        Me.Label35.TabIndex = 10
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(0, 98)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(10, 350)
        Me.Label36.TabIndex = 9
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabelDataRoti
        '
        Me.tabelDataRoti.AllowUserToAddRows = False
        Me.tabelDataRoti.AllowUserToDeleteRows = False
        Me.tabelDataRoti.AllowUserToOrderColumns = True
        Me.tabelDataRoti.AutoGenerateColumns = False
        Me.tabelDataRoti.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataRoti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataRoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataRoti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KoderotiDataGridViewTextBoxColumn, Me.NamarotiDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn})
        Me.tabelDataRoti.DataSource = Me.RotiBindingSource
        Me.tabelDataRoti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataRoti.Location = New System.Drawing.Point(10, 178)
        Me.tabelDataRoti.MultiSelect = False
        Me.tabelDataRoti.Name = "tabelDataRoti"
        Me.tabelDataRoti.ReadOnly = True
        Me.tabelDataRoti.Size = New System.Drawing.Size(428, 260)
        Me.tabelDataRoti.TabIndex = 13
        '
        'KoderotiDataGridViewTextBoxColumn
        '
        Me.KoderotiDataGridViewTextBoxColumn.DataPropertyName = "kode_roti"
        Me.KoderotiDataGridViewTextBoxColumn.HeaderText = "Kode Roti"
        Me.KoderotiDataGridViewTextBoxColumn.Name = "KoderotiDataGridViewTextBoxColumn"
        Me.KoderotiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamarotiDataGridViewTextBoxColumn
        '
        Me.NamarotiDataGridViewTextBoxColumn.DataPropertyName = "nama_roti"
        Me.NamarotiDataGridViewTextBoxColumn.HeaderText = "Nama Roti"
        Me.NamarotiDataGridViewTextBoxColumn.Name = "NamarotiDataGridViewTextBoxColumn"
        Me.NamarotiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        Me.DiskonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        Me.StokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RotiBindingSource
        '
        Me.RotiBindingSource.DataMember = "roti"
        Me.RotiBindingSource.DataSource = Me.TheBreadShopDataSet
        '
        'TheBreadShopDataSet
        '
        Me.TheBreadShopDataSet.DataSetName = "TheBreadShopDataSet"
        Me.TheBreadShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPilih.FlatAppearance.BorderSize = 0
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.ForeColor = System.Drawing.Color.White
        Me.btnPilih.Location = New System.Drawing.Point(339, 10)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(83, 40)
        Me.btnPilih.TabIndex = 14
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'RotiTableAdapter
        '
        Me.RotiTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tabelDataRoti)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PanelHeaderRoti)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 450)
        Me.Panel1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 10)
        Me.Label2.TabIndex = 12
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeaderRoti
        '
        Me.PanelHeaderRoti.Controls.Add(Me.btnPilih)
        Me.PanelHeaderRoti.Controls.Add(Me.btnEditRoti)
        Me.PanelHeaderRoti.Controls.Add(Me.btnHapusRoti)
        Me.PanelHeaderRoti.Controls.Add(Me.txCariRoti)
        Me.PanelHeaderRoti.Controls.Add(Me.Label7)
        Me.PanelHeaderRoti.Controls.Add(Me.Label15)
        Me.PanelHeaderRoti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderRoti.Location = New System.Drawing.Point(10, 108)
        Me.PanelHeaderRoti.Name = "PanelHeaderRoti"
        Me.PanelHeaderRoti.Size = New System.Drawing.Size(428, 60)
        Me.PanelHeaderRoti.TabIndex = 15
        '
        'btnEditRoti
        '
        Me.btnEditRoti.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEditRoti.FlatAppearance.BorderSize = 0
        Me.btnEditRoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRoti.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRoti.ForeColor = System.Drawing.Color.White
        Me.btnEditRoti.Location = New System.Drawing.Point(436, 10)
        Me.btnEditRoti.Name = "btnEditRoti"
        Me.btnEditRoti.Size = New System.Drawing.Size(100, 40)
        Me.btnEditRoti.TabIndex = 7
        Me.btnEditRoti.Text = "Edit"
        Me.btnEditRoti.UseVisualStyleBackColor = False
        '
        'btnHapusRoti
        '
        Me.btnHapusRoti.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnHapusRoti.FlatAppearance.BorderSize = 0
        Me.btnHapusRoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusRoti.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusRoti.ForeColor = System.Drawing.Color.White
        Me.btnHapusRoti.Location = New System.Drawing.Point(542, 10)
        Me.btnHapusRoti.Name = "btnHapusRoti"
        Me.btnHapusRoti.Size = New System.Drawing.Size(100, 40)
        Me.btnHapusRoti.TabIndex = 6
        Me.btnHapusRoti.Text = "Hapus"
        Me.btnHapusRoti.UseVisualStyleBackColor = False
        '
        'txCariRoti
        '
        Me.txCariRoti.Location = New System.Drawing.Point(54, 22)
        Me.txCariRoti.Name = "txCariRoti"
        Me.txCariRoti.Size = New System.Drawing.Size(144, 20)
        Me.txCariRoti.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 40)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cari"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(428, 60)
        Me.Label15.TabIndex = 10
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formCariKodeRoti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formCariKodeRoti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formCariKodeRoti"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelWindowBar.ResumeLayout(False)
        CType(Me.tabelDataRoti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TheBreadShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelHeaderRoti.ResumeLayout(False)
        Me.PanelHeaderRoti.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents TheBreadShopDataSet As TheBreadShopDataSet
    Friend WithEvents RotiBindingSource As BindingSource
    Friend WithEvents RotiTableAdapter As TheBreadShopDataSetTableAdapters.rotiTableAdapter
    Friend WithEvents tabelDataRoti As DataGridView
    Friend WithEvents KoderotiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamarotiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnPilih As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelHeaderRoti As Panel
    Friend WithEvents btnEditRoti As Button
    Friend WithEvents btnHapusRoti As Button
    Friend WithEvents txCariRoti As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
End Class
