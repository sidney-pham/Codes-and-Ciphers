Public Class formCaesar
    ' SHOULD REALLY BE A CONSTANT, BUT VB SAYS THIS ISN'T A "CONSTANT VALUE"
    Private TEXTBOX_FOCUS_BORDER_COLOR As Color = Color.CornflowerBlue
    Private TEXTBOX_UNFOCUS_BORDER_COLOR As Color = Color.WhiteSmoke

    Private selectedMenuButton As Control
    Private currentTextbox As TextBox

    Private textboxModifying As Boolean = False
    Private swap As Boolean = False

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
        lblCaesarInfo1.Top = 0
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

        ' btnSwap
        btnSwap.Left = pnlDemo.Width / 2 - btnSwap.Width / 2
        btnSwap.placeBelow(txtPlaintext, (DEMO_TEXTBOX_MARGIN) / 2 - btnSwap.Height / 2)

        ' ------------------------------------------------------------------------
        ' pnlDecryption
        ' ------------------------------------------------------------------------
        pnlDecryption.Width = Me.Width * 0.9
        pnlDecryption.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlDecryption.horizontallyCentre()
        pnlDecryption.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' lblCaesarCracking
        lblCaesarCracking.Left = 0
        lblCaesarCracking.Top = 0
        lblCaesarCracking.MaximumSize = New Size(pnlDecryption.Width, 0)

        ' lblTryItOut
        lblTryItOut.Left = pnlDecryption.Width / 2 - lblTryItOut.Width / 2
        lblTryItOut.placeBelow(lblCaesarCracking, 50)

        ' lblTryExplanation
        lblTryExplanation.Left = 0
        lblTryExplanation.placeBelow(lblTryItOut, 20)
        lblTryExplanation.MaximumSize = New Size(pnlDecryption.Width, 0)

        ' btnDecyptionExample
        btnDecryptionExample.Left = pnlDecryption.Width / 2 - btnDecryptionExample.Width / 2
        btnDecryptionExample.placeBelow(lblTryExplanation, 30)
        ' ------------------------------------------------------------------------
        ' pnlPrintout
        ' ------------------------------------------------------------------------
        pnlPrintout.Width = Me.Width * 0.9
        pnlPrintout.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlPrintout.horizontallyCentre()
        pnlPrintout.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' picCaesarPrintout
        picCaesarPrintout.Left = pnlPrintout.Width / 4 - picCaesarPrintout.Width / 2
        picCaesarPrintout.Top = 100

        ' btnPrint
        btnPrint.Left = pnlPrintout.Width / 4 - btnPrint.Width / 2
        btnPrint.placeBelow(picCaesarPrintout, 50)

        ' lblPrintoutExplanation
        lblPrintoutExplanation.MaximumSize = New Size(pnlPrintout.Width / 2, 0)
        lblPrintoutExplanation.Left = picCaesarPrintout.Left + picCaesarPrintout.Width + (pnlPrintout.Width - picCaesarPrintout.Left - picCaesarPrintout.Width - lblPrintoutExplanation.Width) / 2
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
        currentTextbox.Focus()
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

    Private Sub txtPlaintext_TextChanged(sender As Object, e As EventArgs) Handles txtPlaintext.TextChanged
        If Not textboxModifying Then
            If Not swap Then
                textboxModifying = True
                txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, rot)
                textboxModifying = False
            End If
        End If
    End Sub

    Private Sub txtCiphertext_TextChanged(sender As Object, e As EventArgs) Handles txtCiphertext.TextChanged
        If Not textboxModifying Then
            If Not swap Then
                textboxModifying = True
                txtPlaintext.Text = encodeCaesar(txtCiphertext.Text, -rot)
                textboxModifying = False
            End If
        End If
    End Sub

    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        swap = True
        txtPlaintext.Text = txtCiphertext.Text
        txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, rot)
        swap = False
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

    Private Sub btnLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLeft.MouseDown
        rot -= 1
        lblAlphabetShift.Text = encodeCaesar(lblAlphabet.Text, rot)
        textboxModifying = True
        txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, rot)
        textboxModifying = False
        currentTextbox.Focus()

        ' Update shift
        lblShift.Text = "SHIFT: " & (rot Mod LENGTH_OF_ALPHABET + LENGTH_OF_ALPHABET) Mod LENGTH_OF_ALPHABET
    End Sub

    Private Sub btnRight_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRight.MouseDown
        rot += 1
        lblAlphabetShift.Text = encodeCaesar(lblAlphabet.Text, rot)
        textboxModifying = True
        txtCiphertext.Text = encodeCaesar(txtPlaintext.Text, rot)
        textboxModifying = False
        currentTextbox.Focus()

        ' Update shift
        lblShift.Text = "SHIFT: " & (rot Mod LENGTH_OF_ALPHABET + LENGTH_OF_ALPHABET) Mod LENGTH_OF_ALPHABET
    End Sub

    ' BECAUSE VB.NET IS FUCKING RETARDED AND DECIDED TO SELECT ALL TEXT INSIDE THIS PARTICULAR TEXTBOX
    ' WHEN .Focus() IS CALLED ON IT FOR ABSOLUTELY NO REASON AT ALL.
    Private Sub txtCiphertext_Enter(sender As Object, e As EventArgs) Handles txtCiphertext.Enter
        Dim position As Integer = txtCiphertext.Text.Length
        txtCiphertext.Select(position, position)
    End Sub

    Private Sub txtPlaintext_Enter(sender As Object, e As EventArgs) Handles txtPlaintext.Enter
        Dim position As Integer = txtPlaintext.Text.Length
        txtPlaintext.Select(position, position)
    End Sub

    Private Sub btnDecryptionExample_Click(sender As Object, e As EventArgs) Handles btnDecryptionExample.Click
        btnDemo.PerformClick()
        rot = 13
        txtPlaintext.Text = "The quick brown fox jumps over the lazy dog."
        lblAlphabetShift.Text = encodeCaesar(lblAlphabet.Text, rot)

        ' Update shift
        lblShift.Text = "SHIFT: " & (rot Mod LENGTH_OF_ALPHABET + LENGTH_OF_ALPHABET) Mod LENGTH_OF_ALPHABET
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        printPictureBox(picCaesarPrintout, picHidden)
        e.Graphics.DrawImage(picHidden.Image, 0, 0)
    End Sub
End Class