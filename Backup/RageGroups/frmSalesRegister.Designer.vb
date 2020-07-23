<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesRegister
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.BRHATCHINGEGGS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.txtCrNoTo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCRDebit
        '
        Me.dgCRDebit.AllowUserToAddRows = False
        Me.dgCRDebit.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCRDebit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCRDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRDebit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INVNO_DATE, Me.Hdate, Me.acc_head, Me.NOOFCHICKS, Me.FREE, Me.INVAMOUNT, Me.NECCAMOUNT, Me.LAYERAMOUNT, Me.BROILERAMOUNT, Me.COCKRELEAMOUNT, Me.AREA, Me.BRHATCHINGEGGS})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCRDebit.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgCRDebit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgCRDebit.Location = New System.Drawing.Point(0, 145)
        Me.dgCRDebit.Name = "dgCRDebit"
        Me.dgCRDebit.ReadOnly = True
        Me.dgCRDebit.Size = New System.Drawing.Size(936, 378)
        Me.dgCRDebit.TabIndex = 155
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
        DataGridViewCellStyle2.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Hdate.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.acc_head.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.acc_head.Width = 150
        '
        'NOOFCHICKS
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.NOOFCHICKS.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.INVAMOUNT.DefaultCellStyle = DataGridViewCellStyle4
        Me.INVAMOUNT.HeaderText = "INV AMOUNT"
        Me.INVAMOUNT.Name = "INVAMOUNT"
        Me.INVAMOUNT.ReadOnly = True
        Me.INVAMOUNT.Width = 75
        '
        'NECCAMOUNT
        '
        Me.NECCAMOUNT.HeaderText = "NECC AMOUNT"
        Me.NECCAMOUNT.Name = "NECCAMOUNT"
        Me.NECCAMOUNT.ReadOnly = True
        '
        'LAYERAMOUNT
        '
        Me.LAYERAMOUNT.HeaderText = "LAYER AMOUNT"
        Me.LAYERAMOUNT.Name = "LAYERAMOUNT"
        Me.LAYERAMOUNT.ReadOnly = True
        Me.LAYERAMOUNT.Width = 60
        '
        'BROILERAMOUNT
        '
        Me.BROILERAMOUNT.HeaderText = "BROILER AMOUNT"
        Me.BROILERAMOUNT.Name = "BROILERAMOUNT"
        Me.BROILERAMOUNT.ReadOnly = True
        Me.BROILERAMOUNT.Width = 60
        '
        'COCKRELEAMOUNT
        '
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
        '
        'BRHATCHINGEGGS
        '
        Me.BRHATCHINGEGGS.HeaderText = "HATCHING EGGS"
        Me.BRHATCHINGEGGS.Name = "BRHATCHINGEGGS"
        Me.BRHATCHINGEGGS.ReadOnly = True
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
        Me.Label6.Size = New System.Drawing.Size(936, 31)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "SALE REGISTER"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(351, 34)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 152
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(264, 36)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(80, 20)
        Me.txtCrNoTo.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "To"
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(156, 36)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtCrNoFrom.TabIndex = 150
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-36, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 15)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Sale Voucher Number From :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(415, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 28)
        Me.Button1.TabIndex = 157
        Me.Button1.Text = "&Print MS DOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSalesRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(936, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgCRDebit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmSalesRegister"
        Me.Text = "frmSalesRegister"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCRDebit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCRDebit As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
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
    Friend WithEvents BRHATCHINGEGGS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
