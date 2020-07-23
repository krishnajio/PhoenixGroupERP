<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusermgt
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtrepass = New System.Windows.Forms.TextBox
        Me.cmbrole = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.dguserinfo = New System.Windows.Forms.DataGridView
        Me.cmbdept = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.dguserinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Retype password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Role:"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(148, 43)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(184, 24)
        Me.txtusername.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(148, 70)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(184, 24)
        Me.txtpassword.TabIndex = 3
        '
        'txtrepass
        '
        Me.txtrepass.Location = New System.Drawing.Point(148, 97)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepass.Size = New System.Drawing.Size(184, 24)
        Me.txtrepass.TabIndex = 4
        '
        'cmbrole
        '
        Me.cmbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrole.FormattingEnabled = True
        Me.cmbrole.Items.AddRange(New Object() {"Admin", "Operator", "Viewer", "Cheque Opr", "Limited", "Viewer Level-1", "MIS", "SALE", "PURCHASE", "EXPENSES", "BANK", "OTHER"})
        Me.cmbrole.Location = New System.Drawing.Point(148, 125)
        Me.cmbrole.Name = "cmbrole"
        Me.cmbrole.Size = New System.Drawing.Size(184, 25)
        Me.cmbrole.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(23, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 46)
        Me.Panel1.TabIndex = 12
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(270, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(56, 31)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(207, 5)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(57, 31)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(138, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(64, 31)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(69, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(64, 31)
        Me.btnmodify.TabIndex = 1
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(10, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(52, 31)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dguserinfo
        '
        Me.dguserinfo.AllowUserToAddRows = False
        Me.dguserinfo.AllowUserToDeleteRows = False
        Me.dguserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguserinfo.Location = New System.Drawing.Point(13, 266)
        Me.dguserinfo.Name = "dguserinfo"
        Me.dguserinfo.ReadOnly = True
        Me.dguserinfo.Size = New System.Drawing.Size(361, 196)
        Me.dguserinfo.TabIndex = 13
        '
        'cmbdept
        '
        Me.cmbdept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdept.FormattingEnabled = True
        Me.cmbdept.Items.AddRange(New Object() {"SALE", "PURCHASE", "EXPENSES", "BANK", "CASH COUNTER", "OTHER"})
        Me.cmbdept.Location = New System.Drawing.Point(148, 154)
        Me.cmbdept.Name = "cmbdept"
        Me.cmbdept.Size = New System.Drawing.Size(184, 25)
        Me.cmbdept.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Department:"
        '
        'frmusermgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(389, 491)
        Me.Controls.Add(Me.cmbdept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dguserinfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbrole)
        Me.Controls.Add(Me.txtrepass)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmusermgt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmusermgt"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dguserinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtrepass As System.Windows.Forms.TextBox
    Friend WithEvents cmbrole As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents dguserinfo As System.Windows.Forms.DataGridView
    Friend WithEvents cmbdept As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
