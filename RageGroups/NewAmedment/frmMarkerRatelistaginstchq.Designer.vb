<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarkerRatelistaginstchq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarkerRatelistaginstchq))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.txtchqno = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(784, 43)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Po Rate VS Market Rate"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(666, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 53)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "&Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(542, 46)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(118, 53)
        Me.btnsave.TabIndex = 126
        Me.btnsave.Text = "&Show"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtchqno
        '
        Me.txtchqno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtchqno.Location = New System.Drawing.Point(134, 55)
        Me.txtchqno.Name = "txtchqno"
        Me.txtchqno.Size = New System.Drawing.Size(402, 20)
        Me.txtchqno.TabIndex = 226
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 15)
        Me.Label18.TabIndex = 227
        Me.Label18.Text = "Enter Cheque No"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 120)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(772, 354)
        Me.CrystalReportViewer1.TabIndex = 228
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frmMarkerRatelistaginstchq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 486)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.txtchqno)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMarkerRatelistaginstchq"
        Me.Text = "frmMarkerRatelistaginstchq"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtchqno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
