<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHatchAmountReport
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
        Me.btnshow = New System.Windows.Forms.Button
        Me.cv1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(421, 41)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(68, 23)
        Me.btnshow.TabIndex = 148
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'cv1
        '
        Me.cv1.ActiveViewIndex = -1
        Me.cv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cv1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cv1.Location = New System.Drawing.Point(0, 85)
        Me.cv1.Name = "cv1"
        Me.cv1.SelectionFormula = ""
        Me.cv1.Size = New System.Drawing.Size(957, 509)
        Me.cv1.TabIndex = 147
        Me.cv1.ViewTimeSelectionFormula = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Hatch Date :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(957, 30)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Hatch Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(104, 40)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 20)
        Me.dtfrom.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "With In"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(271, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Days"
        '
        'frmHatchAmountReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 594)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.cv1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtfrom)
        Me.Name = "frmHatchAmountReport"
        Me.Text = "frmHatchAmountReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents cv1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
