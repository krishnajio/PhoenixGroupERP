<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralacchead
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.dgaccounthead = New System.Windows.Forms.DataGridView()
        Me.acheadcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subgrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExpCode = New System.Windows.Forms.Button()
        Me.txtacheadname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbgrpname = New System.Windows.Forms.ComboBox()
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblacheadcode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbdrcr = New System.Windows.Forms.ComboBox()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.radioall = New System.Windows.Forms.RadioButton()
        Me.radiogrp = New System.Windows.Forms.RadioButton()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbgroupsuffix = New System.Windows.Forms.ComboBox()
        Me.cmbAreaName = New System.Windows.Forms.ComboBox()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbExpCode = New System.Windows.Forms.ComboBox()
        Me.radiosubgrp = New System.Windows.Forms.RadioButton()
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnmodify
        '
        Me.btnmodify.Enabled = False
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(124, 3)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(69, 30)
        Me.btnmodify.TabIndex = 9
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(60, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(60, 30)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(276, 4)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(59, 30)
        Me.btnreset.TabIndex = 11
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(199, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(72, 30)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'dgaccounthead
        '
        Me.dgaccounthead.AllowUserToAddRows = False
        Me.dgaccounthead.AllowUserToDeleteRows = False
        Me.dgaccounthead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaccounthead.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acheadcode, Me.accname, Me.grp, Me.subgrp, Me.dr, Me.cr})
        Me.dgaccounthead.Location = New System.Drawing.Point(12, 304)
        Me.dgaccounthead.Name = "dgaccounthead"
        Me.dgaccounthead.ReadOnly = True
        Me.dgaccounthead.Size = New System.Drawing.Size(806, 319)
        Me.dgaccounthead.TabIndex = 28
        '
        'acheadcode
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acheadcode.DefaultCellStyle = DataGridViewCellStyle1
        Me.acheadcode.HeaderText = "Account Head Code"
        Me.acheadcode.Name = "acheadcode"
        Me.acheadcode.ReadOnly = True
        '
        'accname
        '
        Me.accname.HeaderText = "Account Head Name"
        Me.accname.Name = "accname"
        Me.accname.ReadOnly = True
        Me.accname.Width = 300
        '
        'grp
        '
        Me.grp.HeaderText = "Group"
        Me.grp.Name = "grp"
        Me.grp.ReadOnly = True
        Me.grp.Width = 150
        '
        'subgrp
        '
        Me.subgrp.HeaderText = "Sub Group"
        Me.subgrp.Name = "subgrp"
        Me.subgrp.ReadOnly = True
        Me.subgrp.Width = 80
        '
        'dr
        '
        Me.dr.HeaderText = "Opening Dr"
        Me.dr.Name = "dr"
        Me.dr.ReadOnly = True
        Me.dr.Width = 50
        '
        'cr
        '
        Me.cr.HeaderText = "Opening Cr"
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Width = 50
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(340, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(58, 30)
        Me.btnclose.TabIndex = 12
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnExpCode)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(133, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 43)
        Me.Panel1.TabIndex = 8
        '
        'btnExpCode
        '
        Me.btnExpCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpCode.Location = New System.Drawing.Point(404, 6)
        Me.btnExpCode.Name = "btnExpCode"
        Me.btnExpCode.Size = New System.Drawing.Size(162, 30)
        Me.btnExpCode.TabIndex = 13
        Me.btnExpCode.Text = "&Update Exp Code"
        Me.btnExpCode.UseVisualStyleBackColor = True
        '
        'txtacheadname
        '
        Me.txtacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacheadname.Location = New System.Drawing.Point(243, 35)
        Me.txtacheadname.MaxLength = 30
        Me.txtacheadname.Name = "txtacheadname"
        Me.txtacheadname.Size = New System.Drawing.Size(559, 20)
        Me.txtacheadname.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Account Head Code :"
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
        Me.Label1.Size = New System.Drawing.Size(837, 31)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "General Account Heads"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Select Group :"
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(243, 59)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(474, 21)
        Me.cmbgrpname.TabIndex = 2
        '
        'cmbsubgrpname
        '
        Me.cmbsubgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsubgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubgrpname.BackColor = System.Drawing.Color.White
        Me.cmbsubgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsubgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubgrpname.FormattingEnabled = True
        Me.cmbsubgrpname.Location = New System.Drawing.Point(243, 84)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(474, 21)
        Me.cmbsubgrpname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Select Sub Group :"
        '
        'lblacheadcode
        '
        Me.lblacheadcode.AutoSize = True
        Me.lblacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacheadcode.Location = New System.Drawing.Point(248, 134)
        Me.lblacheadcode.Name = "lblacheadcode"
        Me.lblacheadcode.Size = New System.Drawing.Size(13, 16)
        Me.lblacheadcode.TabIndex = 35
        Me.lblacheadcode.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Account Head Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Opening Balance :"
        '
        'cmbdrcr
        '
        Me.cmbdrcr.BackColor = System.Drawing.Color.White
        Me.cmbdrcr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdrcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdrcr.FormattingEnabled = True
        Me.cmbdrcr.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbdrcr.Location = New System.Drawing.Point(439, 150)
        Me.cmbdrcr.Name = "cmbdrcr"
        Me.cmbdrcr.Size = New System.Drawing.Size(79, 21)
        Me.cmbdrcr.TabIndex = 7
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(242, 150)
        Me.txtamt.MaxLength = 40
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(191, 20)
        Me.txtamt.TabIndex = 6
        '
        'radioall
        '
        Me.radioall.AutoSize = True
        Me.radioall.Checked = True
        Me.radioall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioall.Location = New System.Drawing.Point(23, 278)
        Me.radioall.Name = "radioall"
        Me.radioall.Size = New System.Drawing.Size(41, 20)
        Me.radioall.TabIndex = 38
        Me.radioall.TabStop = True
        Me.radioall.Text = "All"
        Me.radioall.UseVisualStyleBackColor = True
        '
        'radiogrp
        '
        Me.radiogrp.AutoSize = True
        Me.radiogrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiogrp.Location = New System.Drawing.Point(70, 279)
        Me.radiogrp.Name = "radiogrp"
        Me.radiogrp.Size = New System.Drawing.Size(97, 20)
        Me.radiogrp.TabIndex = 39
        Me.radiogrp.Text = "Group Wise"
        Me.radiogrp.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(389, 276)
        Me.txtsearch.MaxLength = 40
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(212, 22)
        Me.txtsearch.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Se&arch :"
        '
        'cmbgroupsuffix
        '
        Me.cmbgroupsuffix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgroupsuffix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroupsuffix.BackColor = System.Drawing.Color.White
        Me.cmbgroupsuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgroupsuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroupsuffix.FormattingEnabled = True
        Me.cmbgroupsuffix.Location = New System.Drawing.Point(723, 59)
        Me.cmbgroupsuffix.Name = "cmbgroupsuffix"
        Me.cmbgroupsuffix.Size = New System.Drawing.Size(79, 21)
        Me.cmbgroupsuffix.TabIndex = 3
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(242, 110)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(191, 21)
        Me.cmbAreaName.TabIndex = 2
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(439, 111)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(79, 21)
        Me.cmbAreaCode.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(148, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = " Select Area:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(83, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 15)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = " Select Expenses Code"
        '
        'cmbExpCode
        '
        Me.cmbExpCode.AutoCompleteCustomSource.AddRange(New String() {" FEED CONSUMPTION ", " MEDICINE CONSUMPTION ", " PACKING MAT. CONSUM. ", " FARM EXPS ", " HATCHERY EXPS. ", " ELECTRICITY ", " HATCHING CHARGES ", " CHICKS,EGGS, & BIRDS TRANSPORTATION ", " SALARY & WAGES ", " OTHER EXPS ", " CAR RUNN & MAINT ", " BANK INTEREST & CHARGES ", " PARENT CHICKS PURCHASE "})
        Me.cmbExpCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbExpCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbExpCode.BackColor = System.Drawing.Color.White
        Me.cmbExpCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpCode.FormattingEnabled = True
        Me.cmbExpCode.Items.AddRange(New Object() {" FEED CONSUMPTION ", " MEDICINE CONSUMPTION ", " PACKING MAT. CONSUM. ", " FARM EXPS ", " HATCHERY EXPS. ", " ELECTRICITY ", " HATCHING CHARGES ", " CHICKS,EGGS, & BIRDS TRANSPORTATION ", " SALARY & WAGES ", " OTHER EXPS ", " CAR RUNN & MAINT ", " BANK INTEREST & CHARGES ", " PARENT CHICKS PURCHASE "})
        Me.cmbExpCode.Location = New System.Drawing.Point(242, 176)
        Me.cmbExpCode.Name = "cmbExpCode"
        Me.cmbExpCode.Size = New System.Drawing.Size(276, 21)
        Me.cmbExpCode.TabIndex = 72
        '
        'radiosubgrp
        '
        Me.radiosubgrp.AutoSize = True
        Me.radiosubgrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiosubgrp.Location = New System.Drawing.Point(173, 279)
        Me.radiosubgrp.Name = "radiosubgrp"
        Me.radiosubgrp.Size = New System.Drawing.Size(124, 20)
        Me.radiosubgrp.TabIndex = 73
        Me.radiosubgrp.Text = "Sub Group Wise"
        Me.radiosubgrp.UseVisualStyleBackColor = True
        '
        'frmGeneralacchead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(837, 646)
        Me.Controls.Add(Me.radiosubgrp)
        Me.Controls.Add(Me.cmbExpCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.cmbgroupsuffix)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.radiogrp)
        Me.Controls.Add(Me.radioall)
        Me.Controls.Add(Me.txtamt)
        Me.Controls.Add(Me.cmbdrcr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblacheadcode)
        Me.Controls.Add(Me.cmbsubgrpname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbgrpname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgaccounthead)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtacheadname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmGeneralacchead"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Account Heads"
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents dgaccounthead As System.Windows.Forms.DataGridView
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtacheadname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblacheadcode As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbdrcr As System.Windows.Forms.ComboBox
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents radioall As System.Windows.Forms.RadioButton
    Friend WithEvents radiogrp As System.Windows.Forms.RadioButton
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbgroupsuffix As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents acheadcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subgrp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbExpCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnExpCode As System.Windows.Forms.Button
    Friend WithEvents radiosubgrp As System.Windows.Forms.RadioButton
End Class
