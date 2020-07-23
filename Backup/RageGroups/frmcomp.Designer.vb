<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcomp
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtcompname = New System.Windows.Forms.TextBox
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.dtpbookstd = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgcompany = New System.Windows.Forms.DataGridView
        Me.txttinno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtopncash = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtstockval = New System.Windows.Forms.TextBox
        Me.cmbDrCr = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.dgcompany, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(427, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Company Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Book Strart Date:"
        '
        'txtcompname
        '
        Me.txtcompname.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompname.Location = New System.Drawing.Point(134, 36)
        Me.txtcompname.MaxLength = 40
        Me.txtcompname.Name = "txtcompname"
        Me.txtcompname.Size = New System.Drawing.Size(229, 21)
        Me.txtcompname.TabIndex = 0
        '
        'txtadd
        '
        Me.txtadd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd.Location = New System.Drawing.Point(134, 61)
        Me.txtadd.MaxLength = 70
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtadd.Size = New System.Drawing.Size(229, 38)
        Me.txtadd.TabIndex = 1
        '
        'dtpbookstd
        '
        Me.dtpbookstd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbookstd.CustomFormat = "dd/MMM/yy"
        Me.dtpbookstd.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbookstd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpbookstd.Location = New System.Drawing.Point(134, 103)
        Me.dtpbookstd.Name = "dtpbookstd"
        Me.dtpbookstd.Size = New System.Drawing.Size(101, 21)
        Me.dtpbookstd.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tin No:"
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(42, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 42)
        Me.Panel1.TabIndex = 6
        '
        'dgcompany
        '
        Me.dgcompany.AllowUserToAddRows = False
        Me.dgcompany.AllowUserToDeleteRows = False
        Me.dgcompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcompany.Location = New System.Drawing.Point(8, 252)
        Me.dgcompany.Name = "dgcompany"
        Me.dgcompany.ReadOnly = True
        Me.dgcompany.Size = New System.Drawing.Size(410, 182)
        Me.dgcompany.TabIndex = 17
        Me.dgcompany.TabStop = False
        '
        'txttinno
        '
        Me.txttinno.Enabled = False
        Me.txttinno.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinno.Location = New System.Drawing.Point(134, 128)
        Me.txttinno.MaxLength = 10
        Me.txttinno.Name = "txttinno"
        Me.txttinno.Size = New System.Drawing.Size(101, 21)
        Me.txttinno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Opening Cash:"
        '
        'txtopncash
        '
        Me.txtopncash.Enabled = False
        Me.txtopncash.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopncash.Location = New System.Drawing.Point(134, 153)
        Me.txtopncash.MaxLength = 18
        Me.txtopncash.Name = "txtopncash"
        Me.txtopncash.Size = New System.Drawing.Size(101, 21)
        Me.txtopncash.TabIndex = 4
        Me.txtopncash.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Stock Value:"
        '
        'txtstockval
        '
        Me.txtstockval.Enabled = False
        Me.txtstockval.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstockval.Location = New System.Drawing.Point(134, 179)
        Me.txtstockval.MaxLength = 18
        Me.txtstockval.Name = "txtstockval"
        Me.txtstockval.Size = New System.Drawing.Size(101, 21)
        Me.txtstockval.TabIndex = 5
        Me.txtstockval.Text = "0"
        '
        'cmbDrCr
        '
        Me.cmbDrCr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDrCr.Enabled = False
        Me.cmbDrCr.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDrCr.FormattingEnabled = True
        Me.cmbDrCr.Items.AddRange(New Object() {"Cr", "Dr"})
        Me.cmbDrCr.Location = New System.Drawing.Point(238, 154)
        Me.cmbDrCr.Name = "cmbDrCr"
        Me.cmbDrCr.Size = New System.Drawing.Size(53, 23)
        Me.cmbDrCr.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(217, 34)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 21)
        Me.TextBox1.TabIndex = 20
        '
        'frmcomp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(427, 448)
        Me.Controls.Add(Me.cmbDrCr)
        Me.Controls.Add(Me.txtstockval)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtopncash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttinno)
        Me.Controls.Add(Me.dgcompany)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpbookstd)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.txtcompname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmcomp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Information"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgcompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcompname As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents dtpbookstd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgcompany As System.Windows.Forms.DataGridView
    Friend WithEvents txttinno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtopncash As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtstockval As System.Windows.Forms.TextBox
    Friend WithEvents cmbDrCr As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
