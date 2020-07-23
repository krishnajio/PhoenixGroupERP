<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankState3
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.cmbacchead = New System.Windows.Forms.ComboBox
        Me.cmbacccode = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblopen = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgbankstate = New System.Windows.Forms.DataGridView
        Me.edate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHQNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WITHDRAWAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEPOSIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BALANCE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.issuedate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.entryid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vou_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtfrom1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnsearch = New System.Windows.Forms.Button
        Me.rdamt = New System.Windows.Forms.RadioButton
        Me.txtfind = New System.Windows.Forms.TextBox
        Me.rdchqno = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.rddate = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        CType(Me.dgbankstate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(519, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 31)
        Me.Button1.TabIndex = 174
        Me.Button1.Text = "&Update Statement"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(645, 503)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 31)
        Me.Button4.TabIndex = 173
        Me.Button4.Text = "&Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbacchead
        '
        Me.cmbacchead.BackColor = System.Drawing.Color.White
        Me.cmbacchead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacchead.FormattingEnabled = True
        Me.cmbacchead.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacchead.Location = New System.Drawing.Point(221, 42)
        Me.cmbacchead.MaxLength = 50
        Me.cmbacchead.Name = "cmbacchead"
        Me.cmbacchead.Size = New System.Drawing.Size(264, 21)
        Me.cmbacchead.TabIndex = 167
        '
        'cmbacccode
        '
        Me.cmbacccode.BackColor = System.Drawing.Color.White
        Me.cmbacccode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacccode.FormattingEnabled = True
        Me.cmbacccode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacccode.Location = New System.Drawing.Point(98, 42)
        Me.cmbacccode.MaxLength = 50
        Me.cmbacccode.Name = "cmbacccode"
        Me.cmbacccode.Size = New System.Drawing.Size(117, 21)
        Me.cmbacccode.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 172
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
        Me.Label5.Size = New System.Drawing.Size(709, 31)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "Bank Statement Entry"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblopen
        '
        Me.lblopen.AutoSize = True
        Me.lblopen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblopen.Location = New System.Drawing.Point(99, 67)
        Me.lblopen.Name = "lblopen"
        Me.lblopen.Size = New System.Drawing.Size(50, 16)
        Me.lblopen.TabIndex = 170
        Me.lblopen.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Opening :"
        '
        'dgbankstate
        '
        Me.dgbankstate.AllowUserToAddRows = False
        Me.dgbankstate.AllowUserToOrderColumns = True
        Me.dgbankstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbankstate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.edate, Me.CHQNO, Me.WITHDRAWAL, Me.DEPOSIT, Me.BALANCE, Me.issuedate, Me.entryid, Me.vou_no})
        Me.dgbankstate.Location = New System.Drawing.Point(7, 161)
        Me.dgbankstate.Name = "dgbankstate"
        Me.dgbankstate.RowTemplate.Height = 20
        Me.dgbankstate.Size = New System.Drawing.Size(689, 336)
        Me.dgbankstate.TabIndex = 168
        '
        'edate
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "dd/MM/yy"
        Me.edate.DefaultCellStyle = DataGridViewCellStyle1
        Me.edate.HeaderText = "Entry Date"
        Me.edate.MaxInputLength = 8
        Me.edate.Name = "edate"
        '
        'CHQNO
        '
        Me.CHQNO.HeaderText = "CHEQUE NO"
        Me.CHQNO.MaxInputLength = 20
        Me.CHQNO.Name = "CHQNO"
        Me.CHQNO.Width = 70
        '
        'WITHDRAWAL
        '
        Me.WITHDRAWAL.HeaderText = "WITHDRAWAL"
        Me.WITHDRAWAL.MaxInputLength = 20
        Me.WITHDRAWAL.Name = "WITHDRAWAL"
        Me.WITHDRAWAL.Width = 80
        '
        'DEPOSIT
        '
        Me.DEPOSIT.HeaderText = "DEPOSIT"
        Me.DEPOSIT.MaxInputLength = 20
        Me.DEPOSIT.Name = "DEPOSIT"
        Me.DEPOSIT.Width = 70
        '
        'BALANCE
        '
        Me.BALANCE.HeaderText = "BALANCE"
        Me.BALANCE.MaxInputLength = 20
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.Width = 70
        '
        'issuedate
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.issuedate.DefaultCellStyle = DataGridViewCellStyle2
        Me.issuedate.HeaderText = "ISSUE DATE"
        Me.issuedate.MaxInputLength = 15
        Me.issuedate.Name = "issuedate"
        Me.issuedate.ReadOnly = True
        '
        'entryid
        '
        Me.entryid.HeaderText = "Entry ID"
        Me.entryid.Name = "entryid"
        Me.entryid.ReadOnly = True
        Me.entryid.Width = 50
        '
        'vou_no
        '
        Me.vou_no.HeaderText = "Voucher No"
        Me.vou_no.Name = "vou_no"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtfrom1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(197, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 173)
        Me.Panel1.TabIndex = 175
        Me.Panel1.Visible = False
        '
        'dtfrom1
        '
        Me.dtfrom1.CustomFormat = "dd/MMM/yy"
        Me.dtfrom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom1.Location = New System.Drawing.Point(139, 50)
        Me.dtfrom1.Name = "dtfrom1"
        Me.dtfrom1.Size = New System.Drawing.Size(95, 20)
        Me.dtfrom1.TabIndex = 179
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Date From :"
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(139, 87)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(95, 20)
        Me.dtto.TabIndex = 177
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "Date to :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(232, 127)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 31)
        Me.Button2.TabIndex = 174
        Me.Button2.Text = "&OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(336, 84)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(95, 20)
        Me.dtfrom.TabIndex = 175
        Me.dtfrom.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 15)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Statement Date :"
        Me.Label8.Visible = False
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(104, 126)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(87, 25)
        Me.btnsearch.TabIndex = 180
        Me.btnsearch.Text = "Find"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'rdamt
        '
        Me.rdamt.AutoSize = True
        Me.rdamt.ForeColor = System.Drawing.Color.Crimson
        Me.rdamt.Location = New System.Drawing.Point(105, 86)
        Me.rdamt.Name = "rdamt"
        Me.rdamt.Size = New System.Drawing.Size(61, 17)
        Me.rdamt.TabIndex = 179
        Me.rdamt.Text = "Amount"
        Me.rdamt.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfind.Location = New System.Drawing.Point(72, 105)
        Me.txtfind.MaxLength = 15
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(117, 20)
        Me.txtfind.TabIndex = 178
        '
        'rdchqno
        '
        Me.rdchqno.AutoSize = True
        Me.rdchqno.Checked = True
        Me.rdchqno.ForeColor = System.Drawing.Color.Crimson
        Me.rdchqno.Location = New System.Drawing.Point(27, 86)
        Me.rdchqno.Name = "rdchqno"
        Me.rdchqno.Size = New System.Drawing.Size(82, 17)
        Me.rdchqno.TabIndex = 177
        Me.rdchqno.TabStop = True
        Me.rdchqno.Text = "Cheque No."
        Me.rdchqno.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "Find:"
        '
        'rddate
        '
        Me.rddate.AutoSize = True
        Me.rddate.ForeColor = System.Drawing.Color.Crimson
        Me.rddate.Location = New System.Drawing.Point(168, 86)
        Me.rddate.Name = "rddate"
        Me.rddate.Size = New System.Drawing.Size(48, 17)
        Me.rddate.TabIndex = 181
        Me.rddate.Text = "Date"
        Me.rddate.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(225, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 25)
        Me.Button3.TabIndex = 183
        Me.Button3.Text = "Previous Date"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(342, 108)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 25)
        Me.Button5.TabIndex = 182
        Me.Button5.Text = "Next Date"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'frmBankState3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(709, 537)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.rddate)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rdamt)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.rdchqno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmbacchead)
        Me.Controls.Add(Me.cmbacccode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblopen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgbankstate)
        Me.Name = "frmBankState3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Statement"
        CType(Me.dgbankstate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmbacchead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacccode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblopen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgbankstate As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents edate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHQNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WITHDRAWAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPOSIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents issuedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents entryid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vou_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents rdamt As System.Windows.Forms.RadioButton
    Friend WithEvents txtfind As System.Windows.Forms.TextBox
    Friend WithEvents rdchqno As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rddate As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents dtfrom1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
