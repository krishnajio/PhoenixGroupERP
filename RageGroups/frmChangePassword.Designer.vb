<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtrepass = New System.Windows.Forms.TextBox
        Me.btnmodify = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(164, 61)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(184, 20)
        Me.txtpassword.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.OliveDrab
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New Password:"
        '
        'txtrepass
        '
        Me.txtrepass.Location = New System.Drawing.Point(164, 88)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepass.Size = New System.Drawing.Size(184, 20)
        Me.txtrepass.TabIndex = 9
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(279, 114)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(71, 31)
        Me.btnmodify.TabIndex = 5
        Me.btnmodify.Text = "&Change"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.OliveDrab
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Retype password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OliveDrab
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Old  Password:"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(166, 28)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(184, 20)
        Me.txtOldPassword.TabIndex = 11
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Olive
        Me.ClientSize = New System.Drawing.Size(375, 154)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtrepass)
        Me.Controls.Add(Me.btnmodify)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtrepass As System.Windows.Forms.TextBox
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
End Class
