Public Class formVigenere
    Private Sub formVigenere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        ' lblVigenere
        lblVigenere.horizontallyCentre()
        lblVigenere.Top = 50

        ' btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class