<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpensesVehiclereport
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
        Me.cmbarea = New System.Windows.Forms.ComboBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.cmbVehNo = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.btnshow = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbVou_type = New System.Windows.Forms.ComboBox
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
        Me.Label1.Size = New System.Drawing.Size(1028, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Expenses Report Delivery Van"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbVou_type)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbarea)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.cmbVehNo)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.dtpto)
        Me.Panel1.Controls.Add(Me.dtpfrom)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 68)
        Me.Panel1.TabIndex = 171
        '
        'cmbarea
        '
        Me.cmbarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbarea.FormattingEnabled = True
        Me.cmbarea.Location = New System.Drawing.Point(664, 13)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Size = New System.Drawing.Size(143, 21)
        Me.cmbarea.TabIndex = 220
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(609, 15)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(59, 19)
        Me.CheckBox2.TabIndex = 219
        Me.CheckBox2.Text = "Area:"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cmbVehNo
        '
        Me.cmbVehNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVehNo.FormattingEnabled = True
        Me.cmbVehNo.Location = New System.Drawing.Point(413, 13)
        Me.cmbVehNo.Name = "cmbVehNo"
        Me.cmbVehNo.Size = New System.Drawing.Size(193, 21)
        Me.cmbVehNo.TabIndex = 218
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(316, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 19)
        Me.CheckBox1.TabIndex = 217
        Me.CheckBox1.Text = "Vehicle No."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dtpto
        '
        Me.dtpto.CustomFormat = "dd/MM/yyyy"
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpto.Location = New System.Drawing.Point(228, 14)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(84, 20)
        Me.dtpto.TabIndex = 216
        '
        'dtpfrom
        '
        Me.dtpfrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(119, 13)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(86, 20)
        Me.dtpfrom.TabIndex = 215
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(813, 13)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 175
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-1, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 15)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Hatch DateFrom :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 113)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1028, 584)
        Me.CrystalReportViewer1.TabIndex = 172
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(614, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "Group"
        '
        'cmbVou_type
        '
        Me.cmbVou_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVou_type.FormattingEnabled = True
        Me.cmbVou_type.Location = New System.Drawing.Point(664, 40)
        Me.cmbVou_type.Name = "cmbVou_type"
        Me.cmbVou_type.Size = New System.Drawing.Size(143, 21)
        Me.cmbVou_type.TabIndex = 222
        '
        'frmExpensesVehiclereport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1028, 697)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "frmExpensesVehiclereport"
        Me.Text = "frmExpensesVehiclereport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Public WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Public WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbVehNo As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbarea As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbVou_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
