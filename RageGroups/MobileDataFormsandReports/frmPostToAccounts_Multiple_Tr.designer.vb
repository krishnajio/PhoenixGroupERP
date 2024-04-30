<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostToAccounts_Mutiple_Tr
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.DtpTrDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAreaCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Auth = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dtpPostingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbVoucherType = New System.Windows.Forms.ComboBox()
        Me.cmbbankHead = New System.Windows.Forms.ComboBox()
        Me.cmbBankCode = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1301, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TR Post To Accounts(Multiple TR)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1214, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "POST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL AREA", "SELECTED AREA"})
        Me.ComboBox1.Location = New System.Drawing.Point(51, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 20
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(715, 54)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "On Screen"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(864, 44)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 34)
        Me.btnShow.TabIndex = 17
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'DtpTrDate
        '
        Me.DtpTrDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpTrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpTrDate.Location = New System.Drawing.Point(580, 48)
        Me.DtpTrDate.Name = "DtpTrDate"
        Me.DtpTrDate.Size = New System.Drawing.Size(120, 26)
        Me.DtpTrDate.TabIndex = 16
        '
        'txtAreaCode
        '
        Me.txtAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaCode.Location = New System.Drawing.Point(309, 49)
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(125, 26)
        Me.txtAreaCode.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Hatch Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Area :"
        '
        'dg
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auth})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg.Location = New System.Drawing.Point(0, 158)
        Me.dg.Name = "dg"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg.Size = New System.Drawing.Size(1289, 514)
        Me.dg.TabIndex = 22
        '
        'Auth
        '
        Me.Auth.FalseValue = "0"
        Me.Auth.HeaderText = "Auth"
        Me.Auth.Name = "Auth"
        Me.Auth.TrueValue = "1"
        '
        'dtpPostingDate
        '
        Me.dtpPostingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPostingDate.Location = New System.Drawing.Point(656, 89)
        Me.dtpPostingDate.Name = "dtpPostingDate"
        Me.dtpPostingDate.Size = New System.Drawing.Size(120, 26)
        Me.dtpPostingDate.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(523, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Posting Date :"
        '
        'cmbVoucherType
        '
        Me.cmbVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVoucherType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVoucherType.FormattingEnabled = True
        Me.cmbVoucherType.Location = New System.Drawing.Point(782, 89)
        Me.cmbVoucherType.Name = "cmbVoucherType"
        Me.cmbVoucherType.Size = New System.Drawing.Size(333, 24)
        Me.cmbVoucherType.TabIndex = 25
        '
        'cmbbankHead
        '
        Me.cmbbankHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankHead.FormattingEnabled = True
        Me.cmbbankHead.Location = New System.Drawing.Point(782, 119)
        Me.cmbbankHead.Name = "cmbbankHead"
        Me.cmbbankHead.Size = New System.Drawing.Size(333, 24)
        Me.cmbbankHead.TabIndex = 26
        '
        'cmbBankCode
        '
        Me.cmbBankCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBankCode.FormattingEnabled = True
        Me.cmbBankCode.Location = New System.Drawing.Point(655, 119)
        Me.cmbBankCode.Name = "cmbBankCode"
        Me.cmbBankCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbBankCode.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(945, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(6, 170)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1271, 483)
        Me.CrystalReportViewer1.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1121, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 58)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "SHOW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(601, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "lbl5"
        '
        'frmPostToAccounts_Mutiple_Tr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1301, 665)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbBankCode)
        Me.Controls.Add(Me.cmbbankHead)
        Me.Controls.Add(Me.cmbVoucherType)
        Me.Controls.Add(Me.dtpPostingDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.DtpTrDate)
        Me.Controls.Add(Me.txtAreaCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmPostToAccounts_Mutiple_Tr"
        Me.Text = "frmPostToAccounts"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents DtpTrDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Auth As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dtpPostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbVoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbankHead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBankCode As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
