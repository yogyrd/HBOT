<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputTransaksiTerapi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputTransaksiTerapi))
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nud_menit = New System.Windows.Forms.NumericUpDown()
        Me.nud_jam = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_jmlterapi = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tb_ambil = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_officer = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_tender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_operator = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_perawat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_dokter = New System.Windows.Forms.ComboBox()
        Me.tb_nmpasien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_nmpelanggan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_tglterapi = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_kddaftar = New System.Windows.Forms.TextBox()
        Me.lbl_noTransaksi = New System.Windows.Forms.Label()
        Me.pnl_toolbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nud_menit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_jam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_toolbar
        '
        Me.pnl_toolbar.BackColor = System.Drawing.Color.AliceBlue
        Me.pnl_toolbar.Controls.Add(Me.btn_close)
        Me.pnl_toolbar.Controls.Add(Me.btn_save)
        Me.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_toolbar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 202)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(774, 63)
        Me.pnl_toolbar.TabIndex = 26
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(670, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 40)
        Me.btn_close.TabIndex = 6
        Me.btn_close.Text = "Batal"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(572, 11)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(92, 40)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Simpan"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.nud_menit)
        Me.Panel1.Controls.Add(Me.nud_jam)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tb_jmlterapi)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.tb_ambil)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cmb_officer)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmb_tender)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmb_operator)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmb_perawat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_dokter)
        Me.Panel1.Controls.Add(Me.tb_nmpasien)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tb_nmpelanggan)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.dtp_tglterapi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tb_kddaftar)
        Me.Panel1.Controls.Add(Me.lbl_noTransaksi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 193)
        Me.Panel1.TabIndex = 27
        '
        'nud_menit
        '
        Me.nud_menit.Location = New System.Drawing.Point(200, 118)
        Me.nud_menit.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nud_menit.Name = "nud_menit"
        Me.nud_menit.Size = New System.Drawing.Size(43, 22)
        Me.nud_menit.TabIndex = 6
        Me.nud_menit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nud_jam
        '
        Me.nud_jam.Location = New System.Drawing.Point(140, 118)
        Me.nud_jam.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nud_jam.Name = "nud_jam"
        Me.nud_jam.Size = New System.Drawing.Size(43, 22)
        Me.nud_jam.TabIndex = 5
        Me.nud_jam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(186, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 16)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = ":"
        '
        'tb_jmlterapi
        '
        Me.tb_jmlterapi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_jmlterapi.Enabled = False
        Me.tb_jmlterapi.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_jmlterapi.Location = New System.Drawing.Point(231, 62)
        Me.tb_jmlterapi.Name = "tb_jmlterapi"
        Me.tb_jmlterapi.Size = New System.Drawing.Size(48, 22)
        Me.tb_jmlterapi.TabIndex = 3
        Me.tb_jmlterapi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(194, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 16)
        Me.Label21.TabIndex = 90
        Me.Label21.Text = "Dari"
        '
        'tb_ambil
        '
        Me.tb_ambil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_ambil.Enabled = False
        Me.tb_ambil.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ambil.Location = New System.Drawing.Point(140, 62)
        Me.tb_ambil.Name = "tb_ambil"
        Me.tb_ambil.Size = New System.Drawing.Size(48, 22)
        Me.tb_ambil.TabIndex = 2
        Me.tb_ambil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(27, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 16)
        Me.Label20.TabIndex = 88
        Me.Label20.Text = "Pengambilan Ke-"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(438, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Nama Officer"
        '
        'cmb_officer
        '
        Me.cmb_officer.FormattingEnabled = True
        Me.cmb_officer.Location = New System.Drawing.Point(528, 126)
        Me.cmb_officer.Name = "cmb_officer"
        Me.cmb_officer.Size = New System.Drawing.Size(225, 24)
        Me.cmb_officer.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(438, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Nama Tender"
        '
        'cmb_tender
        '
        Me.cmb_tender.FormattingEnabled = True
        Me.cmb_tender.Location = New System.Drawing.Point(528, 96)
        Me.cmb_tender.Name = "cmb_tender"
        Me.cmb_tender.Size = New System.Drawing.Size(225, 24)
        Me.cmb_tender.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(426, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Nama Operator"
        '
        'cmb_operator
        '
        Me.cmb_operator.FormattingEnabled = True
        Me.cmb_operator.Location = New System.Drawing.Point(528, 66)
        Me.cmb_operator.Name = "cmb_operator"
        Me.cmb_operator.Size = New System.Drawing.Size(225, 24)
        Me.cmb_operator.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Nama Perawat"
        '
        'cmb_perawat
        '
        Me.cmb_perawat.FormattingEnabled = True
        Me.cmb_perawat.Location = New System.Drawing.Point(528, 36)
        Me.cmb_perawat.Name = "cmb_perawat"
        Me.cmb_perawat.Size = New System.Drawing.Size(225, 24)
        Me.cmb_perawat.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(438, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Nama Dokter"
        '
        'cmb_dokter
        '
        Me.cmb_dokter.FormattingEnabled = True
        Me.cmb_dokter.Location = New System.Drawing.Point(528, 6)
        Me.cmb_dokter.Name = "cmb_dokter"
        Me.cmb_dokter.Size = New System.Drawing.Size(225, 24)
        Me.cmb_dokter.TabIndex = 8
        '
        'tb_nmpasien
        '
        Me.tb_nmpasien.BackColor = System.Drawing.SystemColors.Window
        Me.tb_nmpasien.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nmpasien.Location = New System.Drawing.Point(140, 146)
        Me.tb_nmpasien.Name = "tb_nmpasien"
        Me.tb_nmpasien.Size = New System.Drawing.Size(233, 22)
        Me.tb_nmpasien.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Nama Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Jam Terapi"
        '
        'tb_nmpelanggan
        '
        Me.tb_nmpelanggan.BackColor = System.Drawing.SystemColors.Window
        Me.tb_nmpelanggan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nmpelanggan.Location = New System.Drawing.Point(140, 34)
        Me.tb_nmpelanggan.Name = "tb_nmpelanggan"
        Me.tb_nmpelanggan.ReadOnly = True
        Me.tb_nmpelanggan.Size = New System.Drawing.Size(233, 22)
        Me.tb_nmpelanggan.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(44, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 16)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Tanggal Terapi"
        '
        'dtp_tglterapi
        '
        Me.dtp_tglterapi.CustomFormat = "yyyy-MM-dd"
        Me.dtp_tglterapi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglterapi.Location = New System.Drawing.Point(140, 90)
        Me.dtp_tglterapi.Name = "dtp_tglterapi"
        Me.dtp_tglterapi.Size = New System.Drawing.Size(115, 22)
        Me.dtp_tglterapi.TabIndex = 4
        Me.dtp_tglterapi.Value = New Date(2017, 6, 9, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Pelanggan"
        '
        'tb_kddaftar
        '
        Me.tb_kddaftar.BackColor = System.Drawing.SystemColors.Window
        Me.tb_kddaftar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kddaftar.Location = New System.Drawing.Point(140, 6)
        Me.tb_kddaftar.Name = "tb_kddaftar"
        Me.tb_kddaftar.Size = New System.Drawing.Size(233, 22)
        Me.tb_kddaftar.TabIndex = 0
        '
        'lbl_noTransaksi
        '
        Me.lbl_noTransaksi.AutoSize = True
        Me.lbl_noTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noTransaksi.Location = New System.Drawing.Point(58, 9)
        Me.lbl_noTransaksi.Name = "lbl_noTransaksi"
        Me.lbl_noTransaksi.Size = New System.Drawing.Size(76, 16)
        Me.lbl_noTransaksi.TabIndex = 0
        Me.lbl_noTransaksi.Text = "Kode Daftar"
        '
        'InputTransaksiTerapi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(774, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InputTransaksiTerapi"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Input Transaksi Terapi"
        Me.pnl_toolbar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nud_menit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_jam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_tglterapi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_kddaftar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_noTransaksi As System.Windows.Forms.Label
    Friend WithEvents tb_nmpelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_nmpasien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_tender As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_operator As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_perawat As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_dokter As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmb_officer As System.Windows.Forms.ComboBox
    Friend WithEvents tb_jmlterapi As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tb_ambil As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nud_jam As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_menit As System.Windows.Forms.NumericUpDown
End Class
