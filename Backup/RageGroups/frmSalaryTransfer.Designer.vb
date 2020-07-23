<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalaryTransfer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtSalaryDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblvouno = New System.Windows.Forms.TextBox
        Me.dtVoucherDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvoucher = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Accode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dramount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cramount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbvtype = New System.Windows.Forms.ComboBox
        Me.btnShow = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.dr = New System.Windows.Forms.Label
        Me.cr = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbPaymode = New System.Windows.Forms.ComboBox
        Me.RdHO = New System.Windows.Forms.RadioButton
        Me.Rdothr = New System.Windows.Forms.RadioButton
        Me.cmborgid = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1093, 31)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Salary Transfer"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtSalaryDate
        '
        Me.dtSalaryDate.CustomFormat = "dd/MMM/yy"
        Me.dtSalaryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSalaryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSalaryDate.Location = New System.Drawing.Point(301, 35)
        Me.dtSalaryDate.Name = "dtSalaryDate"
        Me.dtSalaryDate.Size = New System.Drawing.Size(89, 20)
        Me.dtSalaryDate.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Salary Month:"
        '
        'lblvouno
        '
        Me.lblvouno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvouno.Location = New System.Drawing.Point(301, 58)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.ReadOnly = True
        Me.lblvouno.Size = New System.Drawing.Size(89, 20)
        Me.lblvouno.TabIndex = 93
        Me.lblvouno.TabStop = False
        '
        'dtVoucherDate
        '
        Me.dtVoucherDate.CustomFormat = "dd/MMM/yy"
        Me.dtVoucherDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtVoucherDate.Location = New System.Drawing.Point(503, 33)
        Me.dtVoucherDate.Name = "dtVoucherDate"
        Me.dtVoucherDate.Size = New System.Drawing.Size(94, 20)
        Me.dtVoucherDate.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Voucher Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Voucher No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(595, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Voucher Type :"
        '
        'dgvoucher
        '
        Me.dgvoucher.AllowUserToAddRows = False
        Me.dgvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.Accode, Me.acname, Me.narration, Me.dramount, Me.cramount, Me.GroupName})
        Me.dgvoucher.Location = New System.Drawing.Point(0, 85)
        Me.dgvoucher.Name = "dgvoucher"
        Me.dgvoucher.RowTemplate.Height = 20
        Me.dgvoucher.Size = New System.Drawing.Size(1081, 616)
        Me.dgvoucher.TabIndex = 94
        '
        'srno
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srno.DefaultCellStyle = DataGridViewCellStyle1
        Me.srno.HeaderText = "Sr. No."
        Me.srno.MaxInputLength = 2
        Me.srno.Name = "srno"
        Me.srno.Width = 50
        '
        'Accode
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = "-"
        Me.Accode.DefaultCellStyle = DataGridViewCellStyle2
        Me.Accode.HeaderText = "A/C Code"
        Me.Accode.MaxInputLength = 10
        Me.Accode.Name = "Accode"
        Me.Accode.Width = 80
        '
        'acname
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acname.DefaultCellStyle = DataGridViewCellStyle3
        Me.acname.HeaderText = "A/C Name"
        Me.acname.MaxInputLength = 30
        Me.acname.Name = "acname"
        Me.acname.ReadOnly = True
        Me.acname.Width = 200
        '
        'narration
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.narration.DefaultCellStyle = DataGridViewCellStyle4
        Me.narration.HeaderText = "Narration"
        Me.narration.MaxInputLength = 180
        Me.narration.Name = "narration"
        Me.narration.Width = 210
        '
        'dramount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.dramount.DefaultCellStyle = DataGridViewCellStyle5
        Me.dramount.HeaderText = "Dr. Amount"
        Me.dramount.MaxInputLength = 18
        Me.dramount.Name = "dramount"
        Me.dramount.Width = 80
        '
        'cramount
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.cramount.DefaultCellStyle = DataGridViewCellStyle6
        Me.cramount.HeaderText = "Cr Amount"
        Me.cramount.Name = "cramount"
        Me.cramount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cramount.Width = 80
        '
        'GroupName
        '
        Me.GroupName.HeaderText = "GroupName"
        Me.GroupName.Name = "GroupName"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(702, 34)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(168, 21)
        Me.cmbvtype.TabIndex = 95
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnShow.Location = New System.Drawing.Point(702, 60)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(70, 23)
        Me.btnShow.TabIndex = 96
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button1.Location = New System.Drawing.Point(777, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dr
        '
        Me.dr.AutoSize = True
        Me.dr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dr.Location = New System.Drawing.Point(600, 724)
        Me.dr.Name = "dr"
        Me.dr.Size = New System.Drawing.Size(20, 15)
        Me.dr.TabIndex = 98
        Me.dr.Text = "dr"
        '
        'cr
        '
        Me.cr.AutoSize = True
        Me.cr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.cr.Location = New System.Drawing.Point(701, 724)
        Me.cr.Name = "cr"
        Me.cr.Size = New System.Drawing.Size(19, 15)
        Me.cr.TabIndex = 99
        Me.cr.Text = "cr"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(415, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Pay mode. :"
        '
        'cmbPaymode
        '
        Me.cmbPaymode.AutoCompleteCustomSource.AddRange(New String() {"BANK", "CASH"})
        Me.cmbPaymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymode.FormattingEnabled = True
        Me.cmbPaymode.Items.AddRange(New Object() {"BANK", "CASH"})
        Me.cmbPaymode.Location = New System.Drawing.Point(503, 58)
        Me.cmbPaymode.Name = "cmbPaymode"
        Me.cmbPaymode.Size = New System.Drawing.Size(193, 21)
        Me.cmbPaymode.TabIndex = 101
        '
        'RdHO
        '
        Me.RdHO.AutoSize = True
        Me.RdHO.Location = New System.Drawing.Point(896, 39)
        Me.RdHO.Name = "RdHO"
        Me.RdHO.Size = New System.Drawing.Size(80, 17)
        Me.RdHO.TabIndex = 103
        Me.RdHO.TabStop = True
        Me.RdHO.Text = "Head office"
        Me.RdHO.UseVisualStyleBackColor = True
        Me.RdHO.Visible = False
        '
        'Rdothr
        '
        Me.Rdothr.AutoSize = True
        Me.Rdothr.Location = New System.Drawing.Point(992, 39)
        Me.Rdothr.Name = "Rdothr"
        Me.Rdothr.Size = New System.Drawing.Size(80, 17)
        Me.Rdothr.TabIndex = 102
        Me.Rdothr.TabStop = True
        Me.Rdothr.Text = "Other office"
        Me.Rdothr.UseVisualStyleBackColor = True
        Me.Rdothr.Visible = False
        '
        'cmborgid
        '
        Me.cmborgid.AutoCompleteCustomSource.AddRange(New String() {"BANK", "CASH"})
        Me.cmborgid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmborgid.FormattingEnabled = True
        Me.cmborgid.Items.AddRange(New Object() {"Phoenix Poultry", "PHOENIX POULTRY (HO) "})
        Me.cmborgid.Location = New System.Drawing.Point(8, 53)
        Me.cmborgid.Name = "cmborgid"
        Me.cmborgid.Size = New System.Drawing.Size(193, 21)
        Me.cmborgid.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Organization"
        '
        'frmSalaryTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1093, 748)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmborgid)
        Me.Controls.Add(Me.RdHO)
        Me.Controls.Add(Me.Rdothr)
        Me.Controls.Add(Me.cmbPaymode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.dr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.dgvoucher)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.dtVoucherDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtSalaryDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalaryTransfer"
        Me.Text = "frmSalaryTransfer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtSalaryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblvouno As System.Windows.Forms.TextBox
    Friend WithEvents dtVoucherDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents dgvoucher As System.Windows.Forms.DataGridView
    Public WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dramount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dr As System.Windows.Forms.Label
    Friend WithEvents cr As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPaymode As System.Windows.Forms.ComboBox
    Friend WithEvents RdHO As System.Windows.Forms.RadioButton
    Friend WithEvents Rdothr As System.Windows.Forms.RadioButton
    Friend WithEvents cmborgid As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
