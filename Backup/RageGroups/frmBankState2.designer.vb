<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankState2
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmbacccode = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblopen = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgbankstate = New System.Windows.Forms.DataGridView
        Me.edate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHQNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WITHDRAWAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEPOSIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BALANCE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.issuedate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.entryid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbacchead = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.dgbankstate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbacccode
        '
        Me.cmbacccode.BackColor = System.Drawing.Color.White
        Me.cmbacccode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacccode.FormattingEnabled = True
        Me.cmbacccode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacccode.Location = New System.Drawing.Point(90, 40)
        Me.cmbacccode.MaxLength = 50
        Me.cmbacccode.Name = "cmbacccode"
        Me.cmbacccode.Size = New System.Drawing.Size(117, 21)
        Me.cmbacccode.TabIndex = 148
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "Bank A/c :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(700, 31)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "Bank Statement Entry"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblopen
        '
        Me.lblopen.AutoSize = True
        Me.lblopen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblopen.Location = New System.Drawing.Point(91, 65)
        Me.lblopen.Name = "lblopen"
        Me.lblopen.Size = New System.Drawing.Size(50, 16)
        Me.lblopen.TabIndex = 155
        Me.lblopen.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Opening :"
        '
        'dgbankstate
        '
        Me.dgbankstate.AllowUserToAddRows = False
        Me.dgbankstate.AllowUserToOrderColumns = True
        Me.dgbankstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbankstate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.edate, Me.CHQNO, Me.WITHDRAWAL, Me.DEPOSIT, Me.BALANCE, Me.issuedate, Me.entryid})
        Me.dgbankstate.Location = New System.Drawing.Point(4, 97)
        Me.dgbankstate.Name = "dgbankstate"
        Me.dgbankstate.RowTemplate.Height = 20
        Me.dgbankstate.Size = New System.Drawing.Size(689, 398)
        Me.dgbankstate.TabIndex = 152
        '
        'edate
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Format = "dd/MM/yy"
        Me.edate.DefaultCellStyle = DataGridViewCellStyle1
        Me.edate.HeaderText = "Entry Date"
        Me.edate.MaxInputLength = 8
        Me.edate.Name = "edate"
        '
        'CHQNO
        '
        Me.CHQNO.HeaderText = "CHEQUE NO"
        Me.CHQNO.MaxInputLength = 20
        Me.CHQNO.Name = "CHQNO"
        Me.CHQNO.Width = 70
        '
        'WITHDRAWAL
        '
        Me.WITHDRAWAL.HeaderText = "WITHDRAWAL"
        Me.WITHDRAWAL.MaxInputLength = 20
        Me.WITHDRAWAL.Name = "WITHDRAWAL"
        Me.WITHDRAWAL.Width = 80
        '
        'DEPOSIT
        '
        Me.DEPOSIT.HeaderText = "DEPOSIT"
        Me.DEPOSIT.MaxInputLength = 20
        Me.DEPOSIT.Name = "DEPOSIT"
        Me.DEPOSIT.Width = 70
        '
        'BALANCE
        '
        Me.BALANCE.HeaderText = "BALANCE"
        Me.BALANCE.MaxInputLength = 20
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.Width = 70
        '
        'issuedate
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.issuedate.DefaultCellStyle = DataGridViewCellStyle2
        Me.issuedate.HeaderText = "ISSUE DATE"
        Me.issuedate.MaxInputLength = 15
        Me.issuedate.Name = "issuedate"
        Me.issuedate.ReadOnly = True
        '
        'entryid
        '
        Me.entryid.HeaderText = "Entry ID"
        Me.entryid.Name = "entryid"
        Me.entryid.ReadOnly = True
        Me.entryid.Visible = False
        '
        'cmbacchead
        '
        Me.cmbacchead.BackColor = System.Drawing.Color.White
        Me.cmbacchead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacchead.FormattingEnabled = True
        Me.cmbacchead.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacchead.Location = New System.Drawing.Point(213, 40)
        Me.cmbacchead.MaxLength = 50
        Me.cmbacchead.Name = "cmbacchead"
        Me.cmbacchead.Size = New System.Drawing.Size(264, 21)
        Me.cmbacchead.TabIndex = 149
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(637, 501)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 31)
        Me.Button4.TabIndex = 163
        Me.Button4.Text = "&Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmBankState2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(700, 544)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmbacccode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblopen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgbankstate)
        Me.Controls.Add(Me.cmbacchead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBankState2"
        Me.Text = "frmBankState2"
        CType(Me.dgbankstate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbacccode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblopen As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgbankstate As System.Windows.Forms.DataGridView
    Friend WithEvents cmbacchead As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents edate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHQNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WITHDRAWAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPOSIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents issuedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents entryid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
