<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPurchaseRegister
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
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtdate = New System.Windows.Forms.DateTimePicker()
        Me.voutype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbprdunit = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtv2 = New System.Windows.Forms.TextBox()
        Me.txtv1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkcform = New System.Windows.Forms.CheckBox()
        Me.txti2 = New System.Windows.Forms.TextBox()
        Me.txti1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtp2 = New System.Windows.Forms.TextBox()
        Me.txtp1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Purchase Register"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_modify
        '
        Me.btn_modify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify.Location = New System.Drawing.Point(-43, 563)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(72, 28)
        Me.btn_modify.TabIndex = 27
        Me.btn_modify.Text = "&Modify"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(851, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkAll)
        Me.Panel1.Controls.Add(Me.dtdate)
        Me.Panel1.Controls.Add(Me.voutype)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbprdunit)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtv2)
        Me.Panel1.Controls.Add(Me.txtv1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.chkcform)
        Me.Panel1.Controls.Add(Me.txti2)
        Me.Panel1.Controls.Add(Me.txti1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtp2)
        Me.Panel1.Controls.Add(Me.txtp1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 78)
        Me.Panel1.TabIndex = 35
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(81, 36)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(107, 21)
        Me.dtdate.TabIndex = 208
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Location = New System.Drawing.Point(708, 36)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(137, 21)
        Me.voutype.TabIndex = 206
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(606, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 207
        Me.Label6.Text = "Voucher Type:"
        '
        'cmbprdunit
        '
        Me.cmbprdunit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbprdunit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbprdunit.BackColor = System.Drawing.Color.White
        Me.cmbprdunit.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprdunit.FormattingEnabled = True
        Me.cmbprdunit.Location = New System.Drawing.Point(708, 5)
        Me.cmbprdunit.Name = "cmbprdunit"
        Me.cmbprdunit.Size = New System.Drawing.Size(137, 25)
        Me.cmbprdunit.TabIndex = 204
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(639, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 15)
        Me.Label23.TabIndex = 205
        Me.Label23.Text = "Prd. Unit:"
        '
        'txtv2
        '
        Me.txtv2.Location = New System.Drawing.Point(155, 1)
        Me.txtv2.Name = "txtv2"
        Me.txtv2.Size = New System.Drawing.Size(68, 20)
        Me.txtv2.TabIndex = 165
        '
        'txtv1
        '
        Me.txtv1.Location = New System.Drawing.Point(81, 1)
        Me.txtv1.Name = "txtv1"
        Me.txtv1.Size = New System.Drawing.Size(68, 20)
        Me.txtv1.TabIndex = 164
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Voucher No."
        '
        'chkcform
        '
        Me.chkcform.AutoSize = True
        Me.chkcform.Location = New System.Drawing.Point(14, 40)
        Me.chkcform.Name = "chkcform"
        Me.chkcform.Size = New System.Drawing.Size(75, 17)
        Me.chkcform.TabIndex = 162
        Me.chkcform.Text = "Bill Month:"
        Me.chkcform.UseVisualStyleBackColor = True
        '
        'txti2
        '
        Me.txti2.Location = New System.Drawing.Point(568, 4)
        Me.txti2.Name = "txti2"
        Me.txti2.Size = New System.Drawing.Size(68, 20)
        Me.txti2.TabIndex = 161
        '
        'txti1
        '
        Me.txti1.Location = New System.Drawing.Point(494, 4)
        Me.txti1.Name = "txti1"
        Me.txti1.Size = New System.Drawing.Size(68, 20)
        Me.txti1.TabIndex = 160
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Inw.  No."
        '
        'txtp2
        '
        Me.txtp2.Location = New System.Drawing.Point(357, 3)
        Me.txtp2.Name = "txtp2"
        Me.txtp2.Size = New System.Drawing.Size(68, 20)
        Me.txtp2.TabIndex = 158
        '
        'txtp1
        '
        Me.txtp1.Location = New System.Drawing.Point(283, 3)
        Me.txtp1.Name = "txtp1"
        Me.txtp1.Size = New System.Drawing.Size(68, 20)
        Me.txtp1.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "P.O No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Bill Date "
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 114)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1028, 480)
        Me.CrystalReportViewer1.TabIndex = 36
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(851, 38)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(115, 17)
        Me.chkAll.TabIndex = 209
        Me.chkAll.Text = "ALL Voucher Type"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'frmNewPurchaseRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1028, 594)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNewPurchaseRegister"
        Me.Text = "frmNewPurchaseRegister"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents chkcform As System.Windows.Forms.CheckBox
    Friend WithEvents txti2 As System.Windows.Forms.TextBox
    Friend WithEvents txti1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtv2 As System.Windows.Forms.TextBox
    Friend WithEvents txtv1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cmbprdunit As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
End Class
