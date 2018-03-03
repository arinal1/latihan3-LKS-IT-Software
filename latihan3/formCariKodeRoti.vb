Public Class formCariKodeRoti
    Dim kodeRoti As String
    Dim namaroti As String
    Dim hargaRoti As Integer
    Dim diskon As Integer
    'window bar
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

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

    Private Sub formCariKodeRoti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TheBreadShopDataSet.roti' table. You can move, or remove it, as needed.
        Me.RotiTableAdapter.Fill(Me.TheBreadShopDataSet.roti)
        kodeRoti = ""
        namaroti = ""
        hargaRoti = 0
        diskon = 0
        txCariRoti.Focus()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub tabelDataRoti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataRoti.CellClick
        pilihsel(e.RowIndex)
    End Sub

    Sub pilihsel(ByVal e As String)
        If e >= 0 Then
            kodeRoti = tabelDataRoti.Rows(e).Cells(0).Value
            namaroti = tabelDataRoti.Rows(e).Cells(1).Value
            hargaRoti = Decimal.ToInt32(tabelDataRoti.Rows(e).Cells(2).Value)
            diskon = tabelDataRoti.Rows(e).Cells(3).Value
        End If
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        If kodeRoti = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            MainMenu.txKodeRoti.Text = kodeRoti
            MainMenu.txNamaRoti.Text = namaroti
            MainMenu.txHargaRoti.Text = hargaRoti
            MainMenu.txDiskon.Text = diskon
            Me.Close()
            MainMenu.txQty.Focus()
        End If
    End Sub
    Private Sub txCariRoti_TextChanged(sender As Object, e As EventArgs) Handles txCariRoti.TextChanged
        If txCariRoti.Text = "" Then
            Me.RotiTableAdapter.Fill(Me.TheBreadShopDataSet.roti)
        Else
            Dim cariKodeRoti As String = "%" + txCariRoti.Text + "%"
            RotiTableAdapter.FillByCari(Me.TheBreadShopDataSet.roti, cariKodeRoti, cariKodeRoti)
        End If
    End Sub
End Class