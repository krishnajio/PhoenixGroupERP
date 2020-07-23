<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtduedate = New System.Windows.Forms.TextBox()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.cmbRefType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TypeofRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dtpexpensedate = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(847, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "Cheque No"
        '
        'txtChqNo
        '
        Me.txtChqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqNo.Location = New System.Drawing.Point(847, 139)
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(103, 22)
        Me.txtChqNo.TabIndex = 8
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
        Me.Cramt.Location = New System.Drawing.Point(473, 117)
        Me.Cramt.Name = "Cramt"
        Me.Cramt.Size = New System.Drawing.Size(49, 16)
        Me.Cramt.TabIndex = 155
        Me.Cramt.Text = "CrAmt"
        '
        'txtCrmat
        '
        Me.txtCrmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrmat.Location = New System.Drawing.Point(474, 139)
        Me.txtCrmat.Name = "txtCrmat"
        Me.txtCrmat.Size = New System.Drawing.Size(106, 22)
        Me.txtCrmat.TabIndex = 6
        Me.txtCrmat.Text = "0.0"
        '
        'cmbcode
        '
        Me.cmbcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcode.FormattingEnabled = True
        Me.cmbcode.Items.AddRange(New Object() {"SALE"})
        Me.cmbcode.Location = New System.Drawing.Point(195, 111)
        Me.cmbcode.Name = "cmbcode"
        Me.cmbcode.Size = New System.Drawing.Size(163, 24)
        Me.cmbcode.TabIndex = 4
        '
        'cmbAcHead
        '
        Me.cmbAcHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAcHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAcHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcHead.FormattingEnabled = True
        Me.cmbAcHead.Items.AddRange(New Object() {"SALE"})
        Me.cmbAcHead.Location = New System.Drawing.Point(33, 137)
        Me.cmbAcHead.Name = "cmbAcHead"
        Me.cmbAcHead.Size = New System.Drawing.Size(325, 24)
        Me.cmbAcHead.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "A/c Head:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(268, 59)
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
        Me.cmbvoutype.Items.AddRange(New Object() {"SALE"})
        Me.cmbvoutype.Location = New System.Drawing.Point(132, 53)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(130, 21)
        Me.cmbvoutype.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 56)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(994, 43)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Payment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(367, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "DrAmt"
        '
        'txtDramt
        '
        Me.txtDramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDramt.Location = New System.Drawing.Point(367, 139)
        Me.txtDramt.Name = "txtDramt"
        Me.txtDramt.Size = New System.Drawing.Size(101, 22)
        Me.txtDramt.TabIndex = 5
        Me.txtDramt.Text = "0.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 115)
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
        Me.Label6.Location = New System.Drawing.Point(0, 43)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 591)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Payment"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(953, 134)
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
        Me.dgPayment.Location = New System.Drawing.Point(33, 167)
        Me.dgPayment.Name = "dgPayment"
        Me.dgPayment.ReadOnly = True
        Me.dgPayment.Size = New System.Drawing.Size(962, 245)
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
        Me.txtNarration.Location = New System.Drawing.Point(586, 111)
        Me.txtNarration.MaxLength = 180
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(255, 50)
        Me.txtNarration.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(583, 93)
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
        Me.btnModify.Location = New System.Drawing.Point(273, 641)
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
        Me.btnDelete.Location = New System.Drawing.Point(455, 641)
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
        Me.btnReset.Location = New System.Drawing.Point(364, 641)
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
        Me.btnSave.Location = New System.Drawing.Point(184, 641)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 11
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
        Me.Label16.Location = New System.Drawing.Point(0, 634)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(994, 53)
        Me.Label16.TabIndex = 19
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtamount)
        Me.GroupBox1.Controls.Add(Me.txtduedate)
        Me.GroupBox1.Controls.Add(Me.txtref)
        Me.GroupBox1.Controls.Add(Me.cmbRefType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 445)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(681, 173)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ref Detials"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(124, 54)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(381, 147)
        Me.dg.TabIndex = 6
        Me.dg.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(531, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(448, 37)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(81, 22)
        Me.txtamount.TabIndex = 4
        '
        'txtduedate
        '
        Me.txtduedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduedate.Location = New System.Drawing.Point(361, 37)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.Size = New System.Drawing.Size(81, 22)
        Me.txtduedate.TabIndex = 3
        Me.txtduedate.Text = "2/25/10"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(120, 37)
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
        Me.cmbRefType.Location = New System.Drawing.Point(4, 35)
        Me.cmbRefType.Name = "cmbRefType"
        Me.cmbRefType.Size = New System.Drawing.Size(112, 24)
        Me.cmbRefType.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Type of Ref"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(119, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 133
        Me.Label11.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(360, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Due Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(448, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Amount"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeofRef, Me.Ref, Me.DueDate, Me.Amount})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(554, 126)
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
        Me.lblDr.Location = New System.Drawing.Point(461, 415)
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
        Me.lblcr.Location = New System.Drawing.Point(568, 415)
        Me.lblcr.Name = "lblcr"
        Me.lblcr.Size = New System.Drawing.Size(14, 18)
        Me.lblcr.TabIndex = 177
        Me.lblcr.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(649, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 16)
        Me.Label14.TabIndex = 179
        Me.Label14.Text = "Voucher No"
        '
        'txtvou_no
        '
        Me.txtvou_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvou_no.Location = New System.Drawing.Point(744, 53)
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
        Me.chkpayment.Location = New System.Drawing.Point(42, 91)
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
        Me.lblpartycode.Location = New System.Drawing.Point(39, 72)
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
        Me.dtvdate.Location = New System.Drawing.Point(375, 55)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(110, 21)
        Me.dtvdate.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(491, 56)
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
        Me.cmbAreaName.Location = New System.Drawing.Point(527, 54)
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
        Me.cmbAreaCode.Location = New System.Drawing.Point(527, 54)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(115, 21)
        Me.cmbAreaCode.TabIndex = 184
        '
        'dtpexpensedate
        '
        Me.dtpexpensedate.CustomFormat = "dd/MMM/yy"
        Me.dtpexpensedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpensedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexpensedate.Location = New System.Drawing.Point(150, 416)
        Me.dtpexpensedate.Name = "dtpexpensedate"
        Me.dtpexpensedate.Size = New System.Drawing.Size(106, 20)
        Me.dtpexpensedate.TabIndex = 210
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(39, 415)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 16)
        Me.Label23.TabIndex = 211
        Me.Label23.Text = "Expense Date"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(994, 687)
        Me.Controls.Add(Me.dtpexpensedate)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.lblpartycode)
        Me.Controls.Add(Me.chkpayment)
        Me.Controls.Add(Me.txtvou_no)
        Me.Controls.Add(Me.lblcr)
        Me.Controls.Add(Me.lblDr)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtduedate As System.Windows.Forms.TextBox
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents cmbRefType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TypeofRef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents dtpexpensedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
