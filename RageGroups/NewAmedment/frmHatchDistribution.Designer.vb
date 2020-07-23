<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHatchDistribution
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.txthatchqty = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtHatchdate = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.dgHatchQty = New System.Windows.Forms.DataGridView
        Me.cmbPrdUnit = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        CType(Me.dgHatchQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(689, 31)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Area Hatch Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txthatchqty
        '
        Me.txthatchqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthatchqty.Location = New System.Drawing.Point(213, 86)
        Me.txthatchqty.MaxLength = 30
        Me.txthatchqty.Name = "txthatchqty"
        Me.txthatchqty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txthatchqty.Size = New System.Drawing.Size(96, 22)
        Me.txthatchqty.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Hatch Qty:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Hatch Date:"
        '
        'dtHatchdate
        '
        Me.dtHatchdate.CustomFormat = "dd/MMM/yy"
        Me.dtHatchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHatchdate.Location = New System.Drawing.Point(213, 58)
        Me.dtHatchdate.Name = "dtHatchdate"
        Me.dtHatchdate.Size = New System.Drawing.Size(96, 22)
        Me.dtHatchdate.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Location = New System.Drawing.Point(180, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 46)
        Me.Panel2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(138, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(67, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 31)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(9, 6)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(52, 31)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dgHatchQty
        '
        Me.dgHatchQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHatchQty.Location = New System.Drawing.Point(1, 233)
        Me.dgHatchQty.Name = "dgHatchQty"
        Me.dgHatchQty.Size = New System.Drawing.Size(676, 340)
        Me.dgHatchQty.TabIndex = 7
        '
        'cmbPrdUnit
        '
        Me.cmbPrdUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPrdUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPrdUnit.BackColor = System.Drawing.Color.White
        Me.cmbPrdUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrdUnit.FormattingEnabled = True
        Me.cmbPrdUnit.Location = New System.Drawing.Point(213, 142)
        Me.cmbPrdUnit.Name = "cmbPrdUnit"
        Me.cmbPrdUnit.Size = New System.Drawing.Size(173, 21)
        Me.cmbPrdUnit.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label16.Location = New System.Drawing.Point(132, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 15)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = "Prod. Unit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Label2"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(208, 34)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(173, 21)
        Me.cmbAreaName.TabIndex = 0
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(382, 35)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(107, 21)
        Me.cmbAreaCode.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Area:"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(213, 114)
        Me.txtRate.MaxLength = 30
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRate.Size = New System.Drawing.Size(96, 22)
        Me.txtRate.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Rate:"
        '
        'frmHatchDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(689, 596)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbPrdUnit)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dgHatchQty)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dtHatchdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txthatchqty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHatchDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHatchQty"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgHatchQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txthatchqty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtHatchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents dgHatchQty As System.Windows.Forms.DataGridView
    Friend WithEvents cmbPrdUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
