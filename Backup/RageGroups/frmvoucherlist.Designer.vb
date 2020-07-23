<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvoucherlist
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
        Me.cmbvtype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.lblvtype = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtvouno = New System.Windows.Forms.ComboBox
        Me.dtvdate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(104, 8)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(222, 21)
        Me.cmbvtype.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Voucher Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Voucher No. :"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(271, 53)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(55, 22)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&OK"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lblvtype
        '
        Me.lblvtype.AutoSize = True
        Me.lblvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvtype.Location = New System.Drawing.Point(184, 8)
        Me.lblvtype.Name = "lblvtype"
        Me.lblvtype.Size = New System.Drawing.Size(0, 16)
        Me.lblvtype.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Voucher Date :"
        '
        'txtvouno
        '
        Me.txtvouno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtvouno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtvouno.BackColor = System.Drawing.Color.White
        Me.txtvouno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvouno.FormattingEnabled = True
        Me.txtvouno.Location = New System.Drawing.Point(104, 54)
        Me.txtvouno.Name = "txtvouno"
        Me.txtvouno.Size = New System.Drawing.Size(161, 21)
        Me.txtvouno.TabIndex = 2
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(104, 31)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(131, 20)
        Me.dtvdate.TabIndex = 1
        '
        'frmvoucherlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 84)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.txtvouno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.lblvtype)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmvoucherlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmvoucherlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents lblvtype As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtvouno As System.Windows.Forms.ComboBox
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
End Class
