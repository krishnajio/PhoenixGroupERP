<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherAndChqPrint
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
        Me.btnshow = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbFormat = New System.Windows.Forms.ComboBox
        Me.cmbvoutype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbvou_no = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbvou_no)
        Me.Panel1.Controls.Add(Me.cmbvoutype)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbFormat)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 51)
        Me.Panel1.TabIndex = 177
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(604, 12)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 175
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 99)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(888, 647)
        Me.CrystalReportViewer1.TabIndex = 178
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(888, 42)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Voucher and Chq Print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(668, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 28)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "&Chq Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(376, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Layout Name:"
        '
        'cmbFormat
        '
        Me.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Items.AddRange(New Object() {"MULTI CITY", "LOCAL"})
        Me.cmbFormat.Location = New System.Drawing.Point(477, 15)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormat.TabIndex = 177
        '
        'cmbvoutype
        '
        Me.cmbvoutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvoutype.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvoutype.FormattingEnabled = True
        Me.cmbvoutype.Items.AddRange(New Object() {"Temp Bank"})
        Me.cmbvoutype.Location = New System.Drawing.Point(109, 12)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(130, 24)
        Me.cmbvoutype.TabIndex = 179
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Voucher Type:"
        '
        'cmbvou_no
        '
        Me.cmbvou_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvou_no.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvou_no.FormattingEnabled = True
        Me.cmbvou_no.Items.AddRange(New Object() {"Temp Bank"})
        Me.cmbvou_no.Location = New System.Drawing.Point(245, 12)
        Me.cmbvou_no.Name = "cmbvou_no"
        Me.cmbvou_no.Size = New System.Drawing.Size(130, 24)
        Me.cmbvou_no.TabIndex = 181
        '
        'frmVoucherAndChqPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(888, 746)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVoucherAndChqPrint"
        Me.Text = "frmVoucherAndChqPrint"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvou_no As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvoutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
