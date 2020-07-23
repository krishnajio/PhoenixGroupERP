<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitNote
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebitNote))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblvouno = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.dtbilldate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvoucher = New System.Windows.Forms.DataGridView()
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstratre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSTPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSTAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GST_Head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GST_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGST_Per = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGST_Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGST_Head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGST_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGST_Per = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGST_Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGST_Head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGST_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSNCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbgrpferi = New System.Windows.Forms.ComboBox()
        Me.cmbgrpgst = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbferhead = New System.Windows.Forms.ComboBox()
        Me.cmbfercode = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbgsthead = New System.Windows.Forms.ComboBox()
        Me.cmbgstcode = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFreight = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtVdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbacheadname = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmbSubGroup = New System.Windows.Forms.ComboBox()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.voutype = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPoNo = New System.Windows.Forms.TextBox()
        Me.txtImwno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpInwdate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbPrdUnit = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSGStamt = New System.Windows.Forms.TextBox()
        Me.txtigstamt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbsgsthead = New System.Windows.Forms.ComboBox()
        Me.cmbsgstcode = New System.Windows.Forms.ComboBox()
        Me.cmbgrpsgst = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtduedate = New System.Windows.Forms.TextBox()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.cmbRefType = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TypeofRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ChkCform = New System.Windows.Forms.CheckBox()
        Me.dtppodate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtform49no = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtpf49issuedate = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtVehNo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtStockNo = New System.Windows.Forms.TextBox()
        Me.cmbBrokerName = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbBrokerCode = New System.Windows.Forms.ComboBox()
        Me.txtGstAmt = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmbigsthead = New System.Windows.Forms.ComboBox()
        Me.cmbigstcode = New System.Windows.Forms.ComboBox()
        Me.txtPoly = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtJute = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmbgrpigst = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cmbItemHead = New System.Windows.Forms.ComboBox()
        Me.cmbItemCode = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cmbunit = New System.Windows.Forms.ComboBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtLastRate = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtPoRate = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtHsnCode = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtgstper = New System.Windows.Forms.ComboBox()
        Me.txtsgstper = New System.Windows.Forms.ComboBox()
        Me.txtigstper = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1175, 31)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Debit Note"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblvouno
        '
        Me.lblvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblvouno.Location = New System.Drawing.Point(375, 35)
        Me.lblvouno.MaxLength = 18
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.ReadOnly = True
        Me.lblvouno.Size = New System.Drawing.Size(106, 20)
        Me.lblvouno.TabIndex = 1
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox2.Location = New System.Drawing.Point(489, 84)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox2.TabIndex = 180
        Me.CheckBox2.Text = "Add New Party Head"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Voucher No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "Voucher Type:"
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(519, 129)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(119, 21)
        Me.cmbacheadcode.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "Purchase From:"
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(143, 58)
        Me.txtBillNo.MaxLength = 18
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(145, 20)
        Me.txtBillNo.TabIndex = 3
        '
        'dtbilldate
        '
        Me.dtbilldate.CustomFormat = "dd/MMM/yyyy"
        Me.dtbilldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtbilldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtbilldate.Location = New System.Drawing.Point(375, 58)
        Me.dtbilldate.Name = "dtbilldate"
        Me.dtbilldate.Size = New System.Drawing.Size(106, 21)
        Me.dtbilldate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 173
        Me.Label5.Text = "Bill Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Bill No :"
        '
        'dgvoucher
        '
        Me.dgvoucher.AllowUserToAddRows = False
        Me.dgvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.Accode, Me.acname, Me.amount, Me.Qty, Me.Unit, Me.Rate, Me.lstratre, Me.porate, Me.GSTPer, Me.GSTAmt, Me.GST_Head, Me.GST_Code, Me.SGST_Per, Me.SGST_Amt, Me.SGST_Head, Me.SGST_Code, Me.IGST_Per, Me.IGST_Amt, Me.IGST_Head, Me.IGST_Code, Me.HSNCode})
        Me.dgvoucher.Location = New System.Drawing.Point(12, 298)
        Me.dgvoucher.Name = "dgvoucher"
        Me.dgvoucher.ReadOnly = True
        Me.dgvoucher.RowTemplate.Height = 20
        Me.dgvoucher.Size = New System.Drawing.Size(1151, 164)
        Me.dgvoucher.TabIndex = 32
        '
        'srno
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srno.DefaultCellStyle = DataGridViewCellStyle1
        Me.srno.HeaderText = "Sr. No."
        Me.srno.MaxInputLength = 2
        Me.srno.Name = "srno"
        Me.srno.ReadOnly = True
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
        Me.Accode.ReadOnly = True
        '
        'acname
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acname.DefaultCellStyle = DataGridViewCellStyle3
        Me.acname.HeaderText = "A/C Name"
        Me.acname.MaxInputLength = 30
        Me.acname.Name = "acname"
        Me.acname.ReadOnly = True
        Me.acname.Width = 200
        '
        'amount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.amount.HeaderText = "Amount"
        Me.amount.MaxInputLength = 18
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 80
        '
        'Qty
        '
        DataGridViewCellStyle5.NullValue = "0"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle5
        Me.Qty.HeaderText = "Qty"
        Me.Qty.MaxInputLength = 20
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Width = 75
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Unit.Width = 50
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 80
        '
        'lstratre
        '
        Me.lstratre.HeaderText = "Last Rate"
        Me.lstratre.Name = "lstratre"
        Me.lstratre.ReadOnly = True
        Me.lstratre.Width = 80
        '
        'porate
        '
        Me.porate.HeaderText = "P.O Rate"
        Me.porate.Name = "porate"
        Me.porate.ReadOnly = True
        Me.porate.Width = 80
        '
        'GSTPer
        '
        Me.GSTPer.HeaderText = "GSTPER"
        Me.GSTPer.Name = "GSTPer"
        Me.GSTPer.ReadOnly = True
        '
        'GSTAmt
        '
        Me.GSTAmt.HeaderText = "GSTAmt"
        Me.GSTAmt.Name = "GSTAmt"
        Me.GSTAmt.ReadOnly = True
        '
        'GST_Head
        '
        Me.GST_Head.HeaderText = "GST_Head"
        Me.GST_Head.Name = "GST_Head"
        Me.GST_Head.ReadOnly = True
        '
        'GST_Code
        '
        Me.GST_Code.HeaderText = "GST_Code"
        Me.GST_Code.Name = "GST_Code"
        Me.GST_Code.ReadOnly = True
        '
        'SGST_Per
        '
        Me.SGST_Per.HeaderText = "SGST_Per"
        Me.SGST_Per.Name = "SGST_Per"
        Me.SGST_Per.ReadOnly = True
        '
        'SGST_Amt
        '
        Me.SGST_Amt.HeaderText = "SGST_Amt"
        Me.SGST_Amt.Name = "SGST_Amt"
        Me.SGST_Amt.ReadOnly = True
        '
        'SGST_Head
        '
        Me.SGST_Head.HeaderText = "SGST_Head"
        Me.SGST_Head.Name = "SGST_Head"
        Me.SGST_Head.ReadOnly = True
        '
        'SGST_Code
        '
        Me.SGST_Code.HeaderText = "SGST_Code"
        Me.SGST_Code.Name = "SGST_Code"
        Me.SGST_Code.ReadOnly = True
        '
        'IGST_Per
        '
        Me.IGST_Per.HeaderText = "IGST_Per"
        Me.IGST_Per.Name = "IGST_Per"
        Me.IGST_Per.ReadOnly = True
        '
        'IGST_Amt
        '
        Me.IGST_Amt.HeaderText = "IGST_Amt"
        Me.IGST_Amt.Name = "IGST_Amt"
        Me.IGST_Amt.ReadOnly = True
        '
        'IGST_Head
        '
        Me.IGST_Head.HeaderText = "IGST_Head"
        Me.IGST_Head.Name = "IGST_Head"
        Me.IGST_Head.ReadOnly = True
        '
        'IGST_Code
        '
        Me.IGST_Code.HeaderText = "IGST_Code"
        Me.IGST_Code.Name = "IGST_Code"
        Me.IGST_Code.ReadOnly = True
        '
        'HSNCode
        '
        Me.HSNCode.HeaderText = "HSNCode"
        Me.HSNCode.Name = "HSNCode"
        Me.HSNCode.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(645, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 184
        '
        'cmbgrpferi
        '
        Me.cmbgrpferi.FormattingEnabled = True
        Me.cmbgrpferi.Location = New System.Drawing.Point(561, 240)
        Me.cmbgrpferi.Name = "cmbgrpferi"
        Me.cmbgrpferi.Size = New System.Drawing.Size(121, 21)
        Me.cmbgrpferi.TabIndex = 198
        Me.cmbgrpferi.TabStop = False
        '
        'cmbgrpgst
        '
        Me.cmbgrpgst.FormattingEnabled = True
        Me.cmbgrpgst.Location = New System.Drawing.Point(679, 214)
        Me.cmbgrpgst.Name = "cmbgrpgst"
        Me.cmbgrpgst.Size = New System.Drawing.Size(121, 21)
        Me.cmbgrpgst.TabIndex = 197
        Me.cmbgrpgst.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 505)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 196
        Me.Label12.Text = "Freight A/c:"
        '
        'cmbferhead
        '
        Me.cmbferhead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbferhead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbferhead.BackColor = System.Drawing.Color.White
        Me.cmbferhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbferhead.FormattingEnabled = True
        Me.cmbferhead.Location = New System.Drawing.Point(121, 500)
        Me.cmbferhead.Name = "cmbferhead"
        Me.cmbferhead.Size = New System.Drawing.Size(378, 24)
        Me.cmbferhead.TabIndex = 35
        '
        'cmbfercode
        '
        Me.cmbfercode.BackColor = System.Drawing.Color.White
        Me.cmbfercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfercode.FormattingEnabled = True
        Me.cmbfercode.Location = New System.Drawing.Point(502, 500)
        Me.cmbfercode.Name = "cmbfercode"
        Me.cmbfercode.Size = New System.Drawing.Size(92, 24)
        Me.cmbfercode.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 195
        Me.Label9.Text = "GST A/c:"
        '
        'cmbgsthead
        '
        Me.cmbgsthead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbgsthead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgsthead.BackColor = System.Drawing.Color.White
        Me.cmbgsthead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgsthead.FormattingEnabled = True
        Me.cmbgsthead.Location = New System.Drawing.Point(454, 212)
        Me.cmbgsthead.Name = "cmbgsthead"
        Me.cmbgsthead.Size = New System.Drawing.Size(371, 24)
        Me.cmbgsthead.TabIndex = 22
        '
        'cmbgstcode
        '
        Me.cmbgstcode.BackColor = System.Drawing.Color.White
        Me.cmbgstcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgstcode.FormattingEnabled = True
        Me.cmbgstcode.Location = New System.Drawing.Point(831, 212)
        Me.cmbgstcode.Name = "cmbgstcode"
        Me.cmbgstcode.Size = New System.Drawing.Size(90, 24)
        Me.cmbgstcode.TabIndex = 23
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(257, 474)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(234, 20)
        Me.txtTotal.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(214, 477)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 203
        Me.Label16.Text = "Total:"
        '
        'txtFreight
        '
        Me.txtFreight.Location = New System.Drawing.Point(121, 474)
        Me.txtFreight.Name = "txtFreight"
        Me.txtFreight.Size = New System.Drawing.Size(87, 20)
        Me.txtFreight.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(71, 476)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 202
        Me.Label15.Text = "Freight:"
        '
        'dtVdate
        '
        Me.dtVdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtVdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtVdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtVdate.Location = New System.Drawing.Point(584, 37)
        Me.dtVdate.Name = "dtVdate"
        Me.dtVdate.Size = New System.Drawing.Size(105, 21)
        Me.dtVdate.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(486, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 208
        Me.Label7.Text = "Voucher Date :"
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(143, 128)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(371, 24)
        Me.cmbacheadname.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.CheckBox1.Location = New System.Drawing.Point(617, 85)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(139, 17)
        Me.CheckBox1.TabIndex = 210
        Me.CheckBox1.Text = "Add New General Head"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmbSubGroup
        '
        Me.cmbSubGroup.FormattingEnabled = True
        Me.cmbSubGroup.Location = New System.Drawing.Point(644, 130)
        Me.cmbSubGroup.Name = "cmbSubGroup"
        Me.cmbSubGroup.Size = New System.Drawing.Size(112, 21)
        Me.cmbSubGroup.TabIndex = 211
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MMM/yy"
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(448, 105)
        Me.dtpdate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(118, 22)
        Me.dtpdate.TabIndex = 10
        Me.dtpdate.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(304, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 16)
        Me.Label8.TabIndex = 213
        Me.Label8.Text = "Payment Due Date :"
        Me.Label8.Visible = False
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Items.AddRange(New Object() {"DR Note"})
        Me.voutype.Location = New System.Drawing.Point(143, 34)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(145, 21)
        Me.voutype.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.Location = New System.Drawing.Point(484, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 215
        Me.Label10.Text = "P.O No/Date.:"
        Me.Label10.Visible = False
        '
        'txtPoNo
        '
        Me.txtPoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtPoNo.Location = New System.Drawing.Point(584, 60)
        Me.txtPoNo.MaxLength = 18
        Me.txtPoNo.Name = "txtPoNo"
        Me.txtPoNo.Size = New System.Drawing.Size(105, 20)
        Me.txtPoNo.TabIndex = 5
        Me.txtPoNo.Visible = False
        '
        'txtImwno
        '
        Me.txtImwno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtImwno.Location = New System.Drawing.Point(143, 81)
        Me.txtImwno.MaxLength = 18
        Me.txtImwno.Name = "txtImwno"
        Me.txtImwno.Size = New System.Drawing.Size(145, 20)
        Me.txtImwno.TabIndex = 7
        Me.txtImwno.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(81, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 218
        Me.Label11.Text = "Bill  No:"
        Me.Label11.Visible = False
        '
        'dtpInwdate
        '
        Me.dtpInwdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpInwdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpInwdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInwdate.Location = New System.Drawing.Point(375, 81)
        Me.dtpInwdate.Name = "dtpInwdate"
        Me.dtpInwdate.Size = New System.Drawing.Size(106, 21)
        Me.dtpInwdate.TabIndex = 8
        Me.dtpInwdate.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label13.Location = New System.Drawing.Point(299, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 15)
        Me.Label13.TabIndex = 220
        Me.Label13.Text = "lnw. Date :"
        Me.Label13.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 717)
        Me.Label17.TabIndex = 221
        Me.Label17.Text = "Purchase Poultry"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbPrdUnit
        '
        Me.cmbPrdUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPrdUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPrdUnit.BackColor = System.Drawing.Color.White
        Me.cmbPrdUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrdUnit.FormattingEnabled = True
        Me.cmbPrdUnit.Location = New System.Drawing.Point(143, 103)
        Me.cmbPrdUnit.Name = "cmbPrdUnit"
        Me.cmbPrdUnit.Size = New System.Drawing.Size(144, 21)
        Me.cmbPrdUnit.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label18.Location = New System.Drawing.Point(72, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 15)
        Me.Label18.TabIndex = 223
        Me.Label18.Text = "For. Unit:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(229, 238)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "SGST Amt :"
        '
        'txtSGStamt
        '
        Me.txtSGStamt.Location = New System.Drawing.Point(300, 234)
        Me.txtSGStamt.Name = "txtSGStamt"
        Me.txtSGStamt.Size = New System.Drawing.Size(85, 20)
        Me.txtSGStamt.TabIndex = 25
        Me.txtSGStamt.Text = "0"
        '
        'txtigstamt
        '
        Me.txtigstamt.Location = New System.Drawing.Point(300, 260)
        Me.txtigstamt.Name = "txtigstamt"
        Me.txtigstamt.Size = New System.Drawing.Size(85, 20)
        Me.txtigstamt.TabIndex = 29
        Me.txtigstamt.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(224, 260)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 13)
        Me.Label19.TabIndex = 225
        Me.Label19.Text = "IGCST Amt :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(389, 242)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 13)
        Me.Label20.TabIndex = 228
        Me.Label20.Text = "SGST A/c:"
        '
        'cmbsgsthead
        '
        Me.cmbsgsthead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbsgsthead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsgsthead.BackColor = System.Drawing.Color.White
        Me.cmbsgsthead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsgsthead.FormattingEnabled = True
        Me.cmbsgsthead.Location = New System.Drawing.Point(450, 238)
        Me.cmbsgsthead.Name = "cmbsgsthead"
        Me.cmbsgsthead.Size = New System.Drawing.Size(375, 24)
        Me.cmbsgsthead.TabIndex = 26
        '
        'cmbsgstcode
        '
        Me.cmbsgstcode.BackColor = System.Drawing.Color.White
        Me.cmbsgstcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsgstcode.FormattingEnabled = True
        Me.cmbsgstcode.Location = New System.Drawing.Point(831, 238)
        Me.cmbsgstcode.Name = "cmbsgstcode"
        Me.cmbsgstcode.Size = New System.Drawing.Size(92, 24)
        Me.cmbsgstcode.TabIndex = 27
        '
        'cmbgrpsgst
        '
        Me.cmbgrpsgst.BackColor = System.Drawing.Color.White
        Me.cmbgrpsgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpsgst.FormattingEnabled = True
        Me.cmbgrpsgst.Location = New System.Drawing.Point(687, 237)
        Me.cmbgrpsgst.Name = "cmbgrpsgst"
        Me.cmbgrpsgst.Size = New System.Drawing.Size(92, 24)
        Me.cmbgrpsgst.TabIndex = 229
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SteelBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label21.Location = New System.Drawing.Point(12, 634)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(880, 47)
        Me.Label21.TabIndex = 41
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtduedate)
        Me.GroupBox1.Controls.Add(Me.txtref)
        Me.GroupBox1.Controls.Add(Me.cmbRefType)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(605, 686)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(10, 12)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ref Detials"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(129, 47)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(387, 162)
        Me.dg.TabIndex = 6
        Me.dg.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(536, 34)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(34, 28)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(453, 37)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(81, 22)
        Me.txtamount.TabIndex = 4
        '
        'txtduedate
        '
        Me.txtduedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduedate.Location = New System.Drawing.Point(366, 39)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.Size = New System.Drawing.Size(81, 22)
        Me.txtduedate.TabIndex = 3
        Me.txtduedate.Text = "2/25/10"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(125, 37)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(236, 22)
        Me.txtref.TabIndex = 2
        '
        'cmbRefType
        '
        Me.cmbRefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRefType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRefType.FormattingEnabled = True
        Me.cmbRefType.Items.AddRange(New Object() {"Ags Ref", "New Ref", "Advance", "On Account"})
        Me.cmbRefType.Location = New System.Drawing.Point(9, 35)
        Me.cmbRefType.Name = "cmbRefType"
        Me.cmbRefType.Size = New System.Drawing.Size(112, 24)
        Me.cmbRefType.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(124, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 16)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "Name"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(365, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 16)
        Me.Label24.TabIndex = 132
        Me.Label24.Text = "Due Date"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(453, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 16)
        Me.Label25.TabIndex = 131
        Me.Label25.Text = "Amount"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeofRef, Me.Ref, Me.DueDate, Me.DataGridViewTextBoxColumn1})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(554, 144)
        Me.DataGridView1.TabIndex = 0
        '
        'TypeofRef
        '
        Me.TypeofRef.HeaderText = "Type of Ref"
        Me.TypeofRef.Name = "TypeofRef"
        Me.TypeofRef.ReadOnly = True
        '
        'Ref
        '
        Me.Ref.HeaderText = "Ref"
        Me.Ref.Name = "Ref"
        Me.Ref.ReadOnly = True
        '
        'DueDate
        '
        Me.DueDate.HeaderText = "Due Date"
        Me.DueDate.Name = "DueDate"
        Me.DueDate.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 14)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 16)
        Me.Label22.TabIndex = 134
        Me.Label22.Text = "Type of Ref"
        '
        'ChkCform
        '
        Me.ChkCform.AutoSize = True
        Me.ChkCform.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCform.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.ChkCform.Location = New System.Drawing.Point(754, 84)
        Me.ChkCform.Name = "ChkCform"
        Me.ChkCform.Size = New System.Drawing.Size(59, 17)
        Me.ChkCform.TabIndex = 232
        Me.ChkCform.Text = "C-Form"
        Me.ChkCform.UseVisualStyleBackColor = True
        Me.ChkCform.Visible = False
        '
        'dtppodate
        '
        Me.dtppodate.CustomFormat = "dd/MMM/yyyy"
        Me.dtppodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtppodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtppodate.Location = New System.Drawing.Point(695, 58)
        Me.dtppodate.Name = "dtppodate"
        Me.dtppodate.Size = New System.Drawing.Size(105, 21)
        Me.dtppodate.TabIndex = 6
        Me.dtppodate.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(42, 584)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 13)
        Me.Label27.TabIndex = 235
        Me.Label27.Text = "Form 49 No"
        Me.Label27.Visible = False
        '
        'txtform49no
        '
        Me.txtform49no.Location = New System.Drawing.Point(120, 581)
        Me.txtform49no.Name = "txtform49no"
        Me.txtform49no.Size = New System.Drawing.Size(194, 20)
        Me.txtform49no.TabIndex = 40
        Me.txtform49no.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(344, 531)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 13)
        Me.Label28.TabIndex = 237
        Me.Label28.Text = "Recv. Date"
        Me.Label28.Visible = False
        '
        'dtpf49issuedate
        '
        Me.dtpf49issuedate.CustomFormat = "dd/MMM/yy"
        Me.dtpf49issuedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpf49issuedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpf49issuedate.Location = New System.Drawing.Point(422, 526)
        Me.dtpf49issuedate.Name = "dtpf49issuedate"
        Me.dtpf49issuedate.Size = New System.Drawing.Size(77, 21)
        Me.dtpf49issuedate.TabIndex = 37
        Me.dtpf49issuedate.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(602, 506)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 13)
        Me.Label29.TabIndex = 241
        Me.Label29.Text = "Veh. No"
        '
        'TxtVehNo
        '
        Me.TxtVehNo.Location = New System.Drawing.Point(663, 502)
        Me.TxtVehNo.Name = "TxtVehNo"
        Me.TxtVehNo.Size = New System.Drawing.Size(141, 20)
        Me.TxtVehNo.TabIndex = 37
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(596, 532)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 13)
        Me.Label30.TabIndex = 243
        Me.Label30.Text = "Stock No."
        '
        'TxtStockNo
        '
        Me.TxtStockNo.Location = New System.Drawing.Point(663, 528)
        Me.TxtStockNo.Name = "TxtStockNo"
        Me.TxtStockNo.Size = New System.Drawing.Size(141, 20)
        Me.TxtStockNo.TabIndex = 38
        '
        'cmbBrokerName
        '
        Me.cmbBrokerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBrokerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBrokerName.BackColor = System.Drawing.Color.White
        Me.cmbBrokerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrokerName.FormattingEnabled = True
        Me.cmbBrokerName.Location = New System.Drawing.Point(120, 551)
        Me.cmbBrokerName.Name = "cmbBrokerName"
        Me.cmbBrokerName.Size = New System.Drawing.Size(371, 24)
        Me.cmbBrokerName.TabIndex = 39
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label31.Location = New System.Drawing.Point(22, 553)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 15)
        Me.Label31.TabIndex = 246
        Me.Label31.Text = "Broker Name:"
        '
        'cmbBrokerCode
        '
        Me.cmbBrokerCode.BackColor = System.Drawing.Color.White
        Me.cmbBrokerCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrokerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrokerCode.FormattingEnabled = True
        Me.cmbBrokerCode.Location = New System.Drawing.Point(496, 552)
        Me.cmbBrokerCode.Name = "cmbBrokerCode"
        Me.cmbBrokerCode.Size = New System.Drawing.Size(119, 21)
        Me.cmbBrokerCode.TabIndex = 245
        '
        'txtGstAmt
        '
        Me.txtGstAmt.Location = New System.Drawing.Point(298, 211)
        Me.txtGstAmt.Name = "txtGstAmt"
        Me.txtGstAmt.Size = New System.Drawing.Size(85, 20)
        Me.txtGstAmt.TabIndex = 21
        Me.txtGstAmt.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(232, 214)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 13)
        Me.Label26.TabIndex = 248
        Me.Label26.Text = "GST Amt :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(62, 215)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 13)
        Me.Label32.TabIndex = 250
        Me.Label32.Text = "GST Per(%) :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(75, 238)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 13)
        Me.Label33.TabIndex = 252
        Me.Label33.Text = "SGST(%) :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(55, 260)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(84, 13)
        Me.Label34.TabIndex = 254
        Me.Label34.Text = "IGST Per(%) :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(382, 272)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(65, 13)
        Me.Label35.TabIndex = 257
        Me.Label35.Text = "IGST A/c:"
        '
        'cmbigsthead
        '
        Me.cmbigsthead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbigsthead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbigsthead.BackColor = System.Drawing.Color.White
        Me.cmbigsthead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbigsthead.FormattingEnabled = True
        Me.cmbigsthead.Location = New System.Drawing.Point(450, 268)
        Me.cmbigsthead.Name = "cmbigsthead"
        Me.cmbigsthead.Size = New System.Drawing.Size(375, 24)
        Me.cmbigsthead.TabIndex = 30
        '
        'cmbigstcode
        '
        Me.cmbigstcode.BackColor = System.Drawing.Color.White
        Me.cmbigstcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbigstcode.FormattingEnabled = True
        Me.cmbigstcode.Location = New System.Drawing.Point(831, 268)
        Me.cmbigstcode.Name = "cmbigstcode"
        Me.cmbigstcode.Size = New System.Drawing.Size(92, 24)
        Me.cmbigstcode.TabIndex = 31
        '
        'txtPoly
        '
        Me.txtPoly.Location = New System.Drawing.Point(120, 527)
        Me.txtPoly.Name = "txtPoly"
        Me.txtPoly.Size = New System.Drawing.Size(85, 20)
        Me.txtPoly.TabIndex = 35
        Me.txtPoly.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(79, 532)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(35, 13)
        Me.Label36.TabIndex = 259
        Me.Label36.Text = "Poly:"
        '
        'txtJute
        '
        Me.txtJute.Location = New System.Drawing.Point(244, 528)
        Me.txtJute.Name = "txtJute"
        Me.txtJute.Size = New System.Drawing.Size(85, 20)
        Me.txtJute.TabIndex = 36
        Me.txtJute.Text = "0"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(207, 531)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(35, 13)
        Me.Label37.TabIndex = 261
        Me.Label37.Text = "Jute:"
        '
        'cmbgrpigst
        '
        Me.cmbgrpigst.BackColor = System.Drawing.Color.White
        Me.cmbgrpigst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpigst.FormattingEnabled = True
        Me.cmbgrpigst.Location = New System.Drawing.Point(664, 268)
        Me.cmbgrpigst.Name = "cmbgrpigst"
        Me.cmbgrpigst.Size = New System.Drawing.Size(92, 24)
        Me.cmbgrpigst.TabIndex = 262
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label38.Location = New System.Drawing.Point(54, 157)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(83, 15)
        Me.Label38.TabIndex = 263
        Me.Label38.Text = "Product A/c:"
        '
        'cmbItemHead
        '
        Me.cmbItemHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItemHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemHead.BackColor = System.Drawing.Color.White
        Me.cmbItemHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemHead.FormattingEnabled = True
        Me.cmbItemHead.Location = New System.Drawing.Point(143, 158)
        Me.cmbItemHead.Name = "cmbItemHead"
        Me.cmbItemHead.Size = New System.Drawing.Size(371, 24)
        Me.cmbItemHead.TabIndex = 12
        '
        'cmbItemCode
        '
        Me.cmbItemCode.BackColor = System.Drawing.Color.White
        Me.cmbItemCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemCode.FormattingEnabled = True
        Me.cmbItemCode.Location = New System.Drawing.Point(520, 160)
        Me.cmbItemCode.Name = "cmbItemCode"
        Me.cmbItemCode.Size = New System.Drawing.Size(119, 21)
        Me.cmbItemCode.TabIndex = 265
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label39.Location = New System.Drawing.Point(80, 189)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(59, 15)
        Me.Label39.TabIndex = 266
        Me.Label39.Text = "Amount:"
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(141, 188)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(85, 20)
        Me.txtAmt.TabIndex = 14
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(299, 188)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(85, 20)
        Me.txtQty.TabIndex = 15
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label40.Location = New System.Drawing.Point(269, 190)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(31, 15)
        Me.Label40.TabIndex = 268
        Me.Label40.Text = "Qty:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label41.Location = New System.Drawing.Point(410, 193)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(37, 15)
        Me.Label41.TabIndex = 270
        Me.Label41.Text = "Unit:"
        '
        'cmbunit
        '
        Me.cmbunit.FormattingEnabled = True
        Me.cmbunit.Items.AddRange(New Object() {"Kg", "Ton", "Ltrs", "Mton", "Doze", "Nos"})
        Me.cmbunit.Location = New System.Drawing.Point(454, 189)
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(112, 21)
        Me.cmbunit.TabIndex = 16
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(627, 192)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(85, 20)
        Me.txtRate.TabIndex = 17
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label42.Location = New System.Drawing.Point(586, 194)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(41, 15)
        Me.Label42.TabIndex = 272
        Me.Label42.Text = "Rate:"
        '
        'txtLastRate
        '
        Me.txtLastRate.Location = New System.Drawing.Point(789, 193)
        Me.txtLastRate.Name = "txtLastRate"
        Me.txtLastRate.Size = New System.Drawing.Size(85, 20)
        Me.txtLastRate.TabIndex = 18
        Me.txtLastRate.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label43.Location = New System.Drawing.Point(720, 194)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(72, 15)
        Me.Label43.TabIndex = 274
        Me.Label43.Text = "Last Rate:"
        Me.Label43.Visible = False
        '
        'txtPoRate
        '
        Me.txtPoRate.Location = New System.Drawing.Point(944, 194)
        Me.txtPoRate.Name = "txtPoRate"
        Me.txtPoRate.Size = New System.Drawing.Size(85, 20)
        Me.txtPoRate.TabIndex = 19
        Me.txtPoRate.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label44.Location = New System.Drawing.Point(878, 195)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(64, 15)
        Me.Label44.TabIndex = 276
        Me.Label44.Text = "PO Rate:"
        Me.Label44.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(932, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 28)
        Me.Button2.TabIndex = 278
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtHsnCode
        '
        Me.txtHsnCode.Location = New System.Drawing.Point(719, 160)
        Me.txtHsnCode.Name = "txtHsnCode"
        Me.txtHsnCode.Size = New System.Drawing.Size(85, 20)
        Me.txtHsnCode.TabIndex = 13
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label45.Location = New System.Drawing.Point(644, 162)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(77, 15)
        Me.Label45.TabIndex = 279
        Me.Label45.Text = "HSN Code:"
        '
        'txtgstper
        '
        Me.txtgstper.FormattingEnabled = True
        Me.txtgstper.Items.AddRange(New Object() {"0", "5", "12", "18", "28"})
        Me.txtgstper.Location = New System.Drawing.Point(141, 210)
        Me.txtgstper.Name = "txtgstper"
        Me.txtgstper.Size = New System.Drawing.Size(87, 21)
        Me.txtgstper.TabIndex = 20
        Me.txtgstper.Text = "0"
        '
        'txtsgstper
        '
        Me.txtsgstper.FormattingEnabled = True
        Me.txtsgstper.Items.AddRange(New Object() {"0", "5", "12", "18", "28"})
        Me.txtsgstper.Location = New System.Drawing.Point(141, 234)
        Me.txtsgstper.Name = "txtsgstper"
        Me.txtsgstper.Size = New System.Drawing.Size(87, 21)
        Me.txtsgstper.TabIndex = 24
        Me.txtsgstper.Text = "0"
        '
        'txtigstper
        '
        Me.txtigstper.FormattingEnabled = True
        Me.txtigstper.Items.AddRange(New Object() {"0", "5", "12", "18", "28"})
        Me.txtigstper.Location = New System.Drawing.Point(141, 257)
        Me.txtigstper.Name = "txtigstper"
        Me.txtigstper.Size = New System.Drawing.Size(87, 21)
        Me.txtigstper.TabIndex = 28
        Me.txtigstper.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(517, 637)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 33)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "&Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(410, 637)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(101, 35)
        Me.btndelete.TabIndex = 44
        Me.btndelete.Text = "&Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btn_modify
        '
        Me.btn_modify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify.Image = CType(resources.GetObject("btn_modify.Image"), System.Drawing.Image)
        Me.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_modify.Location = New System.Drawing.Point(303, 637)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(101, 35)
        Me.btn_modify.TabIndex = 43
        Me.btn_modify.Text = "&Modify"
        Me.btn_modify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(196, 637)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(101, 35)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmDebitNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(1175, 748)
        Me.Controls.Add(Me.txtigstper)
        Me.Controls.Add(Me.txtsgstper)
        Me.Controls.Add(Me.txtgstper)
        Me.Controls.Add(Me.txtHsnCode)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPoRate)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.txtLastRate)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.cmbunit)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cmbItemCode)
        Me.Controls.Add(Me.cmbItemHead)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtJute)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtPoly)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cmbigsthead)
        Me.Controls.Add(Me.cmbigstcode)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtGstAmt)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cmbBrokerName)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cmbBrokerCode)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TxtStockNo)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtVehNo)
        Me.Controls.Add(Me.dtpf49issuedate)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtform49no)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.dtppodate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChkCform)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbsgsthead)
        Me.Controls.Add(Me.cmbsgstcode)
        Me.Controls.Add(Me.txtigstamt)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmbPrdUnit)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpInwdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtImwno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPoNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.voutype)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbSubGroup)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.dtVdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSGStamt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtFreight)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbferhead)
        Me.Controls.Add(Me.cmbfercode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbgsthead)
        Me.Controls.Add(Me.cmbgstcode)
        Me.Controls.Add(Me.dgvoucher)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBillNo)
        Me.Controls.Add(Me.dtbilldate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbgrpgst)
        Me.Controls.Add(Me.cmbgrpferi)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbgrpsgst)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmbgrpigst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDebitNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPurchasePoultrty"
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblvouno As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents dtbilldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents dgvoucher As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrpferi As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrpgst As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbferhead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfercode As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbgsthead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgstcode As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFreight As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtVdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPoNo As System.Windows.Forms.TextBox
    Friend WithEvents txtImwno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpInwdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbPrdUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSGStamt As System.Windows.Forms.TextBox
    Friend WithEvents txtigstamt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbsgsthead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsgstcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrpsgst As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtduedate As System.Windows.Forms.TextBox
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents cmbRefType As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TypeofRef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChkCform As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtppodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtform49no As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtpf49issuedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtVehNo As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtStockNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbBrokerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbBrokerCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtGstAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmbigsthead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbigstcode As System.Windows.Forms.ComboBox
    Friend WithEvents txtPoly As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtJute As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cmbgrpigst As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cmbItemHead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbItemCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents cmbunit As System.Windows.Forms.ComboBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtLastRate As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtPoRate As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtHsnCode As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtgstper As System.Windows.Forms.ComboBox
    Friend WithEvents txtsgstper As System.Windows.Forms.ComboBox
    Friend WithEvents txtigstper As System.Windows.Forms.ComboBox
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lstratre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSTPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSTAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GST_Head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GST_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SGST_Per As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SGST_Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SGST_Head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SGST_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGST_Per As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGST_Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGST_Head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGST_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HSNCode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
