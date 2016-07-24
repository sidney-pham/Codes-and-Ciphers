Public Class formCaesar
    Private selectedMenuButton As Control

    Private Sub formCaesar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
    End Sub

    Private Sub positionElements()
        Const MENU_PADDING = 10
        Const MENU_CONTENT_MARGIN = 5
        Const DEMO_TEXTBOX_MARGIN = 80

        ' lblCaesarCipher
        lblCaesarCipher.horizontallyCentre()
        lblCaesarCipher.Top = 20

        ' btnBack
        btnBack.Left = 25
        btnBack.Top = Me.Height - btnBack.Height - 25

        ' btnAbout
        btnAbout.Left = Me.Width / 2 - (btnAbout.Width + MENU_PADDING + btnDemo.Width + MENU_PADDING + btnCracking.Width + MENU_PADDING + btnPrintout.Width) / 2
        btnAbout.placeBelow(lblCaesarCipher, 5)

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

        ' lblInfo
        lblCaesarInfo1.Left = 0
        lblCaesarInfo1.MaximumSize = New Size(pnlAbout.Width, 0)

        ' picCaesarDiagram
        picCaesarDiagram.Left = pnlAbout.Width / 2 - picCaesarDiagram.Width / 2
        picCaesarDiagram.placeBelow(lblCaesarInfo1, 25)

        ' ------------------------------------------------------------------------
        ' pnlDemo
        ' ------------------------------------------------------------------------
        pnlDemo.Width = Me.Width * 0.9
        pnlDemo.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlDemo.horizontallyCentre()
        pnlDemo.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' txtPlaintext
        txtPlaintext.Width = pnlDemo.Width * 0.4
        txtPlaintext.Height = pnlDemo.Height * 0.8
        txtPlaintext.Left = pnlDemo.Width / 2 - DEMO_TEXTBOX_MARGIN / 2 - txtPlaintext.Width
        txtPlaintext.Top = pnlDemo.Height / 2 - txtPlaintext.Height / 2

        ' txtCiphertext
        txtCiphertext.Width = pnlDemo.Width * 0.4
        txtCiphertext.Height = pnlDemo.Height * 0.8
        txtCiphertext.placeRight(txtPlaintext, DEMO_TEXTBOX_MARGIN)
        txtCiphertext.Top = pnlDemo.Height / 2 - txtPlaintext.Height / 2

        ' ------------------------------------------------------------------------
        ' pnlCracking
        ' ------------------------------------------------------------------------
        pnlCracking.Width = Me.Width * 0.9
        pnlCracking.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlCracking.horizontallyCentre()
        pnlCracking.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' textbox1
        lblCaesarCracking.Left = pnlCracking.Width / 2 - lblCaesarCracking.Width / 2
        lblCaesarCracking.Top = pnlCracking.Height / 2 - lblCaesarCracking.Height / 2

        ' ------------------------------------------------------------------------
        ' pnlPrintout
        ' ------------------------------------------------------------------------
        pnlPrintout.Width = Me.Width * 0.9
        pnlPrintout.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlPrintout.horizontallyCentre()
        pnlPrintout.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' textbox1
        lblPrintout.Left = pnlPrintout.Width / 2 - lblPrintout.Width / 2
        lblPrintout.Top = pnlPrintout.Height / 2 - lblPrintout.Height / 2

        btnAbout.PerformClick()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        selectedMenuButton.drawBottomBorder(e.Graphics, Color.Silver)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        selectedMenuButton = btnAbout
        Me.Refresh()

        pnlAbout.Show()
        pnlDemo.Hide()
        pnlCracking.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnDemo_Click(sender As Object, e As EventArgs) Handles btnDemo.Click
        selectedMenuButton = btnDemo
        Me.Refresh()

        pnlDemo.Show()
        pnlAbout.Hide()
        pnlCracking.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnCracking_Click(sender As Object, e As EventArgs) Handles btnCracking.Click
        selectedMenuButton = btnCracking
        Me.Refresh()

        pnlCracking.Show()
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
        pnlCracking.Hide()
    End Sub

    Private Sub txtPlaintext_TextChanged(sender As Object, e As EventArgs) Handles txtPlaintext.TextChanged
        txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, 4)
    End Sub

    Private Sub txtPlaintext_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPlaintext.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            txtPlaintext.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtCiphertext_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCiphertext.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            txtCiphertext.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class