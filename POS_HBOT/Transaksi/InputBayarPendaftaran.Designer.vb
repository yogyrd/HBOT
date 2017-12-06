<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBayarPendaftaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputBayarPendaftaran))
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_bayar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tb_disknominal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_diskpersen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_nokartu = New System.Windows.Forms.TextBox()
        Me.cmb_kartu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_mesin = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_jenisbayar = New System.Windows.Forms.ComboBox()
        Me.tb_kdvoucher = New System.Windows.Forms.TextBox()
        Me.lbl_noTransaksi = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_sisabayar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_grandtotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnl_toolbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_toolbar
        '
        Me.pnl_toolbar.BackColor = System.Drawing.Color.AliceBlue
        Me.pnl_toolbar.Controls.Add(Me.btn_close)
        Me.pnl_toolbar.Controls.Add(Me.btn_save)
        Me.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_toolbar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 406)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(715, 63)
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
        Me.btn_close.Location = New System.Drawing.Point(611, 11)
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
        Me.btn_save.Location = New System.Drawing.Point(513, 11)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(92, 40)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Simpan &"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.tb_bayar)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.tb_disknominal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tb_diskpersen)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tb_nokartu)
        Me.Panel1.Controls.Add(Me.cmb_kartu)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmb_mesin)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cmb_jenisbayar)
        Me.Panel1.Controls.Add(Me.tb_kdvoucher)
        Me.Panel1.Controls.Add(Me.lbl_noTransaksi)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 220)
        Me.Panel1.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(388, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 16)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Rp"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label15.Location = New System.Drawing.Point(294, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 16)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Rp"
        '
        'tb_bayar
        '
        Me.tb_bayar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_bayar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_bayar.Location = New System.Drawing.Point(324, 180)
        Me.tb_bayar.Name = "tb_bayar"
        Me.tb_bayar.Size = New System.Drawing.Size(206, 22)
        Me.tb_bayar.TabIndex = 5
        Me.tb_bayar.Text = "0"
        Me.tb_bayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(134, 183)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 16)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Nominal Yang Dibayarkan"
        '
        'tb_disknominal
        '
        Me.tb_disknominal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_disknominal.Location = New System.Drawing.Point(418, 34)
        Me.tb_disknominal.Name = "tb_disknominal"
        Me.tb_disknominal.ReadOnly = True
        Me.tb_disknominal.Size = New System.Drawing.Size(112, 22)
        Me.tb_disknominal.TabIndex = 65
        Me.tb_disknominal.Text = "0"
        Me.tb_disknominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(243, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Diskon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(351, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 16)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "%"
        '
        'tb_diskpersen
        '
        Me.tb_diskpersen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_diskpersen.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_diskpersen.Location = New System.Drawing.Point(297, 34)
        Me.tb_diskpersen.Name = "tb_diskpersen"
        Me.tb_diskpersen.ReadOnly = True
        Me.tb_diskpersen.Size = New System.Drawing.Size(48, 22)
        Me.tb_diskpersen.TabIndex = 62
        Me.tb_diskpersen.Text = "0"
        Me.tb_diskpersen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Nomor Kartu"
        '
        'tb_nokartu
        '
        Me.tb_nokartu.BackColor = System.Drawing.SystemColors.Window
        Me.tb_nokartu.Enabled = False
        Me.tb_nokartu.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_nokartu.Location = New System.Drawing.Point(297, 152)
        Me.tb_nokartu.Name = "tb_nokartu"
        Me.tb_nokartu.ReadOnly = True
        Me.tb_nokartu.Size = New System.Drawing.Size(233, 22)
        Me.tb_nokartu.TabIndex = 4
        '
        'cmb_kartu
        '
        Me.cmb_kartu.Enabled = False
        Me.cmb_kartu.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cmb_kartu.FormattingEnabled = True
        Me.cmb_kartu.Location = New System.Drawing.Point(297, 122)
        Me.cmb_kartu.Name = "cmb_kartu"
        Me.cmb_kartu.Size = New System.Drawing.Size(115, 24)
        Me.cmb_kartu.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(248, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Mesin"
        '
        'cmb_mesin
        '
        Me.cmb_mesin.Enabled = False
        Me.cmb_mesin.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cmb_mesin.FormattingEnabled = True
        Me.cmb_mesin.Location = New System.Drawing.Point(297, 92)
        Me.cmb_mesin.Name = "cmb_mesin"
        Me.cmb_mesin.Size = New System.Drawing.Size(115, 24)
        Me.cmb_mesin.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(252, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Kartu"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(176, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 16)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Jenis Pembayaran"
        '
        'cmb_jenisbayar
        '
        Me.cmb_jenisbayar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_jenisbayar.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cmb_jenisbayar.FormattingEnabled = True
        Me.cmb_jenisbayar.Items.AddRange(New Object() {"TUNAI"})
        Me.cmb_jenisbayar.Location = New System.Drawing.Point(297, 62)
        Me.cmb_jenisbayar.Name = "cmb_jenisbayar"
        Me.cmb_jenisbayar.Size = New System.Drawing.Size(115, 24)
        Me.cmb_jenisbayar.TabIndex = 1
        '
        'tb_kdvoucher
        '
        Me.tb_kdvoucher.BackColor = System.Drawing.SystemColors.Window
        Me.tb_kdvoucher.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_kdvoucher.Location = New System.Drawing.Point(297, 6)
        Me.tb_kdvoucher.Name = "tb_kdvoucher"
        Me.tb_kdvoucher.ReadOnly = True
        Me.tb_kdvoucher.Size = New System.Drawing.Size(233, 22)
        Me.tb_kdvoucher.TabIndex = 0
        '
        'lbl_noTransaksi
        '
        Me.lbl_noTransaksi.AutoSize = True
        Me.lbl_noTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noTransaksi.Location = New System.Drawing.Point(202, 9)
        Me.lbl_noTransaksi.Name = "lbl_noTransaksi"
        Me.lbl_noTransaksi.Size = New System.Drawing.Size(89, 16)
        Me.lbl_noTransaksi.TabIndex = 0
        Me.lbl_noTransaksi.Text = "Kode Voucher"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lbl_total)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 58)
        Me.Panel3.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(224, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 58)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Rp"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_total
        '
        Me.lbl_total.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_total.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(380, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(335, 58)
        Me.lbl_total.TabIndex = 1
        Me.lbl_total.Text = "999,999,999"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Transaksi"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_sisabayar)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 348)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 58)
        Me.Panel2.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Digital-7", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rp"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_sisabayar
        '
        Me.lbl_sisabayar.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_sisabayar.Font = New System.Drawing.Font("Digital-7", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sisabayar.Location = New System.Drawing.Point(380, 0)
        Me.lbl_sisabayar.Name = "lbl_sisabayar"
        Me.lbl_sisabayar.Size = New System.Drawing.Size(335, 58)
        Me.lbl_sisabayar.TabIndex = 1
        Me.lbl_sisabayar.Text = "999,999,999"
        Me.lbl_sisabayar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sisa Bayar"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Lime
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.lbl_grandtotal)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 290)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(715, 58)
        Me.Panel4.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(266, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 58)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Rp"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_grandtotal
        '
        Me.lbl_grandtotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_grandtotal.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandtotal.Location = New System.Drawing.Point(380, 0)
        Me.lbl_grandtotal.Name = "lbl_grandtotal"
        Me.lbl_grandtotal.Size = New System.Drawing.Size(335, 58)
        Me.lbl_grandtotal.TabIndex = 1
        Me.lbl_grandtotal.Text = "999,999,999"
        Me.lbl_grandtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(266, 36)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Total Pembayaran"
        '
        'InputBayarPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(715, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InputBayarPendaftaran"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Input Bayar Pendaftaran"
        Me.pnl_toolbar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_nokartu As System.Windows.Forms.TextBox
    Friend WithEvents cmb_kartu As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_mesin As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_jenisbayar As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_kdvoucher As System.Windows.Forms.TextBox
    Friend WithEvents lbl_noTransaksi As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_sisabayar As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_grandtotal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tb_bayar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tb_disknominal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_diskpersen As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
