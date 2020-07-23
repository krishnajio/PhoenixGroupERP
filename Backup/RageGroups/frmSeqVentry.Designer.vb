<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeqVentry
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.lblvouno = New System.Windows.Forms.TextBox
        Me.dtvdate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbvtype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgSeqvoucher = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Accode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chequeno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.drcr = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblcrsum = New System.Windows.Forms.Label
        Me.lbldrsum = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.panelachead = New System.Windows.Forms.Panel
        Me.cmbacheadcodelist = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbacheadlist = New System.Windows.Forms.ComboBox
        Me.lblvouseq = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.txtSearth = New System.Windows.Forms.TextBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        CType(Me.dgSeqvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelachead.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(804, 31)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Sequential Voucher Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(617, 37)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(56, 20)
        Me.CheckBox3.TabIndex = 98
        Me.CheckBox3.Text = "Lock"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'lblvouno
        '
        Me.lblvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvouno.Location = New System.Drawing.Point(512, 36)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.ReadOnly = True
        Me.lblvouno.Size = New System.Drawing.Size(100, 22)
        Me.lblvouno.TabIndex = 97
        Me.lblvouno.TabStop = False
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(233, 63)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(104, 22)
        Me.dtvdate.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(129, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Voucher Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(414, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Voucher No. :"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(233, 36)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(168, 21)
        Me.cmbvtype.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Voucher Type :"
        '
        'dgSeqvoucher
        '
        Me.dgSeqvoucher.AllowUserToAddRows = False
        Me.dgSeqvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSeqvoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.Accode, Me.acname, Me.narration, Me.chequeno, Me.amount, Me.drcr})
        Me.dgSeqvoucher.Location = New System.Drawing.Point(-1, 91)
        Me.dgSeqvoucher.Name = "dgSeqvoucher"
        Me.dgSeqvoucher.RowTemplate.Height = 21
        Me.dgSeqvoucher.Size = New System.Drawing.Size(805, 354)
        Me.dgSeqvoucher.TabIndex = 99
        '
        'srno
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srno.DefaultCellStyle = DataGridViewCellStyle1
        Me.srno.HeaderText = "Sr. No."
        Me.srno.MaxInputLength = 2
        Me.srno.Name = "srno"
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
        'narration
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.narration.DefaultCellStyle = DataGridViewCellStyle4
        Me.narration.HeaderText = "Narration"
        Me.narration.MaxInputLength = 180
        Me.narration.Name = "narration"
        Me.narration.Width = 200
        '
        'chequeno
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chequeno.DefaultCellStyle = DataGridViewCellStyle5
        Me.chequeno.HeaderText = "Cheque No."
        Me.chequeno.MaxInputLength = 15
        Me.chequeno.Name = "chequeno"
        Me.chequeno.Width = 80
        '
        'amount
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.amount.HeaderText = "Amount"
        Me.amount.MaxInputLength = 18
        Me.amount.Name = "amount"
        Me.amount.Width = 80
        '
        'drcr
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drcr.DefaultCellStyle = DataGridViewCellStyle7
        Me.drcr.HeaderText = "Dr/Cr"
        Me.drcr.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.drcr.Name = "drcr"
        Me.drcr.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.drcr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.drcr.Width = 50
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 505)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(804, 29)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "F4 - NARRATION LIST | F3 -  PREVIOUS NARRATION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblcrsum)
        Me.Panel1.Controls.Add(Me.lbldrsum)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(1, 458)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 43)
        Me.Panel1.TabIndex = 100
        '
        'lblcrsum
        '
        Me.lblcrsum.AutoSize = True
        Me.lblcrsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrsum.Location = New System.Drawing.Point(645, 20)
        Me.lblcrsum.Name = "lblcrsum"
        Me.lblcrsum.Size = New System.Drawing.Size(16, 16)
        Me.lblcrsum.TabIndex = 52
        Me.lblcrsum.Text = "0"
        '
        'lbldrsum
        '
        Me.lbldrsum.AutoSize = True
        Me.lbldrsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrsum.Location = New System.Drawing.Point(645, 4)
        Me.lbldrsum.Name = "lbldrsum"
        Me.lbldrsum.Size = New System.Drawing.Size(16, 16)
        Me.lbldrsum.TabIndex = 51
        Me.lbldrsum.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(564, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Total Cr. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(564, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Total Dr. :"
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(226, 3)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(71, 29)
        Me.btnmodify.TabIndex = 6
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(379, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(59, 29)
        Me.btnclose.TabIndex = 9
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(157, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(63, 29)
        Me.btnsave.TabIndex = 5
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(303, 3)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(70, 29)
        Me.btnreset.TabIndex = 8
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(303, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(70, 29)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'panelachead
        '
        Me.panelachead.BackColor = System.Drawing.Color.NavajoWhite
        Me.panelachead.Controls.Add(Me.cmbacheadcodelist)
        Me.panelachead.Controls.Add(Me.Label5)
        Me.panelachead.Controls.Add(Me.cmbacheadlist)
        Me.panelachead.Location = New System.Drawing.Point(198, 149)
        Me.panelachead.Name = "panelachead"
        Me.panelachead.Size = New System.Drawing.Size(408, 280)
        Me.panelachead.TabIndex = 102
        '
        'cmbacheadcodelist
        '
        Me.cmbacheadcodelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacheadcodelist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcodelist.FormattingEnabled = True
        Me.cmbacheadcodelist.Location = New System.Drawing.Point(15, 34)
        Me.cmbacheadcodelist.Name = "cmbacheadcodelist"
        Me.cmbacheadcodelist.Size = New System.Drawing.Size(105, 262)
        Me.cmbacheadcodelist.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Account Head (Code/Name)  :"
        '
        'cmbacheadlist
        '
        Me.cmbacheadlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacheadlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadlist.FormattingEnabled = True
        Me.cmbacheadlist.Location = New System.Drawing.Point(120, 34)
        Me.cmbacheadlist.Name = "cmbacheadlist"
        Me.cmbacheadlist.Size = New System.Drawing.Size(280, 256)
        Me.cmbacheadlist.TabIndex = 0
        '
        'lblvouseq
        '
        Me.lblvouseq.AutoSize = True
        Me.lblvouseq.Location = New System.Drawing.Point(402, 37)
        Me.lblvouseq.Name = "lblvouseq"
        Me.lblvouseq.Size = New System.Drawing.Size(10, 13)
        Me.lblvouseq.TabIndex = 103
        Me.lblvouseq.Text = "-"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Magenta
        Me.CheckBox2.Location = New System.Drawing.Point(484, 65)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox2.TabIndex = 105
        Me.CheckBox2.Text = "Add New Party Head"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Magenta
        Me.CheckBox1.Location = New System.Drawing.Point(344, 65)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox1.TabIndex = 104
        Me.CheckBox1.Text = "Add New Gen Head"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtSearth
        '
        Me.txtSearth.Location = New System.Drawing.Point(630, 62)
        Me.txtSearth.Name = "txtSearth"
        Me.txtSearth.Size = New System.Drawing.Size(170, 20)
        Me.txtSearth.TabIndex = 106
        Me.txtSearth.Text = "Enter Text to Search"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(680, 36)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 107
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'frmSeqVentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(804, 578)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.txtSearth)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblvouseq)
        Me.Controls.Add(Me.dgSeqvoucher)
        Me.Controls.Add(Me.panelachead)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmSeqVentry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeqVentry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgSeqvoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelachead.ResumeLayout(False)
        Me.panelachead.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents lblvouno As System.Windows.Forms.TextBox
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents dgSeqvoucher As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblcrsum As System.Windows.Forms.Label
    Friend WithEvents lbldrsum As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents panelachead As System.Windows.Forms.Panel
    Friend WithEvents cmbacheadcodelist As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadlist As System.Windows.Forms.ComboBox
    Friend WithEvents lblvouseq As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtSearth As System.Windows.Forms.TextBox
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chequeno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents drcr As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
End Class
