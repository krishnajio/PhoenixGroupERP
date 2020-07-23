<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvInfo
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
        Me.cmbinttype = New System.Windows.Forms.ComboBox
        Me.lbl = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtdate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnok = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.txtinvoiceno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtHeadName = New System.Windows.Forms.TextBox
        Me.txtHeadCode = New System.Windows.Forms.TextBox
        Me.dgInvInfo = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbItemName = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.freeqty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtVouno = New System.Windows.Forms.TextBox
        Me.txtVtype = New System.Windows.Forms.TextBox
        Me.dtVoudate = New System.Windows.Forms.DateTimePicker
        Me.txtNarration = New System.Windows.Forms.TextBox
        Me.dtHatchDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.dgInvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbinttype
        '
        Me.cmbinttype.BackColor = System.Drawing.Color.White
        Me.cmbinttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbinttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cmbinttype.FormattingEnabled = True
        Me.cmbinttype.Items.AddRange(New Object() {"SALE", "PURCHASE", "TRANSFER", "REVERSE"})
        Me.cmbinttype.Location = New System.Drawing.Point(133, 77)
        Me.cmbinttype.Name = "cmbinttype"
        Me.cmbinttype.Size = New System.Drawing.Size(140, 21)
        Me.cmbinttype.TabIndex = 2
        Me.cmbinttype.TabStop = False
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.Color.Teal
        Me.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.SandyBrown
        Me.lbl.Location = New System.Drawing.Point(0, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(630, 26)
        Me.lbl.TabIndex = 46
        Me.lbl.Text = "Inventory"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Invoice No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Invoice Type :"
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(331, 55)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(87, 21)
        Me.dtdate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(282, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Date :"
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnok.Location = New System.Drawing.Point(450, 281)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(40, 27)
        Me.btnok.TabIndex = 6
        Me.btnok.Text = "&OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnclose.Location = New System.Drawing.Point(496, 280)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(134, 28)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Cancel Inventory"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'txtinvoiceno
        '
        Me.txtinvoiceno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtinvoiceno.Location = New System.Drawing.Point(133, 55)
        Me.txtinvoiceno.MaxLength = 18
        Me.txtinvoiceno.Name = "txtinvoiceno"
        Me.txtinvoiceno.Size = New System.Drawing.Size(143, 20)
        Me.txtinvoiceno.TabIndex = 0
        Me.txtinvoiceno.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 15)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Head Name/Code :"
        '
        'txtHeadName
        '
        Me.txtHeadName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtHeadName.Location = New System.Drawing.Point(133, 31)
        Me.txtHeadName.MaxLength = 18
        Me.txtHeadName.Name = "txtHeadName"
        Me.txtHeadName.ReadOnly = True
        Me.txtHeadName.Size = New System.Drawing.Size(240, 20)
        Me.txtHeadName.TabIndex = 0
        Me.txtHeadName.TabStop = False
        '
        'txtHeadCode
        '
        Me.txtHeadCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtHeadCode.Location = New System.Drawing.Point(376, 31)
        Me.txtHeadCode.MaxLength = 18
        Me.txtHeadCode.Name = "txtHeadCode"
        Me.txtHeadCode.ReadOnly = True
        Me.txtHeadCode.Size = New System.Drawing.Size(125, 20)
        Me.txtHeadCode.TabIndex = 1
        Me.txtHeadCode.TabStop = False
        '
        'dgInvInfo
        '
        Me.dgInvInfo.AllowUserToAddRows = False
        Me.dgInvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInvInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.cmbItemName, Me.qty, Me.Nos, Me.rate, Me.Unit, Me.freeqty, Me.amount})
        Me.dgInvInfo.Location = New System.Drawing.Point(3, 102)
        Me.dgInvInfo.Name = "dgInvInfo"
        Me.dgInvInfo.Size = New System.Drawing.Size(627, 150)
        Me.dgInvInfo.TabIndex = 4
        '
        'srno
        '
        Me.srno.HeaderText = "Sr No"
        Me.srno.Name = "srno"
        Me.srno.Width = 50
        '
        'cmbItemName
        '
        Me.cmbItemName.HeaderText = "ItemName"
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmbItemName.Width = 140
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.Width = 75
        '
        'Nos
        '
        Me.Nos.HeaderText = "No"
        Me.Nos.Name = "Nos"
        Me.Nos.Width = 60
        '
        'rate
        '
        Me.rate.HeaderText = "Rate"
        Me.rate.Name = "rate"
        Me.rate.ReadOnly = True
        Me.rate.Width = 75
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Unit.Width = 50
        '
        'freeqty
        '
        Me.freeqty.HeaderText = "Free Qty"
        Me.freeqty.Name = "freeqty"
        Me.freeqty.Width = 50
        '
        'amount
        '
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.Width = 80
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(481, 255)
        Me.txtTotal.MaxLength = 18
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(149, 20)
        Me.txtTotal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(422, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "TOTAL:"
        '
        'txtVouno
        '
        Me.txtVouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtVouno.Location = New System.Drawing.Point(223, 31)
        Me.txtVouno.MaxLength = 18
        Me.txtVouno.Name = "txtVouno"
        Me.txtVouno.ReadOnly = True
        Me.txtVouno.Size = New System.Drawing.Size(147, 20)
        Me.txtVouno.TabIndex = 92
        '
        'txtVtype
        '
        Me.txtVtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtVtype.Location = New System.Drawing.Point(378, 31)
        Me.txtVtype.MaxLength = 18
        Me.txtVtype.Name = "txtVtype"
        Me.txtVtype.ReadOnly = True
        Me.txtVtype.Size = New System.Drawing.Size(75, 20)
        Me.txtVtype.TabIndex = 93
        '
        'dtVoudate
        '
        Me.dtVoudate.CustomFormat = "dd/MMM/yy"
        Me.dtVoudate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtVoudate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtVoudate.Location = New System.Drawing.Point(331, 55)
        Me.dtVoudate.Name = "dtVoudate"
        Me.dtVoudate.Size = New System.Drawing.Size(87, 21)
        Me.dtVoudate.TabIndex = 94
        '
        'txtNarration
        '
        Me.txtNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtNarration.Location = New System.Drawing.Point(409, 257)
        Me.txtNarration.MaxLength = 18
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ReadOnly = True
        Me.txtNarration.Size = New System.Drawing.Size(10, 20)
        Me.txtNarration.TabIndex = 95
        '
        'dtHatchDate
        '
        Me.dtHatchDate.CustomFormat = "dd/MMM/yy"
        Me.dtHatchDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtHatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHatchDate.Location = New System.Drawing.Point(376, 79)
        Me.dtHatchDate.Name = "dtHatchDate"
        Me.dtHatchDate.Size = New System.Drawing.Size(87, 21)
        Me.dtHatchDate.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Hatch  Date :"
        '
        'frmInvInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(630, 311)
        Me.Controls.Add(Me.dtHatchDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.dgInvInfo)
        Me.Controls.Add(Me.txtHeadCode)
        Me.Controls.Add(Me.txtHeadName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtinvoiceno)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.cmbinttype)
        Me.Controls.Add(Me.txtVouno)
        Me.Controls.Add(Me.txtVtype)
        Me.Controls.Add(Me.dtVoudate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInvInfo"
        CType(Me.dgInvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbinttype As System.Windows.Forms.ComboBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txtinvoiceno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtHeadName As System.Windows.Forms.TextBox
    Public WithEvents txtHeadCode As System.Windows.Forms.TextBox
    Friend WithEvents dgInvInfo As System.Windows.Forms.DataGridView
    Public WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtVouno As System.Windows.Forms.TextBox
    Public WithEvents txtVtype As System.Windows.Forms.TextBox
    Public WithEvents dtVoudate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents dtHatchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbItemName As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents freeqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
