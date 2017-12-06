<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaftarPaket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DaftarPaket))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_choose = New System.Windows.Forms.Button()
        Me.dtg_mstPaket = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_toolbar.SuspendLayout()
        CType(Me.dtg_mstPaket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_toolbar
        '
        Me.pnl_toolbar.BackColor = System.Drawing.Color.AliceBlue
        Me.pnl_toolbar.Controls.Add(Me.btn_close)
        Me.pnl_toolbar.Controls.Add(Me.btn_choose)
        Me.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_toolbar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 351)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(962, 63)
        Me.pnl_toolbar.TabIndex = 12
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_close.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(858, 8)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 40)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "Batal"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_choose
        '
        Me.btn_choose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_choose.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_choose.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_choose.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_choose.Image = CType(resources.GetObject("btn_choose.Image"), System.Drawing.Image)
        Me.btn_choose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_choose.Location = New System.Drawing.Point(756, 8)
        Me.btn_choose.Name = "btn_choose"
        Me.btn_choose.Size = New System.Drawing.Size(92, 40)
        Me.btn_choose.TabIndex = 1
        Me.btn_choose.Text = "Pilih"
        Me.btn_choose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_choose.UseVisualStyleBackColor = False
        '
        'dtg_mstPaket
        '
        Me.dtg_mstPaket.AllowUserToAddRows = False
        Me.dtg_mstPaket.AllowUserToDeleteRows = False
        Me.dtg_mstPaket.AllowUserToOrderColumns = True
        Me.dtg_mstPaket.AllowUserToResizeColumns = False
        Me.dtg_mstPaket.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dtg_mstPaket.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_mstPaket.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtg_mstPaket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_mstPaket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dtg_mstPaket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg_mstPaket.Location = New System.Drawing.Point(0, 0)
        Me.dtg_mstPaket.Name = "dtg_mstPaket"
        Me.dtg_mstPaket.ReadOnly = True
        Me.dtg_mstPaket.RowHeadersVisible = False
        Me.dtg_mstPaket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_mstPaket.Size = New System.Drawing.Size(962, 351)
        Me.dtg_mstPaket.TabIndex = 13
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID PAKET"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
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
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 70.0!
        Me.Column3.HeaderText = "MEMBER"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "HARGA PAKET"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "KETERANGAN"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'DaftarPaket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(962, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtg_mstPaket)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DaftarPaket"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Daftar Paket"
        Me.pnl_toolbar.ResumeLayout(False)
        CType(Me.dtg_mstPaket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_choose As System.Windows.Forms.Button
    Friend WithEvents dtg_mstPaket As System.Windows.Forms.DataGridView
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
