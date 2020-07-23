<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeReport
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
        Me.dgChequeReport = New System.Windows.Forms.DataGridView
        Me.issue_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chqno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rtno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bankcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bankname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.infou = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.finaldata = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Stopbounce = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ddcharge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sertax = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chqdocument = New System.Drawing.Printing.PrintDocument
        Me.chqprintpreview = New System.Windows.Forms.PrintDialog
        Me.chqsetup = New System.Windows.Forms.PageSetupDialog
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtchqto = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtissuefrom = New System.Windows.Forms.DateTimePicker
        Me.dtchqfrom = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtissueto = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtfavourof = New System.Windows.Forms.TextBox
        Me.txtchqno = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.btnshow = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        CType(Me.dgChequeReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgChequeReport
        '
        Me.dgChequeReport.AllowUserToAddRows = False
        Me.dgChequeReport.AllowUserToDeleteRows = False
        Me.dgChequeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgChequeReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.issue_date, Me.Column1, Me.chqno, Me.rtno, Me.name, Me.amount, Me.bankcode, Me.bankname, Me.infou, Me.finaldata, Me.Stopbounce, Me.ddcharge, Me.sertax})
        Me.dgChequeReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgChequeReport.Location = New System.Drawing.Point(0, 0)
        Me.dgChequeReport.Name = "dgChequeReport"
        Me.dgChequeReport.ReadOnly = True
        Me.dgChequeReport.Size = New System.Drawing.Size(806, 263)
        Me.dgChequeReport.TabIndex = 0
        '
        'issue_date
        '
        Me.issue_date.DataPropertyName = "Issue_date"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.issue_date.DefaultCellStyle = DataGridViewCellStyle1
        Me.issue_date.HeaderText = "Issue Date"
        Me.issue_date.Name = "issue_date"
        Me.issue_date.ReadOnly = True
        Me.issue_date.Width = 70
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Chq_date"
        DataGridViewCellStyle2.Format = "dd/MM/yy"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Che Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'chqno
        '
        Me.chqno.DataPropertyName = "Cheque_no"
        Me.chqno.HeaderText = "Chq No"
        Me.chqno.Name = "chqno"
        Me.chqno.ReadOnly = True
        Me.chqno.Width = 80
        '
        'rtno
        '
        Me.rtno.DataPropertyName = "receipt_id"
        Me.rtno.HeaderText = "RT NO"
        Me.rtno.Name = "rtno"
        Me.rtno.ReadOnly = True
        '
        'name
        '
        Me.name.DataPropertyName = "party_name"
        Me.name.HeaderText = "Name"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        Me.name.Width = 300
        '
        'amount
        '
        Me.amount.DataPropertyName = "Amount"
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 70
        '
        'bankcode
        '
        Me.bankcode.DataPropertyName = "BankAcc_code"
        Me.bankcode.HeaderText = "Bank Code"
        Me.bankcode.Name = "bankcode"
        Me.bankcode.ReadOnly = True
        '
        'bankname
        '
        Me.bankname.DataPropertyName = "account_head_name"
        Me.bankname.HeaderText = "Bank Name"
        Me.bankname.Name = "bankname"
        Me.bankname.ReadOnly = True
        '
        'infou
        '
        Me.infou.DataPropertyName = "favourof"
        Me.infou.HeaderText = "In Favoure of"
        Me.infou.Name = "infou"
        Me.infou.ReadOnly = True
        Me.infou.Width = 300
        '
        'finaldata
        '
        Me.finaldata.DataPropertyName = "final_date"
        Me.finaldata.HeaderText = "Final Data"
        Me.finaldata.Name = "finaldata"
        Me.finaldata.ReadOnly = True
        '
        'Stopbounce
        '
        Me.Stopbounce.DataPropertyName = "stop_bounce"
        Me.Stopbounce.HeaderText = "Stop Bounce"
        Me.Stopbounce.Name = "Stopbounce"
        Me.Stopbounce.ReadOnly = True
        '
        'ddcharge
        '
        Me.ddcharge.DataPropertyName = "Dd_charge"
        Me.ddcharge.HeaderText = "DD Charge"
        Me.ddcharge.Name = "ddcharge"
        Me.ddcharge.ReadOnly = True
        '
        'sertax
        '
        Me.sertax.DataPropertyName = "Service_tax"
        Me.sertax.HeaderText = "Service Tax"
        Me.sertax.Name = "sertax"
        Me.sertax.ReadOnly = True
        '
        'chqprintpreview
        '
        Me.chqprintpreview.UseEXDialog = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Bank Code"
        '
        'dtchqto
        '
        Me.dtchqto.CustomFormat = "dd/MMM/yyyy"
        Me.dtchqto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtchqto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtchqto.Location = New System.Drawing.Point(284, 94)
        Me.dtchqto.Name = "dtchqto"
        Me.dtchqto.Size = New System.Drawing.Size(118, 20)
        Me.dtchqto.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Issue  Date From: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(252, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "To:"
        '
        'dtissuefrom
        '
        Me.dtissuefrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtissuefrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtissuefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtissuefrom.Location = New System.Drawing.Point(135, 117)
        Me.dtissuefrom.Name = "dtissuefrom"
        Me.dtissuefrom.Size = New System.Drawing.Size(114, 20)
        Me.dtissuefrom.TabIndex = 20
        '
        'dtchqfrom
        '
        Me.dtchqfrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtchqfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtchqfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtchqfrom.Location = New System.Drawing.Point(136, 93)
        Me.dtchqfrom.Name = "dtchqfrom"
        Me.dtchqfrom.Size = New System.Drawing.Size(113, 20)
        Me.dtchqfrom.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(252, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cheque Date From: "
        '
        'dtissueto
        '
        Me.dtissueto.CustomFormat = "dd/MMM/yyyy"
        Me.dtissueto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtissueto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtissueto.Location = New System.Drawing.Point(284, 118)
        Me.dtissueto.Name = "dtissueto"
        Me.dtissueto.Size = New System.Drawing.Size(118, 20)
        Me.dtissueto.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(393, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Favour of"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cheque No"
        '
        'txtfavourof
        '
        Me.txtfavourof.Location = New System.Drawing.Point(392, 33)
        Me.txtfavourof.MaxLength = 30
        Me.txtfavourof.Name = "txtfavourof"
        Me.txtfavourof.Size = New System.Drawing.Size(273, 20)
        Me.txtfavourof.TabIndex = 24
        '
        'txtchqno
        '
        Me.txtchqno.Location = New System.Drawing.Point(11, 33)
        Me.txtchqno.MaxLength = 15
        Me.txtchqno.Name = "txtchqno"
        Me.txtchqno.Size = New System.Drawing.Size(101, 20)
        Me.txtchqno.TabIndex = 10
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(116, 33)
        Me.txtname.MaxLength = 45
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(271, 20)
        Me.txtname.TabIndex = 27
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(411, 74)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(61, 27)
        Me.btnshow.TabIndex = 11
        Me.btnshow.Text = "S&how"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = " Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(604, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 27)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(539, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 27)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "&Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(476, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 27)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "&Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(11, 68)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(101, 21)
        Me.cmbacheadcode.TabIndex = 153
        '
        'cmbacheadname
        '
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(116, 68)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(284, 21)
        Me.cmbacheadname.TabIndex = 154
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbacheadname)
        Me.GroupBox1.Controls.Add(Me.cmbacheadcode)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnshow)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtchqno)
        Me.GroupBox1.Controls.Add(Me.txtfavourof)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtissueto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtchqfrom)
        Me.GroupBox1.Controls.Add(Me.dtissuefrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtchqto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 417)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 142)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(713, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 27)
        Me.Button4.TabIndex = 157
        Me.Button4.Text = "S&how"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(115, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Bank Name"
        '
        'frmChequeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(806, 541)
        Me.Controls.Add(Me.dgChequeReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        'Me.name = "frmChequeReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgChequeReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgChequeReport As System.Windows.Forms.DataGridView
    Friend WithEvents chqdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents chqprintpreview As System.Windows.Forms.PrintDialog
    Friend WithEvents chqsetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtchqto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtissuefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtchqfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtissueto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfavourof As System.Windows.Forms.TextBox
    Friend WithEvents txtchqno As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents issue_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chqno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bankcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bankname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents infou As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents finaldata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stopbounce As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ddcharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sertax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
