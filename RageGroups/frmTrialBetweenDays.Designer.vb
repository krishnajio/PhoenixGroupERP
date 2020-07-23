<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrialbetweendays
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
        Me.rdcustomer = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rdgeneral = New System.Windows.Forms.RadioButton
        Me.rdPary = New System.Windows.Forms.RadioButton
        Me.chkArea = New System.Windows.Forms.CheckBox
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox
        Me.cmbgrpname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.edwoopening = New System.Windows.Forms.RadioButton
        Me.rdwithopening = New System.Windows.Forms.RadioButton
        Me.chkallgengrps = New System.Windows.Forms.CheckBox
        Me.dgtrial = New System.Windows.Forms.DataGridView
        Me.accheadcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.accheadname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DrAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrAmt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdPrint = New System.Windows.Forms.RadioButton
        Me.rdOnscreen = New System.Windows.Forms.RadioButton
        Me.Dr = New System.Windows.Forms.CheckBox
        Me.Cr = New System.Windows.Forms.CheckBox
        Me.BOTH = New System.Windows.Forms.CheckBox
        Me.rdName = New System.Windows.Forms.RadioButton
        Me.rdCode = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnDos = New System.Windows.Forms.Button
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgtrial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdcustomer
        '
        Me.rdcustomer.AutoSize = True
        Me.rdcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdcustomer.Location = New System.Drawing.Point(174, 11)
        Me.rdcustomer.Name = "rdcustomer"
        Me.rdcustomer.Size = New System.Drawing.Size(77, 17)
        Me.rdcustomer.TabIndex = 1
        Me.rdcustomer.Text = "Customer"
        Me.rdcustomer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rdgeneral)
        Me.GroupBox1.Controls.Add(Me.rdcustomer)
        Me.GroupBox1.Controls.Add(Me.rdPary)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 37)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(64, 11)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton1.TabIndex = 113
        Me.RadioButton1.Text = "Intrenal Party"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rdgeneral
        '
        Me.rdgeneral.AutoSize = True
        Me.rdgeneral.Checked = True
        Me.rdgeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdgeneral.Location = New System.Drawing.Point(264, 11)
        Me.rdgeneral.Name = "rdgeneral"
        Me.rdgeneral.Size = New System.Drawing.Size(69, 17)
        Me.rdgeneral.TabIndex = 112
        Me.rdgeneral.TabStop = True
        Me.rdgeneral.Text = "General"
        Me.rdgeneral.UseVisualStyleBackColor = True
        '
        'rdPary
        '
        Me.rdPary.AutoSize = True
        Me.rdPary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdPary.Location = New System.Drawing.Point(5, 11)
        Me.rdPary.Name = "rdPary"
        Me.rdPary.Size = New System.Drawing.Size(54, 17)
        Me.rdPary.TabIndex = 0
        Me.rdPary.Text = "Party"
        Me.rdPary.UseVisualStyleBackColor = True
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArea.Location = New System.Drawing.Point(545, 35)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(55, 19)
        Me.chkArea.TabIndex = 110
        Me.chkArea.Text = "Area"
        Me.chkArea.UseVisualStyleBackColor = True
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 345)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.ShowPrintButton = False
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(916, 248)
        Me.CrViewerGenralLedger.TabIndex = 109
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(732, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 28)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbsubgrpname
        '
        Me.cmbsubgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsubgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubgrpname.BackColor = System.Drawing.Color.White
        Me.cmbsubgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubgrpname.FormattingEnabled = True
        Me.cmbsubgrpname.Items.AddRange(New Object() {"-"})
        Me.cmbsubgrpname.Location = New System.Drawing.Point(356, 97)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(197, 21)
        Me.cmbsubgrpname.TabIndex = 104
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(153, 97)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(197, 21)
        Me.cmbgrpname.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Group / Sub Group:"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(601, 34)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(125, 21)
        Me.cmbAreaName.TabIndex = 100
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(732, 34)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(67, 21)
        Me.cmbAreaCode.TabIndex = 101
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(503, 118)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(64, 28)
        Me.btnshow.TabIndex = 98
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(153, 121)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(81, 20)
        Me.dtfrom.TabIndex = 95
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
        Me.Label1.Size = New System.Drawing.Size(916, 30)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Trial Balance Between days"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Date From :"
        '
        'edwoopening
        '
        Me.edwoopening.AutoSize = True
        Me.edwoopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.edwoopening.Location = New System.Drawing.Point(551, 70)
        Me.edwoopening.Name = "edwoopening"
        Me.edwoopening.Size = New System.Drawing.Size(120, 17)
        Me.edwoopening.TabIndex = 113
        Me.edwoopening.Text = "Without Opening"
        Me.edwoopening.UseVisualStyleBackColor = True
        '
        'rdwithopening
        '
        Me.rdwithopening.AutoSize = True
        Me.rdwithopening.Checked = True
        Me.rdwithopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdwithopening.Location = New System.Drawing.Point(443, 70)
        Me.rdwithopening.Name = "rdwithopening"
        Me.rdwithopening.Size = New System.Drawing.Size(102, 17)
        Me.rdwithopening.TabIndex = 112
        Me.rdwithopening.TabStop = True
        Me.rdwithopening.Text = "With Opening"
        Me.rdwithopening.UseVisualStyleBackColor = True
        '
        'chkallgengrps
        '
        Me.chkallgengrps.AutoSize = True
        Me.chkallgengrps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.chkallgengrps.Location = New System.Drawing.Point(73, 34)
        Me.chkallgengrps.Name = "chkallgengrps"
        Me.chkallgengrps.Size = New System.Drawing.Size(96, 19)
        Me.chkallgengrps.TabIndex = 115
        Me.chkallgengrps.Text = "All  Groups"
        Me.chkallgengrps.UseVisualStyleBackColor = True
        '
        'dgtrial
        '
        Me.dgtrial.AllowUserToAddRows = False
        Me.dgtrial.AllowUserToDeleteRows = False
        Me.dgtrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtrial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.accheadcode, Me.accheadname, Me.DrAmt, Me.CrAmt})
        Me.dgtrial.Location = New System.Drawing.Point(0, 180)
        Me.dgtrial.Name = "dgtrial"
        Me.dgtrial.ReadOnly = True
        Me.dgtrial.Size = New System.Drawing.Size(804, 218)
        Me.dgtrial.TabIndex = 116
        '
        'accheadcode
        '
        Me.accheadcode.HeaderText = "Account Head Code"
        Me.accheadcode.Name = "accheadcode"
        Me.accheadcode.ReadOnly = True
        '
        'accheadname
        '
        Me.accheadname.HeaderText = "Account Head Name"
        Me.accheadname.Name = "accheadname"
        Me.accheadname.ReadOnly = True
        Me.accheadname.Width = 400
        '
        'DrAmt
        '
        Me.DrAmt.HeaderText = "Dr.Amt"
        Me.DrAmt.Name = "DrAmt"
        Me.DrAmt.ReadOnly = True
        '
        'CrAmt
        '
        Me.CrAmt.HeaderText = "Cr.Amt"
        Me.CrAmt.Name = "CrAmt"
        Me.CrAmt.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdPrint)
        Me.GroupBox2.Controls.Add(Me.rdOnscreen)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 33)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        '
        'rdPrint
        '
        Me.rdPrint.AutoSize = True
        Me.rdPrint.Checked = True
        Me.rdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPrint.Location = New System.Drawing.Point(86, 8)
        Me.rdPrint.Name = "rdPrint"
        Me.rdPrint.Size = New System.Drawing.Size(55, 19)
        Me.rdPrint.TabIndex = 1
        Me.rdPrint.TabStop = True
        Me.rdPrint.Text = "Print"
        Me.rdPrint.UseVisualStyleBackColor = True
        '
        'rdOnscreen
        '
        Me.rdOnscreen.AutoSize = True
        Me.rdOnscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOnscreen.Location = New System.Drawing.Point(10, 8)
        Me.rdOnscreen.Name = "rdOnscreen"
        Me.rdOnscreen.Size = New System.Drawing.Size(70, 19)
        Me.rdOnscreen.TabIndex = 0
        Me.rdOnscreen.Text = "Screen"
        Me.rdOnscreen.UseVisualStyleBackColor = True
        '
        'Dr
        '
        Me.Dr.AutoSize = True
        Me.Dr.Location = New System.Drawing.Point(75, 69)
        Me.Dr.Name = "Dr"
        Me.Dr.Size = New System.Drawing.Size(37, 17)
        Me.Dr.TabIndex = 118
        Me.Dr.Text = "Dr"
        Me.Dr.UseVisualStyleBackColor = True
        '
        'Cr
        '
        Me.Cr.AutoSize = True
        Me.Cr.Location = New System.Drawing.Point(111, 69)
        Me.Cr.Name = "Cr"
        Me.Cr.Size = New System.Drawing.Size(36, 17)
        Me.Cr.TabIndex = 119
        Me.Cr.Text = "Cr"
        Me.Cr.UseVisualStyleBackColor = True
        '
        'BOTH
        '
        Me.BOTH.AutoSize = True
        Me.BOTH.Checked = True
        Me.BOTH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BOTH.Location = New System.Drawing.Point(148, 69)
        Me.BOTH.Name = "BOTH"
        Me.BOTH.Size = New System.Drawing.Size(56, 17)
        Me.BOTH.TabIndex = 120
        Me.BOTH.Text = "BOTH"
        Me.BOTH.UseVisualStyleBackColor = True
        '
        'rdName
        '
        Me.rdName.AutoSize = True
        Me.rdName.Checked = True
        Me.rdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdName.Location = New System.Drawing.Point(116, 11)
        Me.rdName.Name = "rdName"
        Me.rdName.Size = New System.Drawing.Size(110, 17)
        Me.rdName.TabIndex = 122
        Me.rdName.TabStop = True
        Me.rdName.Text = "Order By Name"
        Me.rdName.UseVisualStyleBackColor = True
        '
        'rdCode
        '
        Me.rdCode.AutoSize = True
        Me.rdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdCode.Location = New System.Drawing.Point(6, 11)
        Me.rdCode.Name = "rdCode"
        Me.rdCode.Size = New System.Drawing.Size(107, 17)
        Me.rdCode.TabIndex = 121
        Me.rdCode.Text = "Order By Code"
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdCode)
        Me.GroupBox3.Controls.Add(Me.rdName)
        Me.GroupBox3.Location = New System.Drawing.Point(205, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 33)
        Me.GroupBox3.TabIndex = 123
        Me.GroupBox3.TabStop = False
        '
        'btnDos
        '
        Me.btnDos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(644, 117)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(86, 28)
        Me.btnDos.TabIndex = 124
        Me.btnDos.Text = "&DOS Print"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(262, 122)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(81, 20)
        Me.dtTo.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "TO"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(568, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "&Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmTrialbetweendays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(916, 593)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.BOTH)
        Me.Controls.Add(Me.Cr)
        Me.Controls.Add(Me.Dr)
        Me.Controls.Add(Me.edwoopening)
        Me.Controls.Add(Me.rdwithopening)
        Me.Controls.Add(Me.chkArea)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbsubgrpname)
        Me.Controls.Add(Me.cmbgrpname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgtrial)
        Me.Controls.Add(Me.chkallgengrps)
        Me.Name = "frmTrialbetweendays"
        Me.Text = "Trial Balance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgtrial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdcustomer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdPary As System.Windows.Forms.RadioButton
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rdgeneral As System.Windows.Forms.RadioButton
    Friend WithEvents edwoopening As System.Windows.Forms.RadioButton
    Friend WithEvents rdwithopening As System.Windows.Forms.RadioButton
    Friend WithEvents chkallgengrps As System.Windows.Forms.CheckBox
    Friend WithEvents dgtrial As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnscreen As System.Windows.Forms.RadioButton
    Friend WithEvents accheadcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accheadname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dr As System.Windows.Forms.CheckBox
    Friend WithEvents Cr As System.Windows.Forms.CheckBox
    Friend WithEvents BOTH As System.Windows.Forms.CheckBox
    Friend WithEvents rdName As System.Windows.Forms.RadioButton
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
