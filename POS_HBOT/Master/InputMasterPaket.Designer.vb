<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputMasterPaket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputMasterPaket))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rb_diskonnominal = New System.Windows.Forms.RadioButton()
        Me.rb_diskonprosentase = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_hargaakhir = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_akhir = New System.Windows.Forms.DateTimePicker()
        Me.dtp_awal = New System.Windows.Forms.DateTimePicker()
        Me.tb_ket = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_diskonnominal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_diskonpersen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_hargaawal = New System.Windows.Forms.TextBox()
        Me.cmb_member = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nmpaket = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_kdpaket = New System.Windows.Forms.TextBox()
        Me.lbl_noTransaksi = New System.Windows.Forms.Label()
        Me.pnl_detailButton = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dtg_paketDetail = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_toolbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_detailButton.SuspendLayout()
        CType(Me.dtg_paketDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_toolbar
        '
        Me.pnl_toolbar.BackColor = System.Drawing.Color.AliceBlue
        Me.pnl_toolbar.Controls.Add(Me.btn_close)
        Me.pnl_toolbar.Controls.Add(Me.btn_save)
        Me.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_toolbar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 620)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(822, 63)
        Me.pnl_toolbar.TabIndex = 23
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
        Me.btn_close.Location = New System.Drawing.Point(718, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 40)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "Tutup"
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
        Me.btn_save.Location = New System.Drawing.Point(620, 11)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(92, 40)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Simpan"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.rb_diskonnominal)
        Me.Panel1.Controls.Add(Me.rb_diskonprosentase)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tb_hargaakhir)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dtp_akhir)
        Me.Panel1.Controls.Add(Me.dtp_awal)
        Me.Panel1.Controls.Add(Me.tb_ket)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tb_diskonnominal)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tb_diskonpersen)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tb_hargaawal)
        Me.Panel1.Controls.Add(Me.cmb_member)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tb_nmpaket)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tb_kdpaket)
        Me.Panel1.Controls.Add(Me.lbl_noTransaksi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 186)
        Me.Panel1.TabIndex = 6
        '
        'rb_diskonnominal
        '
        Me.rb_diskonnominal.AutoSize = True
        Me.rb_diskonnominal.Location = New System.Drawing.Point(664, 34)
        Me.rb_diskonnominal.Name = "rb_diskonnominal"
        Me.rb_diskonnominal.Size = New System.Drawing.Size(73, 20)
        Me.rb_diskonnominal.TabIndex = 4
        Me.rb_diskonnominal.TabStop = True
        Me.rb_diskonnominal.Text = "Nominal"
        Me.rb_diskonnominal.UseVisualStyleBackColor = True
        '
        'rb_diskonprosentase
        '
        Me.rb_diskonprosentase.AutoSize = True
        Me.rb_diskonprosentase.Location = New System.Drawing.Point(554, 34)
        Me.rb_diskonprosentase.Name = "rb_diskonprosentase"
        Me.rb_diskonprosentase.Size = New System.Drawing.Size(92, 20)
        Me.rb_diskonprosentase.TabIndex = 3
        Me.rb_diskonprosentase.TabStop = True
        Me.rb_diskonprosentase.Text = "Prosentase"
        Me.rb_diskonprosentase.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(548, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Rp"
        '
        'tb_hargaakhir
        '
        Me.tb_hargaakhir.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_hargaakhir.Location = New System.Drawing.Point(578, 146)
        Me.tb_hargaakhir.Name = "tb_hargaakhir"
        Me.tb_hargaakhir.ReadOnly = True
        Me.tb_hargaakhir.Size = New System.Drawing.Size(173, 22)
        Me.tb_hargaakhir.TabIndex = 45
        Me.tb_hargaakhir.Text = "0"
        Me.tb_hargaakhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(435, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 16)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Harga Paket Akhir"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(454, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Paket Berakhir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(471, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Paket Mulai"
        '
        'dtp_akhir
        '
        Me.dtp_akhir.CustomFormat = "yyyy-MM-dd"
        Me.dtp_akhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_akhir.Location = New System.Drawing.Point(554, 118)
        Me.dtp_akhir.Name = "dtp_akhir"
        Me.dtp_akhir.Size = New System.Drawing.Size(115, 22)
        Me.dtp_akhir.TabIndex = 8
        Me.dtp_akhir.Value = New Date(9998, 12, 31, 0, 0, 0, 0)
        '
        'dtp_awal
        '
        Me.dtp_awal.CustomFormat = "yyyy-MM-dd"
        Me.dtp_awal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_awal.Location = New System.Drawing.Point(554, 90)
        Me.dtp_awal.Name = "dtp_awal"
        Me.dtp_awal.Size = New System.Drawing.Size(115, 22)
        Me.dtp_awal.TabIndex = 7
        Me.dtp_awal.Value = New Date(2017, 6, 9, 0, 0, 0, 0)
        '
        'tb_ket
        '
        Me.tb_ket.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ket.Location = New System.Drawing.Point(140, 92)
        Me.tb_ket.Multiline = True
        Me.tb_ket.Name = "tb_ket"
        Me.tb_ket.Size = New System.Drawing.Size(233, 76)
        Me.tb_ket.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Keterangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(634, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Rp"
        '
        'tb_diskonnominal
        '
        Me.tb_diskonnominal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_diskonnominal.Location = New System.Drawing.Point(664, 60)
        Me.tb_diskonnominal.Name = "tb_diskonnominal"
        Me.tb_diskonnominal.ReadOnly = True
        Me.tb_diskonnominal.Size = New System.Drawing.Size(131, 22)
        Me.tb_diskonnominal.TabIndex = 6
        Me.tb_diskonnominal.Text = "0"
        Me.tb_diskonnominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(596, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "%"
        '
        'tb_diskonpersen
        '
        Me.tb_diskonpersen.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_diskonpersen.Location = New System.Drawing.Point(554, 62)
        Me.tb_diskonpersen.MaxLength = 3
        Me.tb_diskonpersen.Name = "tb_diskonpersen"
        Me.tb_diskonpersen.ReadOnly = True
        Me.tb_diskonpersen.Size = New System.Drawing.Size(36, 22)
        Me.tb_diskonpersen.TabIndex = 34
        Me.tb_diskonpersen.Text = "0"
        Me.tb_diskonpersen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(551, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Rp"
        '
        'tb_hargaawal
        '
        Me.tb_hargaawal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_hargaawal.Location = New System.Drawing.Point(581, 6)
        Me.tb_hargaawal.Name = "tb_hargaawal"
        Me.tb_hargaawal.ReadOnly = True
        Me.tb_hargaawal.Size = New System.Drawing.Size(214, 22)
        Me.tb_hargaawal.TabIndex = 32
        Me.tb_hargaawal.Text = "0"
        Me.tb_hargaawal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_member
        '
        Me.cmb_member.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_member.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cmb_member.FormattingEnabled = True
        Me.cmb_member.Items.AddRange(New Object() {"Non Member", "Member Atlas", "Member HBOT"})
        Me.cmb_member.Location = New System.Drawing.Point(140, 62)
        Me.cmb_member.Name = "cmb_member"
        Me.cmb_member.Size = New System.Drawing.Size(233, 24)
        Me.cmb_member.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Diskon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(437, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Harga Paket Awal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Member"
        '
        'tb_nmpaket
        '
        Me.tb_nmpaket.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nmpaket.Location = New System.Drawing.Point(140, 34)
        Me.tb_nmpaket.Name = "tb_nmpaket"
        Me.tb_nmpaket.Size = New System.Drawing.Size(233, 22)
        Me.tb_nmpaket.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Paket"
        '
        'tb_kdpaket
        '
        Me.tb_kdpaket.BackColor = System.Drawing.SystemColors.Window
        Me.tb_kdpaket.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kdpaket.Location = New System.Drawing.Point(140, 6)
        Me.tb_kdpaket.Name = "tb_kdpaket"
        Me.tb_kdpaket.ReadOnly = True
        Me.tb_kdpaket.Size = New System.Drawing.Size(233, 22)
        Me.tb_kdpaket.TabIndex = 2
        '
        'lbl_noTransaksi
        '
        Me.lbl_noTransaksi.AutoSize = True
        Me.lbl_noTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noTransaksi.Location = New System.Drawing.Point(58, 9)
        Me.lbl_noTransaksi.Name = "lbl_noTransaksi"
        Me.lbl_noTransaksi.Size = New System.Drawing.Size(76, 16)
        Me.lbl_noTransaksi.TabIndex = 0
        Me.lbl_noTransaksi.Text = "Kode Paket"
        '
        'pnl_detailButton
        '
        Me.pnl_detailButton.BackColor = System.Drawing.Color.AliceBlue
        Me.pnl_detailButton.Controls.Add(Me.btn_delete)
        Me.pnl_detailButton.Controls.Add(Me.btn_add)
        Me.pnl_detailButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_detailButton.Location = New System.Drawing.Point(0, 186)
        Me.pnl_detailButton.Name = "pnl_detailButton"
        Me.pnl_detailButton.Size = New System.Drawing.Size(822, 434)
        Me.pnl_detailButton.TabIndex = 24
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(148, 8)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(120, 40)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "Hapus Detail"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(12, 8)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(130, 40)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Tambah Detail"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'dtg_paketDetail
        '
        Me.dtg_paketDetail.AllowUserToAddRows = False
        Me.dtg_paketDetail.AllowUserToDeleteRows = False
        Me.dtg_paketDetail.AllowUserToOrderColumns = True
        Me.dtg_paketDetail.AllowUserToResizeColumns = False
        Me.dtg_paketDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dtg_paketDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_paketDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtg_paketDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_paketDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7})
        Me.dtg_paketDetail.Location = New System.Drawing.Point(0, 240)
        Me.dtg_paketDetail.Name = "dtg_paketDetail"
        Me.dtg_paketDetail.RowHeadersVisible = False
        Me.dtg_paketDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_paketDetail.Size = New System.Drawing.Size(822, 380)
        Me.dtg_paketDetail.TabIndex = 25
        '
        'Column4
        '
        Me.Column4.HeaderText = "ID TINDAKAN"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "NAMA TINDAKAN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "KETERANGAN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 50.0!
        Me.Column3.HeaderText = "HARGA"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "JUMLAH"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "SUBTOTAL"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID PAKET"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'InputMasterPaket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(822, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtg_paketDetail)
        Me.Controls.Add(Me.pnl_detailButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "InputMasterPaket"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Input Master Paket"
        Me.pnl_toolbar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_detailButton.ResumeLayout(False)
        CType(Me.dtg_paketDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tb_nmpaket As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_kdpaket As System.Windows.Forms.TextBox
    Friend WithEvents lbl_noTransaksi As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_member As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_hargaawal As System.Windows.Forms.TextBox
    Friend WithEvents tb_diskonpersen As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_diskonnominal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_ket As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnl_detailButton As System.Windows.Forms.Panel
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents dtp_akhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_awal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtg_paketDetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_hargaakhir As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rb_diskonprosentase As System.Windows.Forms.RadioButton
    Friend WithEvents rb_diskonnominal As System.Windows.Forms.RadioButton
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
