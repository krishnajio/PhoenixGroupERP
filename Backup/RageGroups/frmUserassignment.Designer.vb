<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserassignment
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
        Me.cmbuname = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnallot = New System.Windows.Forms.Button
        Me.btnremove = New System.Windows.Forms.Button
        Me.lremcmpname = New System.Windows.Forms.ListBox
        Me.lallotcmpname = New System.Windows.Forms.ListBox
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
        Me.Label1.Size = New System.Drawing.Size(741, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Assign Company to User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbuname
        '
        Me.cmbuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbuname.FormattingEnabled = True
        Me.cmbuname.Location = New System.Drawing.Point(177, 52)
        Me.cmbuname.Name = "cmbuname"
        Me.cmbuname.Size = New System.Drawing.Size(240, 24)
        Me.cmbuname.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "User Name :"
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(666, 378)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(60, 35)
        Me.btnclose.TabIndex = 12
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(583, 378)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(77, 35)
        Me.btnupdate.TabIndex = 11
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Remaining Companies"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(572, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Alotted Companies"
        '
        'btnallot
        '
        Me.btnallot.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnallot.Location = New System.Drawing.Point(358, 190)
        Me.btnallot.Name = "btnallot"
        Me.btnallot.Size = New System.Drawing.Size(23, 34)
        Me.btnallot.TabIndex = 15
        Me.btnallot.Text = ">"
        Me.btnallot.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(358, 238)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(23, 35)
        Me.btnremove.TabIndex = 16
        Me.btnremove.Text = "<"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'lremcmpname
        '
        Me.lremcmpname.FormattingEnabled = True
        Me.lremcmpname.Location = New System.Drawing.Point(8, 117)
        Me.lremcmpname.Name = "lremcmpname"
        Me.lremcmpname.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lremcmpname.Size = New System.Drawing.Size(344, 251)
        Me.lremcmpname.TabIndex = 19
        '
        'lallotcmpname
        '
        Me.lallotcmpname.FormattingEnabled = True
        Me.lallotcmpname.Location = New System.Drawing.Point(383, 121)
        Me.lallotcmpname.Name = "lallotcmpname"
        Me.lallotcmpname.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lallotcmpname.Size = New System.Drawing.Size(346, 251)
        Me.lallotcmpname.TabIndex = 20
        '
        'frmUserassignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(741, 538)
        Me.Controls.Add(Me.lallotcmpname)
        Me.Controls.Add(Me.lremcmpname)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnallot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbuname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUserassignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Company to User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbuname As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnallot As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents lremcmpname As System.Windows.Forms.ListBox
    Friend WithEvents lallotcmpname As System.Windows.Forms.ListBox
End Class
