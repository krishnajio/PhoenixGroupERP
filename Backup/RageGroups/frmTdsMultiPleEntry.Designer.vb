<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTdsMultiPleEntry
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtdate = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbvtype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblvouno = New System.Windows.Forms.Label
        Me.cmbTdsper = New System.Windows.Forms.ComboBox
        Me.cmbtdsType = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbFreightGroup = New System.Windows.Forms.ComboBox
        Me.cmbFrightCode = New System.Windows.Forms.ComboBox
        Me.cmbFreightHead = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDr = New System.Windows.Forms.TextBox
        Me.txtCr = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbTdsYn = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.head = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tds = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sgrp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.narr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TdsPartyCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Actual = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TdsType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TdsPer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbFreightSubGroup = New System.Windows.Forms.ComboBox
        Me.txtnarr = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmbPartyGroup = New System.Windows.Forms.ComboBox
        Me.cmbPartCode = New System.Windows.Forms.ComboBox
        Me.cmbPartyHead = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbldr = New System.Windows.Forms.Label
        Me.lblcr = New System.Windows.Forms.Label
        Me.txtActualAmt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpexpensedate = New System.Windows.Forms.DateTimePicker
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_modify = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbgroup = New System.Windows.Forms.ComboBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Honeydew
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(769, 35)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SlateBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(769, 37)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "TDS Multiple  Entry "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(604, 41)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(121, 21)
        Me.dtdate.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Honeydew
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label13.Location = New System.Drawing.Point(497, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 169
        Me.Label13.Text = "Voucher Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Honeydew
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(373, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Voucher No:"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(103, 42)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(264, 21)
        Me.cmbvtype.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Honeydew
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Voucher Type:"
        '
        'lblvouno
        '
        Me.lblvouno.AutoSize = True
        Me.lblvouno.BackColor = System.Drawing.Color.Honeydew
        Me.lblvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblvouno.ForeColor = System.Drawing.Color.Red
        Me.lblvouno.Location = New System.Drawing.Point(460, 42)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.Size = New System.Drawing.Size(14, 18)
        Me.lblvouno.TabIndex = 170
        Me.lblvouno.Text = "-"
        '
        'cmbTdsper
        '
        Me.cmbTdsper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsper.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsper.BackColor = System.Drawing.Color.White
        Me.cmbTdsper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTdsper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsper.FormattingEnabled = True
        Me.cmbTdsper.Location = New System.Drawing.Point(362, 175)
        Me.cmbTdsper.Name = "cmbTdsper"
        Me.cmbTdsper.Size = New System.Drawing.Size(122, 21)
        Me.cmbTdsper.TabIndex = 172
        '
        'cmbtdsType
        '
        Me.cmbtdsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbtdsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtdsType.BackColor = System.Drawing.Color.White
        Me.cmbtdsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtdsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbtdsType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtdsType.FormattingEnabled = True
        Me.cmbtdsType.Location = New System.Drawing.Point(15, 172)
        Me.cmbtdsType.Name = "cmbtdsType"
        Me.cmbtdsType.Size = New System.Drawing.Size(341, 21)
        Me.cmbtdsType.TabIndex = 9
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacheadcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(490, 175)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbacheadcode.TabIndex = 173
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "TDS Type:"
        '
        'cmbFreightGroup
        '
        Me.cmbFreightGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightGroup.FormattingEnabled = True
        Me.cmbFreightGroup.Location = New System.Drawing.Point(376, 134)
        Me.cmbFreightGroup.Name = "cmbFreightGroup"
        Me.cmbFreightGroup.Size = New System.Drawing.Size(72, 21)
        Me.cmbFreightGroup.TabIndex = 178
        '
        'cmbFrightCode
        '
        Me.cmbFrightCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFrightCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFrightCode.BackColor = System.Drawing.Color.White
        Me.cmbFrightCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFrightCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrightCode.FormattingEnabled = True
        Me.cmbFrightCode.Location = New System.Drawing.Point(362, 133)
        Me.cmbFrightCode.Name = "cmbFrightCode"
        Me.cmbFrightCode.Size = New System.Drawing.Size(88, 21)
        Me.cmbFrightCode.TabIndex = 5
        '
        'cmbFreightHead
        '
        Me.cmbFreightHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightHead.BackColor = System.Drawing.Color.White
        Me.cmbFreightHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFreightHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightHead.FormattingEnabled = True
        Me.cmbFreightHead.Location = New System.Drawing.Point(12, 133)
        Me.cmbFreightHead.Name = "cmbFreightHead"
        Me.cmbFreightHead.Size = New System.Drawing.Size(344, 21)
        Me.cmbFreightHead.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "A/c Head"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Dr"
        '
        'txtDr
        '
        Me.txtDr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDr.Location = New System.Drawing.Point(451, 133)
        Me.txtDr.Name = "txtDr"
        Me.txtDr.Size = New System.Drawing.Size(98, 20)
        Me.txtDr.TabIndex = 6
        '
        'txtCr
        '
        Me.txtCr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCr.Location = New System.Drawing.Point(552, 133)
        Me.txtCr.Name = "txtCr"
        Me.txtCr.Size = New System.Drawing.Size(89, 20)
        Me.txtCr.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 15)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "Cr"
        '
        'cmbTdsYn
        '
        Me.cmbTdsYn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsYn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsYn.BackColor = System.Drawing.Color.White
        Me.cmbTdsYn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTdsYn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTdsYn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsYn.FormattingEnabled = True
        Me.cmbTdsYn.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmbTdsYn.Location = New System.Drawing.Point(644, 133)
        Me.cmbTdsYn.Name = "cmbTdsYn"
        Me.cmbTdsYn.Size = New System.Drawing.Size(100, 21)
        Me.cmbTdsYn.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label9.Location = New System.Drawing.Point(641, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 15)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "TDS Entry "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(708, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.head, Me.Code, Me.Dr, Me.Cr, Me.Tds, Me.Grp, Me.sgrp, Me.narr, Me.TdsPartyCode, Me.Actual, Me.TdsType, Me.TdsPer})
        Me.DataGridView1.Location = New System.Drawing.Point(-14, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(777, 281)
        Me.DataGridView1.TabIndex = 23
        '
        'head
        '
        Me.head.HeaderText = "A/c Head"
        Me.head.Name = "head"
        Me.head.ReadOnly = True
        Me.head.Width = 266
        '
        'Code
        '
        Me.Code.HeaderText = "A/c Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.Width = 74
        '
        'Dr
        '
        Me.Dr.HeaderText = "Dr"
        Me.Dr.Name = "Dr"
        Me.Dr.ReadOnly = True
        Me.Dr.Width = 98
        '
        'Cr
        '
        Me.Cr.HeaderText = "Cr"
        Me.Cr.Name = "Cr"
        Me.Cr.ReadOnly = True
        Me.Cr.Width = 89
        '
        'Tds
        '
        Me.Tds.HeaderText = "Tds[Tes/No]"
        Me.Tds.Name = "Tds"
        Me.Tds.ReadOnly = True
        Me.Tds.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Grp
        '
        Me.Grp.HeaderText = "Group Name"
        Me.Grp.Name = "Grp"
        Me.Grp.ReadOnly = True
        '
        'sgrp
        '
        Me.sgrp.HeaderText = "SubGroup"
        Me.sgrp.Name = "sgrp"
        Me.sgrp.ReadOnly = True
        '
        'narr
        '
        Me.narr.HeaderText = "Narration"
        Me.narr.Name = "narr"
        Me.narr.ReadOnly = True
        '
        'TdsPartyCode
        '
        Me.TdsPartyCode.HeaderText = "Tds Party Code"
        Me.TdsPartyCode.Name = "TdsPartyCode"
        Me.TdsPartyCode.ReadOnly = True
        '
        'Actual
        '
        Me.Actual.HeaderText = "Actual Amt"
        Me.Actual.Name = "Actual"
        Me.Actual.ReadOnly = True
        '
        'TdsType
        '
        Me.TdsType.HeaderText = "TdsType"
        Me.TdsType.Name = "TdsType"
        Me.TdsType.ReadOnly = True
        '
        'TdsPer
        '
        Me.TdsPer.HeaderText = "TdsPer"
        Me.TdsPer.Name = "TdsPer"
        Me.TdsPer.ReadOnly = True
        '
        'cmbFreightSubGroup
        '
        Me.cmbFreightSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightSubGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightSubGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFreightSubGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightSubGroup.FormattingEnabled = True
        Me.cmbFreightSubGroup.Location = New System.Drawing.Point(605, 175)
        Me.cmbFreightSubGroup.Name = "cmbFreightSubGroup"
        Me.cmbFreightSubGroup.Size = New System.Drawing.Size(139, 21)
        Me.cmbFreightSubGroup.TabIndex = 187
        '
        'txtnarr
        '
        Me.txtnarr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnarr.Location = New System.Drawing.Point(17, 264)
        Me.txtnarr.Multiline = True
        Me.txtnarr.Name = "txtnarr"
        Me.txtnarr.Size = New System.Drawing.Size(687, 55)
        Me.txtnarr.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Narration"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(330, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 28)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "&Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbPartyGroup
        '
        Me.cmbPartyGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyGroup.BackColor = System.Drawing.Color.White
        Me.cmbPartyGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPartyGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyGroup.FormattingEnabled = True
        Me.cmbPartyGroup.Location = New System.Drawing.Point(490, 222)
        Me.cmbPartyGroup.Name = "cmbPartyGroup"
        Me.cmbPartyGroup.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartyGroup.TabIndex = 194
        '
        'cmbPartCode
        '
        Me.cmbPartCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartCode.BackColor = System.Drawing.Color.White
        Me.cmbPartCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPartCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPartCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartCode.FormattingEnabled = True
        Me.cmbPartCode.Location = New System.Drawing.Point(376, 222)
        Me.cmbPartCode.Name = "cmbPartCode"
        Me.cmbPartCode.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartCode.TabIndex = 193
        '
        'cmbPartyHead
        '
        Me.cmbPartyHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyHead.BackColor = System.Drawing.Color.White
        Me.cmbPartyHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPartyHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyHead.FormattingEnabled = True
        Me.cmbPartyHead.Location = New System.Drawing.Point(15, 223)
        Me.cmbPartyHead.Name = "cmbPartyHead"
        Me.cmbPartyHead.Size = New System.Drawing.Size(357, 21)
        Me.cmbPartyHead.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "Party A/c"
        '
        'lbldr
        '
        Me.lbldr.AutoSize = True
        Me.lbldr.BackColor = System.Drawing.Color.Honeydew
        Me.lbldr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lbldr.ForeColor = System.Drawing.Color.Red
        Me.lbldr.Location = New System.Drawing.Point(380, 630)
        Me.lbldr.Name = "lbldr"
        Me.lbldr.Size = New System.Drawing.Size(14, 18)
        Me.lbldr.TabIndex = 195
        Me.lbldr.Text = "-"
        '
        'lblcr
        '
        Me.lblcr.AutoSize = True
        Me.lblcr.BackColor = System.Drawing.Color.Honeydew
        Me.lblcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblcr.ForeColor = System.Drawing.Color.Red
        Me.lblcr.Location = New System.Drawing.Point(467, 630)
        Me.lblcr.Name = "lblcr"
        Me.lblcr.Size = New System.Drawing.Size(14, 18)
        Me.lblcr.TabIndex = 196
        Me.lblcr.Text = "-"
        '
        'txtActualAmt
        '
        Me.txtActualAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActualAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActualAmt.Location = New System.Drawing.Point(604, 222)
        Me.txtActualAmt.Name = "txtActualAmt"
        Me.txtActualAmt.Size = New System.Drawing.Size(140, 20)
        Me.txtActualAmt.TabIndex = 11
        Me.txtActualAmt.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label12.Location = New System.Drawing.Point(604, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 198
        Me.Label12.Text = "Actual Amount:"
        '
        'dtpexpensedate
        '
        Me.dtpexpensedate.CustomFormat = "dd/MMM/yy"
        Me.dtpexpensedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpensedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexpensedate.Location = New System.Drawing.Point(122, 322)
        Me.dtpexpensedate.Name = "dtpexpensedate"
        Me.dtpexpensedate.Size = New System.Drawing.Size(106, 20)
        Me.dtpexpensedate.TabIndex = 208
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(13, 325)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 16)
        Me.Label23.TabIndex = 209
        Me.Label23.Text = "Expense Date"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(12, 95)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(344, 21)
        Me.cmbAreaName.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 16)
        Me.Label14.TabIndex = 211
        Me.Label14.Text = "Area:"
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(241, 96)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(115, 21)
        Me.cmbAreaCode.TabIndex = 212
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel1.Controls.Add(Me.btn_modify)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 655)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 48)
        Me.Panel1.TabIndex = 213
        '
        'btn_modify
        '
        Me.btn_modify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify.Location = New System.Drawing.Point(399, 7)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(72, 28)
        Me.btn_modify.TabIndex = 1
        Me.btn_modify.Text = "&Modify"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(366, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 15)
        Me.Label15.TabIndex = 215
        Me.Label15.Text = "Group Name:"
        '
        'cmbgroup
        '
        Me.cmbgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroup.BackColor = System.Drawing.Color.White
        Me.cmbgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroup.FormattingEnabled = True
        Me.cmbgroup.Location = New System.Drawing.Point(362, 95)
        Me.cmbgroup.Name = "cmbgroup"
        Me.cmbgroup.Size = New System.Drawing.Size(388, 21)
        Me.cmbgroup.TabIndex = 3
        Me.cmbgroup.TabStop = False
        '
        'frmTdsMultiPleEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 709)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbgroup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpexpensedate)
        Me.Controls.Add(Me.txtActualAmt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblcr)
        Me.Controls.Add(Me.lbldr)
        Me.Controls.Add(Me.cmbPartyGroup)
        Me.Controls.Add(Me.cmbPartCode)
        Me.Controls.Add(Me.cmbPartyHead)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtnarr)
        Me.Controls.Add(Me.cmbFreightSubGroup)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbTdsYn)
        Me.Controls.Add(Me.txtCr)
        Me.Controls.Add(Me.txtDr)
        Me.Controls.Add(Me.cmbFrightCode)
        Me.Controls.Add(Me.cmbFreightHead)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTdsper)
        Me.Controls.Add(Me.cmbtdsType)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbFreightGroup)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label23)
        Me.MaximizeBox = False
        Me.Name = "frmTdsMultiPleEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTdsMultiPleEntry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblvouno As System.Windows.Forms.Label
    Friend WithEvents cmbTdsper As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtdsType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbFreightGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFrightCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFreightHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDr As System.Windows.Forms.TextBox
    Friend WithEvents txtCr As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbTdsYn As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbFreightSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents txtnarr As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbPartyGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbldr As System.Windows.Forms.Label
    Friend WithEvents lblcr As System.Windows.Forms.Label
    Friend WithEvents txtActualAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpexpensedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sgrp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdsPartyCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdsType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdsPer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents cmbgroup As System.Windows.Forms.ComboBox
End Class
