﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterMasterGroupPegawai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterMasterGroupPegawai))
        Me.pnl_toolbar = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_choose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tb_nmgroup = New System.Windows.Forms.TextBox()
        Me.tb_kdgroup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.pnl_toolbar.Location = New System.Drawing.Point(0, 102)
        Me.pnl_toolbar.Name = "pnl_toolbar"
        Me.pnl_toolbar.Size = New System.Drawing.Size(387, 63)
        Me.pnl_toolbar.TabIndex = 18
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
        Me.btn_close.Location = New System.Drawing.Point(283, 11)
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
        Me.btn_choose.Location = New System.Drawing.Point(181, 11)
        Me.btn_choose.Name = "btn_choose"
        Me.btn_choose.Size = New System.Drawing.Size(92, 40)
        Me.btn_choose.TabIndex = 1
        Me.btn_choose.Text = "OK"
        Me.btn_choose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_choose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tb_nmgroup)
        Me.Panel1.Controls.Add(Me.tb_kdgroup)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 81)
        Me.Panel1.TabIndex = 19
        '
        'tb_nmgroup
        '
        Me.tb_nmgroup.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_nmgroup.Location = New System.Drawing.Point(115, 40)
        Me.tb_nmgroup.Name = "tb_nmgroup"
        Me.tb_nmgroup.Size = New System.Drawing.Size(233, 22)
        Me.tb_nmgroup.TabIndex = 1
        '
        'tb_kdgroup
        '
        Me.tb_kdgroup.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tb_kdgroup.Location = New System.Drawing.Point(115, 12)
        Me.tb_kdgroup.Name = "tb_kdgroup"
        Me.tb_kdgroup.Size = New System.Drawing.Size(233, 22)
        Me.tb_kdgroup.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(28, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nama Group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(32, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Group"
        '
        'FilterMasterGroupPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(387, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_toolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FilterMasterGroupPegawai"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filter Master Group Pegawai"
        Me.pnl_toolbar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_toolbar As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_choose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tb_nmgroup As System.Windows.Forms.TextBox
    Friend WithEvents tb_kdgroup As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
