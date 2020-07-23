<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJournal))
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
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblDr = New System.Windows.Forms.Label()
        Me.lblcr = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtvou_no = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbgroup = New System.Windows.Forms.ComboBox()
        Me.cmbAreaName = New System.Windows.Forms.ComboBox()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpexpensedate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtvdate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtduedate = New System.Windows.Forms.TextBox()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.cmbRefType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TypeofRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkpayment = New System.Windows.Forms.CheckBox()
        Me.CmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtTrNo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCollectionDm = New System.Windows.Forms.TextBox()
        Me.dtRecDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDisdurNo = New System.Windows.Forms.TextBox()
        Me.txtCollectinRec = New System.Windows.Forms.TextBox()
        Me.dthatchdate = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(935, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "Cheque No"
        '
        'txtChqNo
        '
        Me.txtChqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqNo.Location = New System.Drawing.Point(935, 118)
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(89, 22)
        Me.txtChqNo.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(427, 10)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox2.TabIndex = 156
        '
        'Cramt
        '
        Me.Cramt.AutoSize = True
        Me.Cramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cramt.Location = New System.Drawing.Point(545, 96)
        Me.Cramt.Name = "Cramt"
        Me.Cramt.Size = New System.Drawing.Size(49, 16)
        Me.Cramt.TabIndex = 155
        Me.Cramt.Text = "CrAmt"
        '
        'txtCrmat
        '
        Me.txtCrmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrmat.Location = New System.Drawing.Point(545, 117)
        Me.txtCrmat.Name = "txtCrmat"
        Me.txtCrmat.Size = New System.Drawing.Size(71, 22)
        Me.txtCrmat.TabIndex = 7
        Me.txtCrmat.Text = "0.0"
        '
        'cmbcode
        '
        Me.cmbcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcode.FormattingEnabled = True
        Me.cmbcode.Items.AddRange(New Object() {"SALE"})
        Me.cmbcode.Location = New System.Drawing.Point(380, 115)
        Me.cmbcode.Name = "cmbcode"
        Me.cmbcode.Size = New System.Drawing.Size(80, 23)
        Me.cmbcode.TabIndex = 5
        '
        'cmbAcHead
        '
        Me.cmbAcHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAcHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAcHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcHead.FormattingEnabled = True
        Me.cmbAcHead.Items.AddRange(New Object() {"SALE"})
        Me.cmbAcHead.Location = New System.Drawing.Point(29, 114)
        Me.cmbAcHead.Name = "cmbAcHead"
        Me.cmbAcHead.Size = New System.Drawing.Size(346, 24)
        Me.cmbAcHead.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "A/c Head:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(289, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Voucher Date :"
        '
        'cmbvoutype
        '
        Me.cmbvoutype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvoutype.FormattingEnabled = True
        Me.cmbvoutype.Items.AddRange(New Object() {"SALE"})
        Me.cmbvoutype.Location = New System.Drawing.Point(117, 42)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(172, 21)
        Me.cmbvoutype.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Voucher Type:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1156, 40)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Journal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(461, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "DrAmt"
        '
        'txtDramt
        '
        Me.txtDramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDramt.Location = New System.Drawing.Point(464, 117)
        Me.txtDramt.Name = "txtDramt"
        Me.txtDramt.Size = New System.Drawing.Size(78, 22)
        Me.txtDramt.TabIndex = 6
        Me.txtDramt.Text = "0.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(380, 96)
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
        Me.Label6.Location = New System.Drawing.Point(0, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 671)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Journal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(1110, 110)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(34, 28)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'dgPayment
        '
        Me.dgPayment.AllowUserToAddRows = False
        Me.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acname, Me.code, Me.dr1, Me.Cr1, Me.g, Me.s, Me.Narration, Me.ChequeNo})
        Me.dgPayment.Location = New System.Drawing.Point(30, 146)
        Me.dgPayment.Name = "dgPayment"
        Me.dgPayment.ReadOnly = True
        Me.dgPayment.Size = New System.Drawing.Size(1095, 251)
        Me.dgPayment.TabIndex = 12
        Me.dgPayment.TabStop = False
        '
        'acname
        '
        Me.acname.HeaderText = "A/c NAme"
        Me.acname.Name = "acname"
        Me.acname.ReadOnly = True
        Me.acname.Width = 200
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
        '
        'Cr1
        '
        Me.Cr1.HeaderText = "CrAmt"
        Me.Cr1.Name = "Cr1"
        Me.Cr1.ReadOnly = True
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
        Me.Narration.Width = 350
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
        Me.txtNarration.Location = New System.Drawing.Point(620, 93)
        Me.txtNarration.MaxLength = 180
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(309, 48)
        Me.txtNarration.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(617, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Narration"
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(339, 662)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(85, 36)
        Me.btnModify.TabIndex = 24
        Me.btnModify.Text = "&Modify"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(517, 662)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 36)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "&Close"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(426, 662)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 36)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "&Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(250, 662)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic)
        Me.Label16.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label16.Location = New System.Drawing.Point(0, 711)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1156, 61)
        Me.Label16.TabIndex = 15
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(516, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox1.TabIndex = 175
        '
        'lblDr
        '
        Me.lblDr.AutoSize = True
        Me.lblDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr.ForeColor = System.Drawing.Color.Red
        Me.lblDr.Location = New System.Drawing.Point(503, 407)
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
        Me.lblcr.Location = New System.Drawing.Point(606, 407)
        Me.lblcr.Name = "lblcr"
        Me.lblcr.Size = New System.Drawing.Size(14, 18)
        Me.lblcr.TabIndex = 177
        Me.lblcr.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(483, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 16)
        Me.Label14.TabIndex = 179
        Me.Label14.Text = "Voucher No"
        '
        'txtvou_no
        '
        Me.txtvou_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvou_no.Location = New System.Drawing.Point(561, 45)
        Me.txtvou_no.Name = "txtvou_no"
        Me.txtvou_no.ReadOnly = True
        Me.txtvou_no.Size = New System.Drawing.Size(68, 20)
        Me.txtvou_no.TabIndex = 178
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(788, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 15)
        Me.Label15.TabIndex = 183
        Me.Label15.Text = "Group Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(630, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Area:"
        '
        'cmbgroup
        '
        Me.cmbgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroup.BackColor = System.Drawing.Color.White
        Me.cmbgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroup.FormattingEnabled = True
        Me.cmbgroup.Location = New System.Drawing.Point(880, 42)
        Me.cmbgroup.Name = "cmbgroup"
        Me.cmbgroup.Size = New System.Drawing.Size(245, 21)
        Me.cmbgroup.TabIndex = 181
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(669, 43)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(115, 21)
        Me.cmbAreaName.TabIndex = 2
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(669, 44)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(115, 21)
        Me.cmbAreaCode.TabIndex = 18
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MMM/yy"
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(105, 401)
        Me.dtpdate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(116, 21)
        Me.dtpdate.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 215
        Me.Label11.Text = "Due Date"
        '
        'dtpexpensedate
        '
        Me.dtpexpensedate.CustomFormat = "dd/MMM/yy"
        Me.dtpexpensedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpensedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexpensedate.Location = New System.Drawing.Point(331, 403)
        Me.dtpexpensedate.Name = "dtpexpensedate"
        Me.dtpexpensedate.Size = New System.Drawing.Size(116, 20)
        Me.dtpexpensedate.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(227, 403)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 16)
        Me.Label12.TabIndex = 217
        Me.Label12.Text = "Expense Date"
        '
        'dtvdate
        '
        Me.dtvdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(381, 44)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(103, 20)
        Me.dtvdate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtduedate)
        Me.GroupBox1.Controls.Add(Me.txtref)
        Me.GroupBox1.Controls.Add(Me.cmbRefType)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(1065, 403)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(60, 16)
        Me.GroupBox1.TabIndex = 600
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
        Me.dg.Size = New System.Drawing.Size(381, 132)
        Me.dg.TabIndex = 6
        Me.dg.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(555, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(448, 39)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(103, 22)
        Me.txtamount.TabIndex = 4
        '
        'txtduedate
        '
        Me.txtduedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduedate.Location = New System.Drawing.Point(361, 39)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.Size = New System.Drawing.Size(81, 22)
        Me.txtduedate.TabIndex = 3
        Me.txtduedate.Text = "2/25/10"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(120, 39)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(236, 22)
        Me.txtref.TabIndex = 2
        '
        'cmbRefType
        '
        Me.cmbRefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRefType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRefType.FormattingEnabled = True
        Me.cmbRefType.Items.AddRange(New Object() {"-", "Ags Ref", "New Ref", "Advance", "On Account"})
        Me.cmbRefType.Location = New System.Drawing.Point(4, 37)
        Me.cmbRefType.Name = "cmbRefType"
        Me.cmbRefType.Size = New System.Drawing.Size(112, 24)
        Me.cmbRefType.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 16)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "Type of Ref"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(119, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 16)
        Me.Label17.TabIndex = 133
        Me.Label17.Text = "Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(360, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 16)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "Due Date"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(448, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 16)
        Me.Label19.TabIndex = 131
        Me.Label19.Text = "Amount"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeofRef, Me.Ref, Me.DueDate, Me.Amount, Me.AcCode})
        Me.DataGridView1.Location = New System.Drawing.Point(143, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(452, 91)
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
        'AcCode
        '
        Me.AcCode.HeaderText = "AcCode"
        Me.AcCode.Name = "AcCode"
        Me.AcCode.ReadOnly = True
        '
        'chkpayment
        '
        Me.chkpayment.AutoSize = True
        Me.chkpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpayment.ForeColor = System.Drawing.Color.Red
        Me.chkpayment.Location = New System.Drawing.Point(306, 96)
        Me.chkpayment.Name = "chkpayment"
        Me.chkpayment.Size = New System.Drawing.Size(70, 17)
        Me.chkpayment.TabIndex = 4
        Me.chkpayment.Text = "Receipt"
        Me.chkpayment.UseVisualStyleBackColor = True
        '
        'CmbPayMethod
        '
        Me.CmbPayMethod.FormattingEnabled = True
        Me.CmbPayMethod.Items.AddRange(New Object() {"-", "TRAN", "CASH", "RTGS", "NEFT"})
        Me.CmbPayMethod.Location = New System.Drawing.Point(1030, 116)
        Me.CmbPayMethod.Name = "CmbPayMethod"
        Me.CmbPayMethod.Size = New System.Drawing.Size(74, 21)
        Me.CmbPayMethod.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Controls.Add(Me.txtTrNo)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtRem)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtCollectionDm)
        Me.Panel1.Controls.Add(Me.dtRecDate)
        Me.Panel1.Controls.Add(Me.txtDisdurNo)
        Me.Panel1.Controls.Add(Me.txtCollectinRec)
        Me.Panel1.Controls.Add(Me.dthatchdate)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Location = New System.Drawing.Point(35, 429)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 210)
        Me.Panel1.TabIndex = 15
        Me.Panel1.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(163, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 16)
        Me.Label20.TabIndex = 163
        Me.Label20.Text = "Area:"
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.BackColor = System.Drawing.Color.White
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(214, 5)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(173, 24)
        Me.ComboBox3.TabIndex = 15
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.BackColor = System.Drawing.Color.White
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(393, 5)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(107, 24)
        Me.ComboBox4.TabIndex = 16
        Me.ComboBox4.TabStop = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(348, 32)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(13, 16)
        Me.lblId.TabIndex = 161
        Me.lblId.Text = "-"
        '
        'txtTrNo
        '
        Me.txtTrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrNo.Location = New System.Drawing.Point(214, 178)
        Me.txtTrNo.Name = "txtTrNo"
        Me.txtTrNo.Size = New System.Drawing.Size(128, 21)
        Me.txtTrNo.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(141, 181)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 16)
        Me.Label21.TabIndex = 160
        Me.Label21.Text = "T.R No :"
        '
        'txtRem
        '
        Me.txtRem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRem.Location = New System.Drawing.Point(214, 125)
        Me.txtRem.Multiline = True
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(278, 49)
        Me.txtRem.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(128, 126)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 16)
        Me.Label22.TabIndex = 159
        Me.Label22.Text = "Remarks :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 103)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(192, 16)
        Me.Label23.TabIndex = 158
        Me.Label23.Text = "Total Collection Received:"
        '
        'txtCollectionDm
        '
        Me.txtCollectionDm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollectionDm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectionDm.Location = New System.Drawing.Point(214, 78)
        Me.txtCollectionDm.Name = "txtCollectionDm"
        Me.txtCollectionDm.Size = New System.Drawing.Size(128, 21)
        Me.txtCollectionDm.TabIndex = 19
        Me.txtCollectionDm.Text = "0"
        '
        'dtRecDate
        '
        Me.dtRecDate.CustomFormat = "dd/MMM/yy"
        Me.dtRecDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRecDate.Location = New System.Drawing.Point(402, 49)
        Me.dtRecDate.Name = "dtRecDate"
        Me.dtRecDate.Size = New System.Drawing.Size(105, 22)
        Me.dtRecDate.TabIndex = 148
        Me.dtRecDate.Visible = False
        '
        'txtDisdurNo
        '
        Me.txtDisdurNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisdurNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisdurNo.Location = New System.Drawing.Point(214, 30)
        Me.txtDisdurNo.Name = "txtDisdurNo"
        Me.txtDisdurNo.Size = New System.Drawing.Size(128, 21)
        Me.txtDisdurNo.TabIndex = 17
        '
        'txtCollectinRec
        '
        Me.txtCollectinRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollectinRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectinRec.Location = New System.Drawing.Point(214, 102)
        Me.txtCollectinRec.Name = "txtCollectinRec"
        Me.txtCollectinRec.Size = New System.Drawing.Size(128, 21)
        Me.txtCollectinRec.TabIndex = 20
        '
        'dthatchdate
        '
        Me.dthatchdate.CustomFormat = "dd/MMM/yy"
        Me.dthatchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthatchdate.Location = New System.Drawing.Point(214, 54)
        Me.dthatchdate.Name = "dthatchdate"
        Me.dthatchdate.Size = New System.Drawing.Size(105, 22)
        Me.dthatchdate.TabIndex = 18
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(58, 79)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(148, 16)
        Me.Label26.TabIndex = 147
        Me.Label26.Text = "Total Collection Dm:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(75, 33)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(131, 16)
        Me.Label27.TabIndex = 155
        Me.Label27.Text = "Disbursement No:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(113, 54)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(93, 16)
        Me.Label28.TabIndex = 154
        Me.Label28.Text = "Hatch Date :"
        '
        'frmJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1156, 772)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmbPayMethod)
        Me.Controls.Add(Me.chkpayment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.dtpexpensedate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbgroup)
        Me.Controls.Add(Me.cmbAreaName)
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
        Me.Controls.Add(Me.cmbvoutype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmJournal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJournal"
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents cmbgroup As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpexpensedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtduedate As System.Windows.Forms.TextBox
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents cmbRefType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkpayment As System.Windows.Forms.CheckBox
    Friend WithEvents TypeofRef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtTrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtRem As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCollectionDm As System.Windows.Forms.TextBox
    Friend WithEvents dtRecDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDisdurNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCollectinRec As System.Windows.Forms.TextBox
    Friend WithEvents dthatchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
