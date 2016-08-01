<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVigenere
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formVigenere))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblVigenere = New System.Windows.Forms.Label()
        Me.pnlDemo = New System.Windows.Forms.Panel()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.lblAlphabetShift = New System.Windows.Forms.Label()
        Me.lblAlphabet = New System.Windows.Forms.Label()
        Me.lblCiphertext = New System.Windows.Forms.Label()
        Me.lblPlaintext = New System.Windows.Forms.Label()
        Me.txtCiphertext = New System.Windows.Forms.TextBox()
        Me.txtPlaintext = New System.Windows.Forms.TextBox()
        Me.btnPrintout = New System.Windows.Forms.Button()
        Me.btnCracking = New System.Windows.Forms.Button()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pnlDecryption = New System.Windows.Forms.Panel()
        Me.btnDecryptionExample = New System.Windows.Forms.Button()
        Me.lblTryExplanation = New System.Windows.Forms.Label()
        Me.lblTryItOut = New System.Windows.Forms.Label()
        Me.lblCaesarCracking = New System.Windows.Forms.Label()
        Me.pnlAbout = New System.Windows.Forms.Panel()
        Me.picCaesarDiagram = New System.Windows.Forms.PictureBox()
        Me.lblCaesarInfo1 = New System.Windows.Forms.Label()
        Me.pnlPrintout = New System.Windows.Forms.Panel()
        Me.lblPrintoutExplanation = New System.Windows.Forms.Label()
        Me.picHidden = New System.Windows.Forms.PictureBox()
        Me.picCaesarPrintout = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.pnlDemo.SuspendLayout()
        Me.pnlDecryption.SuspendLayout()
        Me.pnlAbout.SuspendLayout()
        CType(Me.picCaesarDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrintout.SuspendLayout()
        CType(Me.picHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCaesarPrintout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SlateGray
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(12, 555)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 10
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "< MAIN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblVigenere
        '
        Me.lblVigenere.AutoSize = True
        Me.lblVigenere.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenere.ForeColor = System.Drawing.Color.Silver
        Me.lblVigenere.Location = New System.Drawing.Point(224, -2)
        Me.lblVigenere.Name = "lblVigenere"
        Me.lblVigenere.Size = New System.Drawing.Size(489, 63)
        Me.lblVigenere.TabIndex = 9
        Me.lblVigenere.Text = " VIGENÈRE CIPHER"
        '
        'pnlDemo
        '
        Me.pnlDemo.Controls.Add(Me.lblShift)
        Me.pnlDemo.Controls.Add(Me.btnRight)
        Me.pnlDemo.Controls.Add(Me.btnLeft)
        Me.pnlDemo.Controls.Add(Me.lblAlphabetShift)
        Me.pnlDemo.Controls.Add(Me.lblAlphabet)
        Me.pnlDemo.Controls.Add(Me.lblCiphertext)
        Me.pnlDemo.Controls.Add(Me.lblPlaintext)
        Me.pnlDemo.Controls.Add(Me.txtCiphertext)
        Me.pnlDemo.Controls.Add(Me.txtPlaintext)
        Me.pnlDemo.Location = New System.Drawing.Point(233, 142)
        Me.pnlDemo.Name = "pnlDemo"
        Me.pnlDemo.Size = New System.Drawing.Size(798, 481)
        Me.pnlDemo.TabIndex = 16
        '
        'lblShift
        '
        Me.lblShift.AutoSize = True
        Me.lblShift.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblShift.Location = New System.Drawing.Point(285, 53)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(116, 36)
        Me.lblShift.TabIndex = 24
        Me.lblShift.Text = "SHIFT: 0"
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRight.FlatAppearance.BorderSize = 0
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnRight.Location = New System.Drawing.Point(570, 3)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(50, 50)
        Me.btnRight.TabIndex = 23
        Me.btnRight.TabStop = False
        Me.btnRight.Text = ">"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLeft.FlatAppearance.BorderSize = 0
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnLeft.Location = New System.Drawing.Point(78, 3)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(50, 50)
        Me.btnLeft.TabIndex = 22
        Me.btnLeft.TabStop = False
        Me.btnLeft.Text = "<"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'lblAlphabetShift
        '
        Me.lblAlphabetShift.AutoSize = True
        Me.lblAlphabetShift.Font = New System.Drawing.Font("Lucida Sans Typewriter", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlphabetShift.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAlphabetShift.Location = New System.Drawing.Point(134, 22)
        Me.lblAlphabetShift.Name = "lblAlphabetShift"
        Me.lblAlphabetShift.Size = New System.Drawing.Size(430, 31)
        Me.lblAlphabetShift.TabIndex = 21
        Me.lblAlphabetShift.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        '
        'lblAlphabet
        '
        Me.lblAlphabet.AutoSize = True
        Me.lblAlphabet.Font = New System.Drawing.Font("Lucida Sans Typewriter", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlphabet.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAlphabet.Location = New System.Drawing.Point(134, 0)
        Me.lblAlphabet.Name = "lblAlphabet"
        Me.lblAlphabet.Size = New System.Drawing.Size(430, 31)
        Me.lblAlphabet.TabIndex = 20
        Me.lblAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        '
        'lblCiphertext
        '
        Me.lblCiphertext.AutoSize = True
        Me.lblCiphertext.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiphertext.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCiphertext.Location = New System.Drawing.Point(482, 67)
        Me.lblCiphertext.Name = "lblCiphertext"
        Me.lblCiphertext.Size = New System.Drawing.Size(126, 25)
        Me.lblCiphertext.TabIndex = 19
        Me.lblCiphertext.Text = "CIPHERTEXT"
        '
        'lblPlaintext
        '
        Me.lblPlaintext.AutoSize = True
        Me.lblPlaintext.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaintext.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPlaintext.Location = New System.Drawing.Point(61, 67)
        Me.lblPlaintext.Name = "lblPlaintext"
        Me.lblPlaintext.Size = New System.Drawing.Size(114, 25)
        Me.lblPlaintext.TabIndex = 18
        Me.lblPlaintext.Text = "PLAINTEXT"
        '
        'txtCiphertext
        '
        Me.txtCiphertext.BackColor = System.Drawing.Color.SlateGray
        Me.txtCiphertext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCiphertext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiphertext.Font = New System.Drawing.Font("Lucida Sans Typewriter", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiphertext.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtCiphertext.Location = New System.Drawing.Point(477, 108)
        Me.txtCiphertext.MaxLength = 150
        Me.txtCiphertext.Multiline = True
        Me.txtCiphertext.Name = "txtCiphertext"
        Me.txtCiphertext.Size = New System.Drawing.Size(389, 275)
        Me.txtCiphertext.TabIndex = 1
        '
        'txtPlaintext
        '
        Me.txtPlaintext.BackColor = System.Drawing.Color.LightGray
        Me.txtPlaintext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlaintext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaintext.Font = New System.Drawing.Font("Lucida Sans Typewriter", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaintext.ForeColor = System.Drawing.Color.Black
        Me.txtPlaintext.Location = New System.Drawing.Point(65, 108)
        Me.txtPlaintext.MaxLength = 150
        Me.txtPlaintext.Multiline = True
        Me.txtPlaintext.Name = "txtPlaintext"
        Me.txtPlaintext.Size = New System.Drawing.Size(389, 275)
        Me.txtPlaintext.TabIndex = 0
        '
        'btnPrintout
        '
        Me.btnPrintout.BackColor = System.Drawing.Color.SlateGray
        Me.btnPrintout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintout.FlatAppearance.BorderSize = 0
        Me.btnPrintout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintout.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintout.ForeColor = System.Drawing.Color.Black
        Me.btnPrintout.Location = New System.Drawing.Point(648, 22)
        Me.btnPrintout.Name = "btnPrintout"
        Me.btnPrintout.Size = New System.Drawing.Size(160, 68)
        Me.btnPrintout.TabIndex = 20
        Me.btnPrintout.TabStop = False
        Me.btnPrintout.Text = "PRINT-OUT"
        Me.btnPrintout.UseVisualStyleBackColor = False
        '
        'btnCracking
        '
        Me.btnCracking.BackColor = System.Drawing.Color.SlateGray
        Me.btnCracking.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCracking.FlatAppearance.BorderSize = 0
        Me.btnCracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCracking.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCracking.ForeColor = System.Drawing.Color.Black
        Me.btnCracking.Location = New System.Drawing.Point(444, 22)
        Me.btnCracking.Name = "btnCracking"
        Me.btnCracking.Size = New System.Drawing.Size(169, 68)
        Me.btnCracking.TabIndex = 19
        Me.btnCracking.TabStop = False
        Me.btnCracking.Text = "DECRYPTION"
        Me.btnCracking.UseVisualStyleBackColor = False
        '
        'btnDemo
        '
        Me.btnDemo.BackColor = System.Drawing.Color.SlateGray
        Me.btnDemo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDemo.FlatAppearance.BorderSize = 0
        Me.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDemo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemo.ForeColor = System.Drawing.Color.Black
        Me.btnDemo.Location = New System.Drawing.Point(302, 22)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(113, 68)
        Me.btnDemo.TabIndex = 18
        Me.btnDemo.TabStop = False
        Me.btnDemo.Text = "DEMO"
        Me.btnDemo.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.SlateGray
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.Black
        Me.btnAbout.Location = New System.Drawing.Point(140, 22)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(113, 68)
        Me.btnAbout.TabIndex = 17
        Me.btnAbout.TabStop = False
        Me.btnAbout.Text = "ABOUT"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'pnlDecryption
        '
        Me.pnlDecryption.Controls.Add(Me.btnDecryptionExample)
        Me.pnlDecryption.Controls.Add(Me.lblTryExplanation)
        Me.pnlDecryption.Controls.Add(Me.lblTryItOut)
        Me.pnlDecryption.Controls.Add(Me.lblCaesarCracking)
        Me.pnlDecryption.Location = New System.Drawing.Point(314, 114)
        Me.pnlDecryption.Name = "pnlDecryption"
        Me.pnlDecryption.Size = New System.Drawing.Size(745, 436)
        Me.pnlDecryption.TabIndex = 21
        '
        'btnDecryptionExample
        '
        Me.btnDecryptionExample.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDecryptionExample.FlatAppearance.BorderSize = 0
        Me.btnDecryptionExample.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecryptionExample.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecryptionExample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnDecryptionExample.Location = New System.Drawing.Point(299, 323)
        Me.btnDecryptionExample.Name = "btnDecryptionExample"
        Me.btnDecryptionExample.Size = New System.Drawing.Size(269, 58)
        Me.btnDecryptionExample.TabIndex = 26
        Me.btnDecryptionExample.TabStop = False
        Me.btnDecryptionExample.Text = "A ROT13 EXAMPLE"
        Me.btnDecryptionExample.UseVisualStyleBackColor = False
        '
        'lblTryExplanation
        '
        Me.lblTryExplanation.AutoSize = True
        Me.lblTryExplanation.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTryExplanation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTryExplanation.Location = New System.Drawing.Point(25, 276)
        Me.lblTryExplanation.Name = "lblTryExplanation"
        Me.lblTryExplanation.Size = New System.Drawing.Size(2730, 32)
        Me.lblTryExplanation.TabIndex = 19
        Me.lblTryExplanation.Text = "Use the ""DEMO"" tool to encipher a message, and then press the ""SET PLAINTEXT TO C" &
    "IPHERTEXT"" button. Try all the possible 26 keys on this new plaintext until you " &
    "end up with your original plaintext!"
        '
        'lblTryItOut
        '
        Me.lblTryItOut.AutoSize = True
        Me.lblTryItOut.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTryItOut.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTryItOut.Location = New System.Drawing.Point(283, 212)
        Me.lblTryItOut.Name = "lblTryItOut"
        Me.lblTryItOut.Size = New System.Drawing.Size(197, 44)
        Me.lblTryItOut.TabIndex = 18
        Me.lblTryItOut.Text = "TRY IT OUT"
        '
        'lblCaesarCracking
        '
        Me.lblCaesarCracking.AutoSize = True
        Me.lblCaesarCracking.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaesarCracking.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCaesarCracking.Location = New System.Drawing.Point(38, 27)
        Me.lblCaesarCracking.Name = "lblCaesarCracking"
        Me.lblCaesarCracking.Size = New System.Drawing.Size(5394, 160)
        Me.lblCaesarCracking.TabIndex = 1
        Me.lblCaesarCracking.Text = resources.GetString("lblCaesarCracking.Text")
        '
        'pnlAbout
        '
        Me.pnlAbout.Controls.Add(Me.picCaesarDiagram)
        Me.pnlAbout.Controls.Add(Me.lblCaesarInfo1)
        Me.pnlAbout.Location = New System.Drawing.Point(17, 175)
        Me.pnlAbout.Name = "pnlAbout"
        Me.pnlAbout.Size = New System.Drawing.Size(745, 436)
        Me.pnlAbout.TabIndex = 22
        '
        'picCaesarDiagram
        '
        Me.picCaesarDiagram.Image = CType(resources.GetObject("picCaesarDiagram.Image"), System.Drawing.Image)
        Me.picCaesarDiagram.Location = New System.Drawing.Point(-60, 194)
        Me.picCaesarDiagram.Name = "picCaesarDiagram"
        Me.picCaesarDiagram.Size = New System.Drawing.Size(800, 352)
        Me.picCaesarDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCaesarDiagram.TabIndex = 1
        Me.picCaesarDiagram.TabStop = False
        '
        'lblCaesarInfo1
        '
        Me.lblCaesarInfo1.AutoSize = True
        Me.lblCaesarInfo1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaesarInfo1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCaesarInfo1.Location = New System.Drawing.Point(15, 17)
        Me.lblCaesarInfo1.Name = "lblCaesarInfo1"
        Me.lblCaesarInfo1.Size = New System.Drawing.Size(3395, 160)
        Me.lblCaesarInfo1.TabIndex = 0
        Me.lblCaesarInfo1.Text = resources.GetString("lblCaesarInfo1.Text")
        '
        'pnlPrintout
        '
        Me.pnlPrintout.Controls.Add(Me.lblPrintoutExplanation)
        Me.pnlPrintout.Controls.Add(Me.picHidden)
        Me.pnlPrintout.Controls.Add(Me.picCaesarPrintout)
        Me.pnlPrintout.Controls.Add(Me.btnPrint)
        Me.pnlPrintout.Location = New System.Drawing.Point(593, 83)
        Me.pnlPrintout.Name = "pnlPrintout"
        Me.pnlPrintout.Size = New System.Drawing.Size(745, 436)
        Me.pnlPrintout.TabIndex = 23
        '
        'lblPrintoutExplanation
        '
        Me.lblPrintoutExplanation.AutoSize = True
        Me.lblPrintoutExplanation.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintoutExplanation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPrintoutExplanation.Location = New System.Drawing.Point(33, 14)
        Me.lblPrintoutExplanation.Name = "lblPrintoutExplanation"
        Me.lblPrintoutExplanation.Size = New System.Drawing.Size(3016, 160)
        Me.lblPrintoutExplanation.TabIndex = 27
        Me.lblPrintoutExplanation.Text = resources.GetString("lblPrintoutExplanation.Text")
        '
        'picHidden
        '
        Me.picHidden.Location = New System.Drawing.Point(232, 52)
        Me.picHidden.Name = "picHidden"
        Me.picHidden.Size = New System.Drawing.Size(100, 50)
        Me.picHidden.TabIndex = 29
        Me.picHidden.TabStop = False
        Me.picHidden.Visible = False
        '
        'picCaesarPrintout
        '
        Me.picCaesarPrintout.Image = CType(resources.GetObject("picCaesarPrintout.Image"), System.Drawing.Image)
        Me.picCaesarPrintout.Location = New System.Drawing.Point(338, 14)
        Me.picCaesarPrintout.Name = "picCaesarPrintout"
        Me.picCaesarPrintout.Size = New System.Drawing.Size(279, 351)
        Me.picCaesarPrintout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCaesarPrintout.TabIndex = 28
        Me.picCaesarPrintout.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(87, 108)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(171, 58)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.TabStop = False
        Me.btnPrint.Text = "PRINT 🖶"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'formVigenere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1106, 656)
        Me.Controls.Add(Me.pnlDemo)
        Me.Controls.Add(Me.pnlPrintout)
        Me.Controls.Add(Me.pnlAbout)
        Me.Controls.Add(Me.pnlDecryption)
        Me.Controls.Add(Me.btnPrintout)
        Me.Controls.Add(Me.btnCracking)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblVigenere)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formVigenere"
        Me.Text = "formVigenere"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDemo.ResumeLayout(False)
        Me.pnlDemo.PerformLayout()
        Me.pnlDecryption.ResumeLayout(False)
        Me.pnlDecryption.PerformLayout()
        Me.pnlAbout.ResumeLayout(False)
        Me.pnlAbout.PerformLayout()
        CType(Me.picCaesarDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrintout.ResumeLayout(False)
        Me.pnlPrintout.PerformLayout()
        CType(Me.picHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCaesarPrintout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblVigenere As Label
    Friend WithEvents pnlDemo As Panel
    Friend WithEvents lblShift As Label
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents lblAlphabetShift As Label
    Friend WithEvents lblAlphabet As Label
    Friend WithEvents lblCiphertext As Label
    Friend WithEvents lblPlaintext As Label
    Friend WithEvents txtCiphertext As TextBox
    Friend WithEvents txtPlaintext As TextBox
    Friend WithEvents btnPrintout As Button
    Friend WithEvents btnCracking As Button
    Friend WithEvents btnDemo As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents pnlDecryption As Panel
    Friend WithEvents btnDecryptionExample As Button
    Friend WithEvents lblTryExplanation As Label
    Friend WithEvents lblTryItOut As Label
    Friend WithEvents lblCaesarCracking As Label
    Friend WithEvents pnlAbout As Panel
    Friend WithEvents picCaesarDiagram As PictureBox
    Friend WithEvents lblCaesarInfo1 As Label
    Friend WithEvents pnlPrintout As Panel
    Friend WithEvents lblPrintoutExplanation As Label
    Friend WithEvents picHidden As PictureBox
    Friend WithEvents picCaesarPrintout As PictureBox
    Friend WithEvents btnPrint As Button
End Class
