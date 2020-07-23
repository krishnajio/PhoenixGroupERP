<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceipt))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbvoutype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtvdate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAcHead = New System.Windows.Forms.ComboBox
        Me.cmbcode = New System.Windows.Forms.ComboBox
        Me.txtCrmat = New System.Windows.Forms.TextBox
        Me.Cramt = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dg = New System.Windows.Forms.DataGridView
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.txtduedate = New System.Windows.Forms.TextBox
        Me.txtref = New System.Windows.Forms.TextBox
        Me.cmbRefType = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TypeofRef = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtChqNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtvouno = New System.Windows.Forms.TextBox
        Me.cmbgroup = New System.Windows.Forms.ComboBox
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.CmbMobileNo = New System.Windows.Forms.ComboBox
        Me.dtHatchDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(648, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Receipt "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic)
        Me.Label16.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label16.Location = New System.Drawing.Point(0, 521)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(648, 67)
        Me.Label16.TabIndex = 10
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbvoutype
        '
        Me.cmbvoutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvoutype.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvoutype.FormattingEnabled = True
        Me.cmbvoutype.Items.AddRange(New Object() {"SALE"})
        Me.cmbvoutype.Location = New System.Drawing.Point(127, 55)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(130, 25)
        Me.cmbvoutype.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Voucher Type:"
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(361, 58)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(90, 20)
        Me.dtvdate.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Voucher Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "A/c Head:"
        '
        'cmbAcHead
        '
        Me.cmbAcHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAcHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAcHead.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcHead.FormattingEnabled = True
        Me.cmbAcHead.Items.AddRange(New Object() {"SALE"})
        Me.cmbAcHead.Location = New System.Drawing.Point(36, 125)
        Me.cmbAcHead.Name = "cmbAcHead"
        Me.cmbAcHead.Size = New System.Drawing.Size(354, 26)
        Me.cmbAcHead.TabIndex = 4
        '
        'cmbcode
        '
        Me.cmbcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcode.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcode.FormattingEnabled = True
        Me.cmbcode.Items.AddRange(New Object() {"SALE"})
        Me.cmbcode.Location = New System.Drawing.Point(393, 125)
        Me.cmbcode.Name = "cmbcode"
        Me.cmbcode.Size = New System.Drawing.Size(117, 26)
        Me.cmbcode.TabIndex = 5
        '
        'txtCrmat
        '
        Me.txtCrmat.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrmat.Location = New System.Drawing.Point(516, 125)
        Me.txtCrmat.Name = "txtCrmat"
        Me.txtCrmat.Size = New System.Drawing.Size(126, 24)
        Me.txtCrmat.TabIndex = 6
        '
        'Cramt
        '
        Me.Cramt.AutoSize = True
        Me.Cramt.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cramt.Location = New System.Drawing.Point(513, 105)
        Me.Cramt.Name = "Cramt"
        Me.Cramt.Size = New System.Drawing.Size(48, 18)
        Me.Cramt.TabIndex = 138
        Me.Cramt.Text = "CrAmt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtduedate)
        Me.GroupBox1.Controls.Add(Me.txtref)
        Me.GroupBox1.Controls.Add(Me.cmbRefType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 266)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ref Detials"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(128, 54)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(381, 176)
        Me.dg.TabIndex = 6
        Me.dg.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(555, 36)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(34, 28)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(448, 39)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(103, 24)
        Me.txtamount.TabIndex = 4
        '
        'txtduedate
        '
        Me.txtduedate.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduedate.Location = New System.Drawing.Point(361, 39)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.Size = New System.Drawing.Size(81, 24)
        Me.txtduedate.TabIndex = 3
        Me.txtduedate.Text = "2/25/10"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(120, 39)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(236, 24)
        Me.txtref.TabIndex = 2
        '
        'cmbRefType
        '
        Me.cmbRefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRefType.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRefType.FormattingEnabled = True
        Me.cmbRefType.Items.AddRange(New Object() {"-", "Ags Ref", "New Ref", "Advance", "On Account"})
        Me.cmbRefType.Location = New System.Drawing.Point(4, 37)
        Me.cmbRefType.Name = "cmbRefType"
        Me.cmbRefType.Size = New System.Drawing.Size(112, 26)
        Me.cmbRefType.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Type of Ref"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(119, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Due Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(448, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Amount"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeofRef, Me.Ref, Me.DueDate, Me.Amount})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(591, 177)
        Me.DataGridView1.TabIndex = 142
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
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Narration"
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(36, 172)
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ReadOnly = True
        Me.txtNarration.Size = New System.Drawing.Size(474, 73)
        Me.txtNarration.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(466, 257)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 142
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(466, 258)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 143
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(515, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Cheque No:"
        '
        'txtChqNo
        '
        Me.txtChqNo.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqNo.Location = New System.Drawing.Point(516, 172)
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(126, 24)
        Me.txtChqNo.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label11.Location = New System.Drawing.Point(0, 45)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 476)
        Me.Label11.TabIndex = 146
        Me.Label11.Text = "Receipt "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(392, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 18)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "A/c Code:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(454, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 15)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "Voucher No :"
        '
        'txtvouno
        '
        Me.txtvouno.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvouno.Location = New System.Drawing.Point(546, 55)
        Me.txtvouno.Name = "txtvouno"
        Me.txtvouno.ReadOnly = True
        Me.txtvouno.Size = New System.Drawing.Size(85, 24)
        Me.txtvouno.TabIndex = 149
        '
        'cmbgroup
        '
        Me.cmbgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroup.BackColor = System.Drawing.Color.White
        Me.cmbgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroup.FormattingEnabled = True
        Me.cmbgroup.Location = New System.Drawing.Point(361, 81)
        Me.cmbgroup.Name = "cmbgroup"
        Me.cmbgroup.Size = New System.Drawing.Size(270, 21)
        Me.cmbgroup.TabIndex = 14
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(127, 82)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(130, 21)
        Me.cmbAreaName.TabIndex = 2
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(136, 82)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(121, 21)
        Me.cmbAreaCode.TabIndex = 151
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(85, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 18)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "Area:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(270, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 15)
        Me.Label15.TabIndex = 154
        Me.Label15.Text = "Group Name:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Phoenix_GroupERP.My.Resources.Resources.Delete_32x32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(516, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 36)
        Me.Button1.TabIndex = 156
        Me.Button1.Text = "&Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(337, 532)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(85, 36)
        Me.btnPrint.TabIndex = 155
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(150, 532)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(85, 36)
        Me.btnModify.TabIndex = 12
        Me.btnModify.Text = "&Modify"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(237, 532)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 36)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(425, 532)
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
        Me.btnSave.Location = New System.Drawing.Point(71, 532)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 36)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CmbMobileNo
        '
        Me.CmbMobileNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMobileNo.FormattingEnabled = True
        Me.CmbMobileNo.Location = New System.Drawing.Point(368, 82)
        Me.CmbMobileNo.Name = "CmbMobileNo"
        Me.CmbMobileNo.Size = New System.Drawing.Size(121, 21)
        Me.CmbMobileNo.TabIndex = 157
        '
        'dtHatchDate
        '
        Me.dtHatchDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHatchDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtHatchDate.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHatchDate.Location = New System.Drawing.Point(383, 205)
        Me.dtHatchDate.Name = "dtHatchDate"
        Me.dtHatchDate.Size = New System.Drawing.Size(127, 25)
        Me.dtHatchDate.TabIndex = 158
        Me.dtHatchDate.Value = New Date(2000, 1, 1, 17, 7, 0, 0)
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(648, 588)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCrmat)
        Me.Controls.Add(Me.cmbcode)
        Me.Controls.Add(Me.cmbAcHead)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbgroup)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.txtvouno)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtChqNo)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Cramt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbvoutype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CmbMobileNo)
        Me.Controls.Add(Me.dtHatchDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceipt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbvoutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAcHead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcode As System.Windows.Forms.ComboBox
    Friend WithEvents txtCrmat As System.Windows.Forms.TextBox
    Friend WithEvents Cramt As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtduedate As System.Windows.Forms.TextBox
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents cmbRefType As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TypeofRef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtvouno As System.Windows.Forms.TextBox
    Public WithEvents cmbgroup As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmbMobileNo As System.Windows.Forms.ComboBox
    Friend WithEvents dtHatchDate As System.Windows.Forms.DateTimePicker
End Class
