<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeadTransfer
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbgrpname = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbAreato = New System.Windows.Forms.ComboBox
        Me.cmbAcodeto = New System.Windows.Forms.ComboBox
        Me.btnTransfer = New System.Windows.Forms.Button
        Me.cmbgroupsuffix = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-2, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 15)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = " Select Area From :"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(131, 63)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(191, 21)
        Me.cmbAreaName.TabIndex = 73
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(328, 64)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(79, 21)
        Me.cmbAreaCode.TabIndex = 71
        '
        'cmbsubgrpname
        '
        Me.cmbsubgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsubgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubgrpname.BackColor = System.Drawing.Color.White
        Me.cmbsubgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsubgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubgrpname.FormattingEnabled = True
        Me.cmbsubgrpname.Location = New System.Drawing.Point(132, 37)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(275, 21)
        Me.cmbsubgrpname.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 15)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Select Sub Group :"
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(132, 12)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(190, 21)
        Me.cmbgrpname.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Select Group :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = " Select Area TO :"
        '
        'CmbAreato
        '
        Me.CmbAreato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbAreato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbAreato.BackColor = System.Drawing.Color.White
        Me.CmbAreato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAreato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAreato.FormattingEnabled = True
        Me.CmbAreato.Location = New System.Drawing.Point(131, 90)
        Me.CmbAreato.Name = "CmbAreato"
        Me.CmbAreato.Size = New System.Drawing.Size(191, 21)
        Me.CmbAreato.TabIndex = 79
        '
        'cmbAcodeto
        '
        Me.cmbAcodeto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAcodeto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAcodeto.BackColor = System.Drawing.Color.White
        Me.cmbAcodeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAcodeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAcodeto.FormattingEnabled = True
        Me.cmbAcodeto.Location = New System.Drawing.Point(328, 91)
        Me.cmbAcodeto.Name = "cmbAcodeto"
        Me.cmbAcodeto.Size = New System.Drawing.Size(79, 21)
        Me.cmbAcodeto.TabIndex = 78
        '
        'btnTransfer
        '
        Me.btnTransfer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(15, 120)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(72, 30)
        Me.btnTransfer.TabIndex = 81
        Me.btnTransfer.Text = "&Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'cmbgroupsuffix
        '
        Me.cmbgroupsuffix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgroupsuffix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroupsuffix.BackColor = System.Drawing.Color.White
        Me.cmbgroupsuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgroupsuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroupsuffix.FormattingEnabled = True
        Me.cmbgroupsuffix.Location = New System.Drawing.Point(328, 10)
        Me.cmbgroupsuffix.Name = "cmbgroupsuffix"
        Me.cmbgroupsuffix.Size = New System.Drawing.Size(79, 21)
        Me.cmbgroupsuffix.TabIndex = 82
        '
        'frmHeadTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(426, 163)
        Me.Controls.Add(Me.cmbgroupsuffix)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbAreato)
        Me.Controls.Add(Me.cmbAcodeto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.cmbsubgrpname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbgrpname)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmHeadTransfer"
        Me.Text = "frmHeadTransfer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbAreato As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAcodeto As System.Windows.Forms.ComboBox
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents cmbgroupsuffix As System.Windows.Forms.ComboBox
End Class
