Imports System.Runtime.CompilerServices, System.Text.RegularExpressions


Public Module modHelpers
    Public Const ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public Const LENGTH_OF_ALPHABET = 26

    'hacky method to replace a char in a string
    <Extension()>
    Function replacedAtIndex(someString As String, index As Integer, newLetter As Char) As String
        Return someString.Remove(index, 1).Insert(index, newLetter)
    End Function

    ' ENCODING FUNCTIONS:
    ' (Note: converts text to uppercase as well)
    Function encodeCaesar(message As String, rot As Integer) As String
        message = message.ToUpper()

        For i = 0 To message.Length - 1
            Dim letter As Char = message(i)
            If Char.IsLetter(letter) Then
                message = message.replacedAtIndex(i, shiftLetter(letter, rot)) 'replace each letter with it's shifted version
            End If
        Next

        Return message
    End Function

    ' Assumes key is valid.
    Function encodeVigenere(message As String, key As String) As String
        message = message.ToUpper()
        key = Regex.Replace(key.ToUpper(), "[^a-zA-Z]", "")
        Dim currentKeyIndex = 0

        For i = 0 To message.Length - 1
            Dim letter As Char = message(i)

            If Char.IsLetter(letter) Then
                Dim currentKeyChar = key(currentKeyIndex Mod key.Length)
                Dim rot As Integer = ALPHABET.IndexOf(currentKeyChar)

                message = message.replacedAtIndex(i, shiftLetter(letter, rot))
                currentKeyIndex += 1
            End If
        Next

        Return message
    End Function

    Public Function ramsEncodeStraddling(inp As String, keyStr As String, n1 As Integer, n2 As Integer) As String
        Debug.Assert(0 <= n1 < 10 And 0 <= n2 < 10)

        keyStr = keyStr.ToUpper
        inp = inp.ToUpper

        Dim nMin = Math.Min(n1, n2)
        Dim nMax = Math.Max(n1, n2)
        If nMin = nMax Then
            If nMin = 9 Then
                nMin = 0
            Else
                nMax = nMax + 1
            End If
        End If

        n1 = nMin
        n2 = nMax

        Dim key As New List(Of Char)
        For i = 0 To keyStr.Length - 1
            If ALPHABET.Contains(keyStr(i)) And Not key.Contains(keyStr(i)) Then
                key.Add(keyStr(i))
            End If
        Next i

        For i = 0 To ALPHABET.Length - 1
            If Not key.Contains(ALPHABET(i)) Then
                key.Add(ALPHABET(i))
            End If
        Next i

        Dim table As New Hashtable
        For i = 0 To key.Count - 1
            If i < n1 Then
                table(key(i)) = i
            ElseIf i < n2 - 1 Then
                table(key(i)) = i + 1
            ElseIf i < 8 Then
                table(key(i)) = i + 2
            ElseIf i < 18 Then
                table(key(i)) = n1 * 10 + i - 8
            ElseIf i < 28 Then
                table(key(i)) = n2 * 10 + i - 18
            Else
                Throw New Exception("Unreachable!")
            End If
        Next

        Dim out As New List(Of Integer)
        For i = 0 To inp.Length - 1
            If table.ContainsKey(inp(i)) Then
                out.Add(table(inp(i)))
            End If
        Next

        Return String.Join("", out.ToArray)
    End Function

    Function encodeStraddling(message As String, keyInput As String, n1 As Integer, n2 As Integer) As String
        message = message.ToUpper()
        keyInput = Regex.Replace(keyInput.ToUpper(), "[^a-zA-Z]", "")

        If n2 < n1 Then
            Dim swap As Integer
            swap = n1
            n1 = n2
            n2 = swap
        End If

        Dim key As New List(Of Char)
        For i = 0 To keyInput.Length - 1
            Dim letter As Char = keyInput(i)
            If Not key.Contains(letter) Then
                key.Add(letter)
            End If
        Next

        For i = 0 To LENGTH_OF_ALPHABET - 1
            Dim letter As Char = ALPHABET(i)
            If Not key.Contains(letter) Then
                key.Add(letter)
            End If
        Next

        'Debug.Print(String.Join(",", key))

        Dim table As New Hashtable
        For i = 0 To key.Count - 1
            If i < n1 Then
                table(key(i)) = i
            ElseIf i < n2 - 1 Then
                table(key(i)) = i + 1
            ElseIf i < 8 Then
                table(key(i)) = i + 2
            ElseIf i < 18 Then
                table(key(i)) = n1 * 10 + i - 8
            ElseIf i < 28 Then
                table(key(i)) = n2 * 10 + i - 18
            Else
                Throw New Exception("Unreachable!")
            End If
        Next

        Dim output As String = ""

        For i = 0 To message.Length - 1
            Dim letter As Char = message(i)
            If table.ContainsKey(letter) Then
                output &= table(letter)
            End If
        Next

        Return output
    End Function

    ' HELPER FUNCTIONS:
    Function shiftLetter(letter As Char, rot As Integer) As Char
        'rot = rot Mod LENGTH_OF_ALPHABET
        ' WHY DO ALL LANGUAGES HAVE THE WEIRDEST BEHAVIOUR FOR NEGATIVE NUMBERS WITH MOD
        ' this formula is taken from http://stackoverflow.com/questions/1082917/mod-of-negative-number-is-melting-my-brain because i'm too dumb to think.
        rot = (rot Mod LENGTH_OF_ALPHABET + LENGTH_OF_ALPHABET) Mod LENGTH_OF_ALPHABET

        Dim newLetter As Char = ALPHABET((ALPHABET.IndexOf(letter) + rot) Mod LENGTH_OF_ALPHABET)

        Return newLetter
    End Function

    ' UNIT TESTS:
    Sub testCaesar()
        Debug.Print("Testing Caesar Encoding!")
        Debug.Assert(encodeCaesar("abc", 0) = "ABC")
        Debug.Assert(encodeCaesar("abc", 1) = "BCD")
        Debug.Assert(encodeCaesar("abc", 2) = "CDE")
        Debug.Assert(encodeCaesar("abc", 25) = "ZAB")
        Debug.Assert(encodeCaesar("abc", LENGTH_OF_ALPHABET) = "ABC")
        Debug.Assert(encodeCaesar("abc", 27) = "BCD")
        Debug.Print("All tests Passed!!!!!")
    End Sub

    Sub testVigenere()
        Debug.Print("Testing Vigenere Encoding!")
        Debug.Assert(encodeVigenere("aaaaaaa", "abc") = "ABCABCA")
        Debug.Assert(encodeVigenere("aaaaaaa", "bcd") = "BCDBCDB")
        Debug.Assert(encodeVigenere("asdfghjkl", "xyz") = "XQCCEGGIK")
        Debug.Assert(encodeVigenere("HI THERE IS THIS KIND OF COOL???", "xyz") = "EG SECQB GR QFHP IHKB NC ANLJ???")
        Debug.Assert(encodeVigenere("!@#$%^&*(", "abc") = "!@#$%^&*(")
        Debug.Print("All tests Passed!!!!!")
    End Sub

    Sub testStraddlingCheckerboard()
        Debug.Print("Testing Straddling Checkerboard Encoding!")
        ' Because ram's solution is definitely correct
        Debug.Print(encodeStraddling("hi", "key", 3, 5) = ramsEncodeStraddling("hi", "key", 3, 5))
        Debug.Print(encodeStraddling("hi", "key", 3, 4) = ramsEncodeStraddling("hi", "key", 3, 4))
        Debug.Print(encodeStraddling("hi", "key", 3, 3) = ramsEncodeStraddling("hi", "key", 3, 3))
        Debug.Print(encodeStraddling("hi", "key", 3, 2) = ramsEncodeStraddling("hi", "key", 3, 2))
        Debug.Print(encodeStraddling("hi", "key", 3, 1) = ramsEncodeStraddling("hi", "key", 3, 1))
        Debug.Print(encodeStraddling("qwertyuiop", "testing", 3, 5) = ramsEncodeStraddling("qwertyuiop", "testing", 3, 5))
        Debug.Print("All tests Passed!!!!!")
    End Sub

    ' POSITIONING HELPERS:
    <Extension()>
    Sub horizontallyCentre(control As Object)
        control.Left = formMain.Width / 2 - control.Width / 2
    End Sub

    <Extension()>
    Sub verticallyCentre(control As Object)
        control.Top = formMain.Height / 2 - control.Height / 2
    End Sub

    <Extension()>
    Sub placeAbove(control As Object, relativeControl As Object, pixels As Integer)
        control.Top = relativeControl.Top - control.Height - pixels
    End Sub

    <Extension()>
    Sub placeBelow(control As Object, relativeControl As Object, pixels As Integer)
        control.Top = relativeControl.Top + relativeControl.Height + pixels
    End Sub

    <Extension()>
    Sub placeRight(control As Object, relativeControl As Object, pixels As Integer)
        control.Left = relativeControl.Left + relativeControl.Width + pixels
    End Sub

    <Extension()>
    Sub placeLeft(control As Object, relativeControl As Object, pixels As Integer)
        control.Left = relativeControl.Left - relativeControl.Width - pixels
    End Sub

    ' BORDER DRAWING

    <Extension()>
    Sub drawBorder(control As Control, color As Color)
        Dim g As Graphics = control.FindForm().CreateGraphics()
        Dim pen As New Pen(color, 4)

        'make sure control argument is a textbox
        'If TypeOf (control) Is TextBox Then
        g.DrawRectangle(pen, New Rectangle(control.Location, control.Size))
        'End If

        pen.Dispose()
        g.Dispose()
    End Sub

    ' This is used inside the onPaint event. Not really reusable idk why.
    <Extension()>
    Sub drawBottomBorder(control As Control, g As Graphics, color As Color)
        Dim pen As New Pen(color, 4)
        g.DrawLine(pen, New Point(control.Left, control.Top + control.Height), New Point(control.Left + control.Width, control.Top + control.Height))

        pen.Dispose()
    End Sub

    ' Better border drawing
    <Extension()>
    Sub drawBorderInPanel(control As Control, g As Graphics, color As Color)
        Dim pen As New Pen(color, 4)

        g.DrawRectangle(pen, New Rectangle(control.Location, control.Size))

        pen.Dispose()
    End Sub

    ' CHANGING A CHARACTER IN A STRNIG
    Function changeCharacter(s As String, replaceWith As Char, index As Integer) As String
        Dim sb As New System.Text.StringBuilder(s)

        'replace character
        sb(index) = replaceWith
        Return sb.ToString()
    End Function


    ' DISCLAIMER: IF YOU DO NOT WANT ACTUAL STDs, DON'T READ THIS. I barely understand what it does.
    ' Printing a pictureBox (uses 2, one hidden, one not)
    ' screw intrinsic documentation, pic1 is the visible, pic2 is the one to be printed.
    ' MOSTLY FROM: http://www.codeproject.com/Tips/763183/Printing-Images-Quickly-and-Efficiently-to-an-A-Pa
    Sub printPictureBox(pic1 As PictureBox, pic2 As PictureBox)
        Try
            pic2.Image = pic1.Image
            If pic2.Image.Width > pic2.Image.Height Then
                pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            End If

            Dim Height As Double = CDbl(1100)
            Dim width As Double

            Dim aspectRatio As Double
            aspectRatio = pic2.Image.Width / pic2.Image.Height
            width = CDbl(1100 * aspectRatio)
            If width > 891 Then
                pic2.Image = pic1.Image
                pic1.Visible = False
                If pic2.Image.Width > pic2.Image.Height Then
                    pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                End If

                Height = CDbl(900)

                aspectRatio = pic2.Image.Width / pic2.Image.Height
                width = CDbl(900 * aspectRatio)
                If width > 891 Then
                    pic2.Image = pic1.Image
                    pic1.Visible = False
                    If pic2.Image.Width > pic2.Image.Height Then
                        pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    End If

                    Height = CDbl(700)
                    width = CDbl(700 * aspectRatio)
                Else
                    Dim wi As Integer
                    wi = Convert.ToInt32(width)
                    Dim hi As Integer
                    hi = Convert.ToInt32(Height)
                    Dim New_Bitmap As New Bitmap(pic2.Image, wi, hi)
                    pic2.Image = New_Bitmap
                End If
            Else
                Dim wi As Integer
                wi = Convert.ToInt32(width)
                Dim hi As Integer
                hi = Convert.ToInt32(Height)
                Dim New_Bitmap As New Bitmap(pic2.Image, wi, hi)
                pic2.Image = New_Bitmap
            End If
        Catch ex As Exception
            MsgBox("bug.")
        End Try
    End Sub
End Module
