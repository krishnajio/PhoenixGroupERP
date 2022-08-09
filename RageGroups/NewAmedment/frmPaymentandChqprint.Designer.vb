<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentandChqprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentandChqprint))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtChqNo = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Cramt = New System.Windows.Forms.Label()
        Me.txtCrmat = New System.Windows.Forms.TextBox()
        Me.cmbcode = New System.Windows.Forms.ComboBox()
        Me.cmbAcHead = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbvoutype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDramt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.dgPayment = New System.Windows.Forms.DataGridView()
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblDr = New System.Windows.Forms.Label()
        Me.lblcr = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtvou_no = New System.Windows.Forms.TextBox()
        Me.chkpayment = New System.Windows.Forms.CheckBox()
        Me.lblpartycode = New System.Windows.Forms.Label()
        Me.dtvdate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbAreaName = New System.Windows.Forms.ComboBox()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
        Me.dgBillNo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Bill_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Session = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit_amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TdsAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbfavourof = New System.Windows.Forms.ComboBox()
        Me.dtchequedate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chqsetup = New System.Windows.Forms.PageSetupDialog()
        Me.chqdocument = New System.Drawing.Printing.PrintDocument()
        Me.chqprintpreview = New System.Windows.Forms.PrintDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.dtpexpensedate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbPartyGroup = New System.Windows.Forms.ComboBox()
        Me.cmbPartCode = New System.Windows.Forms.ComboBox()
        Me.cmbPartyHead = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CmbTdsGroup = New System.Windows.Forms.ComboBox()
        Me.cmbTdsCode = New System.Windows.Forms.ComboBox()
        Me.cmbTdsHead = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txttdsAmount = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtActualAmt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPaidAmt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbTdsper = New System.Windows.Forms.ComboBox()
        Me.cmbtdsType = New System.Windows.Forms.ComboBox()
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkTdsEntry = New System.Windows.Forms.CheckBox()
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBillNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1162, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "Cheque No"
        '
        'txtChqNo
        '
        Me.txtChqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqNo.Location = New System.Drawing.Point(1165, 107)
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(103, 22)
        Me.txtChqNo.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(427, -3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox2.TabIndex = 156
        '
        'Cramt
        '
        Me.Cramt.AutoSize = True
        Me.Cramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cramt.Location = New System.Drawing.Point(735, 84)
        Me.Cramt.Name = "Cramt"
        Me.Cramt.Size = New System.Drawing.Size(49, 16)
        Me.Cramt.TabIndex = 155
        Me.Cramt.Text = "CrAmt"
        '
        'txtCrmat
        '
        Me.txtCrmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrmat.Location = New System.Drawing.Point(720, 107)
        Me.txtCrmat.Name = "txtCrmat"
        Me.txtCrmat.Size = New System.Drawing.Size(101, 22)
        Me.txtCrmat.TabIndex = 6
        Me.txtCrmat.Text = "0.0"
        '
        'cmbcode
        '
        Me.cmbcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcode.FormattingEnabled = True
        Me.cmbcode.Items.AddRange(New Object() {"SALE"})
        Me.cmbcode.Location = New System.Drawing.Point(459, 105)
        Me.cmbcode.Name = "cmbcode"
        Me.cmbcode.Size = New System.Drawing.Size(148, 24)
        Me.cmbcode.TabIndex = 4
        '
        'cmbAcHead
        '
        Me.cmbAcHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAcHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAcHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcHead.FormattingEnabled = True
        Me.cmbAcHead.Items.AddRange(New Object() {"SALE"})
        Me.cmbAcHead.Location = New System.Drawing.Point(30, 105)
        Me.cmbAcHead.Name = "cmbAcHead"
        Me.cmbAcHead.Size = New System.Drawing.Size(423, 24)
        Me.cmbAcHead.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "A/c Head:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(268, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Voucher Date :"
        '
        'cmbvoutype
        '
        Me.cmbvoutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvoutype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvoutype.FormattingEnabled = True
        Me.cmbvoutype.Items.AddRange(New Object() {"BANK"})
        Me.cmbvoutype.Location = New System.Drawing.Point(132, 33)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(130, 21)
        Me.cmbvoutype.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Voucher Type:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1320, 30)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Payment and Cheque print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(629, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "DrAmt"
        '
        'txtDramt
        '
        Me.txtDramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDramt.Location = New System.Drawing.Point(613, 107)
        Me.txtDramt.Name = "txtDramt"
        Me.txtDramt.Size = New System.Drawing.Size(101, 22)
        Me.txtDramt.TabIndex = 5
        Me.txtDramt.Text = "0.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(456, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "A/c Code:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label6.Location = New System.Drawing.Point(0, 30)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 618)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Payment"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(1274, 101)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(34, 28)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'dgPayment
        '
        Me.dgPayment.AllowUserToAddRows = False
        Me.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acname, Me.code, Me.dr1, Me.Cr1, Me.g, Me.s, Me.Narration, Me.ChequeNo})
        Me.dgPayment.Location = New System.Drawing.Point(30, 133)
        Me.dgPayment.Name = "dgPayment"
        Me.dgPayment.ReadOnly = True
        Me.dgPayment.Size = New System.Drawing.Size(1278, 169)
        Me.dgPayment.TabIndex = 164
        '
        'acname
        '
        Me.acname.HeaderText = "A/c NAme"
        Me.acname.Name = "acname"
        Me.acname.ReadOnly = True
        Me.acname.Width = 250
        '
        'code
        '
        Me.code.HeaderText = "A/c Code"
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        '
        'dr1
        '
        Me.dr1.HeaderText = "DrAmt"
        Me.dr1.Name = "dr1"
        Me.dr1.ReadOnly = True
        Me.dr1.Width = 110
        '
        'Cr1
        '
        Me.Cr1.HeaderText = "CrAmt"
        Me.Cr1.Name = "Cr1"
        Me.Cr1.ReadOnly = True
        Me.Cr1.Width = 110
        '
        'g
        '
        Me.g.HeaderText = "g"
        Me.g.Name = "g"
        Me.g.ReadOnly = True
        Me.g.Width = 25
        '
        's
        '
        Me.s.HeaderText = "s"
        Me.s.Name = "s"
        Me.s.ReadOnly = True
        Me.s.Width = 25
        '
        'Narration
        '
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 275
        '
        'ChequeNo
        '
        Me.ChequeNo.HeaderText = "ChequeNo"
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.ReadOnly = True
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(827, 79)
        Me.txtNarration.MaxLength = 180
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(332, 50)
        Me.txtNarration.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(824, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Narration"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic)
        Me.Label16.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label16.Location = New System.Drawing.Point(0, 648)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1320, 101)
        Me.Label16.TabIndex = 19
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(516, -3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox1.TabIndex = 175
        '
        'lblDr
        '
        Me.lblDr.AutoSize = True
        Me.lblDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr.ForeColor = System.Drawing.Color.Red
        Me.lblDr.Location = New System.Drawing.Point(697, 308)
        Me.lblDr.Name = "lblDr"
        Me.lblDr.Size = New System.Drawing.Size(14, 18)
        Me.lblDr.TabIndex = 176
        Me.lblDr.Text = "-"
        '
        'lblcr
        '
        Me.lblcr.AutoSize = True
        Me.lblcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcr.ForeColor = System.Drawing.Color.Red
        Me.lblcr.Location = New System.Drawing.Point(788, 305)
        Me.lblcr.Name = "lblcr"
        Me.lblcr.Size = New System.Drawing.Size(14, 18)
        Me.lblcr.TabIndex = 177
        Me.lblcr.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(702, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 16)
        Me.Label14.TabIndex = 179
        Me.Label14.Text = "Voucher No"
        '
        'txtvou_no
        '
        Me.txtvou_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvou_no.Location = New System.Drawing.Point(797, 33)
        Me.txtvou_no.Name = "txtvou_no"
        Me.txtvou_no.ReadOnly = True
        Me.txtvou_no.Size = New System.Drawing.Size(56, 20)
        Me.txtvou_no.TabIndex = 178
        '
        'chkpayment
        '
        Me.chkpayment.AutoSize = True
        Me.chkpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpayment.ForeColor = System.Drawing.Color.Red
        Me.chkpayment.Location = New System.Drawing.Point(132, 82)
        Me.chkpayment.Name = "chkpayment"
        Me.chkpayment.Size = New System.Drawing.Size(74, 17)
        Me.chkpayment.TabIndex = 3
        Me.chkpayment.Text = "Payment"
        Me.chkpayment.UseVisualStyleBackColor = True
        '
        'lblpartycode
        '
        Me.lblpartycode.AutoSize = True
        Me.lblpartycode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpartycode.Location = New System.Drawing.Point(206, 79)
        Me.lblpartycode.Name = "lblpartycode"
        Me.lblpartycode.Size = New System.Drawing.Size(13, 16)
        Me.lblpartycode.TabIndex = 180
        Me.lblpartycode.Text = "-"
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(375, 33)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(130, 21)
        Me.dtvdate.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(530, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 16)
        Me.Label15.TabIndex = 185
        Me.Label15.Text = "Area:"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(576, 33)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(116, 21)
        Me.cmbAreaName.TabIndex = 183
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(576, 33)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(115, 21)
        Me.cmbAreaCode.TabIndex = 184
        '
        'dgBillNo
        '
        Me.dgBillNo.AllowUserToAddRows = False
        Me.dgBillNo.AllowUserToDeleteRows = False
        Me.dgBillNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBillNo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Bill_No, Me.Bill_date, Me.Amount, Me.Session, Me.debit_amt, Me.TdsAmount})
        Me.dgBillNo.Location = New System.Drawing.Point(28, 308)
        Me.dgBillNo.Name = "dgBillNo"
        Me.dgBillNo.Size = New System.Drawing.Size(663, 337)
        Me.dgBillNo.TabIndex = 186
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.TrueValue = "1"
        Me.Column1.Width = 50
        '
        'Bill_No
        '
        Me.Bill_No.FillWeight = 75.0!
        Me.Bill_No.HeaderText = "Bill_No"
        Me.Bill_No.Name = "Bill_No"
        '
        'Bill_date
        '
        Me.Bill_date.FillWeight = 75.0!
        Me.Bill_date.HeaderText = "Bill_Date"
        Me.Bill_date.Name = "Bill_date"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'Session
        '
        Me.Session.FillWeight = 50.0!
        Me.Session.HeaderText = "Session"
        Me.Session.MaxInputLength = 10
        Me.Session.Name = "Session"
        '
        'debit_amt
        '
        Me.debit_amt.HeaderText = "debit_amt"
        Me.debit_amt.Name = "debit_amt"
        '
        'TdsAmount
        '
        Me.TdsAmount.HeaderText = "TdsAmount"
        Me.TdsAmount.Name = "TdsAmount"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(697, 617)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 28)
        Me.Button1.TabIndex = 187
        Me.Button1.Text = "&Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(770, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Favour of "
        '
        'cmbfavourof
        '
        Me.cmbfavourof.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbfavourof.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbfavourof.BackColor = System.Drawing.Color.White
        Me.cmbfavourof.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfavourof.FormattingEnabled = True
        Me.cmbfavourof.Location = New System.Drawing.Point(841, 346)
        Me.cmbfavourof.MaxLength = 50
        Me.cmbfavourof.Name = "cmbfavourof"
        Me.cmbfavourof.Size = New System.Drawing.Size(471, 23)
        Me.cmbfavourof.TabIndex = 189
        '
        'dtchequedate
        '
        Me.dtchequedate.CustomFormat = "dd/MMM/yy"
        Me.dtchequedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtchequedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtchequedate.Location = New System.Drawing.Point(841, 320)
        Me.dtchequedate.Name = "dtchequedate"
        Me.dtchequedate.Size = New System.Drawing.Size(104, 22)
        Me.dtchequedate.TabIndex = 188
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(741, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 15)
        Me.Label11.TabIndex = 190
        Me.Label11.Text = "Cheque  Date :"
        '
        'chqsetup
        '
        Me.chqsetup.Document = Me.chqdocument
        '
        'chqdocument
        '
        '
        'chqprintpreview
        '
        Me.chqprintpreview.UseEXDialog = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(638, 661)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 36)
        Me.Button2.TabIndex = 192
        Me.Button2.Text = "&Chq &Vou. Print"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(811, 661)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 36)
        Me.Button3.TabIndex = 193
        Me.Button3.Text = "&Post Vou."
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(456, 659)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(85, 36)
        Me.btnModify.TabIndex = 12
        Me.btnModify.Text = "&Modify"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(720, 661)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 36)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "&Close"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(547, 661)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 36)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(365, 661)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(801, 378)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 195
        Me.Label12.Text = "Type"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.BackColor = System.Drawing.Color.White
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"PARTY", "FEED", "MEDICINE", "CAPITAL", "IMPREST", "LOCAL PARTY", "HARDWARE & PACKING MAT.", "PARTNER CAPITAL", "PARENTAL BIRD", "P.P.BIRD MARKETING", "ELECTRICITY", "TELEPHONE", "SALARY & WAGES & BONUS", "TAXES FEES & INSURANCE & CONSULTANCY", "GROUP INSURANCE & GRATUITY", "DIESEL & PETROL", "ADVERTISEMENT", "DONATION & CHARITY", "IMPREST & INCENTIVE", "P.H RENT HATHING EGG PAYMENT", "AREA COLLECTION RET TO P.H", "VEHILE REP MAINT.", "MISC EXPS.", "STAFF WELFARE", "BANK TO BANK TRANSFER(INTERNAL)", "INTERNAL UNIT  TRANSFER"})
        Me.ComboBox3.Location = New System.Drawing.Point(841, 372)
        Me.ComboBox3.MaxLength = 50
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(356, 21)
        Me.ComboBox3.TabIndex = 194
        '
        'dtpexpensedate
        '
        Me.dtpexpensedate.CustomFormat = "dd/MMM/yy"
        Me.dtpexpensedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpensedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexpensedate.Location = New System.Drawing.Point(844, 399)
        Me.dtpexpensedate.Name = "dtpexpensedate"
        Me.dtpexpensedate.Size = New System.Drawing.Size(116, 20)
        Me.dtpexpensedate.TabIndex = 218
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(736, 399)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 16)
        Me.Label13.TabIndex = 219
        Me.Label13.Text = "Expense Date"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(732, 617)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 28)
        Me.Button4.TabIndex = 220
        Me.Button4.Text = "&Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbPartyGroup)
        Me.Panel1.Controls.Add(Me.cmbPartCode)
        Me.Panel1.Controls.Add(Me.cmbPartyHead)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.CmbTdsGroup)
        Me.Panel1.Controls.Add(Me.cmbTdsCode)
        Me.Panel1.Controls.Add(Me.cmbTdsHead)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txttdsAmount)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtActualAmt)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtPaidAmt)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.cmbTdsper)
        Me.Panel1.Controls.Add(Me.cmbtdsType)
        Me.Panel1.Controls.Add(Me.cmbacheadcode)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Location = New System.Drawing.Point(720, 450)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 151)
        Me.Panel1.TabIndex = 243
        Me.Panel1.Visible = False
        '
        'cmbPartyGroup
        '
        Me.cmbPartyGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyGroup.BackColor = System.Drawing.Color.White
        Me.cmbPartyGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyGroup.FormattingEnabled = True
        Me.cmbPartyGroup.Location = New System.Drawing.Point(464, 112)
        Me.cmbPartyGroup.Name = "cmbPartyGroup"
        Me.cmbPartyGroup.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartyGroup.TabIndex = 260
        '
        'cmbPartCode
        '
        Me.cmbPartCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartCode.BackColor = System.Drawing.Color.White
        Me.cmbPartCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartCode.FormattingEnabled = True
        Me.cmbPartCode.Location = New System.Drawing.Point(350, 112)
        Me.cmbPartCode.Name = "cmbPartCode"
        Me.cmbPartCode.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartCode.TabIndex = 259
        '
        'cmbPartyHead
        '
        Me.cmbPartyHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyHead.BackColor = System.Drawing.Color.White
        Me.cmbPartyHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyHead.FormattingEnabled = True
        Me.cmbPartyHead.Location = New System.Drawing.Point(80, 112)
        Me.cmbPartyHead.Name = "cmbPartyHead"
        Me.cmbPartyHead.Size = New System.Drawing.Size(266, 21)
        Me.cmbPartyHead.TabIndex = 253
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 113)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 15)
        Me.Label21.TabIndex = 258
        Me.Label21.Text = "Party A/c"
        '
        'CmbTdsGroup
        '
        Me.CmbTdsGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbTdsGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTdsGroup.BackColor = System.Drawing.Color.White
        Me.CmbTdsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbTdsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTdsGroup.FormattingEnabled = True
        Me.CmbTdsGroup.Location = New System.Drawing.Point(466, 88)
        Me.CmbTdsGroup.Name = "CmbTdsGroup"
        Me.CmbTdsGroup.Size = New System.Drawing.Size(110, 21)
        Me.CmbTdsGroup.TabIndex = 257
        '
        'cmbTdsCode
        '
        Me.cmbTdsCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsCode.BackColor = System.Drawing.Color.White
        Me.cmbTdsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsCode.FormattingEnabled = True
        Me.cmbTdsCode.Location = New System.Drawing.Point(350, 88)
        Me.cmbTdsCode.Name = "cmbTdsCode"
        Me.cmbTdsCode.Size = New System.Drawing.Size(110, 21)
        Me.cmbTdsCode.TabIndex = 256
        '
        'cmbTdsHead
        '
        Me.cmbTdsHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsHead.BackColor = System.Drawing.Color.White
        Me.cmbTdsHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsHead.FormattingEnabled = True
        Me.cmbTdsHead.Location = New System.Drawing.Point(80, 87)
        Me.cmbTdsHead.Name = "cmbTdsHead"
        Me.cmbTdsHead.Size = New System.Drawing.Size(266, 21)
        Me.cmbTdsHead.TabIndex = 252
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label22.Location = New System.Drawing.Point(22, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 15)
        Me.Label22.TabIndex = 255
        Me.Label22.Text = "TDS A/c"
        '
        'txttdsAmount
        '
        Me.txttdsAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttdsAmount.Location = New System.Drawing.Point(180, 62)
        Me.txttdsAmount.Name = "txttdsAmount"
        Me.txttdsAmount.Size = New System.Drawing.Size(171, 20)
        Me.txttdsAmount.TabIndex = 251
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label23.Location = New System.Drawing.Point(82, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 15)
        Me.Label23.TabIndex = 254
        Me.Label23.Text = "Tds  Amount:"
        '
        'txtActualAmt
        '
        Me.txtActualAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActualAmt.Location = New System.Drawing.Point(469, 36)
        Me.txtActualAmt.Name = "txtActualAmt"
        Me.txtActualAmt.Size = New System.Drawing.Size(110, 20)
        Me.txtActualAmt.TabIndex = 245
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label17.Location = New System.Drawing.Point(363, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 15)
        Me.Label17.TabIndex = 246
        Me.Label17.Text = "Actual Amount:"
        '
        'txtPaidAmt
        '
        Me.txtPaidAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidAmt.Location = New System.Drawing.Point(180, 36)
        Me.txtPaidAmt.Name = "txtPaidAmt"
        Me.txtPaidAmt.Size = New System.Drawing.Size(171, 20)
        Me.txtPaidAmt.TabIndex = 244
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label18.Location = New System.Drawing.Point(82, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 15)
        Me.Label18.TabIndex = 250
        Me.Label18.Text = "Paid Amount:"
        '
        'cmbTdsper
        '
        Me.cmbTdsper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsper.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsper.BackColor = System.Drawing.Color.White
        Me.cmbTdsper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsper.FormattingEnabled = True
        Me.cmbTdsper.Location = New System.Drawing.Point(355, 14)
        Me.cmbTdsper.Name = "cmbTdsper"
        Me.cmbTdsper.Size = New System.Drawing.Size(110, 21)
        Me.cmbTdsper.TabIndex = 247
        '
        'cmbtdsType
        '
        Me.cmbtdsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbtdsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtdsType.BackColor = System.Drawing.Color.White
        Me.cmbtdsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtdsType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtdsType.FormattingEnabled = True
        Me.cmbtdsType.Location = New System.Drawing.Point(85, 13)
        Me.cmbtdsType.Name = "cmbtdsType"
        Me.cmbtdsType.Size = New System.Drawing.Size(266, 21)
        Me.cmbtdsType.TabIndex = 243
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(469, 14)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbacheadcode.TabIndex = 248
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 15)
        Me.Label20.TabIndex = 249
        Me.Label20.Text = "TDS Type:"
        '
        'chkTdsEntry
        '
        Me.chkTdsEntry.AutoSize = True
        Me.chkTdsEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTdsEntry.ForeColor = System.Drawing.Color.Red
        Me.chkTdsEntry.Location = New System.Drawing.Point(720, 427)
        Me.chkTdsEntry.Name = "chkTdsEntry"
        Me.chkTdsEntry.Size = New System.Drawing.Size(76, 17)
        Me.chkTdsEntry.TabIndex = 244
        Me.chkTdsEntry.Text = "TdsEntry"
        Me.chkTdsEntry.UseVisualStyleBackColor = True
        '
        'frmPaymentandChqprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1320, 749)
        Me.Controls.Add(Me.chkTdsEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dtpexpensedate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbfavourof)
        Me.Controls.Add(Me.dtchequedate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgBillNo)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.lblpartycode)
        Me.Controls.Add(Me.chkpayment)
        Me.Controls.Add(Me.txtvou_no)
        Me.Controls.Add(Me.lblcr)
        Me.Controls.Add(Me.lblDr)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgPayment)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDramt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtChqNo)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Cramt)
        Me.Controls.Add(Me.txtCrmat)
        Me.Controls.Add(Me.cmbcode)
        Me.Controls.Add(Me.cmbAcHead)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbvoutype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.MaximizeBox = False
        Me.Name = "frmPaymentandChqprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBillNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Cramt As System.Windows.Forms.Label
    Friend WithEvents txtCrmat As System.Windows.Forms.TextBox
    Friend WithEvents cmbcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAcHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbvoutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDramt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents dgPayment As System.Windows.Forms.DataGridView
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblDr As System.Windows.Forms.Label
    Friend WithEvents lblcr As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtvou_no As System.Windows.Forms.TextBox
    Friend WithEvents chkpayment As System.Windows.Forms.CheckBox
    Friend WithEvents lblpartycode As System.Windows.Forms.Label
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents dgBillNo As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbfavourof As System.Windows.Forms.ComboBox
    Friend WithEvents dtchequedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chqsetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents chqprintpreview As System.Windows.Forms.PrintDialog
    Friend WithEvents chqdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents dtpexpensedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Bill_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bill_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Session As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit_amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdsAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbPartyGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CmbTdsGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTdsCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTdsHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txttdsAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtActualAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPaidAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbTdsper As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtdsType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkTdsEntry As System.Windows.Forms.CheckBox
End Class
