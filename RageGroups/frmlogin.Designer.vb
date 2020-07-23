<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.cmbcmpname = New System.Windows.Forms.ComboBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.cmbcmpid = New System.Windows.Forms.ComboBox()
        Me.dtCurrDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password :"
        '
        'txtpwd
        '
        Me.txtpwd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.ForeColor = System.Drawing.Color.Black
        Me.txtpwd.Location = New System.Drawing.Point(423, 275)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(226, 21)
        Me.txtpwd.TabIndex = 2
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(453, 330)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(60, 26)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "&Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(519, 330)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(56, 26)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'cmbcmpname
        '
        Me.cmbcmpname.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbcmpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbcmpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcmpname.ForeColor = System.Drawing.Color.Black
        Me.cmbcmpname.FormattingEnabled = True
        Me.cmbcmpname.Location = New System.Drawing.Point(331, 39)
        Me.cmbcmpname.Name = "cmbcmpname"
        Me.cmbcmpname.Size = New System.Drawing.Size(327, 231)
        Me.cmbcmpname.TabIndex = 1
        '
        'txtuname
        '
        Me.txtuname.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.ForeColor = System.Drawing.Color.Black
        Me.txtuname.Location = New System.Drawing.Point(428, 12)
        Me.txtuname.MaxLength = 15
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(221, 21)
        Me.txtuname.TabIndex = 0
        '
        'cmbcmpid
        '
        Me.cmbcmpid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbcmpid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcmpid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcmpid.FormattingEnabled = True
        Me.cmbcmpid.Location = New System.Drawing.Point(15, 284)
        Me.cmbcmpid.Name = "cmbcmpid"
        Me.cmbcmpid.Size = New System.Drawing.Size(256, 24)
        Me.cmbcmpid.TabIndex = 6
        Me.cmbcmpid.TabStop = False
        '
        'dtCurrDate
        '
        Me.dtCurrDate.CustomFormat = "dd/MMM/yy"
        Me.dtCurrDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCurrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtCurrDate.Location = New System.Drawing.Point(216, 314)
        Me.dtCurrDate.Name = "dtCurrDate"
        Me.dtCurrDate.Size = New System.Drawing.Size(90, 20)
        Me.dtCurrDate.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Session  :"
        '
        'cmbSession
        '
        Me.cmbSession.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSession.ForeColor = System.Drawing.Color.Black
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Location = New System.Drawing.Point(423, 300)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(226, 24)
        Me.cmbSession.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 367)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 21)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "GST READY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(661, 367)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSession)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.cmbcmpname)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbcmpid)
        Me.Controls.Add(Me.dtCurrDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents cmbcmpname As System.Windows.Forms.ComboBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents cmbcmpid As System.Windows.Forms.ComboBox
    Friend WithEvents dtCurrDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
