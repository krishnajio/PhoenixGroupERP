<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTCSReport
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmbTdsper = New System.Windows.Forms.ComboBox()
        Me.cmbtdsType = New System.Windows.Forms.ComboBox()
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkAllParty = New System.Windows.Forms.CheckBox()
        Me.cmbPartyGroup = New System.Windows.Forms.ComboBox()
        Me.cmbPartCode = New System.Windows.Forms.ComboBox()
        Me.cmbPartyHead = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbTcsHeadCode = New System.Windows.Forms.ComboBox()
        Me.rdPurchase = New System.Windows.Forms.RadioButton()
        Me.rdSale = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1167, 37)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "TCS Report"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Honeydew
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1167, 72)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dt1
        '
        Me.dt1.CustomFormat = "dd/MMM/yy"
        Me.dt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt1.Location = New System.Drawing.Point(105, 74)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(87, 21)
        Me.dt1.TabIndex = 165
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Honeydew
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 166
        Me.Label13.Text = "Voucher Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Honeydew
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "To"
        '
        'dt2
        '
        Me.dt2.CustomFormat = "dd/MMM/yy"
        Me.dt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt2.Location = New System.Drawing.Point(227, 74)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(87, 21)
        Me.dt2.TabIndex = 168
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(1101, 77)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(54, 28)
        Me.btnShow.TabIndex = 169
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 109)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1167, 633)
        Me.CrystalReportViewer1.TabIndex = 170
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'cmbTdsper
        '
        Me.cmbTdsper.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTdsper.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTdsper.BackColor = System.Drawing.Color.White
        Me.cmbTdsper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbTdsper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTdsper.FormattingEnabled = True
        Me.cmbTdsper.Location = New System.Drawing.Point(670, 79)
        Me.cmbTdsper.Name = "cmbTdsper"
        Me.cmbTdsper.Size = New System.Drawing.Size(110, 21)
        Me.cmbTdsper.TabIndex = 172
        '
        'cmbtdsType
        '
        Me.cmbtdsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbtdsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtdsType.BackColor = System.Drawing.Color.White
        Me.cmbtdsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtdsType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtdsType.FormattingEnabled = True
        Me.cmbtdsType.Location = New System.Drawing.Point(400, 77)
        Me.cmbtdsType.Name = "cmbtdsType"
        Me.cmbtdsType.Size = New System.Drawing.Size(266, 21)
        Me.cmbtdsType.TabIndex = 171
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(784, 79)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbacheadcode.TabIndex = 173
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Honeydew
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "TCS Type:"
        '
        'ChkAllParty
        '
        Me.ChkAllParty.AutoSize = True
        Me.ChkAllParty.BackColor = System.Drawing.Color.Honeydew
        Me.ChkAllParty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllParty.Location = New System.Drawing.Point(6, 44)
        Me.ChkAllParty.Name = "ChkAllParty"
        Me.ChkAllParty.Size = New System.Drawing.Size(78, 19)
        Me.ChkAllParty.TabIndex = 175
        Me.ChkAllParty.Text = "All Party"
        Me.ChkAllParty.UseVisualStyleBackColor = False
        '
        'cmbPartyGroup
        '
        Me.cmbPartyGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyGroup.BackColor = System.Drawing.Color.White
        Me.cmbPartyGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPartyGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyGroup.FormattingEnabled = True
        Me.cmbPartyGroup.Location = New System.Drawing.Point(634, 41)
        Me.cmbPartyGroup.Name = "cmbPartyGroup"
        Me.cmbPartyGroup.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartyGroup.TabIndex = 198
        '
        'cmbPartCode
        '
        Me.cmbPartCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartCode.BackColor = System.Drawing.Color.White
        Me.cmbPartCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPartCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPartCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartCode.FormattingEnabled = True
        Me.cmbPartCode.Location = New System.Drawing.Point(520, 41)
        Me.cmbPartCode.Name = "cmbPartCode"
        Me.cmbPartCode.Size = New System.Drawing.Size(110, 21)
        Me.cmbPartCode.TabIndex = 197
        '
        'cmbPartyHead
        '
        Me.cmbPartyHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPartyHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPartyHead.BackColor = System.Drawing.Color.White
        Me.cmbPartyHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPartyHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPartyHead.FormattingEnabled = True
        Me.cmbPartyHead.Location = New System.Drawing.Point(159, 42)
        Me.cmbPartyHead.Name = "cmbPartyHead"
        Me.cmbPartyHead.Size = New System.Drawing.Size(357, 21)
        Me.cmbPartyHead.TabIndex = 195
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Honeydew
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label11.Location = New System.Drawing.Point(91, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "Party A/c"
        '
        'cmbTcsHeadCode
        '
        Me.cmbTcsHeadCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTcsHeadCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTcsHeadCode.BackColor = System.Drawing.Color.White
        Me.cmbTcsHeadCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTcsHeadCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTcsHeadCode.FormattingEnabled = True
        Me.cmbTcsHeadCode.Location = New System.Drawing.Point(901, 79)
        Me.cmbTcsHeadCode.Name = "cmbTcsHeadCode"
        Me.cmbTcsHeadCode.Size = New System.Drawing.Size(194, 21)
        Me.cmbTcsHeadCode.TabIndex = 199
        '
        'rdPurchase
        '
        Me.rdPurchase.AutoSize = True
        Me.rdPurchase.Location = New System.Drawing.Point(853, 44)
        Me.rdPurchase.Name = "rdPurchase"
        Me.rdPurchase.Size = New System.Drawing.Size(70, 17)
        Me.rdPurchase.TabIndex = 200
        Me.rdPurchase.TabStop = True
        Me.rdPurchase.Text = "Purchase"
        Me.rdPurchase.UseVisualStyleBackColor = True
        '
        'rdSale
        '
        Me.rdSale.AutoSize = True
        Me.rdSale.Location = New System.Drawing.Point(968, 45)
        Me.rdSale.Name = "rdSale"
        Me.rdSale.Size = New System.Drawing.Size(46, 17)
        Me.rdSale.TabIndex = 201
        Me.rdSale.TabStop = True
        Me.rdSale.Text = "Sale"
        Me.rdSale.UseVisualStyleBackColor = True
        '
        'frmTCSReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1167, 742)
        Me.Controls.Add(Me.rdSale)
        Me.Controls.Add(Me.rdPurchase)
        Me.Controls.Add(Me.cmbTcsHeadCode)
        Me.Controls.Add(Me.cmbPartyGroup)
        Me.Controls.Add(Me.cmbPartCode)
        Me.Controls.Add(Me.cmbPartyHead)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ChkAllParty)
        Me.Controls.Add(Me.cmbTdsper)
        Me.Controls.Add(Me.cmbtdsType)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmTCSReport"
        Me.Text = "TCS Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbTdsper As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtdsType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkAllParty As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPartyGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbTcsHeadCode As System.Windows.Forms.ComboBox
    Friend WithEvents rdPurchase As System.Windows.Forms.RadioButton
    Friend WithEvents rdSale As System.Windows.Forms.RadioButton
End Class
