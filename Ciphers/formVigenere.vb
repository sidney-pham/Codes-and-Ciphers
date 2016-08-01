Public Class formVigenere
    Private selectedMenuButton As Control

    Private Sub formVigenere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        Const MENU_PADDING = 10
        Const MENU_CONTENT_MARGIN = 5
        Const DEMO_TEXTBOX_MARGIN = 80
        Const TEXTBOX_WIDTH = 0.8
        Const TEXTBOX_HEIGHT = 0.3
        Const ALPHABET_MARGIN = 10

        ' lblVigenere
        lblVigenere.horizontallyCentre()
        lblVigenere.Top = 50

        ' btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25

        ' btnAbout
        btnAbout.Left = Me.Width / 2 - (btnAbout.Width + MENU_PADDING + btnDemo.Width + MENU_PADDING + btnCracking.Width + MENU_PADDING + btnPrintout.Width) / 2
        btnAbout.placeBelow(lblVigenere, 5)

        ' btnDemo
        btnDemo.placeRight(btnAbout, MENU_PADDING)
        btnDemo.Top = btnAbout.Top

        ' btnCracking
        btnCracking.placeRight(btnDemo, MENU_PADDING)
        btnCracking.Top = btnAbout.Top

        ' btnPrintout
        btnPrintout.placeRight(btnCracking, MENU_PADDING)
        btnPrintout.Top = btnAbout.Top

        ' ------------------------------------------------------------------------
        ' pnlAbout
        ' ------------------------------------------------------------------------
        pnlAbout.Width = Me.Width * 0.9
        pnlAbout.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlAbout.horizontallyCentre()
        pnlAbout.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

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
        ' pnlDecryption
        ' ------------------------------------------------------------------------
        pnlDecryption.Width = Me.Width * 0.9
        pnlDecryption.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlDecryption.horizontallyCentre()
        pnlDecryption.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' ------------------------------------------------------------------------
        ' pnlPrintout
        ' ------------------------------------------------------------------------
        pnlPrintout.Width = Me.Width * 0.9
        pnlPrintout.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlPrintout.horizontallyCentre()
        pnlPrintout.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

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

        pnlAbout.Show()
        pnlDemo.Hide()
        pnlDecryption.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnDemo_Click(sender As Object, e As EventArgs) Handles btnDemo.Click
        selectedMenuButton = btnDemo
        Me.Refresh()

        pnlDemo.Show()
        pnlAbout.Hide()
        pnlDecryption.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnCracking_Click(sender As Object, e As EventArgs) Handles btnCracking.Click
        selectedMenuButton = btnCracking
        Me.Refresh()

        pnlDecryption.Show()
        pnlAbout.Hide()
        pnlDemo.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnPrintout_Click(sender As Object, e As EventArgs) Handles btnPrintout.Click
        selectedMenuButton = btnPrintout
        Me.Refresh()

        pnlPrintout.Show()
        pnlAbout.Hide()
        pnlDemo.Hide()
        pnlDecryption.Hide()
    End Sub
End Class