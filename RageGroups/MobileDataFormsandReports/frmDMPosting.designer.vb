﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDMPosting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBankCode = New System.Windows.Forms.ComboBox()
        Me.cmbbankHead = New System.Windows.Forms.ComboBox()
        Me.cmbVoucherType = New System.Windows.Forms.ComboBox()
        Me.dtpPostingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtAreaCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Auth = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbInsCode = New System.Windows.Forms.ComboBox()
        Me.cmbInsHead = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdTcsCode = New System.Windows.Forms.ComboBox()
        Me.cmbTcsHead = New System.Windows.Forms.ComboBox()
        Me.dgDetials = New System.Windows.Forms.DataGridView()
        Me.ChkisCm = New System.Windows.Forms.CheckBox()
        Me.ChkisDm = New System.Windows.Forms.CheckBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1326, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DM Post To Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBankCode
        '
        Me.cmbBankCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBankCode.FormattingEnabled = True
        Me.cmbBankCode.Location = New System.Drawing.Point(607, 73)
        Me.cmbBankCode.Name = "cmbBankCode"
        Me.cmbBankCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbBankCode.TabIndex = 40
        '
        'cmbbankHead
        '
        Me.cmbbankHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbbankHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbankHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankHead.FormattingEnabled = True
        Me.cmbbankHead.Location = New System.Drawing.Point(734, 73)
        Me.cmbbankHead.Name = "cmbbankHead"
        Me.cmbbankHead.Size = New System.Drawing.Size(308, 24)
        Me.cmbbankHead.TabIndex = 39
        '
        'cmbVoucherType
        '
        Me.cmbVoucherType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbVoucherType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVoucherType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVoucherType.FormattingEnabled = True
        Me.cmbVoucherType.Location = New System.Drawing.Point(265, 74)
        Me.cmbVoucherType.Name = "cmbVoucherType"
        Me.cmbVoucherType.Size = New System.Drawing.Size(236, 24)
        Me.cmbVoucherType.TabIndex = 38
        '
        'dtpPostingDate
        '
        Me.dtpPostingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPostingDate.Location = New System.Drawing.Point(139, 72)
        Me.dtpPostingDate.Name = "dtpPostingDate"
        Me.dtpPostingDate.Size = New System.Drawing.Size(120, 26)
        Me.dtpPostingDate.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Posting Date :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1048, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "POST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL AREA", "SELECTED AREA"})
        Me.ComboBox1.Location = New System.Drawing.Point(7, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(814, 40)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton1.TabIndex = 33
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "On Screen"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(733, 34)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 26)
        Me.btnShow.TabIndex = 32
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtAreaCode
        '
        Me.txtAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaCode.Location = New System.Drawing.Point(265, 40)
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(125, 26)
        Me.txtAreaCode.TabIndex = 30
        Me.txtAreaCode.Text = "GSPR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Area :"
        '
        'dg
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auth})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle8
        Me.dg.Location = New System.Drawing.Point(22, 164)
        Me.dg.Name = "dg"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dg.Size = New System.Drawing.Size(1292, 343)
        Me.dg.TabIndex = 41
        '
        'Auth
        '
        Me.Auth.FalseValue = "0"
        Me.Auth.HeaderText = "Auth"
        Me.Auth.Name = "Auth"
        Me.Auth.TrueValue = "1"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(896, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 26)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(7, 165)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1292, 343)
        Me.CrystalReportViewer1.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(507, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Cr Head:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Ins. Head:"
        '
        'cmbInsCode
        '
        Me.cmbInsCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInsCode.FormattingEnabled = True
        Me.cmbInsCode.Location = New System.Drawing.Point(138, 108)
        Me.cmbInsCode.Name = "cmbInsCode"
        Me.cmbInsCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbInsCode.TabIndex = 51
        '
        'cmbInsHead
        '
        Me.cmbInsHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbInsHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbInsHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInsHead.FormattingEnabled = True
        Me.cmbInsHead.Location = New System.Drawing.Point(265, 108)
        Me.cmbInsHead.Name = "cmbInsHead"
        Me.cmbInsHead.Size = New System.Drawing.Size(236, 24)
        Me.cmbInsHead.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(507, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Tcs. Head:"
        '
        'cmdTcsCode
        '
        Me.cmdTcsCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTcsCode.FormattingEnabled = True
        Me.cmdTcsCode.Location = New System.Drawing.Point(607, 108)
        Me.cmdTcsCode.Name = "cmdTcsCode"
        Me.cmdTcsCode.Size = New System.Drawing.Size(121, 24)
        Me.cmdTcsCode.TabIndex = 54
        '
        'cmbTcsHead
        '
        Me.cmbTcsHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTcsHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTcsHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTcsHead.FormattingEnabled = True
        Me.cmbTcsHead.Location = New System.Drawing.Point(734, 108)
        Me.cmbTcsHead.Name = "cmbTcsHead"
        Me.cmbTcsHead.Size = New System.Drawing.Size(308, 24)
        Me.cmbTcsHead.TabIndex = 53
        '
        'dgDetials
        '
        Me.dgDetials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetials.Location = New System.Drawing.Point(22, 526)
        Me.dgDetials.Name = "dgDetials"
        Me.dgDetials.Size = New System.Drawing.Size(1210, 220)
        Me.dgDetials.TabIndex = 59
        '
        'ChkisCm
        '
        Me.ChkisCm.AutoSize = True
        Me.ChkisCm.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkisCm.Location = New System.Drawing.Point(468, 42)
        Me.ChkisCm.Name = "ChkisCm"
        Me.ChkisCm.Size = New System.Drawing.Size(51, 24)
        Me.ChkisCm.TabIndex = 62
        Me.ChkisCm.Text = "CM"
        Me.ChkisCm.UseVisualStyleBackColor = True
        '
        'ChkisDm
        '
        Me.ChkisDm.AutoSize = True
        Me.ChkisDm.Checked = True
        Me.ChkisDm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkisDm.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkisDm.Location = New System.Drawing.Point(405, 42)
        Me.ChkisDm.Name = "ChkisDm"
        Me.ChkisDm.Size = New System.Drawing.Size(53, 24)
        Me.ChkisDm.TabIndex = 61
        Me.ChkisDm.Text = "DM"
        Me.ChkisDm.UseVisualStyleBackColor = True
        '
        'frmDMPosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 749)
        Me.Controls.Add(Me.ChkisCm)
        Me.Controls.Add(Me.ChkisDm)
        Me.Controls.Add(Me.dgDetials)
        Me.Controls.Add(Me.cmdTcsCode)
        Me.Controls.Add(Me.cmbTcsHead)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbInsCode)
        Me.Controls.Add(Me.cmbInsHead)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.cmbBankCode)
        Me.Controls.Add(Me.cmbbankHead)
        Me.Controls.Add(Me.cmbVoucherType)
        Me.Controls.Add(Me.dtpPostingDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtAreaCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmDMPosting"
        Me.Text = "frmDMPosting"
        CType(Me.dg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgDetials,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBankCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbankHead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpPostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Auth As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbInsCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInsHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdTcsCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTcsHead As System.Windows.Forms.ComboBox
    Friend WithEvents dgDetials As System.Windows.Forms.DataGridView
    Friend WithEvents ChkisCm As System.Windows.Forms.CheckBox
    Friend WithEvents ChkisDm As System.Windows.Forms.CheckBox
End Class