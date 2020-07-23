<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChicksratemaster
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
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbAREA = New System.Windows.Forms.ComboBox
        Me.Cmbitemname = New System.Windows.Forms.ComboBox
        Me.dthatchdate = New System.Windows.Forms.DateTimePicker
        Me.dgItemOpening = New System.Windows.Forms.DataGridView
        Me.txtRate = New System.Windows.Forms.ComboBox
        Me.lblID = New System.Windows.Forms.Label
        Me.Cmbarecode = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbHatchery = New System.Windows.Forms.ComboBox
        Me.CmbState = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Txtqty = New System.Windows.Forms.TextBox
        Me.Txtmort = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.dgItemOpening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(10, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 46)
        Me.Panel1.TabIndex = 7
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Hatch Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Select Area :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Item Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Rate :"
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
        Me.Label6.Size = New System.Drawing.Size(437, 31)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Chick Rate Master"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CmbAREA
        '
        Me.CmbAREA.BackColor = System.Drawing.Color.White
        Me.CmbAREA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAREA.FormattingEnabled = True
        Me.CmbAREA.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.CmbAREA.Location = New System.Drawing.Point(120, 34)
        Me.CmbAREA.MaxLength = 150
        Me.CmbAREA.Name = "CmbAREA"
        Me.CmbAREA.Size = New System.Drawing.Size(226, 24)
        Me.CmbAREA.TabIndex = 0
        '
        'Cmbitemname
        '
        Me.Cmbitemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbitemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbitemname.BackColor = System.Drawing.Color.White
        Me.Cmbitemname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbitemname.FormattingEnabled = True
        Me.Cmbitemname.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.Cmbitemname.Location = New System.Drawing.Point(120, 63)
        Me.Cmbitemname.MaxLength = 30
        Me.Cmbitemname.Name = "Cmbitemname"
        Me.Cmbitemname.Size = New System.Drawing.Size(226, 24)
        Me.Cmbitemname.TabIndex = 1
        '
        'dthatchdate
        '
        Me.dthatchdate.CustomFormat = "dd/MMM/yy"
        Me.dthatchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dthatchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthatchdate.Location = New System.Drawing.Point(120, 92)
        Me.dthatchdate.Name = "dthatchdate"
        Me.dthatchdate.Size = New System.Drawing.Size(105, 22)
        Me.dthatchdate.TabIndex = 2
        '
        'dgItemOpening
        '
        Me.dgItemOpening.AllowUserToAddRows = False
        Me.dgItemOpening.AllowUserToOrderColumns = True
        Me.dgItemOpening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemOpening.Location = New System.Drawing.Point(6, 252)
        Me.dgItemOpening.Name = "dgItemOpening"
        Me.dgItemOpening.Size = New System.Drawing.Size(427, 280)
        Me.dgItemOpening.TabIndex = 8
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.White
        Me.txtRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.FormattingEnabled = True
        Me.txtRate.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.txtRate.Location = New System.Drawing.Point(120, 118)
        Me.txtRate.MaxLength = 30
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(129, 24)
        Me.txtRate.TabIndex = 4
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(382, 38)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 16)
        Me.lblID.TabIndex = 84
        Me.lblID.Text = "id"
        '
        'Cmbarecode
        '
        Me.Cmbarecode.BackColor = System.Drawing.Color.White
        Me.Cmbarecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbarecode.FormattingEnabled = True
        Me.Cmbarecode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.Cmbarecode.Location = New System.Drawing.Point(119, 35)
        Me.Cmbarecode.MaxLength = 150
        Me.Cmbarecode.Name = "Cmbarecode"
        Me.Cmbarecode.Size = New System.Drawing.Size(226, 24)
        Me.Cmbarecode.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Qty :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Hatchery :"
        '
        'CmbHatchery
        '
        Me.CmbHatchery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbHatchery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbHatchery.BackColor = System.Drawing.Color.White
        Me.CmbHatchery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHatchery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHatchery.FormattingEnabled = True
        Me.CmbHatchery.Items.AddRange(New Object() {"JABALPUR", "RAIPUR", "HAJIPUR", "WEST BENGAL"})
        Me.CmbHatchery.Location = New System.Drawing.Point(298, 92)
        Me.CmbHatchery.MaxLength = 30
        Me.CmbHatchery.Name = "CmbHatchery"
        Me.CmbHatchery.Size = New System.Drawing.Size(133, 24)
        Me.CmbHatchery.TabIndex = 3
        '
        'CmbState
        '
        Me.CmbState.BackColor = System.Drawing.Color.White
        Me.CmbState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbState.FormattingEnabled = True
        Me.CmbState.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.CmbState.Location = New System.Drawing.Point(121, 33)
        Me.CmbState.MaxLength = 150
        Me.CmbState.Name = "CmbState"
        Me.CmbState.Size = New System.Drawing.Size(226, 24)
        Me.CmbState.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-3, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 16)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Tran. Mortality :"
        '
        'Txtqty
        '
        Me.Txtqty.Location = New System.Drawing.Point(121, 150)
        Me.Txtqty.Name = "Txtqty"
        Me.Txtqty.Size = New System.Drawing.Size(128, 20)
        Me.Txtqty.TabIndex = 5
        '
        'Txtmort
        '
        Me.Txtmort.Location = New System.Drawing.Point(121, 177)
        Me.Txtmort.Name = "Txtmort"
        Me.Txtmort.Size = New System.Drawing.Size(128, 20)
        Me.Txtmort.TabIndex = 6
        '
        'frmChicksratemaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(437, 534)
        Me.Controls.Add(Me.Txtmort)
        Me.Controls.Add(Me.Txtqty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbHatchery)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.dgItemOpening)
        Me.Controls.Add(Me.dthatchdate)
        Me.Controls.Add(Me.Cmbitemname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmbAREA)
        Me.Controls.Add(Me.Cmbarecode)
        Me.Controls.Add(Me.CmbState)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChicksratemaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chicks Rate Master"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgItemOpening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbAREA As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbitemname As System.Windows.Forms.ComboBox
    Friend WithEvents dthatchdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgItemOpening As System.Windows.Forms.DataGridView
    Friend WithEvents txtRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Cmbarecode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbHatchery As System.Windows.Forms.ComboBox
    Friend WithEvents CmbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Txtmort As System.Windows.Forms.TextBox
End Class
