<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterMasterVoucher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterMasterVoucher))
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_choose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_diskonNominal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_akhir = New System.Windows.Forms.DateTimePicker()
        Me.dtp_awal = New System.Windows.Forms.DateTimePicker()
        Me.tb_ket = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_diskonProsentase = New System.Windows.Forms.TextBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_kodeVoucher = New System.Windows.Forms.TextBox()
        Me.lbl_noTransaksi = New System.Windows.Forms.Label()
        Me.pnl_toolbar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_toolbar
        '
        Me.pnl_toolbar.BackColor = System.Drawing.Color.AliceBlue
        Me.pnl_toolbar.Controls.Add(Me.btn_close)
        Me.pnl_toolbar.Controls.Add(Me.btn_choose)
        Me.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_toolbar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 275)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(462, 63)
        Me.pnl_toolbar.TabIndex = 20
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
        Me.btn_close.Location = New System.Drawing.Point(358, 11)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 40)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "Batal"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_choose
        '
        Me.btn_choose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_choose.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_choose.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_choose.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_choose.Image = CType(resources.GetObject("btn_choose.Image"), System.Drawing.Image)
        Me.btn_choose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_choose.Location = New System.Drawing.Point(256, 11)
        Me.btn_choose.Name = "btn_choose"
        Me.btn_choose.Size = New System.Drawing.Size(92, 40)
        Me.btn_choose.TabIndex = 1
        Me.btn_choose.Text = "OK"
        Me.btn_choose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_choose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tb_diskonNominal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.dtp_akhir)
        Me.Panel1.Controls.Add(Me.dtp_awal)
        Me.Panel1.Controls.Add(Me.tb_ket)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tb_diskonProsentase)
        Me.Panel1.Controls.Add(Me.cmb_status)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tb_kodeVoucher)
        Me.Panel1.Controls.Add(Me.lbl_noTransaksi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 262)
        Me.Panel1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(163, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Rp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(61, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Diskon Berakhir"
        '
        'tb_diskonNominal
        '
        Me.tb_diskonNominal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_diskonNominal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_diskonNominal.Location = New System.Drawing.Point(194, 170)
        Me.tb_diskonNominal.Name = "tb_diskonNominal"
        Me.tb_diskonNominal.Size = New System.Drawing.Size(106, 22)
        Me.tb_diskonNominal.TabIndex = 4
        Me.tb_diskonNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(58, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Diskon Nominal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Diskon Mulai"
        '
        'dtp_akhir
        '
        Me.dtp_akhir.CustomFormat = "yyyy-MM-dd"
        Me.dtp_akhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_akhir.Location = New System.Drawing.Point(166, 226)
        Me.dtp_akhir.Name = "dtp_akhir"
        Me.dtp_akhir.Size = New System.Drawing.Size(115, 22)
        Me.dtp_akhir.TabIndex = 6
        Me.dtp_akhir.Value = New Date(9998, 12, 31, 0, 0, 0, 0)
        '
        'dtp_awal
        '
        Me.dtp_awal.CustomFormat = "yyyy-MM-dd"
        Me.dtp_awal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_awal.Location = New System.Drawing.Point(166, 198)
        Me.dtp_awal.Name = "dtp_awal"
        Me.dtp_awal.Size = New System.Drawing.Size(115, 22)
        Me.dtp_awal.TabIndex = 5
        Me.dtp_awal.Value = New Date(2017, 6, 9, 0, 0, 0, 0)
        '
        'tb_ket
        '
        Me.tb_ket.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ket.Location = New System.Drawing.Point(166, 70)
        Me.tb_ket.Multiline = True
        Me.tb_ket.Name = "tb_ket"
        Me.tb_ket.Size = New System.Drawing.Size(233, 66)
        Me.tb_ket.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(86, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Keterangan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(221, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "%"
        '
        'tb_diskonProsentase
        '
        Me.tb_diskonProsentase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_diskonProsentase.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_diskonProsentase.Location = New System.Drawing.Point(166, 142)
        Me.tb_diskonProsentase.MaxLength = 3
        Me.tb_diskonProsentase.Name = "tb_diskonProsentase"
        Me.tb_diskonProsentase.Size = New System.Drawing.Size(48, 22)
        Me.tb_diskonProsentase.TabIndex = 3
        Me.tb_diskonProsentase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Tidak Aktif", "Aktif"})
        Me.cmb_status.Location = New System.Drawing.Point(166, 40)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(233, 24)
        Me.cmb_status.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Diskon Prosentase"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Status"
        '
        'tb_kodeVoucher
        '
        Me.tb_kodeVoucher.BackColor = System.Drawing.SystemColors.Window
        Me.tb_kodeVoucher.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kodeVoucher.Location = New System.Drawing.Point(166, 12)
        Me.tb_kodeVoucher.Name = "tb_kodeVoucher"
        Me.tb_kodeVoucher.ReadOnly = True
        Me.tb_kodeVoucher.Size = New System.Drawing.Size(233, 22)
        Me.tb_kodeVoucher.TabIndex = 0
        '
        'lbl_noTransaksi
        '
        Me.lbl_noTransaksi.AutoSize = True
        Me.lbl_noTransaksi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noTransaksi.Location = New System.Drawing.Point(71, 15)
        Me.lbl_noTransaksi.Name = "lbl_noTransaksi"
        Me.lbl_noTransaksi.Size = New System.Drawing.Size(89, 16)
        Me.lbl_noTransaksi.TabIndex = 0
        Me.lbl_noTransaksi.Text = "Kode Voucher"
        '
        'FilterMasterVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(462, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FilterMasterVoucher"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filter Master Voucher"
        Me.pnl_toolbar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_choose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtp_akhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_awal As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_ket As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_diskonProsentase As System.Windows.Forms.TextBox
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_kodeVoucher As System.Windows.Forms.TextBox
    Friend WithEvents lbl_noTransaksi As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_diskonNominal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
