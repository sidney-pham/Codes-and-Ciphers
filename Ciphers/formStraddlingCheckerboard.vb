Public Class formStraddlingCheckerboard
    Private selectedMenuButton As Control

    Private Sub formStraddlingCheckerboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        Const MENU_PADDING = 10
        Const MENU_CONTENT_MARGIN = 5
        Const DEMO_TEXTBOX_MARGIN = 80
        Const TEXTBOX_WIDTH = 0.8
        Const TEXTBOX_HEIGHT = 0.3
        Const ALPHABET_MARGIN = 10

        ' Putting this here so it runs early on so blinking is mitigated.
        pnlAbout1.Show()
        pnlAbout2.Hide()
        btnNextPageAbout.Show()
        btnPreviousPageAbout.Hide()
        pnlDemo.Hide()
        'pnlDecryption1.Hide()
        'pnlDecryption2.Hide()
        pnlPrintout.Hide()
        'btnPreviousPageDecryption.Hide()
        'btnNextPageDecryption.Hide()
        pnlDecryption.Hide()

        ' lblStraddlingCheckerboard
        lblStraddlingCheckerboard.horizontallyCentre()
        lblStraddlingCheckerboard.Top = 50

        ' btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25

        ' btnAbout
        btnAbout.Left = Me.Width / 2 - (btnAbout.Width + MENU_PADDING + btnDemo.Width + MENU_PADDING + MENU_PADDING + btnPrintout.Width) / 2
        btnAbout.placeBelow(lblStraddlingCheckerboard, 5)

        ' btnDemo
        btnDemo.placeRight(btnAbout, MENU_PADDING)
        btnDemo.Top = btnAbout.Top

        ' btnPrintout
        btnPrintout.placeRight(btnDemo, MENU_PADDING)
        btnPrintout.Top = btnAbout.Top

        ' ------------------------------------------------------------------------
        ' pnlAbout1
        ' ------------------------------------------------------------------------
        pnlAbout1.Width = Me.Width * 0.9
        pnlAbout1.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlAbout1.horizontallyCentre()
        pnlAbout1.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' lblStraddlingInfo1
        lblStraddlingInfo1.Left = 0
        lblStraddlingInfo1.Top = 0
        lblStraddlingInfo1.MaximumSize = New Size(pnlAbout1.Width, 0)

        ' btnNextPageAbout
        btnNextPageAbout.Show()
        btnNextPageAbout.Height = 0.15 * Me.Width
        btnNextPageAbout.Width = 0.05 * Me.Width
        btnNextPageAbout.Left = Me.Width - btnNextPageAbout.Width
        btnNextPageAbout.verticallyCentre()

        ' btnPreviousPageAbout
        btnPreviousPageAbout.Hide()
        btnPreviousPageAbout.Height = 0.15 * Me.Width
        btnPreviousPageAbout.Width = 0.05 * Me.Width
        btnPreviousPageAbout.Left = 0
        btnPreviousPageAbout.verticallyCentre()

        ' ------------------------------------------------------------------------
        ' pnlAbout2
        ' ------------------------------------------------------------------------
        pnlAbout2.Width = Me.Width * 0.9
        pnlAbout2.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlAbout2.horizontallyCentre()
        pnlAbout2.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' lblStraddlingInfo2
        lblStraddlingInfo2.Left = 0
        lblStraddlingInfo2.Top = 0
        lblStraddlingInfo2.MaximumSize = New Size(pnlAbout2.Width, 0)

        picStraddling1.Height = 100 '0.8 * (pnlAbout2.Height - lblStraddlingInfo2.Height - lblStraddlingInfo3.Height - lblStraddling1Caption.Height - 20 - 5 - 5 - 20)
        picStraddling1.Left = pnlAbout2.Width / 4 - picStraddling1.Width / 2
        picStraddling1.placeBelow(lblStraddlingInfo2, 20)

        picStraddling2.Height = picStraddling1.Height
        picStraddling2.Left = pnlAbout2.Width / 4 * 3 - picStraddling2.Width / 2
        picStraddling2.Top = picStraddling1.Top

        lblStraddling1Caption.Left = pnlAbout2.Width / 4 - lblStraddling1Caption.Width / 2
        lblStraddling1Caption.placeBelow(picStraddling1, 0)

        lblStraddling2Caption.Left = pnlAbout2.Width / 4 * 3 - lblStraddling2Caption.Width / 2
        lblStraddling2Caption.placeBelow(picStraddling2, 5)

        lblStraddlingInfo3.Left = 0
        lblStraddlingInfo3.placeBelow(lblStraddling1Caption, 20)
        lblStraddlingInfo3.MaximumSize = New Size(pnlAbout2.Width, 0)
        ' ------------------------------------------------------------------------
        ' pnlDemo
        ' ------------------------------------------------------------------------
        pnlDemo.Width = Me.Width * 0.9
        pnlDemo.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlDemo.horizontallyCentre()
        pnlDemo.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        'lblAlphabet.Text = generateAlphabet(1)
        'lblAlphabetShift.Text = encodeCaesar(lblAlphabet.Text, rot)

        ' lblAlphabet
        lblAlphabet.Left = pnlDemo.Width / 2 - lblAlphabet.Width / 2
        lblAlphabet.Top = 30

        ' lblAlphabetShift
        lblAlphabetShift.Left = lblAlphabet.Left
        lblAlphabetShift.placeBelow(lblAlphabetShift, ALPHABET_MARGIN)

        ' btnLeft
        btnLeft.Height = lblAlphabet.Height + ALPHABET_MARGIN + lblAlphabetShift.Height
        btnLeft.Width = 0.5 * btnLeft.Height
        'btnLeft.placeLeft(lblAlphabet, 10)
        btnLeft.Left = lblAlphabet.Left - btnLeft.Width - 10
        btnLeft.Top = lblAlphabet.Top 'lblAlphabet.Top + (lblAlphabet.Height + ALPHABET_MARGIN + lblAlphabetShift.Height) / 2 - btnLeft.Height / 2

        ' btnRight
        btnRight.Height = btnLeft.Height
        btnRight.Width = 0.5 * btnRight.Height
        btnRight.placeRight(lblAlphabet, 10)
        btnRight.Top = btnLeft.Top

        ' lblShift
        lblShift.Left = pnlDemo.Width / 2 - lblShift.Width / 2
        lblShift.placeBelow(lblAlphabetShift, 15)

        ' txtPlaintext
        txtPlaintext.Width = pnlDemo.Width * TEXTBOX_WIDTH
        txtPlaintext.Height = pnlDemo.Height * TEXTBOX_HEIGHT
        'txtPlaintext.Left = pnlDemo.Width / 2 - DEMO_TEXTBOX_MARGIN / 2 - txtPlaintext.Width
        'txtPlaintext.Top = pnlDemo.Height / 2 - txtPlaintext.Height / 2
        txtPlaintext.Left = pnlDemo.Width / 2 - txtPlaintext.Width / 2
        txtPlaintext.placeBelow(lblShift, 50) 'pnlDemo.Height / 2 - txtPlaintext.Height - DEMO_TEXTBOX_MARGIN / 2 + 60

        ' txtCiphertext
        txtCiphertext.Width = pnlDemo.Width * TEXTBOX_WIDTH
        txtCiphertext.Height = pnlDemo.Height * TEXTBOX_HEIGHT
        txtCiphertext.Left = pnlDemo.Width / 2 - txtCiphertext.Width / 2
        txtCiphertext.placeBelow(txtPlaintext, DEMO_TEXTBOX_MARGIN)

        ' lblPlaintext
        lblPlaintext.Left = txtPlaintext.Left
        lblPlaintext.placeAbove(txtPlaintext, 10)

        ' lblCiphertext
        lblCiphertext.Left = txtCiphertext.Left
        lblCiphertext.placeAbove(txtCiphertext, 10)

        ' ------------------------------------------------------------------------
        ' pnlPrintout
        ' ------------------------------------------------------------------------
        pnlPrintout.Width = Me.Width * 0.9
        pnlPrintout.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlPrintout.horizontallyCentre()
        pnlPrintout.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' picStraddlingPrintout
        picStraddlingPrintout.Left = pnlPrintout.Width / 4 - picStraddlingPrintout.Width / 2
        picStraddlingPrintout.Top = 100

        ' btnPrint
        btnPrint.Left = pnlPrintout.Width / 4 - btnPrint.Width / 2
        btnPrint.placeBelow(picStraddlingPrintout, 50)

        ' lblPrintoutExplanation
        lblPrintoutExplanation.MaximumSize = New Size(pnlPrintout.Width / 2, 0)
        lblPrintoutExplanation.Left = picStraddlingPrintout.Left + picStraddlingPrintout.Width + (pnlPrintout.Width - picStraddlingPrintout.Left - picStraddlingPrintout.Width - lblPrintoutExplanation.Width) / 2
        lblPrintoutExplanation.Top = 100

        btnAbout.PerformClick()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        selectedMenuButton.drawBottomBorder(e.Graphics, Color.Silver)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        btnAbout.PerformClick()

        formMain.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        selectedMenuButton = btnAbout
        Me.Refresh()

        pnlAbout1.Show()
        pnlAbout2.Hide()
        btnNextPageAbout.Show()
        btnPreviousPageAbout.Hide()
        pnlDemo.Hide()
        pnlDecryption.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnDemo_Click(sender As Object, e As EventArgs) Handles btnDemo.Click
        selectedMenuButton = btnDemo
        Me.Refresh()

        pnlDemo.Show()
        pnlAbout1.Hide()
        pnlAbout2.Hide()
        btnNextPageAbout.Hide()
        btnPreviousPageAbout.Hide()
        pnlDecryption.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnPrintout_Click(sender As Object, e As EventArgs) Handles btnPrintout.Click
        selectedMenuButton = btnPrintout
        Me.Refresh()

        pnlPrintout.Show()
        pnlAbout1.Hide()
        pnlAbout2.Hide()
        btnNextPageAbout.Hide()
        btnPreviousPageAbout.Hide()
        pnlDemo.Hide()
        pnlDecryption.Hide()
    End Sub

    Private Sub btnPreviousPageAbout_Click(sender As Object, e As EventArgs) Handles btnPreviousPageAbout.Click
        btnPreviousPageAbout.Hide()
        pnlAbout1.Show()
        pnlAbout2.Hide()
        btnNextPageAbout.Show()
    End Sub

    Private Sub btnNextPageAbout_Click(sender As Object, e As EventArgs) Handles btnNextPageAbout.Click
        btnNextPageAbout.Hide()
        pnlAbout2.Show()
        pnlAbout1.Hide()
        btnPreviousPageAbout.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        printPictureBox(picStraddlingPrintout, picHidden)
        e.Graphics.DrawImage(picHidden.Image, 0, 0)
    End Sub
End Class