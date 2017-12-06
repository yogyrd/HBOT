Imports System.Windows.Forms

Public Class FormUtama

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is MdiClient Then c.BackColor = Me.BackColor
        Next
    End Sub


    Private Sub btn_master_Click(sender As Object, e As EventArgs) Handles btn_master.Click
        If pnl_menuMaster.Visible = True Then
            pnl_menuMaster.Visible = False
        Else
            pnl_menuMaster.Visible = True
            pnl_menuTransaksi.Visible = False
            pnl_menuLaporan.Visible = False
            pnl_menuConfig.Visible = False
        End If
    End Sub

    Private Sub btn_transaksi_Click(sender As Object, e As EventArgs) Handles btn_transaksi.Click
        If pnl_menuTransaksi.Visible = True Then
            pnl_menuTransaksi.Visible = False
        Else
            pnl_menuTransaksi.Visible = True
            pnl_menuMaster.Visible = False
            pnl_menuLaporan.Visible = False
            pnl_menuConfig.Visible = False
        End If
    End Sub

    Private Sub btn_laporan_Click(sender As Object, e As EventArgs) Handles btn_laporan.Click
        If pnl_menuLaporan.Visible = True Then
            pnl_menuLaporan.Visible = False
        Else
            pnl_menuLaporan.Visible = True
            pnl_menuMaster.Visible = False
            pnl_menuTransaksi.Visible = False
            pnl_menuConfig.Visible = False
        End If
    End Sub

    Private Sub btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click
        If pnl_menuConfig.Visible = True Then
            pnl_menuConfig.Visible = False
        Else
            pnl_menuConfig.Visible = True
            pnl_menuMaster.Visible = False
            pnl_menuTransaksi.Visible = False
            pnl_menuLaporan.Visible = False
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    
    Private Sub pnl_mstPegawai_Click(sender As Object, e As EventArgs) Handles pnl_mstPegawai.Click, lbl_mstPegawai.Click, icn_mstPegawai.Click
        MasterPegawai.MdiParent = Me
        MasterPegawai.Show()
        MasterPegawai.Activate()
    End Sub

    Private Sub pnl_mstGroupPegawai_Click(sender As Object, e As EventArgs) Handles pnl_mstGroupPegawai.Click, lbl_mstGroupPegawai.Click, icn_mstGroupPegawai.Click
        MasterGroupPegawai.MdiParent = Me
        MasterGroupPegawai.Show()
        MasterGroupPegawai.Activate()
    End Sub

    Private Sub pnl_mstFee_Click(sender As Object, e As EventArgs) Handles pnl_mstFee.Click, lbl_mstFee.Click, icn_mstFee.Click
        MasterFee.MdiParent = Me
        MasterFee.Show()
        MasterFee.Activate()
    End Sub

    Private Sub pnl_mstTindakan_Click(sender As Object, e As EventArgs) Handles pnl_mstTindakan.Click, lbl_mstTindakan.Click, icn_mstTindakan.Click
        MasterTindakan.MdiParent = Me
        MasterTindakan.Show()
        MasterTindakan.Activate()
    End Sub

    Private Sub pnl_mstPaket_Click(sender As Object, e As EventArgs) Handles pnl_mstPaket.Click, lbl_mstPaket.Click, icn_mstPaket.Click
        MasterPaket.MdiParent = Me
        MasterPaket.Show()
        MasterPaket.Activate()
    End Sub

    Private Sub pnl_mstVoucher_Click(sender As Object, e As EventArgs) Handles pnl_mstVoucher.Click, lbl_mstVoucher.Click, icn_mstVoucher.Click
        MasterVoucher.MdiParent = Me
        MasterVoucher.Show()
        MasterVoucher.Activate()
    End Sub

    Private Sub pnl_trDaftar_Click(sender As Object, e As EventArgs) Handles pnl_trDaftar.Click, lbl_trDaftar.Click, icn_trDaftar.Click
        TransaksiPendaftaran.MdiParent = Me
        TransaksiPendaftaran.Show()
        TransaksiPendaftaran.Activate()
    End Sub

    Private Sub pnl_trTerapi_Click(sender As Object, e As EventArgs) Handles pnl_trTerapi.Click, lbl_trTerapi.Click, icn_trTerapi.Click
        TransaksiTerapi.MdiParent = Me
        TransaksiTerapi.Show()
        TransaksiTerapi.Activate()
    End Sub

    Private Sub icn_rptDtJual_Click(sender As Object, e As EventArgs) Handles pnl_rptDtJual.Click, lbl__rptDtJual.Click, icn_rptDtJual.Click
        LaporanPejualan.MdiParent = Me
        LaporanPejualan.Show()
        LaporanPejualan.Activate()
    End Sub

    Private Sub pnl_dtTerapi_Click(sender As Object, e As EventArgs) Handles pnl_dtTerapi.Click, lbl_dtTerapi.Click, icn_dtTerapi.Click
        LaporanTerapi.MdiParent = Me
        LaporanTerapi.Show()
        LaporanTerapi.Activate()
    End Sub


    Private Sub pnl_dtPenggunaanPaket_Click(sender As Object, e As EventArgs) Handles pnl_dtPenggunaanPaket.Click, lbl_dtPenggunaanPaket.Click, icn_dtPenggunaanPaket.Click
        LaporanPenggunaanPaket.MdiParent = Me
        LaporanPenggunaanPaket.Show()
        LaporanPenggunaanPaket.Activate()
    End Sub

    Private Sub pnl_feePegawai_Click(sender As Object, e As EventArgs) Handles pnl_feePegawai.Click, lbl_feePegawai.Click, icn_feePegawai.Click
        LaporanFeePegawai.MdiParent = Me
        LaporanFeePegawai.Show()
        LaporanFeePegawai.Activate()
    End Sub

End Class
