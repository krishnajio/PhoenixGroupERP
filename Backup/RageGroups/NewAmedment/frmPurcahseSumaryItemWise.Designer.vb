<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurcahseSumaryItemWise
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbacheadname)
        Me.GroupBox1.Controls.Add(Me.dtto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnshow)
        Me.GroupBox1.Controls.Add(Me.dtfrom)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Items.AddRange(New Object() {"W-S", "O-S", "ALL", ""})
        Me.cmbacheadname.Location = New System.Drawing.Point(435, 16)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(184, 21)
        Me.cmbacheadname.TabIndex = 90
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(252, 15)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(104, 22)
        Me.dtto.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "To"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(362, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = " (W-S/O-S)  :"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(623, 16)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(53, 26)
        Me.btnshow.TabIndex = 93
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(113, 15)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 22)
        Me.dtfrom.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Bill Date From :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 95)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1028, 647)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frmPurcahseSumaryItemWise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 742)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPurcahseSumaryItemWise"
        Me.Text = "frmPurcahseSumaryItemWise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
