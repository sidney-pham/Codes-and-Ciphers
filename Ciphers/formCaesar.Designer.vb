<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCaesar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCaesar))
        Me.lblCaesarCipher = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.btnCracking = New System.Windows.Forms.Button()
        Me.lblCaesarInfo1 = New System.Windows.Forms.Label()
        Me.pnlAbout = New System.Windows.Forms.Panel()
        Me.btnPrintout = New System.Windows.Forms.Button()
        Me.pnlDemo = New System.Windows.Forms.Panel()
        Me.txtPlaintext = New System.Windows.Forms.TextBox()
        Me.pnlCracking = New System.Windows.Forms.Panel()
        Me.lblCaesarCracking = New System.Windows.Forms.Label()
        Me.pnlPrintout = New System.Windows.Forms.Panel()
        Me.lblPrintout = New System.Windows.Forms.Label()
        Me.picCaesarDiagram = New System.Windows.Forms.PictureBox()
        Me.txtCiphertext = New System.Windows.Forms.TextBox()
        Me.pnlAbout.SuspendLayout()
        Me.pnlDemo.SuspendLayout()
        Me.pnlCracking.SuspendLayout()
        Me.pnlPrintout.SuspendLayout()
        CType(Me.picCaesarDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaesarCipher
        '
        Me.lblCaesarCipher.AutoSize = True
        Me.lblCaesarCipher.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaesarCipher.ForeColor = System.Drawing.Color.Silver
        Me.lblCaesarCipher.Location = New System.Drawing.Point(250, 23)
        Me.lblCaesarCipher.Name = "lblCaesarCipher"
        Me.lblCaesarCipher.Size = New System.Drawing.Size(429, 63)
        Me.lblCaesarCipher.TabIndex = 6
        Me.lblCaesarCipher.Text = "CAESAR CIPHER"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.SlateGray
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Silver
        Me.btnBack.Location = New System.Drawing.Point(12, 576)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "< MAIN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.SlateGray
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.Black
        Me.btnAbout.Location = New System.Drawing.Point(215, 89)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(113, 68)
        Me.btnAbout.TabIndex = 9
        Me.btnAbout.Text = "ABOUT"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnDemo
        '
        Me.btnDemo.BackColor = System.Drawing.Color.SlateGray
        Me.btnDemo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDemo.FlatAppearance.BorderSize = 0
        Me.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDemo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemo.ForeColor = System.Drawing.Color.Black
        Me.btnDemo.Location = New System.Drawing.Point(377, 89)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(113, 68)
        Me.btnDemo.TabIndex = 10
        Me.btnDemo.Text = "DEMO"
        Me.btnDemo.UseVisualStyleBackColor = False
        '
        'btnCracking
        '
        Me.btnCracking.BackColor = System.Drawing.Color.SlateGray
        Me.btnCracking.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCracking.FlatAppearance.BorderSize = 0
        Me.btnCracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCracking.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCracking.ForeColor = System.Drawing.Color.Black
        Me.btnCracking.Location = New System.Drawing.Point(528, 89)
        Me.btnCracking.Name = "btnCracking"
        Me.btnCracking.Size = New System.Drawing.Size(160, 68)
        Me.btnCracking.TabIndex = 11
        Me.btnCracking.Text = "CRACKING"
        Me.btnCracking.UseVisualStyleBackColor = False
        '
        'lblCaesarInfo1
        '
        Me.lblCaesarInfo1.AutoSize = True
        Me.lblCaesarInfo1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaesarInfo1.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCaesarInfo1.Location = New System.Drawing.Point(16, 26)
        Me.lblCaesarInfo1.Name = "lblCaesarInfo1"
        Me.lblCaesarInfo1.Size = New System.Drawing.Size(3269, 160)
        Me.lblCaesarInfo1.TabIndex = 0
        Me.lblCaesarInfo1.Text = resources.GetString("lblCaesarInfo1.Text")
        '
        'pnlAbout
        '
        Me.pnlAbout.Controls.Add(Me.picCaesarDiagram)
        Me.pnlAbout.Controls.Add(Me.lblCaesarInfo1)
        Me.pnlAbout.Location = New System.Drawing.Point(26, 148)
        Me.pnlAbout.Name = "pnlAbout"
        Me.pnlAbout.Size = New System.Drawing.Size(745, 436)
        Me.pnlAbout.TabIndex = 13
        '
        'btnPrintout
        '
        Me.btnPrintout.BackColor = System.Drawing.Color.SlateGray
        Me.btnPrintout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrintout.FlatAppearance.BorderSize = 0
        Me.btnPrintout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintout.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintout.ForeColor = System.Drawing.Color.Black
        Me.btnPrintout.Location = New System.Drawing.Point(723, 89)
        Me.btnPrintout.Name = "btnPrintout"
        Me.btnPrintout.Size = New System.Drawing.Size(160, 68)
        Me.btnPrintout.TabIndex = 14
        Me.btnPrintout.Text = "PRINT-OUT"
        Me.btnPrintout.UseVisualStyleBackColor = False
        '
        'pnlDemo
        '
        Me.pnlDemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDemo.Controls.Add(Me.txtCiphertext)
        Me.pnlDemo.Controls.Add(Me.txtPlaintext)
        Me.pnlDemo.Location = New System.Drawing.Point(21, 78)
        Me.pnlDemo.Name = "pnlDemo"
        Me.pnlDemo.Size = New System.Drawing.Size(798, 492)
        Me.pnlDemo.TabIndex = 15
        '
        'txtPlaintext
        '
        Me.txtPlaintext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaintext.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaintext.Location = New System.Drawing.Point(65, 108)
        Me.txtPlaintext.Multiline = True
        Me.txtPlaintext.Name = "txtPlaintext"
        Me.txtPlaintext.Size = New System.Drawing.Size(389, 275)
        Me.txtPlaintext.TabIndex = 0
        Me.txtPlaintext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlCracking
        '
        Me.pnlCracking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCracking.Controls.Add(Me.lblCaesarCracking)
        Me.pnlCracking.Location = New System.Drawing.Point(808, 51)
        Me.pnlCracking.Name = "pnlCracking"
        Me.pnlCracking.Size = New System.Drawing.Size(745, 436)
        Me.pnlCracking.TabIndex = 16
        '
        'lblCaesarCracking
        '
        Me.lblCaesarCracking.AutoSize = True
        Me.lblCaesarCracking.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaesarCracking.ForeColor = System.Drawing.Color.White
        Me.lblCaesarCracking.Location = New System.Drawing.Point(16, 26)
        Me.lblCaesarCracking.Name = "lblCaesarCracking"
        Me.lblCaesarCracking.Size = New System.Drawing.Size(141, 33)
        Me.lblCaesarCracking.TabIndex = 0
        Me.lblCaesarCracking.Text = "Cracking "
        '
        'pnlPrintout
        '
        Me.pnlPrintout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrintout.Controls.Add(Me.lblPrintout)
        Me.pnlPrintout.Location = New System.Drawing.Point(586, 621)
        Me.pnlPrintout.Name = "pnlPrintout"
        Me.pnlPrintout.Size = New System.Drawing.Size(745, 436)
        Me.pnlPrintout.TabIndex = 17
        '
        'lblPrintout
        '
        Me.lblPrintout.AutoSize = True
        Me.lblPrintout.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrintout.ForeColor = System.Drawing.Color.White
        Me.lblPrintout.Location = New System.Drawing.Point(16, 26)
        Me.lblPrintout.Name = "lblPrintout"
        Me.lblPrintout.Size = New System.Drawing.Size(124, 33)
        Me.lblPrintout.TabIndex = 0
        Me.lblPrintout.Text = "Print-out"
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
        'txtCiphertext
        '
        Me.txtCiphertext.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiphertext.Location = New System.Drawing.Point(472, 108)
        Me.txtCiphertext.Multiline = True
        Me.txtCiphertext.Name = "txtCiphertext"
        Me.txtCiphertext.Size = New System.Drawing.Size(389, 275)
        Me.txtCiphertext.TabIndex = 1
        Me.txtCiphertext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'formCaesar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1278, 825)
        Me.Controls.Add(Me.pnlCracking)
        Me.Controls.Add(Me.pnlPrintout)
        Me.Controls.Add(Me.pnlDemo)
        Me.Controls.Add(Me.btnPrintout)
        Me.Controls.Add(Me.pnlAbout)
        Me.Controls.Add(Me.btnCracking)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblCaesarCipher)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formCaesar"
        Me.Text = "formCaesar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlAbout.ResumeLayout(False)
        Me.pnlAbout.PerformLayout()
        Me.pnlDemo.ResumeLayout(False)
        Me.pnlDemo.PerformLayout()
        Me.pnlCracking.ResumeLayout(False)
        Me.pnlCracking.PerformLayout()
        Me.pnlPrintout.ResumeLayout(False)
        Me.pnlPrintout.PerformLayout()
        CType(Me.picCaesarDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaesarCipher As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnDemo As Button
    Friend WithEvents btnCracking As Button
    Friend WithEvents lblCaesarInfo1 As Label
    Friend WithEvents pnlAbout As Panel
    Friend WithEvents btnPrintout As Button
    Friend WithEvents txtPlaintext As TextBox
    Friend WithEvents pnlDemo As Panel
    Friend WithEvents pnlCracking As Panel
    Friend WithEvents lblCaesarCracking As Label
    Friend WithEvents pnlPrintout As Panel
    Friend WithEvents lblPrintout As Label
    Friend WithEvents picCaesarDiagram As PictureBox
    Friend WithEvents txtCiphertext As TextBox
End Class
