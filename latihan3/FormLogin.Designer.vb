<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txPassword = New System.Windows.Forms.TextBox()
        Me.txID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.KaryawanTableAdapter = New latihan3.TheBreadShopDataSetTableAdapters.karyawanTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.Controls.Add(Me.Panel1)
        Me.PanelForm.Controls.Add(Me.PanelHeader)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(0, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(407, 373)
        Me.PanelForm.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.txPassword)
        Me.Panel1.Controls.Add(Me.txID)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 269)
        Me.Panel1.TabIndex = 0
        '
        'txPassword
        '
        Me.txPassword.Location = New System.Drawing.Point(40, 149)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.Size = New System.Drawing.Size(327, 20)
        Me.txPassword.TabIndex = 1
        Me.txPassword.UseSystemPasswordChar = True
        '
        'txID
        '
        Me.txID.Location = New System.Drawing.Point(40, 75)
        Me.txID.Name = "txID"
        Me.txID.Size = New System.Drawing.Size(327, 20)
        Me.txID.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "ID Karyawan"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(40, 203)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(327, 42)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Sign In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(40, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(327, 24)
        Me.Label5.TabIndex = 2
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(407, 104)
        Me.PanelHeader.TabIndex = 0
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(407, 30)
        Me.PanelWindowBar.TabIndex = 1
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Black
        Me.btnKeluar.Location = New System.Drawing.Point(377, 0)
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
        Me.Label1.Location = New System.Drawing.Point(154, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sign In"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_karyawan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_karyawan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_karyawan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_karyawan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "shift"
        Me.DataGridViewTextBoxColumn3.HeaderText = "shift"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "password"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "level_admin"
        Me.DataGridViewTextBoxColumn5.HeaderText = "level_admin"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "foto"
        Me.DataGridViewImageColumn1.HeaderText = "foto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 269)
        Me.Label3.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Location = New System.Drawing.Point(367, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 269)
        Me.Label4.TabIndex = 1
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 373)
        Me.Controls.Add(Me.PanelForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        Me.PanelForm.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txPassword As TextBox
    Friend WithEvents txID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KaryawanTableAdapter As TheBreadShopDataSetTableAdapters.karyawanTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
