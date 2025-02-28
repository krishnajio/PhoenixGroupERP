<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvanceLedger
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
        Me.btnshow = New System.Windows.Forms.Button()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAreaName = New System.Windows.Forms.ComboBox()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbgrpname = New System.Windows.Forms.ComboBox()
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox()
        Me.cmbacheadname = New System.Windows.Forms.ComboBox()
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rdPary = New System.Windows.Forms.RadioButton()
        Me.drcustomer = New System.Windows.Forms.RadioButton()
        Me.CheckBoxArea = New System.Windows.Forms.CheckBox()
        Me.lblintper = New System.Windows.Forms.Label()
        Me.lblintrule = New System.Windows.Forms.Label()
        Me.lblinttype = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdPrint = New System.Windows.Forms.RadioButton()
        Me.rdOnscreen = New System.Windows.Forms.RadioButton()
        Me.dgGridLeger = New System.Windows.Forms.DataGridView()
        Me.VouDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoucherType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoucherNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dgParty = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBoxSelect = New System.Windows.Forms.CheckBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.chklistled = New System.Windows.Forms.CheckedListBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnwprint = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.rdwithopening = New System.Windows.Forms.CheckBox()
        Me.cmbVoucherTax = New System.Windows.Forms.ComboBox()
        Me.cmbTaxType = New System.Windows.Forms.ComboBox()
        Me.cmbPer = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbWiOs = New System.Windows.Forms.ComboBox()
        Me.cmbPrdType = New System.Windows.Forms.ComboBox()
        Me.cmbPrduct = New System.Windows.Forms.ComboBox()
        Me.chkProduct = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgGridLeger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgParty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(426, 164)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(53, 26)
        Me.btnshow.TabIndex = 6
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(432, 85)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 22)
        Me.dtfrom.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(353, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Date From :"
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
        Me.Label1.Size = New System.Drawing.Size(1304, 30)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "General Ledger With Filter on TDS and Tax"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Area :"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(48, 33)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(125, 21)
        Me.cmbAreaName.TabIndex = 80
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(178, 33)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(72, 21)
        Me.cmbAreaCode.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Group /Sub Group :"
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(382, 34)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(345, 21)
        Me.cmbgrpname.TabIndex = 2
        '
        'cmbsubgrpname
        '
        Me.cmbsubgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsubgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubgrpname.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbsubgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubgrpname.FormattingEnabled = True
        Me.cmbsubgrpname.Location = New System.Drawing.Point(730, 34)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(115, 21)
        Me.cmbsubgrpname.TabIndex = 3
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(382, 58)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(465, 21)
        Me.cmbacheadname.TabIndex = 0
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(850, 59)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(115, 21)
        Me.cmbacheadcode.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(189, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(542, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "To"
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(571, 85)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(104, 22)
        Me.dtto.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(649, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 235)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(1304, 353)
        Me.CrViewerGenralLedger.TabIndex = 92
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rdPary)
        Me.GroupBox1.Controls.Add(Me.drcustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(850, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 33)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(66, 10)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(110, 19)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.Text = "Internal Party"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(274, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 19)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "General"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rdPary
        '
        Me.rdPary.AutoSize = True
        Me.rdPary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPary.Location = New System.Drawing.Point(3, 10)
        Me.rdPary.Name = "rdPary"
        Me.rdPary.Size = New System.Drawing.Size(57, 19)
        Me.rdPary.TabIndex = 7
        Me.rdPary.Text = "Party"
        Me.rdPary.UseVisualStyleBackColor = True
        '
        'drcustomer
        '
        Me.drcustomer.AutoSize = True
        Me.drcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drcustomer.Location = New System.Drawing.Point(182, 10)
        Me.drcustomer.Name = "drcustomer"
        Me.drcustomer.Size = New System.Drawing.Size(86, 19)
        Me.drcustomer.TabIndex = 8
        Me.drcustomer.Text = "Customer"
        Me.drcustomer.UseVisualStyleBackColor = True
        '
        'CheckBoxArea
        '
        Me.CheckBoxArea.AutoSize = True
        Me.CheckBoxArea.Location = New System.Drawing.Point(833, 90)
        Me.CheckBoxArea.Name = "CheckBoxArea"
        Me.CheckBoxArea.Size = New System.Drawing.Size(75, 17)
        Me.CheckBoxArea.TabIndex = 97
        Me.CheckBoxArea.Text = "Area Wise"
        Me.CheckBoxArea.UseVisualStyleBackColor = True
        '
        'lblintper
        '
        Me.lblintper.AutoSize = True
        Me.lblintper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblintper.Location = New System.Drawing.Point(412, 60)
        Me.lblintper.Name = "lblintper"
        Me.lblintper.Size = New System.Drawing.Size(13, 16)
        Me.lblintper.TabIndex = 98
        Me.lblintper.Text = "-"
        '
        'lblintrule
        '
        Me.lblintrule.AutoSize = True
        Me.lblintrule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblintrule.Location = New System.Drawing.Point(457, 60)
        Me.lblintrule.Name = "lblintrule"
        Me.lblintrule.Size = New System.Drawing.Size(13, 16)
        Me.lblintrule.TabIndex = 99
        Me.lblintrule.Text = "-"
        '
        'lblinttype
        '
        Me.lblinttype.AutoSize = True
        Me.lblinttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinttype.Location = New System.Drawing.Point(506, 60)
        Me.lblinttype.Name = "lblinttype"
        Me.lblinttype.Size = New System.Drawing.Size(13, 16)
        Me.lblinttype.TabIndex = 100
        Me.lblinttype.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdPrint)
        Me.GroupBox2.Controls.Add(Me.rdOnscreen)
        Me.GroupBox2.Location = New System.Drawing.Point(681, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 33)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        '
        'rdPrint
        '
        Me.rdPrint.AutoSize = True
        Me.rdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPrint.Location = New System.Drawing.Point(86, 6)
        Me.rdPrint.Name = "rdPrint"
        Me.rdPrint.Size = New System.Drawing.Size(55, 19)
        Me.rdPrint.TabIndex = 1
        Me.rdPrint.Text = "Print"
        Me.rdPrint.UseVisualStyleBackColor = True
        '
        'rdOnscreen
        '
        Me.rdOnscreen.AutoSize = True
        Me.rdOnscreen.Checked = True
        Me.rdOnscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOnscreen.Location = New System.Drawing.Point(6, 6)
        Me.rdOnscreen.Name = "rdOnscreen"
        Me.rdOnscreen.Size = New System.Drawing.Size(70, 19)
        Me.rdOnscreen.TabIndex = 0
        Me.rdOnscreen.TabStop = True
        Me.rdOnscreen.Text = "Screen"
        Me.rdOnscreen.UseVisualStyleBackColor = True
        '
        'dgGridLeger
        '
        Me.dgGridLeger.AllowUserToAddRows = False
        Me.dgGridLeger.AllowUserToDeleteRows = False
        Me.dgGridLeger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGridLeger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VouDate, Me.Narration, Me.VoucherType, Me.VoucherNo, Me.ChequeNo, Me.DrAmt, Me.CrAmt, Me.balance})
        Me.dgGridLeger.Location = New System.Drawing.Point(0, 304)
        Me.dgGridLeger.Name = "dgGridLeger"
        Me.dgGridLeger.ReadOnly = True
        Me.dgGridLeger.Size = New System.Drawing.Size(803, 341)
        Me.dgGridLeger.TabIndex = 102
        Me.dgGridLeger.Visible = False
        '
        'VouDate
        '
        Me.VouDate.DataPropertyName = "Vou_date"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.VouDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.VouDate.HeaderText = "Vou Date"
        Me.VouDate.MaxInputLength = 10
        Me.VouDate.Name = "VouDate"
        Me.VouDate.ReadOnly = True
        Me.VouDate.Width = 50
        '
        'Narration
        '
        Me.Narration.DataPropertyName = "Narration"
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 250
        '
        'VoucherType
        '
        Me.VoucherType.DataPropertyName = "vou_type"
        Me.VoucherType.HeaderText = "VoucherType"
        Me.VoucherType.MaxInputLength = 30
        Me.VoucherType.Name = "VoucherType"
        Me.VoucherType.ReadOnly = True
        Me.VoucherType.Width = 75
        '
        'VoucherNo
        '
        Me.VoucherNo.DataPropertyName = "Vou_no"
        Me.VoucherNo.HeaderText = "VoucherNo."
        Me.VoucherNo.MaxInputLength = 40
        Me.VoucherNo.Name = "VoucherNo"
        Me.VoucherNo.ReadOnly = True
        Me.VoucherNo.Width = 60
        '
        'ChequeNo
        '
        Me.ChequeNo.DataPropertyName = "Cheque_no"
        Me.ChequeNo.HeaderText = "ChequeNo"
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.ReadOnly = True
        Me.ChequeNo.Width = 50
        '
        'DrAmt
        '
        Me.DrAmt.DataPropertyName = "dramt"
        Me.DrAmt.HeaderText = "Dr.Amt"
        Me.DrAmt.Name = "DrAmt"
        Me.DrAmt.ReadOnly = True
        Me.DrAmt.Width = 50
        '
        'CrAmt
        '
        Me.CrAmt.DataPropertyName = "cramt"
        Me.CrAmt.HeaderText = "Cr.Amt"
        Me.CrAmt.Name = "CrAmt"
        Me.CrAmt.ReadOnly = True
        Me.CrAmt.Width = 50
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        Me.balance.HeaderText = "Balance"
        Me.balance.MaxInputLength = 50
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 50
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(387, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox1.TabIndex = 81
        '
        'dgParty
        '
        Me.dgParty.AllowUserToAddRows = False
        Me.dgParty.AllowUserToDeleteRows = False
        Me.dgParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgParty.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgParty.Location = New System.Drawing.Point(2, 347)
        Me.dgParty.Name = "dgParty"
        Me.dgParty.ReadOnly = True
        Me.dgParty.Size = New System.Drawing.Size(803, 311)
        Me.dgParty.TabIndex = 103
        Me.dgParty.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Vou_date"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Vou Date"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Narration"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Narration"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "vou_type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "VoucherType"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 30
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Vou_no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "VoucherNo."
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 40
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cheque_no"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ChequeNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "dramt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dr.Amt"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cramt"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cr.Amt"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "balamt"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn8.MaxInputLength = 50
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'btnDos
        '
        Me.btnDos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(545, 164)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(98, 26)
        Me.btnDos.TabIndex = 104
        Me.btnDos.Text = "&DOS Print"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(648, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 26)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "&DOS Print ALL"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(703, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 26)
        Me.Button3.TabIndex = 106
        Me.Button3.Text = "&File"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'CheckBoxSelect
        '
        Me.CheckBoxSelect.AutoSize = True
        Me.CheckBoxSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSelect.Location = New System.Drawing.Point(830, 166)
        Me.CheckBoxSelect.Name = "CheckBoxSelect"
        Me.CheckBoxSelect.Size = New System.Drawing.Size(71, 20)
        Me.CheckBoxSelect.TabIndex = 108
        Me.CheckBoxSelect.Text = "Select"
        Me.CheckBoxSelect.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.panel1.Controls.Add(Me.Button6)
        Me.panel1.Controls.Add(Me.Button5)
        Me.panel1.Controls.Add(Me.chklistled)
        Me.panel1.Controls.Add(Me.btnPrint)
        Me.panel1.Location = New System.Drawing.Point(621, 244)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(289, 344)
        Me.panel1.TabIndex = 109
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(4, 314)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 26)
        Me.Button6.TabIndex = 109
        Me.Button6.Text = "&Print ALL"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(4, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 26)
        Me.Button5.TabIndex = 108
        Me.Button5.Text = "&Print ALL"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'chklistled
        '
        Me.chklistled.FormattingEnabled = True
        Me.chklistled.Location = New System.Drawing.Point(7, 4)
        Me.chklistled.Name = "chklistled"
        Me.chklistled.Size = New System.Drawing.Size(277, 304)
        Me.chklistled.TabIndex = 107
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(164, 314)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(117, 26)
        Me.btnPrint.TabIndex = 106
        Me.btnPrint.Text = "&DOS Print ALL"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnwprint
        '
        Me.btnwprint.Enabled = False
        Me.btnwprint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwprint.Location = New System.Drawing.Point(484, 164)
        Me.btnwprint.Name = "btnwprint"
        Me.btnwprint.Size = New System.Drawing.Size(56, 26)
        Me.btnwprint.TabIndex = 110
        Me.btnwprint.Text = "&Print"
        Me.btnwprint.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(771, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 26)
        Me.Button4.TabIndex = 111
        Me.Button4.Text = "&Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.Location = New System.Drawing.Point(900, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 20)
        Me.TextBox1.TabIndex = 112
        Me.TextBox1.Text = "0"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(905, 90)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox1.TabIndex = 113
        Me.CheckBox1.Text = "Select All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'rdwithopening
        '
        Me.rdwithopening.AutoSize = True
        Me.rdwithopening.Checked = True
        Me.rdwithopening.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdwithopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdwithopening.ForeColor = System.Drawing.Color.Red
        Me.rdwithopening.Location = New System.Drawing.Point(325, 169)
        Me.rdwithopening.Name = "rdwithopening"
        Me.rdwithopening.Size = New System.Drawing.Size(103, 17)
        Me.rdwithopening.TabIndex = 114
        Me.rdwithopening.Text = "With Opening"
        Me.rdwithopening.UseVisualStyleBackColor = True
        '
        'cmbVoucherTax
        '
        Me.cmbVoucherTax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbVoucherTax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVoucherTax.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbVoucherTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVoucherTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVoucherTax.FormattingEnabled = True
        Me.cmbVoucherTax.Items.AddRange(New Object() {"ALL", "TDS", "GST", "RCM"})
        Me.cmbVoucherTax.Location = New System.Drawing.Point(431, 109)
        Me.cmbVoucherTax.Name = "cmbVoucherTax"
        Me.cmbVoucherTax.Size = New System.Drawing.Size(125, 21)
        Me.cmbVoucherTax.TabIndex = 115
        '
        'cmbTaxType
        '
        Me.cmbTaxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTaxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTaxType.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTaxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTaxType.FormattingEnabled = True
        Me.cmbTaxType.Location = New System.Drawing.Point(562, 110)
        Me.cmbTaxType.Name = "cmbTaxType"
        Me.cmbTaxType.Size = New System.Drawing.Size(125, 21)
        Me.cmbTaxType.TabIndex = 116
        '
        'cmbPer
        '
        Me.cmbPer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPer.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPer.FormattingEnabled = True
        Me.cmbPer.Location = New System.Drawing.Point(693, 110)
        Me.cmbPer.Name = "cmbPer"
        Me.cmbPer.Size = New System.Drawing.Size(64, 21)
        Me.cmbPer.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(391, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Tax:"
        '
        'cmbWiOs
        '
        Me.cmbWiOs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbWiOs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbWiOs.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbWiOs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWiOs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbWiOs.FormattingEnabled = True
        Me.cmbWiOs.Location = New System.Drawing.Point(763, 110)
        Me.cmbWiOs.Name = "cmbWiOs"
        Me.cmbWiOs.Size = New System.Drawing.Size(125, 21)
        Me.cmbWiOs.TabIndex = 119
        '
        'cmbPrdType
        '
        Me.cmbPrdType.BackColor = System.Drawing.Color.White
        Me.cmbPrdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrdType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrdType.FormattingEnabled = True
        Me.cmbPrdType.Items.AddRange(New Object() {"FEED", "MEDICINE", "PACKING MATERIALS", "GENERAL PUR ITEMS"})
        Me.cmbPrdType.Location = New System.Drawing.Point(431, 136)
        Me.cmbPrdType.MaxLength = 50
        Me.cmbPrdType.Name = "cmbPrdType"
        Me.cmbPrdType.Size = New System.Drawing.Size(145, 24)
        Me.cmbPrdType.TabIndex = 120
        '
        'cmbPrduct
        '
        Me.cmbPrduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPrduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPrduct.BackColor = System.Drawing.Color.White
        Me.cmbPrduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrduct.FormattingEnabled = True
        Me.cmbPrduct.Location = New System.Drawing.Point(582, 137)
        Me.cmbPrduct.Name = "cmbPrduct"
        Me.cmbPrduct.Size = New System.Drawing.Size(319, 24)
        Me.cmbPrduct.TabIndex = 121
        '
        'chkProduct
        '
        Me.chkProduct.AutoSize = True
        Me.chkProduct.Location = New System.Drawing.Point(344, 141)
        Me.chkProduct.Name = "chkProduct"
        Me.chkProduct.Size = New System.Drawing.Size(81, 17)
        Me.chkProduct.TabIndex = 122
        Me.chkProduct.Text = "chkProduct"
        Me.chkProduct.UseVisualStyleBackColor = True
        '
        'frmAdvanceLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1304, 588)
        Me.Controls.Add(Me.chkProduct)
        Me.Controls.Add(Me.cmbPrdType)
        Me.Controls.Add(Me.cmbPrduct)
        Me.Controls.Add(Me.cmbWiOs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPer)
        Me.Controls.Add(Me.cmbTaxType)
        Me.Controls.Add(Me.cmbVoucherTax)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnwprint)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.CheckBoxSelect)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbsubgrpname)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.dgParty)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblinttype)
        Me.Controls.Add(Me.lblintrule)
        Me.Controls.Add(Me.lblintper)
        Me.Controls.Add(Me.CheckBoxArea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbgrpname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgGridLeger)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.rdwithopening)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdvanceLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Account Ledger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgGridLeger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgParty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents drcustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rdPary As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxArea As System.Windows.Forms.CheckBox
    Friend WithEvents lblintper As System.Windows.Forms.Label
    Friend WithEvents lblintrule As System.Windows.Forms.Label
    Friend WithEvents lblinttype As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnscreen As System.Windows.Forms.RadioButton
    Friend WithEvents dgGridLeger As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents VouDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoucherType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoucherNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgParty As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxSelect As System.Windows.Forms.CheckBox
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents chklistled As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnwprint As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents rdwithopening As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cmbVoucherTax As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTaxType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPer As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbWiOs As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPrdType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPrduct As System.Windows.Forms.ComboBox
    Friend WithEvents chkProduct As System.Windows.Forms.CheckBox
End Class
