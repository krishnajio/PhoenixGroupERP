<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackDateChqBankBook
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
        Me.dtvdate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.cmbDrCr = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtChqo = New System.Windows.Forms.TextBox
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.cmbacsubgroup = New System.Windows.Forms.ComboBox
        Me.cmbacgroup = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgBankBook = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.dgBankBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(567, 28)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Amount Credited By Bank  ,Amount Debited By Bank"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(202, 85)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(88, 20)
        Me.dtvdate.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(119, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Entry Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Amount :"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(202, 109)
        Me.txtAmount.MaxLength = 18
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(88, 21)
        Me.txtAmount.TabIndex = 113
        Me.txtAmount.Text = "0"
        '
        'cmbDrCr
        '
        Me.cmbDrCr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDrCr.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrCr.FormattingEnabled = True
        Me.cmbDrCr.Items.AddRange(New Object() {"Cr", "Dr"})
        Me.cmbDrCr.Location = New System.Drawing.Point(294, 108)
        Me.cmbDrCr.Name = "cmbDrCr"
        Me.cmbDrCr.Size = New System.Drawing.Size(53, 23)
        Me.cmbDrCr.TabIndex = 114
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Cheque No :"
        '
        'txtChqo
        '
        Me.txtChqo.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqo.Location = New System.Drawing.Point(202, 134)
        Me.txtChqo.MaxLength = 18
        Me.txtChqo.Name = "txtChqo"
        Me.txtChqo.Size = New System.Drawing.Size(145, 21)
        Me.txtChqo.TabIndex = 116
        Me.txtChqo.Text = "0"
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(202, 34)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(212, 21)
        Me.cmbacheadname.TabIndex = 0
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(420, 34)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(133, 21)
        Me.cmbacheadcode.TabIndex = 119
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-2, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(93, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 42)
        Me.Panel1.TabIndex = 123
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(69, 3)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(67, 31)
        Me.btnmodify.TabIndex = 7
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(281, 3)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(56, 31)
        Me.btnclose.TabIndex = 10
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(5, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(58, 31)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(218, 3)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(57, 31)
        Me.btnreset.TabIndex = 9
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(142, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(70, 31)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'cmbacsubgroup
        '
        Me.cmbacsubgroup.BackColor = System.Drawing.Color.White
        Me.cmbacsubgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacsubgroup.Enabled = False
        Me.cmbacsubgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacsubgroup.FormattingEnabled = True
        Me.cmbacsubgroup.Location = New System.Drawing.Point(420, 58)
        Me.cmbacsubgroup.Name = "cmbacsubgroup"
        Me.cmbacsubgroup.Size = New System.Drawing.Size(133, 24)
        Me.cmbacsubgroup.TabIndex = 120
        Me.cmbacsubgroup.TabStop = False
        '
        'cmbacgroup
        '
        Me.cmbacgroup.BackColor = System.Drawing.Color.White
        Me.cmbacgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacgroup.Enabled = False
        Me.cmbacgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacgroup.FormattingEnabled = True
        Me.cmbacgroup.Location = New System.Drawing.Point(203, 58)
        Me.cmbacgroup.Name = "cmbacgroup"
        Me.cmbacgroup.Size = New System.Drawing.Size(211, 24)
        Me.cmbacgroup.TabIndex = 118
        Me.cmbacgroup.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 15)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Group/Sub Group :"
        '
        'dgBankBook
        '
        Me.dgBankBook.AllowUserToAddRows = False
        Me.dgBankBook.AllowUserToDeleteRows = False
        Me.dgBankBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBankBook.Location = New System.Drawing.Point(12, 209)
        Me.dgBankBook.Name = "dgBankBook"
        Me.dgBankBook.ReadOnly = True
        Me.dgBankBook.Size = New System.Drawing.Size(541, 128)
        Me.dgBankBook.TabIndex = 124
        '
        'frmBackDateChqBankBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(567, 345)
        Me.Controls.Add(Me.dgBankBook)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbacsubgroup)
        Me.Controls.Add(Me.cmbacgroup)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtChqo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDrCr)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackDateChqBankBook"
        Me.Text = "frmBackDateChqBankBook"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgBankBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbDrCr As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChqo As System.Windows.Forms.TextBox
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents cmbacsubgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacgroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgBankBook As System.Windows.Forms.DataGridView
End Class
