<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterest
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
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.txtruleid = New System.Windows.Forms.TextBox
        Me.dginterest = New System.Windows.Forms.DataGridView
        Me.ruleid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inttype = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtdescr = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbinttype = New System.Windows.Forms.ComboBox
        CType(Me.dginterest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(332, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(78, 31)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(250, 6)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(78, 31)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(86, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(78, 31)
        Me.btnmodify.TabIndex = 4
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(169, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(78, 31)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtruleid
        '
        Me.txtruleid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruleid.Location = New System.Drawing.Point(138, 48)
        Me.txtruleid.MaxLength = 120
        Me.txtruleid.Name = "txtruleid"
        Me.txtruleid.ReadOnly = True
        Me.txtruleid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtruleid.Size = New System.Drawing.Size(46, 22)
        Me.txtruleid.TabIndex = 0
        '
        'dginterest
        '
        Me.dginterest.AllowUserToAddRows = False
        Me.dginterest.AllowUserToDeleteRows = False
        Me.dginterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dginterest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ruleid, Me.Descr, Me.Rate, Me.inttype})
        Me.dginterest.Location = New System.Drawing.Point(46, 184)
        Me.dginterest.Name = "dginterest"
        Me.dginterest.ReadOnly = True
        Me.dginterest.Size = New System.Drawing.Size(398, 143)
        Me.dginterest.TabIndex = 37
        '
        'ruleid
        '
        Me.ruleid.HeaderText = "Rule ID"
        Me.ruleid.Name = "ruleid"
        Me.ruleid.ReadOnly = True
        Me.ruleid.Width = 50
        '
        'Descr
        '
        Me.Descr.HeaderText = "Description"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        Me.Descr.Width = 250
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate (%)"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 50
        '
        'inttype
        '
        Me.inttype.HeaderText = "Int. Type"
        Me.inttype.Name = "inttype"
        Me.inttype.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Iterest Rule ID :"
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
        Me.Label1.Size = New System.Drawing.Size(485, 35)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Interest Rules"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(4, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 31)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(37, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 46)
        Me.Panel1.TabIndex = 34
        '
        'txtdescr
        '
        Me.txtdescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescr.Location = New System.Drawing.Point(138, 74)
        Me.txtdescr.MaxLength = 30
        Me.txtdescr.Name = "txtdescr"
        Me.txtdescr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescr.Size = New System.Drawing.Size(310, 22)
        Me.txtdescr.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Description :"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(138, 100)
        Me.txtrate.MaxLength = 30
        Me.txtrate.Name = "txtrate"
        Me.txtrate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtrate.Size = New System.Drawing.Size(70, 22)
        Me.txtrate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Rate (%) :"
        '
        'cmbinttype
        '
        Me.cmbinttype.BackColor = System.Drawing.Color.White
        Me.cmbinttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbinttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbinttype.FormattingEnabled = True
        Me.cmbinttype.Items.AddRange(New Object() {"Monthly", "Quaterly", "Half Yearly", "Yearly"})
        Me.cmbinttype.Location = New System.Drawing.Point(214, 99)
        Me.cmbinttype.Name = "cmbinttype"
        Me.cmbinttype.Size = New System.Drawing.Size(124, 24)
        Me.cmbinttype.TabIndex = 43
        '
        'frmInterest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(485, 337)
        Me.Controls.Add(Me.cmbinttype)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdescr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtruleid)
        Me.Controls.Add(Me.dginterest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInterest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interest Rule"
        CType(Me.dginterest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents txtruleid As System.Windows.Forms.TextBox
    Friend WithEvents dginterest As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtdescr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbinttype As System.Windows.Forms.ComboBox
    Friend WithEvents ruleid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inttype As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
