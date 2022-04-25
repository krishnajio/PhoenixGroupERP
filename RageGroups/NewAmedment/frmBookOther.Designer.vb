<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookOther
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.btngroup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listgrp = New System.Windows.Forms.CheckedListBox()
        Me.dgBook = New System.Windows.Forms.DataGridView()
        Me.acc_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acc_head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.narration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chqno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vouchertype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vouno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dramt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cramt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdOnscreen = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdPrint = New System.Windows.Forms.RadioButton()
        Me.btndosprint = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 74)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(970, 504)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(121, 44)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 20)
        Me.dtfrom.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Book Date From :"
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
        Me.Label1.Size = New System.Drawing.Size(970, 31)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Day Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(721, 37)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(82, 28)
        Me.btnclose.TabIndex = 75
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(494, 39)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(61, 28)
        Me.btnshow.TabIndex = 74
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'btngroup
        '
        Me.btngroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngroup.Location = New System.Drawing.Point(390, 39)
        Me.btngroup.Name = "btngroup"
        Me.btngroup.Size = New System.Drawing.Size(101, 28)
        Me.btngroup.TabIndex = 73
        Me.btngroup.Text = "&Voucher type"
        Me.btngroup.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.listgrp)
        Me.Panel1.Controls.Add(Me.dgBook)
        Me.Panel1.Location = New System.Drawing.Point(412, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 280)
        Me.Panel1.TabIndex = 76
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(197, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 24)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "&X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Voucher Type"
        '
        'listgrp
        '
        Me.listgrp.CheckOnClick = True
        Me.listgrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listgrp.FormattingEnabled = True
        Me.listgrp.Location = New System.Drawing.Point(8, 40)
        Me.listgrp.Name = "listgrp"
        Me.listgrp.Size = New System.Drawing.Size(208, 225)
        Me.listgrp.TabIndex = 75
        '
        'dgBook
        '
        Me.dgBook.AllowUserToAddRows = False
        Me.dgBook.AllowUserToDeleteRows = False
        Me.dgBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acc_code, Me.acc_head, Me.narration, Me.chqno, Me.Vouchertype, Me.vdate, Me.vouno, Me.dramt, Me.cramt})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBook.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgBook.Location = New System.Drawing.Point(-313, 180)
        Me.dgBook.Name = "dgBook"
        Me.dgBook.ReadOnly = True
        Me.dgBook.Size = New System.Drawing.Size(801, 391)
        Me.dgBook.TabIndex = 2
        '
        'acc_code
        '
        Me.acc_code.DataPropertyName = "Acc_code"
        Me.acc_code.HeaderText = "A\c Code"
        Me.acc_code.Name = "acc_code"
        Me.acc_code.ReadOnly = True
        Me.acc_code.Width = 75
        '
        'acc_head
        '
        Me.acc_head.DataPropertyName = "Acc_name"
        Me.acc_head.HeaderText = "A\c Head"
        Me.acc_head.Name = "acc_head"
        Me.acc_head.ReadOnly = True
        Me.acc_head.Width = 125
        '
        'narration
        '
        Me.narration.DataPropertyName = "Narration"
        Me.narration.HeaderText = "Narration"
        Me.narration.Name = "narration"
        Me.narration.ReadOnly = True
        Me.narration.Width = 200
        '
        'chqno
        '
        Me.chqno.DataPropertyName = "Cheque No"
        Me.chqno.HeaderText = "Cheque No"
        Me.chqno.Name = "chqno"
        Me.chqno.ReadOnly = True
        Me.chqno.Width = 75
        '
        'Vouchertype
        '
        Me.Vouchertype.DataPropertyName = "Vtype"
        Me.Vouchertype.HeaderText = "Voucher Type"
        Me.Vouchertype.Name = "Vouchertype"
        Me.Vouchertype.ReadOnly = True
        '
        'vdate
        '
        Me.vdate.DataPropertyName = "Vdate"
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = "-"
        Me.vdate.DefaultCellStyle = DataGridViewCellStyle1
        Me.vdate.HeaderText = "Voucher Date"
        Me.vdate.Name = "vdate"
        Me.vdate.ReadOnly = True
        Me.vdate.Width = 90
        '
        'vouno
        '
        Me.vouno.DataPropertyName = "Vouno"
        Me.vouno.HeaderText = "Voucher No."
        Me.vouno.Name = "vouno"
        Me.vouno.ReadOnly = True
        '
        'dramt
        '
        Me.dramt.DataPropertyName = "dramt"
        Me.dramt.HeaderText = "Dr Amount"
        Me.dramt.Name = "dramt"
        Me.dramt.ReadOnly = True
        '
        'cramt
        '
        Me.cramt.DataPropertyName = "cramt"
        Me.cramt.HeaderText = "Cr Amount"
        Me.cramt.Name = "cramt"
        Me.cramt.ReadOnly = True
        '
        'rdOnscreen
        '
        Me.rdOnscreen.AutoSize = True
        Me.rdOnscreen.Checked = True
        Me.rdOnscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOnscreen.Location = New System.Drawing.Point(6, 10)
        Me.rdOnscreen.Name = "rdOnscreen"
        Me.rdOnscreen.Size = New System.Drawing.Size(70, 19)
        Me.rdOnscreen.TabIndex = 0
        Me.rdOnscreen.TabStop = True
        Me.rdOnscreen.Text = "Screen"
        Me.rdOnscreen.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdPrint)
        Me.GroupBox2.Controls.Add(Me.rdOnscreen)
        Me.GroupBox2.Location = New System.Drawing.Point(231, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 34)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        '
        'rdPrint
        '
        Me.rdPrint.AutoSize = True
        Me.rdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPrint.Location = New System.Drawing.Point(82, 8)
        Me.rdPrint.Name = "rdPrint"
        Me.rdPrint.Size = New System.Drawing.Size(55, 19)
        Me.rdPrint.TabIndex = 1
        Me.rdPrint.Text = "Print"
        Me.rdPrint.UseVisualStyleBackColor = True
        '
        'btndosprint
        '
        Me.btndosprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndosprint.Location = New System.Drawing.Point(629, 38)
        Me.btndosprint.Name = "btndosprint"
        Me.btndosprint.Size = New System.Drawing.Size(87, 28)
        Me.btndosprint.TabIndex = 103
        Me.btndosprint.Text = "&DOS Print"
        Me.btndosprint.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Enabled = False
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(561, 39)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(62, 28)
        Me.btnprint.TabIndex = 104
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'frmBookOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(970, 578)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btndosprint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btngroup)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBookOther"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents btngroup As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents listgrp As System.Windows.Forms.CheckedListBox
    Friend WithEvents rdOnscreen As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdPrint As System.Windows.Forms.RadioButton
    Friend WithEvents dgBook As System.Windows.Forms.DataGridView
    Friend WithEvents acc_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acc_head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chqno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vouchertype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vouno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndosprint As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
