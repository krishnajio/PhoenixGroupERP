<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrial4day
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
        Me.rdwithopening = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox
        Me.cmbgrpname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.btnshow = New System.Windows.Forms.Button
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.chkArea = New System.Windows.Forms.CheckBox
        Me.d1 = New System.Windows.Forms.DateTimePicker
        Me.d2 = New System.Windows.Forms.DateTimePicker
        Me.d3 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'rdwithopening
        '
        Me.rdwithopening.AutoSize = True
        Me.rdwithopening.Checked = True
        Me.rdwithopening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.rdwithopening.Location = New System.Drawing.Point(127, 58)
        Me.rdwithopening.Name = "rdwithopening"
        Me.rdwithopening.Size = New System.Drawing.Size(102, 17)
        Me.rdwithopening.TabIndex = 121
        Me.rdwithopening.TabStop = True
        Me.rdwithopening.Text = "With Opening"
        Me.rdwithopening.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(447, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 28)
        Me.Button1.TabIndex = 120
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
        Me.cmbsubgrpname.Location = New System.Drawing.Point(330, 31)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(197, 21)
        Me.cmbsubgrpname.TabIndex = 119
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(127, 31)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(197, 21)
        Me.cmbgrpname.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(-3, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 117
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
        Me.cmbAreaName.Location = New System.Drawing.Point(126, 4)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(125, 21)
        Me.cmbAreaName.TabIndex = 115
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(257, 4)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(67, 21)
        Me.cmbAreaCode.TabIndex = 116
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(373, 58)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(68, 28)
        Me.btnshow.TabIndex = 114
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 126)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(975, 460)
        Me.CrViewerGenralLedger.TabIndex = 123
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArea.Location = New System.Drawing.Point(65, 4)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(55, 19)
        Me.chkArea.TabIndex = 124
        Me.chkArea.Text = "Area"
        Me.chkArea.UseVisualStyleBackColor = True
        '
        'd1
        '
        Me.d1.CustomFormat = "dd/MMM/yy"
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d1.Location = New System.Drawing.Point(534, 32)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(104, 20)
        Me.d1.TabIndex = 125
        '
        'd2
        '
        Me.d2.CustomFormat = "dd/MMM/yy"
        Me.d2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d2.Location = New System.Drawing.Point(644, 32)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(104, 20)
        Me.d2.TabIndex = 127
        '
        'd3
        '
        Me.d3.CustomFormat = "dd/MMM/yy"
        Me.d3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d3.Location = New System.Drawing.Point(754, 32)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(104, 20)
        Me.d3.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(531, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "1 St date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(650, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "2 St date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(760, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "3 St date"
        '
        'frmTrial4day
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 586)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.chkArea)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.rdwithopening)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbsubgrpname)
        Me.Controls.Add(Me.cmbgrpname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.btnshow)
        Me.Name = "frmTrial4day"
        Me.Text = "frmTrial4day"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdwithopening As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents d1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents d2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents d3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
