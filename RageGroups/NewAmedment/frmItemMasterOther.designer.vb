<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemMasterOther
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbunit = New System.Windows.Forms.ComboBox()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgItemMaster = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtdiscountper = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnecc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfreeqty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdiscountamt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.rdForPurchse = New System.Windows.Forms.RadioButton()
        Me.rdOther = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgItemMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Unit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 129)
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
        Me.cmbunit.Items.AddRange(New Object() {"Kg", "Lt", "Tonnes", "Ml", "No", "Sft", "Gm", "Doase", "Vial", ""})
        Me.cmbunit.Location = New System.Drawing.Point(64, 98)
        Me.cmbunit.MaxLength = 50
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(117, 24)
        Me.cmbunit.TabIndex = 1
        '
        'txtitemname
        '
        Me.txtitemname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitemname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.Location = New System.Drawing.Point(64, 75)
        Me.txtitemname.MaxLength = 30
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtitemname.Size = New System.Drawing.Size(413, 22)
        Me.txtitemname.TabIndex = 0
        '
        'txtrate
        '
        Me.txtrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(64, 127)
        Me.txtrate.MaxLength = 30
        Me.txtrate.Name = "txtrate"
        Me.txtrate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtrate.Size = New System.Drawing.Size(54, 22)
        Me.txtrate.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkCyan
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(505, 31)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Product Master Other"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgItemMaster
        '
        Me.dgItemMaster.AllowUserToAddRows = False
        Me.dgItemMaster.AllowUserToOrderColumns = True
        Me.dgItemMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemMaster.Location = New System.Drawing.Point(11, 238)
        Me.dgItemMaster.Name = "dgItemMaster"
        Me.dgItemMaster.Size = New System.Drawing.Size(460, 302)
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
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
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
        Me.txtdiscountper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscountper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscountper.Location = New System.Drawing.Point(223, 128)
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
        Me.Label5.Location = New System.Drawing.Point(124, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Discount % :"
        '
        'txtnecc
        '
        Me.txtnecc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnecc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnecc.Location = New System.Drawing.Point(407, 103)
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
        Me.Label6.Location = New System.Drawing.Point(349, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "NECC :"
        '
        'txtfreeqty
        '
        Me.txtfreeqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfreeqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfreeqty.Location = New System.Drawing.Point(278, 103)
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
        Me.Label7.Location = New System.Drawing.Point(186, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Free Qty % :"
        '
        'txtdiscountamt
        '
        Me.txtdiscountamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdiscountamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscountamt.Location = New System.Drawing.Point(407, 127)
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
        Me.Label8.Location = New System.Drawing.Point(287, 130)
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
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(8, 184)
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
        'rdForPurchse
        '
        Me.rdForPurchse.AutoSize = True
        Me.rdForPurchse.Checked = True
        Me.rdForPurchse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdForPurchse.Location = New System.Drawing.Point(64, 159)
        Me.rdForPurchse.Name = "rdForPurchse"
        Me.rdForPurchse.Size = New System.Drawing.Size(85, 19)
        Me.rdForPurchse.TabIndex = 82
        Me.rdForPurchse.TabStop = True
        Me.rdForPurchse.Text = "Purchase"
        Me.rdForPurchse.UseVisualStyleBackColor = True
        '
        'rdOther
        '
        Me.rdOther.AutoSize = True
        Me.rdOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOther.Location = New System.Drawing.Point(155, 159)
        Me.rdOther.Name = "rdOther"
        Me.rdOther.Size = New System.Drawing.Size(67, 19)
        Me.rdOther.TabIndex = 83
        Me.rdOther.Text = "Others"
        Me.rdOther.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"FEED", "MEDICINE", "PACKING MATERIALS", "GENERAL PUR ITEMS"})
        Me.ComboBox1.Location = New System.Drawing.Point(61, 45)
        Me.ComboBox1.MaxLength = 50
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(173, 24)
        Me.ComboBox1.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Type :"
        '
        'frmItemMasterOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(505, 552)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.rdOther)
        Me.Controls.Add(Me.rdForPurchse)
        Me.Controls.Add(Me.txtdiscountamt)
        Me.Controls.Add(Me.txtnecc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtfreeqty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
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
        Me.Name = "frmItemMasterOther"
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
    Friend WithEvents rdForPurchse As System.Windows.Forms.RadioButton
    Friend WithEvents rdOther As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
