Imports System.Runtime.CompilerServices, System.Text.RegularExpressions ' Used to filter out non-alpha characters in strings.

Public Class formStraddlingCheckerboard
    ' SHOULD REALLY BE A CONSTANT, BUT VB SAYS THIS ISN'T A "CONSTANT VALUE", SO IT'S A VARIABLE. 
    Private TEXTBOX_FOCUS_BORDER_COLOR As Color = Color.CornflowerBlue
    Private TEXTBOX_UNFOCUS_BORDER_COLOR As Color = Color.WhiteSmoke
    Private TEXTBOX_ERROR_BORDER_COLOR As Color = Color.Red

    Const MIN_N = 0
    Const MAX_N = 9

    Private selectedMenuButton As Control
    Private key As String = ""
    Private n1 As Integer = 0
    Private n2 As Integer = 0
    Private deletingn1 As Boolean = False
    Private deletingn2 As Boolean = False

    Private n1IsValid As Boolean = True
    Private n2IsValid As Boolean = True

    Private currentTextbox As TextBox
    Private errorTextboxExists As Boolean = False
    Private errorTextbox As TextBox

    Private Sub formStraddlingCheckerboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Don't get rid of this. It will likely crash. I don't know why.
        key = ""
        n1 = 0
        n2 = 0
        currentTextbox = txtKey
        positionElements()
    End Sub

    Private Sub positionElements()
        Const MENU_PADDING = 10
        Const MENU_CONTENT_MARGIN = 5
        Const DEMO_TEXTBOX_MARGIN = 80
        Const DEMO_BUTTON_MARGIN = 5
        Const TEXTBOX_WIDTH = 0.8
        Const TEXTBOX_HEIGHT = 0.2
        Const KEY_TOP = 40

        ' Putting this here so it runs early on so blinking is mitigated.
        pnlAbout1.Show()
        pnlAbout2.Hide()
        btnNextPageAbout.Show()
        btnPreviousPageAbout.Hide()
        pnlDemo.Hide()
        pnlPrintout.Hide()
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

        picStraddling1.Height = 100
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

        ' lblKey
        lblKey.Left = pnlDemo.Width / 2 - (lblKey.Width + txtKey.Width + 15) / 2
        lblKey.Top = KEY_TOP - lblKey.Height / 2

        ' txtKey
        txtKey.placeRight(lblKey, 15)
        txtKey.Top = KEY_TOP - txtKey.Height / 2

        ' lblExcludedDigits
        lblExcludedDigits.Left = lblKey.Left
        lblExcludedDigits.placeBelow(lblKey, 50)

        ' btnn1Fewer
        btnn1Fewer.Height = txtn1.Height
        btnn1Fewer.Width = btnn1Fewer.Height
        btnn1Fewer.Left = lblExcludedDigits.Left + lblExcludedDigits.Width + 20
        btnn1Fewer.placeBelow(lblKey, 50)

        ' txtn1
        txtn1.Text = n1
        txtn1.placeRight(btnn1Fewer, DEMO_BUTTON_MARGIN)
        txtn1.Top = btnn1Fewer.Top

        ' btnn1More
        btnn1More.Height = btnn1Fewer.Height
        btnn1More.Width = btnn1More.Height
        btnn1More.placeRight(txtn1, DEMO_BUTTON_MARGIN)
        btnn1More.Top = btnn1Fewer.Top

        ' btnn2fewer
        btnn2fewer.Height = btnn1Fewer.Height
        btnn2fewer.Width = btnn1Fewer.Height
        btnn2fewer.placeRight(btnn1More, 30)
        btnn2fewer.Top = btnn1Fewer.Top

        ' txtn2
        txtn2.Text = n2
        txtn2.placeRight(btnn2fewer, DEMO_BUTTON_MARGIN)
        txtn2.Top = txtn1.Top

        ' btnn2More
        btnn2More.Height = btnn1Fewer.Height
        btnn2More.Width = btnn2More.Height
        btnn2More.placeRight(txtn2, DEMO_BUTTON_MARGIN)
        btnn2More.Top = btnn2fewer.Top

        ' txtPlaintext
        txtPlaintext.Width = pnlDemo.Width * TEXTBOX_WIDTH
        txtPlaintext.Height = pnlDemo.Height * TEXTBOX_HEIGHT
        txtPlaintext.Left = pnlDemo.Width / 2 - txtPlaintext.Width / 2
        txtPlaintext.placeBelow(txtn2, 50)

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
        Me.Close()
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

        currentTextbox.Focus()
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

    ' Printing the print-outs.
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        printPictureBox(picStraddlingPrintout, picHidden)
        e.Graphics.DrawImage(picHidden.Image, 0, 0)
    End Sub

    ' Handles the behaviour of the numeric-updown-type buttons. This is because Winform's 
    ' actual NumericUpDowns are so ugly and you can't customise them, so you're better off making your own.
    Private Sub btnn1Fewer_Click(sender As Object, e As EventArgs) Handles btnn1Fewer.Click
        n1 -= 1

        If n1 = MIN_N Then
            btnn1Fewer.Enabled = False
        Else
            btnn1Fewer.Enabled = True
            btnn1More.Enabled = True
        End If

        txtn1.Text = n1
    End Sub

    Private Sub btnn1More_Click(sender As Object, e As EventArgs) Handles btnn1More.Click
        n1 += 1

        If n1 = MAX_N Then
            btnn1More.Enabled = False
        Else
            btnn1More.Enabled = True
            btnn1Fewer.Enabled = True
        End If

        txtn1.Text = n1
    End Sub

    Private Sub btnn2fewer_Click(sender As Object, e As EventArgs) Handles btnn2fewer.Click
        n2 -= 1

        If n2 = MIN_N Then
            btnn2fewer.Enabled = False
        Else
            btnn2fewer.Enabled = True
            btnn2More.Enabled = True
        End If

        txtn2.Text = n2
    End Sub

    Private Sub btnn2More_Click(sender As Object, e As EventArgs) Handles btnn2More.Click
        n2 += 1

        If n2 = MAX_N Then
            btnn2More.Enabled = False
        Else
            btnn2More.Enabled = True
            btnn2fewer.Enabled = True
        End If

        txtn2.Text = n2
    End Sub

    Private Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged
        key = Regex.Replace(txtKey.Text, "[^a-zA-Z]", "")

        txtCiphertext.Text = encodeStraddling(txtPlaintext.Text, key, n1, n2)
    End Sub

    Private Sub txtn1_TextChanged(sender As Object, e As EventArgs) Handles txtn1.TextChanged
        updaten1Buttons()
        pnlDemo.Refresh()
    End Sub

    Private Sub txtn2_TextChanged(sender As Object, e As EventArgs) Handles txtn2.TextChanged
        updaten2Buttons()
        pnlDemo.Refresh()
    End Sub

    ' Update the value of the n1 textbox. Re-purposed code from my Series and Sequences application:
    ' https://www.github.com/sidney-pham/series-and-sequences
    Private Sub updaten1Buttons()
        Dim firstTermAsInt As Integer
        Dim inputIsInteger As Boolean
        Dim inputIsWithinRange As Boolean = False

        ' Hacky way to check if a textbox's value is an int
        inputIsInteger = Integer.TryParse(txtn1.Text, firstTermAsInt)

        If inputIsInteger Then
            If firstTermAsInt >= MIN_N And firstTermAsInt <= MAX_N Then
                inputIsWithinRange = True
            End If
        End If

        n1IsValid = inputIsInteger And inputIsWithinRange

        If n1IsValid Then
            n1 = firstTermAsInt

            txtn1.Text = n1
            txtn1.SelectionStart = txtn1.Text.Length + 1
        Else
            ' Play asterisk sound unless user is backspacing
            If Not deletingn1 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            End If
        End If

        ' Update the buttons
        btnn1Fewer.Enabled = n1 <> MIN_N
        btnn1More.Enabled = n1 <> MAX_N
        If txtPlaintext.Text <> "" Then
            txtCiphertext.Text = encodeStraddling(txtPlaintext.Text, key, n1, n2)
        End If
    End Sub

    Private Sub updaten2Buttons()
        Dim firstTermAsInt As Integer
        Dim inputIsInteger As Boolean
        Dim inputIsWithinRange As Boolean = False

        ' Hacky way to check if textbox's value is an int
        inputIsInteger = Integer.TryParse(txtn2.Text, firstTermAsInt)

        If inputIsInteger Then
            If firstTermAsInt >= MIN_N And firstTermAsInt <= MAX_N Then
                inputIsWithinRange = True
            End If
        End If

        n2IsValid = inputIsInteger And inputIsWithinRange

        If n2IsValid Then
            n2 = firstTermAsInt

            txtn2.Text = n2
            txtn2.SelectionStart = txtn2.Text.Length + 1
        Else
            ' Play asterisk sound unless user is backspacing
            If Not deletingn2 Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
            End If
        End If

        ' Update the buttons
        btnn2fewer.Enabled = n2 <> MIN_N
        btnn2More.Enabled = n2 <> MAX_N
        If txtPlaintext.Text <> "" Then
            txtCiphertext.Text = encodeStraddling(txtPlaintext.Text, key, n1, n2)
        End If
    End Sub

    Private Sub txtn1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtn1.KeyPress
        deletingn1 = e.KeyChar = ChrW(Keys.Back)
    End Sub

    Private Sub txtn2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtn2.KeyPress
        deletingn2 = e.KeyChar = ChrW(Keys.Back)
    End Sub

    ' Draw borders around Textboxes, including error borders.
    Private Sub pnlDemo_Paint(sender As Object, e As PaintEventArgs) Handles pnlDemo.Paint
        txtPlaintext.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
        txtCiphertext.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
        txtKey.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
        currentTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_FOCUS_BORDER_COLOR)
        If Not n1IsValid Then
            txtn1.drawBorderInPanel(e.Graphics, TEXTBOX_ERROR_BORDER_COLOR)
        Else
            txtn1.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
            currentTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_FOCUS_BORDER_COLOR)
        End If

        If Not n2IsValid Then
            txtn2.drawBorderInPanel(e.Graphics, TEXTBOX_ERROR_BORDER_COLOR)
        Else
            txtn2.drawBorderInPanel(e.Graphics, TEXTBOX_UNFOCUS_BORDER_COLOR)
            currentTextbox.drawBorderInPanel(e.Graphics, TEXTBOX_FOCUS_BORDER_COLOR)
        End If
    End Sub

    Private Sub txtPlaintext_TextChanged(sender As Object, e As EventArgs) Handles txtPlaintext.TextChanged
        If txtPlaintext.Text <> "" Then
            txtCiphertext.Text = encodeStraddling(txtPlaintext.Text, key, n1, n2)
        End If
    End Sub

    ' Multiline textboxes in VB don't allow Ctrl-A to work (no one knows why, really...), so you have to 
    ' implement your own Ctrl-A behaviour. This is killing clarity, so just ignore that it exists.
    Private Sub txtPlaintext_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPlaintext.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            txtPlaintext.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtKey_GotFocus(sender As Object, e As EventArgs) Handles txtKey.GotFocus
        currentTextbox = txtKey
        pnlDemo.Refresh()
    End Sub

    Private Sub txtPlaintext_GotFocus(sender As Object, e As EventArgs) Handles txtPlaintext.GotFocus
        currentTextbox = txtPlaintext
        pnlDemo.Refresh()
    End Sub

    Private Sub txtn1_GotFocus(sender As Object, e As EventArgs) Handles txtn1.GotFocus
        currentTextbox = txtn1
        pnlDemo.Refresh()
    End Sub

    Private Sub txtn2_GotFocus(sender As Object, e As EventArgs) Handles txtn2.GotFocus
        currentTextbox = txtn2
        pnlDemo.Refresh()
    End Sub
End Class