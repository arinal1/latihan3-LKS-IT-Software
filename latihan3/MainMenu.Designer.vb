<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.PanelWrapperDashboard = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblJmlPenjualan = New System.Windows.Forms.Label()
        Me.lblJmlAktivitas = New System.Windows.Forms.Label()
        Me.lblJmlKaryawan = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblJmlRoti = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PanelWrapperRoti = New System.Windows.Forms.Panel()
        Me.tabelDataRoti = New System.Windows.Forms.DataGridView()
        Me.KoderotiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamarotiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RotiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TheBreadShopDataSet = New latihan3.TheBreadShopDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelHeaderRoti = New System.Windows.Forms.Panel()
        Me.btnTambahRoti = New System.Windows.Forms.Button()
        Me.btnEditRoti = New System.Windows.Forms.Button()
        Me.btnHapusRoti = New System.Windows.Forms.Button()
        Me.txCariRoti = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelWrapperKasir = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.PanelFooterKasir = New System.Windows.Forms.Panel()
        Me.txDiskonBelanja = New System.Windows.Forms.TextBox()
        Me.txKembalian = New System.Windows.Forms.TextBox()
        Me.txBayar = New System.Windows.Forms.TextBox()
        Me.txTotalBelanja = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.tabelDataKasir = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_roti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_roti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok_sedia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.PanelHeaderKasir = New System.Windows.Forms.Panel()
        Me.btnCariKodeRoti = New System.Windows.Forms.Button()
        Me.txTotalPembayaran = New System.Windows.Forms.TextBox()
        Me.tglKasir = New System.Windows.Forms.DateTimePicker()
        Me.txQty = New System.Windows.Forms.TextBox()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.txNamaRoti = New System.Windows.Forms.TextBox()
        Me.txKodeRoti = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txStrukKasir = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txHargaRoti = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.bnMinimize = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PanelSideBar = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnRiwayat = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnKaryawan = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRoti = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnKasir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PanelJudul = New System.Windows.Forms.Panel()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RotiTableAdapter = New latihan3.TheBreadShopDataSetTableAdapters.rotiTableAdapter()
        Me.Header_penjualanTableAdapter = New latihan3.TheBreadShopDataSetTableAdapters.header_penjualanTableAdapter()
        Me.PenjualanTableAdapter = New latihan3.TheBreadShopDataSetTableAdapters.penjualanTableAdapter()
        Me.PanelForm.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        Me.PanelWrapperDashboard.SuspendLayout()
        Me.PanelWrapperRoti.SuspendLayout()
        CType(Me.tabelDataRoti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TheBreadShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderRoti.SuspendLayout()
        Me.PanelWrapperKasir.SuspendLayout()
        Me.PanelFooterKasir.SuspendLayout()
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderKasir.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelSideBar.SuspendLayout()
        Me.PanelJudul.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Controls.Add(Me.PanelKonten)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Controls.Add(Me.PanelSideBar)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(870, 570)
        Me.PanelForm.TabIndex = 0
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.PanelWrapperRoti)
        Me.PanelKonten.Controls.Add(Me.PanelWrapperKasir)
        Me.PanelKonten.Controls.Add(Me.PanelWrapperDashboard)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(200, 100)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(668, 468)
        Me.PanelKonten.TabIndex = 0
        '
        'PanelWrapperDashboard
        '
        Me.PanelWrapperDashboard.BackColor = System.Drawing.Color.Transparent
        Me.PanelWrapperDashboard.Controls.Add(Me.Label29)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label28)
        Me.PanelWrapperDashboard.Controls.Add(Me.lblJmlPenjualan)
        Me.PanelWrapperDashboard.Controls.Add(Me.lblJmlAktivitas)
        Me.PanelWrapperDashboard.Controls.Add(Me.lblJmlKaryawan)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label21)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label26)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label24)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label22)
        Me.PanelWrapperDashboard.Controls.Add(Me.lblJmlRoti)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label16)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label17)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label19)
        Me.PanelWrapperDashboard.Controls.Add(Me.Label18)
        Me.PanelWrapperDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapperDashboard.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapperDashboard.Name = "PanelWrapperDashboard"
        Me.PanelWrapperDashboard.Size = New System.Drawing.Size(668, 468)
        Me.PanelWrapperDashboard.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(219, 406)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 30)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "√ Lezat   √ Sehat  √ Terjangkau"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(191, 376)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(286, 30)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Toko Roti Terbaik Di Indonesia"
        '
        'lblJmlPenjualan
        '
        Me.lblJmlPenjualan.BackColor = System.Drawing.Color.White
        Me.lblJmlPenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlPenjualan.Location = New System.Drawing.Point(41, 276)
        Me.lblJmlPenjualan.Name = "lblJmlPenjualan"
        Me.lblJmlPenjualan.Size = New System.Drawing.Size(182, 30)
        Me.lblJmlPenjualan.TabIndex = 0
        Me.lblJmlPenjualan.Text = "Penjualan Hari Ini"
        '
        'lblJmlAktivitas
        '
        Me.lblJmlAktivitas.BackColor = System.Drawing.Color.White
        Me.lblJmlAktivitas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlAktivitas.Location = New System.Drawing.Point(378, 276)
        Me.lblJmlAktivitas.Name = "lblJmlAktivitas"
        Me.lblJmlAktivitas.Size = New System.Drawing.Size(182, 30)
        Me.lblJmlAktivitas.TabIndex = 0
        Me.lblJmlAktivitas.Text = "Aktivitas Hari Ini"
        '
        'lblJmlKaryawan
        '
        Me.lblJmlKaryawan.BackColor = System.Drawing.Color.White
        Me.lblJmlKaryawan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlKaryawan.Location = New System.Drawing.Point(378, 100)
        Me.lblJmlKaryawan.Name = "lblJmlKaryawan"
        Me.lblJmlKaryawan.Size = New System.Drawing.Size(182, 30)
        Me.lblJmlKaryawan.TabIndex = 0
        Me.lblJmlKaryawan.Text = "Karyawan"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(41, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(182, 30)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Data Roti"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(35, 208)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(151, 43)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "100"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(373, 208)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(151, 43)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "200"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(373, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(151, 43)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "10"
        '
        'lblJmlRoti
        '
        Me.lblJmlRoti.BackColor = System.Drawing.Color.White
        Me.lblJmlRoti.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlRoti.Location = New System.Drawing.Point(35, 32)
        Me.lblJmlRoti.Name = "lblJmlRoti"
        Me.lblJmlRoti.Size = New System.Drawing.Size(151, 43)
        Me.lblJmlRoti.TabIndex = 0
        Me.lblJmlRoti.Text = "100"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(24, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(300, 150)
        Me.Label16.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(352, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(300, 150)
        Me.Label17.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(352, 194)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(300, 150)
        Me.Label19.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(24, 194)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(300, 150)
        Me.Label18.TabIndex = 0
        '
        'PanelWrapperRoti
        '
        Me.PanelWrapperRoti.Controls.Add(Me.tabelDataRoti)
        Me.PanelWrapperRoti.Controls.Add(Me.Label8)
        Me.PanelWrapperRoti.Controls.Add(Me.PanelHeaderRoti)
        Me.PanelWrapperRoti.Controls.Add(Me.Label6)
        Me.PanelWrapperRoti.Controls.Add(Me.Label5)
        Me.PanelWrapperRoti.Controls.Add(Me.Label4)
        Me.PanelWrapperRoti.Controls.Add(Me.Label1)
        Me.PanelWrapperRoti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapperRoti.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapperRoti.Name = "PanelWrapperRoti"
        Me.PanelWrapperRoti.Size = New System.Drawing.Size(668, 468)
        Me.PanelWrapperRoti.TabIndex = 0
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
        Me.tabelDataRoti.Location = New System.Drawing.Point(10, 80)
        Me.tabelDataRoti.MultiSelect = False
        Me.tabelDataRoti.Name = "tabelDataRoti"
        Me.tabelDataRoti.ReadOnly = True
        Me.tabelDataRoti.Size = New System.Drawing.Size(648, 378)
        Me.tabelDataRoti.TabIndex = 10
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
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(648, 10)
        Me.Label8.TabIndex = 9
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeaderRoti
        '
        Me.PanelHeaderRoti.Controls.Add(Me.btnTambahRoti)
        Me.PanelHeaderRoti.Controls.Add(Me.btnEditRoti)
        Me.PanelHeaderRoti.Controls.Add(Me.btnHapusRoti)
        Me.PanelHeaderRoti.Controls.Add(Me.txCariRoti)
        Me.PanelHeaderRoti.Controls.Add(Me.Label7)
        Me.PanelHeaderRoti.Controls.Add(Me.Label15)
        Me.PanelHeaderRoti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderRoti.Location = New System.Drawing.Point(10, 10)
        Me.PanelHeaderRoti.Name = "PanelHeaderRoti"
        Me.PanelHeaderRoti.Size = New System.Drawing.Size(648, 60)
        Me.PanelHeaderRoti.TabIndex = 0
        '
        'btnTambahRoti
        '
        Me.btnTambahRoti.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnTambahRoti.FlatAppearance.BorderSize = 0
        Me.btnTambahRoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahRoti.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahRoti.ForeColor = System.Drawing.Color.White
        Me.btnTambahRoti.Location = New System.Drawing.Point(330, 10)
        Me.btnTambahRoti.Name = "btnTambahRoti"
        Me.btnTambahRoti.Size = New System.Drawing.Size(100, 40)
        Me.btnTambahRoti.TabIndex = 8
        Me.btnTambahRoti.Text = "Tambah"
        Me.btnTambahRoti.UseVisualStyleBackColor = False
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
        Me.Label15.Size = New System.Drawing.Size(648, 60)
        Me.Label15.TabIndex = 10
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(648, 10)
        Me.Label6.TabIndex = 8
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(648, 10)
        Me.Label5.TabIndex = 7
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(658, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 468)
        Me.Label4.TabIndex = 6
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 468)
        Me.Label1.TabIndex = 5
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWrapperKasir
        '
        Me.PanelWrapperKasir.Controls.Add(Me.Label37)
        Me.PanelWrapperKasir.Controls.Add(Me.PanelFooterKasir)
        Me.PanelWrapperKasir.Controls.Add(Me.tabelDataKasir)
        Me.PanelWrapperKasir.Controls.Add(Me.Label39)
        Me.PanelWrapperKasir.Controls.Add(Me.PanelHeaderKasir)
        Me.PanelWrapperKasir.Controls.Add(Me.Label33)
        Me.PanelWrapperKasir.Controls.Add(Me.Label34)
        Me.PanelWrapperKasir.Controls.Add(Me.Label35)
        Me.PanelWrapperKasir.Controls.Add(Me.Label36)
        Me.PanelWrapperKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapperKasir.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapperKasir.Name = "PanelWrapperKasir"
        Me.PanelWrapperKasir.Size = New System.Drawing.Size(668, 468)
        Me.PanelWrapperKasir.TabIndex = 9
        '
        'Label37
        '
        Me.Label37.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(10, 368)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(648, 10)
        Me.Label37.TabIndex = 9
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFooterKasir
        '
        Me.PanelFooterKasir.BackColor = System.Drawing.Color.White
        Me.PanelFooterKasir.Controls.Add(Me.txDiskonBelanja)
        Me.PanelFooterKasir.Controls.Add(Me.txKembalian)
        Me.PanelFooterKasir.Controls.Add(Me.txBayar)
        Me.PanelFooterKasir.Controls.Add(Me.txTotalBelanja)
        Me.PanelFooterKasir.Controls.Add(Me.Label46)
        Me.PanelFooterKasir.Controls.Add(Me.Label48)
        Me.PanelFooterKasir.Controls.Add(Me.btnBayar)
        Me.PanelFooterKasir.Controls.Add(Me.Label47)
        Me.PanelFooterKasir.Controls.Add(Me.Label45)
        Me.PanelFooterKasir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooterKasir.Location = New System.Drawing.Point(10, 378)
        Me.PanelFooterKasir.Name = "PanelFooterKasir"
        Me.PanelFooterKasir.Size = New System.Drawing.Size(648, 80)
        Me.PanelFooterKasir.TabIndex = 11
        '
        'txDiskonBelanja
        '
        Me.txDiskonBelanja.Location = New System.Drawing.Point(79, 52)
        Me.txDiskonBelanja.Name = "txDiskonBelanja"
        Me.txDiskonBelanja.Size = New System.Drawing.Size(125, 20)
        Me.txDiskonBelanja.TabIndex = 5
        '
        'txKembalian
        '
        Me.txKembalian.Enabled = False
        Me.txKembalian.Location = New System.Drawing.Point(330, 53)
        Me.txKembalian.Name = "txKembalian"
        Me.txKembalian.Size = New System.Drawing.Size(125, 20)
        Me.txKembalian.TabIndex = 5
        '
        'txBayar
        '
        Me.txBayar.Location = New System.Drawing.Point(330, 14)
        Me.txBayar.Name = "txBayar"
        Me.txBayar.Size = New System.Drawing.Size(125, 20)
        Me.txBayar.TabIndex = 5
        '
        'txTotalBelanja
        '
        Me.txTotalBelanja.Enabled = False
        Me.txTotalBelanja.Location = New System.Drawing.Point(79, 14)
        Me.txTotalBelanja.Name = "txTotalBelanja"
        Me.txTotalBelanja.Size = New System.Drawing.Size(125, 20)
        Me.txTotalBelanja.TabIndex = 5
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(-1, 42)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(59, 40)
        Me.Label46.TabIndex = 4
        Me.Label46.Text = "Diskon"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(247, 42)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(78, 40)
        Me.Label48.TabIndex = 4
        Me.Label48.Text = "Kembalian"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBayar.FlatAppearance.BorderSize = 0
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Location = New System.Drawing.Point(559, 19)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(83, 40)
        Me.btnBayar.TabIndex = 6
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(267, -2)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(58, 40)
        Me.Label47.TabIndex = 4
        Me.Label47.Text = "Bayar"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(-1, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(89, 40)
        Me.Label45.TabIndex = 4
        Me.Label45.Text = "Total Belanja"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabelDataKasir
        '
        Me.tabelDataKasir.AllowUserToAddRows = False
        Me.tabelDataKasir.AllowUserToDeleteRows = False
        Me.tabelDataKasir.AllowUserToOrderColumns = True
        Me.tabelDataKasir.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataKasir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataKasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode_roti, Me.nama_roti, Me.harga, Me.qty, Me.diskon, Me.sub_total, Me.stok_sedia})
        Me.tabelDataKasir.Location = New System.Drawing.Point(10, 189)
        Me.tabelDataKasir.MultiSelect = False
        Me.tabelDataKasir.Name = "tabelDataKasir"
        Me.tabelDataKasir.ReadOnly = True
        Me.tabelDataKasir.Size = New System.Drawing.Size(648, 269)
        Me.tabelDataKasir.TabIndex = 10
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 40
        '
        'kode_roti
        '
        Me.kode_roti.HeaderText = "Kode Roti"
        Me.kode_roti.Name = "kode_roti"
        Me.kode_roti.ReadOnly = True
        '
        'nama_roti
        '
        Me.nama_roti.HeaderText = "Nama Roti"
        Me.nama_roti.Name = "nama_roti"
        Me.nama_roti.ReadOnly = True
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'diskon
        '
        Me.diskon.HeaderText = "Diskon(%)"
        Me.diskon.Name = "diskon"
        Me.diskon.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'stok_sedia
        '
        Me.stok_sedia.HeaderText = "stokSedia"
        Me.stok_sedia.Name = "stok_sedia"
        Me.stok_sedia.ReadOnly = True
        Me.stok_sedia.Visible = False
        '
        'Label39
        '
        Me.Label39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(10, 183)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(648, 10)
        Me.Label39.TabIndex = 12
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeaderKasir
        '
        Me.PanelHeaderKasir.Controls.Add(Me.btnCariKodeRoti)
        Me.PanelHeaderKasir.Controls.Add(Me.txTotalPembayaran)
        Me.PanelHeaderKasir.Controls.Add(Me.tglKasir)
        Me.PanelHeaderKasir.Controls.Add(Me.txQty)
        Me.PanelHeaderKasir.Controls.Add(Me.txDiskon)
        Me.PanelHeaderKasir.Controls.Add(Me.txNamaRoti)
        Me.PanelHeaderKasir.Controls.Add(Me.txKodeRoti)
        Me.PanelHeaderKasir.Controls.Add(Me.Label42)
        Me.PanelHeaderKasir.Controls.Add(Me.Label44)
        Me.PanelHeaderKasir.Controls.Add(Me.Label49)
        Me.PanelHeaderKasir.Controls.Add(Me.txStrukKasir)
        Me.PanelHeaderKasir.Controls.Add(Me.Label43)
        Me.PanelHeaderKasir.Controls.Add(Me.Label41)
        Me.PanelHeaderKasir.Controls.Add(Me.Label40)
        Me.PanelHeaderKasir.Controls.Add(Me.Label31)
        Me.PanelHeaderKasir.Controls.Add(Me.Label38)
        Me.PanelHeaderKasir.Controls.Add(Me.Label30)
        Me.PanelHeaderKasir.Controls.Add(Me.Label32)
        Me.PanelHeaderKasir.Controls.Add(Me.txHargaRoti)
        Me.PanelHeaderKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderKasir.Location = New System.Drawing.Point(10, 10)
        Me.PanelHeaderKasir.Name = "PanelHeaderKasir"
        Me.PanelHeaderKasir.Size = New System.Drawing.Size(648, 173)
        Me.PanelHeaderKasir.TabIndex = 0
        '
        'btnCariKodeRoti
        '
        Me.btnCariKodeRoti.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCariKodeRoti.FlatAppearance.BorderSize = 0
        Me.btnCariKodeRoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariKodeRoti.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariKodeRoti.ForeColor = System.Drawing.Color.White
        Me.btnCariKodeRoti.Location = New System.Drawing.Point(270, 54)
        Me.btnCariKodeRoti.Name = "btnCariKodeRoti"
        Me.btnCariKodeRoti.Size = New System.Drawing.Size(20, 20)
        Me.btnCariKodeRoti.TabIndex = 6
        Me.btnCariKodeRoti.Text = "?"
        Me.btnCariKodeRoti.UseVisualStyleBackColor = False
        '
        'txTotalPembayaran
        '
        Me.txTotalPembayaran.Enabled = False
        Me.txTotalPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotalPembayaran.Location = New System.Drawing.Point(368, 90)
        Me.txTotalPembayaran.Name = "txTotalPembayaran"
        Me.txTotalPembayaran.Size = New System.Drawing.Size(268, 47)
        Me.txTotalPembayaran.TabIndex = 5
        '
        'tglKasir
        '
        Me.tglKasir.Location = New System.Drawing.Point(436, 10)
        Me.tglKasir.Name = "tglKasir"
        Me.tglKasir.Size = New System.Drawing.Size(200, 20)
        Me.tglKasir.TabIndex = 14
        '
        'txQty
        '
        Me.txQty.Location = New System.Drawing.Point(90, 83)
        Me.txQty.Name = "txQty"
        Me.txQty.Size = New System.Drawing.Size(200, 20)
        Me.txQty.TabIndex = 5
        '
        'txDiskon
        '
        Me.txDiskon.Enabled = False
        Me.txDiskon.Location = New System.Drawing.Point(90, 139)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(200, 20)
        Me.txDiskon.TabIndex = 5
        '
        'txNamaRoti
        '
        Me.txNamaRoti.Enabled = False
        Me.txNamaRoti.Location = New System.Drawing.Point(90, 111)
        Me.txNamaRoti.Name = "txNamaRoti"
        Me.txNamaRoti.Size = New System.Drawing.Size(200, 20)
        Me.txNamaRoti.TabIndex = 5
        '
        'txKodeRoti
        '
        Me.txKodeRoti.Location = New System.Drawing.Point(90, 55)
        Me.txKodeRoti.Name = "txKodeRoti"
        Me.txKodeRoti.Size = New System.Drawing.Size(174, 20)
        Me.txKodeRoti.TabIndex = 5
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(0, 71)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(69, 40)
        Me.Label42.TabIndex = 4
        Me.Label42.Text = "QTY"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(3, 124)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(94, 40)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Diskon (%)"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.White
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(364, 51)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(272, 38)
        Me.Label49.TabIndex = 4
        Me.Label49.Text = "Total Pembayaran"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txStrukKasir
        '
        Me.txStrukKasir.Enabled = False
        Me.txStrukKasir.Location = New System.Drawing.Point(90, 10)
        Me.txStrukKasir.Name = "txStrukKasir"
        Me.txStrukKasir.Size = New System.Drawing.Size(200, 20)
        Me.txStrukKasir.TabIndex = 5
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(-3, 96)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 40)
        Me.Label43.TabIndex = 4
        Me.Label43.Text = "Nama Roti"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(-1, 45)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(100, 40)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Kode Roti"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(342, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(85, 40)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "Tanggal"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(-1, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(100, 40)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "No Struk"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(0, 41)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(648, 132)
        Me.Label38.TabIndex = 13
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(0, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(648, 1)
        Me.Label30.TabIndex = 9
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(0, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(648, 40)
        Me.Label32.TabIndex = 10
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txHargaRoti
        '
        Me.txHargaRoti.Enabled = False
        Me.txHargaRoti.Location = New System.Drawing.Point(617, 55)
        Me.txHargaRoti.Name = "txHargaRoti"
        Me.txHargaRoti.Size = New System.Drawing.Size(25, 20)
        Me.txHargaRoti.TabIndex = 5
        Me.txHargaRoti.Visible = False
        '
        'Label33
        '
        Me.Label33.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(10, 458)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(648, 10)
        Me.Label33.TabIndex = 8
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(10, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(648, 10)
        Me.Label34.TabIndex = 7
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(658, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(10, 468)
        Me.Label35.TabIndex = 6
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(0, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(10, 468)
        Me.Label36.TabIndex = 5
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.lblKeterangan)
        Me.PanelHeader.Controls.Add(Me.lblMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(200, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(668, 100)
        Me.PanelHeader.TabIndex = 0
        '
        'lblKeterangan
        '
        Me.lblKeterangan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKeterangan.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblKeterangan.Location = New System.Drawing.Point(0, 70)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(668, 30)
        Me.lblKeterangan.TabIndex = 4
        Me.lblKeterangan.Text = "Tekan F1 Untuk Mencari  |  Tekan F2 Untuk Menambah Data  |  Tekan F3 Untuk Mengha" &
    "pus"
        Me.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMenu
        '
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Black
        Me.lblMenu.Location = New System.Drawing.Point(0, 30)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(668, 40)
        Me.lblMenu.TabIndex = 3
        Me.lblMenu.Text = "Halaman Awal"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.bnMinimize)
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(668, 30)
        Me.PanelWindowBar.TabIndex = 1
        '
        'bnMinimize
        '
        Me.bnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.bnMinimize.FlatAppearance.BorderSize = 0
        Me.bnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnMinimize.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnMinimize.ForeColor = System.Drawing.Color.Black
        Me.bnMinimize.Location = New System.Drawing.Point(608, 0)
        Me.bnMinimize.Name = "bnMinimize"
        Me.bnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.bnMinimize.TabIndex = 7
        Me.bnMinimize.Text = "-"
        Me.bnMinimize.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(638, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 6
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PanelSideBar
        '
        Me.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.btnLogOut)
        Me.PanelSideBar.Controls.Add(Me.Label13)
        Me.PanelSideBar.Controls.Add(Me.btnRiwayat)
        Me.PanelSideBar.Controls.Add(Me.Label12)
        Me.PanelSideBar.Controls.Add(Me.btnKaryawan)
        Me.PanelSideBar.Controls.Add(Me.Label11)
        Me.PanelSideBar.Controls.Add(Me.btnRoti)
        Me.PanelSideBar.Controls.Add(Me.Label9)
        Me.PanelSideBar.Controls.Add(Me.btnKasir)
        Me.PanelSideBar.Controls.Add(Me.Label10)
        Me.PanelSideBar.Controls.Add(Me.btnDashboard)
        Me.PanelSideBar.Controls.Add(Me.Label14)
        Me.PanelSideBar.Controls.Add(Me.PanelJudul)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(200, 568)
        Me.PanelSideBar.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(0, 508)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 60)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Keluar Sesi"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Location = New System.Drawing.Point(0, 405)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 1)
        Me.Label13.TabIndex = 15
        '
        'btnRiwayat
        '
        Me.btnRiwayat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRiwayat.FlatAppearance.BorderSize = 0
        Me.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRiwayat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRiwayat.ForeColor = System.Drawing.Color.Black
        Me.btnRiwayat.Location = New System.Drawing.Point(0, 345)
        Me.btnRiwayat.Name = "btnRiwayat"
        Me.btnRiwayat.Size = New System.Drawing.Size(200, 60)
        Me.btnRiwayat.TabIndex = 11
        Me.btnRiwayat.Text = "      Riwayat Aktivitas"
        Me.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRiwayat.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Location = New System.Drawing.Point(0, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 1)
        Me.Label12.TabIndex = 14
        '
        'btnKaryawan
        '
        Me.btnKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKaryawan.FlatAppearance.BorderSize = 0
        Me.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaryawan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaryawan.ForeColor = System.Drawing.Color.Black
        Me.btnKaryawan.Location = New System.Drawing.Point(0, 284)
        Me.btnKaryawan.Name = "btnKaryawan"
        Me.btnKaryawan.Size = New System.Drawing.Size(200, 60)
        Me.btnKaryawan.TabIndex = 9
        Me.btnKaryawan.Text = "      Data Karyawan"
        Me.btnKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaryawan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Location = New System.Drawing.Point(0, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 1)
        Me.Label11.TabIndex = 13
        '
        'btnRoti
        '
        Me.btnRoti.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRoti.FlatAppearance.BorderSize = 0
        Me.btnRoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoti.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoti.ForeColor = System.Drawing.Color.Black
        Me.btnRoti.Location = New System.Drawing.Point(0, 223)
        Me.btnRoti.Name = "btnRoti"
        Me.btnRoti.Size = New System.Drawing.Size(200, 60)
        Me.btnRoti.TabIndex = 8
        Me.btnRoti.Text = "      Data Roti"
        Me.btnRoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoti.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 1)
        Me.Label9.TabIndex = 0
        '
        'btnKasir
        '
        Me.btnKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKasir.FlatAppearance.BorderSize = 0
        Me.btnKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKasir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKasir.ForeColor = System.Drawing.Color.Black
        Me.btnKasir.Location = New System.Drawing.Point(0, 162)
        Me.btnKasir.Name = "btnKasir"
        Me.btnKasir.Size = New System.Drawing.Size(200, 60)
        Me.btnKasir.TabIndex = 10
        Me.btnKasir.Text = "      Kasir"
        Me.btnKasir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKasir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(0, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 1)
        Me.Label10.TabIndex = 12
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.Location = New System.Drawing.Point(0, 101)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 60)
        Me.btnDashboard.TabIndex = 5
        Me.btnDashboard.Text = "      Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Location = New System.Drawing.Point(0, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 1)
        Me.Label14.TabIndex = 16
        '
        'PanelJudul
        '
        Me.PanelJudul.BackColor = System.Drawing.Color.IndianRed
        Me.PanelJudul.Controls.Add(Me.lblAdmin)
        Me.PanelJudul.Controls.Add(Me.Label3)
        Me.PanelJudul.Controls.Add(Me.LabelJudul)
        Me.PanelJudul.Controls.Add(Me.Label2)
        Me.PanelJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelJudul.Location = New System.Drawing.Point(0, 0)
        Me.PanelJudul.Name = "PanelJudul"
        Me.PanelJudul.Size = New System.Drawing.Size(200, 100)
        Me.PanelJudul.TabIndex = 7
        '
        'lblAdmin
        '
        Me.lblAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.White
        Me.lblAdmin.Location = New System.Drawing.Point(51, 61)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAdmin.Size = New System.Drawing.Size(149, 39)
        Me.lblAdmin.TabIndex = 3
        Me.lblAdmin.Text = "Admin"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(22, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "O"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelJudul
        '
        Me.LabelJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelJudul.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.Color.White
        Me.LabelJudul.Location = New System.Drawing.Point(29, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(171, 61)
        Me.LabelJudul.TabIndex = 2
        Me.LabelJudul.Text = "The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bread" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shop"
        Me.LabelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(29, 100)
        Me.Label2.TabIndex = 4
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RotiTableAdapter
        '
        Me.RotiTableAdapter.ClearBeforeFill = True
        '
        'Header_penjualanTableAdapter
        '
        Me.Header_penjualanTableAdapter.ClearBeforeFill = True
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 570)
        Me.Controls.Add(Me.PanelForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelForm.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelWrapperDashboard.ResumeLayout(False)
        Me.PanelWrapperRoti.ResumeLayout(False)
        CType(Me.tabelDataRoti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TheBreadShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderRoti.ResumeLayout(False)
        Me.PanelHeaderRoti.PerformLayout()
        Me.PanelWrapperKasir.ResumeLayout(False)
        Me.PanelFooterKasir.ResumeLayout(False)
        Me.PanelFooterKasir.PerformLayout()
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderKasir.ResumeLayout(False)
        Me.PanelHeaderKasir.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelSideBar.ResumeLayout(False)
        Me.PanelJudul.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PanelJudul As Panel
    Friend WithEvents lblAdmin As Label
    Friend WithEvents LabelJudul As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents bnMinimize As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnRiwayat As Button
    Friend WithEvents btnKasir As Button
    Friend WithEvents btnKaryawan As Button
    Friend WithEvents btnRoti As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelWrapperRoti As Panel
    Friend WithEvents tabelDataRoti As DataGridView
    Friend WithEvents PanelHeaderRoti As Panel
    Friend WithEvents btnTambahRoti As Button
    Friend WithEvents btnEditRoti As Button
    Friend WithEvents btnHapusRoti As Button
    Friend WithEvents txCariRoti As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TheBreadShopDataSet As TheBreadShopDataSet
    Friend WithEvents RotiBindingSource As BindingSource
    Friend WithEvents RotiTableAdapter As TheBreadShopDataSetTableAdapters.rotiTableAdapter
    Friend WithEvents PanelWrapperDashboard As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents KoderotiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamarotiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblJmlPenjualan As Label
    Friend WithEvents lblJmlAktivitas As Label
    Friend WithEvents lblJmlKaryawan As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblJmlRoti As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PanelWrapperKasir As Panel
    Friend WithEvents tabelDataKasir As DataGridView
    Friend WithEvents Label30 As Label
    Friend WithEvents PanelHeaderKasir As Panel
    Friend WithEvents btnBayar As Button
    Friend WithEvents txStrukKasir As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Header_penjualanTableAdapter As TheBreadShopDataSetTableAdapters.header_penjualanTableAdapter
    Friend WithEvents PenjualanTableAdapter As TheBreadShopDataSetTableAdapters.penjualanTableAdapter
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode_roti As DataGridViewTextBoxColumn
    Friend WithEvents nama_roti As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents diskon As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents Label37 As Label
    Friend WithEvents PanelFooterKasir As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents tglKasir As DateTimePicker
    Friend WithEvents Label40 As Label
    Friend WithEvents txQty As TextBox
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents txNamaRoti As TextBox
    Friend WithEvents txKodeRoti As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents btnCariKodeRoti As Button
    Friend WithEvents Label45 As Label
    Friend WithEvents txTotalBelanja As TextBox
    Friend WithEvents txDiskonBelanja As TextBox
    Friend WithEvents txTotalPembayaran As TextBox
    Friend WithEvents txKembalian As TextBox
    Friend WithEvents txBayar As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents txHargaRoti As TextBox
    Friend WithEvents stok_sedia As DataGridViewTextBoxColumn
End Class
