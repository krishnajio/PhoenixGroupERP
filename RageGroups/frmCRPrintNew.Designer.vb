<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRPrintNew
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtfrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.dgCRDebit = New System.Windows.Forms.DataGridView()
        Me.vno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acc_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acc_head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.narratio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cramt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtPrint = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAreaCode = New System.Windows.Forms.TextBox()
        Me.cmbVoutype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtfrom
        '
        Me.txtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfrom.Location = New System.Drawing.Point(267, 44)
        Me.txtfrom.MaxLength = 60
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.Size = New System.Drawing.Size(49, 22)
        Me.txtfrom.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Cr. No. From :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1130, 35)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = " Print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtto
        '
        Me.txtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtto.Location = New System.Drawing.Point(349, 44)
        Me.txtto.MaxLength = 60
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(53, 22)
        Me.txtto.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "to"
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(63, 323)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(56, 31)
        Me.btnclose.TabIndex = 45
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(0, 323)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(57, 31)
        Me.btnprint.TabIndex = 44
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(945, 44)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(56, 26)
        Me.btnshow.TabIndex = 43
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        Me.btnshow.Visible = False
        '
        'dgCRDebit
        '
        Me.dgCRDebit.AllowUserToAddRows = False
        Me.dgCRDebit.AllowUserToDeleteRows = False
        Me.dgCRDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vno, Me.vdate, Me.acc_code, Me.acc_head, Me.narratio, Me.cramt})
        Me.dgCRDebit.Location = New System.Drawing.Point(-3, 74)
        Me.dgCRDebit.Name = "dgCRDebit"
        Me.dgCRDebit.ReadOnly = True
        Me.dgCRDebit.Size = New System.Drawing.Size(181, 234)
        Me.dgCRDebit.TabIndex = 98
        Me.dgCRDebit.TabStop = False
        '
        'vno
        '
        Me.vno.HeaderText = "Vou No."
        Me.vno.Name = "vno"
        Me.vno.ReadOnly = True
        Me.vno.Width = 60
        '
        'vdate
        '
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.vdate.DefaultCellStyle = DataGridViewCellStyle1
        Me.vdate.HeaderText = "Vou Date"
        Me.vdate.Name = "vdate"
        Me.vdate.ReadOnly = True
        Me.vdate.Width = 75
        '
        'acc_code
        '
        Me.acc_code.HeaderText = "A/c Code"
        Me.acc_code.Name = "acc_code"
        Me.acc_code.ReadOnly = True
        Me.acc_code.Width = 60
        '
        'acc_head
        '
        Me.acc_head.HeaderText = "A/c Head"
        Me.acc_head.Name = "acc_head"
        Me.acc_head.ReadOnly = True
        Me.acc_head.Width = 150
        '
        'narratio
        '
        Me.narratio.HeaderText = "Narration"
        Me.narratio.Name = "narratio"
        Me.narratio.ReadOnly = True
        Me.narratio.Width = 200
        '
        'cramt
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.cramt.DefaultCellStyle = DataGridViewCellStyle2
        Me.cramt.HeaderText = "Cr Amount"
        Me.cramt.Name = "cramt"
        Me.cramt.ReadOnly = True
        Me.cramt.Width = 75
        '
        'dtPrint
        '
        Me.dtPrint.CustomFormat = "dd/MMM/yy"
        Me.dtPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPrint.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPrint.Location = New System.Drawing.Point(1007, 48)
        Me.dtPrint.Name = "dtPrint"
        Me.dtPrint.Size = New System.Drawing.Size(52, 20)
        Me.dtPrint.TabIndex = 99
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(408, 46)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton1.TabIndex = 100
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CashCounter"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 74)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(934, 535)
        Me.CrystalReportViewer1.TabIndex = 101
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(840, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 26)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "AreaCode :"
        '
        'txtAreaCode
        '
        Me.txtAreaCode.Location = New System.Drawing.Point(100, 44)
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(55, 20)
        Me.txtAreaCode.TabIndex = 104
        '
        'cmbVoutype
        '
        Me.cmbVoutype.FormattingEnabled = True
        Me.cmbVoutype.Items.AddRange(New Object() {"CR Voucher", "Bank Trans"})
        Me.cmbVoutype.Location = New System.Drawing.Point(501, 45)
        Me.cmbVoutype.Name = "cmbVoutype"
        Me.cmbVoutype.Size = New System.Drawing.Size(121, 21)
        Me.cmbVoutype.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(628, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Cust Code :"
        '
        'txtCustCode
        '
        Me.txtCustCode.Location = New System.Drawing.Point(711, 44)
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(55, 20)
        Me.txtCustCode.TabIndex = 107
        '
        'frmCRPrintNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1130, 621)
        Me.Controls.Add(Me.txtCustCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbVoutype)
        Me.Controls.Add(Me.txtAreaCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.dtPrint)
        Me.Controls.Add(Me.dgCRDebit)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCRPrintNew"
        Me.Text = "frmCRPrint"
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents dgCRDebit As System.Windows.Forms.DataGridView
    Friend WithEvents vno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narratio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtPrint As System.Windows.Forms.DateTimePicker
    Public WithEvents txtfrom As System.Windows.Forms.TextBox
    Public WithEvents txtto As System.Windows.Forms.TextBox
    Public WithEvents btnshow As System.Windows.Forms.Button
    Public WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbVoutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCustCode As System.Windows.Forms.TextBox
End Class
