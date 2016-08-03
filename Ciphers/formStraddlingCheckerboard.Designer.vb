<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStraddlingCheckerboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formStraddlingCheckerboard))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblStraddlingCheckerboard = New System.Windows.Forms.Label()
        Me.btnPrintout = New System.Windows.Forms.Button()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
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
        Me.pnlPrintout = New System.Windows.Forms.Panel()
        Me.lblPrintoutExplanation = New System.Windows.Forms.Label()
        Me.picHidden = New System.Windows.Forms.PictureBox()
        Me.picStraddlingPrintout = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.pnlDecryption = New System.Windows.Forms.Panel()
        Me.btnDecryptionExample = New System.Windows.Forms.Button()
        Me.lblTryExplanation = New System.Windows.Forms.Label()
        Me.lblTryItOut = New System.Windows.Forms.Label()
        Me.lblCaesarCracking = New System.Windows.Forms.Label()
        Me.pnlAbout1 = New System.Windows.Forms.Panel()
        Me.lblStraddlingInfo1 = New System.Windows.Forms.Label()
        Me.pnlAbout2 = New System.Windows.Forms.Panel()
        Me.lblStraddlingInfo2 = New System.Windows.Forms.Label()
        Me.btnPreviousPageAbout = New System.Windows.Forms.Button()
        Me.btnNextPageAbout = New System.Windows.Forms.Button()
        Me.picStraddling1 = New System.Windows.Forms.PictureBox()
        Me.picStraddling2 = New System.Windows.Forms.PictureBox()
        Me.lblStraddling1Caption = New System.Windows.Forms.Label()
        Me.lblStraddling2Caption = New System.Windows.Forms.Label()
        Me.lblStraddlingInfo3 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnlDemo.SuspendLayout()
        Me.pnlPrintout.SuspendLayout()
        CType(Me.picHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStraddlingPrintout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDecryption.SuspendLayout()
        Me.pnlAbout1.SuspendLayout()
        Me.pnlAbout2.SuspendLayout()
        CType(Me.picStraddling1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStraddling2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnBack.Location = New System.Drawing.Point(6, 548)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 10
        Me.btnBack.TabStop = False
        Me.btnBack.Text = "< MAIN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblStraddlingCheckerboard
        '
        Me.lblStraddlingCheckerboard.AutoSize = True
        Me.lblStraddlingCheckerboard.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraddlingCheckerboard.ForeColor = System.Drawing.Color.Silver
        Me.lblStraddlingCheckerboard.Location = New System.Drawing.Point(145, -3)
        Me.lblStraddlingCheckerboard.Name = "lblStraddlingCheckerboard"
        Me.lblStraddlingCheckerboard.Size = New System.Drawing.Size(779, 63)
        Me.lblStraddlingCheckerboard.TabIndex = 9
        Me.lblStraddlingCheckerboard.Text = "STRADDLING CHECKERBOARD"
        '
        'btnPrintout
        '
        Me.btnPrintout.BackColor = System.Drawing.Color.SlateGray
        Me.btnPrintout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintout.FlatAppearance.BorderSize = 0
        Me.btnPrintout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintout.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintout.ForeColor = System.Drawing.Color.Black
        Me.btnPrintout.Location = New System.Drawing.Point(637, 24)
        Me.btnPrintout.Name = "btnPrintout"
        Me.btnPrintout.Size = New System.Drawing.Size(160, 68)
        Me.btnPrintout.TabIndex = 24
        Me.btnPrintout.TabStop = False
        Me.btnPrintout.Text = "PRINT-OUT"
        Me.btnPrintout.UseVisualStyleBackColor = False
        '
        'btnDemo
        '
        Me.btnDemo.BackColor = System.Drawing.Color.SlateGray
        Me.btnDemo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDemo.FlatAppearance.BorderSize = 0
        Me.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDemo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemo.ForeColor = System.Drawing.Color.Black
        Me.btnDemo.Location = New System.Drawing.Point(291, 24)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(113, 68)
        Me.btnDemo.TabIndex = 22
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
        Me.btnAbout.Location = New System.Drawing.Point(129, 24)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(113, 68)
        Me.btnAbout.TabIndex = 21
        Me.btnAbout.TabStop = False
        Me.btnAbout.Text = "ABOUT"
        Me.btnAbout.UseVisualStyleBackColor = False
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
        Me.pnlDemo.Location = New System.Drawing.Point(227, 124)
        Me.pnlDemo.Name = "pnlDemo"
        Me.pnlDemo.Size = New System.Drawing.Size(798, 481)
        Me.pnlDemo.TabIndex = 25
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
        'pnlPrintout
        '
        Me.pnlPrintout.Controls.Add(Me.lblPrintoutExplanation)
        Me.pnlPrintout.Controls.Add(Me.picHidden)
        Me.pnlPrintout.Controls.Add(Me.picStraddlingPrintout)
        Me.pnlPrintout.Controls.Add(Me.btnPrint)
        Me.pnlPrintout.Location = New System.Drawing.Point(29, 51)
        Me.pnlPrintout.Name = "pnlPrintout"
        Me.pnlPrintout.Size = New System.Drawing.Size(745, 436)
        Me.pnlPrintout.TabIndex = 28
        '
        'lblPrintoutExplanation
        '
        Me.lblPrintoutExplanation.AutoSize = True
        Me.lblPrintoutExplanation.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintoutExplanation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPrintoutExplanation.Location = New System.Drawing.Point(33, 14)
        Me.lblPrintoutExplanation.Name = "lblPrintoutExplanation"
        Me.lblPrintoutExplanation.Size = New System.Drawing.Size(3051, 96)
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
        'picStraddlingPrintout
        '
        Me.picStraddlingPrintout.Image = CType(resources.GetObject("picStraddlingPrintout.Image"), System.Drawing.Image)
        Me.picStraddlingPrintout.Location = New System.Drawing.Point(338, 95)
        Me.picStraddlingPrintout.Name = "picStraddlingPrintout"
        Me.picStraddlingPrintout.Size = New System.Drawing.Size(279, 351)
        Me.picStraddlingPrintout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStraddlingPrintout.TabIndex = 28
        Me.picStraddlingPrintout.TabStop = False
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
        'pnlDecryption
        '
        Me.pnlDecryption.Controls.Add(Me.btnDecryptionExample)
        Me.pnlDecryption.Controls.Add(Me.lblTryExplanation)
        Me.pnlDecryption.Controls.Add(Me.lblTryItOut)
        Me.pnlDecryption.Controls.Add(Me.lblCaesarCracking)
        Me.pnlDecryption.Location = New System.Drawing.Point(308, 96)
        Me.pnlDecryption.Name = "pnlDecryption"
        Me.pnlDecryption.Size = New System.Drawing.Size(745, 436)
        Me.pnlDecryption.TabIndex = 26
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
        'pnlAbout1
        '
        Me.pnlAbout1.Controls.Add(Me.lblStraddlingInfo1)
        Me.pnlAbout1.Location = New System.Drawing.Point(32, 106)
        Me.pnlAbout1.Name = "pnlAbout1"
        Me.pnlAbout1.Size = New System.Drawing.Size(745, 436)
        Me.pnlAbout1.TabIndex = 29
        '
        'lblStraddlingInfo1
        '
        Me.lblStraddlingInfo1.AutoSize = True
        Me.lblStraddlingInfo1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraddlingInfo1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStraddlingInfo1.Location = New System.Drawing.Point(15, 17)
        Me.lblStraddlingInfo1.Name = "lblStraddlingInfo1"
        Me.lblStraddlingInfo1.Size = New System.Drawing.Size(10880, 160)
        Me.lblStraddlingInfo1.TabIndex = 0
        Me.lblStraddlingInfo1.Text = resources.GetString("lblStraddlingInfo1.Text")
        '
        'pnlAbout2
        '
        Me.pnlAbout2.Controls.Add(Me.lblStraddlingInfo3)
        Me.pnlAbout2.Controls.Add(Me.lblStraddling2Caption)
        Me.pnlAbout2.Controls.Add(Me.lblStraddling1Caption)
        Me.pnlAbout2.Controls.Add(Me.picStraddling2)
        Me.pnlAbout2.Controls.Add(Me.picStraddling1)
        Me.pnlAbout2.Controls.Add(Me.lblStraddlingInfo2)
        Me.pnlAbout2.Location = New System.Drawing.Point(46, 79)
        Me.pnlAbout2.Name = "pnlAbout2"
        Me.pnlAbout2.Size = New System.Drawing.Size(745, 436)
        Me.pnlAbout2.TabIndex = 30
        '
        'lblStraddlingInfo2
        '
        Me.lblStraddlingInfo2.AutoSize = True
        Me.lblStraddlingInfo2.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraddlingInfo2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStraddlingInfo2.Location = New System.Drawing.Point(15, 17)
        Me.lblStraddlingInfo2.Name = "lblStraddlingInfo2"
        Me.lblStraddlingInfo2.Size = New System.Drawing.Size(5734, 96)
        Me.lblStraddlingInfo2.TabIndex = 0
        Me.lblStraddlingInfo2.Text = resources.GetString("lblStraddlingInfo2.Text")
        '
        'btnPreviousPageAbout
        '
        Me.btnPreviousPageAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnPreviousPageAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPreviousPageAbout.FlatAppearance.BorderSize = 0
        Me.btnPreviousPageAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviousPageAbout.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousPageAbout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPreviousPageAbout.Location = New System.Drawing.Point(-4, -28)
        Me.btnPreviousPageAbout.Name = "btnPreviousPageAbout"
        Me.btnPreviousPageAbout.Size = New System.Drawing.Size(95, 101)
        Me.btnPreviousPageAbout.TabIndex = 27
        Me.btnPreviousPageAbout.Text = "<"
        Me.btnPreviousPageAbout.UseVisualStyleBackColor = False
        '
        'btnNextPageAbout
        '
        Me.btnNextPageAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNextPageAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNextPageAbout.FlatAppearance.BorderSize = 0
        Me.btnNextPageAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPageAbout.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPageAbout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnNextPageAbout.Location = New System.Drawing.Point(653, -28)
        Me.btnNextPageAbout.Name = "btnNextPageAbout"
        Me.btnNextPageAbout.Size = New System.Drawing.Size(95, 101)
        Me.btnNextPageAbout.TabIndex = 31
        Me.btnNextPageAbout.Text = ">"
        Me.btnNextPageAbout.UseVisualStyleBackColor = False
        '
        'picStraddling1
        '
        Me.picStraddling1.Image = CType(resources.GetObject("picStraddling1.Image"), System.Drawing.Image)
        Me.picStraddling1.Location = New System.Drawing.Point(58, 52)
        Me.picStraddling1.Name = "picStraddling1"
        Me.picStraddling1.Size = New System.Drawing.Size(236, 108)
        Me.picStraddling1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStraddling1.TabIndex = 6
        Me.picStraddling1.TabStop = False
        '
        'picStraddling2
        '
        Me.picStraddling2.Image = CType(resources.GetObject("picStraddling2.Image"), System.Drawing.Image)
        Me.picStraddling2.Location = New System.Drawing.Point(362, 52)
        Me.picStraddling2.Name = "picStraddling2"
        Me.picStraddling2.Size = New System.Drawing.Size(261, 108)
        Me.picStraddling2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStraddling2.TabIndex = 7
        Me.picStraddling2.TabStop = False
        '
        'lblStraddling1Caption
        '
        Me.lblStraddling1Caption.AutoSize = True
        Me.lblStraddling1Caption.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraddling1Caption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStraddling1Caption.Location = New System.Drawing.Point(3, 376)
        Me.lblStraddling1Caption.Name = "lblStraddling1Caption"
        Me.lblStraddling1Caption.Size = New System.Drawing.Size(338, 22)
        Me.lblStraddling1Caption.TabIndex = 8
        Me.lblStraddling1Caption.Text = "Standard Straddling Checkerboard"
        '
        'lblStraddling2Caption
        '
        Me.lblStraddling2Caption.AutoSize = True
        Me.lblStraddling2Caption.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraddling2Caption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStraddling2Caption.Location = New System.Drawing.Point(383, 376)
        Me.lblStraddling2Caption.Name = "lblStraddling2Caption"
        Me.lblStraddling2Caption.Size = New System.Drawing.Size(450, 22)
        Me.lblStraddling2Caption.TabIndex = 9
        Me.lblStraddling2Caption.Text = "Straddling Checkerboard With Key ""ETAOINSR"" "
        '
        'lblStraddlingInfo3
        '
        Me.lblStraddlingInfo3.AutoSize = True
        Me.lblStraddlingInfo3.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraddlingInfo3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStraddlingInfo3.Location = New System.Drawing.Point(15, 197)
        Me.lblStraddlingInfo3.Name = "lblStraddlingInfo3"
        Me.lblStraddlingInfo3.Size = New System.Drawing.Size(5142, 32)
        Me.lblStraddlingInfo3.TabIndex = 10
        Me.lblStraddlingInfo3.Text = resources.GetString("lblStraddlingInfo3.Text")
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'formStraddlingCheckerboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1090, 617)
        Me.Controls.Add(Me.pnlPrintout)
        Me.Controls.Add(Me.btnNextPageAbout)
        Me.Controls.Add(Me.btnPreviousPageAbout)
        Me.Controls.Add(Me.pnlAbout1)
        Me.Controls.Add(Me.pnlDemo)
        Me.Controls.Add(Me.pnlDecryption)
        Me.Controls.Add(Me.btnPrintout)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblStraddlingCheckerboard)
        Me.Controls.Add(Me.pnlAbout2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formStraddlingCheckerboard"
        Me.Text = "formStraddlingCheckerboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDemo.ResumeLayout(False)
        Me.pnlDemo.PerformLayout()
        Me.pnlPrintout.ResumeLayout(False)
        Me.pnlPrintout.PerformLayout()
        CType(Me.picHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStraddlingPrintout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDecryption.ResumeLayout(False)
        Me.pnlDecryption.PerformLayout()
        Me.pnlAbout1.ResumeLayout(False)
        Me.pnlAbout1.PerformLayout()
        Me.pnlAbout2.ResumeLayout(False)
        Me.pnlAbout2.PerformLayout()
        CType(Me.picStraddling1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStraddling2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblStraddlingCheckerboard As Label
    Friend WithEvents btnPrintout As Button
    Friend WithEvents btnDemo As Button
    Friend WithEvents btnAbout As Button
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
    Friend WithEvents pnlPrintout As Panel
    Friend WithEvents lblPrintoutExplanation As Label
    Friend WithEvents picHidden As PictureBox
    Friend WithEvents picStraddlingPrintout As PictureBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents pnlDecryption As Panel
    Friend WithEvents btnDecryptionExample As Button
    Friend WithEvents lblTryExplanation As Label
    Friend WithEvents lblTryItOut As Label
    Friend WithEvents lblCaesarCracking As Label
    Friend WithEvents pnlAbout1 As Panel
    Friend WithEvents lblStraddlingInfo1 As Label
    Friend WithEvents pnlAbout2 As Panel
    Friend WithEvents lblStraddlingInfo2 As Label
    Friend WithEvents btnPreviousPageAbout As Button
    Friend WithEvents btnNextPageAbout As Button
    Friend WithEvents picStraddling2 As PictureBox
    Friend WithEvents picStraddling1 As PictureBox
    Friend WithEvents lblStraddling2Caption As Label
    Friend WithEvents lblStraddling1Caption As Label
    Friend WithEvents lblStraddlingInfo3 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
