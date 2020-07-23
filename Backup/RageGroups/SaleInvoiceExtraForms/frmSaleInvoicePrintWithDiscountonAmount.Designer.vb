<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleInvoicePrintWithDiscountonAmount
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
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.txtCrNoTo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgCRDebit = New System.Windows.Forms.DataGridView
        Me.INVNO_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acc_head = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOOFCHICKS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FREE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INVAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NECCAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LAYERAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BROILERAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COCKRELEAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AREA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.freeper = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.neccrate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISCOUNTAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISRATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BRhatchEGGS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Ivory
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1028, 31)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "SALE INV. PRINT WITH DISCOUNT ON AMOUNT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(388, 33)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 160
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(301, 36)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(80, 20)
        Me.txtCrNoTo.TabIndex = 159
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 15)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Sale Voucher Number From :"
        '
        'dgCRDebit
        '
        Me.dgCRDebit.AllowUserToAddRows = False
        Me.dgCRDebit.AllowUserToDeleteRows = False
        Me.dgCRDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INVNO_DATE, Me.Hdate, Me.acc_head, Me.NOOFCHICKS, Me.FREE, Me.INVAMOUNT, Me.NECCAMOUNT, Me.LAYERAMOUNT, Me.BROILERAMOUNT, Me.COCKRELEAMOUNT, Me.AREA, Me.PNAME, Me.unitprice, Me.freeper, Me.neccrate, Me.TotalAmount, Me.DISCOUNTAMOUNT, Me.DISRATE, Me.BRhatchEGGS})
        Me.dgCRDebit.Location = New System.Drawing.Point(-41, 65)
        Me.dgCRDebit.Name = "dgCRDebit"
        Me.dgCRDebit.ReadOnly = True
        Me.dgCRDebit.Size = New System.Drawing.Size(1057, 669)
        Me.dgCRDebit.TabIndex = 163
        '
        'INVNO_DATE
        '
        Me.INVNO_DATE.HeaderText = "INV NO & DATE"
        Me.INVNO_DATE.Name = "INVNO_DATE"
        Me.INVNO_DATE.ReadOnly = True
        Me.INVNO_DATE.Width = 60
        '
        'Hdate
        '
        DataGridViewCellStyle55.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle55.NullValue = Nothing
        Me.Hdate.DefaultCellStyle = DataGridViewCellStyle55
        Me.Hdate.HeaderText = "HATCH DATE"
        Me.Hdate.Name = "Hdate"
        Me.Hdate.ReadOnly = True
        Me.Hdate.Width = 75
        '
        'acc_head
        '
        Me.acc_head.HeaderText = "CUST NAME & ADDRESS "
        Me.acc_head.Name = "acc_head"
        Me.acc_head.ReadOnly = True
        Me.acc_head.Width = 150
        '
        'NOOFCHICKS
        '
        DataGridViewCellStyle56.NullValue = Nothing
        Me.NOOFCHICKS.DefaultCellStyle = DataGridViewCellStyle56
        Me.NOOFCHICKS.HeaderText = "NO. OF CHICKS"
        Me.NOOFCHICKS.MaxInputLength = 20
        Me.NOOFCHICKS.Name = "NOOFCHICKS"
        Me.NOOFCHICKS.ReadOnly = True
        Me.NOOFCHICKS.Width = 60
        '
        'FREE
        '
        Me.FREE.HeaderText = "FREE"
        Me.FREE.Name = "FREE"
        Me.FREE.ReadOnly = True
        Me.FREE.Width = 50
        '
        'INVAMOUNT
        '
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle57.Format = "N2"
        DataGridViewCellStyle57.NullValue = "0.00"
        Me.INVAMOUNT.DefaultCellStyle = DataGridViewCellStyle57
        Me.INVAMOUNT.HeaderText = "INV AMOUNT"
        Me.INVAMOUNT.Name = "INVAMOUNT"
        Me.INVAMOUNT.ReadOnly = True
        Me.INVAMOUNT.Width = 75
        '
        'NECCAMOUNT
        '
        DataGridViewCellStyle58.Format = "0.00"
        Me.NECCAMOUNT.DefaultCellStyle = DataGridViewCellStyle58
        Me.NECCAMOUNT.HeaderText = "NECC AMOUNT"
        Me.NECCAMOUNT.Name = "NECCAMOUNT"
        Me.NECCAMOUNT.ReadOnly = True
        '
        'LAYERAMOUNT
        '
        DataGridViewCellStyle59.Format = "0.00"
        Me.LAYERAMOUNT.DefaultCellStyle = DataGridViewCellStyle59
        Me.LAYERAMOUNT.HeaderText = "LAYER AMOUNT"
        Me.LAYERAMOUNT.Name = "LAYERAMOUNT"
        Me.LAYERAMOUNT.ReadOnly = True
        Me.LAYERAMOUNT.Width = 60
        '
        'BROILERAMOUNT
        '
        DataGridViewCellStyle60.Format = "0.00"
        Me.BROILERAMOUNT.DefaultCellStyle = DataGridViewCellStyle60
        Me.BROILERAMOUNT.HeaderText = "BROILER AMOUNT"
        Me.BROILERAMOUNT.Name = "BROILERAMOUNT"
        Me.BROILERAMOUNT.ReadOnly = True
        Me.BROILERAMOUNT.Width = 60
        '
        'COCKRELEAMOUNT
        '
        DataGridViewCellStyle61.Format = "0.00"
        Me.COCKRELEAMOUNT.DefaultCellStyle = DataGridViewCellStyle61
        Me.COCKRELEAMOUNT.HeaderText = "COCKRELE AMOUNT"
        Me.COCKRELEAMOUNT.Name = "COCKRELEAMOUNT"
        Me.COCKRELEAMOUNT.ReadOnly = True
        Me.COCKRELEAMOUNT.Width = 60
        '
        'AREA
        '
        Me.AREA.HeaderText = "AREA"
        Me.AREA.Name = "AREA"
        Me.AREA.ReadOnly = True
        Me.AREA.Width = 60
        '
        'PNAME
        '
        Me.PNAME.HeaderText = "PRODUCT NAME"
        Me.PNAME.Name = "PNAME"
        Me.PNAME.ReadOnly = True
        Me.PNAME.Width = 75
        '
        'unitprice
        '
        DataGridViewCellStyle62.Format = "0.00"
        Me.unitprice.DefaultCellStyle = DataGridViewCellStyle62
        Me.unitprice.HeaderText = "Unit Price"
        Me.unitprice.Name = "unitprice"
        Me.unitprice.ReadOnly = True
        Me.unitprice.Width = 30
        '
        'freeper
        '
        Me.freeper.HeaderText = "Free Per"
        Me.freeper.Name = "freeper"
        Me.freeper.ReadOnly = True
        Me.freeper.Width = 50
        '
        'neccrate
        '
        DataGridViewCellStyle63.Format = "0.00"
        Me.neccrate.DefaultCellStyle = DataGridViewCellStyle63
        Me.neccrate.HeaderText = "NECC Rate"
        Me.neccrate.Name = "neccrate"
        Me.neccrate.ReadOnly = True
        Me.neccrate.Width = 50
        '
        'TotalAmount
        '
        Me.TotalAmount.HeaderText = "TotalAmount"
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        Me.TotalAmount.Width = 50
        '
        'DISCOUNTAMOUNT
        '
        Me.DISCOUNTAMOUNT.HeaderText = "DISCOUNT AMOUNT"
        Me.DISCOUNTAMOUNT.Name = "DISCOUNTAMOUNT"
        Me.DISCOUNTAMOUNT.ReadOnly = True
        Me.DISCOUNTAMOUNT.Width = 50
        '
        'DISRATE
        '
        Me.DISRATE.HeaderText = "DIS.RATE"
        Me.DISRATE.Name = "DISRATE"
        Me.DISRATE.ReadOnly = True
        Me.DISRATE.Width = 50
        '
        'BRhatchEGGS
        '
        Me.BRhatchEGGS.HeaderText = "BRhatchEGGS"
        Me.BRhatchEGGS.Name = "BRhatchEGGS"
        Me.BRhatchEGGS.ReadOnly = True
        Me.BRhatchEGGS.Width = 50
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(193, 36)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtCrNoFrom.TabIndex = 158
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(452, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 28)
        Me.Button1.TabIndex = 165
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSaleInvoicePrintWithDiscountonAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgCRDebit)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.Name = "frmSaleInvoicePrintWithDiscountonAmount"
        Me.Text = "frmSaleInvoicePrint"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgCRDebit As System.Windows.Forms.DataGridView
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents INVNO_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOOFCHICKS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FREE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NECCAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LAYERAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BROILERAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COCKRELEAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AREA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents freeper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neccrate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISCOUNTAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISRATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BRhatchEGGS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
