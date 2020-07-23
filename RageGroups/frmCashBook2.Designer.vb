<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashBook2
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg = New System.Windows.Forms.DataGridView
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdchqno = New System.Windows.Forms.RadioButton
        Me.txtfind = New System.Windows.Forms.TextBox
        Me.rdamt = New System.Windows.Forms.RadioButton
        Me.btnsearch = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(286, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 25)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "Pg &Dn"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "to"
        Me.Label2.Visible = False
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(59, 60)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(128, 20)
        Me.dtto.TabIndex = 96
        Me.dtto.Visible = False
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(451, 60)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(87, 24)
        Me.btnclose.TabIndex = 95
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(451, 33)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(87, 25)
        Me.btnshow.TabIndex = 94
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(138, 35)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(128, 20)
        Me.dtfrom.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Book Date From :"
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
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Cash Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date1, Me.Narration, Me.Dramt, Me.cramt, Me.Balance})
        Me.dg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dg.Location = New System.Drawing.Point(0, 101)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(804, 337)
        Me.dg.TabIndex = 100
        '
        'date1
        '
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle21.NullValue = "-"
        Me.date1.DefaultCellStyle = DataGridViewCellStyle21
        Me.date1.HeaderText = "Date /Vou No."
        Me.date1.Name = "date1"
        Me.date1.ReadOnly = True
        Me.date1.Width = 120
        '
        'Narration
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Narration.DefaultCellStyle = DataGridViewCellStyle22
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 370
        '
        'Dramt
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.Format = "N2"
        Me.Dramt.DefaultCellStyle = DataGridViewCellStyle23
        Me.Dramt.HeaderText = "Receipt"
        Me.Dramt.Name = "Dramt"
        Me.Dramt.ReadOnly = True
        Me.Dramt.Width = 90
        '
        'cramt
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.Format = "N2"
        Me.cramt.DefaultCellStyle = DataGridViewCellStyle24
        Me.cramt.HeaderText = "Payment"
        Me.cramt.Name = "cramt"
        Me.cramt.ReadOnly = True
        Me.cramt.Width = 90
        '
        'Balance
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.Format = "N2"
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle25
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Width = 90
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(373, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 25)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "Pg &Up"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(287, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 25)
        Me.Button3.TabIndex = 103
        Me.Button3.Text = "Date Dn"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(373, 33)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 25)
        Me.Button4.TabIndex = 104
        Me.Button4.Text = "Date Up"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(559, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Find:"
        '
        'rdchqno
        '
        Me.rdchqno.AutoSize = True
        Me.rdchqno.Checked = True
        Me.rdchqno.ForeColor = System.Drawing.Color.Crimson
        Me.rdchqno.Location = New System.Drawing.Point(557, 35)
        Me.rdchqno.Name = "rdchqno"
        Me.rdchqno.Size = New System.Drawing.Size(82, 17)
        Me.rdchqno.TabIndex = 106
        Me.rdchqno.TabStop = True
        Me.rdchqno.Text = "Cheque No."
        Me.rdchqno.UseVisualStyleBackColor = True
        '
        'txtfind
        '
        Me.txtfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfind.Location = New System.Drawing.Point(602, 54)
        Me.txtfind.MaxLength = 15
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(117, 20)
        Me.txtfind.TabIndex = 107
        '
        'rdamt
        '
        Me.rdamt.AutoSize = True
        Me.rdamt.ForeColor = System.Drawing.Color.Crimson
        Me.rdamt.Location = New System.Drawing.Point(635, 35)
        Me.rdamt.Name = "rdamt"
        Me.rdamt.Size = New System.Drawing.Size(61, 17)
        Me.rdamt.TabIndex = 108
        Me.rdamt.Text = "Amount"
        Me.rdamt.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(634, 75)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(87, 25)
        Me.btnsearch.TabIndex = 109
        Me.btnsearch.Text = "Find"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 65)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox1.TabIndex = 110
        Me.CheckBox1.Text = "V"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(451, 90)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 24)
        Me.Button5.TabIndex = 111
        Me.Button5.Text = "&Print"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 120)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(804, 337)
        Me.CrystalReportViewer1.TabIndex = 112
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        Me.CrystalReportViewer1.Visible = False
        '
        'frmCashBook2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(804, 438)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.rdamt)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.rdchqno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmCashBook2"
        Me.Text = "Cash Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents date1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rdchqno As System.Windows.Forms.RadioButton
    Friend WithEvents txtfind As System.Windows.Forms.TextBox
    Friend WithEvents rdamt As System.Windows.Forms.RadioButton
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
