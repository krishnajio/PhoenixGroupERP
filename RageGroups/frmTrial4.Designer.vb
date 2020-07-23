<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrial4
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbgrpname = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rdgeneral = New System.Windows.Forms.RadioButton
        Me.rdcustomer = New System.Windows.Forms.RadioButton
        Me.rdPary = New System.Windows.Forms.RadioButton
        Me.chkallgengrps = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.BOTH = New System.Windows.Forms.CheckBox
        Me.Cr = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnshow = New System.Windows.Forms.Button
        Me.rdName = New System.Windows.Forms.RadioButton
        Me.rdCode = New System.Windows.Forms.RadioButton
        Me.Dr = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdwithopening = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.edwoopening = New System.Windows.Forms.RadioButton
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkArea = New System.Windows.Forms.CheckBox
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumPurple
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaShell
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(974, 30)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Trial Balance B/w Days"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbgrpname)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rdgeneral)
        Me.GroupBox1.Controls.Add(Me.rdcustomer)
        Me.GroupBox1.Controls.Add(Me.rdPary)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(974, 41)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(572, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Group:"
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(370, 11)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(197, 21)
        Me.cmbgrpname.TabIndex = 118
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(60, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton1.TabIndex = 117
        Me.RadioButton1.Text = "Internal Party"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rdgeneral
        '
        Me.rdgeneral.AutoSize = True
        Me.rdgeneral.Checked = True
        Me.rdgeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdgeneral.Location = New System.Drawing.Point(244, 11)
        Me.rdgeneral.Name = "rdgeneral"
        Me.rdgeneral.Size = New System.Drawing.Size(69, 17)
        Me.rdgeneral.TabIndex = 116
        Me.rdgeneral.TabStop = True
        Me.rdgeneral.Text = "General"
        Me.rdgeneral.UseVisualStyleBackColor = True
        '
        'rdcustomer
        '
        Me.rdcustomer.AutoSize = True
        Me.rdcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdcustomer.Location = New System.Drawing.Point(164, 11)
        Me.rdcustomer.Name = "rdcustomer"
        Me.rdcustomer.Size = New System.Drawing.Size(77, 17)
        Me.rdcustomer.TabIndex = 115
        Me.rdcustomer.Text = "Customer"
        Me.rdcustomer.UseVisualStyleBackColor = True
        '
        'rdPary
        '
        Me.rdPary.AutoSize = True
        Me.rdPary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdPary.Location = New System.Drawing.Point(8, 10)
        Me.rdPary.Name = "rdPary"
        Me.rdPary.Size = New System.Drawing.Size(54, 17)
        Me.rdPary.TabIndex = 114
        Me.rdPary.Text = "Party"
        Me.rdPary.UseVisualStyleBackColor = True
        '
        'chkallgengrps
        '
        Me.chkallgengrps.AutoSize = True
        Me.chkallgengrps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.chkallgengrps.ForeColor = System.Drawing.Color.Red
        Me.chkallgengrps.Location = New System.Drawing.Point(573, 17)
        Me.chkallgengrps.Name = "chkallgengrps"
        Me.chkallgengrps.Size = New System.Drawing.Size(238, 19)
        Me.chkallgengrps.TabIndex = 116
        Me.chkallgengrps.Text = "All  Groups(With OUT Sub Group)"
        Me.chkallgengrps.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.btnprint)
        Me.GroupBox3.Controls.Add(Me.chkallgengrps)
        Me.GroupBox3.Controls.Add(Me.BOTH)
        Me.GroupBox3.Controls.Add(Me.Cr)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btnshow)
        Me.GroupBox3.Controls.Add(Me.rdName)
        Me.GroupBox3.Controls.Add(Me.rdCode)
        Me.GroupBox3.Controls.Add(Me.Dr)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(974, 47)
        Me.GroupBox3.TabIndex = 100
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(817, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 19)
        Me.CheckBox1.TabIndex = 131
        Me.CheckBox1.Text = "Sub  Groups"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Enabled = False
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(441, 13)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(54, 26)
        Me.btnprint.TabIndex = 129
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'BOTH
        '
        Me.BOTH.AutoSize = True
        Me.BOTH.Checked = True
        Me.BOTH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BOTH.Location = New System.Drawing.Point(78, 20)
        Me.BOTH.Name = "BOTH"
        Me.BOTH.Size = New System.Drawing.Size(56, 17)
        Me.BOTH.TabIndex = 127
        Me.BOTH.Text = "BOTH"
        Me.BOTH.UseVisualStyleBackColor = True
        '
        'Cr
        '
        Me.Cr.AutoSize = True
        Me.Cr.Location = New System.Drawing.Point(41, 20)
        Me.Cr.Name = "Cr"
        Me.Cr.Size = New System.Drawing.Size(36, 17)
        Me.Cr.TabIndex = 126
        Me.Cr.Text = "Cr"
        Me.Cr.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(499, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 28)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(371, 12)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(68, 28)
        Me.btnshow.TabIndex = 126
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'rdName
        '
        Me.rdName.AutoSize = True
        Me.rdName.Checked = True
        Me.rdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdName.Location = New System.Drawing.Point(250, 19)
        Me.rdName.Name = "rdName"
        Me.rdName.Size = New System.Drawing.Size(110, 17)
        Me.rdName.TabIndex = 129
        Me.rdName.TabStop = True
        Me.rdName.Text = "Order By Name"
        Me.rdName.UseVisualStyleBackColor = True
        '
        'rdCode
        '
        Me.rdCode.AutoSize = True
        Me.rdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdCode.Location = New System.Drawing.Point(140, 19)
        Me.rdCode.Name = "rdCode"
        Me.rdCode.Size = New System.Drawing.Size(107, 17)
        Me.rdCode.TabIndex = 128
        Me.rdCode.Text = "Order By Code"
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'Dr
        '
        Me.Dr.AutoSize = True
        Me.Dr.Location = New System.Drawing.Point(5, 20)
        Me.Dr.Name = "Dr"
        Me.Dr.Size = New System.Drawing.Size(37, 17)
        Me.Dr.TabIndex = 125
        Me.Dr.Text = "Dr"
        Me.Dr.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdwithopening)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.edwoopening)
        Me.GroupBox2.Controls.Add(Me.dtTo)
        Me.GroupBox2.Controls.Add(Me.dtfrom)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.chkArea)
        Me.GroupBox2.Controls.Add(Me.cmbAreaName)
        Me.GroupBox2.Controls.Add(Me.cmbAreaCode)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(974, 51)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'rdwithopening
        '
        Me.rdwithopening.AutoSize = True
        Me.rdwithopening.Checked = True
        Me.rdwithopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdwithopening.Location = New System.Drawing.Point(503, 20)
        Me.rdwithopening.Name = "rdwithopening"
        Me.rdwithopening.Size = New System.Drawing.Size(102, 17)
        Me.rdwithopening.TabIndex = 132
        Me.rdwithopening.TabStop = True
        Me.rdwithopening.Text = "With Opening"
        Me.rdwithopening.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 15)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "To"
        '
        'edwoopening
        '
        Me.edwoopening.AutoSize = True
        Me.edwoopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.edwoopening.Location = New System.Drawing.Point(667, 20)
        Me.edwoopening.Name = "edwoopening"
        Me.edwoopening.Size = New System.Drawing.Size(120, 17)
        Me.edwoopening.TabIndex = 133
        Me.edwoopening.Text = "Without Opening"
        Me.edwoopening.UseVisualStyleBackColor = True
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(196, 18)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(83, 20)
        Me.dtTo.TabIndex = 129
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(57, 17)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 20)
        Me.dtfrom.TabIndex = 114
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Date :"
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArea.Location = New System.Drawing.Point(300, 19)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(55, 19)
        Me.chkArea.TabIndex = 113
        Me.chkArea.Text = "Area"
        Me.chkArea.UseVisualStyleBackColor = True
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(356, 18)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(125, 21)
        Me.cmbAreaName.TabIndex = 111
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(414, 18)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(67, 21)
        Me.cmbAreaCode.TabIndex = 112
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.DisplayGroupTree = False
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Top
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 169)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.ShowPrintButton = False
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(974, 603)
        Me.CrViewerGenralLedger.TabIndex = 110
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'frmTrial4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(974, 688)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmTrial4"
        Me.Text = "Trial B/w days and Subgroup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdgeneral As System.Windows.Forms.RadioButton
    Friend WithEvents rdcustomer As System.Windows.Forms.RadioButton
    Friend WithEvents rdPary As System.Windows.Forms.RadioButton
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BOTH As System.Windows.Forms.CheckBox
    Friend WithEvents Cr As System.Windows.Forms.CheckBox
    Friend WithEvents rdName As System.Windows.Forms.RadioButton
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents Dr As System.Windows.Forms.CheckBox
    Friend WithEvents chkallgengrps As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents rdwithopening As System.Windows.Forms.RadioButton
    Friend WithEvents edwoopening As System.Windows.Forms.RadioButton
End Class
