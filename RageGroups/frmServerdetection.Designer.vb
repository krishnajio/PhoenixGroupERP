<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerdetection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpwd1 = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbserver = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncontinue = New System.Windows.Forms.Button()
        Me.txtdb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server Detection"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpwd1
        '
        Me.txtpwd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd1.Location = New System.Drawing.Point(199, 129)
        Me.txtpwd1.Name = "txtpwd1"
        Me.txtpwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd1.Size = New System.Drawing.Size(173, 22)
        Me.txtpwd1.TabIndex = 17
        Me.txtpwd1.Text = "ph@hoenix#g"
        '
        'txtpwd
        '
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(199, 101)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(173, 22)
        Me.txtpwd.TabIndex = 16
        Me.txtpwd.Text = "ph@hoenix#g"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(199, 72)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(173, 22)
        Me.txtusername.TabIndex = 15
        Me.txtusername.Text = "sa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Enter A Server User Name:"
        '
        'cmbserver
        '
        Me.cmbserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbserver.FormattingEnabled = True
        Me.cmbserver.Location = New System.Drawing.Point(199, 42)
        Me.cmbserver.Name = "cmbserver"
        Me.cmbserver.Size = New System.Drawing.Size(191, 24)
        Me.cmbserver.TabIndex = 11
        Me.cmbserver.Text = "192.168.0.130"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Select A Server Name:"
        '
        'btncontinue
        '
        Me.btncontinue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontinue.Location = New System.Drawing.Point(199, 239)
        Me.btncontinue.Name = "btncontinue"
        Me.btncontinue.Size = New System.Drawing.Size(97, 31)
        Me.btncontinue.TabIndex = 18
        Me.btncontinue.Text = "&Continue"
        Me.btncontinue.UseVisualStyleBackColor = True
        '
        'txtdb
        '
        Me.txtdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdb.Location = New System.Drawing.Point(199, 157)
        Me.txtdb.Name = "txtdb"
        Me.txtdb.Size = New System.Drawing.Size(173, 22)
        Me.txtdb.TabIndex = 19
        Me.txtdb.Text = "PhxGroupERP"
        '
        'frmServerdetection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(423, 343)
        Me.Controls.Add(Me.txtdb)
        Me.Controls.Add(Me.btncontinue)
        Me.Controls.Add(Me.txtpwd1)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbserver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmServerdetection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServerdetection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpwd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbserver As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncontinue As System.Windows.Forms.Button
    Friend WithEvents txtdb As System.Windows.Forms.TextBox
End Class
