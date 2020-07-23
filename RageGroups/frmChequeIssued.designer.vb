<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeIssued
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnprintvoucher = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnaddmultiple = New System.Windows.Forms.Button
        Me.btnprintall = New System.Windows.Forms.Button
        Me.btnaddsingle = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.chqsetup = New System.Windows.Forms.PageSetupDialog
        Me.chqprintpreview = New System.Windows.Forms.PrintDialog
        Me.chqdocument = New System.Drawing.Printing.PrintDocument
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblchequeno = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtIssuedate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbacchead = New System.Windows.Forms.ComboBox
        Me.cmbacccode = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtchqno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtchequedate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbpartyacchead = New System.Windows.Forms.ComboBox
        Me.cmbpartyacccode = New System.Windows.Forms.ComboBox
        Me.cmbfavourof = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtddchrgper = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtddcharges = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtservicetax = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtrectamt = New System.Windows.Forms.TextBox
        Me.btnchangerepno = New System.Windows.Forms.Button
        Me.rdParty = New System.Windows.Forms.RadioButton
        Me.rdother = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtsertaxper = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblrecno = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblvouno = New System.Windows.Forms.Label
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(762, 31)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Cheque Issued"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.btnprintvoucher)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.btnaddmultiple)
        Me.Panel2.Controls.Add(Me.btnprintall)
        Me.Panel2.Controls.Add(Me.btnaddsingle)
        Me.Panel2.Controls.Add(Me.btnprint)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Location = New System.Drawing.Point(47, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(643, 42)
        Me.Panel2.TabIndex = 140
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(568, 3)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(57, 31)
        Me.btnclose.TabIndex = 13
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnprintvoucher
        '
        Me.btnprintvoucher.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprintvoucher.Location = New System.Drawing.Point(503, 3)
        Me.btnprintvoucher.Name = "btnprintvoucher"
        Me.btnprintvoucher.Size = New System.Drawing.Size(61, 31)
        Me.btnprintvoucher.TabIndex = 12
        Me.btnprintvoucher.Text = "&Reset"
        Me.btnprintvoucher.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(284, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(70, 31)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnaddmultiple
        '
        Me.btnaddmultiple.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddmultiple.Location = New System.Drawing.Point(102, 3)
        Me.btnaddmultiple.Name = "btnaddmultiple"
        Me.btnaddmultiple.Size = New System.Drawing.Size(105, 31)
        Me.btnaddmultiple.TabIndex = 14
        Me.btnaddmultiple.Text = "Add &Multiple"
        Me.btnaddmultiple.UseVisualStyleBackColor = True
        '
        'btnprintall
        '
        Me.btnprintall.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprintall.Location = New System.Drawing.Point(422, 3)
        Me.btnprintall.Name = "btnprintall"
        Me.btnprintall.Size = New System.Drawing.Size(75, 31)
        Me.btnprintall.TabIndex = 10
        Me.btnprintall.Text = "&Print All"
        Me.btnprintall.UseVisualStyleBackColor = True
        '
        'btnaddsingle
        '
        Me.btnaddsingle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddsingle.Location = New System.Drawing.Point(5, 3)
        Me.btnaddsingle.Name = "btnaddsingle"
        Me.btnaddsingle.Size = New System.Drawing.Size(92, 31)
        Me.btnaddsingle.TabIndex = 13
        Me.btnaddsingle.Text = "&Add Single"
        Me.btnaddsingle.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(360, 3)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(57, 31)
        Me.btnprint.TabIndex = 9
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(210, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(70, 31)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'chqprintpreview
        '
        Me.chqprintpreview.UseEXDialog = True
        '
        'chqdocument
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'lblchequeno
        '
        Me.lblchequeno.AutoSize = True
        Me.lblchequeno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchequeno.Location = New System.Drawing.Point(547, 121)
        Me.lblchequeno.Name = "lblchequeno"
        Me.lblchequeno.Size = New System.Drawing.Size(13, 16)
        Me.lblchequeno.TabIndex = 145
        Me.lblchequeno.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Issue Date :"
        '
        'dtIssuedate
        '
        Me.dtIssuedate.CustomFormat = "dd/MMM/yy"
        Me.dtIssuedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIssuedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtIssuedate.Location = New System.Drawing.Point(117, 40)
        Me.dtIssuedate.Name = "dtIssuedate"
        Me.dtIssuedate.Size = New System.Drawing.Size(117, 20)
        Me.dtIssuedate.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Bank Name:"
        '
        'cmbacchead
        '
        Me.cmbacchead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacchead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacchead.BackColor = System.Drawing.Color.White
        Me.cmbacchead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacchead.FormattingEnabled = True
        Me.cmbacchead.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacchead.Location = New System.Drawing.Point(117, 66)
        Me.cmbacchead.MaxLength = 50
        Me.cmbacchead.Name = "cmbacchead"
        Me.cmbacchead.Size = New System.Drawing.Size(264, 21)
        Me.cmbacchead.TabIndex = 2
        '
        'cmbacccode
        '
        Me.cmbacccode.BackColor = System.Drawing.Color.White
        Me.cmbacccode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacccode.FormattingEnabled = True
        Me.cmbacccode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbacccode.Location = New System.Drawing.Point(117, 66)
        Me.cmbacccode.MaxLength = 50
        Me.cmbacccode.Name = "cmbacccode"
        Me.cmbacccode.Size = New System.Drawing.Size(117, 21)
        Me.cmbacccode.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Cheque No:"
        '
        'txtchqno
        '
        Me.txtchqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchqno.Location = New System.Drawing.Point(117, 92)
        Me.txtchqno.MaxLength = 15
        Me.txtchqno.Name = "txtchqno"
        Me.txtchqno.Size = New System.Drawing.Size(117, 20)
        Me.txtchqno.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Cheque  Date :"
        '
        'dtchequedate
        '
        Me.dtchequedate.CustomFormat = "dd/MMM/yy"
        Me.dtchequedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtchequedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtchequedate.Location = New System.Drawing.Point(337, 91)
        Me.dtchequedate.Name = "dtchequedate"
        Me.dtchequedate.Size = New System.Drawing.Size(104, 22)
        Me.dtchequedate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Party Name:"
        '
        'cmbpartyacchead
        '
        Me.cmbpartyacchead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbpartyacchead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbpartyacchead.BackColor = System.Drawing.Color.White
        Me.cmbpartyacchead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpartyacchead.FormattingEnabled = True
        Me.cmbpartyacchead.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbpartyacchead.Location = New System.Drawing.Point(117, 117)
        Me.cmbpartyacchead.MaxLength = 50
        Me.cmbpartyacchead.Name = "cmbpartyacchead"
        Me.cmbpartyacchead.Size = New System.Drawing.Size(264, 21)
        Me.cmbpartyacchead.TabIndex = 6
        '
        'cmbpartyacccode
        '
        Me.cmbpartyacccode.BackColor = System.Drawing.Color.White
        Me.cmbpartyacccode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpartyacccode.FormattingEnabled = True
        Me.cmbpartyacccode.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbpartyacccode.Location = New System.Drawing.Point(117, 117)
        Me.cmbpartyacccode.MaxLength = 50
        Me.cmbpartyacccode.Name = "cmbpartyacccode"
        Me.cmbpartyacccode.Size = New System.Drawing.Size(117, 21)
        Me.cmbpartyacccode.TabIndex = 5
        '
        'cmbfavourof
        '
        Me.cmbfavourof.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbfavourof.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbfavourof.BackColor = System.Drawing.Color.White
        Me.cmbfavourof.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfavourof.FormattingEnabled = True
        Me.cmbfavourof.Items.AddRange(New Object() {"Cash", "Cheque", "D.D."})
        Me.cmbfavourof.Location = New System.Drawing.Point(384, 117)
        Me.cmbfavourof.MaxLength = 50
        Me.cmbfavourof.Name = "cmbfavourof"
        Me.cmbfavourof.Size = New System.Drawing.Size(366, 21)
        Me.cmbfavourof.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(502, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Favour of "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Amount:"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(117, 144)
        Me.txtamount.MaxLength = 18
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(115, 20)
        Me.txtamount.TabIndex = 8
        Me.txtamount.Text = "0.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "DD Chrg %:"
        '
        'txtddchrgper
        '
        Me.txtddchrgper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtddchrgper.Location = New System.Drawing.Point(117, 169)
        Me.txtddchrgper.MaxLength = 6
        Me.txtddchrgper.Name = "txtddchrgper"
        Me.txtddchrgper.Size = New System.Drawing.Size(115, 20)
        Me.txtddchrgper.TabIndex = 9
        Me.txtddchrgper.Text = "0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(238, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "DD Charges:"
        '
        'txtddcharges
        '
        Me.txtddcharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtddcharges.Location = New System.Drawing.Point(335, 171)
        Me.txtddcharges.MaxLength = 18
        Me.txtddcharges.Name = "txtddcharges"
        Me.txtddcharges.Size = New System.Drawing.Size(105, 20)
        Me.txtddcharges.TabIndex = 10
        Me.txtddcharges.Text = "0.0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(238, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 15)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Service Tax:"
        '
        'txtservicetax
        '
        Me.txtservicetax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservicetax.Location = New System.Drawing.Point(335, 197)
        Me.txtservicetax.MaxLength = 18
        Me.txtservicetax.Name = "txtservicetax"
        Me.txtservicetax.Size = New System.Drawing.Size(105, 20)
        Me.txtservicetax.TabIndex = 11
        Me.txtservicetax.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(446, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 15)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Rect. Amount :"
        '
        'txtrectamt
        '
        Me.txtrectamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrectamt.Location = New System.Drawing.Point(550, 197)
        Me.txtrectamt.MaxLength = 18
        Me.txtrectamt.Name = "txtrectamt"
        Me.txtrectamt.Size = New System.Drawing.Size(121, 20)
        Me.txtrectamt.TabIndex = 12
        Me.txtrectamt.Text = "0.0"
        '
        'btnchangerepno
        '
        Me.btnchangerepno.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnchangerepno.Location = New System.Drawing.Point(677, 191)
        Me.btnchangerepno.Name = "btnchangerepno"
        Me.btnchangerepno.Size = New System.Drawing.Size(58, 34)
        Me.btnchangerepno.TabIndex = 141
        Me.btnchangerepno.Text = "&Change Rect. ID"
        Me.btnchangerepno.UseVisualStyleBackColor = True
        '
        'rdParty
        '
        Me.rdParty.AutoSize = True
        Me.rdParty.Checked = True
        Me.rdParty.ForeColor = System.Drawing.Color.Crimson
        Me.rdParty.Location = New System.Drawing.Point(7, 10)
        Me.rdParty.Name = "rdParty"
        Me.rdParty.Size = New System.Drawing.Size(57, 19)
        Me.rdParty.TabIndex = 0
        Me.rdParty.TabStop = True
        Me.rdParty.Text = "Party"
        Me.rdParty.UseVisualStyleBackColor = True
        '
        'rdother
        '
        Me.rdother.AutoSize = True
        Me.rdother.ForeColor = System.Drawing.Color.Crimson
        Me.rdother.Location = New System.Drawing.Point(68, 10)
        Me.rdother.Name = "rdother"
        Me.rdother.Size = New System.Drawing.Size(60, 19)
        Me.rdother.TabIndex = 1
        Me.rdother.Text = "Other"
        Me.rdother.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdother)
        Me.GroupBox1.Controls.Add(Me.rdParty)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(240, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 30)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 199)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "Service Tax %:"
        '
        'txtsertaxper
        '
        Me.txtsertaxper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsertaxper.Location = New System.Drawing.Point(117, 195)
        Me.txtsertaxper.MaxLength = 6
        Me.txtsertaxper.Name = "txtsertaxper"
        Me.txtsertaxper.Size = New System.Drawing.Size(115, 20)
        Me.txtsertaxper.TabIndex = 143
        Me.txtsertaxper.Text = "0.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(532, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 15)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "Receipt No. :"
        '
        'lblrecno
        '
        Me.lblrecno.AutoSize = True
        Me.lblrecno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecno.Location = New System.Drawing.Point(636, 36)
        Me.lblrecno.Name = "lblrecno"
        Me.lblrecno.Size = New System.Drawing.Size(13, 16)
        Me.lblrecno.TabIndex = 147
        Me.lblrecno.Text = "-"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(610, 97)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(150, 19)
        Me.CheckBox1.TabIndex = 148
        Me.CheckBox1.Text = "Add New Gen Head"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(611, 75)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(156, 19)
        Me.CheckBox2.TabIndex = 149
        Me.CheckBox2.Text = "Add New Party Head"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(532, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 15)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Voucher No :"
        '
        'lblvouno
        '
        Me.lblvouno.AutoSize = True
        Me.lblvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblvouno.Location = New System.Drawing.Point(636, 55)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.Size = New System.Drawing.Size(11, 13)
        Me.lblvouno.TabIndex = 151
        Me.lblvouno.Text = "-"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(391, 41)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(32, 20)
        Me.CheckBox3.TabIndex = 152
        Me.CheckBox3.Text = "-"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'frmChequeIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(762, 281)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblrecno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtsertaxper)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnchangerepno)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtrectamt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtservicetax)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtddcharges)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtddchrgper)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbfavourof)
        Me.Controls.Add(Me.cmbpartyacchead)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtchequedate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtchqno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtIssuedate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblchequeno)
        Me.Controls.Add(Me.cmbpartyacccode)
        Me.Controls.Add(Me.cmbacchead)
        Me.Controls.Add(Me.cmbacccode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChequeIssued"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChequeIssued"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnaddmultiple As System.Windows.Forms.Button
    Friend WithEvents btnprintall As System.Windows.Forms.Button
    Friend WithEvents btnaddsingle As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnprintvoucher As System.Windows.Forms.Button
    Friend WithEvents chqsetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents chqprintpreview As System.Windows.Forms.PrintDialog
    Friend WithEvents chqdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblchequeno As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtIssuedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbacchead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacccode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtchqno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtchequedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbpartyacchead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbpartyacccode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfavourof As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtddchrgper As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtddcharges As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtservicetax As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtrectamt As System.Windows.Forms.TextBox
    Friend WithEvents btnchangerepno As System.Windows.Forms.Button
    Friend WithEvents rdParty As System.Windows.Forms.RadioButton
    Friend WithEvents rdother As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtsertaxper As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblrecno As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblvouno As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
End Class
