<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsubgroup
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
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtsubgroupname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.cmbgroup = New System.Windows.Forms.ComboBox()
        Me.dgsubgroups = New System.Windows.Forms.DataGridView()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtshedules = New System.Windows.Forms.TextBox()
        Me.txtgroupsfx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbgrpsuffix = New System.Windows.Forms.ComboBox()
        Me.txtprefix = New System.Windows.Forms.TextBox()
        CType(Me.dgsubgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'txtsubgroupname
        '
        Me.txtsubgroupname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubgroupname.Location = New System.Drawing.Point(153, 43)
        Me.txtsubgroupname.MaxLength = 60
        Me.txtsubgroupname.Name = "txtsubgroupname"
        Me.txtsubgroupname.Size = New System.Drawing.Size(384, 22)
        Me.txtsubgroupname.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Sub group name:"
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
        'cmbgroup
        '
        Me.cmbgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroup.FormattingEnabled = True
        Me.cmbgroup.Items.AddRange(New Object() {"BS", "PL"})
        Me.cmbgroup.Location = New System.Drawing.Point(153, 99)
        Me.cmbgroup.Name = "cmbgroup"
        Me.cmbgroup.Size = New System.Drawing.Size(296, 24)
        Me.cmbgroup.TabIndex = 2
        '
        'dgsubgroups
        '
        Me.dgsubgroups.AllowUserToAddRows = False
        Me.dgsubgroups.AllowUserToDeleteRows = False
        Me.dgsubgroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsubgroups.Location = New System.Drawing.Point(21, 224)
        Me.dgsubgroups.Name = "dgsubgroups"
        Me.dgsubgroups.ReadOnly = True
        Me.dgsubgroups.Size = New System.Drawing.Size(538, 407)
        Me.dgsubgroups.TabIndex = 31
        Me.dgsubgroups.TabStop = False
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(582, 35)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Sub Group Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(107, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 46)
        Me.Panel1.TabIndex = 3
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(10, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(52, 31)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Group of:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Shedules:"
        '
        'txtshedules
        '
        Me.txtshedules.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshedules.Location = New System.Drawing.Point(153, 129)
        Me.txtshedules.MaxLength = 1
        Me.txtshedules.Name = "txtshedules"
        Me.txtshedules.Size = New System.Drawing.Size(88, 22)
        Me.txtshedules.TabIndex = 3
        '
        'txtgroupsfx
        '
        Me.txtgroupsfx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgroupsfx.Location = New System.Drawing.Point(153, 71)
        Me.txtgroupsfx.MaxLength = 2
        Me.txtgroupsfx.Name = "txtgroupsfx"
        Me.txtgroupsfx.Size = New System.Drawing.Size(130, 22)
        Me.txtgroupsfx.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Sub Group prefix:"
        '
        'cmbgrpsuffix
        '
        Me.cmbgrpsuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgrpsuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpsuffix.FormattingEnabled = True
        Me.cmbgrpsuffix.Items.AddRange(New Object() {"BS", "PL"})
        Me.cmbgrpsuffix.Location = New System.Drawing.Point(455, 99)
        Me.cmbgrpsuffix.Name = "cmbgrpsuffix"
        Me.cmbgrpsuffix.Size = New System.Drawing.Size(82, 24)
        Me.cmbgrpsuffix.TabIndex = 36
        '
        'txtprefix
        '
        Me.txtprefix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprefix.Location = New System.Drawing.Point(247, 129)
        Me.txtprefix.MaxLength = 20
        Me.txtprefix.Name = "txtprefix"
        Me.txtprefix.ReadOnly = True
        Me.txtprefix.Size = New System.Drawing.Size(88, 22)
        Me.txtprefix.TabIndex = 37
        '
        'frmsubgroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(582, 643)
        Me.Controls.Add(Me.txtprefix)
        Me.Controls.Add(Me.cmbgrpsuffix)
        Me.Controls.Add(Me.txtgroupsfx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtshedules)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsubgroupname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbgroup)
        Me.Controls.Add(Me.dgsubgroups)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmsubgroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsubgroup"
        CType(Me.dgsubgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents txtsubgroupname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents cmbgroup As System.Windows.Forms.ComboBox
    Friend WithEvents dgsubgroups As System.Windows.Forms.DataGridView
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtshedules As System.Windows.Forms.TextBox
    Friend WithEvents txtgroupsfx As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbgrpsuffix As System.Windows.Forms.ComboBox
    Friend WithEvents txtprefix As System.Windows.Forms.TextBox
End Class
