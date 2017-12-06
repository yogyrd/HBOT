<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputTransaksiPendaftaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputTransaksiPendaftaran))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_bayar = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_member = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_notlp = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_almt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_tgltr = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_kdmember = New System.Windows.Forms.TextBox()
        Me.cmb_pelanggan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_kddaftar = New System.Windows.Forms.TextBox()
        Me.lbl_noTransaksi = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dtg_dftrDetail = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_toolbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtg_dftrDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_toolbar
        '
        Me.pnl_toolbar.BackColor = System.Drawing.Color.AliceBlue
        Me.pnl_toolbar.Controls.Add(Me.btn_bayar)
        Me.pnl_toolbar.Controls.Add(Me.btn_close)
        Me.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_toolbar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 451)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(849, 63)
        Me.pnl_toolbar.TabIndex = 25
        '
        'btn_bayar
        '
        Me.btn_bayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_bayar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_bayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bayar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bayar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_bayar.Image = CType(resources.GetObject("btn_bayar.Image"), System.Drawing.Image)
        Me.btn_bayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bayar.Location = New System.Drawing.Point(647, 11)
        Me.btn_bayar.Name = "btn_bayar"
        Me.btn_bayar.Size = New System.Drawing.Size(92, 40)
        Me.btn_bayar.TabIndex = 7
        Me.btn_bayar.Text = "Bayar"
        Me.btn_bayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_bayar.UseVisualStyleBackColor = False
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
        Me.btn_close.Location = New System.Drawing.Point(745, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 40)
        Me.btn_close.TabIndex = 6
        Me.btn_close.Text = "Batal"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.cmb_member)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tb_notlp)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tb_email)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tb_almt)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.dtp_tgltr)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tb_kdmember)
        Me.Panel1.Controls.Add(Me.cmb_pelanggan)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tb_kddaftar)
        Me.Panel1.Controls.Add(Me.lbl_noTransaksi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 190)
        Me.Panel1.TabIndex = 26
        '
        'cmb_member
        '
        Me.cmb_member.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_member.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cmb_member.FormattingEnabled = True
        Me.cmb_member.Items.AddRange(New Object() {"Non Member", "Member Atlas", "Member HBOT"})
        Me.cmb_member.Location = New System.Drawing.Point(148, 68)
        Me.cmb_member.Name = "cmb_member"
        Me.cmb_member.Size = New System.Drawing.Size(233, 24)
        Me.cmb_member.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(516, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Email"
        '
        'tb_notlp
        '
        Me.tb_notlp.Location = New System.Drawing.Point(563, 124)
        Me.tb_notlp.Mask = "000.000.000.000"
        Me.tb_notlp.Name = "tb_notlp"
        Me.tb_notlp.Size = New System.Drawing.Size(115, 22)
        Me.tb_notlp.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(502, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "No. Telp"
        '
        'tb_email
        '
        Me.tb_email.BackColor = System.Drawing.SystemColors.Window
        Me.tb_email.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_email.Location = New System.Drawing.Point(563, 152)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(233, 22)
        Me.tb_email.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Alamat"
        '
        'tb_almt
        '
        Me.tb_almt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_almt.Location = New System.Drawing.Point(563, 42)
        Me.tb_almt.Multiline = True
        Me.tb_almt.Name = "tb_almt"
        Me.tb_almt.Size = New System.Drawing.Size(233, 76)
        Me.tb_almt.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 16)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Tanggal Transaksi"
        '
        'dtp_tgltr
        '
        Me.dtp_tgltr.CustomFormat = "yyyy-MM-dd"
        Me.dtp_tgltr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tgltr.Location = New System.Drawing.Point(148, 40)
        Me.dtp_tgltr.Name = "dtp_tgltr"
        Me.dtp_tgltr.Size = New System.Drawing.Size(115, 22)
        Me.dtp_tgltr.TabIndex = 1
        Me.dtp_tgltr.Value = New Date(2017, 6, 9, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Kode"
        '
        'tb_kdmember
        '
        Me.tb_kdmember.BackColor = System.Drawing.SystemColors.Window
        Me.tb_kdmember.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kdmember.Location = New System.Drawing.Point(148, 98)
        Me.tb_kdmember.Name = "tb_kdmember"
        Me.tb_kdmember.Size = New System.Drawing.Size(233, 22)
        Me.tb_kdmember.TabIndex = 3
        '
        'cmb_pelanggan
        '
        Me.cmb_pelanggan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_pelanggan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_pelanggan.FormattingEnabled = True
        Me.cmb_pelanggan.Location = New System.Drawing.Point(563, 12)
        Me.cmb_pelanggan.Name = "cmb_pelanggan"
        Me.cmb_pelanggan.Size = New System.Drawing.Size(233, 24)
        Me.cmb_pelanggan.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Member"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(450, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Pelanggan"
        '
        'tb_kddaftar
        '
        Me.tb_kddaftar.BackColor = System.Drawing.SystemColors.Window
        Me.tb_kddaftar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kddaftar.Location = New System.Drawing.Point(148, 12)
        Me.tb_kddaftar.Name = "tb_kddaftar"
        Me.tb_kddaftar.ReadOnly = True
        Me.tb_kddaftar.Size = New System.Drawing.Size(233, 22)
        Me.tb_kddaftar.TabIndex = 0
        '
        'lbl_noTransaksi
        '
        Me.lbl_noTransaksi.AutoSize = True
        Me.lbl_noTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noTransaksi.Location = New System.Drawing.Point(66, 15)
        Me.lbl_noTransaksi.Name = "lbl_noTransaksi"
        Me.lbl_noTransaksi.Size = New System.Drawing.Size(76, 16)
        Me.lbl_noTransaksi.TabIndex = 0
        Me.lbl_noTransaksi.Text = "Kode Daftar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(849, 58)
        Me.Panel2.TabIndex = 27
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
        Me.btn_delete.TabIndex = 15
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
        'dtg_dftrDetail
        '
        Me.dtg_dftrDetail.AllowUserToAddRows = False
        Me.dtg_dftrDetail.AllowUserToDeleteRows = False
        Me.dtg_dftrDetail.AllowUserToOrderColumns = True
        Me.dtg_dftrDetail.AllowUserToResizeColumns = False
        Me.dtg_dftrDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dtg_dftrDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_dftrDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtg_dftrDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_dftrDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column8, Me.Column6, Me.Column3, Me.Column4})
        Me.dtg_dftrDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg_dftrDetail.Location = New System.Drawing.Point(0, 248)
        Me.dtg_dftrDetail.Name = "dtg_dftrDetail"
        Me.dtg_dftrDetail.RowHeadersVisible = False
        Me.dtg_dftrDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_dftrDetail.Size = New System.Drawing.Size(849, 203)
        Me.dtg_dftrDetail.TabIndex = 28
        '
        'Column5
        '
        Me.Column5.HeaderText = "ID PAKET"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "KODE PAKET"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "NAMA PAKET"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "KETERANGAN"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.FillWeight = 70.0!
        Me.Column6.HeaderText = "HARGA"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 50.0!
        Me.Column3.HeaderText = "JUMLAH"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "SUBTOTAL"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'InputTransaksiPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(849, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtg_dftrDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InputTransaksiPendaftaran"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Transaksi Pendaftaran"
        Me.pnl_toolbar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtg_dftrDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_kddaftar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_noTransaksi As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents dtg_dftrDetail As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_pelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tb_kdmember As System.Windows.Forms.TextBox
    Friend WithEvents dtp_tgltr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_bayar As System.Windows.Forms.Button
    Friend WithEvents tb_almt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_email As System.Windows.Forms.TextBox
    Friend WithEvents tb_notlp As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_member As System.Windows.Forms.ComboBox
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
