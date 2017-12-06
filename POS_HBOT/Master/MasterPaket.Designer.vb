<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPaket
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterPaket))
        Me.dtg_mstPaket = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        CType(Me.dtg_mstPaket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_toolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtg_mstPaket
        '
        Me.dtg_mstPaket.AllowUserToAddRows = False
        Me.dtg_mstPaket.AllowUserToDeleteRows = False
        Me.dtg_mstPaket.AllowUserToOrderColumns = True
        Me.dtg_mstPaket.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dtg_mstPaket.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_mstPaket.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtg_mstPaket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_mstPaket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg_mstPaket.Location = New System.Drawing.Point(0, 60)
        Me.dtg_mstPaket.MultiSelect = False
        Me.dtg_mstPaket.Name = "dtg_mstPaket"
        Me.dtg_mstPaket.ReadOnly = True
        Me.dtg_mstPaket.RowHeadersVisible = False
        Me.dtg_mstPaket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtg_mstPaket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_mstPaket.Size = New System.Drawing.Size(1292, 444)
        Me.dtg_mstPaket.TabIndex = 12
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
        Me.btn_add.Size = New System.Drawing.Size(92, 40)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Tambah"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_filter
        '
        Me.btn_filter.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filter.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_filter.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(502, 8)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(92, 40)
        Me.btn_filter.TabIndex = 3
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_filter.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(600, 8)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(92, 40)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "Cetak"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(698, 8)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 40)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "Tutup"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_refresh.Location = New System.Drawing.Point(404, 8)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(92, 40)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'pnl_toolbar
        '
        Me.pnl_toolbar.BackColor = System.Drawing.Color.Orange
        Me.pnl_toolbar.Controls.Add(Me.btn_show)
        Me.pnl_toolbar.Controls.Add(Me.btn_delete)
        Me.pnl_toolbar.Controls.Add(Me.btn_edit)
        Me.pnl_toolbar.Controls.Add(Me.btn_refresh)
        Me.pnl_toolbar.Controls.Add(Me.btn_close)
        Me.pnl_toolbar.Controls.Add(Me.btn_print)
        Me.pnl_toolbar.Controls.Add(Me.btn_filter)
        Me.pnl_toolbar.Controls.Add(Me.btn_add)
        Me.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(1292, 60)
        Me.pnl_toolbar.TabIndex = 11
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_show.Image = CType(resources.GetObject("btn_show.Image"), System.Drawing.Image)
        Me.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_show.Location = New System.Drawing.Point(306, 8)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(92, 40)
        Me.btn_show.TabIndex = 15
        Me.btn_show.Text = "View"
        Me.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_show.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(208, 8)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(92, 40)
        Me.btn_delete.TabIndex = 14
        Me.btn_delete.Text = "Hapus"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(110, 8)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(92, 40)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "Ubah"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'MasterPaket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 504)
        Me.Controls.Add(Me.dtg_mstPaket)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.Name = "MasterPaket"
        Me.Text = "Master Paket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtg_mstPaket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_toolbar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtg_mstPaket As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_filter As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_show As System.Windows.Forms.Button
End Class
