<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankopening
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
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.cmbdrcr = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgaccounthead = New System.Windows.Forms.DataGridView
        Me.acheadcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.accname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbheadcode = New System.Windows.Forms.ComboBox
        Me.cmbheadname = New System.Windows.Forms.ComboBox
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(223, 88)
        Me.txtamt.MaxLength = 40
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(128, 20)
        Me.txtamt.TabIndex = 77
        '
        'cmbdrcr
        '
        Me.cmbdrcr.BackColor = System.Drawing.Color.White
        Me.cmbdrcr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdrcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdrcr.FormattingEnabled = True
        Me.cmbdrcr.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbdrcr.Location = New System.Drawing.Point(138, 88)
        Me.cmbdrcr.Name = "cmbdrcr"
        Me.cmbdrcr.Size = New System.Drawing.Size(79, 21)
        Me.cmbdrcr.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 15)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Opening Balance :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 15)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Bank Head Name :"
        '
        'dgaccounthead
        '
        Me.dgaccounthead.AllowUserToAddRows = False
        Me.dgaccounthead.AllowUserToDeleteRows = False
        Me.dgaccounthead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaccounthead.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acheadcode, Me.accname, Me.dr, Me.cr})
        Me.dgaccounthead.Location = New System.Drawing.Point(6, 178)
        Me.dgaccounthead.Name = "dgaccounthead"
        Me.dgaccounthead.ReadOnly = True
        Me.dgaccounthead.Size = New System.Drawing.Size(434, 250)
        Me.dgaccounthead.TabIndex = 82
        '
        'acheadcode
        '
        Me.acheadcode.HeaderText = "Account Head Code"
        Me.acheadcode.Name = "acheadcode"
        Me.acheadcode.ReadOnly = True
        Me.acheadcode.Width = 80
        '
        'accname
        '
        Me.accname.HeaderText = "Account Head Name"
        Me.accname.Name = "accname"
        Me.accname.ReadOnly = True
        Me.accname.Width = 200
        '
        'dr
        '
        Me.dr.HeaderText = "Opening Dr"
        Me.dr.Name = "dr"
        Me.dr.ReadOnly = True
        Me.dr.Width = 50
        '
        'cr
        '
        Me.cr.HeaderText = "Opening Cr"
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Width = 50
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(6, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 43)
        Me.Panel1.TabIndex = 79
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(90, 4)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(79, 31)
        Me.btnmodify.TabIndex = 9
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(329, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(68, 31)
        Me.btnclose.TabIndex = 12
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(17, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(70, 31)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(257, 5)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(69, 31)
        Me.btnreset.TabIndex = 11
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(172, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(82, 31)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Bank Head Code :"
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
        Me.Label1.Size = New System.Drawing.Size(447, 31)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Bank Statement Opening"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbheadcode
        '
        Me.cmbheadcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbheadcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbheadcode.BackColor = System.Drawing.Color.White
        Me.cmbheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbheadcode.FormattingEnabled = True
        Me.cmbheadcode.Location = New System.Drawing.Point(138, 36)
        Me.cmbheadcode.Name = "cmbheadcode"
        Me.cmbheadcode.Size = New System.Drawing.Size(152, 21)
        Me.cmbheadcode.TabIndex = 73
        '
        'cmbheadname
        '
        Me.cmbheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbheadname.BackColor = System.Drawing.Color.White
        Me.cmbheadname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbheadname.FormattingEnabled = True
        Me.cmbheadname.Location = New System.Drawing.Point(138, 62)
        Me.cmbheadname.Name = "cmbheadname"
        Me.cmbheadname.Size = New System.Drawing.Size(287, 21)
        Me.cmbheadname.TabIndex = 88
        '
        'frmBankopening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(447, 438)
        Me.Controls.Add(Me.cmbheadname)
        Me.Controls.Add(Me.txtamt)
        Me.Controls.Add(Me.cmbdrcr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbheadcode)
        Me.Controls.Add(Me.dgaccounthead)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBankopening"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Statement Opening"
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents cmbdrcr As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgaccounthead As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents acheadcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbheadname As System.Windows.Forms.ComboBox
End Class
