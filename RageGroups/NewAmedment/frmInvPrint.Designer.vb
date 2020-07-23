<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.voutype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.txtCrNoTo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCrNoFrom = New System.Windows.Forms.TextBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtphachdateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtHatchdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAreacode = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaShell
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1247, 31)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Sale Invoice Print"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Location = New System.Drawing.Point(488, 36)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(243, 21)
        Me.voutype.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Voucher Type:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1129, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 22)
        Me.Button1.TabIndex = 173
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(1065, 37)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 22)
        Me.btnshow.TabIndex = 170
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'txtCrNoTo
        '
        Me.txtCrNoTo.Location = New System.Drawing.Point(306, 36)
        Me.txtCrNoTo.Name = "txtCrNoTo"
        Me.txtCrNoTo.Size = New System.Drawing.Size(80, 20)
        Me.txtCrNoTo.TabIndex = 169
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 15)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Sale Voucher Number From :"
        '
        'txtCrNoFrom
        '
        Me.txtCrNoFrom.Location = New System.Drawing.Point(198, 36)
        Me.txtCrNoFrom.Name = "txtCrNoFrom"
        Me.txtCrNoFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtCrNoFrom.TabIndex = 168
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(9, 139)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1111, 498)
        Me.CrystalReportViewer1.TabIndex = 176
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"HAJIPUR UNIT", "PARIYAT UNIT", "RAIPUR UNIT", "VARANASI UNIT", "WB-1", "WB-2"})
        Me.ComboBox1.Location = New System.Drawing.Point(737, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox1.TabIndex = 177
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.dtphachdateTo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtHatchdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCustCode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(198, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(619, 45)
        Me.GroupBox1.TabIndex = 178
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(541, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 23)
        Me.Button2.TabIndex = 178
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtphachdateTo
        '
        Me.dtphachdateTo.CustomFormat = "dd/MMM/yy"
        Me.dtphachdateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtphachdateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtphachdateTo.Location = New System.Drawing.Point(455, 12)
        Me.dtphachdateTo.Name = "dtphachdateTo"
        Me.dtphachdateTo.Size = New System.Drawing.Size(80, 21)
        Me.dtphachdateTo.TabIndex = 177
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "To"
        '
        'dtHatchdate
        '
        Me.dtHatchdate.CustomFormat = "dd/MMM/yy"
        Me.dtHatchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtHatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHatchdate.Location = New System.Drawing.Point(340, 13)
        Me.dtHatchdate.Name = "dtHatchdate"
        Me.dtHatchdate.Size = New System.Drawing.Size(80, 21)
        Me.dtHatchdate.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Hatch Date From:"
        '
        'txtCustCode
        '
        Me.txtCustCode.Location = New System.Drawing.Point(125, 13)
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(75, 20)
        Me.txtCustCode.TabIndex = 173
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Customer Code :"
        '
        'txtAreacode
        '
        Me.txtAreacode.Location = New System.Drawing.Point(979, 37)
        Me.txtAreacode.Name = "txtAreacode"
        Me.txtAreacode.Size = New System.Drawing.Size(80, 20)
        Me.txtAreacode.TabIndex = 179
        '
        'frmInvPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 649)
        Me.Controls.Add(Me.txtAreacode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.voutype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.txtCrNoTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCrNoFrom)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmInvPrint"
        Me.Text = "frmInvPrint"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents txtCrNoTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCrNoFrom As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtphachdateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtHatchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtAreacode As System.Windows.Forms.TextBox
End Class
