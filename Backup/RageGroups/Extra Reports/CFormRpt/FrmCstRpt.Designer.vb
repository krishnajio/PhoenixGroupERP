<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCstRpt
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbstate = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dgdl = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.dgdl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(917, 33)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "C Form  Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbstate)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.dtTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmbacheadname)
        Me.Panel1.Controls.Add(Me.cmbacheadcode)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.dtfrom)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 79)
        Me.Panel1.TabIndex = 113
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(751, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 26)
        Me.Button2.TabIndex = 128
        Me.Button2.Text = "&List More Than One "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "State"
        Me.Label3.Visible = False
        '
        'cmbstate
        '
        Me.cmbstate.AutoCompleteCustomSource.AddRange(New String() {"M.P", "Out of MP"})
        Me.cmbstate.FormattingEnabled = True
        Me.cmbstate.Items.AddRange(New Object() {"M.P", "C.G", "BIHAR", "M.H", "W.B"})
        Me.cmbstate.Location = New System.Drawing.Point(116, 40)
        Me.cmbstate.Name = "cmbstate"
        Me.cmbstate.Size = New System.Drawing.Size(176, 21)
        Me.cmbstate.TabIndex = 126
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(116, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 19)
        Me.CheckBox1.TabIndex = 125
        Me.CheckBox1.Text = "ALL"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(504, 38)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(104, 22)
        Me.dtTo.TabIndex = 124
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(479, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "To"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(679, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 26)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(365, 8)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(247, 21)
        Me.cmbacheadname.TabIndex = 115
        Me.cmbacheadname.Visible = False
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(614, 8)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(131, 21)
        Me.cmbacheadcode.TabIndex = 116
        Me.cmbacheadcode.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(326, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 15)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Unit"
        Me.Label11.Visible = False
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(614, 35)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(59, 26)
        Me.btnshow.TabIndex = 118
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(367, 39)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 22)
        Me.dtfrom.TabIndex = 117
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(311, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "From  :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 112)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(917, 630)
        Me.CrystalReportViewer1.TabIndex = 114
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'dgdl
        '
        Me.dgdl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdl.Location = New System.Drawing.Point(596, 112)
        Me.dgdl.Name = "dgdl"
        Me.dgdl.Size = New System.Drawing.Size(321, 297)
        Me.dgdl.TabIndex = 115
        Me.dgdl.Visible = False
        '
        'FrmCstRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 742)
        Me.Controls.Add(Me.dgdl)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCstRpt"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgdl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbstate As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgdl As System.Windows.Forms.DataGridView
End Class
