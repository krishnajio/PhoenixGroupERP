<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstockopening
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cmbareacode = New System.Windows.Forms.ComboBox
        Me.Cmbareaname = New System.Windows.Forms.ComboBox
        Me.Cmbitemname = New System.Windows.Forms.ComboBox
        Me.Txtqty = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtdate = New System.Windows.Forms.DateTimePicker
        Me.dgItemOpening = New System.Windows.Forms.DataGridView
        Me.CHQNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.umit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WITHDRAWAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sessi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbunit = New System.Windows.Forms.ComboBox
        Me.txtRate = New System.Windows.Forms.ComboBox
        Me.cmbAmount = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        CType(Me.dgItemOpening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(5, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 46)
        Me.Panel1.TabIndex = 35
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(332, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(78, 31)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(250, 6)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(78, 31)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(169, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(78, 31)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(86, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(78, 31)
        Me.btnmodify.TabIndex = 4
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(7, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 31)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Area :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Item Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "QTY :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Rate :"
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
        Me.Label6.Size = New System.Drawing.Size(432, 31)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Stock Opening"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cmbareacode
        '
        Me.Cmbareacode.BackColor = System.Drawing.Color.White
        Me.Cmbareacode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbareacode.FormattingEnabled = True
        Me.Cmbareacode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.Cmbareacode.Location = New System.Drawing.Point(98, 71)
        Me.Cmbareacode.MaxLength = 1
        Me.Cmbareacode.Name = "Cmbareacode"
        Me.Cmbareacode.Size = New System.Drawing.Size(94, 24)
        Me.Cmbareacode.TabIndex = 74
        '
        'Cmbareaname
        '
        Me.Cmbareaname.BackColor = System.Drawing.Color.White
        Me.Cmbareaname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbareaname.FormattingEnabled = True
        Me.Cmbareaname.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.Cmbareaname.Location = New System.Drawing.Point(198, 71)
        Me.Cmbareaname.MaxLength = 50
        Me.Cmbareaname.Name = "Cmbareaname"
        Me.Cmbareaname.Size = New System.Drawing.Size(126, 24)
        Me.Cmbareaname.TabIndex = 2
        '
        'Cmbitemname
        '
        Me.Cmbitemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbitemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbitemname.BackColor = System.Drawing.Color.White
        Me.Cmbitemname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbitemname.FormattingEnabled = True
        Me.Cmbitemname.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.Cmbitemname.Location = New System.Drawing.Point(98, 101)
        Me.Cmbitemname.MaxLength = 30
        Me.Cmbitemname.Name = "Cmbitemname"
        Me.Cmbitemname.Size = New System.Drawing.Size(226, 24)
        Me.Cmbitemname.TabIndex = 3
        '
        'Txtqty
        '
        Me.Txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtqty.Location = New System.Drawing.Point(98, 131)
        Me.Txtqty.MaxLength = 30
        Me.Txtqty.Name = "Txtqty"
        Me.Txtqty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtqty.Size = New System.Drawing.Size(129, 22)
        Me.Txtqty.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Amount :"
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(98, 44)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(96, 22)
        Me.dtdate.TabIndex = 0
        '
        'dgItemOpening
        '
        Me.dgItemOpening.AllowUserToAddRows = False
        Me.dgItemOpening.AllowUserToOrderColumns = True
        Me.dgItemOpening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemOpening.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHQNO, Me.Column1, Me.Column4, Me.umit, Me.WITHDRAWAL, Me.Column2, Me.sessi})
        Me.dgItemOpening.Location = New System.Drawing.Point(5, 262)
        Me.dgItemOpening.Name = "dgItemOpening"
        Me.dgItemOpening.Size = New System.Drawing.Size(427, 133)
        Me.dgItemOpening.TabIndex = 83
        '
        'CHQNO
        '
        Me.CHQNO.DataPropertyName = "AreaCode"
        Me.CHQNO.HeaderText = "Area Code"
        Me.CHQNO.MaxInputLength = 2
        Me.CHQNO.Name = "CHQNO"
        Me.CHQNO.Width = 50
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ItemName"
        Me.Column1.HeaderText = "Item Name"
        Me.Column1.MaxInputLength = 30
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Qty"
        Me.Column4.HeaderText = "QTY."
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'umit
        '
        Me.umit.DataPropertyName = "Unit"
        Me.umit.HeaderText = "Unit"
        Me.umit.Name = "umit"
        '
        'WITHDRAWAL
        '
        Me.WITHDRAWAL.DataPropertyName = "Rate"
        Me.WITHDRAWAL.HeaderText = "Rate"
        Me.WITHDRAWAL.MaxInputLength = 6
        Me.WITHDRAWAL.Name = "WITHDRAWAL"
        Me.WITHDRAWAL.Width = 50
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Amount"
        Me.Column2.HeaderText = "Amount"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'sessi
        '
        Me.sessi.DataPropertyName = "Session"
        Me.sessi.HeaderText = "Session"
        Me.sessi.Name = "sessi"
        '
        'cmbunit
        '
        Me.cmbunit.BackColor = System.Drawing.Color.White
        Me.cmbunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbunit.FormattingEnabled = True
        Me.cmbunit.Items.AddRange(New Object() {"Kg", "Lt", "Tonnes", "Ml", "No"})
        Me.cmbunit.Location = New System.Drawing.Point(233, 128)
        Me.cmbunit.MaxLength = 50
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(91, 24)
        Me.cmbunit.TabIndex = 5
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.White
        Me.txtRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.FormattingEnabled = True
        Me.txtRate.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.txtRate.Location = New System.Drawing.Point(98, 161)
        Me.txtRate.MaxLength = 30
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(129, 24)
        Me.txtRate.TabIndex = 6
        '
        'cmbAmount
        '
        Me.cmbAmount.BackColor = System.Drawing.Color.White
        Me.cmbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAmount.FormattingEnabled = True
        Me.cmbAmount.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbAmount.Location = New System.Drawing.Point(98, 191)
        Me.cmbAmount.MaxLength = 30
        Me.cmbAmount.Name = "cmbAmount"
        Me.cmbAmount.Size = New System.Drawing.Size(129, 24)
        Me.cmbAmount.TabIndex = 7
        '
        'frmstockopening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(432, 407)
        Me.Controls.Add(Me.cmbAmount)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.cmbunit)
        Me.Controls.Add(Me.dgItemOpening)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txtqty)
        Me.Controls.Add(Me.Cmbitemname)
        Me.Controls.Add(Me.Cmbareaname)
        Me.Controls.Add(Me.Cmbareacode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmstockopening"
        Me.Text = "frmstockopening"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgItemOpening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmbareaname As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbareacode As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbitemname As System.Windows.Forms.ComboBox
    Friend WithEvents Txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgItemOpening As System.Windows.Forms.DataGridView
    Friend WithEvents cmbunit As System.Windows.Forms.ComboBox
    Friend WithEvents txtRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAmount As System.Windows.Forms.ComboBox
    Friend WithEvents CHQNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents umit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WITHDRAWAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sessi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
