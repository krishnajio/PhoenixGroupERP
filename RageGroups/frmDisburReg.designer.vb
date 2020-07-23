<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisburReg
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dthatchdate = New System.Windows.Forms.DateTimePicker()
        Me.dgItemOpening = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCollectinRec = New System.Windows.Forms.TextBox()
        Me.txtBankSlip = New System.Windows.Forms.TextBox()
        Me.txtDisdurNo = New System.Windows.Forms.TextBox()
        Me.dtRecDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCollectionDm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTrNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbAreaName = New System.Windows.Forms.ComboBox()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
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
        Me.Panel1.Location = New System.Drawing.Point(49, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 46)
        Me.Panel1.TabIndex = 7
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(332, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(78, 31)
        Me.btnclose.TabIndex = 13
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(250, 6)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(78, 31)
        Me.btnreset.TabIndex = 12
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(169, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(78, 31)
        Me.btndelete.TabIndex = 11
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(86, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(78, 31)
        Me.btnmodify.TabIndex = 10
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(7, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 31)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Hatch Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Disbursement No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Total Collection Dm:"
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
        Me.Label6.Size = New System.Drawing.Size(620, 31)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Disbursement Register"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dthatchdate
        '
        Me.dthatchdate.CustomFormat = "dd/MMM/yy"
        Me.dthatchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthatchdate.Location = New System.Drawing.Point(202, 94)
        Me.dthatchdate.Name = "dthatchdate"
        Me.dthatchdate.Size = New System.Drawing.Size(105, 22)
        Me.dthatchdate.TabIndex = 2
        '
        'dgItemOpening
        '
        Me.dgItemOpening.AllowUserToAddRows = False
        Me.dgItemOpening.AllowUserToOrderColumns = True
        Me.dgItemOpening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemOpening.Location = New System.Drawing.Point(12, 380)
        Me.dgItemOpening.Name = "dgItemOpening"
        Me.dgItemOpening.Size = New System.Drawing.Size(563, 304)
        Me.dgItemOpening.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Bank Slip :"
        '
        'txtCollectinRec
        '
        Me.txtCollectinRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollectinRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectinRec.Location = New System.Drawing.Point(202, 178)
        Me.txtCollectinRec.Name = "txtCollectinRec"
        Me.txtCollectinRec.Size = New System.Drawing.Size(128, 21)
        Me.txtCollectinRec.TabIndex = 5
        '
        'txtBankSlip
        '
        Me.txtBankSlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankSlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankSlip.Location = New System.Drawing.Point(202, 208)
        Me.txtBankSlip.Name = "txtBankSlip"
        Me.txtBankSlip.Size = New System.Drawing.Size(128, 21)
        Me.txtBankSlip.TabIndex = 6
        '
        'txtDisdurNo
        '
        Me.txtDisdurNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisdurNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisdurNo.Location = New System.Drawing.Point(202, 67)
        Me.txtDisdurNo.Name = "txtDisdurNo"
        Me.txtDisdurNo.Size = New System.Drawing.Size(128, 21)
        Me.txtDisdurNo.TabIndex = 1
        '
        'dtRecDate
        '
        Me.dtRecDate.CustomFormat = "dd/MMM/yy"
        Me.dtRecDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRecDate.Location = New System.Drawing.Point(202, 122)
        Me.dtRecDate.Name = "dtRecDate"
        Me.dtRecDate.Size = New System.Drawing.Size(105, 22)
        Me.dtRecDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 16)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "DM Receving Date :"
        '
        'txtCollectionDm
        '
        Me.txtCollectionDm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollectionDm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollectionDm.Location = New System.Drawing.Point(202, 152)
        Me.txtCollectionDm.Name = "txtCollectionDm"
        Me.txtCollectionDm.Size = New System.Drawing.Size(128, 21)
        Me.txtCollectionDm.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 16)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Total Collection Received:"
        '
        'txtRem
        '
        Me.txtRem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRem.Location = New System.Drawing.Point(202, 235)
        Me.txtRem.Multiline = True
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(278, 49)
        Me.txtRem.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Remarks :"
        '
        'txtTrNo
        '
        Me.txtTrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrNo.Location = New System.Drawing.Point(202, 290)
        Me.txtTrNo.Name = "txtTrNo"
        Me.txtTrNo.Size = New System.Drawing.Size(128, 21)
        Me.txtTrNo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(129, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "T.R No :"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(336, 69)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(13, 16)
        Me.lblId.TabIndex = 100
        Me.lblId.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(151, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "Area:"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(202, 40)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(173, 24)
        Me.cmbAreaName.TabIndex = 0
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(381, 40)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(107, 24)
        Me.cmbAreaCode.TabIndex = 142
        Me.cmbAreaCode.TabStop = False
        '
        'frmDisburReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(620, 674)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtTrNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCollectionDm)
        Me.Controls.Add(Me.dtRecDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDisdurNo)
        Me.Controls.Add(Me.txtBankSlip)
        Me.Controls.Add(Me.txtCollectinRec)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgItemOpening)
        Me.Controls.Add(Me.dthatchdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDisburReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement Register"
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dthatchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgItemOpening As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCollectinRec As System.Windows.Forms.TextBox
    Friend WithEvents txtBankSlip As System.Windows.Forms.TextBox
    Friend WithEvents txtDisdurNo As System.Windows.Forms.TextBox
    Friend WithEvents dtRecDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCollectionDm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRem As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
End Class
