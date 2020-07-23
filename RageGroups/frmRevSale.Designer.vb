<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevSale
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtnrevrse = New System.Windows.Forms.Button
        Me.cmbacheadnamedr = New System.Windows.Forms.ComboBox
        Me.cmbacheadcodedr = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbacsubgroupdr = New System.Windows.Forms.ComboBox
        Me.cmbacgroupdr = New System.Windows.Forms.ComboBox
        Me.cmbvtype = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtvdate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgCRDebit = New System.Windows.Forms.DataGridView
        Me.vno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acc_code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acc_head = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.narratio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DrAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtCrNoTo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbheadcr = New System.Windows.Forms.ComboBox
        Me.cmbcodecr = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.sgrpcr = New System.Windows.Forms.ComboBox
        Me.grpcr = New System.Windows.Forms.ComboBox
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.btnshow = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(631, 535)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 28)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(536, 535)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Delet&e "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtnrevrse
        '
        Me.dtnrevrse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtnrevrse.Location = New System.Drawing.Point(235, 535)
        Me.dtnrevrse.Name = "dtnrevrse"
        Me.dtnrevrse.Size = New System.Drawing.Size(295, 28)
        Me.dtnrevrse.TabIndex = 8
        Me.dtnrevrse.Text = "&Save "
        Me.dtnrevrse.UseVisualStyleBackColor = True
        '
        'cmbacheadnamedr
        '
        Me.cmbacheadnamedr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadnamedr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadnamedr.BackColor = System.Drawing.Color.White
        Me.cmbacheadnamedr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadnamedr.FormattingEnabled = True
        Me.cmbacheadnamedr.Location = New System.Drawing.Point(234, 427)
        Me.cmbacheadnamedr.Name = "cmbacheadnamedr"
        Me.cmbacheadnamedr.Size = New System.Drawing.Size(296, 21)
        Me.cmbacheadnamedr.TabIndex = 4
        '
        'cmbacheadcodedr
        '
        Me.cmbacheadcodedr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcodedr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcodedr.BackColor = System.Drawing.Color.White
        Me.cmbacheadcodedr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcodedr.FormattingEnabled = True
        Me.cmbacheadcodedr.Location = New System.Drawing.Point(536, 428)
        Me.cmbacheadcodedr.Name = "cmbacheadcodedr"
        Me.cmbacheadcodedr.Size = New System.Drawing.Size(168, 21)
        Me.cmbacheadcodedr.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 429)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 15)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = "Account Head (Code/Name) Dr  :"
        '
        'cmbacsubgroupdr
        '
        Me.cmbacsubgroupdr.BackColor = System.Drawing.Color.White
        Me.cmbacsubgroupdr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacsubgroupdr.Enabled = False
        Me.cmbacsubgroupdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacsubgroupdr.FormattingEnabled = True
        Me.cmbacsubgroupdr.Location = New System.Drawing.Point(536, 452)
        Me.cmbacsubgroupdr.Name = "cmbacsubgroupdr"
        Me.cmbacsubgroupdr.Size = New System.Drawing.Size(168, 24)
        Me.cmbacsubgroupdr.TabIndex = 139
        '
        'cmbacgroupdr
        '
        Me.cmbacgroupdr.BackColor = System.Drawing.Color.White
        Me.cmbacgroupdr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacgroupdr.Enabled = False
        Me.cmbacgroupdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacgroupdr.FormattingEnabled = True
        Me.cmbacgroupdr.Location = New System.Drawing.Point(234, 451)
        Me.cmbacgroupdr.Name = "cmbacgroupdr"
        Me.cmbacgroupdr.Size = New System.Drawing.Size(296, 24)
        Me.cmbacgroupdr.TabIndex = 138
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(320, 38)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(124, 21)
        Me.cmbvtype.TabIndex = 0
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(356, 201)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(124, 21)
        Me.cmbAreaCode.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Voucher Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Area :"
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(113, 217)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(89, 20)
        Me.dtvdate.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Voucher  Date :"
        '
        'dgCRDebit
        '
        Me.dgCRDebit.AllowUserToAddRows = False
        Me.dgCRDebit.AllowUserToDeleteRows = False
        Me.dgCRDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vno, Me.vdate, Me.acc_code, Me.acc_head, Me.narratio, Me.DrAmount, Me.cramt})
        Me.dgCRDebit.Location = New System.Drawing.Point(5, 103)
        Me.dgCRDebit.Name = "dgCRDebit"
        Me.dgCRDebit.ReadOnly = True
        Me.dgCRDebit.Size = New System.Drawing.Size(785, 318)
        Me.dgCRDebit.TabIndex = 132
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
        DataGridViewCellStyle7.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.vdate.DefaultCellStyle = DataGridViewCellStyle7
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
        'DrAmount
        '
        Me.DrAmount.HeaderText = "Dr Amount"
        Me.DrAmount.Name = "DrAmount"
        Me.DrAmount.ReadOnly = True
        '
        'cramt
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.cramt.DefaultCellStyle = DataGridViewCellStyle8
        Me.cramt.HeaderText = "Cr Amount"
        Me.cramt.Name = "cramt"
        Me.cramt.ReadOnly = True
        Me.cramt.Width = 75
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(482, 65)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(80, 20)
        Me.txtCrNoTo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(453, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "To"
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(322, 65)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(122, 20)
        Me.txtCrNoFrom.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(130, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 15)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Sale Voucher Number From :"
        '
        'cmbheadcr
        '
        Me.cmbheadcr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbheadcr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbheadcr.BackColor = System.Drawing.Color.White
        Me.cmbheadcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbheadcr.FormattingEnabled = True
        Me.cmbheadcr.Location = New System.Drawing.Point(234, 482)
        Me.cmbheadcr.Name = "cmbheadcr"
        Me.cmbheadcr.Size = New System.Drawing.Size(296, 21)
        Me.cmbheadcr.TabIndex = 6
        '
        'cmbcodecr
        '
        Me.cmbcodecr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbcodecr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcodecr.BackColor = System.Drawing.Color.White
        Me.cmbcodecr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcodecr.FormattingEnabled = True
        Me.cmbcodecr.Location = New System.Drawing.Point(536, 483)
        Me.cmbcodecr.Name = "cmbcodecr"
        Me.cmbcodecr.Size = New System.Drawing.Size(168, 21)
        Me.cmbcodecr.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 15)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Account Head (Code/Name) Cr  :"
        '
        'sgrpcr
        '
        Me.sgrpcr.BackColor = System.Drawing.Color.White
        Me.sgrpcr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.sgrpcr.Enabled = False
        Me.sgrpcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sgrpcr.FormattingEnabled = True
        Me.sgrpcr.Location = New System.Drawing.Point(536, 507)
        Me.sgrpcr.Name = "sgrpcr"
        Me.sgrpcr.Size = New System.Drawing.Size(168, 24)
        Me.sgrpcr.TabIndex = 146
        Me.sgrpcr.TabStop = False
        '
        'grpcr
        '
        Me.grpcr.BackColor = System.Drawing.Color.White
        Me.grpcr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.grpcr.Enabled = False
        Me.grpcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpcr.FormattingEnabled = True
        Me.grpcr.Location = New System.Drawing.Point(234, 506)
        Me.grpcr.Name = "grpcr"
        Me.grpcr.Size = New System.Drawing.Size(296, 24)
        Me.grpcr.TabIndex = 145
        Me.grpcr.TabStop = False
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(368, 201)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(112, 21)
        Me.cmbAreaName.TabIndex = 148
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(568, 65)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 3
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(802, 31)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "R SALE ENTRY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmRevSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(802, 576)
        Me.Controls.Add(Me.dgCRDebit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.cmbheadcr)
        Me.Controls.Add(Me.cmbcodecr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sgrpcr)
        Me.Controls.Add(Me.grpcr)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtnrevrse)
        Me.Controls.Add(Me.cmbacheadnamedr)
        Me.Controls.Add(Me.cmbacheadcodedr)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbacsubgroupdr)
        Me.Controls.Add(Me.cmbacgroupdr)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbAreaName)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRevSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRevSale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtnrevrse As System.Windows.Forms.Button
    Friend WithEvents cmbacheadnamedr As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcodedr As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbacsubgroupdr As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacgroupdr As System.Windows.Forms.ComboBox
    Public WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgCRDebit As System.Windows.Forms.DataGridView
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbheadcr As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcodecr As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sgrpcr As System.Windows.Forms.ComboBox
    Friend WithEvents grpcr As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents vno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narratio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
