<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankBook
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdPrint = New System.Windows.Forms.RadioButton
        Me.rdOnscreen = New System.Windows.Forms.RadioButton
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgGridLeger = New System.Windows.Forms.DataGridView
        Me.VouDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VoucherType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VoucherNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChequeNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DrAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgGridLeger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdPrint)
        Me.GroupBox2.Controls.Add(Me.rdOnscreen)
        Me.GroupBox2.Location = New System.Drawing.Point(440, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 30)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        '
        'rdPrint
        '
        Me.rdPrint.AutoSize = True
        Me.rdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPrint.Location = New System.Drawing.Point(86, 8)
        Me.rdPrint.Name = "rdPrint"
        Me.rdPrint.Size = New System.Drawing.Size(55, 19)
        Me.rdPrint.TabIndex = 1
        Me.rdPrint.Text = "Print"
        Me.rdPrint.UseVisualStyleBackColor = True
        '
        'rdOnscreen
        '
        Me.rdOnscreen.AutoSize = True
        Me.rdOnscreen.Checked = True
        Me.rdOnscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOnscreen.Location = New System.Drawing.Point(6, 8)
        Me.rdOnscreen.Name = "rdOnscreen"
        Me.rdOnscreen.Size = New System.Drawing.Size(70, 19)
        Me.rdOnscreen.TabIndex = 0
        Me.rdOnscreen.TabStop = True
        Me.rdOnscreen.Text = "Screen"
        Me.rdOnscreen.UseVisualStyleBackColor = True
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(330, 35)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(247, 21)
        Me.cmbacheadname.TabIndex = 102
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(579, 35)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(131, 21)
        Me.cmbacheadcode.TabIndex = 103
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(137, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(598, 64)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(55, 26)
        Me.btnshow.TabIndex = 105
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(195, 68)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 22)
        Me.dtfrom.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(137, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "From  :"
        '
        'dgGridLeger
        '
        Me.dgGridLeger.AllowUserToAddRows = False
        Me.dgGridLeger.AllowUserToDeleteRows = False
        Me.dgGridLeger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGridLeger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VouDate, Me.Narration, Me.VoucherType, Me.VoucherNo, Me.ChequeNo, Me.DrAmt, Me.CrAmt, Me.balance, Me.bdate})
        Me.dgGridLeger.Location = New System.Drawing.Point(0, 129)
        Me.dgGridLeger.Name = "dgGridLeger"
        Me.dgGridLeger.ReadOnly = True
        Me.dgGridLeger.Size = New System.Drawing.Size(803, 207)
        Me.dgGridLeger.TabIndex = 110
        '
        'VouDate
        '
        Me.VouDate.DataPropertyName = "Vou_date"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.VouDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.VouDate.HeaderText = "Vou Date"
        Me.VouDate.MaxInputLength = 10
        Me.VouDate.Name = "VouDate"
        Me.VouDate.ReadOnly = True
        Me.VouDate.Width = 50
        '
        'Narration
        '
        Me.Narration.DataPropertyName = "Narration"
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 250
        '
        'VoucherType
        '
        Me.VoucherType.DataPropertyName = "vou_type"
        Me.VoucherType.HeaderText = "VoucherType"
        Me.VoucherType.MaxInputLength = 30
        Me.VoucherType.Name = "VoucherType"
        Me.VoucherType.ReadOnly = True
        Me.VoucherType.Width = 75
        '
        'VoucherNo
        '
        Me.VoucherNo.DataPropertyName = "Vou_no"
        Me.VoucherNo.HeaderText = "VoucherNo."
        Me.VoucherNo.MaxInputLength = 40
        Me.VoucherNo.Name = "VoucherNo"
        Me.VoucherNo.ReadOnly = True
        Me.VoucherNo.Width = 60
        '
        'ChequeNo
        '
        Me.ChequeNo.DataPropertyName = "Cheque_no"
        Me.ChequeNo.HeaderText = "ChequeNo"
        Me.ChequeNo.Name = "ChequeNo"
        Me.ChequeNo.ReadOnly = True
        Me.ChequeNo.Width = 50
        '
        'DrAmt
        '
        Me.DrAmt.DataPropertyName = "dramt"
        Me.DrAmt.HeaderText = "Dr.Amt"
        Me.DrAmt.Name = "DrAmt"
        Me.DrAmt.ReadOnly = True
        Me.DrAmt.Width = 50
        '
        'CrAmt
        '
        Me.CrAmt.DataPropertyName = "cramt"
        Me.CrAmt.HeaderText = "Cr.Amt"
        Me.CrAmt.Name = "CrAmt"
        Me.CrAmt.ReadOnly = True
        Me.CrAmt.Width = 50
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        Me.balance.HeaderText = "Balance"
        Me.balance.MaxInputLength = 50
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 50
        '
        'bdate
        '
        Me.bdate.DataPropertyName = "Ch_date"
        Me.bdate.HeaderText = "Bank Date"
        Me.bdate.Name = "bdate"
        Me.bdate.ReadOnly = True
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 107)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(804, 253)
        Me.CrViewerGenralLedger.TabIndex = 109
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
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
        Me.Label1.Size = New System.Drawing.Size(804, 32)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Bank Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(659, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 26)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "To"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(330, 67)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(104, 22)
        Me.dtTo.TabIndex = 114
        '
        'frmBankBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(804, 360)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgGridLeger)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBankBook"
        Me.Text = "frmBankBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgGridLeger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnscreen As System.Windows.Forms.RadioButton
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgGridLeger As System.Windows.Forms.DataGridView
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents VouDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoucherType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VoucherNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
End Class
