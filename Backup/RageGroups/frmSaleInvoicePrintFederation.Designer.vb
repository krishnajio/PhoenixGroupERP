<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleInvoicePrintFederation
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.txtCrNoTo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgCRDebit = New System.Windows.Forms.DataGridView
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox
        Me.INVNO_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acc_head = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOOFCHICKS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FREE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INVAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AREA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vou_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(504, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 28)
        Me.Button1.TabIndex = 173
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Label6.Size = New System.Drawing.Size(976, 31)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "SALE INV. PRINT FARMING FEDERATION"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(440, 32)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 168
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(353, 34)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(80, 20)
        Me.txtCrNoTo.TabIndex = 167
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 15)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Sale Voucher Number From :"
        '
        'dgCRDebit
        '
        Me.dgCRDebit.AllowUserToAddRows = False
        Me.dgCRDebit.AllowUserToDeleteRows = False
        Me.dgCRDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INVNO_DATE, Me.Hdate, Me.acc_head, Me.NOOFCHICKS, Me.FREE, Me.INVAMOUNT, Me.AREA, Me.PNAME, Me.unitprice, Me.TotalAmount, Me.Vou_no})
        Me.dgCRDebit.Location = New System.Drawing.Point(56, 66)
        Me.dgCRDebit.Name = "dgCRDebit"
        Me.dgCRDebit.ReadOnly = True
        Me.dgCRDebit.Size = New System.Drawing.Size(874, 505)
        Me.dgCRDebit.TabIndex = 171
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(245, 34)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtCrNoFrom.TabIndex = 166
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
        DataGridViewCellStyle5.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Hdate.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.NullValue = Nothing
        Me.NOOFCHICKS.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.INVAMOUNT.DefaultCellStyle = DataGridViewCellStyle7
        Me.INVAMOUNT.HeaderText = "INV AMOUNT"
        Me.INVAMOUNT.Name = "INVAMOUNT"
        Me.INVAMOUNT.ReadOnly = True
        Me.INVAMOUNT.Width = 75
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
        DataGridViewCellStyle8.Format = "0.00"
        Me.unitprice.DefaultCellStyle = DataGridViewCellStyle8
        Me.unitprice.HeaderText = "Unit Price"
        Me.unitprice.Name = "unitprice"
        Me.unitprice.ReadOnly = True
        Me.unitprice.Width = 50
        '
        'TotalAmount
        '
        Me.TotalAmount.HeaderText = "TotalAmount"
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        Me.TotalAmount.Width = 75
        '
        'Vou_no
        '
        Me.Vou_no.HeaderText = "Vou_no"
        Me.Vou_no.Name = "Vou_no"
        Me.Vou_no.ReadOnly = True
        '
        'frmSaleInvoicePrintFederation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(976, 551)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgCRDebit)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaleInvoicePrintFederation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSaleInvoicePrintFederation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgCRDebit As System.Windows.Forms.DataGridView
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents INVNO_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOOFCHICKS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FREE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AREA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vou_no As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
