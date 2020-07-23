<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherDetectionVoucherDr
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtdate = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbvtype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.dtSalaryDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvoucher = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Accode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dramount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cramount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subgrp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtnarr = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtChqNo = New System.Windows.Forms.TextBox
        Me.cmbFreightSubGroup = New System.Windows.Forms.ComboBox
        Me.txtCr = New System.Windows.Forms.TextBox
        Me.txtDr = New System.Windows.Forms.TextBox
        Me.cmbFrightCode = New System.Windows.Forms.ComboBox
        Me.cmbFreightHead = New System.Windows.Forms.ComboBox
        Me.cmbFreightGroup = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbDept = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.lblvouno = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(753, 91)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(753, 37)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Other Detection Voucher"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(632, 48)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(87, 21)
        Me.dtdate.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.CadetBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label13.Location = New System.Drawing.Point(534, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 175
        Me.Label13.Text = "Voucher Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CadetBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(276, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Voucher No:"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(99, 47)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(170, 21)
        Me.cmbvtype.TabIndex = 0
        Me.cmbvtype.Text = "SALARY JOURNAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Voucher Type:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button1.Location = New System.Drawing.Point(653, 649)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnShow.Location = New System.Drawing.Point(632, 101)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(88, 23)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'dtSalaryDate
        '
        Me.dtSalaryDate.CustomFormat = "dd/MMM/yy"
        Me.dtSalaryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSalaryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSalaryDate.Location = New System.Drawing.Point(99, 74)
        Me.dtSalaryDate.Name = "dtSalaryDate"
        Me.dtSalaryDate.Size = New System.Drawing.Size(170, 20)
        Me.dtSalaryDate.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CadetBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 181
        Me.Label4.Text = "Salary Month:"
        '
        'dgvoucher
        '
        Me.dgvoucher.AllowUserToAddRows = False
        Me.dgvoucher.AllowUserToDeleteRows = False
        Me.dgvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.Accode, Me.acname, Me.dramount, Me.cramount, Me.GroupName, Me.subgrp})
        Me.dgvoucher.Location = New System.Drawing.Point(4, 131)
        Me.dgvoucher.Name = "dgvoucher"
        Me.dgvoucher.ReadOnly = True
        Me.dgvoucher.RowTemplate.Height = 20
        Me.dgvoucher.Size = New System.Drawing.Size(749, 451)
        Me.dgvoucher.TabIndex = 182
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
        Me.Accode.Width = 80
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
        'dramount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.dramount.DefaultCellStyle = DataGridViewCellStyle4
        Me.dramount.HeaderText = "Dr. Amount"
        Me.dramount.MaxInputLength = 18
        Me.dramount.Name = "dramount"
        Me.dramount.ReadOnly = True
        Me.dramount.Width = 80
        '
        'cramount
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.cramount.DefaultCellStyle = DataGridViewCellStyle5
        Me.cramount.HeaderText = "Cr Amount"
        Me.cramount.Name = "cramount"
        Me.cramount.ReadOnly = True
        Me.cramount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cramount.Width = 80
        '
        'GroupName
        '
        Me.GroupName.HeaderText = "GroupName"
        Me.GroupName.Name = "GroupName"
        Me.GroupName.ReadOnly = True
        '
        'subgrp
        '
        Me.subgrp.HeaderText = "Sub Group"
        Me.subgrp.Name = "subgrp"
        Me.subgrp.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 585)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Narration"
        '
        'txtnarr
        '
        Me.txtnarr.Location = New System.Drawing.Point(1, 603)
        Me.txtnarr.Multiline = True
        Me.txtnarr.Name = "txtnarr"
        Me.txtnarr.Size = New System.Drawing.Size(500, 30)
        Me.txtnarr.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(504, 585)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Chq No"
        '
        'txtChqNo
        '
        Me.txtChqNo.Location = New System.Drawing.Point(507, 603)
        Me.txtChqNo.Multiline = True
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(246, 30)
        Me.txtChqNo.TabIndex = 9
        '
        'cmbFreightSubGroup
        '
        Me.cmbFreightSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightSubGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightSubGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightSubGroup.FormattingEnabled = True
        Me.cmbFreightSubGroup.Location = New System.Drawing.Point(653, 771)
        Me.cmbFreightSubGroup.Name = "cmbFreightSubGroup"
        Me.cmbFreightSubGroup.Size = New System.Drawing.Size(100, 21)
        Me.cmbFreightSubGroup.TabIndex = 198
        Me.cmbFreightSubGroup.TabStop = False
        '
        'txtCr
        '
        Me.txtCr.Location = New System.Drawing.Point(558, 651)
        Me.txtCr.Name = "txtCr"
        Me.txtCr.Size = New System.Drawing.Size(89, 20)
        Me.txtCr.TabIndex = 13
        '
        'txtDr
        '
        Me.txtDr.Location = New System.Drawing.Point(454, 651)
        Me.txtDr.Name = "txtDr"
        Me.txtDr.Size = New System.Drawing.Size(98, 20)
        Me.txtDr.TabIndex = 12
        '
        'cmbFrightCode
        '
        Me.cmbFrightCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFrightCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFrightCode.BackColor = System.Drawing.Color.White
        Me.cmbFrightCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrightCode.FormattingEnabled = True
        Me.cmbFrightCode.Location = New System.Drawing.Point(325, 651)
        Me.cmbFrightCode.Name = "cmbFrightCode"
        Me.cmbFrightCode.Size = New System.Drawing.Size(123, 21)
        Me.cmbFrightCode.TabIndex = 11
        '
        'cmbFreightHead
        '
        Me.cmbFreightHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightHead.BackColor = System.Drawing.Color.White
        Me.cmbFreightHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightHead.FormattingEnabled = True
        Me.cmbFreightHead.Location = New System.Drawing.Point(1, 651)
        Me.cmbFreightHead.Name = "cmbFreightHead"
        Me.cmbFreightHead.Size = New System.Drawing.Size(318, 21)
        Me.cmbFreightHead.TabIndex = 10
        '
        'cmbFreightGroup
        '
        Me.cmbFreightGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightGroup.FormattingEnabled = True
        Me.cmbFreightGroup.Location = New System.Drawing.Point(558, 746)
        Me.cmbFreightGroup.Name = "cmbFreightGroup"
        Me.cmbFreightGroup.Size = New System.Drawing.Size(89, 21)
        Me.cmbFreightGroup.TabIndex = 199
        Me.cmbFreightGroup.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(555, 635)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 15)
        Me.Label8.TabIndex = 202
        Me.Label8.Text = "Cr"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(453, 638)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 201
        Me.Label7.Text = "Dr"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 631)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 200
        Me.Label9.Text = "Bank A/c Head"
        '
        'cmbDept
        '
        Me.cmbDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDept.BackColor = System.Drawing.Color.White
        Me.cmbDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(363, 74)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(168, 21)
        Me.cmbDept.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.CadetBlue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(271, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 203
        Me.Label11.Text = "Department :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.CadetBlue
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 15)
        Me.Label12.TabIndex = 205
        Me.Label12.Text = "Pay Mode:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CASH", "BANK"})
        Me.ComboBox1.Location = New System.Drawing.Point(99, 99)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'lblvouno
        '
        Me.lblvouno.Location = New System.Drawing.Point(363, 49)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.ReadOnly = True
        Me.lblvouno.Size = New System.Drawing.Size(167, 20)
        Me.lblvouno.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"BOI", "SBI"})
        Me.ComboBox2.Location = New System.Drawing.Point(363, 100)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.CadetBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label14.Location = New System.Drawing.Point(318, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 15)
        Me.Label14.TabIndex = 209
        Me.Label14.Text = "Bank:"
        '
        'frmOtherDetectionVoucherDr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 682)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCr)
        Me.Controls.Add(Me.txtDr)
        Me.Controls.Add(Me.cmbFrightCode)
        Me.Controls.Add(Me.cmbFreightHead)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtChqNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtnarr)
        Me.Controls.Add(Me.dgvoucher)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dtSalaryDate)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbFreightGroup)
        Me.Controls.Add(Me.cmbFreightSubGroup)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOtherDetectionVoucherDr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOtherDetectionVoucher"
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents dtSalaryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents dgvoucher As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnarr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents cmbFreightSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents txtCr As System.Windows.Forms.TextBox
    Friend WithEvents txtDr As System.Windows.Forms.TextBox
    Friend WithEvents cmbFrightCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFreightHead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFreightGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dramount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subgrp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblvouno As System.Windows.Forms.TextBox
    Public WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
