<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRDebit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCrNoTo = New System.Windows.Forms.TextBox()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.dgCRDebit = New System.Windows.Forms.DataGridView()
        Me.vno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acc_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acc_head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.narratio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cramt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtvdate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAreaName = New System.Windows.Forms.ComboBox()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbvtype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.lblvouno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbacheadname = New System.Windows.Forms.ComboBox()
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbacsubgroup = New System.Windows.Forms.ComboBox()
        Me.cmbacgroup = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtndebit = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbvou_type = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(1085, 31)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "CR -> Debit"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 15)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "CR Voucher Number From :"
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(190, 116)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtCrNoFrom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "To"
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(324, 116)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(100, 20)
        Me.txtCrNoTo.TabIndex = 6
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(296, 138)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 8
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dgCRDebit
        '
        Me.dgCRDebit.AllowUserToAddRows = False
        Me.dgCRDebit.AllowUserToDeleteRows = False
        Me.dgCRDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vno, Me.vdate, Me.acc_code, Me.acc_head, Me.narratio, Me.cramt})
        Me.dgCRDebit.Location = New System.Drawing.Point(0, 195)
        Me.dgCRDebit.Name = "dgCRDebit"
        Me.dgCRDebit.ReadOnly = True
        Me.dgCRDebit.Size = New System.Drawing.Size(672, 150)
        Me.dgCRDebit.TabIndex = 97
        Me.dgCRDebit.TabStop = False
        '
        'vno
        '
        Me.vno.HeaderText = "Vou No."
        Me.vno.Name = "vno"
        Me.vno.ReadOnly = True
        Me.vno.Width = 60
        '
        'vdate
        '
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.vdate.DefaultCellStyle = DataGridViewCellStyle1
        Me.vdate.HeaderText = "Vou Date"
        Me.vdate.Name = "vdate"
        Me.vdate.ReadOnly = True
        Me.vdate.Width = 75
        '
        'acc_code
        '
        Me.acc_code.HeaderText = "A/c Code"
        Me.acc_code.Name = "acc_code"
        Me.acc_code.ReadOnly = True
        Me.acc_code.Width = 60
        '
        'acc_head
        '
        Me.acc_head.HeaderText = "A/c Head"
        Me.acc_head.Name = "acc_head"
        Me.acc_head.ReadOnly = True
        Me.acc_head.Width = 150
        '
        'narratio
        '
        Me.narratio.HeaderText = "Narration"
        Me.narratio.Name = "narratio"
        Me.narratio.ReadOnly = True
        Me.narratio.Width = 200
        '
        'cramt
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.cramt.DefaultCellStyle = DataGridViewCellStyle2
        Me.cramt.HeaderText = "Cr Amount"
        Me.cramt.Name = "cramt"
        Me.cramt.ReadOnly = True
        Me.cramt.Width = 75
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(109, 36)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(109, 20)
        Me.dtvdate.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Voucher  Date :"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(239, 62)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(185, 21)
        Me.cmbAreaName.TabIndex = 2
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(109, 62)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(124, 21)
        Me.cmbAreaCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Area :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Voucher Type:"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(109, 87)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(124, 21)
        Me.cmbvtype.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(239, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Voucher No:"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(430, 91)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(56, 20)
        Me.CheckBox3.TabIndex = 107
        Me.CheckBox3.Text = "Lock"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'lblvouno
        '
        Me.lblvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvouno.Location = New System.Drawing.Point(324, 90)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.ReadOnly = True
        Me.lblvouno.Size = New System.Drawing.Size(100, 20)
        Me.lblvouno.TabIndex = 4
        Me.lblvouno.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Amount:"
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(69, 349)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(15, 15)
        Me.lblamount.TabIndex = 109
        Me.lblamount.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(204, 349)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Debit To:"
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(206, 367)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(296, 21)
        Me.cmbacheadname.TabIndex = 9
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(505, 367)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(168, 21)
        Me.cmbacheadcode.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'cmbacsubgroup
        '
        Me.cmbacsubgroup.BackColor = System.Drawing.Color.White
        Me.cmbacsubgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacsubgroup.Enabled = False
        Me.cmbacsubgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacsubgroup.FormattingEnabled = True
        Me.cmbacsubgroup.Location = New System.Drawing.Point(505, 391)
        Me.cmbacsubgroup.Name = "cmbacsubgroup"
        Me.cmbacsubgroup.Size = New System.Drawing.Size(168, 24)
        Me.cmbacsubgroup.TabIndex = 114
        Me.cmbacsubgroup.TabStop = False
        '
        'cmbacgroup
        '
        Me.cmbacgroup.BackColor = System.Drawing.Color.White
        Me.cmbacgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacgroup.Enabled = False
        Me.cmbacgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacgroup.FormattingEnabled = True
        Me.cmbacgroup.Location = New System.Drawing.Point(207, 391)
        Me.cmbacgroup.Name = "cmbacgroup"
        Me.cmbacgroup.Size = New System.Drawing.Size(295, 24)
        Me.cmbacgroup.TabIndex = 112
        Me.cmbacgroup.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(76, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 15)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Group/Sub Group :"
        '
        'dtndebit
        '
        Me.dtndebit.BackColor = System.Drawing.Color.Teal
        Me.dtndebit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtndebit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtndebit.Location = New System.Drawing.Point(144, 430)
        Me.dtndebit.Name = "dtndebit"
        Me.dtndebit.Size = New System.Drawing.Size(295, 28)
        Me.dtndebit.TabIndex = 11
        Me.dtndebit.Text = "&Debit Amout "
        Me.dtndebit.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(115, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 15)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "Narration"
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(190, 169)
        Me.txtNarration.MaxLength = 100
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(394, 20)
        Me.txtNarration.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(440, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Delet&e "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(613, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmbvou_type
        '
        Me.cmbvou_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvou_type.FormattingEnabled = True
        Me.cmbvou_type.Location = New System.Drawing.Point(190, 142)
        Me.cmbvou_type.Name = "cmbvou_type"
        Me.cmbvou_type.Size = New System.Drawing.Size(100, 21)
        Me.cmbvou_type.TabIndex = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(60, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 15)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "CR Voucher Type :"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(534, 430)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 28)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "&Print CR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmCRDebit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1085, 473)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmbvou_type)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtndebit)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbacsubgroup)
        Me.Controls.Add(Me.cmbacgroup)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgCRDebit)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCRDebit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCRDebit"
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dgCRDebit As System.Windows.Forms.DataGridView
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents lblvouno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbacsubgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents vno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narratio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtndebit As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbvou_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
