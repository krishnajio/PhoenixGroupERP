<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemmaster
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbunit = New System.Windows.Forms.ComboBox
        Me.txtitemname = New System.Windows.Forms.TextBox
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgItemMaster = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.txtdiscountper = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnecc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtfreeqty = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdiscountamt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        CType(Me.dgItemMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Unit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Rate :"
        '
        'cmbunit
        '
        Me.cmbunit.BackColor = System.Drawing.Color.White
        Me.cmbunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbunit.FormattingEnabled = True
        Me.cmbunit.Items.AddRange(New Object() {"Kg", "Lt", "Tonnes", "Ml", "No"})
        Me.cmbunit.Location = New System.Drawing.Point(69, 59)
        Me.cmbunit.MaxLength = 50
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(117, 24)
        Me.cmbunit.TabIndex = 1
        '
        'txtitemname
        '
        Me.txtitemname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.Location = New System.Drawing.Point(69, 36)
        Me.txtitemname.MaxLength = 30
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtitemname.Size = New System.Drawing.Size(269, 22)
        Me.txtitemname.TabIndex = 0
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(69, 110)
        Me.txtrate.MaxLength = 30
        Me.txtrate.Name = "txtrate"
        Me.txtrate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtrate.Size = New System.Drawing.Size(54, 22)
        Me.txtrate.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(482, 31)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Item Master"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgItemMaster
        '
        Me.dgItemMaster.AllowUserToAddRows = False
        Me.dgItemMaster.AllowUserToOrderColumns = True
        Me.dgItemMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemMaster.Location = New System.Drawing.Point(11, 187)
        Me.dgItemMaster.Name = "dgItemMaster"
        Me.dgItemMaster.Size = New System.Drawing.Size(460, 353)
        Me.dgItemMaster.TabIndex = 72
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(12, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 46)
        Me.Panel1.TabIndex = 73
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(333, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(78, 31)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(251, 6)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(78, 31)
        Me.btnreset.TabIndex = 6
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(170, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(78, 31)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(87, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(78, 31)
        Me.btnmodify.TabIndex = 4
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(8, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 31)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtdiscountper
        '
        Me.txtdiscountper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscountper.Location = New System.Drawing.Point(228, 111)
        Me.txtdiscountper.MaxLength = 30
        Me.txtdiscountper.Name = "txtdiscountper"
        Me.txtdiscountper.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdiscountper.Size = New System.Drawing.Size(44, 22)
        Me.txtdiscountper.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Discount % :"
        '
        'txtnecc
        '
        Me.txtnecc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnecc.Location = New System.Drawing.Point(228, 85)
        Me.txtnecc.MaxLength = 30
        Me.txtnecc.Name = "txtnecc"
        Me.txtnecc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtnecc.Size = New System.Drawing.Size(70, 22)
        Me.txtnecc.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "NECC :"
        '
        'txtfreeqty
        '
        Me.txtfreeqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfreeqty.Location = New System.Drawing.Point(94, 85)
        Me.txtfreeqty.MaxLength = 30
        Me.txtfreeqty.Name = "txtfreeqty"
        Me.txtfreeqty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtfreeqty.Size = New System.Drawing.Size(70, 22)
        Me.txtfreeqty.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Free Qty % :"
        '
        'txtdiscountamt
        '
        Me.txtdiscountamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscountamt.Location = New System.Drawing.Point(399, 110)
        Me.txtdiscountamt.MaxLength = 30
        Me.txtdiscountamt.Name = "txtdiscountamt"
        Me.txtdiscountamt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdiscountamt.Size = New System.Drawing.Size(70, 22)
        Me.txtdiscountamt.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(280, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Discount Amt.  :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(12, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(459, 46)
        Me.Panel2.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(354, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(272, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 31)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(191, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 31)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(108, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 31)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "&Modify"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(29, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 31)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "&Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmItemmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(482, 552)
        Me.Controls.Add(Me.txtdiscountamt)
        Me.Controls.Add(Me.txtnecc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfreeqty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdiscountper)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.cmbunit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgItemMaster)
        Me.MaximizeBox = False
        Me.Name = "frmItemmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmItemmaster"
        CType(Me.dgItemMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbunit As System.Windows.Forms.ComboBox
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgItemMaster As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtdiscountper As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnecc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfreeqty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdiscountamt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
