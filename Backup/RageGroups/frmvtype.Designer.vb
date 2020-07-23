<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvtype
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
        Me.dggroups = New System.Windows.Forms.DataGridView
        Me.txtvtype = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.numericup = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbvouchernoseq = New System.Windows.Forms.ComboBox
        Me.txtPrefix = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.dggroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.numericup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dggroups
        '
        Me.dggroups.AllowUserToAddRows = False
        Me.dggroups.AllowUserToDeleteRows = False
        Me.dggroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dggroups.Location = New System.Drawing.Point(15, 210)
        Me.dggroups.Name = "dggroups"
        Me.dggroups.ReadOnly = True
        Me.dggroups.Size = New System.Drawing.Size(441, 129)
        Me.dggroups.TabIndex = 31
        '
        'txtvtype
        '
        Me.txtvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvtype.Location = New System.Drawing.Point(196, 40)
        Me.txtvtype.MaxLength = 20
        Me.txtvtype.Name = "txtvtype"
        Me.txtvtype.Size = New System.Drawing.Size(217, 22)
        Me.txtvtype.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Voucher Type:"
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
        Me.Label1.Size = New System.Drawing.Size(479, 35)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Voucher Type's"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(270, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(56, 31)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(207, 5)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(57, 31)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(138, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(64, 31)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(7, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(52, 31)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(69, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(64, 31)
        Me.btnmodify.TabIndex = 4
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(66, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 46)
        Me.Panel1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Day Book sequence:"
        '
        'numericup
        '
        Me.numericup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericup.Location = New System.Drawing.Point(196, 69)
        Me.numericup.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericup.Name = "numericup"
        Me.numericup.ReadOnly = True
        Me.numericup.Size = New System.Drawing.Size(46, 22)
        Me.numericup.TabIndex = 1
        Me.numericup.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Voucher no sequence:"
        '
        'cmbvouchernoseq
        '
        Me.cmbvouchernoseq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvouchernoseq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvouchernoseq.FormattingEnabled = True
        Me.cmbvouchernoseq.Items.AddRange(New Object() {"Only increasing order", "Increasing order with breaking on date"})
        Me.cmbvouchernoseq.Location = New System.Drawing.Point(196, 97)
        Me.cmbvouchernoseq.Name = "cmbvouchernoseq"
        Me.cmbvouchernoseq.Size = New System.Drawing.Size(217, 24)
        Me.cmbvouchernoseq.TabIndex = 2
        '
        'txtPrefix
        '
        Me.txtPrefix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(196, 127)
        Me.txtPrefix.MaxLength = 20
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(61, 22)
        Me.txtPrefix.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Prefix for Voucher:"
        '
        'frmvtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(479, 362)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbvouchernoseq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numericup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dggroups)
        Me.Controls.Add(Me.txtvtype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmvtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Type"
        CType(Me.dggroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.numericup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dggroups As System.Windows.Forms.DataGridView
    Friend WithEvents txtvtype As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numericup As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbvouchernoseq As System.Windows.Forms.ComboBox
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
