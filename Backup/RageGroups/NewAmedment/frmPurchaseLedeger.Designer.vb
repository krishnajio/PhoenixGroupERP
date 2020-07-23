<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseLedeger
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
        Me.voutype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.d2 = New System.Windows.Forms.DateTimePicker
        Me.d1 = New System.Windows.Forms.DateTimePicker
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.cmbProduct = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Location = New System.Drawing.Point(743, 34)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(121, 21)
        Me.voutype.TabIndex = 182
        Me.voutype.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(645, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Voucher Type:"
        Me.Label3.Visible = False
        '
        'd2
        '
        Me.d2.CustomFormat = "dd/MMM/yy"
        Me.d2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d2.Location = New System.Drawing.Point(500, 62)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(81, 20)
        Me.d2.TabIndex = 179
        '
        'd1
        '
        Me.d1.CustomFormat = "dd/MMM/yy"
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d1.Location = New System.Drawing.Point(390, 62)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(83, 20)
        Me.d1.TabIndex = 178
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 188)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1147, 535)
        Me.CrystalReportViewer1.TabIndex = 177
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'cmbProduct
        '
        Me.cmbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(190, 35)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(451, 21)
        Me.cmbProduct.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Select Product:"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(587, 58)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 172
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(471, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(282, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Voucher Date :"
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
        Me.Label6.Size = New System.Drawing.Size(1147, 31)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "PURCHASE LEDGER"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(870, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox1.TabIndex = 183
        Me.ComboBox1.Visible = False
        '
        'frmPurchaseLedeger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 723)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.voutype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmPurchaseLedeger"
        Me.Text = "frmPurchaseLedeger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents d2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents d1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
