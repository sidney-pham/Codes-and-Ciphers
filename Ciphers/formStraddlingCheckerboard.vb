Public Class formStraddlingCheckerboard
    Private Sub formStraddlingCheckerboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        ' lblStraddlingCheckerboard
        lblStraddlingCheckerboard.horizontallyCentre()
        lblStraddlingCheckerboard.Top = 50

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