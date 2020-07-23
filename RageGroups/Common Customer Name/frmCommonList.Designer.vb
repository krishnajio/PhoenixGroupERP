<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommonList
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
        Me.lblgroupsuffix = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblgroupname = New System.Windows.Forms.ComboBox
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbCmpCompany = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCmpcode = New System.Windows.Forms.ComboBox
        Me.cmbCmpCodeTO = New System.Windows.Forms.ComboBox
        Me.cmpCompantTo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgaccounthead = New System.Windows.Forms.DataGridView
        Me.acheadcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.accname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subgrp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.crlimit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.crdays = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.intrule = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.intrate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inttype = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnDosprint = New System.Windows.Forms.Button
        Me.btnshow = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txno_of_char = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnShow1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(972, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Account Heads List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Visible = False
        '
        'lblgroupsuffix
        '
        Me.lblgroupsuffix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.lblgroupsuffix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lblgroupsuffix.BackColor = System.Drawing.Color.White
        Me.lblgroupsuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lblgroupsuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgroupsuffix.FormattingEnabled = True
        Me.lblgroupsuffix.Location = New System.Drawing.Point(616, 37)
        Me.lblgroupsuffix.Name = "lblgroupsuffix"
        Me.lblgroupsuffix.Size = New System.Drawing.Size(44, 21)
        Me.lblgroupsuffix.TabIndex = 82
        Me.lblgroupsuffix.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = " Select Area:"
        Me.Label13.Visible = False
        '
        'lblgroupname
        '
        Me.lblgroupname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.lblgroupname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lblgroupname.BackColor = System.Drawing.Color.White
        Me.lblgroupname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lblgroupname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgroupname.FormattingEnabled = True
        Me.lblgroupname.Items.AddRange(New Object() {"CUSTOMER", "PARTY"})
        Me.lblgroupname.Location = New System.Drawing.Point(491, 37)
        Me.lblgroupname.Name = "lblgroupname"
        Me.lblgroupname.Size = New System.Drawing.Size(119, 21)
        Me.lblgroupname.TabIndex = 81
        Me.lblgroupname.Visible = False
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(126, 35)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(191, 21)
        Me.cmbAreaName.TabIndex = 79
        Me.cmbAreaName.Visible = False
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(323, 36)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(44, 21)
        Me.cmbAreaCode.TabIndex = 78
        Me.cmbAreaCode.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Select Group :"
        Me.Label2.Visible = False
        '
        'cmbCmpCompany
        '
        Me.cmbCmpCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCmpCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCmpCompany.BackColor = System.Drawing.Color.White
        Me.cmbCmpCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCmpCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCmpCompany.FormattingEnabled = True
        Me.cmbCmpCompany.Items.AddRange(New Object() {"CUSTOMER", "PARTY"})
        Me.cmbCmpCompany.Location = New System.Drawing.Point(127, 34)
        Me.cmbCmpCompany.Name = "cmbCmpCompany"
        Me.cmbCmpCompany.Size = New System.Drawing.Size(359, 21)
        Me.cmbCmpCompany.TabIndex = 84
        Me.cmbCmpCompany.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Select Company :"
        Me.Label3.Visible = False
        '
        'cmbCmpcode
        '
        Me.cmbCmpcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCmpcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCmpcode.BackColor = System.Drawing.Color.White
        Me.cmbCmpcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCmpcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCmpcode.FormattingEnabled = True
        Me.cmbCmpcode.Items.AddRange(New Object() {"CUSTOMER", "PARTY"})
        Me.cmbCmpcode.Location = New System.Drawing.Point(491, 37)
        Me.cmbCmpcode.Name = "cmbCmpcode"
        Me.cmbCmpcode.Size = New System.Drawing.Size(116, 21)
        Me.cmbCmpcode.TabIndex = 85
        Me.cmbCmpcode.Visible = False
        '
        'cmbCmpCodeTO
        '
        Me.cmbCmpCodeTO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCmpCodeTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCmpCodeTO.BackColor = System.Drawing.Color.White
        Me.cmbCmpCodeTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCmpCodeTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCmpCodeTO.FormattingEnabled = True
        Me.cmbCmpCodeTO.Items.AddRange(New Object() {"CUSTOMER", "PARTY"})
        Me.cmbCmpCodeTO.Location = New System.Drawing.Point(501, 37)
        Me.cmbCmpCodeTO.Name = "cmbCmpCodeTO"
        Me.cmbCmpCodeTO.Size = New System.Drawing.Size(119, 21)
        Me.cmbCmpCodeTO.TabIndex = 88
        Me.cmbCmpCodeTO.Visible = False
        '
        'cmpCompantTo
        '
        Me.cmpCompantTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmpCompantTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmpCompantTo.BackColor = System.Drawing.Color.White
        Me.cmpCompantTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmpCompantTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmpCompantTo.FormattingEnabled = True
        Me.cmpCompantTo.Items.AddRange(New Object() {"CUSTOMER", "PARTY"})
        Me.cmpCompantTo.Location = New System.Drawing.Point(127, 32)
        Me.cmpCompantTo.Name = "cmpCompantTo"
        Me.cmpCompantTo.Size = New System.Drawing.Size(359, 21)
        Me.cmpCompantTo.TabIndex = 87
        Me.cmpCompantTo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Compare To:"
        Me.Label4.Visible = False
        '
        'dgaccounthead
        '
        Me.dgaccounthead.AllowUserToAddRows = False
        Me.dgaccounthead.AllowUserToDeleteRows = False
        Me.dgaccounthead.AllowUserToOrderColumns = True
        Me.dgaccounthead.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgaccounthead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaccounthead.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acheadcode, Me.accname, Me.grp, Me.subgrp, Me.dr, Me.cr, Me.crlimit, Me.crdays, Me.intrule, Me.intrate, Me.inttype})
        Me.dgaccounthead.Location = New System.Drawing.Point(928, 60)
        Me.dgaccounthead.Name = "dgaccounthead"
        Me.dgaccounthead.ReadOnly = True
        Me.dgaccounthead.Size = New System.Drawing.Size(19, 22)
        Me.dgaccounthead.TabIndex = 91
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
        'btnDosprint
        '
        Me.btnDosprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDosprint.Location = New System.Drawing.Point(707, 31)
        Me.btnDosprint.Name = "btnDosprint"
        Me.btnDosprint.Size = New System.Drawing.Size(82, 22)
        Me.btnDosprint.TabIndex = 90
        Me.btnDosprint.Text = "&Dos Print"
        Me.btnDosprint.UseVisualStyleBackColor = True
        Me.btnDosprint.Visible = False
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(626, 35)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(86, 21)
        Me.btnshow.TabIndex = 89
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        Me.btnshow.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(666, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 15)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "No. of Charchter To Match"
        Me.Label5.Visible = False
        '
        'txno_of_char
        '
        Me.txno_of_char.Location = New System.Drawing.Point(847, 34)
        Me.txno_of_char.Name = "txno_of_char"
        Me.txno_of_char.Size = New System.Drawing.Size(100, 20)
        Me.txno_of_char.TabIndex = 93
        Me.txno_of_char.Text = "10"
        Me.txno_of_char.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Enter Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(126, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(265, 20)
        Me.txtName.TabIndex = 95
        '
        'btnShow1
        '
        Me.btnShow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow1.Location = New System.Drawing.Point(397, 33)
        Me.btnShow1.Name = "btnShow1"
        Me.btnShow1.Size = New System.Drawing.Size(75, 23)
        Me.btnShow1.TabIndex = 96
        Me.btnShow1.Text = "&Show"
        Me.btnShow1.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 120)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(972, 626)
        Me.CrystalReportViewer1.TabIndex = 97
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frmCommonList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(972, 746)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnShow1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txno_of_char)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgaccounthead)
        Me.Controls.Add(Me.btnDosprint)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.cmbCmpCodeTO)
        Me.Controls.Add(Me.cmpCompantTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCmpcode)
        Me.Controls.Add(Me.cmbCmpCompany)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblgroupsuffix)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblgroupname)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCommonList"
        Me.Text = "frmCommonList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblgroupsuffix As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblgroupname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCmpCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCmpcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCmpCodeTO As System.Windows.Forms.ComboBox
    Friend WithEvents cmpCompantTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgaccounthead As System.Windows.Forms.DataGridView
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
    Friend WithEvents btnDosprint As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txno_of_char As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnShow1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
