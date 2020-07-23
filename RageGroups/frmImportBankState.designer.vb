<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportBankState
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button4 = New System.Windows.Forms.Button
        Me.cmbacchead = New System.Windows.Forms.ComboBox
        Me.cmbacccode = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblopen = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.txtfilename = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnsave = New System.Windows.Forms.Button
        Me.rdsingle = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdtwo = New System.Windows.Forms.RadioButton
        Me.txtdtformat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdtsep = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.detail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.entryid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.issuedate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BALANCE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEPOSIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WITHDRAWAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHQNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.edate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgbankstate = New System.Windows.Forms.DataGridView
        CType(Me.dgbankstate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(645, 506)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 31)
        Me.Button4.TabIndex = 171
        Me.Button4.Text = "&Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbacchead
        '
        Me.cmbacchead.BackColor = System.Drawing.Color.White
        Me.cmbacchead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacchead.FormattingEnabled = True
        Me.cmbacchead.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacchead.Location = New System.Drawing.Point(221, 45)
        Me.cmbacchead.MaxLength = 50
        Me.cmbacchead.Name = "cmbacchead"
        Me.cmbacchead.Size = New System.Drawing.Size(264, 21)
        Me.cmbacchead.TabIndex = 165
        '
        'cmbacccode
        '
        Me.cmbacccode.BackColor = System.Drawing.Color.White
        Me.cmbacccode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacccode.FormattingEnabled = True
        Me.cmbacccode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacccode.Location = New System.Drawing.Point(98, 45)
        Me.cmbacccode.MaxLength = 50
        Me.cmbacccode.Name = "cmbacccode"
        Me.cmbacccode.Size = New System.Drawing.Size(117, 21)
        Me.cmbacccode.TabIndex = 164
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Bank A/c :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(628, 31)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Import Bank Statement"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblopen
        '
        Me.lblopen.AutoSize = True
        Me.lblopen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblopen.Location = New System.Drawing.Point(99, 70)
        Me.lblopen.Name = "lblopen"
        Me.lblopen.Size = New System.Drawing.Size(50, 16)
        Me.lblopen.TabIndex = 168
        Me.lblopen.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Opening :"
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(563, 69)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(56, 31)
        Me.btnclose.TabIndex = 173
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(413, 69)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(72, 31)
        Me.btnreset.TabIndex = 172
        Me.btnreset.Text = "&Import"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'txtfilename
        '
        Me.txtfilename.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfilename.Location = New System.Drawing.Point(98, 90)
        Me.txtfilename.MaxLength = 40
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(229, 22)
        Me.txtfilename.TabIndex = 174
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "File Name :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(333, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 26)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "&Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.xls"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(487, 69)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(72, 31)
        Me.btnsave.TabIndex = 177
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'rdsingle
        '
        Me.rdsingle.AutoSize = True
        Me.rdsingle.Checked = True
        Me.rdsingle.Location = New System.Drawing.Point(100, 118)
        Me.rdsingle.Name = "rdsingle"
        Me.rdsingle.Size = New System.Drawing.Size(96, 17)
        Me.rdsingle.TabIndex = 178
        Me.rdsingle.TabStop = True
        Me.rdsingle.Text = "One Col (W/D)"
        Me.rdsingle.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Statement Type :"
        '
        'rdtwo
        '
        Me.rdtwo.AutoSize = True
        Me.rdtwo.Location = New System.Drawing.Point(196, 118)
        Me.rdtwo.Name = "rdtwo"
        Me.rdtwo.Size = New System.Drawing.Size(97, 17)
        Me.rdtwo.TabIndex = 180
        Me.rdtwo.Text = "Two Col (W/D)"
        Me.rdtwo.UseVisualStyleBackColor = True
        '
        'txtdtformat
        '
        Me.txtdtformat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdtformat.Location = New System.Drawing.Point(98, 140)
        Me.txtdtformat.MaxLength = 40
        Me.txtdtformat.Name = "txtdtformat"
        Me.txtdtformat.Size = New System.Drawing.Size(82, 22)
        Me.txtdtformat.TabIndex = 181
        Me.txtdtformat.Text = "DD/MM/YY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 182
        Me.Label4.Text = "Date Format :"
        '
        'txtdtsep
        '
        Me.txtdtsep.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdtsep.Location = New System.Drawing.Point(251, 140)
        Me.txtdtsep.MaxLength = 40
        Me.txtdtsep.Name = "txtdtsep"
        Me.txtdtsep.Size = New System.Drawing.Size(23, 22)
        Me.txtdtsep.TabIndex = 183
        Me.txtdtsep.Text = "/"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "Separator :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(543, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 31)
        Me.Button2.TabIndex = 185
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(299, 131)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 22)
        Me.TextBox1.TabIndex = 186
        Me.TextBox1.Visible = False
        '
        'detail
        '
        Me.detail.HeaderText = "Detail"
        Me.detail.Name = "detail"
        '
        'entryid
        '
        Me.entryid.HeaderText = "Entry ID"
        Me.entryid.Name = "entryid"
        Me.entryid.ReadOnly = True
        Me.entryid.Visible = False
        '
        'issuedate
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.issuedate.DefaultCellStyle = DataGridViewCellStyle1
        Me.issuedate.HeaderText = "ISSUE DATE"
        Me.issuedate.MaxInputLength = 15
        Me.issuedate.Name = "issuedate"
        Me.issuedate.ReadOnly = True
        '
        'BALANCE
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.BALANCE.DefaultCellStyle = DataGridViewCellStyle2
        Me.BALANCE.HeaderText = "BALANCE"
        Me.BALANCE.MaxInputLength = 20
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.Width = 70
        '
        'DEPOSIT
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DEPOSIT.DefaultCellStyle = DataGridViewCellStyle3
        Me.DEPOSIT.HeaderText = "DEPOSIT"
        Me.DEPOSIT.MaxInputLength = 20
        Me.DEPOSIT.Name = "DEPOSIT"
        Me.DEPOSIT.Width = 70
        '
        'WITHDRAWAL
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.WITHDRAWAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.WITHDRAWAL.HeaderText = "WITHDRAWAL"
        Me.WITHDRAWAL.MaxInputLength = 20
        Me.WITHDRAWAL.Name = "WITHDRAWAL"
        Me.WITHDRAWAL.Width = 80
        '
        'CHQNO
        '
        Me.CHQNO.HeaderText = "CHEQUE NO"
        Me.CHQNO.MaxInputLength = 20
        Me.CHQNO.Name = "CHQNO"
        Me.CHQNO.Width = 70
        '
        'edate
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "dd/MMM/yy"
        Me.edate.DefaultCellStyle = DataGridViewCellStyle5
        Me.edate.HeaderText = "Entry Date"
        Me.edate.MaxInputLength = 8
        Me.edate.Name = "edate"
        '
        'Srno
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Srno.DefaultCellStyle = DataGridViewCellStyle6
        Me.Srno.HeaderText = "Sr. No."
        Me.Srno.Name = "Srno"
        Me.Srno.Width = 50
        '
        'dgbankstate
        '
        Me.dgbankstate.AllowUserToAddRows = False
        Me.dgbankstate.AllowUserToOrderColumns = True
        Me.dgbankstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbankstate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Srno, Me.edate, Me.CHQNO, Me.WITHDRAWAL, Me.DEPOSIT, Me.BALANCE, Me.issuedate, Me.entryid, Me.detail})
        Me.dgbankstate.Location = New System.Drawing.Point(12, 176)
        Me.dgbankstate.Name = "dgbankstate"
        Me.dgbankstate.RowTemplate.Height = 20
        Me.dgbankstate.Size = New System.Drawing.Size(566, 324)
        Me.dgbankstate.TabIndex = 166
        '
        'frmImportBankState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 522)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtdtsep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdtformat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rdtwo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdsingle)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtfilename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmbacchead)
        Me.Controls.Add(Me.cmbacccode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblopen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgbankstate)
        Me.MaximizeBox = False
        Me.Name = "frmImportBankState"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmImportBankState"
        CType(Me.dgbankstate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmbacchead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacccode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblopen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents rdsingle As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdtwo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdtformat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdtsep As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents entryid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents issuedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPOSIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WITHDRAWAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHQNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgbankstate As System.Windows.Forms.DataGridView
End Class
