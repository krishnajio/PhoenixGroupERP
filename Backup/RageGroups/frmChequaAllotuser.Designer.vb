<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequaAllotuser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbacccode = New System.Windows.Forms.ComboBox
        Me.cmbacchead = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtchqnofrom = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtchqnoto = New System.Windows.Forms.TextBox
        Me.dtIssuedate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cmbbookno = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbuser = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Bank = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chqfrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chqto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Issuedate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chqrem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Uname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bookno = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(731, 31)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Cheque Allotment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Bank Name :"
        '
        'cmbacccode
        '
        Me.cmbacccode.BackColor = System.Drawing.Color.White
        Me.cmbacccode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacccode.FormattingEnabled = True
        Me.cmbacccode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacccode.Location = New System.Drawing.Point(142, 61)
        Me.cmbacccode.MaxLength = 50
        Me.cmbacccode.Name = "cmbacccode"
        Me.cmbacccode.Size = New System.Drawing.Size(100, 21)
        Me.cmbacccode.TabIndex = 72
        '
        'cmbacchead
        '
        Me.cmbacchead.BackColor = System.Drawing.Color.White
        Me.cmbacchead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacchead.FormattingEnabled = True
        Me.cmbacchead.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacchead.Location = New System.Drawing.Point(246, 61)
        Me.cmbacchead.MaxLength = 50
        Me.cmbacchead.Name = "cmbacchead"
        Me.cmbacchead.Size = New System.Drawing.Size(264, 21)
        Me.cmbacchead.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Cheque No. from :"
        '
        'txtchqnofrom
        '
        Me.txtchqnofrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchqnofrom.Location = New System.Drawing.Point(142, 135)
        Me.txtchqnofrom.Name = "txtchqnofrom"
        Me.txtchqnofrom.Size = New System.Drawing.Size(100, 20)
        Me.txtchqnofrom.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "to:"
        '
        'txtchqnoto
        '
        Me.txtchqnoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchqnoto.Location = New System.Drawing.Point(275, 135)
        Me.txtchqnoto.Name = "txtchqnoto"
        Me.txtchqnoto.Size = New System.Drawing.Size(100, 20)
        Me.txtchqnoto.TabIndex = 77
        '
        'dtIssuedate
        '
        Me.dtIssuedate.CustomFormat = "dd/MMM/yy"
        Me.dtIssuedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIssuedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtIssuedate.Location = New System.Drawing.Point(461, 35)
        Me.dtIssuedate.Name = "dtIssuedate"
        Me.dtIssuedate.Size = New System.Drawing.Size(100, 20)
        Me.dtIssuedate.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Allotmnet Date :"
        '
        'btnmodify
        '
        Me.btnmodify.Enabled = False
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(189, 163)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(67, 27)
        Me.btnmodify.TabIndex = 16
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(126, 163)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(59, 27)
        Me.btnsave.TabIndex = 15
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(334, 163)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(54, 27)
        Me.btnreset.TabIndex = 18
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(262, 163)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(66, 27)
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(394, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 27)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bank, Me.Chqfrom, Me.chqto, Me.Issuedate, Me.chqrem, Me.Uname, Me.Bookno})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 196)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(691, 184)
        Me.DataGridView1.TabIndex = 81
        '
        'cmbbookno
        '
        Me.cmbbookno.BackColor = System.Drawing.Color.White
        Me.cmbbookno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbookno.FormattingEnabled = True
        Me.cmbbookno.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbbookno.Location = New System.Drawing.Point(142, 111)
        Me.cmbbookno.MaxLength = 50
        Me.cmbbookno.Name = "cmbbookno"
        Me.cmbbookno.Size = New System.Drawing.Size(117, 21)
        Me.cmbbookno.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 15)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Cheque Book No. :"
        '
        'cmbuser
        '
        Me.cmbuser.BackColor = System.Drawing.Color.White
        Me.cmbuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbuser.FormattingEnabled = True
        Me.cmbuser.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbuser.Location = New System.Drawing.Point(142, 86)
        Me.cmbuser.MaxLength = 50
        Me.cmbuser.Name = "cmbuser"
        Me.cmbuser.Size = New System.Drawing.Size(368, 21)
        Me.cmbuser.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "User Name :"
        '
        'Bank
        '
        Me.Bank.HeaderText = "Bank"
        Me.Bank.Name = "Bank"
        Me.Bank.ReadOnly = True
        Me.Bank.Width = 200
        '
        'Chqfrom
        '
        Me.Chqfrom.HeaderText = "Cheque From"
        Me.Chqfrom.Name = "Chqfrom"
        Me.Chqfrom.ReadOnly = True
        Me.Chqfrom.Width = 70
        '
        'chqto
        '
        Me.chqto.HeaderText = "Cheque To"
        Me.chqto.Name = "chqto"
        Me.chqto.ReadOnly = True
        Me.chqto.Width = 70
        '
        'Issuedate
        '
        DataGridViewCellStyle1.Format = "dd/MMM/yy"
        Me.Issuedate.DefaultCellStyle = DataGridViewCellStyle1
        Me.Issuedate.HeaderText = "Issue Date"
        Me.Issuedate.Name = "Issuedate"
        Me.Issuedate.ReadOnly = True
        Me.Issuedate.Width = 70
        '
        'chqrem
        '
        Me.chqrem.HeaderText = "Cheque Remains"
        Me.chqrem.Name = "chqrem"
        Me.chqrem.ReadOnly = True
        Me.chqrem.Width = 70
        '
        'Uname
        '
        Me.Uname.HeaderText = "Uname"
        Me.Uname.Name = "Uname"
        Me.Uname.ReadOnly = True
        '
        'Bookno
        '
        Me.Bookno.HeaderText = "Book No"
        Me.Bookno.Name = "Bookno"
        Me.Bookno.ReadOnly = True
        '
        'frmChequaAllotuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(731, 388)
        Me.Controls.Add(Me.cmbuser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbbookno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnmodify)
        Me.Controls.Add(Me.dtIssuedate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.txtchqnoto)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtchqnofrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbacccode)
        Me.Controls.Add(Me.cmbacchead)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmChequaAllotuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Allotment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbacccode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacchead As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtchqnofrom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtchqnoto As System.Windows.Forms.TextBox
    Friend WithEvents dtIssuedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbbookno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbuser As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Bank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chqfrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chqto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Issuedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chqrem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bookno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
