Public Class formRoti
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Sub formRoti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainMenu.editRoti = False Then
            ulangForm()
        Else
            txKode.Text = MainMenu.kodeRoti
            txNama.Text = MainMenu.namaRoti
            txHarga.Text = MainMenu.hargaRoti
            txDiskon.Text = MainMenu.diskonRoti
            txStok.Text = MainMenu.stokRoti
            txKode.Enabled = False
            txNama.Focus()
        End If
    End Sub
    Sub ulangForm()
        txKode.Clear()
        txNama.Clear()
        txHarga.Clear()
        txDiskon.Clear()
        txStok.Clear()
        txKode.Enabled = True
        txKode.Focus()
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        If MainMenu.editRoti = False Then
            ulangForm()
        Else
            txNama.Clear()
            txHarga.Clear()
            txDiskon.Clear()
            txStok.Clear()
            txNama.Focus()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txKode.Text = "" Or txNama.Text = "" Or txHarga.Text = "" Or txDiskon.Text = "" Or txDiskon.Text = "" Then
            MsgBox("Mohon Data Dilengkapi!")
        Else
            If MainMenu.editRoti = False Then
                RotiTableAdapter.Insert(txKode.Text, txNama.Text, txHarga.Text, txDiskon.Text, txStok.Text)
            Else
                RotiTableAdapter.edit(txNama.Text, txHarga.Text, txDiskon.Text, txStok.Text, txKode.Text)
            End If
            Me.Close()
        End If
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

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class