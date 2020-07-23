<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase_Register
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.txtCrNoTo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgPurchase = New System.Windows.Forms.DataGridView
        Me.btndosprint = New System.Windows.Forms.Button
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtFrom = New System.Windows.Forms.DateTimePicker
        Me.BILLNODATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PARTYNAMEADD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PURNOTINNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRODUCTNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PARTYAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FREIGHTAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VATAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOTALAMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label6.Size = New System.Drawing.Size(804, 31)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Purchase Register"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(422, 32)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 159
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(335, 34)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(80, 20)
        Me.txtCrNoTo.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "To"
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(227, 34)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtCrNoFrom.TabIndex = 157
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-3, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 15)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Purchase  Voucher Number From :"
        '
        'dgPurchase
        '
        Me.dgPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPurchase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BILLNODATE, Me.PARTYNAMEADD, Me.PURNOTINNO, Me.PRODUCTNAME, Me.PARTYAMOUNT, Me.FREIGHTAMOUNT, Me.VATAMOUNT, Me.TOTALAMOUNT})
        Me.dgPurchase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPurchase.Location = New System.Drawing.Point(0, 66)
        Me.dgPurchase.Name = "dgPurchase"
        Me.dgPurchase.Size = New System.Drawing.Size(804, 388)
        Me.dgPurchase.TabIndex = 163
        '
        'btndosprint
        '
        Me.btndosprint.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndosprint.Location = New System.Drawing.Point(486, 33)
        Me.btndosprint.Name = "btndosprint"
        Me.btndosprint.Size = New System.Drawing.Size(106, 28)
        Me.btndosprint.TabIndex = 164
        Me.btndosprint.Text = "&MS DOS Print"
        Me.btndosprint.UseVisualStyleBackColor = True
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(685, 37)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(81, 20)
        Me.dtTo.TabIndex = 167
        '
        'dtFrom
        '
        Me.dtFrom.CustomFormat = "dd/MMM/yy"
        Me.dtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(598, 37)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(81, 20)
        Me.dtFrom.TabIndex = 166
        '
        'BILLNODATE
        '
        Me.BILLNODATE.HeaderText = "BILL NO. DATE"
        Me.BILLNODATE.Name = "BILLNODATE"
        Me.BILLNODATE.ReadOnly = True
        Me.BILLNODATE.Width = 60
        '
        'PARTYNAMEADD
        '
        Me.PARTYNAMEADD.HeaderText = "PARTY NAME & ADDRESS"
        Me.PARTYNAMEADD.Name = "PARTYNAMEADD"
        Me.PARTYNAMEADD.ReadOnly = True
        '
        'PURNOTINNO
        '
        Me.PURNOTINNO.HeaderText = "PUR.N0 MPST NO"
        Me.PURNOTINNO.Name = "PURNOTINNO"
        Me.PURNOTINNO.ReadOnly = True
        '
        'PRODUCTNAME
        '
        Me.PRODUCTNAME.HeaderText = "PRODUCT NAME"
        Me.PRODUCTNAME.Name = "PRODUCTNAME"
        Me.PRODUCTNAME.ReadOnly = True
        '
        'PARTYAMOUNT
        '
        Me.PARTYAMOUNT.HeaderText = "TOTAL AMOUNT"
        Me.PARTYAMOUNT.Name = "PARTYAMOUNT"
        Me.PARTYAMOUNT.ReadOnly = True
        '
        'FREIGHTAMOUNT
        '
        Me.FREIGHTAMOUNT.HeaderText = "FREIGHT AMOUNT"
        Me.FREIGHTAMOUNT.Name = "FREIGHTAMOUNT"
        Me.FREIGHTAMOUNT.ReadOnly = True
        '
        'VATAMOUNT
        '
        Me.VATAMOUNT.HeaderText = "VAT/CST AMOUNT"
        Me.VATAMOUNT.Name = "VATAMOUNT"
        Me.VATAMOUNT.ReadOnly = True
        '
        'TOTALAMOUNT
        '
        Me.TOTALAMOUNT.HeaderText = "PARTY AMOUNT"
        Me.TOTALAMOUNT.Name = "TOTALAMOUNT"
        Me.TOTALAMOUNT.ReadOnly = True
        '
        'frmPurchase_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(804, 454)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.btndosprint)
        Me.Controls.Add(Me.dgPurchase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.Controls.Add(Me.Label8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurchase_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPurchase_Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents btndosprint As System.Windows.Forms.Button
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents BILLNODATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARTYNAMEADD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURNOTINNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARTYAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FREIGHTAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VATAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALAMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
