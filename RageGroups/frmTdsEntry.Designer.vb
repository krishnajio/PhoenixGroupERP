<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTdsEntry
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbtdsType = New System.Windows.Forms.ComboBox()
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox()
        Me.cmbTdsper = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbvtype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblvouno = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbFreightHead = New System.Windows.Forms.ComboBox()
        Me.cmbFrightCode = New System.Windows.Forms.ComboBox()
        Me.cmbFreightGroup = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPaidAmt = New System.Windows.Forms.TextBox()
        Me.txtActualAmt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttdsAmount = New System.Windows.Forms.TextBox()
        Me.CmbTdsGroup = New System.Windows.Forms.ComboBox()
        Me.cmbTdsCode = New System.Windows.Forms.ComboBox()
        Me.cmbTdsHead = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbPartyGroup = New System.Windows.Forms.ComboBox()
        Me.cmbPartCode = New System.Windows.Forms.ComboBox()
        Me.cmbPartyHead = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBilltyNo = New System.Windows.Forms.TextBox()
        Me.txtVhno = New System.Windows.Forms.TextBox()
        Me.txtVehicleNo1 = New System.Windows.Forms.Label()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtdate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbFreightSubGroup = New System.Windows.Forms.ComboBox()
        Me.cmbTdsSubGroup = New System.Windows.Forms.ComboBox()
        Me.cmbPartySubGroup = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrd = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgTds = New System.Windows.Forms.DataGridView()
        Me.txtBilltydate = New System.Windows.Forms.TextBox()
        Me.ChkBankEntry = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblvouno1 = New System.Windows.Forms.Label()
        Me.txtBankamt = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtchq = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbbankcode = New System.Windows.Forms.ComboBox()
        Me.cmbbankHead = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbvtype1 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbbanksubgroup = New System.Windows.Forms.ComboBox()
        Me.cmbbankgroup = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPaidTo = New System.Windows.Forms.TextBox()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.Narration = New System.Windows.Forms.Label()
        Me.dtpexpensedate = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgTds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SlateBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(607, 37)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "TDS Entry "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "TDS Type:"
        '
        'cmbtdsType
        '
        Me.cmbtdsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbtdsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtdsType.BackColor = System.Drawing.Color.White
        Me.cmbtdsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtdsType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtdsType.FormattingEnabled = True
        Me.cmbtdsType.Location = New System.Drawing.Point(110, 89)
        Me.cmbtdsType.Name = "cmbtdsType"
        Me.cmbtdsType.Size = New System.Drawing.Size(266, 21)
        Me.cmbtdsType.TabIndex = 3
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(494, 91)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbacheadcode.TabIndex = 42
        '
        'cmbTdsper
        '
        Me.cmbTdsper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsper.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsper.BackColor = System.Drawing.Color.White
        Me.cmbTdsper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsper.FormattingEnabled = True
        Me.cmbTdsper.Location = New System.Drawing.Point(380, 91)
        Me.cmbTdsper.Name = "cmbTdsper"
        Me.cmbTdsper.Size = New System.Drawing.Size(110, 21)
        Me.cmbTdsper.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Honeydew
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(607, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Honeydew
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Voucher Type:"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(110, 51)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(170, 21)
        Me.cmbvtype.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Honeydew
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(286, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Voucher No:"
        '
        'lblvouno
        '
        Me.lblvouno.AutoSize = True
        Me.lblvouno.BackColor = System.Drawing.Color.Honeydew
        Me.lblvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblvouno.ForeColor = System.Drawing.Color.Red
        Me.lblvouno.Location = New System.Drawing.Point(367, 51)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.Size = New System.Drawing.Size(14, 18)
        Me.lblvouno.TabIndex = 141
        Me.lblvouno.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Freight A/c"
        '
        'cmbFreightHead
        '
        Me.cmbFreightHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightHead.BackColor = System.Drawing.Color.White
        Me.cmbFreightHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightHead.FormattingEnabled = True
        Me.cmbFreightHead.Location = New System.Drawing.Point(110, 117)
        Me.cmbFreightHead.Name = "cmbFreightHead"
        Me.cmbFreightHead.Size = New System.Drawing.Size(266, 21)
        Me.cmbFreightHead.TabIndex = 4
        '
        'cmbFrightCode
        '
        Me.cmbFrightCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFrightCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFrightCode.BackColor = System.Drawing.Color.White
        Me.cmbFrightCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrightCode.FormattingEnabled = True
        Me.cmbFrightCode.Location = New System.Drawing.Point(380, 117)
        Me.cmbFrightCode.Name = "cmbFrightCode"
        Me.cmbFrightCode.Size = New System.Drawing.Size(110, 21)
        Me.cmbFrightCode.TabIndex = 144
        '
        'cmbFreightGroup
        '
        Me.cmbFreightGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightGroup.FormattingEnabled = True
        Me.cmbFreightGroup.Location = New System.Drawing.Point(494, 118)
        Me.cmbFreightGroup.Name = "cmbFreightGroup"
        Me.cmbFreightGroup.Size = New System.Drawing.Size(110, 21)
        Me.cmbFreightGroup.TabIndex = 145
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(107, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Paid Amount:"
        '
        'txtPaidAmt
        '
        Me.txtPaidAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidAmt.Location = New System.Drawing.Point(205, 140)
        Me.txtPaidAmt.Name = "txtPaidAmt"
        Me.txtPaidAmt.Size = New System.Drawing.Size(171, 20)
        Me.txtPaidAmt.TabIndex = 5
        '
        'txtActualAmt
        '
        Me.txtActualAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActualAmt.Location = New System.Drawing.Point(494, 140)
        Me.txtActualAmt.Name = "txtActualAmt"
        Me.txtActualAmt.Size = New System.Drawing.Size(110, 20)
        Me.txtActualAmt.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(388, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Actual Amount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label9.Location = New System.Drawing.Point(107, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "Tds  Amount:"
        '
        'txttdsAmount
        '
        Me.txttdsAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttdsAmount.Location = New System.Drawing.Point(205, 162)
        Me.txttdsAmount.Name = "txttdsAmount"
        Me.txttdsAmount.Size = New System.Drawing.Size(171, 20)
        Me.txttdsAmount.TabIndex = 7
        '
        'CmbTdsGroup
        '
        Me.CmbTdsGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbTdsGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTdsGroup.BackColor = System.Drawing.Color.White
        Me.CmbTdsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbTdsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTdsGroup.FormattingEnabled = True
        Me.CmbTdsGroup.Location = New System.Drawing.Point(491, 189)
        Me.CmbTdsGroup.Name = "CmbTdsGroup"
        Me.CmbTdsGroup.Size = New System.Drawing.Size(110, 21)
        Me.CmbTdsGroup.TabIndex = 155
        '
        'cmbTdsCode
        '
        Me.cmbTdsCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsCode.BackColor = System.Drawing.Color.White
        Me.cmbTdsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsCode.FormattingEnabled = True
        Me.cmbTdsCode.Location = New System.Drawing.Point(375, 189)
        Me.cmbTdsCode.Name = "cmbTdsCode"
        Me.cmbTdsCode.Size = New System.Drawing.Size(110, 21)
        Me.cmbTdsCode.TabIndex = 154
        '
        'cmbTdsHead
        '
        Me.cmbTdsHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsHead.BackColor = System.Drawing.Color.White
        Me.cmbTdsHead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsHead.FormattingEnabled = True
        Me.cmbTdsHead.Location = New System.Drawing.Point(105, 187)
        Me.cmbTdsHead.Name = "cmbTdsHead"
        Me.cmbTdsHead.Size = New System.Drawing.Size(266, 21)
        Me.cmbTdsHead.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.Location = New System.Drawing.Point(47, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "TDS A/c"
        '
        'cmbPartyGroup
        '
        Me.cmbPartyGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyGroup.BackColor = System.Drawing.Color.White
        Me.cmbPartyGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyGroup.FormattingEnabled = True
        Me.cmbPartyGroup.Location = New System.Drawing.Point(489, 213)
        Me.cmbPartyGroup.Name = "cmbPartyGroup"
        Me.cmbPartyGroup.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartyGroup.TabIndex = 159
        '
        'cmbPartCode
        '
        Me.cmbPartCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartCode.BackColor = System.Drawing.Color.White
        Me.cmbPartCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartCode.FormattingEnabled = True
        Me.cmbPartCode.Location = New System.Drawing.Point(375, 213)
        Me.cmbPartCode.Name = "cmbPartCode"
        Me.cmbPartCode.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartCode.TabIndex = 158
        '
        'cmbPartyHead
        '
        Me.cmbPartyHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyHead.BackColor = System.Drawing.Color.White
        Me.cmbPartyHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyHead.FormattingEnabled = True
        Me.cmbPartyHead.Location = New System.Drawing.Point(105, 212)
        Me.cmbPartyHead.Name = "cmbPartyHead"
        Me.cmbPartyHead.Size = New System.Drawing.Size(266, 21)
        Me.cmbPartyHead.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "Party A/c"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label12.Location = New System.Drawing.Point(114, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 160
        Me.Label12.Text = "Bill/Bilty No"
        '
        'txtBilltyNo
        '
        Me.txtBilltyNo.Location = New System.Drawing.Point(200, 237)
        Me.txtBilltyNo.Name = "txtBilltyNo"
        Me.txtBilltyNo.Size = New System.Drawing.Size(171, 20)
        Me.txtBilltyNo.TabIndex = 10
        '
        'txtVhno
        '
        Me.txtVhno.Location = New System.Drawing.Point(489, 239)
        Me.txtVhno.Name = "txtVhno"
        Me.txtVhno.Size = New System.Drawing.Size(110, 20)
        Me.txtVhno.TabIndex = 11
        '
        'txtVehicleNo1
        '
        Me.txtVehicleNo1.AutoSize = True
        Me.txtVehicleNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtVehicleNo1.Location = New System.Drawing.Point(408, 242)
        Me.txtVehicleNo1.Name = "txtVehicleNo1"
        Me.txtVehicleNo1.Size = New System.Drawing.Size(76, 15)
        Me.txtVehicleNo1.TabIndex = 162
        Me.txtVehicleNo1.Text = "Vehicle No"
        '
        'btn_modify
        '
        Me.btn_modify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify.Location = New System.Drawing.Point(143, 11)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(72, 28)
        Me.btn_modify.TabIndex = 1
        Me.btn_modify.Text = "&Modify"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(83, 11)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(54, 28)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btn_modify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 48)
        Me.Panel1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(370, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&TDS Multiple Entry "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(295, 11)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(69, 28)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(221, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(507, 50)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(97, 21)
        Me.dtdate.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Honeydew
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label13.Location = New System.Drawing.Point(410, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Voucher Date :"
        '
        'cmbFreightSubGroup
        '
        Me.cmbFreightSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightSubGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightSubGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightSubGroup.FormattingEnabled = True
        Me.cmbFreightSubGroup.Location = New System.Drawing.Point(380, 161)
        Me.cmbFreightSubGroup.Name = "cmbFreightSubGroup"
        Me.cmbFreightSubGroup.Size = New System.Drawing.Size(112, 21)
        Me.cmbFreightSubGroup.TabIndex = 165
        Me.cmbFreightSubGroup.Visible = False
        '
        'cmbTdsSubGroup
        '
        Me.cmbTdsSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsSubGroup.BackColor = System.Drawing.Color.White
        Me.cmbTdsSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsSubGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsSubGroup.FormattingEnabled = True
        Me.cmbTdsSubGroup.Location = New System.Drawing.Point(382, 162)
        Me.cmbTdsSubGroup.Name = "cmbTdsSubGroup"
        Me.cmbTdsSubGroup.Size = New System.Drawing.Size(110, 21)
        Me.cmbTdsSubGroup.TabIndex = 166
        '
        'cmbPartySubGroup
        '
        Me.cmbPartySubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartySubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartySubGroup.BackColor = System.Drawing.Color.White
        Me.cmbPartySubGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartySubGroup.FormattingEnabled = True
        Me.cmbPartySubGroup.Location = New System.Drawing.Point(382, 161)
        Me.cmbPartySubGroup.Name = "cmbPartySubGroup"
        Me.cmbPartySubGroup.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartySubGroup.TabIndex = 167
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label14.Location = New System.Drawing.Point(102, 261)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 15)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "Bill/Bilty Date"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(314, 260)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(92, 20)
        Me.txtqty.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label15.Location = New System.Drawing.Point(289, 262)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 15)
        Me.Label15.TabIndex = 171
        Me.Label15.Text = "Qty"
        '
        'txtPrd
        '
        Me.txtPrd.Location = New System.Drawing.Point(489, 266)
        Me.txtPrd.Name = "txtPrd"
        Me.txtPrd.Size = New System.Drawing.Size(110, 20)
        Me.txtPrd.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label16.Location = New System.Drawing.Point(428, 268)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 15)
        Me.Label16.TabIndex = 173
        Me.Label16.Text = "Product"
        '
        'dgTds
        '
        Me.dgTds.AllowUserToAddRows = False
        Me.dgTds.AllowUserToDeleteRows = False
        Me.dgTds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTds.Location = New System.Drawing.Point(2, 480)
        Me.dgTds.Name = "dgTds"
        Me.dgTds.ReadOnly = True
        Me.dgTds.Size = New System.Drawing.Size(599, 263)
        Me.dgTds.TabIndex = 19
        '
        'txtBilltydate
        '
        Me.txtBilltydate.Location = New System.Drawing.Point(200, 260)
        Me.txtBilltydate.Name = "txtBilltydate"
        Me.txtBilltydate.Size = New System.Drawing.Size(92, 20)
        Me.txtBilltydate.TabIndex = 12
        '
        'ChkBankEntry
        '
        Me.ChkBankEntry.AutoSize = True
        Me.ChkBankEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBankEntry.ForeColor = System.Drawing.Color.Firebrick
        Me.ChkBankEntry.Location = New System.Drawing.Point(2, 345)
        Me.ChkBankEntry.Name = "ChkBankEntry"
        Me.ChkBankEntry.Size = New System.Drawing.Size(101, 20)
        Me.ChkBankEntry.TabIndex = 17
        Me.ChkBankEntry.Text = "Bank Entry"
        Me.ChkBankEntry.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.Controls.Add(Me.lblvouno1)
        Me.GroupBox1.Controls.Add(Me.txtBankamt)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtchq)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cmbbankcode)
        Me.GroupBox1.Controls.Add(Me.cmbbankHead)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cmbvtype1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 63)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        Me.GroupBox1.Visible = False
        '
        'lblvouno1
        '
        Me.lblvouno1.AutoSize = True
        Me.lblvouno1.BackColor = System.Drawing.Color.Honeydew
        Me.lblvouno1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblvouno1.ForeColor = System.Drawing.Color.Red
        Me.lblvouno1.Location = New System.Drawing.Point(365, 12)
        Me.lblvouno1.Name = "lblvouno1"
        Me.lblvouno1.Size = New System.Drawing.Size(12, 15)
        Me.lblvouno1.TabIndex = 144
        Me.lblvouno1.Text = "-"
        '
        'txtBankamt
        '
        Me.txtBankamt.Location = New System.Drawing.Point(484, 35)
        Me.txtBankamt.Name = "txtBankamt"
        Me.txtBankamt.Size = New System.Drawing.Size(110, 20)
        Me.txtBankamt.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label22.Location = New System.Drawing.Point(425, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 15)
        Me.Label22.TabIndex = 177
        Me.Label22.Text = "Amount:"
        '
        'txtchq
        '
        Me.txtchq.Location = New System.Drawing.Point(484, 8)
        Me.txtchq.Name = "txtchq"
        Me.txtchq.Size = New System.Drawing.Size(110, 20)
        Me.txtchq.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label21.Location = New System.Drawing.Point(406, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 15)
        Me.Label21.TabIndex = 175
        Me.Label21.Text = "Cheque No."
        '
        'cmbbankcode
        '
        Me.cmbbankcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbbankcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbankcode.BackColor = System.Drawing.Color.White
        Me.cmbbankcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankcode.FormattingEnabled = True
        Me.cmbbankcode.Location = New System.Drawing.Point(484, 7)
        Me.cmbbankcode.Name = "cmbbankcode"
        Me.cmbbankcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbbankcode.TabIndex = 7
        Me.cmbbankcode.Visible = False
        '
        'cmbbankHead
        '
        Me.cmbbankHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbbankHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbankHead.BackColor = System.Drawing.Color.White
        Me.cmbbankHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankHead.FormattingEnabled = True
        Me.cmbbankHead.Location = New System.Drawing.Point(106, 33)
        Me.cmbbankHead.Name = "cmbbankHead"
        Me.cmbbankHead.Size = New System.Drawing.Size(313, 21)
        Me.cmbbankHead.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label19.Location = New System.Drawing.Point(38, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 15)
        Me.Label19.TabIndex = 160
        Me.Label19.Text = "Bank A/c"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.CadetBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label17.Location = New System.Drawing.Point(281, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 15)
        Me.Label17.TabIndex = 143
        Me.Label17.Text = "Voucher No:"
        '
        'cmbvtype1
        '
        Me.cmbvtype1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbvtype1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype1.BackColor = System.Drawing.Color.White
        Me.cmbvtype1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype1.FormattingEnabled = True
        Me.cmbvtype1.Location = New System.Drawing.Point(106, 9)
        Me.cmbvtype1.Name = "cmbvtype1"
        Me.cmbvtype1.Size = New System.Drawing.Size(170, 21)
        Me.cmbvtype1.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.CadetBlue
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 15)
        Me.Label18.TabIndex = 142
        Me.Label18.Text = "Voucher Type:"
        '
        'cmbbanksubgroup
        '
        Me.cmbbanksubgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbbanksubgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbanksubgroup.BackColor = System.Drawing.Color.White
        Me.cmbbanksubgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbanksubgroup.FormattingEnabled = True
        Me.cmbbanksubgroup.Location = New System.Drawing.Point(537, 288)
        Me.cmbbanksubgroup.Name = "cmbbanksubgroup"
        Me.cmbbanksubgroup.Size = New System.Drawing.Size(61, 21)
        Me.cmbbanksubgroup.TabIndex = 36
        '
        'cmbbankgroup
        '
        Me.cmbbankgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbbankgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbankgroup.BackColor = System.Drawing.Color.White
        Me.cmbbankgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankgroup.FormattingEnabled = True
        Me.cmbbankgroup.Location = New System.Drawing.Point(546, 292)
        Me.cmbbankgroup.Name = "cmbbankgroup"
        Me.cmbbankgroup.Size = New System.Drawing.Size(41, 21)
        Me.cmbbankgroup.TabIndex = 31
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label20.Location = New System.Drawing.Point(139, 285)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 15)
        Me.Label20.TabIndex = 178
        Me.Label20.Text = "Paid To"
        '
        'txtPaidTo
        '
        Me.txtPaidTo.Location = New System.Drawing.Point(200, 284)
        Me.txtPaidTo.Name = "txtPaidTo"
        Me.txtPaidTo.Size = New System.Drawing.Size(206, 20)
        Me.txtPaidTo.TabIndex = 15
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(200, 308)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(399, 34)
        Me.txtNarration.TabIndex = 16
        '
        'Narration
        '
        Me.Narration.AutoSize = True
        Me.Narration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Narration.Location = New System.Drawing.Point(127, 309)
        Me.Narration.Name = "Narration"
        Me.Narration.Size = New System.Drawing.Size(67, 15)
        Me.Narration.TabIndex = 180
        Me.Narration.Text = "Narration"
        '
        'dtpexpensedate
        '
        Me.dtpexpensedate.CustomFormat = "dd/MMM/yy"
        Me.dtpexpensedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpensedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexpensedate.Location = New System.Drawing.Point(209, 346)
        Me.dtpexpensedate.Name = "dtpexpensedate"
        Me.dtpexpensedate.Size = New System.Drawing.Size(106, 20)
        Me.dtpexpensedate.TabIndex = 206
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(105, 347)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 16)
        Me.Label23.TabIndex = 207
        Me.Label23.Text = "Expense Date"
        '
        'frmTdsEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 733)
        Me.Controls.Add(Me.dtpexpensedate)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Narration)
        Me.Controls.Add(Me.txtPaidTo)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkBankEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBilltydate)
        Me.Controls.Add(Me.dgTds)
        Me.Controls.Add(Me.cmbbanksubgroup)
        Me.Controls.Add(Me.txtPrd)
        Me.Controls.Add(Me.cmbbankgroup)
        Me.Controls.Add(Me.cmbFreightSubGroup)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmbTdsSubGroup)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.cmbPartySubGroup)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtVhno)
        Me.Controls.Add(Me.txtVehicleNo1)
        Me.Controls.Add(Me.txtBilltyNo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbPartyGroup)
        Me.Controls.Add(Me.cmbPartCode)
        Me.Controls.Add(Me.cmbPartyHead)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmbTdsGroup)
        Me.Controls.Add(Me.cmbTdsCode)
        Me.Controls.Add(Me.cmbTdsHead)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txttdsAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtActualAmt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPaidAmt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbFreightGroup)
        Me.Controls.Add(Me.cmbFrightCode)
        Me.Controls.Add(Me.cmbFreightHead)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTdsper)
        Me.Controls.Add(Me.cmbtdsType)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTdsEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTdsEntry"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgTds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbtdsType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTdsper As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblvouno As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbFreightHead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFrightCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFreightGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPaidAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtActualAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttdsAmount As System.Windows.Forms.TextBox
    Friend WithEvents CmbTdsGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTdsCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTdsHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbPartyGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBilltyNo As System.Windows.Forms.TextBox
    Friend WithEvents txtVhno As System.Windows.Forms.TextBox
    Friend WithEvents txtVehicleNo1 As System.Windows.Forms.Label
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbFreightSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTdsSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartySubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPrd As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgTds As System.Windows.Forms.DataGridView
    Friend WithEvents txtBilltydate As System.Windows.Forms.TextBox
    Friend WithEvents ChkBankEntry As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbvtype1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblvouno1 As System.Windows.Forms.Label
    Friend WithEvents cmbbanksubgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbankgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbankcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbankHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtPaidTo As System.Windows.Forms.TextBox
    Friend WithEvents txtchq As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents Narration As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtBankamt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpexpensedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
