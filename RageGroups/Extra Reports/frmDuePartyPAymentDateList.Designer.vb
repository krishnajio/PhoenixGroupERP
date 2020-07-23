<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDuePartyPAymentDateList
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        Me.voutype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtdate = New System.Windows.Forms.DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btngroup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1244, 30)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Due Payment Date Report"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btngroup)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DtpTo)
        Me.GroupBox1.Controls.Add(Me.voutype)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnshow)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtdate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1244, 55)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(733, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "To :"
        '
        'DtpTo
        '
        Me.DtpTo.CustomFormat = "dd/MMM/yyyy"
        Me.DtpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpTo.Location = New System.Drawing.Point(774, 19)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(104, 20)
        Me.DtpTo.TabIndex = 210
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Location = New System.Drawing.Point(107, 21)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(137, 21)
        Me.voutype.TabIndex = 208
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Voucher Type:"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(888, 18)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(68, 23)
        Me.btnshow.TabIndex = 156
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(546, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "From :"
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(598, 19)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(104, 20)
        Me.dtdate.TabIndex = 154
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 85)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1244, 497)
        Me.CrystalReportViewer1.TabIndex = 153
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btngroup
        '
        Me.btngroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngroup.Location = New System.Drawing.Point(250, 13)
        Me.btngroup.Name = "btngroup"
        Me.btngroup.Size = New System.Drawing.Size(101, 28)
        Me.btngroup.TabIndex = 212
        Me.btngroup.Text = "&Voucher type"
        Me.btngroup.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.listgrp)
        Me.Panel1.Controls.Add(Me.dgBook)
        Me.Panel1.Location = New System.Drawing.Point(170, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 288)
        Me.Panel1.TabIndex = 154
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Voucher Type"
        '
        'listgrp
        '
        Me.listgrp.CheckOnClick = True
        Me.listgrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listgrp.FormattingEnabled = True
        Me.listgrp.Location = New System.Drawing.Point(3, 36)
        Me.listgrp.Name = "listgrp"
        Me.listgrp.Size = New System.Drawing.Size(208, 225)
        Me.listgrp.TabIndex = 75
        '
        'dgBook
        '
        Me.dgBook.AllowUserToAddRows = False
        Me.dgBook.AllowUserToDeleteRows = False
        Me.dgBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acc_code, Me.acc_head, Me.narration, Me.chqno, Me.Vouchertype, Me.vdate, Me.vouno, Me.dramt, Me.cramt})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBook.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle7.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle7.NullValue = "-"
        Me.vdate.DefaultCellStyle = DataGridViewCellStyle7
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
        'frmDuePartyPAymentDateList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1244, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDuePartyPAymentDateList"
        Me.Text = "frmDuePartyPAymentDateList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngroup As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listgrp As System.Windows.Forms.CheckedListBox
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
End Class
