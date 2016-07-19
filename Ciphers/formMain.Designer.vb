<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Me.components = New System.ComponentModel.Container()
        Me.lblHowTheyWork = New System.Windows.Forms.Label()
        Me.btnStraddlingCheckerboard = New System.Windows.Forms.Button()
        Me.btnVigenere = New System.Windows.Forms.Button()
        Me.btnCaesar = New System.Windows.Forms.Button()
        Me.lblCodesAndCiphers = New System.Windows.Forms.Label()
        Me.tmrHover = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblHowTheyWork
        '
        Me.lblHowTheyWork.AutoSize = True
        Me.lblHowTheyWork.Font = New System.Drawing.Font("ISOCPEUR", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowTheyWork.ForeColor = System.Drawing.Color.Silver
        Me.lblHowTheyWork.Location = New System.Drawing.Point(133, 223)
        Me.lblHowTheyWork.Name = "lblHowTheyWork"
        Me.lblHowTheyWork.Size = New System.Drawing.Size(412, 66)
        Me.lblHowTheyWork.TabIndex = 9
        Me.lblHowTheyWork.Text = "HOW THEY WORK:"
        '
        'btnStraddlingCheckerboard
        '
        Me.btnStraddlingCheckerboard.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnStraddlingCheckerboard.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnStraddlingCheckerboard.FlatAppearance.BorderSize = 0
        Me.btnStraddlingCheckerboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStraddlingCheckerboard.Font = New System.Drawing.Font("ISOCTEUR", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStraddlingCheckerboard.ForeColor = System.Drawing.Color.Black
        Me.btnStraddlingCheckerboard.Location = New System.Drawing.Point(586, 388)
        Me.btnStraddlingCheckerboard.Name = "btnStraddlingCheckerboard"
        Me.btnStraddlingCheckerboard.Size = New System.Drawing.Size(600, 111)
        Me.btnStraddlingCheckerboard.TabIndex = 8
        Me.btnStraddlingCheckerboard.Text = "THE STRADDLING CHECKERBOARD"
        Me.btnStraddlingCheckerboard.UseVisualStyleBackColor = False
        '
        'btnVigenere
        '
        Me.btnVigenere.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnVigenere.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVigenere.FlatAppearance.BorderSize = 0
        Me.btnVigenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVigenere.Font = New System.Drawing.Font("ISOCTEUR", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVigenere.ForeColor = System.Drawing.Color.Black
        Me.btnVigenere.Location = New System.Drawing.Point(586, 283)
        Me.btnVigenere.Name = "btnVigenere"
        Me.btnVigenere.Size = New System.Drawing.Size(600, 80)
        Me.btnVigenere.TabIndex = 7
        Me.btnVigenere.Text = "THE VIGENÈRE CIPHER"
        Me.btnVigenere.UseVisualStyleBackColor = False
        '
        'btnCaesar
        '
        Me.btnCaesar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCaesar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCaesar.FlatAppearance.BorderSize = 0
        Me.btnCaesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaesar.Font = New System.Drawing.Font("ISOCTEUR", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaesar.ForeColor = System.Drawing.Color.Black
        Me.btnCaesar.Location = New System.Drawing.Point(586, 197)
        Me.btnCaesar.Name = "btnCaesar"
        Me.btnCaesar.Size = New System.Drawing.Size(600, 80)
        Me.btnCaesar.TabIndex = 6
        Me.btnCaesar.Text = "THE CAESAR CIPHER"
        Me.btnCaesar.UseVisualStyleBackColor = False
        '
        'lblCodesAndCiphers
        '
        Me.lblCodesAndCiphers.AutoSize = True
        Me.lblCodesAndCiphers.Font = New System.Drawing.Font("ISOCPEUR", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodesAndCiphers.ForeColor = System.Drawing.Color.Black
        Me.lblCodesAndCiphers.Location = New System.Drawing.Point(108, 288)
        Me.lblCodesAndCiphers.Name = "lblCodesAndCiphers"
        Me.lblCodesAndCiphers.Size = New System.Drawing.Size(394, 60)
        Me.lblCodesAndCiphers.TabIndex = 5
        Me.lblCodesAndCiphers.Text = "Codes and Ciphers"
        '
        'tmrHover
        '
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1106, 656)
        Me.Controls.Add(Me.lblHowTheyWork)
        Me.Controls.Add(Me.btnStraddlingCheckerboard)
        Me.Controls.Add(Me.btnVigenere)
        Me.Controls.Add(Me.btnCaesar)
        Me.Controls.Add(Me.lblCodesAndCiphers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formMain"
        Me.Text = "formMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHowTheyWork As Label
    Friend WithEvents btnStraddlingCheckerboard As Button
    Friend WithEvents btnVigenere As Button
    Friend WithEvents btnCaesar As Button
    Friend WithEvents lblCodesAndCiphers As Label
    Friend WithEvents tmrHover As Timer
End Class
