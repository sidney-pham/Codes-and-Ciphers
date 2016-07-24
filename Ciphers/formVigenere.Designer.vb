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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblVigenere = New System.Windows.Forms.Label()
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
        Me.btnBack.Location = New System.Drawing.Point(95, 304)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(215, 68)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "< MAIN MENU"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblVigenere
        '
        Me.lblVigenere.AutoSize = True
        Me.lblVigenere.Font = New System.Drawing.Font("Century Gothic", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigenere.ForeColor = System.Drawing.Color.Silver
        Me.lblVigenere.Location = New System.Drawing.Point(222, 76)
        Me.lblVigenere.Name = "lblVigenere"
        Me.lblVigenere.Size = New System.Drawing.Size(489, 63)
        Me.lblVigenere.TabIndex = 9
        Me.lblVigenere.Text = " VIGENÈRE CIPHER"
        '
        'formVigenere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1106, 656)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblVigenere)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formVigenere"
        Me.Text = "formVigenere"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblVigenere As Label
End Class
