<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartyDueBill
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkSelectParty = New System.Windows.Forms.CheckBox()
        Me.cmpbarty = New System.Windows.Forms.ComboBox()
        Me.cmbPartyCode = New System.Windows.Forms.ComboBox()
        Me.l = New System.Windows.Forms.Label()
        Me.cmbVoucherType = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label1.Size = New System.Drawing.Size(1155, 37)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "PAYMENT PENDING LIST "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MMM/yy"
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(125, 40)
        Me.dtpdate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(87, 21)
        Me.dtpdate.TabIndex = 214
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 15)
        Me.Label8.TabIndex = 215
        Me.Label8.Text = "Payment Month :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 129)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1147, 609)
        Me.CrystalReportViewer1.TabIndex = 216
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(554, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 23)
        Me.Button1.TabIndex = 217
        Me.Button1.Text = "show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkSelectParty
        '
        Me.chkSelectParty.AutoSize = True
        Me.chkSelectParty.Location = New System.Drawing.Point(228, 43)
        Me.chkSelectParty.Name = "chkSelectParty"
        Me.chkSelectParty.Size = New System.Drawing.Size(83, 17)
        Me.chkSelectParty.TabIndex = 218
        Me.chkSelectParty.Text = "Select Party"
        Me.chkSelectParty.UseVisualStyleBackColor = True
        '
        'cmpbarty
        '
        Me.cmpbarty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmpbarty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmpbarty.FormattingEnabled = True
        Me.cmpbarty.Location = New System.Drawing.Point(317, 39)
        Me.cmpbarty.Name = "cmpbarty"
        Me.cmpbarty.Size = New System.Drawing.Size(403, 21)
        Me.cmpbarty.TabIndex = 219
        '
        'cmbPartyCode
        '
        Me.cmbPartyCode.FormattingEnabled = True
        Me.cmbPartyCode.Location = New System.Drawing.Point(554, 39)
        Me.cmbPartyCode.Name = "cmbPartyCode"
        Me.cmbPartyCode.Size = New System.Drawing.Size(121, 21)
        Me.cmbPartyCode.TabIndex = 220
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(735, 44)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(107, 13)
        Me.l.TabIndex = 221
        Me.l.Text = "Select Voucher Type"
        '
        'cmbVoucherType
        '
        Me.cmbVoucherType.FormattingEnabled = True
        Me.cmbVoucherType.Location = New System.Drawing.Point(849, 39)
        Me.cmbVoucherType.Name = "cmbVoucherType"
        Me.cmbVoucherType.Size = New System.Drawing.Size(225, 21)
        Me.cmbVoucherType.TabIndex = 222
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0-15", "16-45", ">45"})
        Me.ComboBox1.Location = New System.Drawing.Point(317, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.TabIndex = 227
        Me.ComboBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(225, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 228
        Me.Label4.Text = "Select Days:"
        Me.Label4.Visible = False
        '
        'frmPartyDueBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 733)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbVoucherType)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.cmpbarty)
        Me.Controls.Add(Me.chkSelectParty)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPartyCode)
        Me.Name = "frmPartyDueBill"
        Me.Text = "frmPartyDueBill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkSelectParty As System.Windows.Forms.CheckBox
    Friend WithEvents cmpbarty As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPartyCode As System.Windows.Forms.ComboBox
    Friend WithEvents l As System.Windows.Forms.Label
    Friend WithEvents cmbVoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
