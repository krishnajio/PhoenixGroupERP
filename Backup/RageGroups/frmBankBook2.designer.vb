<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankBook2
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dg = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.rdamt = New System.Windows.Forms.RadioButton
        Me.txtfind = New System.Windows.Forms.TextBox
        Me.rdchqno = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(738, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 26)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Label1.Size = New System.Drawing.Size(941, 32)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Bank Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(191, 35)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(247, 21)
        Me.cmbacheadname.TabIndex = 115
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(440, 35)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(131, 21)
        Me.cmbacheadcode.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(738, 36)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(69, 26)
        Me.btnshow.TabIndex = 118
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(187, 68)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 22)
        Me.dtfrom.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(129, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "From  :"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date1, Me.Narration, Me.Dramt, Me.cramt, Me.Balance})
        Me.dg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg.Location = New System.Drawing.Point(0, 86)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(941, 492)
        Me.dg.TabIndex = 126
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(659, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 25)
        Me.Button2.TabIndex = 128
        Me.Button2.Text = "Pg &Up"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(573, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 25)
        Me.Button3.TabIndex = 127
        Me.Button3.Text = "Pg &Dn"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(893, 79)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(87, 25)
        Me.btnsearch.TabIndex = 135
        Me.btnsearch.Text = "Find"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'rdamt
        '
        Me.rdamt.AutoSize = True
        Me.rdamt.ForeColor = System.Drawing.Color.Crimson
        Me.rdamt.Location = New System.Drawing.Point(894, 39)
        Me.rdamt.Name = "rdamt"
        Me.rdamt.Size = New System.Drawing.Size(61, 17)
        Me.rdamt.TabIndex = 134
        Me.rdamt.Text = "Amount"
        Me.rdamt.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfind.Location = New System.Drawing.Point(861, 58)
        Me.txtfind.MaxLength = 15
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(117, 20)
        Me.txtfind.TabIndex = 133
        '
        'rdchqno
        '
        Me.rdchqno.AutoSize = True
        Me.rdchqno.Checked = True
        Me.rdchqno.ForeColor = System.Drawing.Color.Crimson
        Me.rdchqno.Location = New System.Drawing.Point(816, 39)
        Me.rdchqno.Name = "rdchqno"
        Me.rdchqno.Size = New System.Drawing.Size(82, 17)
        Me.rdchqno.TabIndex = 132
        Me.rdchqno.TabStop = True
        Me.rdchqno.Text = "Cheque No."
        Me.rdchqno.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(818, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Find:"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(659, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 25)
        Me.Button4.TabIndex = 130
        Me.Button4.Text = "Date Up"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(573, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 25)
        Me.Button5.TabIndex = 129
        Me.Button5.Text = "Date Dn"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 61)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox1.TabIndex = 136
        Me.CheckBox1.Text = "V"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'date1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = "-"
        Me.date1.DefaultCellStyle = DataGridViewCellStyle1
        Me.date1.HeaderText = "Date /Vou No."
        Me.date1.Name = "date1"
        Me.date1.ReadOnly = True
        Me.date1.Width = 120
        '
        'Narration
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Narration.DefaultCellStyle = DataGridViewCellStyle2
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Narration.Width = 370
        '
        'Dramt
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "n2"
        Me.Dramt.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dramt.HeaderText = "Debit"
        Me.Dramt.Name = "Dramt"
        Me.Dramt.ReadOnly = True
        '
        'cramt
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "n2"
        Me.cramt.DefaultCellStyle = DataGridViewCellStyle4
        Me.cramt.HeaderText = "Credit"
        Me.cramt.Name = "cramt"
        Me.cramt.ReadOnly = True
        '
        'Balance
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "n2"
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle5
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Visible = False
        '
        'frmBankBook2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(941, 578)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.rdamt)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.rdchqno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmBankBook2"
        Me.Text = "Bank Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents rdamt As System.Windows.Forms.RadioButton
    Friend WithEvents txtfind As System.Windows.Forms.TextBox
    Friend WithEvents rdchqno As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents date1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
