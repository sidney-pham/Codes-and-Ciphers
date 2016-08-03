<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formVigenere
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formVigenere))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblVigenere = New System.Windows.Forms.Label()
        Me.pnlDemo = New System.Windows.Forms.Panel()
        Me.lblResultAdditionSubscript = New System.Windows.Forms.Label()
        Me.lblResultAddition = New System.Windows.Forms.Label()
        Me.lblEqualsAddition = New System.Windows.Forms.Label()
        Me.lblPlusAddition = New System.Windows.Forms.Label()
        Me.lblKeyAdditionSubscript = New System.Windows.Forms.Label()
        Me.lblPlaintextAdditionSubscript = New System.Windows.Forms.Label()
        Me.lblKeyAddition = New System.Windows.Forms.Label()
        Me.lblPlaintextAddition = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.lblKeyLarge = New System.Windows.Forms.Label()
        Me.lblCiphertext = New System.Windows.Forms.Label()
        Me.lblPlaintext = New System.Windows.Forms.Label()
        Me.txtCiphertext = New System.Windows.Forms.TextBox()
        Me.txtPlaintext = New System.Windows.Forms.TextBox()
        Me.btnPrintout = New System.Windows.Forms.Button()
        Me.btnCracking = New System.Windows.Forms.Button()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pnlDecryption1 = New System.Windows.Forms.Panel()
        Me.lblVigenereDecryption = New System.Windows.Forms.Label()
        Me.pnlAbout1 = New System.Windows.Forms.Panel()
        Me.lblVigenereCaption = New System.Windows.Forms.Label()
        Me.lblAlbertiCaption = New System.Windows.Forms.Label()
        Me.picVigenere = New System.Windows.Forms.PictureBox()
        Me.picAlberti = New System.Windows.Forms.PictureBox()
        Me.lblVigenereInfo1 = New System.Windows.Forms.Label()
        Me.pnlPrintout = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPrintoutExplanation = New System.Windows.Forms.Label()
        Me.picHidden = New System.Windows.Forms.PictureBox()
        Me.picVigenerePrintout = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.pnlAbout2 = New System.Windows.Forms.Panel()
        Me.lblVigenereSquareCaption = New System.Windows.Forms.Label()
        Me.picVigenereSquare = New System.Windows.Forms.PictureBox()
        Me.lblVigenereInfo3 = New System.Windows.Forms.Label()
        Me.lblVigenereInfo2 = New System.Windows.Forms.Label()
        Me.btnNextPageAbout = New System.Windows.Forms.Button()
        Me.btnPreviousPageAbout = New System.Windows.Forms.Button()
        Me.btnPreviousPageDecryption = New System.Windows.Forms.Button()
        Me.btnNextPageDecryption = New System.Windows.Forms.Button()
        Me.pnlDecryption2 = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblVideo = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnlDemo.SuspendLayout()
        Me.pnlDecryption1.SuspendLayout()
        Me.pnlAbout1.SuspendLayout()
        CType(Me.picVigenere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAlberti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrintout.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVigenerePrintout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAbout2.SuspendLayout()
        CType(Me.picVigenereSquare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDecryption2.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlDemo.Controls.Add(Me.lblResultAdditionSubscript)
        Me.pnlDemo.Controls.Add(Me.lblResultAddition)
        Me.pnlDemo.Controls.Add(Me.lblEqualsAddition)
        Me.pnlDemo.Controls.Add(Me.lblPlusAddition)
        Me.pnlDemo.Controls.Add(Me.lblKeyAdditionSubscript)
        Me.pnlDemo.Controls.Add(Me.lblPlaintextAdditionSubscript)
        Me.pnlDemo.Controls.Add(Me.lblKeyAddition)
        Me.pnlDemo.Controls.Add(Me.lblPlaintextAddition)
        Me.pnlDemo.Controls.Add(Me.txtKey)
        Me.pnlDemo.Controls.Add(Me.lblKey)
        Me.pnlDemo.Controls.Add(Me.lblKeyLarge)
        Me.pnlDemo.Controls.Add(Me.lblCiphertext)
        Me.pnlDemo.Controls.Add(Me.lblPlaintext)
        Me.pnlDemo.Controls.Add(Me.txtCiphertext)
        Me.pnlDemo.Controls.Add(Me.txtPlaintext)
        Me.pnlDemo.Location = New System.Drawing.Point(53, 96)
        Me.pnlDemo.Name = "pnlDemo"
        Me.pnlDemo.Size = New System.Drawing.Size(835, 518)
        Me.pnlDemo.TabIndex = 16
        '
        'lblResultAdditionSubscript
        '
        Me.lblResultAdditionSubscript.AutoSize = True
        Me.lblResultAdditionSubscript.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultAdditionSubscript.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblResultAdditionSubscript.Location = New System.Drawing.Point(420, 165)
        Me.lblResultAdditionSubscript.Name = "lblResultAdditionSubscript"
        Me.lblResultAdditionSubscript.Size = New System.Drawing.Size(21, 23)
        Me.lblResultAdditionSubscript.TabIndex = 33
        Me.lblResultAdditionSubscript.Text = "B"
        '
        'lblResultAddition
        '
        Me.lblResultAddition.AutoSize = True
        Me.lblResultAddition.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultAddition.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblResultAddition.Location = New System.Drawing.Point(392, 129)
        Me.lblResultAddition.Name = "lblResultAddition"
        Me.lblResultAddition.Size = New System.Drawing.Size(32, 36)
        Me.lblResultAddition.TabIndex = 32
        Me.lblResultAddition.Text = "B"
        '
        'lblEqualsAddition
        '
        Me.lblEqualsAddition.AutoSize = True
        Me.lblEqualsAddition.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqualsAddition.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblEqualsAddition.Location = New System.Drawing.Point(347, 125)
        Me.lblEqualsAddition.Name = "lblEqualsAddition"
        Me.lblEqualsAddition.Size = New System.Drawing.Size(32, 36)
        Me.lblEqualsAddition.TabIndex = 31
        Me.lblEqualsAddition.Text = "="
        '
        'lblPlusAddition
        '
        Me.lblPlusAddition.AutoSize = True
        Me.lblPlusAddition.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlusAddition.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPlusAddition.Location = New System.Drawing.Point(254, 125)
        Me.lblPlusAddition.Name = "lblPlusAddition"
        Me.lblPlusAddition.Size = New System.Drawing.Size(32, 36)
        Me.lblPlusAddition.TabIndex = 30
        Me.lblPlusAddition.Text = "+"
        '
        'lblKeyAdditionSubscript
        '
        Me.lblKeyAdditionSubscript.AutoSize = True
        Me.lblKeyAdditionSubscript.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyAdditionSubscript.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblKeyAdditionSubscript.Location = New System.Drawing.Point(320, 155)
        Me.lblKeyAdditionSubscript.Name = "lblKeyAdditionSubscript"
        Me.lblKeyAdditionSubscript.Size = New System.Drawing.Size(21, 23)
        Me.lblKeyAdditionSubscript.TabIndex = 29
        Me.lblKeyAdditionSubscript.Text = "B"
        '
        'lblPlaintextAdditionSubscript
        '
        Me.lblPlaintextAdditionSubscript.AutoSize = True
        Me.lblPlaintextAdditionSubscript.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaintextAdditionSubscript.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPlaintextAdditionSubscript.Location = New System.Drawing.Point(229, 155)
        Me.lblPlaintextAdditionSubscript.Name = "lblPlaintextAdditionSubscript"
        Me.lblPlaintextAdditionSubscript.Size = New System.Drawing.Size(21, 23)
        Me.lblPlaintextAdditionSubscript.TabIndex = 28
        Me.lblPlaintextAdditionSubscript.Text = "B"
        '
        'lblKeyAddition
        '
        Me.lblKeyAddition.AutoSize = True
        Me.lblKeyAddition.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyAddition.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblKeyAddition.Location = New System.Drawing.Point(292, 125)
        Me.lblKeyAddition.Name = "lblKeyAddition"
        Me.lblKeyAddition.Size = New System.Drawing.Size(32, 36)
        Me.lblKeyAddition.TabIndex = 27
        Me.lblKeyAddition.Text = "B"
        '
        'lblPlaintextAddition
        '
        Me.lblPlaintextAddition.AutoSize = True
        Me.lblPlaintextAddition.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaintextAddition.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPlaintextAddition.Location = New System.Drawing.Point(198, 125)
        Me.lblPlaintextAddition.Name = "lblPlaintextAddition"
        Me.lblPlaintextAddition.Size = New System.Drawing.Size(32, 36)
        Me.lblPlaintextAddition.TabIndex = 26
        Me.lblPlaintextAddition.Text = "B"
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.Color.LightGray
        Me.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKey.Font = New System.Drawing.Font("Lucida Sans Typewriter", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.Black
        Me.txtKey.Location = New System.Drawing.Point(169, 15)
        Me.txtKey.MaxLength = 18
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(430, 44)
        Me.txtKey.TabIndex = 25
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKey.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblKey.Location = New System.Drawing.Point(47, 28)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(74, 36)
        Me.lblKey.TabIndex = 24
        Me.lblKey.Text = "KEY:"
        '
        'lblKeyLarge
        '
        Me.lblKeyLarge.AutoSize = True
        Me.lblKeyLarge.Font = New System.Drawing.Font("Lucida Sans Typewriter", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyLarge.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblKeyLarge.Location = New System.Drawing.Point(243, 84)
        Me.lblKeyLarge.Name = "lblKeyLarge"
        Me.lblKeyLarge.Size = New System.Drawing.Size(285, 55)
        Me.lblKeyLarge.TabIndex = 20
        Me.lblKeyLarge.Text = "C O U N T"
        '
        'lblCiphertext
        '
        Me.lblCiphertext.AutoSize = True
        Me.lblCiphertext.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiphertext.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCiphertext.Location = New System.Drawing.Point(453, 187)
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
        Me.lblPlaintext.Location = New System.Drawing.Point(30, 184)
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
        Me.txtCiphertext.Location = New System.Drawing.Point(437, 221)
        Me.txtCiphertext.MaxLength = 150
        Me.txtCiphertext.Multiline = True
        Me.txtCiphertext.Name = "txtCiphertext"
        Me.txtCiphertext.ReadOnly = True
        Me.txtCiphertext.Size = New System.Drawing.Size(389, 275)
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
        Me.txtPlaintext.Location = New System.Drawing.Point(35, 221)
        Me.txtPlaintext.MaxLength = 100
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
        Me.btnPrintout.Location = New System.Drawing.Point(642, 22)
        Me.btnPrintout.Name = "btnPrintout"
        Me.btnPrintout.Size = New System.Drawing.Size(166, 68)
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
        'pnlDecryption1
        '
        Me.pnlDecryption1.Controls.Add(Me.lblVigenereDecryption)
        Me.pnlDecryption1.Location = New System.Drawing.Point(180, 43)
        Me.pnlDecryption1.Name = "pnlDecryption1"
        Me.pnlDecryption1.Size = New System.Drawing.Size(745, 436)
        Me.pnlDecryption1.TabIndex = 21
        '
        'lblVigenereDecryption
        '
        Me.lblVigenereDecryption.AutoSize = True
        Me.lblVigenereDecryption.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenereDecryption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVigenereDecryption.Location = New System.Drawing.Point(38, 27)
        Me.lblVigenereDecryption.Name = "lblVigenereDecryption"
        Me.lblVigenereDecryption.Size = New System.Drawing.Size(7662, 160)
        Me.lblVigenereDecryption.TabIndex = 1
        Me.lblVigenereDecryption.Text = resources.GetString("lblVigenereDecryption.Text")
        '
        'pnlAbout1
        '
        Me.pnlAbout1.Controls.Add(Me.lblVigenereCaption)
        Me.pnlAbout1.Controls.Add(Me.lblAlbertiCaption)
        Me.pnlAbout1.Controls.Add(Me.picVigenere)
        Me.pnlAbout1.Controls.Add(Me.picAlberti)
        Me.pnlAbout1.Controls.Add(Me.lblVigenereInfo1)
        Me.pnlAbout1.Location = New System.Drawing.Point(33, 111)
        Me.pnlAbout1.Name = "pnlAbout1"
        Me.pnlAbout1.Size = New System.Drawing.Size(745, 436)
        Me.pnlAbout1.TabIndex = 22
        '
        'lblVigenereCaption
        '
        Me.lblVigenereCaption.AutoSize = True
        Me.lblVigenereCaption.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenereCaption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVigenereCaption.Location = New System.Drawing.Point(433, 405)
        Me.lblVigenereCaption.Name = "lblVigenereCaption"
        Me.lblVigenereCaption.Size = New System.Drawing.Size(178, 22)
        Me.lblVigenereCaption.TabIndex = 4
        Me.lblVigenereCaption.Text = "Blaise de Vigenère"
        '
        'lblAlbertiCaption
        '
        Me.lblAlbertiCaption.AutoSize = True
        Me.lblAlbertiCaption.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlbertiCaption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAlbertiCaption.Location = New System.Drawing.Point(121, 387)
        Me.lblAlbertiCaption.Name = "lblAlbertiCaption"
        Me.lblAlbertiCaption.Size = New System.Drawing.Size(203, 22)
        Me.lblAlbertiCaption.TabIndex = 3
        Me.lblAlbertiCaption.Text = "Leon Battista Alberti"
        '
        'picVigenere
        '
        Me.picVigenere.Image = CType(resources.GetObject("picVigenere.Image"), System.Drawing.Image)
        Me.picVigenere.Location = New System.Drawing.Point(437, 194)
        Me.picVigenere.Name = "picVigenere"
        Me.picVigenere.Size = New System.Drawing.Size(207, 215)
        Me.picVigenere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVigenere.TabIndex = 2
        Me.picVigenere.TabStop = False
        '
        'picAlberti
        '
        Me.picAlberti.Image = CType(resources.GetObject("picAlberti.Image"), System.Drawing.Image)
        Me.picAlberti.Location = New System.Drawing.Point(82, 17)
        Me.picAlberti.Name = "picAlberti"
        Me.picAlberti.Size = New System.Drawing.Size(300, 397)
        Me.picAlberti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAlberti.TabIndex = 1
        Me.picAlberti.TabStop = False
        '
        'lblVigenereInfo1
        '
        Me.lblVigenereInfo1.AutoSize = True
        Me.lblVigenereInfo1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenereInfo1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVigenereInfo1.Location = New System.Drawing.Point(15, 17)
        Me.lblVigenereInfo1.Name = "lblVigenereInfo1"
        Me.lblVigenereInfo1.Size = New System.Drawing.Size(5422, 160)
        Me.lblVigenereInfo1.TabIndex = 0
        Me.lblVigenereInfo1.Text = resources.GetString("lblVigenereInfo1.Text")
        '
        'pnlPrintout
        '
        Me.pnlPrintout.Controls.Add(Me.PictureBox1)
        Me.pnlPrintout.Controls.Add(Me.lblPrintoutExplanation)
        Me.pnlPrintout.Controls.Add(Me.picHidden)
        Me.pnlPrintout.Controls.Add(Me.picVigenerePrintout)
        Me.pnlPrintout.Controls.Add(Me.btnPrint)
        Me.pnlPrintout.Location = New System.Drawing.Point(306, 12)
        Me.pnlPrintout.Name = "pnlPrintout"
        Me.pnlPrintout.Size = New System.Drawing.Size(745, 436)
        Me.pnlPrintout.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(655, 190)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lblPrintoutExplanation
        '
        Me.lblPrintoutExplanation.AutoSize = True
        Me.lblPrintoutExplanation.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintoutExplanation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPrintoutExplanation.Location = New System.Drawing.Point(33, 14)
        Me.lblPrintoutExplanation.Name = "lblPrintoutExplanation"
        Me.lblPrintoutExplanation.Size = New System.Drawing.Size(1174, 32)
        Me.lblPrintoutExplanation.TabIndex = 27
        Me.lblPrintoutExplanation.Text = "Use the Vigenère square to encrypt your own messages using a polyalphabetic ciphe" &
    "r!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'picVigenerePrintout
        '
        Me.picVigenerePrintout.Image = CType(resources.GetObject("picVigenerePrintout.Image"), System.Drawing.Image)
        Me.picVigenerePrintout.Location = New System.Drawing.Point(338, 14)
        Me.picVigenerePrintout.Name = "picVigenerePrintout"
        Me.picVigenerePrintout.Size = New System.Drawing.Size(279, 351)
        Me.picVigenerePrintout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVigenerePrintout.TabIndex = 28
        Me.picVigenerePrintout.TabStop = False
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
        'pnlAbout2
        '
        Me.pnlAbout2.Controls.Add(Me.lblVigenereSquareCaption)
        Me.pnlAbout2.Controls.Add(Me.picVigenereSquare)
        Me.pnlAbout2.Controls.Add(Me.lblVigenereInfo3)
        Me.pnlAbout2.Controls.Add(Me.lblVigenereInfo2)
        Me.pnlAbout2.Location = New System.Drawing.Point(137, 80)
        Me.pnlAbout2.Name = "pnlAbout2"
        Me.pnlAbout2.Size = New System.Drawing.Size(745, 436)
        Me.pnlAbout2.TabIndex = 24
        '
        'lblVigenereSquareCaption
        '
        Me.lblVigenereSquareCaption.AutoSize = True
        Me.lblVigenereSquareCaption.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenereSquareCaption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVigenereSquareCaption.Location = New System.Drawing.Point(355, 177)
        Me.lblVigenereSquareCaption.Name = "lblVigenereSquareCaption"
        Me.lblVigenereSquareCaption.Size = New System.Drawing.Size(160, 22)
        Me.lblVigenereSquareCaption.TabIndex = 6
        Me.lblVigenereSquareCaption.Text = "Vigenère Square"
        '
        'picVigenereSquare
        '
        Me.picVigenereSquare.Image = CType(resources.GetObject("picVigenereSquare.Image"), System.Drawing.Image)
        Me.picVigenereSquare.Location = New System.Drawing.Point(290, 83)
        Me.picVigenereSquare.Name = "picVigenereSquare"
        Me.picVigenereSquare.Size = New System.Drawing.Size(300, 397)
        Me.picVigenereSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVigenereSquare.TabIndex = 5
        Me.picVigenereSquare.TabStop = False
        '
        'lblVigenereInfo3
        '
        Me.lblVigenereInfo3.AutoSize = True
        Me.lblVigenereInfo3.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenereInfo3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVigenereInfo3.Location = New System.Drawing.Point(15, 187)
        Me.lblVigenereInfo3.Name = "lblVigenereInfo3"
        Me.lblVigenereInfo3.Size = New System.Drawing.Size(3376, 96)
        Me.lblVigenereInfo3.TabIndex = 1
        Me.lblVigenereInfo3.Text = resources.GetString("lblVigenereInfo3.Text")
        '
        'lblVigenereInfo2
        '
        Me.lblVigenereInfo2.AutoSize = True
        Me.lblVigenereInfo2.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenereInfo2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVigenereInfo2.Location = New System.Drawing.Point(15, 17)
        Me.lblVigenereInfo2.Name = "lblVigenereInfo2"
        Me.lblVigenereInfo2.Size = New System.Drawing.Size(1974, 32)
        Me.lblVigenereInfo2.TabIndex = 0
        Me.lblVigenereInfo2.Text = "The Vigenère cipher is generally used with a Vigenère square. This is a square th" &
    "at shows the corresponding alphabet for every letter in the key."
        '
        'btnNextPageAbout
        '
        Me.btnNextPageAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNextPageAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNextPageAbout.FlatAppearance.BorderSize = 0
        Me.btnNextPageAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPageAbout.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPageAbout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnNextPageAbout.Location = New System.Drawing.Point(787, -11)
        Me.btnNextPageAbout.Name = "btnNextPageAbout"
        Me.btnNextPageAbout.Size = New System.Drawing.Size(95, 101)
        Me.btnNextPageAbout.TabIndex = 25
        Me.btnNextPageAbout.Text = ">"
        Me.btnNextPageAbout.UseVisualStyleBackColor = False
        '
        'btnPreviousPageAbout
        '
        Me.btnPreviousPageAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnPreviousPageAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPreviousPageAbout.FlatAppearance.BorderSize = 0
        Me.btnPreviousPageAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviousPageAbout.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousPageAbout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPreviousPageAbout.Location = New System.Drawing.Point(12, 4)
        Me.btnPreviousPageAbout.Name = "btnPreviousPageAbout"
        Me.btnPreviousPageAbout.Size = New System.Drawing.Size(95, 101)
        Me.btnPreviousPageAbout.TabIndex = 26
        Me.btnPreviousPageAbout.Text = "<"
        Me.btnPreviousPageAbout.UseVisualStyleBackColor = False
        '
        'btnPreviousPageDecryption
        '
        Me.btnPreviousPageDecryption.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnPreviousPageDecryption.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPreviousPageDecryption.FlatAppearance.BorderSize = 0
        Me.btnPreviousPageDecryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviousPageDecryption.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousPageDecryption.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPreviousPageDecryption.Location = New System.Drawing.Point(56, 4)
        Me.btnPreviousPageDecryption.Name = "btnPreviousPageDecryption"
        Me.btnPreviousPageDecryption.Size = New System.Drawing.Size(95, 101)
        Me.btnPreviousPageDecryption.TabIndex = 27
        Me.btnPreviousPageDecryption.Text = "<"
        Me.btnPreviousPageDecryption.UseVisualStyleBackColor = False
        '
        'btnNextPageDecryption
        '
        Me.btnNextPageDecryption.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNextPageDecryption.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNextPageDecryption.FlatAppearance.BorderSize = 0
        Me.btnNextPageDecryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPageDecryption.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPageDecryption.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnNextPageDecryption.Location = New System.Drawing.Point(856, -13)
        Me.btnNextPageDecryption.Name = "btnNextPageDecryption"
        Me.btnNextPageDecryption.Size = New System.Drawing.Size(95, 101)
        Me.btnNextPageDecryption.TabIndex = 28
        Me.btnNextPageDecryption.Text = ">"
        Me.btnNextPageDecryption.UseVisualStyleBackColor = False
        '
        'pnlDecryption2
        '
        Me.pnlDecryption2.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.pnlDecryption2.Controls.Add(Me.lblVideo)
        Me.pnlDecryption2.Location = New System.Drawing.Point(63, 22)
        Me.pnlDecryption2.Name = "pnlDecryption2"
        Me.pnlDecryption2.Size = New System.Drawing.Size(745, 436)
        Me.pnlDecryption2.TabIndex = 29
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(140, 92)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(417, 324)
        Me.AxWindowsMediaPlayer1.TabIndex = 20
        '
        'lblVideo
        '
        Me.lblVideo.AutoSize = True
        Me.lblVideo.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideo.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblVideo.Location = New System.Drawing.Point(151, 24)
        Me.lblVideo.Name = "lblVideo"
        Me.lblVideo.Size = New System.Drawing.Size(434, 44)
        Me.lblVideo.TabIndex = 19
        Me.lblVideo.Text = "VIDEO - Kasiski Method"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'formVigenere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1106, 656)
        Me.Controls.Add(Me.pnlDemo)
        Me.Controls.Add(Me.btnNextPageDecryption)
        Me.Controls.Add(Me.btnPreviousPageDecryption)
        Me.Controls.Add(Me.btnNextPageAbout)
        Me.Controls.Add(Me.btnPreviousPageAbout)
        Me.Controls.Add(Me.btnPrintout)
        Me.Controls.Add(Me.btnCracking)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblVigenere)
        Me.Controls.Add(Me.pnlPrintout)
        Me.Controls.Add(Me.pnlDecryption2)
        Me.Controls.Add(Me.pnlAbout2)
        Me.Controls.Add(Me.pnlDecryption1)
        Me.Controls.Add(Me.pnlAbout1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formVigenere"
        Me.Text = "formVigenere"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDemo.ResumeLayout(False)
        Me.pnlDemo.PerformLayout()
        Me.pnlDecryption1.ResumeLayout(False)
        Me.pnlDecryption1.PerformLayout()
        Me.pnlAbout1.ResumeLayout(False)
        Me.pnlAbout1.PerformLayout()
        CType(Me.picVigenere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAlberti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrintout.ResumeLayout(False)
        Me.pnlPrintout.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVigenerePrintout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAbout2.ResumeLayout(False)
        Me.pnlAbout2.PerformLayout()
        CType(Me.picVigenereSquare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDecryption2.ResumeLayout(False)
        Me.pnlDecryption2.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblVigenere As Label
    Friend WithEvents pnlDemo As Panel
    Friend WithEvents lblKey As Label
    Friend WithEvents lblKeyLarge As Label
    Friend WithEvents lblCiphertext As Label
    Friend WithEvents lblPlaintext As Label
    Friend WithEvents txtCiphertext As TextBox
    Friend WithEvents txtPlaintext As TextBox
    Friend WithEvents btnPrintout As Button
    Friend WithEvents btnCracking As Button
    Friend WithEvents btnDemo As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents pnlDecryption1 As Panel
    Friend WithEvents lblVigenereDecryption As Label
    Friend WithEvents pnlAbout1 As Panel
    Friend WithEvents picAlberti As PictureBox
    Friend WithEvents lblVigenereInfo1 As Label
    Friend WithEvents pnlPrintout As Panel
    Friend WithEvents lblPrintoutExplanation As Label
    Friend WithEvents picHidden As PictureBox
    Friend WithEvents picVigenerePrintout As PictureBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents picVigenere As PictureBox
    Friend WithEvents lblVigenereCaption As Label
    Friend WithEvents lblAlbertiCaption As Label
    Friend WithEvents pnlAbout2 As Panel
    Friend WithEvents lblVigenereInfo2 As Label
    Friend WithEvents btnNextPageAbout As Button
    Friend WithEvents btnPreviousPageAbout As Button
    Friend WithEvents picVigenereSquare As PictureBox
    Friend WithEvents lblVigenereInfo3 As Label
    Friend WithEvents lblVigenereSquareCaption As Label
    Friend WithEvents txtKey As TextBox
    Friend WithEvents lblResultAdditionSubscript As Label
    Friend WithEvents lblResultAddition As Label
    Friend WithEvents lblEqualsAddition As Label
    Friend WithEvents lblPlusAddition As Label
    Friend WithEvents lblKeyAdditionSubscript As Label
    Friend WithEvents lblPlaintextAdditionSubscript As Label
    Friend WithEvents lblKeyAddition As Label
    Friend WithEvents lblPlaintextAddition As Label
    Friend WithEvents btnPreviousPageDecryption As Button
    Friend WithEvents btnNextPageDecryption As Button
    Friend WithEvents pnlDecryption2 As Panel
    Friend WithEvents lblVideo As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
End Class
