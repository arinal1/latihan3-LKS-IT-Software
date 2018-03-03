<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRoti
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txKode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txStok = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUlang = New System.Windows.Forms.Button()
        Me.RotiTableAdapter = New latihan3.TheBreadShopDataSetTableAdapters.rotiTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.PanelHeader.TabIndex = 1
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
        Me.Label1.Location = New System.Drawing.Point(128, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Form Data Roti"
        '
        'txKode
        '
        Me.txKode.Location = New System.Drawing.Point(135, 128)
        Me.txKode.Name = "txKode"
        Me.txKode.Size = New System.Drawing.Size(266, 20)
        Me.txKode.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Kode Roti"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Roti"
        '
        'txNama
        '
        Me.txNama.Location = New System.Drawing.Point(135, 171)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(266, 20)
        Me.txNama.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Harga"
        '
        'txHarga
        '
        Me.txHarga.Location = New System.Drawing.Point(135, 214)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(266, 20)
        Me.txHarga.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Diskon"
        '
        'txDiskon
        '
        Me.txDiskon.Location = New System.Drawing.Point(135, 257)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(266, 20)
        Me.txDiskon.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok"
        '
        'txStok
        '
        Me.txStok.Location = New System.Drawing.Point(135, 300)
        Me.txStok.Name = "txStok"
        Me.txStok.Size = New System.Drawing.Size(266, 20)
        Me.txStok.TabIndex = 4
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(301, 356)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 40)
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnUlang
        '
        Me.btnUlang.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUlang.FlatAppearance.BorderSize = 0
        Me.btnUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUlang.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUlang.ForeColor = System.Drawing.Color.White
        Me.btnUlang.Location = New System.Drawing.Point(186, 356)
        Me.btnUlang.Name = "btnUlang"
        Me.btnUlang.Size = New System.Drawing.Size(100, 40)
        Me.btnUlang.TabIndex = 7
        Me.btnUlang.Text = "Ulang"
        Me.btnUlang.UseVisualStyleBackColor = False
        '
        'RotiTableAdapter
        '
        Me.RotiTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnUlang)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.txStok)
        Me.Panel1.Controls.Add(Me.txDiskon)
        Me.Panel1.Controls.Add(Me.txHarga)
        Me.Panel1.Controls.Add(Me.txNama)
        Me.Panel1.Controls.Add(Me.txKode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 418)
        Me.Panel1.TabIndex = 8
        '
        'formRoti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 418)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formRoti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formRoti"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelWindowBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txKode As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txStok As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUlang As Button
    Friend WithEvents RotiTableAdapter As TheBreadShopDataSetTableAdapters.rotiTableAdapter
    Friend WithEvents Panel1 As Panel
End Class
