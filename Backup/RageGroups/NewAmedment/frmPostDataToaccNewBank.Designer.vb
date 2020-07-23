<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostDataToaccNewBAak
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
        Me.dgBillNo = New System.Windows.Forms.DataGridView
        Me.cmbvoutype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.vou_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vou_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewVoucheNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgBillNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 43)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Post Data"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgBillNo
        '
        Me.dgBillNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBillNo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.vou_type, Me.vou_no, Me.NewVoucheNo, Me.NewDate})
        Me.dgBillNo.Location = New System.Drawing.Point(0, 76)
        Me.dgBillNo.Name = "dgBillNo"
        Me.dgBillNo.Size = New System.Drawing.Size(556, 276)
        Me.dgBillNo.TabIndex = 187
        '
        'cmbvoutype
        '
        Me.cmbvoutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvoutype.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvoutype.FormattingEnabled = True
        Me.cmbvoutype.Items.AddRange(New Object() {"Bank"})
        Me.cmbvoutype.Location = New System.Drawing.Point(105, 46)
        Me.cmbvoutype.Name = "cmbvoutype"
        Me.cmbvoutype.Size = New System.Drawing.Size(130, 24)
        Me.cmbvoutype.TabIndex = 188
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Voucher Type:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 28)
        Me.Button1.TabIndex = 190
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 28)
        Me.Button2.TabIndex = 191
        Me.Button2.Text = "&Post"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Select"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.TrueValue = "1"
        Me.Column1.Width = 50
        '
        'vou_type
        '
        Me.vou_type.DataPropertyName = "vou_type"
        Me.vou_type.HeaderText = "Voucher Type"
        Me.vou_type.Name = "vou_type"
        '
        'vou_no
        '
        Me.vou_no.DataPropertyName = "vou_no"
        Me.vou_no.HeaderText = "Voucher No"
        Me.vou_no.Name = "vou_no"
        '
        'NewVoucheNo
        '
        Me.NewVoucheNo.HeaderText = "NewVoucheNo"
        Me.NewVoucheNo.Name = "NewVoucheNo"
        '
        'NewDate
        '
        Me.NewDate.HeaderText = "NewDate"
        Me.NewDate.Name = "NewDate"
        '
        'frmPostDataToaccNewBAak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(580, 402)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbvoutype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgBillNo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmPostDataToaccNewBAak"
        Me.Text = "frmPostDataToacc"
        CType(Me.dgBillNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgBillNo As System.Windows.Forms.DataGridView
    Friend WithEvents cmbvoutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents vou_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vou_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewVoucheNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
