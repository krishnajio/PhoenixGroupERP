<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleRepPHHAPHOE
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
        Me.lbl = New System.Windows.Forms.Label
        Me.dtHatchDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.Color.Teal
        Me.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.SandyBrown
        Me.lbl.Location = New System.Drawing.Point(0, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(1028, 26)
        Me.lbl.TabIndex = 47
        Me.lbl.Text = "Sale Report"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtHatchDate
        '
        Me.dtHatchDate.CustomFormat = "dd/MMM/yy"
        Me.dtHatchDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtHatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHatchDate.Location = New System.Drawing.Point(102, 29)
        Me.dtHatchDate.Name = "dtHatchDate"
        Me.dtHatchDate.Size = New System.Drawing.Size(87, 21)
        Me.dtHatchDate.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Hatch  Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(224, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 21)
        Me.DateTimePicker1.TabIndex = 102
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1028, 690)
        Me.CrystalReportViewer1.TabIndex = 104
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frmSaleRepPHHAPHOE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtHatchDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl)
        Me.Name = "frmSaleRepPHHAPHOE"
        Me.Text = "frmSaleRepPHHAPHOE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents dtHatchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
