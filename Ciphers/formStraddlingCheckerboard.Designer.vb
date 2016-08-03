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
        Me.btnn2More = New System.Windows.Forms.Button()
        Me.btnn1More = New System.Windows.Forms.Button()
        Me.btnn2fewer = New System.Windows.Forms.Button()
        Me.btnn1Fewer = New System.Windows.Forms.Button()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.lblExcludedDigits = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
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
        Me.lblStraddlingInfo3 = New System.Windows.Forms.Label()
        Me.lblStraddling2Caption = New System.Windows.Forms.Label()
        Me.lblStraddling1Caption = New System.Windows.Forms.Label()
        Me.picStraddling2 = New System.Windows.Forms.PictureBox()
        Me.picStraddling1 = New System.Windows.Forms.PictureBox()
        Me.lblStraddlingInfo2 = New System.Windows.Forms.Label()
        Me.btnPreviousPageAbout = New System.Windows.Forms.Button()
        Me.btnNextPageAbout = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnlDemo.SuspendLayout()
        Me.pnlPrintout.SuspendLayout()
        CType(Me.picHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStraddlingPrintout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDecryption.SuspendLayout()
        Me.pnlAbout1.SuspendLayout()
        Me.pnlAbout2.SuspendLayout()
        CType(Me.picStraddling2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStraddling1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlDemo.Controls.Add(Me.btnn2More)
        Me.pnlDemo.Controls.Add(Me.btnn1More)
        Me.pnlDemo.Controls.Add(Me.btnn2fewer)
        Me.pnlDemo.Controls.Add(Me.btnn1Fewer)
        Me.pnlDemo.Controls.Add(Me.txtn2)
        Me.pnlDemo.Controls.Add(Me.txtn1)
        Me.pnlDemo.Controls.Add(Me.lblExcludedDigits)
        Me.pnlDemo.Controls.Add(Me.lblKey)
        Me.pnlDemo.Controls.Add(Me.txtKey)
        Me.pnlDemo.Controls.Add(Me.lblCiphertext)
        Me.pnlDemo.Controls.Add(Me.lblPlaintext)
        Me.pnlDemo.Controls.Add(Me.txtCiphertext)
        Me.pnlDemo.Controls.Add(Me.txtPlaintext)
        Me.pnlDemo.Location = New System.Drawing.Point(6, 31)
        Me.pnlDemo.Name = "pnlDemo"
        Me.pnlDemo.Size = New System.Drawing.Size(798, 481)
        Me.pnlDemo.TabIndex = 25
        '
        'btnn2More
        '
        Me.btnn2More.BackColor = System.Drawing.Color.Gainsboro
        Me.btnn2More.FlatAppearance.BorderSize = 0
        Me.btnn2More.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnn2More.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnn2More.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnn2More.Location = New System.Drawing.Point(738, 315)
        Me.btnn2More.Name = "btnn2More"
        Me.btnn2More.Size = New System.Drawing.Size(50, 50)
        Me.btnn2More.TabIndex = 34
        Me.btnn2More.TabStop = False
        Me.btnn2More.Text = ">"
        Me.btnn2More.UseVisualStyleBackColor = False
        '
        'btnn1More
        '
        Me.btnn1More.BackColor = System.Drawing.Color.Gainsboro
        Me.btnn1More.FlatAppearance.BorderSize = 0
        Me.btnn1More.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnn1More.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnn1More.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnn1More.Location = New System.Drawing.Point(531, 305)
        Me.btnn1More.Name = "btnn1More"
        Me.btnn1More.Size = New System.Drawing.Size(50, 50)
        Me.btnn1More.TabIndex = 33
        Me.btnn1More.TabStop = False
        Me.btnn1More.Text = ">"
        Me.btnn1More.UseVisualStyleBackColor = False
        '
        'btnn2fewer
        '
        Me.btnn2fewer.BackColor = System.Drawing.Color.Gainsboro
        Me.btnn2fewer.FlatAppearance.BorderSize = 0
        Me.btnn2fewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnn2fewer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnn2fewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnn2fewer.Location = New System.Drawing.Point(613, 315)
        Me.btnn2fewer.Name = "btnn2fewer"
        Me.btnn2fewer.Size = New System.Drawing.Size(50, 50)
        Me.btnn2fewer.TabIndex = 32
        Me.btnn2fewer.TabStop = False
        Me.btnn2fewer.Text = "<"
        Me.btnn2fewer.UseVisualStyleBackColor = False
        '
        'btnn1Fewer
        '
        Me.btnn1Fewer.BackColor = System.Drawing.Color.Gainsboro
        Me.btnn1Fewer.FlatAppearance.BorderSize = 0
        Me.btnn1Fewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnn1Fewer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnn1Fewer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnn1Fewer.Location = New System.Drawing.Point(400, 305)
        Me.btnn1Fewer.Name = "btnn1Fewer"
        Me.btnn1Fewer.Size = New System.Drawing.Size(50, 50)
        Me.btnn1Fewer.TabIndex = 31
        Me.btnn1Fewer.TabStop = False
        Me.btnn1Fewer.Text = "<"
        Me.btnn1Fewer.UseVisualStyleBackColor = False
        '
        'txtn2
        '
        Me.txtn2.BackColor = System.Drawing.Color.White
        Me.txtn2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtn2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtn2.Location = New System.Drawing.Point(672, 319)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(60, 36)
        Me.txtn2.TabIndex = 30
        Me.txtn2.Text = "1"
        Me.txtn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtn1
        '
        Me.txtn1.BackColor = System.Drawing.Color.White
        Me.txtn1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtn1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtn1.Location = New System.Drawing.Point(465, 315)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(60, 36)
        Me.txtn1.TabIndex = 29
        Me.txtn1.Text = "1"
        Me.txtn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblExcludedDigits
        '
        Me.lblExcludedDigits.AutoSize = True
        Me.lblExcludedDigits.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcludedDigits.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblExcludedDigits.Location = New System.Drawing.Point(118, 305)
        Me.lblExcludedDigits.Name = "lblExcludedDigits"
        Me.lblExcludedDigits.Size = New System.Drawing.Size(263, 36)
        Me.lblExcludedDigits.TabIndex = 28
        Me.lblExcludedDigits.Text = "EXCLUDED DIGITS:"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKey.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblKey.Location = New System.Drawing.Point(144, 245)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(74, 36)
        Me.lblKey.TabIndex = 27
        Me.lblKey.Text = "KEY:"
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.Color.LightGray
        Me.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKey.Font = New System.Drawing.Font("Lucida Sans Typewriter", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.Black
        Me.txtKey.Location = New System.Drawing.Point(233, 241)
        Me.txtKey.MaxLength = 18
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(430, 44)
        Me.txtKey.TabIndex = 26
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCiphertext
        '
        Me.lblCiphertext.AutoSize = True
        Me.lblCiphertext.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiphertext.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCiphertext.Location = New System.Drawing.Point(476, 373)
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
        Me.lblPlaintext.Location = New System.Drawing.Point(66, 380)
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
        Me.txtCiphertext.Location = New System.Drawing.Point(481, 408)
        Me.txtCiphertext.MaxLength = 100
        Me.txtCiphertext.Multiline = True
        Me.txtCiphertext.Name = "txtCiphertext"
        Me.txtCiphertext.Size = New System.Drawing.Size(389, 103)
        Me.txtCiphertext.TabIndex = 1
        Me.txtCiphertext.TabStop = False
        '
        'txtPlaintext
        '
        Me.txtPlaintext.BackColor = System.Drawing.Color.LightGray
        Me.txtPlaintext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlaintext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaintext.Font = New System.Drawing.Font("Lucida Sans Typewriter", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaintext.ForeColor = System.Drawing.Color.Black
        Me.txtPlaintext.Location = New System.Drawing.Point(61, 408)
        Me.txtPlaintext.MaxLength = 100
        Me.txtPlaintext.Multiline = True
        Me.txtPlaintext.Name = "txtPlaintext"
        Me.txtPlaintext.Size = New System.Drawing.Size(389, 73)
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
        Me.Controls.Add(Me.btnNextPageAbout)
        Me.Controls.Add(Me.btnPreviousPageAbout)
        Me.Controls.Add(Me.pnlDemo)
        Me.Controls.Add(Me.pnlDecryption)
        Me.Controls.Add(Me.btnPrintout)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblStraddlingCheckerboard)
        Me.Controls.Add(Me.pnlPrintout)
        Me.Controls.Add(Me.pnlAbout2)
        Me.Controls.Add(Me.pnlAbout1)
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
        CType(Me.picStraddling2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStraddling1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblStraddlingCheckerboard As Label
    Friend WithEvents btnPrintout As Button
    Friend WithEvents btnDemo As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents pnlDemo As Panel
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
    Friend WithEvents txtKey As TextBox
    Friend WithEvents lblExcludedDigits As Label
    Friend WithEvents lblKey As Label
    Friend WithEvents btnn2More As Button
    Friend WithEvents btnn1More As Button
    Friend WithEvents btnn2fewer As Button
    Friend WithEvents btnn1Fewer As Button
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents txtn1 As TextBox
End Class
