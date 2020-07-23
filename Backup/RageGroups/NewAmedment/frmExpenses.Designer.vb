<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpenses))
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtChqNo = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Cramt = New System.Windows.Forms.Label
        Me.txtCrmat = New System.Windows.Forms.TextBox
        Me.cmbcode = New System.Windows.Forms.ComboBox
        Me.cmbAcHead = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbvoutype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDramt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.dgPayment = New System.Windows.Forms.DataGridView
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dr1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cr1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.g = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.s = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.lblDr = New System.Windows.Forms.Label
        Me.lblcr = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtvou_no = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbgroup = New System.Windows.Forms.ComboBox
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.cmbExpType = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbprdunit = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbdetials = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpexpensedate = New System.Windows.Forms.DateTimePicker
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.dtvdate = New System.Windows.Forms.DateTimePicker
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 469)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "Cheque No"
        '
        'txtChqNo
        '
        Me.txtChqNo.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqNo.Location = New System.Drawing.Point(107, 466)
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(106, 24)
        Me.txtChqNo.TabIndex = 13
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
        Me.Cramt.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cramt.Location = New System.Drawing.Point(588, 112)
        Me.Cramt.Name = "Cramt"
        Me.Cramt.Size = New System.Drawing.Size(48, 18)
        Me.Cramt.TabIndex = 155
        Me.Cramt.Text = "CrAmt"
        '
        'txtCrmat
        '
        Me.txtCrmat.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrmat.Location = New System.Drawing.Point(586, 131)
        Me.txtCrmat.Name = "txtCrmat"
        Me.txtCrmat.Size = New System.Drawing.Size(101, 24)
        Me.txtCrmat.TabIndex = 9
        Me.txtCrmat.Text = "0.0"
        '
        'cmbcode
        '
        Me.cmbcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcode.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcode.FormattingEnabled = True
        Me.cmbcode.Items.AddRange(New Object() {"SALE"})
        Me.cmbcode.Location = New System.Drawing.Point(387, 132)
        Me.cmbcode.Name = "cmbcode"
        Me.cmbcode.Size = New System.Drawing.Size(95, 26)
        Me.cmbcode.TabIndex = 7
        '
        'cmbAcHead
        '
        Me.cmbAcHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAcHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAcHead.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcHead.FormattingEnabled = True
        Me.cmbAcHead.Items.AddRange(New Object() {"SALE"})
        Me.cmbAcHead.Location = New System.Drawing.Point(30, 132)
        Me.cmbAcHead.Name = "cmbAcHead"
        Me.cmbAcHead.Size = New System.Drawing.Size(354, 26)
        Me.cmbAcHead.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "A/c Head:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(273, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Voucher Date :"
        '
        'cmbvoutype
        '
        Me.cmbvoutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvoutype.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvoutype.FormattingEnabled = True
        Me.cmbvoutype.Items.AddRange(New Object() {"SALE"})
        Me.cmbvoutype.Location = New System.Drawing.Point(132, 43)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(137, 24)
        Me.cmbvoutype.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Voucher Type:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1036, 40)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Expenses"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(482, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "DrAmt"
        '
        'txtDramt
        '
        Me.txtDramt.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDramt.Location = New System.Drawing.Point(485, 132)
        Me.txtDramt.Name = "txtDramt"
        Me.txtDramt.Size = New System.Drawing.Size(97, 24)
        Me.txtDramt.TabIndex = 8
        Me.txtDramt.Text = "0.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(384, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "A/c Code:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label6.Location = New System.Drawing.Point(0, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 456)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Expenses"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(981, 133)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(37, 28)
        Me.btnOk.TabIndex = 12
        Me.btnOk.Text = "&Add"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'dgPayment
        '
        Me.dgPayment.AllowUserToAddRows = False
        Me.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acname, Me.code, Me.dr1, Me.Cr1, Me.g, Me.s, Me.Narration})
        Me.dgPayment.Location = New System.Drawing.Point(30, 164)
        Me.dgPayment.Name = "dgPayment"
        Me.dgPayment.ReadOnly = True
        Me.dgPayment.Size = New System.Drawing.Size(988, 301)
        Me.dgPayment.TabIndex = 19
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
        Me.Narration.Width = 350
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(758, 112)
        Me.txtNarration.MaxLength = 180
        Me.txtNarration.Multiline = True
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.Size = New System.Drawing.Size(217, 46)
        Me.txtNarration.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(755, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Narration"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic)
        Me.Label16.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label16.Location = New System.Drawing.Point(0, 496)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1036, 49)
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
        Me.lblDr.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr.ForeColor = System.Drawing.Color.Red
        Me.lblDr.Location = New System.Drawing.Point(439, 473)
        Me.lblDr.Name = "lblDr"
        Me.lblDr.Size = New System.Drawing.Size(14, 19)
        Me.lblDr.TabIndex = 176
        Me.lblDr.Text = "-"
        '
        'lblcr
        '
        Me.lblcr.AutoSize = True
        Me.lblcr.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcr.ForeColor = System.Drawing.Color.Red
        Me.lblcr.Location = New System.Drawing.Point(519, 476)
        Me.lblcr.Name = "lblcr"
        Me.lblcr.Size = New System.Drawing.Size(14, 19)
        Me.lblcr.TabIndex = 177
        Me.lblcr.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(513, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 179
        Me.Label14.Text = "Voucher No"
        '
        'txtvou_no
        '
        Me.txtvou_no.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvou_no.Location = New System.Drawing.Point(594, 46)
        Me.txtvou_no.Name = "txtvou_no"
        Me.txtvou_no.ReadOnly = True
        Me.txtvou_no.Size = New System.Drawing.Size(96, 21)
        Me.txtvou_no.TabIndex = 178
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(282, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 15)
        Me.Label15.TabIndex = 183
        Me.Label15.Text = "Group Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(92, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 18)
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
        Me.cmbgroup.Location = New System.Drawing.Point(375, 91)
        Me.cmbgroup.Name = "cmbgroup"
        Me.cmbgroup.Size = New System.Drawing.Size(315, 21)
        Me.cmbgroup.TabIndex = 20
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(132, 97)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(137, 21)
        Me.cmbAreaName.TabIndex = 4
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(134, 97)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(109, 21)
        Me.cmbAreaCode.TabIndex = 180
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(420, 502)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(85, 36)
        Me.btnModify.TabIndex = 17
        Me.btnModify.Text = "&Modify"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(598, 502)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 36)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "&Close"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(509, 502)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 36)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "&Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(331, 502)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cmbExpType
        '
        Me.cmbExpType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbExpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpType.DropDownWidth = 200
        Me.cmbExpType.FormattingEnabled = True
        Me.cmbExpType.IntegralHeight = False
        Me.cmbExpType.Items.AddRange(New Object() {"SALE", "PRODUCTION", "OTHERs"})
        Me.cmbExpType.Location = New System.Drawing.Point(375, 69)
        Me.cmbExpType.Name = "cmbExpType"
        Me.cmbExpType.Size = New System.Drawing.Size(131, 21)
        Me.cmbExpType.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(278, 69)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 18)
        Me.Label21.TabIndex = 200
        Me.Label21.Text = "Expense Type:"
        '
        'cmbprdunit
        '
        Me.cmbprdunit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbprdunit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbprdunit.BackColor = System.Drawing.Color.White
        Me.cmbprdunit.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprdunit.FormattingEnabled = True
        Me.cmbprdunit.Location = New System.Drawing.Point(132, 69)
        Me.cmbprdunit.Name = "cmbprdunit"
        Me.cmbprdunit.Size = New System.Drawing.Size(137, 25)
        Me.cmbprdunit.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(63, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 15)
        Me.Label23.TabIndex = 203
        Me.Label23.Text = "Prd. Unit:"
        '
        'cmbdetials
        '
        Me.cmbdetials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdetials.FormattingEnabled = True
        Me.cmbdetials.Items.AddRange(New Object() {"NO", "YES"})
        Me.cmbdetials.Location = New System.Drawing.Point(692, 133)
        Me.cmbdetials.Name = "cmbdetials"
        Me.cmbdetials.Size = New System.Drawing.Size(60, 23)
        Me.cmbdetials.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(226, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 18)
        Me.Label11.TabIndex = 205
        Me.Label11.Text = "Expense Date"
        '
        'dtpexpensedate
        '
        Me.dtpexpensedate.CustomFormat = "dd/MMM/yy"
        Me.dtpexpensedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpexpensedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpexpensedate.Location = New System.Drawing.Point(317, 471)
        Me.dtpexpensedate.Name = "dtpexpensedate"
        Me.dtpexpensedate.Size = New System.Drawing.Size(106, 20)
        Me.dtpexpensedate.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(696, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox1.TabIndex = 206
        Me.CheckBox1.Text = "TDS Entry"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(375, 43)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(130, 21)
        Me.dtvdate.TabIndex = 1
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1036, 545)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.dtpexpensedate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbdetials)
        Me.Controls.Add(Me.cmbprdunit)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmbExpType)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbgroup)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.Label14)
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
        Me.Controls.Add(Me.cmbAreaCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJournal"
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbExpType As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents cmbprdunit As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbdetials As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpexpensedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cr1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
End Class
