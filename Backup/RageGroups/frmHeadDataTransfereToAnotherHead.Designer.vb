<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeadDataTransfereToAnotherHead
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
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbgrpname = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbaccto = New System.Windows.Forms.ComboBox
        Me.cmbcodeto = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.dr = New System.Windows.Forms.ComboBox
        Me.cr = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.crTo = New System.Windows.Forms.ComboBox
        Me.drTo = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbsubgrpname
        '
        Me.cmbsubgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsubgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubgrpname.BackColor = System.Drawing.Color.White
        Me.cmbsubgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsubgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubgrpname.FormattingEnabled = True
        Me.cmbsubgrpname.Location = New System.Drawing.Point(415, 46)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(112, 21)
        Me.cmbsubgrpname.TabIndex = 92
        Me.cmbsubgrpname.TabStop = False
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(208, 27)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(247, 21)
        Me.cmbacheadname.TabIndex = 89
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(461, 25)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbacheadcode.TabIndex = 90
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(164, 47)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(245, 21)
        Me.cmbgrpname.TabIndex = 91
        Me.cmbgrpname.TabStop = False
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
        Me.Label1.Size = New System.Drawing.Size(647, 31)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Data Transfer To Another Head"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Transfer TO:"
        '
        'cmbaccto
        '
        Me.cmbaccto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbaccto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbaccto.BackColor = System.Drawing.Color.White
        Me.cmbaccto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbaccto.FormattingEnabled = True
        Me.cmbaccto.Location = New System.Drawing.Point(227, 127)
        Me.cmbaccto.Name = "cmbaccto"
        Me.cmbaccto.Size = New System.Drawing.Size(247, 21)
        Me.cmbaccto.TabIndex = 97
        '
        'cmbcodeto
        '
        Me.cmbcodeto.BackColor = System.Drawing.Color.White
        Me.cmbcodeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcodeto.FormattingEnabled = True
        Me.cmbcodeto.Location = New System.Drawing.Point(480, 125)
        Me.cmbcodeto.Name = "cmbcodeto"
        Me.cmbcodeto.Size = New System.Drawing.Size(110, 21)
        Me.cmbcodeto.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 15)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Account Head (Code/Name)  TO:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(559, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "&Transfer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dr
        '
        Me.dr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.dr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dr.BackColor = System.Drawing.Color.White
        Me.dr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.dr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dr.FormattingEnabled = True
        Me.dr.Location = New System.Drawing.Point(208, 53)
        Me.dr.Name = "dr"
        Me.dr.Size = New System.Drawing.Size(112, 24)
        Me.dr.TabIndex = 104
        Me.dr.TabStop = False
        '
        'cr
        '
        Me.cr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cr.BackColor = System.Drawing.Color.White
        Me.cr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cr.FormattingEnabled = True
        Me.cr.Location = New System.Drawing.Point(459, 53)
        Me.cr.Name = "cr"
        Me.cr.Size = New System.Drawing.Size(112, 24)
        Me.cr.TabIndex = 105
        Me.cr.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "OPenintg Dr"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(368, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "OPenintg Cr"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Select Group:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "OPenintg Cr"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(138, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "OPenintg Dr"
        '
        'crTo
        '
        Me.crTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.crTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.crTo.BackColor = System.Drawing.Color.White
        Me.crTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.crTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crTo.FormattingEnabled = True
        Me.crTo.Location = New System.Drawing.Point(480, 160)
        Me.crTo.Name = "crTo"
        Me.crTo.Size = New System.Drawing.Size(112, 24)
        Me.crTo.TabIndex = 110
        Me.crTo.TabStop = False
        '
        'drTo
        '
        Me.drTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.drTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.drTo.BackColor = System.Drawing.Color.White
        Me.drTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.drTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drTo.FormattingEnabled = True
        Me.drTo.Location = New System.Drawing.Point(228, 154)
        Me.drTo.Name = "drTo"
        Me.drTo.Size = New System.Drawing.Size(112, 24)
        Me.drTo.TabIndex = 109
        Me.drTo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.cmbacheadname)
        Me.GroupBox1.Controls.Add(Me.crTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbacheadcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.drTo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbcodeto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbaccto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dr)
        Me.GroupBox1.Controls.Add(Me.cr)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 214)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DataTransfer"
        '
        'frmHeadDataTransfereToAnotherHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(647, 332)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbsubgrpname)
        Me.Controls.Add(Me.cmbgrpname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHeadDataTransfereToAnotherHead"
        Me.Text = "frmHeadDataTransfereToAnotherHead"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbaccto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcodeto As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dr As System.Windows.Forms.ComboBox
    Friend WithEvents cr As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents crTo As System.Windows.Forms.ComboBox
    Friend WithEvents drTo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
