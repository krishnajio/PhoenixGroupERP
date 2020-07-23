<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMisCashReceived
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdCashrec = New System.Windows.Forms.RadioButton
        Me.rdcashpayment = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button1.Location = New System.Drawing.Point(500, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.DisplayGroupTree = False
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 62)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(927, 686)
        Me.CrViewerGenralLedger.TabIndex = 152
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "TO"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(198, 35)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(81, 20)
        Me.dtTo.TabIndex = 150
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(88, 35)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(81, 20)
        Me.dtfrom.TabIndex = 148
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 149
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
        Me.Label1.Size = New System.Drawing.Size(927, 30)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Cash Received/Payment "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rdCashrec
        '
        Me.rdCashrec.AutoSize = True
        Me.rdCashrec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCashrec.Location = New System.Drawing.Point(286, 35)
        Me.rdCashrec.Name = "rdCashrec"
        Me.rdCashrec.Size = New System.Drawing.Size(90, 19)
        Me.rdCashrec.TabIndex = 154
        Me.rdCashrec.TabStop = True
        Me.rdCashrec.Text = "Cash Rec."
        Me.rdCashrec.UseVisualStyleBackColor = True
        '
        'rdcashpayment
        '
        Me.rdcashpayment.AutoSize = True
        Me.rdcashpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdcashpayment.Location = New System.Drawing.Point(378, 35)
        Me.rdcashpayment.Name = "rdcashpayment"
        Me.rdcashpayment.Size = New System.Drawing.Size(116, 19)
        Me.rdcashpayment.TabIndex = 155
        Me.rdcashpayment.TabStop = True
        Me.rdcashpayment.Text = "Cash Payment"
        Me.rdcashpayment.UseVisualStyleBackColor = True
        '
        'frmMisCashReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(927, 748)
        Me.Controls.Add(Me.rdcashpayment)
        Me.Controls.Add(Me.rdCashrec)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMisCashReceived"
        Me.Text = "frmMisCashReceived"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdCashrec As System.Windows.Forms.RadioButton
    Friend WithEvents rdcashpayment As System.Windows.Forms.RadioButton
End Class
