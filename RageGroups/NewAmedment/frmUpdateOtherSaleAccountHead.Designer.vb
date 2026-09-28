<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateOtherSaleAccountHead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbVoucherType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVoucherType = New System.Windows.Forms.TextBox()
        Me.txtOldAccountCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewAccountCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(978, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UpdateOtherSaleAccountHead"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbVoucherType
        '
        Me.cmbVoucherType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbVoucherType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVoucherType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVoucherType.FormattingEnabled = True
        Me.cmbVoucherType.Location = New System.Drawing.Point(12, 84)
        Me.cmbVoucherType.Name = "cmbVoucherType"
        Me.cmbVoucherType.Size = New System.Drawing.Size(236, 24)
        Me.cmbVoucherType.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Voucher Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Voucher No"
        '
        'txtVoucherType
        '
        Me.txtVoucherType.Location = New System.Drawing.Point(12, 136)
        Me.txtVoucherType.Name = "txtVoucherType"
        Me.txtVoucherType.Size = New System.Drawing.Size(233, 20)
        Me.txtVoucherType.TabIndex = 42
        '
        'txtOldAccountCode
        '
        Me.txtOldAccountCode.Location = New System.Drawing.Point(12, 181)
        Me.txtOldAccountCode.Name = "txtOldAccountCode"
        Me.txtOldAccountCode.Size = New System.Drawing.Size(233, 20)
        Me.txtOldAccountCode.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Old Account Code"
        '
        'txtNewAccountCode
        '
        Me.txtNewAccountCode.Location = New System.Drawing.Point(12, 226)
        Me.txtNewAccountCode.Name = "txtNewAccountCode"
        Me.txtNewAccountCode.Size = New System.Drawing.Size(233, 20)
        Me.txtNewAccountCode.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "New Account Code"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 33)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(304, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(662, 162)
        Me.DataGridView1.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 33)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmUpdateOtherSaleAccountHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(978, 344)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNewAccountCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOldAccountCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVoucherType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbVoucherType)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUpdateOtherSaleAccountHead"
        Me.Text = "frmUpdateOtherSaleAccountHead"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbVoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVoucherType As System.Windows.Forms.TextBox
    Friend WithEvents txtOldAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewAccountCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
