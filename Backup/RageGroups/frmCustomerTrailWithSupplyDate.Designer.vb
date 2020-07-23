<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerTrailWithSupplyDate
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.btnDos = New System.Windows.Forms.Button
        Me.edwoopening = New System.Windows.Forms.RadioButton
        Me.rdwithopening = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdCode = New System.Windows.Forms.RadioButton
        Me.rdName = New System.Windows.Forms.RadioButton
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.chkArea = New System.Windows.Forms.CheckBox
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.BOTH = New System.Windows.Forms.CheckBox
        Me.Cr = New System.Windows.Forms.CheckBox
        Me.Dr = New System.Windows.Forms.CheckBox
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "TO"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(204, 73)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(81, 20)
        Me.dtTo.TabIndex = 137
        '
        'btnDos
        '
        Me.btnDos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDos.Location = New System.Drawing.Point(552, 72)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(86, 26)
        Me.btnDos.TabIndex = 136
        Me.btnDos.Text = "&DOS Print"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'edwoopening
        '
        Me.edwoopening.AutoSize = True
        Me.edwoopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.edwoopening.Location = New System.Drawing.Point(358, 39)
        Me.edwoopening.Name = "edwoopening"
        Me.edwoopening.Size = New System.Drawing.Size(120, 17)
        Me.edwoopening.TabIndex = 133
        Me.edwoopening.Text = "Without Opening"
        Me.edwoopening.UseVisualStyleBackColor = True
        '
        'rdwithopening
        '
        Me.rdwithopening.AutoSize = True
        Me.rdwithopening.Checked = True
        Me.rdwithopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdwithopening.Location = New System.Drawing.Point(250, 39)
        Me.rdwithopening.Name = "rdwithopening"
        Me.rdwithopening.Size = New System.Drawing.Size(102, 17)
        Me.rdwithopening.TabIndex = 132
        Me.rdwithopening.TabStop = True
        Me.rdwithopening.Text = "With Opening"
        Me.rdwithopening.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(478, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 28)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(419, 71)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(56, 28)
        Me.btnshow.TabIndex = 130
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(95, 72)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(81, 20)
        Me.dtfrom.TabIndex = 127
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
        Me.Label1.Size = New System.Drawing.Size(800, 30)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Customer Trial Balance With Last Supply Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Date From :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdCode)
        Me.GroupBox3.Controls.Add(Me.rdName)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 33)
        Me.GroupBox3.TabIndex = 135
        Me.GroupBox3.TabStop = False
        '
        'rdCode
        '
        Me.rdCode.AutoSize = True
        Me.rdCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdCode.Location = New System.Drawing.Point(6, 6)
        Me.rdCode.Name = "rdCode"
        Me.rdCode.Size = New System.Drawing.Size(107, 17)
        Me.rdCode.TabIndex = 121
        Me.rdCode.Text = "Order By Code"
        Me.rdCode.UseVisualStyleBackColor = True
        '
        'rdName
        '
        Me.rdName.AutoSize = True
        Me.rdName.Checked = True
        Me.rdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdName.Location = New System.Drawing.Point(116, 6)
        Me.rdName.Name = "rdName"
        Me.rdName.Size = New System.Drawing.Size(110, 17)
        Me.rdName.TabIndex = 122
        Me.rdName.TabStop = True
        Me.rdName.Text = "Order By Name"
        Me.rdName.UseVisualStyleBackColor = True
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 124)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(800, 331)
        Me.CrViewerGenralLedger.TabIndex = 139
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArea.Location = New System.Drawing.Point(479, 40)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(55, 19)
        Me.chkArea.TabIndex = 142
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
        Me.cmbAreaName.Location = New System.Drawing.Point(535, 39)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(125, 21)
        Me.cmbAreaName.TabIndex = 140
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(664, 39)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(67, 21)
        Me.cmbAreaCode.TabIndex = 141
        '
        'BOTH
        '
        Me.BOTH.AutoSize = True
        Me.BOTH.Checked = True
        Me.BOTH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BOTH.Location = New System.Drawing.Point(363, 76)
        Me.BOTH.Name = "BOTH"
        Me.BOTH.Size = New System.Drawing.Size(56, 17)
        Me.BOTH.TabIndex = 145
        Me.BOTH.Text = "BOTH"
        Me.BOTH.UseVisualStyleBackColor = True
        '
        'Cr
        '
        Me.Cr.AutoSize = True
        Me.Cr.Location = New System.Drawing.Point(326, 76)
        Me.Cr.Name = "Cr"
        Me.Cr.Size = New System.Drawing.Size(36, 17)
        Me.Cr.TabIndex = 144
        Me.Cr.Text = "Cr"
        Me.Cr.UseVisualStyleBackColor = True
        '
        'Dr
        '
        Me.Dr.AutoSize = True
        Me.Dr.Location = New System.Drawing.Point(290, 76)
        Me.Dr.Name = "Dr"
        Me.Dr.Size = New System.Drawing.Size(37, 17)
        Me.Dr.TabIndex = 143
        Me.Dr.Text = "Dr"
        Me.Dr.UseVisualStyleBackColor = True
        '
        'frmCustomerTrailWithSupplyDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 455)
        Me.Controls.Add(Me.BOTH)
        Me.Controls.Add(Me.Cr)
        Me.Controls.Add(Me.Dr)
        Me.Controls.Add(Me.chkArea)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.btnDos)
        Me.Controls.Add(Me.edwoopening)
        Me.Controls.Add(Me.rdwithopening)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerTrailWithSupplyDate"
        Me.Text = "frmCustomerTrailWithSupplyDate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents edwoopening As System.Windows.Forms.RadioButton
    Friend WithEvents rdwithopening As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCode As System.Windows.Forms.RadioButton
    Friend WithEvents rdName As System.Windows.Forms.RadioButton
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents BOTH As System.Windows.Forms.CheckBox
    Friend WithEvents Cr As System.Windows.Forms.CheckBox
    Friend WithEvents Dr As System.Windows.Forms.CheckBox
End Class
