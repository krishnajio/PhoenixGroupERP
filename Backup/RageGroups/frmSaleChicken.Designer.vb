<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleChicken
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbPurofhead = New System.Windows.Forms.ComboBox
        Me.cmbcodePur = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.dgPurchase = New System.Windows.Forms.DataGridView
        Me.Particular = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Quantity_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Quantity_Kg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtVoucherNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtInvnoNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtBatchNo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.dtInvVate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtbatch = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtVouDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbcommhead = New System.Windows.Forms.ComboBox
        Me.cmbcommcode = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbferhead = New System.Windows.Forms.ComboBox
        Me.cmbfercode = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtComm = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtFreight = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtgtotal = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblbatchno = New System.Windows.Forms.Label
        Me.chklock = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ChknewCustomer = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        CType(Me.dgPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(272, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(78, 31)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 424)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Cr"
        Me.Label5.Visible = False
        '
        'cmbPurofhead
        '
        Me.cmbPurofhead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPurofhead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPurofhead.BackColor = System.Drawing.Color.White
        Me.cmbPurofhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurofhead.FormattingEnabled = True
        Me.cmbPurofhead.Location = New System.Drawing.Point(95, 419)
        Me.cmbPurofhead.Name = "cmbPurofhead"
        Me.cmbPurofhead.Size = New System.Drawing.Size(274, 24)
        Me.cmbPurofhead.TabIndex = 14
        '
        'cmbcodePur
        '
        Me.cmbcodePur.BackColor = System.Drawing.Color.White
        Me.cmbcodePur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcodePur.FormattingEnabled = True
        Me.cmbcodePur.Location = New System.Drawing.Point(374, 419)
        Me.cmbcodePur.Name = "cmbcodePur"
        Me.cmbcodePur.Size = New System.Drawing.Size(92, 24)
        Me.cmbcodePur.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(562, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Dr"
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(126, 106)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(301, 24)
        Me.cmbacheadname.TabIndex = 7
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(431, 106)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(125, 24)
        Me.cmbacheadcode.TabIndex = 8
        '
        'dgPurchase
        '
        Me.dgPurchase.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPurchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPurchase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Particular, Me.Quantity_No, Me.Quantity_Kg, Me.Rate, Me.Amount})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPurchase.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgPurchase.Location = New System.Drawing.Point(0, 138)
        Me.dgPurchase.Name = "dgPurchase"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPurchase.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgPurchase.Size = New System.Drawing.Size(626, 193)
        Me.dgPurchase.TabIndex = 9
        '
        'Particular
        '
        Me.Particular.DataPropertyName = "Particular"
        Me.Particular.HeaderText = "Particular"
        Me.Particular.Name = "Particular"
        Me.Particular.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Particular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Particular.Width = 200
        '
        'Quantity_No
        '
        DataGridViewCellStyle2.NullValue = "0"
        Me.Quantity_No.DefaultCellStyle = DataGridViewCellStyle2
        Me.Quantity_No.HeaderText = "Quantity in No"
        Me.Quantity_No.Name = "Quantity_No"
        Me.Quantity_No.Width = 80
        '
        'Quantity_Kg
        '
        DataGridViewCellStyle3.NullValue = "0"
        Me.Quantity_Kg.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity_Kg.HeaderText = "Quantity in kg"
        Me.Quantity_Kg.Name = "Quantity_Kg"
        Me.Quantity_Kg.Width = 80
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 60
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 120
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Location = New System.Drawing.Point(126, 57)
        Me.txtVoucherNo.MaxLength = 20
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.ReadOnly = True
        Me.txtVoucherNo.Size = New System.Drawing.Size(85, 20)
        Me.txtVoucherNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Voucher No :"
        '
        'txtInvnoNo
        '
        Me.txtInvnoNo.Location = New System.Drawing.Point(126, 34)
        Me.txtInvnoNo.Name = "txtInvnoNo"
        Me.txtInvnoNo.Size = New System.Drawing.Size(85, 20)
        Me.txtInvnoNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Invoice No :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(291, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Inv Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Sold To:"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(183, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(78, 31)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'txtBatchNo
        '
        Me.txtBatchNo.AutoSize = True
        Me.txtBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchNo.Location = New System.Drawing.Point(287, 86)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Size = New System.Drawing.Size(68, 13)
        Me.txtBatchNo.TabIndex = 158
        Me.txtBatchNo.Text = "Batch No :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnModify)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Location = New System.Drawing.Point(98, 509)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 41)
        Me.Panel2.TabIndex = 160
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(97, 5)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(78, 31)
        Me.btnModify.TabIndex = 21
        Me.btnModify.Text = "&Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(11, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 31)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtInvVate
        '
        Me.dtInvVate.CustomFormat = "dd/MMM/yy"
        Me.dtInvVate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInvVate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInvVate.Location = New System.Drawing.Point(364, 37)
        Me.dtInvVate.Name = "dtInvVate"
        Me.dtInvVate.Size = New System.Drawing.Size(81, 20)
        Me.dtInvVate.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(626, 31)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "SALE PHOENIX CHICKEN"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbatch
        '
        Me.txtbatch.Location = New System.Drawing.Point(364, 83)
        Me.txtbatch.Name = "txtbatch"
        Me.txtbatch.Size = New System.Drawing.Size(85, 20)
        Me.txtbatch.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Vou Date :"
        '
        'dtVouDate
        '
        Me.dtVouDate.CustomFormat = "dd/MMM/yy"
        Me.dtVouDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtVouDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtVouDate.Location = New System.Drawing.Point(364, 61)
        Me.dtVouDate.Name = "dtVouDate"
        Me.dtVouDate.Size = New System.Drawing.Size(81, 20)
        Me.dtVouDate.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Sale A/c"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "Comm A/c"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(472, 454)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 170
        Me.Label11.Text = "Cr"
        '
        'cmbcommhead
        '
        Me.cmbcommhead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbcommhead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcommhead.BackColor = System.Drawing.Color.White
        Me.cmbcommhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcommhead.FormattingEnabled = True
        Me.cmbcommhead.Location = New System.Drawing.Point(95, 449)
        Me.cmbcommhead.Name = "cmbcommhead"
        Me.cmbcommhead.Size = New System.Drawing.Size(274, 24)
        Me.cmbcommhead.TabIndex = 16
        '
        'cmbcommcode
        '
        Me.cmbcommcode.BackColor = System.Drawing.Color.White
        Me.cmbcommcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcommcode.FormattingEnabled = True
        Me.cmbcommcode.Location = New System.Drawing.Point(374, 449)
        Me.cmbcommcode.Name = "cmbcommcode"
        Me.cmbcommcode.Size = New System.Drawing.Size(92, 24)
        Me.cmbcommcode.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 484)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 174
        Me.Label12.Text = "Freight A/c"
        '
        'cmbferhead
        '
        Me.cmbferhead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbferhead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbferhead.BackColor = System.Drawing.Color.White
        Me.cmbferhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbferhead.FormattingEnabled = True
        Me.cmbferhead.Location = New System.Drawing.Point(95, 479)
        Me.cmbferhead.Name = "cmbferhead"
        Me.cmbferhead.Size = New System.Drawing.Size(273, 24)
        Me.cmbferhead.TabIndex = 18
        '
        'cmbfercode
        '
        Me.cmbfercode.BackColor = System.Drawing.Color.White
        Me.cmbfercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfercode.FormattingEnabled = True
        Me.cmbfercode.Location = New System.Drawing.Point(374, 479)
        Me.cmbfercode.Name = "cmbfercode"
        Me.cmbfercode.Size = New System.Drawing.Size(92, 24)
        Me.cmbfercode.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(472, 490)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 175
        Me.Label13.Text = "Cr"
        '
        'txtComm
        '
        Me.txtComm.Location = New System.Drawing.Point(531, 335)
        Me.txtComm.Name = "txtComm"
        Me.txtComm.Size = New System.Drawing.Size(85, 20)
        Me.txtComm.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(447, 338)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 177
        Me.Label14.Text = "Commission  :"
        '
        'txtFreight
        '
        Me.txtFreight.Location = New System.Drawing.Point(531, 357)
        Me.txtFreight.Name = "txtFreight"
        Me.txtFreight.Size = New System.Drawing.Size(85, 20)
        Me.txtFreight.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(467, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 179
        Me.Label15.Text = "Freight  :"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(531, 378)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(85, 20)
        Me.txtTotal.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(485, 381)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 181
        Me.Label16.Text = "Total:"
        '
        'txtgtotal
        '
        Me.txtgtotal.Location = New System.Drawing.Point(531, 400)
        Me.txtgtotal.Name = "txtgtotal"
        Me.txtgtotal.ReadOnly = True
        Me.txtgtotal.Size = New System.Drawing.Size(85, 20)
        Me.txtgtotal.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(442, 403)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 183
        Me.Label17.Text = "Grand Total:"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(219, 82)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(58, 21)
        Me.cmbAreaName.TabIndex = 5
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(126, 82)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(88, 21)
        Me.cmbAreaCode.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(83, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 186
        Me.Label18.Text = "Area:"
        '
        'lblbatchno
        '
        Me.lblbatchno.AutoSize = True
        Me.lblbatchno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbatchno.Location = New System.Drawing.Point(455, 86)
        Me.lblbatchno.Name = "lblbatchno"
        Me.lblbatchno.Size = New System.Drawing.Size(68, 13)
        Me.lblbatchno.TabIndex = 187
        Me.lblbatchno.Text = "Batch No :"
        '
        'chklock
        '
        Me.chklock.AutoSize = True
        Me.chklock.Checked = True
        Me.chklock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chklock.Location = New System.Drawing.Point(217, 59)
        Me.chklock.Name = "chklock"
        Me.chklock.Size = New System.Drawing.Size(54, 17)
        Me.chklock.TabIndex = 188
        Me.chklock.Text = "LOCK"
        Me.chklock.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(205, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(290, 106)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 13
        Me.ComboBox2.TabStop = False
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(219, 449)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 189
        Me.ComboBox3.TabStop = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(217, 482)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 190
        Me.ComboBox4.TabStop = False
        '
        'ChknewCustomer
        '
        Me.ChknewCustomer.AutoSize = True
        Me.ChknewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChknewCustomer.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.ChknewCustomer.Location = New System.Drawing.Point(449, 53)
        Me.ChknewCustomer.Name = "ChknewCustomer"
        Me.ChknewCustomer.Size = New System.Drawing.Size(167, 17)
        Me.ChknewCustomer.TabIndex = 192
        Me.ChknewCustomer.Text = "Add New Customer Head"
        Me.ChknewCustomer.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox2.Location = New System.Drawing.Point(449, 37)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox2.TabIndex = 191
        Me.CheckBox2.Text = "Add New Party Head"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox1.Location = New System.Drawing.Point(449, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 17)
        Me.CheckBox1.TabIndex = 196
        Me.CheckBox1.Text = "Add New General Head"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmSaleChicken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(626, 562)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ChknewCustomer)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.chklock)
        Me.Controls.Add(Me.lblbatchno)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.txtgtotal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtFreight)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtComm)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbferhead)
        Me.Controls.Add(Me.cmbfercode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbcommhead)
        Me.Controls.Add(Me.cmbcommcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtVouDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbPurofhead)
        Me.Controls.Add(Me.cmbcodePur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.dgPurchase)
        Me.Controls.Add(Me.txtVoucherNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInvnoNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBatchNo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dtInvVate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtbatch)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSaleChicken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSaleChicken"
        CType(Me.dgPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPurofhead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcodePur As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents dgPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents txtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInvnoNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtBatchNo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtInvVate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtbatch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtVouDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbcommhead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcommcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbferhead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfercode As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtComm As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFreight As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtgtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblbatchno As System.Windows.Forms.Label
    Friend WithEvents chklock As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ChknewCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Particular As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Quantity_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity_Kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
