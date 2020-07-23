<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmForm49
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.dg = New System.Windows.Forms.DataGridView
        Me.frm_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbName = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbCode = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.TxtfrmNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNoOfFrm = New System.Windows.Forms.TextBox
        Me.DtpIssueDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpfrmrecDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.DtpBillDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtReceivedBill = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 40)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Form 49"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(395, 50)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(14, 15)
        Me.lblID.TabIndex = 107
        Me.lblID.Text = "0"
        Me.lblID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(0, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 46)
        Me.Panel1.TabIndex = 8
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(314, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(56, 31)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(251, 5)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(57, 31)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(182, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(64, 31)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(113, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(64, 31)
        Me.btnmodify.TabIndex = 1
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(54, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(52, 31)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.Lavender
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.frm_no, Me.id})
        Me.dg.Location = New System.Drawing.Point(414, 40)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(141, 318)
        Me.dg.TabIndex = 9
        '
        'frm_no
        '
        Me.frm_no.HeaderText = "Form No."
        Me.frm_no.Name = "frm_no"
        Me.frm_no.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'cmbName
        '
        Me.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbName.BackColor = System.Drawing.Color.White
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(164, 59)
        Me.cmbName.MaxLength = 50
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(219, 21)
        Me.cmbName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Party Name"
        '
        'CmbCode
        '
        Me.CmbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCode.BackColor = System.Drawing.Color.White
        Me.CmbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCode.FormattingEnabled = True
        Me.CmbCode.Location = New System.Drawing.Point(164, 89)
        Me.CmbCode.MaxLength = 50
        Me.CmbCode.Name = "CmbCode"
        Me.CmbCode.Size = New System.Drawing.Size(219, 21)
        Me.CmbCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Party Code"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(24, 120)
        Me.Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(74, 15)
        Me.Label.TabIndex = 115
        Me.Label.Text = "Form 49 No."
        '
        'TxtfrmNo
        '
        Me.TxtfrmNo.BackColor = System.Drawing.Color.White
        Me.TxtfrmNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtfrmNo.Location = New System.Drawing.Point(164, 117)
        Me.TxtfrmNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtfrmNo.Name = "TxtfrmNo"
        Me.TxtfrmNo.Size = New System.Drawing.Size(219, 21)
        Me.TxtfrmNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "No. Of Form Issue"
        '
        'TxtNoOfFrm
        '
        Me.TxtNoOfFrm.BackColor = System.Drawing.Color.White
        Me.TxtNoOfFrm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoOfFrm.Location = New System.Drawing.Point(164, 149)
        Me.TxtNoOfFrm.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNoOfFrm.Name = "TxtNoOfFrm"
        Me.TxtNoOfFrm.Size = New System.Drawing.Size(219, 21)
        Me.TxtNoOfFrm.TabIndex = 3
        '
        'DtpIssueDate
        '
        Me.DtpIssueDate.CustomFormat = "dd/MMM/yyyy"
        Me.DtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpIssueDate.Location = New System.Drawing.Point(164, 183)
        Me.DtpIssueDate.Name = "DtpIssueDate"
        Me.DtpIssueDate.Size = New System.Drawing.Size(219, 20)
        Me.DtpIssueDate.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Issue Date"
        '
        'DtpfrmrecDate
        '
        Me.DtpfrmrecDate.CustomFormat = "dd/MMM/yyyy"
        Me.DtpfrmrecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpfrmrecDate.Location = New System.Drawing.Point(164, 277)
        Me.DtpfrmrecDate.Name = "DtpfrmrecDate"
        Me.DtpfrmrecDate.Size = New System.Drawing.Size(219, 20)
        Me.DtpfrmrecDate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 280)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 15)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Form 49 Received Date"
        '
        'DtpBillDate
        '
        Me.DtpBillDate.CustomFormat = "dd/MMM/yyyy"
        Me.DtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpBillDate.Location = New System.Drawing.Point(164, 245)
        Me.DtpBillDate.Name = "DtpBillDate"
        Me.DtpBillDate.Size = New System.Drawing.Size(219, 20)
        Me.DtpBillDate.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 248)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Bill Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 218)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Received Bill No."
        '
        'TxtReceivedBill
        '
        Me.TxtReceivedBill.BackColor = System.Drawing.Color.White
        Me.TxtReceivedBill.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceivedBill.Location = New System.Drawing.Point(164, 215)
        Me.TxtReceivedBill.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtReceivedBill.Name = "TxtReceivedBill"
        Me.TxtReceivedBill.Size = New System.Drawing.Size(219, 21)
        Me.TxtReceivedBill.TabIndex = 5
        '
        'FrmForm49
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(555, 358)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtReceivedBill)
        Me.Controls.Add(Me.DtpBillDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpfrmrecDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpIssueDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNoOfFrm)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.TxtfrmNo)
        Me.Controls.Add(Me.CmbCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmForm49"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form 49"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents TxtfrmNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoOfFrm As System.Windows.Forms.TextBox
    Friend WithEvents DtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpfrmrecDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpBillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtReceivedBill As System.Windows.Forms.TextBox
    Friend WithEvents frm_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
