<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceSheet3
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdwodetail = New System.Windows.Forms.RadioButton
        Me.rdwdetail = New System.Windows.Forms.RadioButton
        Me.rdpl = New System.Windows.Forms.RadioButton
        Me.rdbal = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtfind = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdamt = New System.Windows.Forms.RadioButton
        Me.rdchqno = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgdetail = New System.Windows.Forms.DataGridView
        Me.groupname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.headname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgsummary = New System.Windows.Forms.DataGridView
        Me.libilaty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Shedule = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aamount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgsummary, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(777, 31)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Balance Sheet / Profit && Loss"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.rdpl)
        Me.Panel1.Controls.Add(Me.rdbal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.txtfind)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnprint)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dtto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 102)
        Me.Panel1.TabIndex = 230
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdwodetail)
        Me.GroupBox2.Controls.Add(Me.rdwdetail)
        Me.GroupBox2.Location = New System.Drawing.Point(511, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 40)
        Me.GroupBox2.TabIndex = 244
        Me.GroupBox2.TabStop = False
        '
        'rdwodetail
        '
        Me.rdwodetail.AutoSize = True
        Me.rdwodetail.Checked = True
        Me.rdwodetail.ForeColor = System.Drawing.Color.Crimson
        Me.rdwodetail.Location = New System.Drawing.Point(105, 12)
        Me.rdwodetail.Name = "rdwodetail"
        Me.rdwodetail.Size = New System.Drawing.Size(92, 17)
        Me.rdwodetail.TabIndex = 192
        Me.rdwodetail.TabStop = True
        Me.rdwodetail.Text = "Without Detail"
        Me.rdwodetail.UseVisualStyleBackColor = True
        '
        'rdwdetail
        '
        Me.rdwdetail.AutoSize = True
        Me.rdwdetail.ForeColor = System.Drawing.Color.Crimson
        Me.rdwdetail.Location = New System.Drawing.Point(15, 12)
        Me.rdwdetail.Name = "rdwdetail"
        Me.rdwdetail.Size = New System.Drawing.Size(77, 17)
        Me.rdwdetail.TabIndex = 191
        Me.rdwdetail.Text = "With Detail"
        Me.rdwdetail.UseVisualStyleBackColor = True
        '
        'rdpl
        '
        Me.rdpl.AutoSize = True
        Me.rdpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdpl.Location = New System.Drawing.Point(374, 15)
        Me.rdpl.Name = "rdpl"
        Me.rdpl.Size = New System.Drawing.Size(106, 19)
        Me.rdpl.TabIndex = 236
        Me.rdpl.Text = "Profit && Loss"
        Me.rdpl.UseVisualStyleBackColor = True
        '
        'rdbal
        '
        Me.rdbal.AutoSize = True
        Me.rdbal.Checked = True
        Me.rdbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbal.Location = New System.Drawing.Point(257, 15)
        Me.rdbal.Name = "rdbal"
        Me.rdbal.Size = New System.Drawing.Size(118, 19)
        Me.rdbal.TabIndex = 235
        Me.rdbal.TabStop = True
        Me.rdbal.Text = "Balance Sheet"
        Me.rdbal.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 233
        Me.Label8.Text = "Date:"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(727, 49)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(42, 25)
        Me.Button6.TabIndex = 243
        Me.Button6.Text = "C&alc"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(75, 72)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(87, 25)
        Me.btnsearch.TabIndex = 241
        Me.btnsearch.Text = "Find"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfind.Location = New System.Drawing.Point(57, 49)
        Me.txtfind.MaxLength = 15
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(117, 20)
        Me.txtfind.TabIndex = 240
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 239
        Me.Label6.Text = "Find:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(506, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 28)
        Me.Button2.TabIndex = 238
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(580, 47)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(68, 28)
        Me.btnprint.TabIndex = 237
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdamt)
        Me.GroupBox1.Controls.Add(Me.rdchqno)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 40)
        Me.GroupBox1.TabIndex = 242
        Me.GroupBox1.TabStop = False
        '
        'rdamt
        '
        Me.rdamt.AutoSize = True
        Me.rdamt.ForeColor = System.Drawing.Color.Crimson
        Me.rdamt.Location = New System.Drawing.Point(120, 12)
        Me.rdamt.Name = "rdamt"
        Me.rdamt.Size = New System.Drawing.Size(61, 17)
        Me.rdamt.TabIndex = 192
        Me.rdamt.Text = "Amount"
        Me.rdamt.UseVisualStyleBackColor = True
        '
        'rdchqno
        '
        Me.rdchqno.AutoSize = True
        Me.rdchqno.Checked = True
        Me.rdchqno.ForeColor = System.Drawing.Color.Crimson
        Me.rdchqno.Location = New System.Drawing.Point(29, 12)
        Me.rdchqno.Name = "rdchqno"
        Me.rdchqno.Size = New System.Drawing.Size(76, 17)
        Me.rdchqno.TabIndex = 191
        Me.rdchqno.TabStop = True
        Me.rdchqno.Text = "Grp. Name"
        Me.rdchqno.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(653, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 28)
        Me.Button1.TabIndex = 232
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(257, 53)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(104, 20)
        Me.dtto.TabIndex = 231
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Controls.Add(Me.dgdetail)
        Me.Panel2.Controls.Add(Me.dgsummary)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 420)
        Me.Panel2.TabIndex = 231
        '
        'dgdetail
        '
        Me.dgdetail.AllowUserToAddRows = False
        Me.dgdetail.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgdetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.groupname, Me.headname, Me.dramt, Me.Cramt})
        Me.dgdetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdetail.Location = New System.Drawing.Point(0, 0)
        Me.dgdetail.Name = "dgdetail"
        Me.dgdetail.ReadOnly = True
        Me.dgdetail.Size = New System.Drawing.Size(777, 420)
        Me.dgdetail.TabIndex = 224
        Me.dgdetail.Visible = False
        '
        'groupname
        '
        Me.groupname.HeaderText = "Group Name"
        Me.groupname.Name = "groupname"
        Me.groupname.ReadOnly = True
        Me.groupname.Width = 200
        '
        'headname
        '
        Me.headname.HeaderText = "Head Name"
        Me.headname.Name = "headname"
        Me.headname.ReadOnly = True
        Me.headname.Width = 300
        '
        'dramt
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = ".00"
        Me.dramt.DefaultCellStyle = DataGridViewCellStyle9
        Me.dramt.HeaderText = "Dr. Amt"
        Me.dramt.Name = "dramt"
        Me.dramt.ReadOnly = True
        '
        'Cramt
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = ".00"
        Me.Cramt.DefaultCellStyle = DataGridViewCellStyle10
        Me.Cramt.HeaderText = "Cr. Amt"
        Me.Cramt.Name = "Cramt"
        Me.Cramt.ReadOnly = True
        '
        'dgsummary
        '
        Me.dgsummary.AllowUserToAddRows = False
        Me.dgsummary.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dgsummary.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgsummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.libilaty, Me.Shedule, Me.lAmount, Me.aamount})
        Me.dgsummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgsummary.Location = New System.Drawing.Point(0, 0)
        Me.dgsummary.Name = "dgsummary"
        Me.dgsummary.ReadOnly = True
        Me.dgsummary.Size = New System.Drawing.Size(777, 420)
        Me.dgsummary.TabIndex = 223
        '
        'libilaty
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libilaty.DefaultCellStyle = DataGridViewCellStyle12
        Me.libilaty.HeaderText = "Group Name"
        Me.libilaty.Name = "libilaty"
        Me.libilaty.ReadOnly = True
        Me.libilaty.Width = 200
        '
        'Shedule
        '
        Me.Shedule.HeaderText = "Shedule"
        Me.Shedule.Name = "Shedule"
        Me.Shedule.ReadOnly = True
        '
        'lAmount
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.Format = "0.00"
        Me.lAmount.DefaultCellStyle = DataGridViewCellStyle13
        Me.lAmount.HeaderText = "Dr. Amt"
        Me.lAmount.Name = "lAmount"
        Me.lAmount.ReadOnly = True
        Me.lAmount.Width = 150
        '
        'aamount
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.Format = "0.00"
        Me.aamount.DefaultCellStyle = DataGridViewCellStyle14
        Me.aamount.HeaderText = "Cr. Amt"
        Me.aamount.Name = "aamount"
        Me.aamount.ReadOnly = True
        Me.aamount.Width = 150
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(777, 420)
        Me.CrystalReportViewer1.TabIndex = 225
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frmBalanceSheet3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmBalanceSheet3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBalanceSheet3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgsummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdpl As System.Windows.Forms.RadioButton
    Friend WithEvents rdbal As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtfind As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdamt As System.Windows.Forms.RadioButton
    Friend WithEvents rdchqno As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgsummary As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdwodetail As System.Windows.Forms.RadioButton
    Friend WithEvents rdwdetail As System.Windows.Forms.RadioButton
    Friend WithEvents libilaty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shedule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgdetail As System.Windows.Forms.DataGridView
    Friend WithEvents groupname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
