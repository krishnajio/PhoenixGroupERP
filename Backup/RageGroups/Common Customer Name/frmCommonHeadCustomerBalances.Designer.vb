<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommonHeadCustomerBalances
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button1.Location = New System.Drawing.Point(285, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 165
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 162)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(974, 432)
        Me.CrViewerGenralLedger.TabIndex = 164
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(88, 32)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(81, 20)
        Me.dtfrom.TabIndex = 162
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 163
        Me.Label8.Text = "Date From :"
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
        Me.Label1.Size = New System.Drawing.Size(974, 30)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Sale , Purchase, Expenses"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmCommonHeadCustomerBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 594)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCommonHeadCustomerBalances"
        Me.Text = "frmCommonHeadCustomerBalances"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
