<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartyaccount
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.cmbdrcr = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblacheadcode = New System.Windows.Forms.Label()
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgaccounthead = New System.Windows.Forms.DataGridView()
        Me.acheadcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subgrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crlimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crdays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.intrule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.intrate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inttype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GSTNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDosprint = New System.Windows.Forms.Button()
        Me.btnmodify = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtacheadname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtIFSCCode = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBankAccountNumber = New System.Windows.Forms.TextBox()
        Me.lblgroupsuffix = New System.Windows.Forms.ComboBox()
        Me.cmbintrule = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblgroupname = New System.Windows.Forms.ComboBox()
        Me.lblgroupsuffix1 = New System.Windows.Forms.Label()
        Me.cmbAreaName = New System.Windows.Forms.ComboBox()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtintrate = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcrdays = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtcrlimit = New System.Windows.Forms.TextBox()
        Me.lblgroupname1 = New System.Windows.Forms.Label()
        Me.cmbintruleid = New System.Windows.Forms.ComboBox()
        Me.txtinttype = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtGstIn = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEmailID = New System.Windows.Forms.TextBox()
        Me.txtremark1 = New System.Windows.Forms.ComboBox()
        Me.txtremark2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpanno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtphno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtstate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Se&arch Party Account Head :"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(398, 404)
        Me.txtsearch.MaxLength = 40
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(292, 21)
        Me.txtsearch.TabIndex = 58
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(158, 126)
        Me.txtamt.MaxLength = 40
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(91, 20)
        Me.txtamt.TabIndex = 3
        '
        'cmbdrcr
        '
        Me.cmbdrcr.BackColor = System.Drawing.Color.White
        Me.cmbdrcr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdrcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdrcr.FormattingEnabled = True
        Me.cmbdrcr.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbdrcr.Location = New System.Drawing.Point(255, 126)
        Me.cmbdrcr.Name = "cmbdrcr"
        Me.cmbdrcr.Size = New System.Drawing.Size(61, 21)
        Me.cmbdrcr.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 15)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Opening Balance :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 15)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Account Head Name :"
        '
        'lblacheadcode
        '
        Me.lblacheadcode.AutoSize = True
        Me.lblacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacheadcode.Location = New System.Drawing.Point(158, 86)
        Me.lblacheadcode.Name = "lblacheadcode"
        Me.lblacheadcode.Size = New System.Drawing.Size(13, 16)
        Me.lblacheadcode.TabIndex = 53
        Me.lblacheadcode.Text = "-"
        '
        'cmbsubgrpname
        '
        Me.cmbsubgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsubgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubgrpname.BackColor = System.Drawing.Color.White
        Me.cmbsubgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsubgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubgrpname.FormattingEnabled = True
        Me.cmbsubgrpname.Location = New System.Drawing.Point(157, 60)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(263, 21)
        Me.cmbsubgrpname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 15)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Select Sub Group :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Select Group :"
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
        Me.Label1.Size = New System.Drawing.Size(1075, 31)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Party Account Heads"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Account Head Code :"
        '
        'dgaccounthead
        '
        Me.dgaccounthead.AllowUserToAddRows = False
        Me.dgaccounthead.AllowUserToDeleteRows = False
        Me.dgaccounthead.AllowUserToOrderColumns = True
        Me.dgaccounthead.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgaccounthead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaccounthead.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acheadcode, Me.accname, Me.grp, Me.subgrp, Me.dr, Me.cr, Me.crlimit, Me.crdays, Me.intrule, Me.intrate, Me.inttype, Me.GSTNO})
        Me.dgaccounthead.Location = New System.Drawing.Point(-14, 479)
        Me.dgaccounthead.Name = "dgaccounthead"
        Me.dgaccounthead.ReadOnly = True
        Me.dgaccounthead.Size = New System.Drawing.Size(1079, 258)
        Me.dgaccounthead.TabIndex = 50
        '
        'acheadcode
        '
        Me.acheadcode.HeaderText = "Account Head Code"
        Me.acheadcode.Name = "acheadcode"
        Me.acheadcode.ReadOnly = True
        Me.acheadcode.Width = 80
        '
        'accname
        '
        Me.accname.HeaderText = "Account Head Name"
        Me.accname.Name = "accname"
        Me.accname.ReadOnly = True
        Me.accname.Width = 160
        '
        'grp
        '
        Me.grp.HeaderText = "Group"
        Me.grp.Name = "grp"
        Me.grp.ReadOnly = True
        Me.grp.Width = 80
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
        Me.dr.Width = 80
        '
        'cr
        '
        Me.cr.HeaderText = "Opening Cr"
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Width = 80
        '
        'crlimit
        '
        Me.crlimit.HeaderText = "Cr. Limit"
        Me.crlimit.Name = "crlimit"
        Me.crlimit.ReadOnly = True
        Me.crlimit.Width = 80
        '
        'crdays
        '
        Me.crdays.HeaderText = "Cr. Days"
        Me.crdays.Name = "crdays"
        Me.crdays.ReadOnly = True
        Me.crdays.Width = 50
        '
        'intrule
        '
        Me.intrule.HeaderText = "Interest Rule"
        Me.intrule.Name = "intrule"
        Me.intrule.ReadOnly = True
        Me.intrule.Width = 80
        '
        'intrate
        '
        Me.intrate.HeaderText = "Rate of Interest (%)"
        Me.intrate.Name = "intrate"
        Me.intrate.ReadOnly = True
        Me.intrate.Width = 50
        '
        'inttype
        '
        Me.inttype.HeaderText = "Int Type"
        Me.inttype.Name = "inttype"
        Me.inttype.ReadOnly = True
        Me.inttype.Width = 50
        '
        'GSTNO
        '
        Me.GSTNO.HeaderText = "GSTNo"
        Me.GSTNO.Name = "GSTNO"
        Me.GSTNO.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnDosprint)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(9, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 43)
        Me.Panel1.TabIndex = 13
        '
        'btnDosprint
        '
        Me.btnDosprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDosprint.Location = New System.Drawing.Point(562, 5)
        Me.btnDosprint.Name = "btnDosprint"
        Me.btnDosprint.Size = New System.Drawing.Size(82, 31)
        Me.btnDosprint.TabIndex = 20
        Me.btnDosprint.Text = "&Dos Print"
        Me.btnDosprint.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Enabled = False
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(197, 4)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(94, 31)
        Me.btnmodify.TabIndex = 16
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(474, 4)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(82, 31)
        Me.btnclose.TabIndex = 19
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(109, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(86, 31)
        Me.btnsave.TabIndex = 15
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(389, 4)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(81, 31)
        Me.btnreset.TabIndex = 18
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Enabled = False
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(293, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(93, 31)
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtacheadname
        '
        Me.txtacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacheadname.Location = New System.Drawing.Point(157, 102)
        Me.txtacheadname.MaxLength = 50
        Me.txtacheadname.Name = "txtacheadname"
        Me.txtacheadname.Size = New System.Drawing.Size(368, 20)
        Me.txtacheadname.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtBranch)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtIFSCCode)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtBankName)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtBankAccountNumber)
        Me.GroupBox1.Controls.Add(Me.lblgroupsuffix)
        Me.GroupBox1.Controls.Add(Me.cmbintrule)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblgroupname)
        Me.GroupBox1.Controls.Add(Me.lblgroupsuffix1)
        Me.GroupBox1.Controls.Add(Me.cmbAreaName)
        Me.GroupBox1.Controls.Add(Me.cmbAreaCode)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtintrate)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtcrdays)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtcrlimit)
        Me.GroupBox1.Controls.Add(Me.lblgroupname1)
        Me.GroupBox1.Controls.Add(Me.txtamt)
        Me.GroupBox1.Controls.Add(Me.cmbdrcr)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblacheadcode)
        Me.GroupBox1.Controls.Add(Me.cmbsubgrpname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtacheadname)
        Me.GroupBox1.Controls.Add(Me.cmbintruleid)
        Me.GroupBox1.Controls.Add(Me.txtinttype)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 361)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Head's Detail"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(92, 330)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 15)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Branch:"
        '
        'txtBranch
        '
        Me.txtBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranch.Location = New System.Drawing.Point(157, 329)
        Me.txtBranch.MaxLength = 50
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(277, 20)
        Me.txtBranch.TabIndex = 83
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(70, 304)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 15)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "IFSC Code:"
        '
        'txtIFSCCode
        '
        Me.txtIFSCCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIFSCCode.Location = New System.Drawing.Point(157, 303)
        Me.txtIFSCCode.MaxLength = 50
        Me.txtIFSCCode.Name = "txtIFSCCode"
        Me.txtIFSCCode.Size = New System.Drawing.Size(277, 20)
        Me.txtIFSCCode.TabIndex = 81
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(63, 278)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 15)
        Me.Label23.TabIndex = 80
        Me.Label23.Text = "Bank Name:"
        '
        'txtBankName
        '
        Me.txtBankName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(157, 277)
        Me.txtBankName.MaxLength = 50
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(277, 20)
        Me.txtBankName.TabIndex = 79
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 252)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 15)
        Me.Label22.TabIndex = 78
        Me.Label22.Text = "Bank A/c Number:"
        '
        'txtBankAccountNumber
        '
        Me.txtBankAccountNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankAccountNumber.Location = New System.Drawing.Point(157, 251)
        Me.txtBankAccountNumber.MaxLength = 50
        Me.txtBankAccountNumber.Name = "txtBankAccountNumber"
        Me.txtBankAccountNumber.Size = New System.Drawing.Size(277, 20)
        Me.txtBankAccountNumber.TabIndex = 77
        '
        'lblgroupsuffix
        '
        Me.lblgroupsuffix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.lblgroupsuffix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lblgroupsuffix.BackColor = System.Drawing.Color.White
        Me.lblgroupsuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lblgroupsuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgroupsuffix.FormattingEnabled = True
        Me.lblgroupsuffix.Location = New System.Drawing.Point(426, 40)
        Me.lblgroupsuffix.Name = "lblgroupsuffix"
        Me.lblgroupsuffix.Size = New System.Drawing.Size(44, 21)
        Me.lblgroupsuffix.TabIndex = 76
        '
        'cmbintrule
        '
        Me.cmbintrule.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbintrule.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbintrule.BackColor = System.Drawing.Color.White
        Me.cmbintrule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbintrule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbintrule.FormattingEnabled = True
        Me.cmbintrule.Location = New System.Drawing.Point(157, 198)
        Me.cmbintrule.Name = "cmbintrule"
        Me.cmbintrule.Size = New System.Drawing.Size(249, 21)
        Me.cmbintrule.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(64, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = " Select Area:"
        '
        'lblgroupname
        '
        Me.lblgroupname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.lblgroupname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lblgroupname.BackColor = System.Drawing.Color.White
        Me.lblgroupname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgroupname.FormattingEnabled = True
        Me.lblgroupname.Location = New System.Drawing.Point(157, 38)
        Me.lblgroupname.Name = "lblgroupname"
        Me.lblgroupname.Size = New System.Drawing.Size(263, 21)
        Me.lblgroupname.TabIndex = 75
        '
        'lblgroupsuffix1
        '
        Me.lblgroupsuffix1.AutoSize = True
        Me.lblgroupsuffix1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblgroupsuffix1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblgroupsuffix1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgroupsuffix1.Location = New System.Drawing.Point(237, 41)
        Me.lblgroupsuffix1.Name = "lblgroupsuffix1"
        Me.lblgroupsuffix1.Size = New System.Drawing.Size(25, 15)
        Me.lblgroupsuffix1.TabIndex = 68
        Me.lblgroupsuffix1.Text = "PA"
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(157, 16)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(263, 21)
        Me.cmbAreaName.TabIndex = 67
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(426, 16)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(44, 21)
        Me.cmbAreaCode.TabIndex = 66
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(83, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 15)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "PinCode :"
        '
        'txtintrate
        '
        Me.txtintrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtintrate.Location = New System.Drawing.Point(158, 221)
        Me.txtintrate.MaxLength = 40
        Me.txtintrate.Name = "txtintrate"
        Me.txtintrate.Size = New System.Drawing.Size(91, 20)
        Me.txtintrate.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(55, 201)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 15)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Interest Rule :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 15)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Prop.  /Firm Name:"
        '
        'txtcrdays
        '
        Me.txtcrdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrdays.Location = New System.Drawing.Point(158, 173)
        Me.txtcrdays.MaxLength = 40
        Me.txtcrdays.Name = "txtcrdays"
        Me.txtcrdays.Size = New System.Drawing.Size(276, 20)
        Me.txtcrdays.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(52, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 15)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Section Code :"
        '
        'txtcrlimit
        '
        Me.txtcrlimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrlimit.Location = New System.Drawing.Point(158, 149)
        Me.txtcrlimit.MaxLength = 40
        Me.txtcrlimit.Name = "txtcrlimit"
        Me.txtcrlimit.Size = New System.Drawing.Size(91, 20)
        Me.txtcrlimit.TabIndex = 4
        '
        'lblgroupname1
        '
        Me.lblgroupname1.AutoSize = True
        Me.lblgroupname1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblgroupname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblgroupname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgroupname1.Location = New System.Drawing.Point(157, 41)
        Me.lblgroupname1.Name = "lblgroupname1"
        Me.lblgroupname1.Size = New System.Drawing.Size(50, 15)
        Me.lblgroupname1.TabIndex = 56
        Me.lblgroupname1.Text = "PARTY"
        '
        'cmbintruleid
        '
        Me.cmbintruleid.BackColor = System.Drawing.Color.White
        Me.cmbintruleid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbintruleid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbintruleid.FormattingEnabled = True
        Me.cmbintruleid.Items.AddRange(New Object() {"Dr", "Cr"})
        Me.cmbintruleid.Location = New System.Drawing.Point(306, 194)
        Me.cmbintruleid.Name = "cmbintruleid"
        Me.cmbintruleid.Size = New System.Drawing.Size(61, 21)
        Me.cmbintruleid.TabIndex = 72
        '
        'txtinttype
        '
        Me.txtinttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinttype.Location = New System.Drawing.Point(255, 221)
        Me.txtinttype.MaxLength = 40
        Me.txtinttype.Name = "txtinttype"
        Me.txtinttype.ReadOnly = True
        Me.txtinttype.Size = New System.Drawing.Size(152, 20)
        Me.txtinttype.TabIndex = 74
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.txtGstIn)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtEmailID)
        Me.GroupBox2.Controls.Add(Me.txtremark1)
        Me.GroupBox2.Controls.Add(Me.txtremark2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtpanno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtphno)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtstate)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcity)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(572, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 313)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Other Details"
        '
        'txtGstIn
        '
        Me.txtGstIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGstIn.Location = New System.Drawing.Point(107, 198)
        Me.txtGstIn.MaxLength = 100
        Me.txtGstIn.Name = "txtGstIn"
        Me.txtGstIn.Size = New System.Drawing.Size(275, 20)
        Me.txtGstIn.TabIndex = 69
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(31, 199)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 15)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "GST IN:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(35, 278)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 15)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Email ID:"
        '
        'txtEmailID
        '
        Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailID.Location = New System.Drawing.Point(108, 277)
        Me.txtEmailID.MaxLength = 40
        Me.txtEmailID.Name = "txtEmailID"
        Me.txtEmailID.Size = New System.Drawing.Size(274, 20)
        Me.txtEmailID.TabIndex = 66
        '
        'txtremark1
        '
        Me.txtremark1.FormattingEnabled = True
        Me.txtremark1.Items.AddRange(New Object() {"NO DISCOUNT", "DISCOUNT"})
        Me.txtremark1.Location = New System.Drawing.Point(107, 224)
        Me.txtremark1.Name = "txtremark1"
        Me.txtremark1.Size = New System.Drawing.Size(275, 24)
        Me.txtremark1.TabIndex = 66
        '
        'txtremark2
        '
        Me.txtremark2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremark2.Location = New System.Drawing.Point(107, 251)
        Me.txtremark2.MaxLength = 40
        Me.txtremark2.Name = "txtremark2"
        Me.txtremark2.Size = New System.Drawing.Size(275, 20)
        Me.txtremark2.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 15)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "TIN NO. :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Remark 1 :"
        '
        'txtpanno
        '
        Me.txtpanno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpanno.Location = New System.Drawing.Point(107, 173)
        Me.txtpanno.MaxLength = 40
        Me.txtpanno.Name = "txtpanno"
        Me.txtpanno.Size = New System.Drawing.Size(275, 20)
        Me.txtpanno.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "PAN No. :"
        '
        'txtphno
        '
        Me.txtphno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphno.Location = New System.Drawing.Point(107, 148)
        Me.txtphno.MaxLength = 40
        Me.txtphno.Name = "txtphno"
        Me.txtphno.Size = New System.Drawing.Size(275, 20)
        Me.txtphno.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Phone No. :"
        '
        'txtstate
        '
        Me.txtstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstate.Location = New System.Drawing.Point(107, 123)
        Me.txtstate.MaxLength = 40
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(275, 20)
        Me.txtstate.TabIndex = 10
        Me.txtstate.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "State :"
        '
        'txtcity
        '
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(107, 97)
        Me.txtcity.MaxLength = 40
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(275, 20)
        Me.txtcity.TabIndex = 9
        Me.txtcity.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(64, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 15)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "City :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 15)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Address :"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(107, 22)
        Me.txtaddress.MaxLength = 30
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtaddress.Size = New System.Drawing.Size(275, 72)
        Me.txtaddress.TabIndex = 8
        Me.txtaddress.Text = "-"
        '
        'frmPartyaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1075, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgaccounthead)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPartyaccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Party Account Heads"
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents cmbdrcr As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblacheadcode As System.Windows.Forms.Label
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgaccounthead As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents txtacheadname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtcrlimit As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcrdays As System.Windows.Forms.TextBox
    Friend WithEvents cmbintrule As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtintrate As System.Windows.Forms.TextBox
    Friend WithEvents txtstate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtphno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtpanno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtremark2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbintruleid As System.Windows.Forms.ComboBox
    Public WithEvents lblgroupname1 As System.Windows.Forms.Label
    Public WithEvents lblgroupsuffix1 As System.Windows.Forms.Label
    Friend WithEvents txtinttype As System.Windows.Forms.TextBox
    Friend WithEvents txtremark1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblgroupname As System.Windows.Forms.ComboBox
    Friend WithEvents lblgroupsuffix As System.Windows.Forms.ComboBox
    Friend WithEvents btnDosprint As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEmailID As System.Windows.Forms.TextBox
    Friend WithEvents txtGstIn As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents acheadcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subgrp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crlimit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crdays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents intrule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents intrate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inttype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GSTNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtBankAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtIFSCCode As System.Windows.Forms.TextBox
End Class
