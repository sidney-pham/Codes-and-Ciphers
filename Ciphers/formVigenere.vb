Imports System.Text.RegularExpressions

Public Class formVigenere
    ' SHOULD REALLY BE A CONSTANT, BUT VB SAYS THIS ISN'T A "CONSTANT VALUE"
    Private TEXTBOX_FOCUS_BORDER_COLOR As Color = Color.CornflowerBlue
    Private TEXTBOX_UNFOCUS_BORDER_COLOR As Color = Color.WhiteSmoke
    Private TEXTBOX_ERROR_BORDER_COLOR As Color = Color.Red

    Private selectedMenuButton As Control
    Private currentTextbox As TextBox
    Private errorTextboxExists As Boolean = False
    Private errorTextbox As TextBox
    Private key As String

    Private Sub formVigenere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentTextbox = txtKey
        positionElements()
    End Sub

    Private Sub positionElements()
        Const MENU_PADDING = 10
        Const MENU_CONTENT_MARGIN = 5
        Const DEMO_TEXTBOX_MARGIN = 80
        Const TEXTBOX_WIDTH = 0.8
        Const TEXTBOX_HEIGHT = 0.2

        ' Putting this here so it runs early on so blinking is mitigated.
        pnlAbout2.Hide()
        pnlDemo.Hide()
        pnlDecryption.Hide()
        pnlPrintout.Hide()

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
        ' pnlAbout1
        ' ------------------------------------------------------------------------
        pnlAbout1.Show()

        pnlAbout1.Width = Me.Width * 0.9
        pnlAbout1.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlAbout1.horizontallyCentre()
        pnlAbout1.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' lblVigenereInfo1
        lblVigenereInfo1.Left = 0
        lblVigenereInfo1.Top = 0
        lblVigenereInfo1.MaximumSize = New Size(pnlAbout1.Width, 0)

        ' picAlberti
        picAlberti.Height = pnlAbout1.Height - lblVigenereInfo1.Height - lblAlbertiCaption.Height - 40
        picAlberti.Left = pnlAbout1.Width / 4 - picAlberti.Width / 2
        picAlberti.placeBelow(lblVigenereInfo1, 30)

        ' picVigenere
        picVigenere.Height = pnlAbout1.Height - lblVigenereInfo1.Height - lblVigenereCaption.Height - 40
        picVigenere.Left = pnlAbout1.Width / 4 * 3 - picVigenere.Width / 2
        picVigenere.placeBelow(lblVigenereInfo1, 30)

        ' lblAlbertiCaption
        lblAlbertiCaption.Left = pnlAbout1.Width / 4 - lblAlbertiCaption.Width / 2
        lblAlbertiCaption.placeBelow(picAlberti, 10)

        ' lblVigenereCaption
        lblVigenereCaption.Left = pnlAbout1.Width / 4 * 3 - lblVigenereCaption.Width / 2
        lblVigenereCaption.placeBelow(picVigenere, 10)

        ' btnNextPage
        btnNextPage.Show()
        btnNextPage.Height = 0.15 * Me.Width
        btnNextPage.Width = 0.05 * Me.Width
        btnNextPage.Left = Me.Width - btnNextPage.Width
        btnNextPage.verticallyCentre()

        ' btnPreviousPage
        btnPreviousPage.Hide()
        btnPreviousPage.Height = 0.15 * Me.Width
        btnPreviousPage.Width = 0.05 * Me.Width
        btnPreviousPage.Left = 0
        btnPreviousPage.verticallyCentre()

        ' ------------------------------------------------------------------------
        ' pnlAbout2
        ' ------------------------------------------------------------------------
        pnlAbout2.Hide()

        pnlAbout2.Width = Me.Width * 0.9
        pnlAbout2.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlAbout2.horizontallyCentre()
        pnlAbout2.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' lblVigenereInfo2
        lblVigenereInfo2.Left = 0
        lblVigenereInfo2.Top = 0
        lblVigenereInfo2.MaximumSize = New Size(pnlAbout2.Width, 0)

        ' picVigenereSquare
        picVigenereSquare.Height = pnlAbout2.Height * 0.3
        picVigenereSquare.Left = pnlAbout2.Width / 2 - picVigenereSquare.Width / 2
        picVigenereSquare.placeBelow(lblVigenereInfo2, 10)

        ' lblVigenereSquareCaption
        lblVigenereSquareCaption.Left = pnlAbout2.Width / 2 - lblVigenereSquareCaption.Width / 2
        lblVigenereSquareCaption.placeBelow(picVigenereSquare, 10)

        ' lblVigenereInfo3
        lblVigenereInfo3.Left = 0
        lblVigenereInfo3.placeBelow(lblVigenereSquareCaption, 10)
        lblVigenereInfo3.MaximumSize = New Size(pnlAbout2.Width, 0)

        ' ------------------------------------------------------------------------
        ' pnlDemo
        ' ------------------------------------------------------------------------
        pnlDemo.Width = Me.Width * 0.9
        pnlDemo.Height = btnBack.Top - btnDemo.Top - btnDemo.Height - MENU_CONTENT_MARGIN
        pnlDemo.horizontallyCentre()
        pnlDemo.placeBelow(btnAbout, MENU_CONTENT_MARGIN)

        ' lblKey
        lblKey.Left = pnlDemo.Width / 2 - (lblKey.Width + txtKey.Width + 15) / 2
        lblKey.Top = 30 - lblKey.Height / 2

        ' txtKey
        txtKey.placeRight(lblKey, 15)
        txtKey.Top = 30 - txtKey.Height / 2

        ' lblKeyLarge
        lblKeyLarge.placeBelow(txtKey, 20)
        lblKeyLarge.Text = generateKeyLabel(txtKey.Text)

        lblPlaintextAddition.Left = pnlDemo.Width / 2 - (lblPlaintextAddition.Width + lblPlaintextAdditionSubscript.Width - 2 + 10 + lblPlusAddition.Width + 10 + lblKeyAddition.Width + lblKeyAdditionSubscript.Width - 2 + 10 + lblEqualsAddition.Width + 10 + lblResultAddition.Width + lblResultAdditionSubscript.Width - 2) / 2
        lblPlaintextAddition.placeBelow(lblKeyLarge, 15)

        lblPlaintextAdditionSubscript.placeRight(lblPlaintextAddition, -2)
        lblPlaintextAdditionSubscript.placeBelow(lblPlaintextAddition, -2)

        lblPlusAddition.placeRight(lblPlaintextAddition, 10)
        lblPlusAddition.Top = lblPlaintextAddition.Top + lblPlaintextAddition.Height / 2 - lblPlusAddition.Height / 2

        lblKeyAddition.placeRight(lblPlusAddition, 10)
        lblKeyAddition.Top = lblPlaintextAddition.Top

        lblKeyAdditionSubscript.placeRight(lblKeyAddition, -2)
        lblKeyAdditionSubscript.placeBelow(lblKeyAddition, -2)

        lblEqualsAddition.placeRight(lblKeyAddition, 10)
        lblEqualsAddition.Top = lblPlaintextAddition.Top + lblPlaintextAddition.Height / 2 - lblEqualsAddition.Height / 2

        lblResultAddition.placeRight(lblEqualsAddition, 10)
        lblResultAddition.Top = lblPlaintextAddition.Top

        lblResultAdditionSubscript.placeRight(lblResultAddition, -2)
        lblResultAdditionSubscript.placeBelow(lblResultAddition, -2)


        ' txtPlaintext
        txtPlaintext.Width = pnlDemo.Width * TEXTBOX_WIDTH
        txtPlaintext.Height = pnlDemo.Height * TEXTBOX_HEIGHT
        'txtPlaintext.Left = pnlDemo.Width / 2 - DEMO_TEXTBOX_MARGIN / 2 - txtPlaintext.Width
        'txtPlaintext.Top = pnlDemo.Height / 2 - txtPlaintext.Height / 2
        txtPlaintext.Left = pnlDemo.Width / 2 - txtPlaintext.Width / 2
        txtPlaintext.placeBelow(lblPlaintextAdditionSubscript, 50) 'pnlDemo.Height / 2 - txtPlaintext.Height - DEMO_TEXTBOX_MARGIN / 2 + 60

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
        Me.Close()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        selectedMenuButton = btnAbout
        Me.Refresh()

        pnlAbout1.Show()
        btnNextPage.Show()
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
        btnNextPage.Hide()
        btnPreviousPage.Hide()
        pnlDecryption.Hide()
        pnlPrintout.Hide()

        currentTextbox.Focus()
    End Sub

    Private Sub btnCracking_Click(sender As Object, e As EventArgs) Handles btnCracking.Click
        selectedMenuButton = btnCracking
        Me.Refresh()

        pnlDecryption.Show()
        pnlAbout1.Hide()
        pnlAbout2.Hide()
        btnNextPage.Hide()
        btnPreviousPage.Hide()
        pnlDemo.Hide()
        pnlPrintout.Hide()
    End Sub

    Private Sub btnPrintout_Click(sender As Object, e As EventArgs) Handles btnPrintout.Click
        selectedMenuButton = btnPrintout
        Me.Refresh()

        pnlPrintout.Show()
        pnlAbout1.Hide()
        pnlAbout2.Hide()
        btnNextPage.Hide()
        btnPreviousPage.Hide()
        pnlDemo.Hide()
        pnlDecryption.Hide()
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        btnNextPage.Hide()
        pnlAbout2.Show()
        pnlAbout1.Hide()
        btnPreviousPage.Show()
    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        btnPreviousPage.Hide()
        pnlAbout1.Show()
        pnlAbout2.Hide()
        btnNextPage.Show()
    End Sub

    Private Sub pnlDemo_Paint(sender As Object, e As PaintEventArgs) Handles pnlDemo.Paint
        txtPlaintext.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
        txtCiphertext.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
        currentTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_FOCUS_BORDER_COLOR)
        If errorTextboxExists Then
            errorTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_ERROR_BORDER_COLOR)
        Else
            If errorTextbox IsNot Nothing Then
                errorTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
                currentTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_FOCUS_BORDER_COLOR)
            End If
        End If
    End Sub

    Private Sub txtPlaintext_GotFocus(sender As Object, e As EventArgs) Handles txtPlaintext.GotFocus
        currentTextbox = txtPlaintext
        pnlDemo.Refresh()
    End Sub

    Private Sub txtKey_GotFocus(sender As Object, e As EventArgs) Handles txtKey.GotFocus
        currentTextbox = txtKey
        pnlDemo.Refresh()
    End Sub

    Private Function generateKeyLabel(key As String) As String
        Return String.Join(" ", key.Select(Function(c) c.ToString()).ToArray())
    End Function

    Private Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged
        key = txtKey.Text
        lblKeyLarge.Text = generateKeyLabel(key)
        lblKeyLarge.Left = pnlDemo.Width / 2 - lblKeyLarge.Width / 2

        If txtPlaintext.Text <> "" Then
            If Regex.Replace(txtKey.Text, "[^a-zA-Z]", "") <> "" Then
                errorTextboxExists = False
                pnlDemo.Refresh() ' NOT GOOD AT ALL. PANEL IS REDRAWN EVERY TIME USER ENTERS STUFF INTO txtKey.
                txtCiphertext.Text = encodeVigenere(txtPlaintext.Text, key)
                updateAddition(txtPlaintext.Text, key)
            Else
                ' User must enter a key
                errorTextboxExists = True
                errorTextbox = txtKey
                pnlDemo.Refresh()
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            End If
        Else
            errorTextboxExists = False
            pnlDemo.Refresh() ' NOT GOOD AT ALL. PANEL IS REDRAWN EVERY TIME USER ENTERS STUFF INTO txtKey.
            updateAddition("A", "A")
        End If
    End Sub

    Private Sub txtPlaintext_TextChanged(sender As Object, e As EventArgs) Handles txtPlaintext.TextChanged
        txtCiphertext.Text = encodeVigenere(txtPlaintext.Text, key)
        If Regex.Replace(txtPlaintext.Text, "[^a-zA-Z]", "") <> "" Then
            updateAddition(txtPlaintext.Text, key)
        Else
            updateAddition("A", "A")
        End If
    End Sub

    Private Sub txtPlaintext_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPlaintext.KeyDown
        If Regex.Replace(txtKey.Text, "[^a-zA-Z]", "") = "" Then
            e.SuppressKeyPress = True
            'drawBorderInPanel()
            txtKey.Focus()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        End If

        If e.Control And e.KeyCode = Keys.A Then
            txtPlaintext.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub updateAddition(plaintext As String, key As String)
        Dim lastLetter = plaintext.Last()
        Dim currentKeyIndex = (Regex.Replace(plaintext, "[^a-zA-Z]", "").Length - 1) Mod key.Length
        Dim currentKeyLetter = key(currentKeyIndex)

        If Char.IsLetter(lastLetter) Then
            lblPlaintextAddition.Text = lastLetter
            lblPlaintextAdditionSubscript.Text = ALPHABET.IndexOf(lastLetter)
            lblKeyAddition.Text = currentKeyLetter
            lblKeyAdditionSubscript.Text = ALPHABET.IndexOf(currentKeyLetter)
            lblResultAddition.Text = encodeVigenere(lastLetter, currentKeyLetter)
            lblResultAdditionSubscript.Text = ALPHABET.IndexOf(encodeVigenere(lastLetter, currentKeyLetter))

            If Regex.Replace(txtKey.Text, "[^a-zA-Z]", "") <> "" Then
                If Regex.Replace(txtPlaintext.Text, "[^a-zA-Z]", "") <> "" Then
                    lblKeyLarge.Text = generateKeyLabel(changeCharacter(key, LCase(currentKeyLetter), currentKeyIndex))
                End If
            End If
        End If
        lblKeyLarge.Left = pnlDemo.Width / 2 - lblKeyLarge.Width / 2
    End Sub


End Class