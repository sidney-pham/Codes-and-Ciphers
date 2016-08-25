Imports System.Drawing.Graphics

Public Class formMain
    ' Form-level data for the hover effect over the buttons.
    Const HOVER_EFFECT_INTERVAL = 50
    Const HOVER_LETTER_INCREMENT = 10

    Private hover As Object                         ' Object to perform effect on.
    Private beforeHoverText As String               ' What to reset the text to after hover effect ends
    Private currentHoverCharacter As Integer        ' Current letter position in the string
    Private currentHoverCharacterCount As Integer   ' Current letter being iterated through in the position.

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        positionElements()
        testCaesar()
        testVigenere()
        testStraddlingCheckerboard()

        tmrHover.Interval = HOVER_EFFECT_INTERVAL
    End Sub

    Private Sub positionElements()
        Const BUTTON_MARGIN = 30
        Const LABEL_MARGIN = 0

        ' lblCodesAndCiphers
        lblCodesAndCiphers.Left = (Me.Width - lblCodesAndCiphers.Width - btnCaesar.Width) / 3
        lblCodesAndCiphers.verticallyCentre()

        ' lblHowTheyWork
        lblHowTheyWork.Left = (Me.Width - lblCodesAndCiphers.Width - btnCaesar.Width) / 3
        lblHowTheyWork.placeAbove(lblCodesAndCiphers, LABEL_MARGIN)

        ' btnVigenere
        btnVigenere.placeRight(lblCodesAndCiphers, (Me.Width - lblCodesAndCiphers.Width - btnCaesar.Width) / 3)
        btnVigenere.verticallyCentre()

        ' btnCaesar
        btnCaesar.placeRight(lblCodesAndCiphers, (Me.Width - lblCodesAndCiphers.Width - btnCaesar.Width) / 3)
        btnCaesar.placeAbove(btnVigenere, BUTTON_MARGIN)

        ' btnStraddlingCheckerboard
        btnStraddlingCheckerboard.placeRight(lblCodesAndCiphers, (Me.Width - lblCodesAndCiphers.Width - btnCaesar.Width) / 3)
        btnStraddlingCheckerboard.placeBelow(btnVigenere, BUTTON_MARGIN)

    End Sub

    Private Sub btnCaesar_MouseEnter(sender As Object, e As EventArgs) Handles btnCaesar.MouseEnter, btnVigenere.MouseEnter, btnStraddlingCheckerboard.MouseEnter
        sender.BackColor = Color.DarkOliveGreen

        ' Set up all the form-level variables
        hover = sender
        beforeHoverText = sender.Text
        currentHoverCharacter = 0
        currentHoverCharacterCount = 0

        tmrHover.Start()
    End Sub

    Private Sub btnCaesar_MouseLeave(sender As Object, e As EventArgs) Handles btnCaesar.MouseLeave, btnVigenere.MouseLeave, btnStraddlingCheckerboard.MouseLeave
        sender.BackColor = Color.LightSlateGray
        tmrHover.Stop()
        sender.Text = beforeHoverText
    End Sub

    ' Every HOVER_EFFECT_INTERVAL milliseconds, perform the hover effect.
    Private Sub tmrHover_Tick(sender As Object, e As EventArgs) Handles tmrHover.Tick
        ' Skip over non alphabetical characters
        While Not Char.IsLetter(hover.Text(currentHoverCharacter))
            currentHoverCharacter += 1
        End While

        ' Update the appropriate letter by shifting it by HOVER_LETTER_INCREMENT letters
        Dim newHoverCharacter = shiftLetter(hover.Text(currentHoverCharacter), HOVER_LETTER_INCREMENT)
        hover.Text = changeCharacter(hover.Text, newHoverCharacter, currentHoverCharacter)
        currentHoverCharacterCount += HOVER_LETTER_INCREMENT

        ' After updating the letter, if it has already been through 26 characters, move on to the next letter.
        If currentHoverCharacterCount >= 25 Then
            currentHoverCharacterCount = 0
            ' Update the previous letter as well, because it is likely that its current value isn't its original value.
            hover.Text = changeCharacter(hover.Text, beforeHoverText(currentHoverCharacter), currentHoverCharacter)
            currentHoverCharacter += 1
        End If

        ' When the entire string is looped through, restart from the beginning.
        If currentHoverCharacter >= beforeHoverText.Length Then
            currentHoverCharacter = 0
        End If
    End Sub

    Private Sub btnCaesar_Click(sender As Object, e As EventArgs) Handles btnCaesar.Click
        formCaesar.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnVigenere_Click(sender As Object, e As EventArgs) Handles btnVigenere.Click
        formVigenere.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub

    Private Sub btnStraddlingCheckerboard_Click(sender As Object, e As EventArgs) Handles btnStraddlingCheckerboard.Click
        formStraddlingCheckerboard.Show()
        Threading.Thread.Sleep(150)
        Me.Hide()
    End Sub
End Class
