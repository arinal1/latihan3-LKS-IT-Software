Public Class MainMenu
    'window bar
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    'admin
    Public logOut As Boolean
    Public admin As String
    Public idAdmin As String
    Public lvlAdmin As Integer
    'roti
    Public editRoti As Boolean
    Public kodeRoti As String
    Public namaRoti As String
    Public hargaRoti As Decimal
    Public diskonRoti As Integer
    Public stokRoti As Integer
    'kasir
    Dim pilihIndexTabel As String
    Dim totalBelanja As Integer
    Dim stokSedia As Integer

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshDataBase()
        btnDashboard_Click(sender, e)
        Me.KeyPreview = True
    End Sub

    Sub refreshDataBase()
        Me.PenjualanTableAdapter.Fill(Me.TheBreadShopDataSet.penjualan)
        Me.Header_penjualanTableAdapter.Fill(Me.TheBreadShopDataSet.header_penjualan)
        Me.RotiTableAdapter.Fill(Me.TheBreadShopDataSet.roti)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        logOut = False
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        logOut = True
        Me.Close()
        FormLogin.Show()
    End Sub
    Private Sub PanelWindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelWindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelWindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseUp
        drag = False
    End Sub

    Sub UlangForm()
        PanelWrapperDashboard.Visible = False
        PanelWrapperRoti.Visible = False
        PanelWrapperKasir.Visible = False
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        UlangForm()
        PanelWrapperDashboard.Visible = True
        lblKeterangan.Text = ""
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        UlangForm()
        PanelWrapperKasir.Visible = True
        lblKeterangan.Text = "Tekan Enter Untuk Menambah Data  |  Tekan F1 Untuk Mencari Kode Roti  |  Tekan F2 Untuk Menghapus Item  |  Tekan F3 Untuk Mengulang  |  Tekan F4 Untuk Membayar"
    End Sub

    Private Sub btnHapusRoti_Click(sender As Object, e As EventArgs) Handles btnHapusRoti.Click
        If kodeRoti = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            If MsgBox("Apakah Anda Yakin Menghapus Roti " + kodeRoti + "?", vbYesNo, "Konfirmasi") = vbYes Then
                RotiTableAdapter.hapus(kodeRoti)
                refreshDataBase()
                txCariRoti.Focus()
            End If
        End If
    End Sub

    Private Sub tabelDataRoti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataRoti.CellClick
        pilihSelRoti(e.RowIndex)
    End Sub

    Sub pilihSelRoti(ByVal e As String)
        If e >= 0 Then
            kodeRoti = tabelDataRoti.Rows(e).Cells(0).Value
            namaRoti = tabelDataRoti.Rows(e).Cells(1).Value
            hargaRoti = tabelDataRoti.Rows(e).Cells(2).Value
            diskonRoti = tabelDataRoti.Rows(e).Cells(3).Value
            stokRoti = tabelDataRoti.Rows(e).Cells(4).Value
        End If
    End Sub

    Private Sub btnTambahRoti_Click(sender As Object, e As EventArgs) Handles btnTambahRoti.Click
        editRoti = False
        formRoti.ShowDialog()
        refreshDataBase()
        txCariRoti.Focus()
    End Sub

    Private Sub btnEditRoti_Click(sender As Object, e As EventArgs) Handles btnEditRoti.Click
        If kodeRoti = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            editRoti = True
            formRoti.ShowDialog()
            refreshDataBase()
            txCariRoti.Focus()
        End If
    End Sub

    Private Sub btnRoti_Click(sender As Object, e As EventArgs) Handles btnRoti.Click
        UlangForm()
        PanelWrapperRoti.Visible = True
        lblKeterangan.Text = "Tekan F1 Untuk Mencari  |  Tekan F2 Untuk Menambah Data  |  Tekan F3 Untuk Menghapus"
        txCariRoti.Focus()
    End Sub

    Private Sub txCariRoti_TextChanged(sender As Object, e As EventArgs) Handles txCariRoti.TextChanged
        If txCariRoti.Text = "" Then
            refreshDataBase()
        Else
            Dim cariKodeRoti As String = "%" + txCariRoti.Text + "%"
            RotiTableAdapter.FillByCari(Me.TheBreadShopDataSet.roti, cariKodeRoti, cariKodeRoti)
        End If
    End Sub

    Private Sub PanelWrapperKasir_VisibleChanged(sender As Object, e As EventArgs) Handles PanelWrapperKasir.VisibleChanged
        If PanelWrapperKasir.Visible Then
            cariStrukKasir()
            tglKasir.Value = Now()
            ulangFormKasir()
        End If
    End Sub

    Sub cariStrukKasir()
        Dim strukTerakhir As String = Header_penjualanTableAdapter.cariStruk()
        If strukTerakhir = "" Then
            txStrukKasir.Text = "Struk 1"
        Else
            txStrukKasir.Text = String.Concat("Struk ", Header_penjualanTableAdapter.GetData().Count + 1)
        End If
        txKodeRoti.Focus()
    End Sub

    Private Sub btnCariKodeRoti_Click(sender As Object, e As EventArgs) Handles btnCariKodeRoti.Click
        formCariKodeRoti.ShowDialog()
        If txKodeRoti.Text IsNot "" Then
            txQty.Focus()
        End If
    End Sub

    Private Sub txKodeRoti_KeyDown(sender As Object, e As KeyEventArgs) Handles txKodeRoti.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txKodeRoti.Text = "" Then
                MsgBox("Mohon Data Diisi!")
                txNamaRoti.Clear()
                txHargaRoti.Clear()
            Else
                Dim dt As New TheBreadShopDataSet.rotiDataTable
                dt = RotiTableAdapter.GetDataByKode(txKodeRoti.Text + "%")
                If dt.Count = 0 Then
                    MsgBox("Kode Tidak Ada!")
                    txNamaRoti.Clear()
                    txHargaRoti.Clear()
                Else
                    txKodeRoti.Text = dt.Rows(0).Item(0)
                    txNamaRoti.Text = dt.Rows(0).Item(1)
                    txHargaRoti.Text = Decimal.ToInt32(dt.Rows(0).Item(2))
                    txDiskon.Text = dt.Rows(0).Item(3)
                    stokSedia = Integer.Parse(dt.Rows(0).Item(4))
                    txQty.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txQty.KeyDown, txHargaRoti.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txQty.Text IsNot "" Then
                If txKodeRoti.Text = "" Or txNamaRoti.Text = "" Or txHargaRoti.Text = "" Or txQty.Text = "" Or txDiskon.Text = "" Then
                    MsgBox("Mohon Data Dilengkapi!")
                Else
                    If txQty.Text > stokSedia Then
                        MsgBox("Stok Tinggal tidak tersedia!")
                    Else
                        If txDiskon.Text = "" Then
                            txDiskon.Text = 0
                        End If
                        Dim subTotal As Integer = Integer.Parse(txHargaRoti.Text) * Integer.Parse(txQty.Text)
                        If txDiskon.Text <> 0 Then
                            subTotal = subTotal - (subTotal * txDiskon.Text / 100)
                        End If
                        Dim tambah As Boolean = False
                        Dim indexTambah As Integer
                        For i = 0 To tabelDataKasir.RowCount - 1
                            If txKodeRoti.Text = tabelDataKasir.Rows(i).Cells(1).Value Then
                                tambah = True
                                indexTambah = i
                            End If
                        Next
                        If tambah Then
                            Dim edit1 As Integer = Integer.Parse(tabelDataKasir.Rows(indexTambah).Cells(4).Value)
                            Dim edit2 As Integer = Integer.Parse(tabelDataKasir.Rows(indexTambah).Cells(6).Value)
                            tabelDataKasir.Rows.RemoveAt(indexTambah)
                            tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeRoti.Text, txNamaRoti.Text, txHargaRoti.Text, Integer.Parse(txQty.Text) + edit1, txDiskon.Text, subTotal + edit2, stokSedia)
                        Else
                            tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeRoti.Text, txNamaRoti.Text, txHargaRoti.Text, txQty.Text, txDiskon.Text, subTotal, stokSedia)
                        End If
                        isiFooterKasir(subTotal, 1)
                        txKodeRoti.Clear()
                        txNamaRoti.Clear()
                        txHargaRoti.Clear()
                        txQty.Clear()
                        txDiskon.Clear()
                        txKodeRoti.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Sub isiFooterKasir(subTotal As Integer, status As Integer)
        If status = 1 Then
            totalBelanja = totalBelanja + subTotal
        Else
            totalBelanja = totalBelanja - subTotal
        End If

        txTotalBelanja.Text = totalBelanja
        If txDiskonBelanja.Text = "" Then
            txTotalPembayaran.Text = totalBelanja
        Else
            txTotalPembayaran.Text = totalBelanja - (totalBelanja * txDiskonBelanja.Text / 100)
        End If
        If txBayar.Text = "" Then
            txKembalian.Text = ""
        Else
            txKembalian.Text = txBayar.Text - txTotalPembayaran.Text
        End If
    End Sub

    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If PanelWrapperKasir.Visible Then
            If e.KeyCode = Keys.F1 Then
                btnCariKodeRoti_Click(sender, e)
            ElseIf e.KeyCode = Keys.F2 Then
                If pilihIndexTabel = "" Or tabelDataKasir.RowCount = 0 Then
                    MsgBox("Mohon Pilih Data")
                Else
                    Dim pesan As String = "Yakin membatalkan pembelian roti " + tabelDataKasir.Rows(pilihIndexTabel).Cells(1).Value + " ?"
                    If MsgBox(pesan, vbYesNo, "Konfirmasi") = vbYes Then
                        isiFooterKasir(Integer.Parse(tabelDataKasir.Rows(pilihIndexTabel).Cells(6).Value), 2)
                        tabelDataKasir.Rows.RemoveAt(pilihIndexTabel)
                        pilihIndexTabel = Nothing
                    End If
                End If
            ElseIf e.KeyCode = Keys.F3 Then
                If MsgBox("Yakin Mengulang?", vbYesNo, "Konfirmasi") = vbYes Then
                    ulangFormKasir()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                If txBayar.Text = "" Then
                    txBayar.Focus()
                Else
                    btnBayar_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub tabelDataKasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKasir.CellClick
        If e.RowIndex >= 0 Then
            pilihIndexTabel = e.RowIndex
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If tabelDataKasir.RowCount = 0 Then
            MsgBox("Mohon Data Diisi!")
        Else
            If Integer.Parse(txBayar.Text) < Integer.Parse(txTotalPembayaran.Text) Then
                MsgBox("Maaf, Uang Pelanggan Kurang")
            Else
                Header_penjualanTableAdapter.Insert(txStrukKasir.Text, tglKasir.Value, idAdmin)
                For i = 0 To tabelDataKasir.RowCount - 1
                    PenjualanTableAdapter.Insert(tabelDataKasir.Rows(i).Cells(1).Value, Integer.Parse(tabelDataKasir.Rows(i).Cells(4).Value), txStrukKasir.Text)
                    RotiTableAdapter.jual(Integer.Parse(tabelDataKasir.Rows(i).Cells(7).Value) - Integer.Parse(tabelDataKasir.Rows(i).Cells(4).Value), tabelDataKasir.Rows(i).Cells(1).Value)
                Next
                totalBelanja = 0
                ulangFormKasir()
            End If
        End If
    End Sub

    Sub ulangFormKasir()
        cariStrukKasir()
        txKodeRoti.Clear()
        txNamaRoti.Clear()
        txHargaRoti.Clear()
        txQty.Clear()
        txDiskon.Clear()
        txTotalBelanja.Clear()
        txDiskonBelanja.Clear()
        txKembalian.Clear()
        txTotalPembayaran.Clear()
        txBayar.Clear()
        tabelDataKasir.Rows.Clear()
        totalBelanja = 0
        stokSedia = 0
        txKodeRoti.Focus()
    End Sub

    Private Sub txBayar_TextChanged(sender As Object, e As EventArgs) Handles txBayar.TextChanged
        If String.IsNullOrEmpty(txBayar.Text) = False And String.IsNullOrEmpty(txTotalPembayaran.Text) = False Then
            If Integer.Parse(txBayar.Text) >= Integer.Parse(txTotalPembayaran.Text) Then
                txKembalian.Text = txBayar.Text - txTotalPembayaran.Text
            Else
                txKembalian.Clear()
            End If
        Else
            txKembalian.Clear()
        End If
    End Sub

    Sub handleTextInteger(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        handleTextInteger(e)
    End Sub

    Private Sub txDiskonBelanja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskonBelanja.KeyPress
        handleTextInteger(e)
    End Sub

    Private Sub txQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txQty.KeyPress
        handleTextInteger(e)
    End Sub

    Private Sub txBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBayar.KeyPress
        handleTextInteger(e)
        If txBayar.Text IsNot "" Or txTotalPembayaran.Text IsNot "" Then
            If txBayar.Text >= txTotalPembayaran.Text Then
                txKembalian.Text = txBayar.Text - txTotalPembayaran.Text
                If Asc(e.KeyChar) = 13 Then
                    btnBayar_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub PanelWrapperRoti_VisibleChanged(sender As Object, e As EventArgs) Handles PanelWrapperRoti.VisibleChanged
        If PanelWrapperRoti.Visible Then
            txCariRoti.Clear()
            txCariRoti.Focus()
            refreshDataBase()
        End If
    End Sub

    Private Sub txDiskonBelanja_TextChanged(sender As Object, e As EventArgs) Handles txDiskonBelanja.TextChanged
        If String.IsNullOrEmpty(txTotalPembayaran.Text) = False Then
            If txDiskonBelanja.Text = "" Then
                txTotalPembayaran.Text = txTotalBelanja.Text
            Else
                txTotalPembayaran.Text = txTotalBelanja.Text - (txTotalBelanja.Text * txDiskonBelanja.Text / 100)
            End If
            If txBayar.Text = "" Or txTotalPembayaran.Text = "" Then
                txKembalian.Text = ""
            ElseIf Integer.Parse(txBayar.Text) < Integer.Parse(txTotalPembayaran.Text) Then
                txKembalian.Text = ""
            Else txKembalian.Text = txBayar.Text - txTotalPembayaran.Text
            End If
        End If
    End Sub
End Class
