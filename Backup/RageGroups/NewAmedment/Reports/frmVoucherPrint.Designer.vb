<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherPrint
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.cmbvoutype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtchequedate = New System.Windows.Forms.DateTimePicker
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.chqsetup = New System.Windows.Forms.PageSetupDialog
        Me.chqdocument = New System.Drawing.Printing.PrintDocument
        Me.chqprintpreview = New System.Windows.Forms.PrintDialog
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1006, 43)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Voucher and Cheque print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.cmbvoutype)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.dtchequedate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 59)
        Me.Panel1.TabIndex = 125
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(542, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 23)
        Me.Button2.TabIndex = 185
        Me.Button2.Text = "Cheque Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(461, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 184
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bank"})
        Me.ComboBox1.Location = New System.Drawing.Point(324, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 24)
        Me.ComboBox1.TabIndex = 183
        '
        'cmbvoutype
        '
        Me.cmbvoutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvoutype.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvoutype.FormattingEnabled = True
        Me.cmbvoutype.Location = New System.Drawing.Point(111, 12)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(130, 24)
        Me.cmbvoutype.TabIndex = 180
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Voucher Type:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(247, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 182
        Me.Label14.Text = "Voucher No"
        '
        'dtchequedate
        '
        Me.dtchequedate.CustomFormat = "dd-MMM-yyyy"
        Me.dtchequedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtchequedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtchequedate.Location = New System.Drawing.Point(551, 15)
        Me.dtchequedate.Name = "dtchequedate"
        Me.dtchequedate.Size = New System.Drawing.Size(104, 22)
        Me.dtchequedate.TabIndex = 189
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 102)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(527, 557)
        Me.CrystalReportViewer1.TabIndex = 194
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'chqsetup
        '
        Me.chqsetup.Document = Me.chqdocument
        '
        'chqdocument
        '
        '
        'chqprintpreview
        '
        Me.chqprintpreview.Document = Me.chqdocument
        Me.chqprintpreview.UseEXDialog = True
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.DisplayGroupTree = False
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(533, 102)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.SelectionFormula = ""
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(470, 557)
        Me.CrystalReportViewer2.TabIndex = 195
        Me.CrystalReportViewer2.ViewTimeSelectionFormula = ""
        '
        'frmVoucherPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 725)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVoucherPrint"
        Me.Text = "frmVoucherPrint"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbvoutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chqsetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents chqdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents chqprintpreview As System.Windows.Forms.PrintDialog
    Friend WithEvents dtchequedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
