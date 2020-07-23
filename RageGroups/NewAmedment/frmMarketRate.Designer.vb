<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarketRate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarketRate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.cmbPrdUnit = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbBill = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbPOno = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtitamnae = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(656, 43)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Market Rate Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(101, 73)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(418, 24)
        Me.cmbacheadname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Party Name:"
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(525, 74)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(119, 21)
        Me.cmbacheadcode.TabIndex = 2
        '
        'cmbPrdUnit
        '
        Me.cmbPrdUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPrdUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPrdUnit.BackColor = System.Drawing.Color.White
        Me.cmbPrdUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrdUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrdUnit.FormattingEnabled = True
        Me.cmbPrdUnit.Location = New System.Drawing.Point(101, 46)
        Me.cmbPrdUnit.Name = "cmbPrdUnit"
        Me.cmbPrdUnit.Size = New System.Drawing.Size(215, 21)
        Me.cmbPrdUnit.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label18.Location = New System.Drawing.Point(30, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 15)
        Me.Label18.TabIndex = 225
        Me.Label18.Text = "For. Unit:"
        '
        'cmbBill
        '
        Me.cmbBill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBill.BackColor = System.Drawing.Color.White
        Me.cmbBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBill.FormattingEnabled = True
        Me.cmbBill.Location = New System.Drawing.Point(101, 103)
        Me.cmbBill.Name = "cmbBill"
        Me.cmbBill.Size = New System.Drawing.Size(418, 24)
        Me.cmbBill.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Bill No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "PO No:"
        '
        'cmbPOno
        '
        Me.cmbPOno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPOno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPOno.BackColor = System.Drawing.Color.White
        Me.cmbPOno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPOno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPOno.FormattingEnabled = True
        Me.cmbPOno.Location = New System.Drawing.Point(101, 133)
        Me.cmbPOno.Name = "cmbPOno"
        Me.cmbPOno.Size = New System.Drawing.Size(418, 24)
        Me.cmbPOno.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(-3, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 230
        Me.Label5.Text = "Product Name:"
        '
        'txtitamnae
        '
        Me.txtitamnae.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitamnae.Location = New System.Drawing.Point(103, 169)
        Me.txtitamnae.Name = "txtitamnae"
        Me.txtitamnae.Size = New System.Drawing.Size(541, 20)
        Me.txtitamnae.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(103, 195)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(541, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Rate:"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(101, 221)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(118, 53)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "&Update"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label7.Location = New System.Drawing.Point(345, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(311, 15)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "* Product Name and Rate seperated by comma "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(225, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMarketRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(656, 276)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtitamnae)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbPOno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbBill)
        Me.Controls.Add(Me.cmbPrdUnit)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMarketRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMarketRate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPrdUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbBill As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPOno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtitamnae As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
