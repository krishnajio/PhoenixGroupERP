<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHatchQty
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
        Me.Label4.Size = New System.Drawing.Size(408, 31)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Hatch Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txthatchqty
        '
        Me.txthatchqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthatchqty.Location = New System.Drawing.Point(130, 89)
        Me.txthatchqty.MaxLength = 30
        Me.txthatchqty.Name = "txthatchqty"
        Me.txthatchqty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txthatchqty.Size = New System.Drawing.Size(96, 22)
        Me.txthatchqty.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Hatch Qty:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 67)
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
        Me.dtHatchdate.Location = New System.Drawing.Point(130, 61)
        Me.dtHatchdate.Name = "dtHatchdate"
        Me.dtHatchdate.Size = New System.Drawing.Size(96, 22)
        Me.dtHatchdate.TabIndex = 76
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Location = New System.Drawing.Point(37, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 46)
        Me.Panel2.TabIndex = 77
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
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "&Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dgHatchQty
        '
        Me.dgHatchQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHatchQty.Location = New System.Drawing.Point(4, 201)
        Me.dgHatchQty.Name = "dgHatchQty"
        Me.dgHatchQty.Size = New System.Drawing.Size(404, 143)
        Me.dgHatchQty.TabIndex = 78
        '
        'cmbPrdUnit
        '
        Me.cmbPrdUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPrdUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPrdUnit.BackColor = System.Drawing.Color.White
        Me.cmbPrdUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrdUnit.FormattingEnabled = True
        Me.cmbPrdUnit.Location = New System.Drawing.Point(130, 34)
        Me.cmbPrdUnit.Name = "cmbPrdUnit"
        Me.cmbPrdUnit.Size = New System.Drawing.Size(173, 21)
        Me.cmbPrdUnit.TabIndex = 135
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label16.Location = New System.Drawing.Point(49, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 15)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = "Prod. Unit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Label2"
        '
        'frmHatchQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(408, 358)
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
        Me.Name = "frmHatchQty"
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
End Class
