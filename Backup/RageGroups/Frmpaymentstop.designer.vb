<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpaymentstop
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.Rdbtnbounce = New System.Windows.Forms.RadioButton
        Me.Rdbtnspayment = New System.Windows.Forms.RadioButton
        Me.Rdbtndestroy = New System.Windows.Forms.RadioButton
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.dginterest = New System.Windows.Forms.DataGridView
        Me.ruleid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtchqno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        CType(Me.dginterest, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(611, 35)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Cheque Bounce Destroy Stop Payment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Cheque No :"
        '
        'Rdbtnbounce
        '
        Me.Rdbtnbounce.AutoSize = True
        Me.Rdbtnbounce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdbtnbounce.Location = New System.Drawing.Point(286, 133)
        Me.Rdbtnbounce.Name = "Rdbtnbounce"
        Me.Rdbtnbounce.Size = New System.Drawing.Size(72, 20)
        Me.Rdbtnbounce.TabIndex = 1
        Me.Rdbtnbounce.Text = "Bounce"
        Me.Rdbtnbounce.UseVisualStyleBackColor = True
        '
        'Rdbtnspayment
        '
        Me.Rdbtnspayment.AutoSize = True
        Me.Rdbtnspayment.Checked = True
        Me.Rdbtnspayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdbtnspayment.Location = New System.Drawing.Point(286, 111)
        Me.Rdbtnspayment.Name = "Rdbtnspayment"
        Me.Rdbtnspayment.Size = New System.Drawing.Size(110, 20)
        Me.Rdbtnspayment.TabIndex = 2
        Me.Rdbtnspayment.TabStop = True
        Me.Rdbtnspayment.Text = "Stop Payment"
        Me.Rdbtnspayment.UseVisualStyleBackColor = True
        '
        'Rdbtndestroy
        '
        Me.Rdbtndestroy.AutoSize = True
        Me.Rdbtndestroy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdbtndestroy.Location = New System.Drawing.Point(286, 155)
        Me.Rdbtndestroy.Name = "Rdbtndestroy"
        Me.Rdbtndestroy.Size = New System.Drawing.Size(73, 20)
        Me.Rdbtndestroy.TabIndex = 3
        Me.Rdbtndestroy.Text = "Destroy"
        Me.Rdbtndestroy.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(370, 195)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(78, 31)
        Me.btnclose.TabIndex = 48
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(286, 195)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(78, 31)
        Me.btnreset.TabIndex = 47
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(202, 195)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 31)
        Me.btnsave.TabIndex = 44
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dginterest
        '
        Me.dginterest.AllowUserToAddRows = False
        Me.dginterest.AllowUserToDeleteRows = False
        Me.dginterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dginterest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ruleid, Me.Descr, Me.Rate})
        Me.dginterest.Location = New System.Drawing.Point(0, 232)
        Me.dginterest.Name = "dginterest"
        Me.dginterest.ReadOnly = True
        Me.dginterest.Size = New System.Drawing.Size(599, 167)
        Me.dginterest.TabIndex = 92
        '
        'ruleid
        '
        Me.ruleid.HeaderText = "Cheque No"
        Me.ruleid.Name = "ruleid"
        Me.ruleid.ReadOnly = True
        '
        'Descr
        '
        Me.Descr.HeaderText = "Reason"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.HeaderText = "Bounce Stop payment Destroy"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 200
        '
        'txtchqno
        '
        Me.txtchqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchqno.Location = New System.Drawing.Point(151, 78)
        Me.txtchqno.MaxLength = 30
        Me.txtchqno.Name = "txtchqno"
        Me.txtchqno.Size = New System.Drawing.Size(167, 22)
        Me.txtchqno.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Bank Code/Head :"
        '
        'cmbacheadname
        '
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(324, 50)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(228, 24)
        Me.cmbacheadname.TabIndex = 122
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(151, 50)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(167, 24)
        Me.cmbacheadcode.TabIndex = 121
        '
        'Frmpaymentstop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(611, 420)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtchqno)
        Me.Controls.Add(Me.dginterest)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Rdbtndestroy)
        Me.Controls.Add(Me.Rdbtnspayment)
        Me.Controls.Add(Me.Rdbtnbounce)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frmpaymentstop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmpaymentstop"
        CType(Me.dginterest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Rdbtnbounce As System.Windows.Forms.RadioButton
    Friend WithEvents Rdbtnspayment As System.Windows.Forms.RadioButton
    Friend WithEvents Rdbtndestroy As System.Windows.Forms.RadioButton
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents dginterest As System.Windows.Forms.DataGridView
    Friend WithEvents ruleid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtchqno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
End Class
