<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgroups
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
        Me.btndelete = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.dggroups = New System.Windows.Forms.DataGridView
        Me.txtgroupname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbbs_pl = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtgroupsfx = New System.Windows.Forms.TextBox
        Me.cmbdr_cr = New System.Windows.Forms.ComboBox
        Me.listeffectsin = New System.Windows.Forms.ListBox
        Me.listremvtype = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkall = New System.Windows.Forms.CheckBox
        Me.btnremove = New System.Windows.Forms.Button
        Me.btnallot = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.dggroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(314, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(56, 31)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(251, 5)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(57, 31)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(182, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(64, 31)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(17, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 46)
        Me.Panel1.TabIndex = 2
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(113, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(64, 31)
        Me.btnmodify.TabIndex = 4
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(54, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(52, 31)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dggroups
        '
        Me.dggroups.AllowUserToAddRows = False
        Me.dggroups.AllowUserToDeleteRows = False
        Me.dggroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dggroups.Location = New System.Drawing.Point(17, 172)
        Me.dggroups.Name = "dggroups"
        Me.dggroups.ReadOnly = True
        Me.dggroups.Size = New System.Drawing.Size(836, 450)
        Me.dggroups.TabIndex = 24
        '
        'txtgroupname
        '
        Me.txtgroupname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgroupname.Location = New System.Drawing.Point(102, 38)
        Me.txtgroupname.MaxLength = 40
        Me.txtgroupname.Name = "txtgroupname"
        Me.txtgroupname.Size = New System.Drawing.Size(330, 22)
        Me.txtgroupname.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Part of:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Group name:"
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
        Me.Label1.Size = New System.Drawing.Size(864, 35)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Group Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbbs_pl
        '
        Me.cmbbs_pl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbs_pl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbs_pl.FormattingEnabled = True
        Me.cmbbs_pl.Items.AddRange(New Object() {"BS", "PL"})
        Me.cmbbs_pl.Location = New System.Drawing.Point(102, 90)
        Me.cmbbs_pl.Name = "cmbbs_pl"
        Me.cmbbs_pl.Size = New System.Drawing.Size(62, 24)
        Me.cmbbs_pl.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Group prefix:"
        '
        'txtgroupsfx
        '
        Me.txtgroupsfx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgroupsfx.Location = New System.Drawing.Point(102, 64)
        Me.txtgroupsfx.MaxLength = 2
        Me.txtgroupsfx.Name = "txtgroupsfx"
        Me.txtgroupsfx.Size = New System.Drawing.Size(130, 22)
        Me.txtgroupsfx.TabIndex = 1
        '
        'cmbdr_cr
        '
        Me.cmbdr_cr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdr_cr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdr_cr.FormattingEnabled = True
        Me.cmbdr_cr.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbdr_cr.Location = New System.Drawing.Point(170, 90)
        Me.cmbdr_cr.Name = "cmbdr_cr"
        Me.cmbdr_cr.Size = New System.Drawing.Size(62, 24)
        Me.cmbdr_cr.TabIndex = 26
        '
        'listeffectsin
        '
        Me.listeffectsin.FormattingEnabled = True
        Me.listeffectsin.Location = New System.Drawing.Point(675, 64)
        Me.listeffectsin.Name = "listeffectsin"
        Me.listeffectsin.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.listeffectsin.Size = New System.Drawing.Size(178, 69)
        Me.listeffectsin.TabIndex = 28
        '
        'listremvtype
        '
        Me.listremvtype.FormattingEnabled = True
        Me.listremvtype.Location = New System.Drawing.Point(438, 64)
        Me.listremvtype.Name = "listremvtype"
        Me.listremvtype.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.listremvtype.Size = New System.Drawing.Size(181, 69)
        Me.listremvtype.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Voucher Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(672, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Effects in:"
        '
        'chkall
        '
        Me.chkall.AutoSize = True
        Me.chkall.Checked = True
        Me.chkall.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkall.Location = New System.Drawing.Point(657, 43)
        Me.chkall.Name = "chkall"
        Me.chkall.Size = New System.Drawing.Size(42, 19)
        Me.chkall.TabIndex = 31
        Me.chkall.Text = "All"
        Me.chkall.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(629, 113)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(34, 27)
        Me.btnremove.TabIndex = 33
        Me.btnremove.Text = "<"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnallot
        '
        Me.btnallot.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnallot.Location = New System.Drawing.Point(629, 81)
        Me.btnallot.Name = "btnallot"
        Me.btnallot.Size = New System.Drawing.Size(34, 26)
        Me.btnallot.TabIndex = 32
        Me.btnallot.Text = ">"
        Me.btnallot.UseVisualStyleBackColor = True
        '
        'frmgroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(864, 634)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnallot)
        Me.Controls.Add(Me.chkall)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.listeffectsin)
        Me.Controls.Add(Me.listremvtype)
        Me.Controls.Add(Me.cmbdr_cr)
        Me.Controls.Add(Me.txtgroupsfx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbbs_pl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dggroups)
        Me.Controls.Add(Me.txtgroupname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmgroups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmgroups"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dggroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents dggroups As System.Windows.Forms.DataGridView
    Friend WithEvents txtgroupname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbbs_pl As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgroupsfx As System.Windows.Forms.TextBox
    Friend WithEvents cmbdr_cr As System.Windows.Forms.ComboBox
    Friend WithEvents listeffectsin As System.Windows.Forms.ListBox
    Friend WithEvents listremvtype As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkall As System.Windows.Forms.CheckBox
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btnallot As System.Windows.Forms.Button
End Class
