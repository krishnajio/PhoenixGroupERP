<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherSaleReg
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PRD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.txtCrNoTo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NECCAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCRDebit = New System.Windows.Forms.DataGridView()
        Me.INVNO_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acc_head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOOFCHICKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FREE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voutype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRD
        '
        Me.PRD.HeaderText = "PRODUCT"
        Me.PRD.Name = "PRD"
        Me.PRD.ReadOnly = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 62)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1028, 678)
        Me.CrystalReportViewer1.TabIndex = 167
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
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
        Me.Label6.Size = New System.Drawing.Size(1020, 31)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "OTHER SALE REGISTER"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(850, 36)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 161
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(343, 36)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(80, 20)
        Me.txtCrNoTo.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "To"
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(235, 36)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtCrNoFrom.TabIndex = 159
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 15)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Other Sale Voucher Number From :"
        '
        'NECCAMOUNT
        '
        Me.NECCAMOUNT.HeaderText = "NECC AMOUNT"
        Me.NECCAMOUNT.Name = "NECCAMOUNT"
        Me.NECCAMOUNT.ReadOnly = True
        '
        'INVDATE
        '
        Me.INVDATE.HeaderText = "INV DATE"
        Me.INVDATE.Name = "INVDATE"
        Me.INVDATE.ReadOnly = True
        Me.INVDATE.Width = 75
        '
        'Hdate
        '
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Hdate.DefaultCellStyle = DataGridViewCellStyle1
        Me.Hdate.HeaderText = "HATCH DATE"
        Me.Hdate.Name = "Hdate"
        Me.Hdate.ReadOnly = True
        Me.Hdate.Width = 75
        '
        'dgCRDebit
        '
        Me.dgCRDebit.AllowUserToAddRows = False
        Me.dgCRDebit.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCRDebit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgCRDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INVNO_DATE, Me.INVDATE, Me.Hdate, Me.CUSTCODE, Me.acc_head, Me.NOOFCHICKS, Me.FREE, Me.INVAMOUNT, Me.NECCAMOUNT, Me.PRD})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCRDebit.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgCRDebit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgCRDebit.Location = New System.Drawing.Point(0, 319)
        Me.dgCRDebit.Name = "dgCRDebit"
        Me.dgCRDebit.ReadOnly = True
        Me.dgCRDebit.Size = New System.Drawing.Size(1020, 414)
        Me.dgCRDebit.TabIndex = 164
        '
        'INVNO_DATE
        '
        Me.INVNO_DATE.HeaderText = "INV NO "
        Me.INVNO_DATE.Name = "INVNO_DATE"
        Me.INVNO_DATE.ReadOnly = True
        Me.INVNO_DATE.Width = 60
        '
        'CUSTCODE
        '
        Me.CUSTCODE.HeaderText = "CUST. CODE"
        Me.CUSTCODE.Name = "CUSTCODE"
        Me.CUSTCODE.ReadOnly = True
        Me.CUSTCODE.Width = 60
        '
        'acc_head
        '
        Me.acc_head.HeaderText = "CUSTOMER  NAME  "
        Me.acc_head.Name = "acc_head"
        Me.acc_head.ReadOnly = True
        Me.acc_head.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.acc_head.Width = 200
        '
        'NOOFCHICKS
        '
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.NOOFCHICKS.DefaultCellStyle = DataGridViewCellStyle3
        Me.NOOFCHICKS.HeaderText = "QTY"
        Me.NOOFCHICKS.MaxInputLength = 20
        Me.NOOFCHICKS.Name = "NOOFCHICKS"
        Me.NOOFCHICKS.ReadOnly = True
        Me.NOOFCHICKS.Width = 60
        '
        'FREE
        '
        Me.FREE.HeaderText = "FREE QTY"
        Me.FREE.Name = "FREE"
        Me.FREE.ReadOnly = True
        Me.FREE.Width = 50
        '
        'INVAMOUNT
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.INVAMOUNT.DefaultCellStyle = DataGridViewCellStyle4
        Me.INVAMOUNT.HeaderText = "INV AMOUNT"
        Me.INVAMOUNT.Name = "INVAMOUNT"
        Me.INVAMOUNT.ReadOnly = True
        Me.INVAMOUNT.Width = 75
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Items.AddRange(New Object() {"OTHER SALE MANSAR", "OTHER SALE", "OTHER SALE CASH", "OTHER SALE RET.", "FEED TRANSFER", "CHICKS TRANSFER", "OTHER SALE CASH RP", "OTHER SALE FEED", "OTHER SALE PP", "-----------------------", "OTHER SALE(GST)", "OTHER SALE CASH(GST)", "OTHER SALE CASH RP(G", "OTHER SALE FEED(GST)", "-----------------------------", "OTHER SALE BM(GST)", "OTHER SALE CASH GSL", "OTHER SALE PARIYAT", "OTHER SALE CASH PA", "OTHER SALE HAJIPUR", "OTHER SALE WB", "OTHER SALE CASH WB", "OTHER SALE VARANSAI", "OTHER SALE CASH VARA", "OT SALE CASH HJ(GST)", "OT SALE CASH HJ(GST)", "OTHER SALE INTER UNI", "OTHER SALE CHICKS(GS", "OTHER SALE RP(GST)", "I U  TRANSFER(GST)", "OTHER SALE CASH AGR", "OTHER SALE CASH BM", "INTER TRANSFER"})
        Me.voutype.Location = New System.Drawing.Point(532, 37)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(312, 21)
        Me.voutype.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Voucher Type:"
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(914, 34)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(62, 28)
        Me.btnprint.TabIndex = 174
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'frmOtherSaleReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1020, 733)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.voutype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgCRDebit)
        Me.Name = "frmOtherSaleReg"
        Me.Text = "frmOtherSaleReg"
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NECCAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgCRDebit As System.Windows.Forms.DataGridView
    Friend WithEvents INVNO_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTCODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOOFCHICKS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FREE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
