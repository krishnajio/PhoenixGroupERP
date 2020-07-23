<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateVouDate
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
        Me.voutype = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTO = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dthatchdate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtppp = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Location = New System.Drawing.Point(119, 46)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(241, 21)
        Me.voutype.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SlateBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1252, 35)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Update Billing Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Voucher Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Voucher No From:"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(529, 47)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(111, 20)
        Me.txtFrom.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(655, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Voucher No To:"
        '
        'txtTO
        '
        Me.txtTO.Location = New System.Drawing.Point(777, 43)
        Me.txtTO.Name = "txtTO"
        Me.txtTO.Size = New System.Drawing.Size(111, 20)
        Me.txtTO.TabIndex = 135
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(894, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 136
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1081, 150)
        Me.DataGridView1.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "New Bill Date:"
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(119, 236)
        Me.dtpdate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(112, 21)
        Me.dtpdate.TabIndex = 215
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(237, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 30)
        Me.Button2.TabIndex = 216
        Me.Button2.Text = "&Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dthatchdate
        '
        Me.dthatchdate.CustomFormat = "dd/MMM/yyyy"
        Me.dthatchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dthatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthatchdate.Location = New System.Drawing.Point(141, 307)
        Me.dthatchdate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dthatchdate.Name = "dthatchdate"
        Me.dthatchdate.Size = New System.Drawing.Size(112, 21)
        Me.dthatchdate.TabIndex = 218
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 217
        Me.Label6.Text = "New Hatch Date:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(259, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 30)
        Me.Button3.TabIndex = 219
        Me.Button3.Text = "&Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtppp
        '
        Me.dtppp.CustomFormat = "dd/MMM/yyyy"
        Me.dtppp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtppp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtppp.Location = New System.Drawing.Point(975, 42)
        Me.dtppp.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtppp.Name = "dtppp"
        Me.dtppp.Size = New System.Drawing.Size(112, 21)
        Me.dtppp.TabIndex = 220
        '
        'frmUpdateVouDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 388)
        Me.Controls.Add(Me.dtppp)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dthatchdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.voutype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmUpdateVouDate"
        Me.Text = "frmUpdateVouDate"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTO As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dthatchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dtppp As System.Windows.Forms.DateTimePicker
End Class
