<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRVoucherFeeding
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChknewCustomer = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.dgCrVoucher = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Accode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chequeno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vouno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtvdate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblcrsum = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbvou_type = New System.Windows.Forms.ComboBox
        CType(Me.dgCrVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(978, 31)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "CR Voucher Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChknewCustomer
        '
        Me.ChknewCustomer.AutoSize = True
        Me.ChknewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChknewCustomer.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.ChknewCustomer.Location = New System.Drawing.Point(523, 36)
        Me.ChknewCustomer.Name = "ChknewCustomer"
        Me.ChknewCustomer.Size = New System.Drawing.Size(167, 17)
        Me.ChknewCustomer.TabIndex = 94
        Me.ChknewCustomer.Text = "Add New Customer Head"
        Me.ChknewCustomer.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox2.Location = New System.Drawing.Point(380, 36)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox2.TabIndex = 93
        Me.CheckBox2.Text = "Add New Party Head"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox1.Location = New System.Drawing.Point(244, 36)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox1.TabIndex = 92
        Me.CheckBox1.Text = "Add New Gen Head"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dgCrVoucher
        '
        Me.dgCrVoucher.AllowUserToAddRows = False
        Me.dgCrVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCrVoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.Accode, Me.acname, Me.narration, Me.chequeno, Me.amount, Me.vouno})
        Me.dgCrVoucher.Location = New System.Drawing.Point(-13, 122)
        Me.dgCrVoucher.Name = "dgCrVoucher"
        Me.dgCrVoucher.RowTemplate.Height = 20
        Me.dgCrVoucher.Size = New System.Drawing.Size(820, 449)
        Me.dgCrVoucher.TabIndex = 90
        '
        'srno
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srno.DefaultCellStyle = DataGridViewCellStyle1
        Me.srno.HeaderText = "Sr. No."
        Me.srno.MaxInputLength = 2
        Me.srno.Name = "srno"
        Me.srno.Width = 50
        '
        'Accode
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = "-"
        Me.Accode.DefaultCellStyle = DataGridViewCellStyle2
        Me.Accode.HeaderText = "A/C Code"
        Me.Accode.MaxInputLength = 10
        Me.Accode.Name = "Accode"
        Me.Accode.Width = 80
        '
        'acname
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acname.DefaultCellStyle = DataGridViewCellStyle3
        Me.acname.HeaderText = "A/C Name"
        Me.acname.MaxInputLength = 30
        Me.acname.Name = "acname"
        Me.acname.Width = 200
        '
        'narration
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.narration.DefaultCellStyle = DataGridViewCellStyle4
        Me.narration.HeaderText = "Narration"
        Me.narration.MaxInputLength = 180
        Me.narration.Name = "narration"
        Me.narration.Width = 200
        '
        'chequeno
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chequeno.DefaultCellStyle = DataGridViewCellStyle5
        Me.chequeno.HeaderText = "Cheque No."
        Me.chequeno.MaxInputLength = 15
        Me.chequeno.Name = "chequeno"
        Me.chequeno.Width = 80
        '
        'amount
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.amount.HeaderText = "Amount"
        Me.amount.MaxInputLength = 18
        Me.amount.Name = "amount"
        Me.amount.Width = 80
        '
        'vouno
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vouno.DefaultCellStyle = DataGridViewCellStyle7
        Me.vouno.HeaderText = "Voucher No."
        Me.vouno.Name = "vouno"
        Me.vouno.ReadOnly = True
        Me.vouno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.vouno.Width = 75
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(131, 36)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(101, 20)
        Me.dtvdate.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Voucher Date :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblcrsum)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Location = New System.Drawing.Point(1, 583)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 43)
        Me.Panel1.TabIndex = 95
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(385, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 28)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "&Print CR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblcrsum
        '
        Me.lblcrsum.AutoSize = True
        Me.lblcrsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrsum.Location = New System.Drawing.Point(752, 11)
        Me.lblcrsum.Name = "lblcrsum"
        Me.lblcrsum.Size = New System.Drawing.Size(15, 15)
        Me.lblcrsum.TabIndex = 52
        Me.lblcrsum.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(672, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Total Cr. :"
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(463, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(54, 28)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(232, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(58, 28)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(294, 5)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(85, 28)
        Me.btnreset.TabIndex = 8
        Me.btnreset.Text = "CR->&Debit"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "CR Voucher Type :"
        '
        'cmbvou_type
        '
        Me.cmbvou_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvou_type.FormattingEnabled = True
        Me.cmbvou_type.Location = New System.Drawing.Point(131, 64)
        Me.cmbvou_type.Name = "cmbvou_type"
        Me.cmbvou_type.Size = New System.Drawing.Size(131, 21)
        Me.cmbvou_type.TabIndex = 97
        '
        'CRVoucherFeeding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(978, 670)
        Me.Controls.Add(Me.cmbvou_type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ChknewCustomer)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.dgCrVoucher)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CRVoucherFeeding"
        Me.Text = "CRVoucherFeeding"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCrVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChknewCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Public WithEvents dgCrVoucher As System.Windows.Forms.DataGridView
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblcrsum As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chequeno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vouno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbvou_type As System.Windows.Forms.ComboBox
End Class
