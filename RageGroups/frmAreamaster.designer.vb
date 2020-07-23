<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreamaster
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cmbareacode = New System.Windows.Forms.ComboBox
        Me.Cmbareaname = New System.Windows.Forms.ComboBox
        Me.CmbState = New System.Windows.Forms.ComboBox
        Me.dgItemOpening = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        CType(Me.dgItemOpening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(17, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 46)
        Me.Panel1.TabIndex = 35
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(249, 3)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(78, 31)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(167, 4)
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
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(7, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 31)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Area :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "State:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(432, 31)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Area Master"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cmbareacode
        '
        Me.Cmbareacode.BackColor = System.Drawing.Color.White
        Me.Cmbareacode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbareacode.FormattingEnabled = True
        Me.Cmbareacode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.Cmbareacode.Location = New System.Drawing.Point(98, 37)
        Me.Cmbareacode.MaxLength = 1
        Me.Cmbareacode.Name = "Cmbareacode"
        Me.Cmbareacode.Size = New System.Drawing.Size(94, 24)
        Me.Cmbareacode.TabIndex = 74
        '
        'Cmbareaname
        '
        Me.Cmbareaname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbareaname.BackColor = System.Drawing.Color.White
        Me.Cmbareaname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbareaname.FormattingEnabled = True
        Me.Cmbareaname.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.Cmbareaname.Location = New System.Drawing.Point(198, 37)
        Me.Cmbareaname.MaxLength = 50
        Me.Cmbareaname.Name = "Cmbareaname"
        Me.Cmbareaname.Size = New System.Drawing.Size(222, 24)
        Me.Cmbareaname.TabIndex = 2
        '
        'CmbState
        '
        Me.CmbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbState.BackColor = System.Drawing.Color.White
        Me.CmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbState.FormattingEnabled = True
        Me.CmbState.Items.AddRange(New Object() {"Andaman & Nicobar", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chandigarh", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "New Delhi", "Orissa", "Puducherry", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Dadra and Nagar Haveli", "Daman and Diu", "Lakshadweep"})
        Me.CmbState.Location = New System.Drawing.Point(98, 67)
        Me.CmbState.MaxLength = 30
        Me.CmbState.Name = "CmbState"
        Me.CmbState.Size = New System.Drawing.Size(318, 24)
        Me.CmbState.TabIndex = 3
        '
        'dgItemOpening
        '
        Me.dgItemOpening.AllowUserToAddRows = False
        Me.dgItemOpening.AllowUserToOrderColumns = True
        Me.dgItemOpening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemOpening.Location = New System.Drawing.Point(5, 149)
        Me.dgItemOpening.Name = "dgItemOpening"
        Me.dgItemOpening.Size = New System.Drawing.Size(427, 585)
        Me.dgItemOpening.TabIndex = 83
        '
        'frmAreamaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(432, 746)
        Me.Controls.Add(Me.dgItemOpening)
        Me.Controls.Add(Me.CmbState)
        Me.Controls.Add(Me.Cmbareaname)
        Me.Controls.Add(Me.Cmbareacode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmAreamaster"
        Me.Text = "frmstockopening"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgItemOpening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmbareaname As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbareacode As System.Windows.Forms.ComboBox
    Friend WithEvents CmbState As System.Windows.Forms.ComboBox
    Friend WithEvents dgItemOpening As System.Windows.Forms.DataGridView
End Class
