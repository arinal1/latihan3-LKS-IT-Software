Public Class FormLogin
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txID.Clear()
        txPassword.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txID.Text = "" Or txPassword.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong!")
        Else
            Dim dt As New TheBreadShopDataSet.karyawanDataTable
            dt = KaryawanTableAdapter.GetDataByLogin(txID.Text, txPassword.Text)
            If dt.Count = 0 Then
                MsgBox("ID atau Password Salah!")
            Else
                MainMenu.idAdmin = dt.Rows(0).Item(0)
                MainMenu.admin = dt.Rows(0).Item(1)
                MainMenu.lvlAdmin = dt.Rows(0).Item(4)
                MainMenu.lblAdmin.Text = MainMenu.admin
                Me.Hide()
                MainMenu.ShowDialog()
                If MainMenu.logOut = False Then
                    Me.Close()
                End If
                txID.Clear()
                txPassword.Clear()
                txID.Focus()
            End If
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