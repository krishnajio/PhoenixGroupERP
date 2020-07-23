<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleInvoiceWithDiscountOnAmout
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtinvoiceno = New System.Windows.Forms.TextBox
        Me.dtdate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.voutype = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgSaleVoucher = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pcname = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.freeper = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.freeqty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtHatchdate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.btn_modify = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ChknewCustomer = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.lblno = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.txtremark1 = New System.Windows.Forms.ComboBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.cmbsubgrp = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDiscountper = New System.Windows.Forms.TextBox
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtnetamount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.dgSaleVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Sold To:"
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtinvoiceno.Location = New System.Drawing.Point(89, 46)
        Me.txtinvoiceno.MaxLength = 18
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.ReadOnly = True
        Me.txtinvoiceno.Size = New System.Drawing.Size(80, 20)
        Me.txtinvoiceno.TabIndex = 0
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(275, 42)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(87, 21)
        Me.dtdate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Invoice Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Invoice No :"
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(275, 119)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(275, 21)
        Me.cmbacheadname.TabIndex = 5
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(549, 119)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbacheadcode.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Voucher Type:"
        '
        'voutype
        '
        Me.voutype.AutoSize = True
        Me.voutype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.voutype.Location = New System.Drawing.Point(465, 72)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(41, 15)
        Me.voutype.TabIndex = 101
        Me.voutype.Text = "SALE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Voucher No:"
        '
        'dgSaleVoucher
        '
        Me.dgSaleVoucher.AllowUserToAddRows = False
        Me.dgSaleVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSaleVoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.pcname, Me.qty, Me.rate, Me.Amount, Me.freeper, Me.freeqty})
        Me.dgSaleVoucher.Location = New System.Drawing.Point(1, 148)
        Me.dgSaleVoucher.Name = "dgSaleVoucher"
        Me.dgSaleVoucher.RowTemplate.Height = 20
        Me.dgSaleVoucher.Size = New System.Drawing.Size(680, 225)
        Me.dgSaleVoucher.TabIndex = 7
        '
        'srno
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srno.DefaultCellStyle = DataGridViewCellStyle1
        Me.srno.Frozen = True
        Me.srno.HeaderText = "Sr. No."
        Me.srno.MaxInputLength = 2
        Me.srno.Name = "srno"
        Me.srno.Width = 30
        '
        'pcname
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcname.DefaultCellStyle = DataGridViewCellStyle2
        Me.pcname.Frozen = True
        Me.pcname.HeaderText = "Product Name"
        Me.pcname.Name = "pcname"
        Me.pcname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pcname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.pcname.Width = 200
        '
        'qty
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.qty.Frozen = True
        Me.qty.HeaderText = "Qty"
        Me.qty.MaxInputLength = 15
        Me.qty.Name = "qty"
        '
        'rate
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rate.DefaultCellStyle = DataGridViewCellStyle4
        Me.rate.Frozen = True
        Me.rate.HeaderText = "Rate"
        Me.rate.MaxInputLength = 18
        Me.rate.Name = "rate"
        Me.rate.Width = 50
        '
        'Amount
        '
        Me.Amount.Frozen = True
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 125
        '
        'freeper
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.freeper.DefaultCellStyle = DataGridViewCellStyle5
        Me.freeper.Frozen = True
        Me.freeper.HeaderText = "Free Per"
        Me.freeper.MaxInputLength = 3
        Me.freeper.Name = "freeper"
        Me.freeper.ReadOnly = True
        Me.freeper.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.freeper.Width = 50
        '
        'freeqty
        '
        Me.freeqty.Frozen = True
        Me.freeqty.HeaderText = "Free Qty"
        Me.freeqty.Name = "freeqty"
        Me.freeqty.ReadOnly = True
        Me.freeqty.Width = 60
        '
        'dtHatchdate
        '
        Me.dtHatchdate.CustomFormat = "dd/MMM/yy"
        Me.dtHatchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtHatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHatchdate.Location = New System.Drawing.Point(89, 69)
        Me.dtHatchdate.Name = "dtHatchdate"
        Me.dtHatchdate.Size = New System.Drawing.Size(80, 21)
        Me.dtHatchdate.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Hatch Date :"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(197, 482)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(58, 28)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Station"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(89, 91)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(180, 21)
        Me.cmbAreaName.TabIndex = 3
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(275, 93)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(87, 21)
        Me.cmbAreaCode.TabIndex = 4
        '
        'btn_modify
        '
        Me.btn_modify.Enabled = False
        Me.btn_modify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify.Location = New System.Drawing.Point(261, 482)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(72, 28)
        Me.btn_modify.TabIndex = 11
        Me.btn_modify.Text = "&Modify"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(339, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 28)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&Print Inv."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(277, 119)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 21)
        Me.ComboBox1.TabIndex = 117
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(89, 117)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox2.TabIndex = 118
        Me.ComboBox2.TabStop = False
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.BackColor = System.Drawing.Color.White
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(89, 118)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox3.TabIndex = 119
        '
        'ChknewCustomer
        '
        Me.ChknewCustomer.AutoSize = True
        Me.ChknewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChknewCustomer.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.ChknewCustomer.Location = New System.Drawing.Point(511, 96)
        Me.ChknewCustomer.Name = "ChknewCustomer"
        Me.ChknewCustomer.Size = New System.Drawing.Size(167, 17)
        Me.ChknewCustomer.TabIndex = 121
        Me.ChknewCustomer.Text = "Add New Customer Head"
        Me.ChknewCustomer.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox2.Location = New System.Drawing.Point(367, 95)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox2.TabIndex = 120
        Me.CheckBox2.Text = "Add New Party Head"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'lblno
        '
        Me.lblno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblno.Location = New System.Drawing.Point(275, 67)
        Me.lblno.MaxLength = 18
        Me.lblno.Name = "lblno"
        Me.lblno.ReadOnly = True
        Me.lblno.Size = New System.Drawing.Size(87, 20)
        Me.lblno.TabIndex = 122
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox1.Location = New System.Drawing.Point(511, 74)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(150, 17)
        Me.CheckBox1.TabIndex = 123
        Me.CheckBox1.Text = "Update Rate / Free %"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtremark1
        '
        Me.txtremark1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtremark1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtremark1.BackColor = System.Drawing.Color.White
        Me.txtremark1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremark1.FormattingEnabled = True
        Me.txtremark1.Location = New System.Drawing.Point(539, 119)
        Me.txtremark1.Name = "txtremark1"
        Me.txtremark1.Size = New System.Drawing.Size(110, 21)
        Me.txtremark1.TabIndex = 124
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(437, 482)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(69, 28)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cmbsubgrp
        '
        Me.cmbsubgrp.FormattingEnabled = True
        Me.cmbsubgrp.Location = New System.Drawing.Point(549, 119)
        Me.cmbsubgrp.Name = "cmbsubgrp"
        Me.cmbsubgrp.Size = New System.Drawing.Size(100, 21)
        Me.cmbsubgrp.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(361, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Discount %"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label9.Location = New System.Drawing.Point(325, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 15)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Discount Amount"
        '
        'txtDiscountper
        '
        Me.txtDiscountper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountper.Location = New System.Drawing.Point(446, 379)
        Me.txtDiscountper.Name = "txtDiscountper"
        Me.txtDiscountper.Size = New System.Drawing.Size(100, 22)
        Me.txtDiscountper.TabIndex = 8
        Me.txtDiscountper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.BackColor = System.Drawing.Color.White
        Me.txtDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountAmount.Location = New System.Drawing.Point(446, 402)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.ReadOnly = True
        Me.txtDiscountAmount.Size = New System.Drawing.Size(100, 22)
        Me.txtDiscountAmount.TabIndex = 9
        Me.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Location = New System.Drawing.Point(1, 464)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 60)
        Me.Panel1.TabIndex = 131
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Ivory
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(682, 39)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Sale Invoice With  Discount on Amount"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnetamount
        '
        Me.txtnetamount.BackColor = System.Drawing.Color.White
        Me.txtnetamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnetamount.Location = New System.Drawing.Point(446, 427)
        Me.txtnetamount.Name = "txtnetamount"
        Me.txtnetamount.ReadOnly = True
        Me.txtnetamount.Size = New System.Drawing.Size(100, 22)
        Me.txtnetamount.TabIndex = 133
        Me.txtnetamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(359, 433)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 15)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Net Amount"
        '
        'frmSaleInvoiceWithDiscountOnAmout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(682, 536)
        Me.Controls.Add(Me.txtnetamount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDiscountAmount)
        Me.Controls.Add(Me.txtDiscountper)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblno)
        Me.Controls.Add(Me.ChknewCustomer)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dtHatchdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgSaleVoucher)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.voutype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtinvoiceno)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtremark1)
        Me.Controls.Add(Me.cmbsubgrp)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaleInvoiceWithDiscountOnAmout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale Invoice "
        CType(Me.dgSaleVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtinvoiceno As System.Windows.Forms.TextBox
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents voutype As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents dgSaleVoucher As System.Windows.Forms.DataGridView
    Friend WithEvents dtHatchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ChknewCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblno As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtremark1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cmbsubgrp As System.Windows.Forms.ComboBox
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pcname As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents freeper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents freeqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountper As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnetamount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
