Public Class formCaesar
    ' SHOULD REALLY BE A CONSTANT, BUT VB SAYS THIS ISN'T A "CONSTANT VALUE"
    Private TEXTBOX_FOCUS_BORDER_COLOR As Color = Color.DeepSkyBlue
    Private TEXTBOX_UNFOCUS_BORDER_COLOR As Color = Color.WhiteSmoke

    Private selectedMenuButton As Control
    Private currentTextbox As TextBox

    Private textboxModifying As Boolean = False

    Private rot As Integer = 0

    Private Sub formCaesar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentTextbox = txtPlaintext
        positionElements()
    End Sub

    Private Sub positionElements()
        Const MENU_PADDING = 10
        Const MENU_CONTENT_MARGIN = 5
        Const DEMO_TEXTBOX_MARGIN = 80
        Const TEXTBOX_WIDTH = 0.8
        Const TEXTBOX_HEIGHT = 0.3
        Const ALPHABET_MARGIN = 10

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
        lblAlphabet.Top = 0
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

        lblAlphabet.Text = generateAlphabet(1)
        lblAlphabetShift.Text = encodeCaesar(lblAlphabet.Text, rot)

        ' lblAlphabet
        lblAlphabet.Left = pnlDemo.Width / 2 - lblAlphabet.Width / 2
        lblAlphabet.Top = 30

        ' lblAlphabetShift
        lblAlphabetShift.Left = lblAlphabet.Left
        lblAlphabetShift.placeBelow(lblAlphabetShift, ALPHABET_MARGIN)

        ' btnLeft
        'btnLeft.placeLeft(lblAlphabet, 10)
        btnLeft.Left = lblAlphabet.Left - btnLeft.Width - 10
        btnLeft.Top = lblAlphabet.Top + (lblAlphabet.Height + ALPHABET_MARGIN + lblAlphabetShift.Height) / 2 - btnLeft.Height / 2

        ' btnRight
        btnRight.placeRight(lblAlphabet, 10)
        btnRight.Top = btnLeft.Top

        ' txtPlaintext
        txtPlaintext.Width = pnlDemo.Width * TEXTBOX_WIDTH
        txtPlaintext.Height = pnlDemo.Height * TEXTBOX_HEIGHT
        'txtPlaintext.Left = pnlDemo.Width / 2 - DEMO_TEXTBOX_MARGIN / 2 - txtPlaintext.Width
        'txtPlaintext.Top = pnlDemo.Height / 2 - txtPlaintext.Height / 2
        txtPlaintext.Left = pnlDemo.Width / 2 - txtPlaintext.Width / 2
        txtPlaintext.Top = pnlDemo.Height / 2 - txtPlaintext.Height - DEMO_TEXTBOX_MARGIN / 2 + 60

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
        currentTextbox.Focus()
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
        If Not textboxModifying Then
            textboxModifying = True
            txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, rot)
            textboxModifying = False
        End If
    End Sub

    Private Sub txtCiphertext_TextChanged(sender As Object, e As EventArgs) Handles txtCiphertext.TextChanged
        If Not textboxModifying Then
            textboxModifying = True
            txtPlaintext.Text = encodeCaesar(txtCiphertext.Text, -rot)
            textboxModifying = False
        End If
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

    Private Sub pnlDemo_Paint(sender As Object, e As PaintEventArgs) Handles pnlDemo.Paint
        txtPlaintext.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
        txtCiphertext.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
        currentTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_FOCUS_BORDER_COLOR)
    End Sub

    Private Sub txtPlaintext_GotFocus(sender As Object, e As EventArgs) Handles txtPlaintext.GotFocus
        currentTextbox = txtPlaintext
        pnlDemo.Refresh()
    End Sub

    Private Sub txtCiphertext_GotFocus(sender As Object, e As EventArgs) Handles txtCiphertext.GotFocus
        currentTextbox = txtCiphertext
        pnlDemo.Refresh()
    End Sub

    Private Function generateAlphabet(spaces As Integer) As String
        Dim spacesString As String = "".PadRight(spaces, " ") ' GENUINELY WHAT THE FUCK IS THIS. WHY DOES STRING MULTIPLICATION NOT EXIST IN VB. THIS IS AIDS. From: https://www.rosettacode.org/wiki/Repeat_a_string#Visual_Basic_.NET

        Return String.Join(spacesString, ALPHABET.Select(Function(c) c.ToString()).ToArray()) ' THIS IS LITERALLY THE MOST FUCKING RETARDED FUNCTION IN VB. WHY THE FUCK CAN IT NOT TAKE A CHAR ARRAY BUT ONLY STRING ARRAYS. WHAT THE FUCK IS THE FUCKING DIFFERENCE. FUCK VB.
    End Function

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        rot -= 1
        lblAlphabetShift.Text = encodeCaesar(lblAlphabet.Text, rot)
        textboxModifying = True
        txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, rot)
        textboxModifying = False
        currentTextbox.Focus()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        rot += 1
        lblAlphabetShift.Text = encodeCaesar(lblAlphabet.Text, rot)
        textboxModifying = True
        txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, rot)
        textboxModifying = False
        currentTextbox.Focus()
    End Sub

    ' BECAUSE VB.NET IS FUCKING RETARDED AND DECIDED TO SELECT ALL TEXT INSIDE THIS PARTICULAR TEXTBOX
    ' WHEN .Focus() IS CALLED ON IT FOR ABSOLUTELY NO REASON AT ALL.
    ' The exact same thing was called on the other textbox, but it didn't happen.
    ' RETARDED...
    Private Sub txtCiphertext_Enter(sender As Object, e As EventArgs) Handles txtCiphertext.Enter
        Dim position As Integer = txtCiphertext.Text.Length
        txtCiphertext.Select(position, position)
    End Sub
End Class