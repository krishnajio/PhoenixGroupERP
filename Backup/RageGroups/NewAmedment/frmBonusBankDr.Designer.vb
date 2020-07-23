<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBonusBankDr
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblvouno = New System.Windows.Forms.TextBox
        Me.dgvoucher = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Accode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dramount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cramount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subgrp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnShow = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbvtype = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCr = New System.Windows.Forms.TextBox
        Me.txtDr = New System.Windows.Forms.TextBox
        Me.cmbFrightCode = New System.Windows.Forms.ComboBox
        Me.cmbFreightHead = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtnarr = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbvtype1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbFreightGroup = New System.Windows.Forms.ComboBox
        Me.cmbFreightSubGroup = New System.Windows.Forms.ComboBox
        Me.dtdate = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblvouno1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtChqNo = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SlateBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(950, 37)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "BONUS BANK ENTRY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblvouno
        '
        Me.lblvouno.Location = New System.Drawing.Point(382, 47)
        Me.lblvouno.Name = "lblvouno"
        Me.lblvouno.Size = New System.Drawing.Size(122, 20)
        Me.lblvouno.TabIndex = 184
        '
        'dgvoucher
        '
        Me.dgvoucher.AllowUserToAddRows = False
        Me.dgvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.Accode, Me.acname, Me.dramount, Me.cramount, Me.GroupName, Me.subgrp})
        Me.dgvoucher.Location = New System.Drawing.Point(12, 77)
        Me.dgvoucher.Name = "dgvoucher"
        Me.dgvoucher.RowTemplate.Height = 20
        Me.dgvoucher.Size = New System.Drawing.Size(749, 385)
        Me.dgvoucher.TabIndex = 188
        '
        'srno
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srno.DefaultCellStyle = DataGridViewCellStyle6
        Me.srno.HeaderText = "Sr. No."
        Me.srno.MaxInputLength = 2
        Me.srno.Name = "srno"
        Me.srno.Width = 50
        '
        'Accode
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.NullValue = "-"
        Me.Accode.DefaultCellStyle = DataGridViewCellStyle7
        Me.Accode.HeaderText = "A/C Code"
        Me.Accode.MaxInputLength = 10
        Me.Accode.Name = "Accode"
        Me.Accode.Width = 80
        '
        'acname
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acname.DefaultCellStyle = DataGridViewCellStyle8
        Me.acname.HeaderText = "A/C Name"
        Me.acname.MaxInputLength = 30
        Me.acname.Name = "acname"
        Me.acname.Width = 200
        '
        'dramount
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.dramount.DefaultCellStyle = DataGridViewCellStyle9
        Me.dramount.HeaderText = "Dr. Amount"
        Me.dramount.MaxInputLength = 18
        Me.dramount.Name = "dramount"
        Me.dramount.Width = 80
        '
        'cramount
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0.00"
        Me.cramount.DefaultCellStyle = DataGridViewCellStyle10
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
        'subgrp
        '
        Me.subgrp.HeaderText = "Sub Group"
        Me.subgrp.Name = "subgrp"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnShow.Location = New System.Drawing.Point(510, 46)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(87, 23)
        Me.btnShow.TabIndex = 185
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Honeydew
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(291, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Voucher No:"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(115, 46)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(170, 21)
        Me.cmbvtype.TabIndex = 183
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Honeydew
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Voucher Type:"
        '
        'txtCr
        '
        Me.txtCr.Location = New System.Drawing.Point(569, 594)
        Me.txtCr.Name = "txtCr"
        Me.txtCr.Size = New System.Drawing.Size(89, 20)
        Me.txtCr.TabIndex = 196
        '
        'txtDr
        '
        Me.txtDr.Location = New System.Drawing.Point(465, 594)
        Me.txtDr.Name = "txtDr"
        Me.txtDr.Size = New System.Drawing.Size(98, 20)
        Me.txtDr.TabIndex = 195
        '
        'cmbFrightCode
        '
        Me.cmbFrightCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFrightCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFrightCode.BackColor = System.Drawing.Color.White
        Me.cmbFrightCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrightCode.FormattingEnabled = True
        Me.cmbFrightCode.Location = New System.Drawing.Point(336, 594)
        Me.cmbFrightCode.Name = "cmbFrightCode"
        Me.cmbFrightCode.Size = New System.Drawing.Size(123, 21)
        Me.cmbFrightCode.TabIndex = 194
        '
        'cmbFreightHead
        '
        Me.cmbFreightHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightHead.BackColor = System.Drawing.Color.White
        Me.cmbFreightHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightHead.FormattingEnabled = True
        Me.cmbFreightHead.Location = New System.Drawing.Point(12, 594)
        Me.cmbFreightHead.Name = "cmbFreightHead"
        Me.cmbFreightHead.Size = New System.Drawing.Size(318, 21)
        Me.cmbFreightHead.TabIndex = 193
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 528)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 198
        Me.Label10.Text = "Narration"
        '
        'txtnarr
        '
        Me.txtnarr.Location = New System.Drawing.Point(12, 546)
        Me.txtnarr.Multiline = True
        Me.txtnarr.Name = "txtnarr"
        Me.txtnarr.Size = New System.Drawing.Size(500, 31)
        Me.txtnarr.TabIndex = 192
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button1.Location = New System.Drawing.Point(664, 619)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 197
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbvtype1
        '
        Me.cmbvtype1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbvtype1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype1.BackColor = System.Drawing.Color.White
        Me.cmbvtype1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype1.FormattingEnabled = True
        Me.cmbvtype1.Location = New System.Drawing.Point(115, 490)
        Me.cmbvtype1.Name = "cmbvtype1"
        Me.cmbvtype1.Size = New System.Drawing.Size(170, 21)
        Me.cmbvtype1.TabIndex = 199
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Honeydew
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "Voucher Type:"
        '
        'cmbFreightGroup
        '
        Me.cmbFreightGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightGroup.FormattingEnabled = True
        Me.cmbFreightGroup.Location = New System.Drawing.Point(789, 242)
        Me.cmbFreightGroup.Name = "cmbFreightGroup"
        Me.cmbFreightGroup.Size = New System.Drawing.Size(170, 21)
        Me.cmbFreightGroup.TabIndex = 201
        '
        'cmbFreightSubGroup
        '
        Me.cmbFreightSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbFreightSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFreightSubGroup.BackColor = System.Drawing.Color.White
        Me.cmbFreightSubGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFreightSubGroup.FormattingEnabled = True
        Me.cmbFreightSubGroup.Location = New System.Drawing.Point(780, 283)
        Me.cmbFreightSubGroup.Name = "cmbFreightSubGroup"
        Me.cmbFreightSubGroup.Size = New System.Drawing.Size(170, 21)
        Me.cmbFreightSubGroup.TabIndex = 202
        '
        'dtdate
        '
        Me.dtdate.CustomFormat = "dd/MMM/yy"
        Me.dtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtdate.Location = New System.Drawing.Point(425, 485)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(87, 21)
        Me.dtdate.TabIndex = 203
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Honeydew
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label13.Location = New System.Drawing.Point(308, 488)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "Voucher Date :"
        '
        'lblvouno1
        '
        Me.lblvouno1.AutoSize = True
        Me.lblvouno1.BackColor = System.Drawing.Color.Honeydew
        Me.lblvouno1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.lblvouno1.Location = New System.Drawing.Point(529, 488)
        Me.lblvouno1.Name = "lblvouno1"
        Me.lblvouno1.Size = New System.Drawing.Size(101, 15)
        Me.lblvouno1.TabIndex = 205
        Me.lblvouno1.Text = "Voucher Date :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label6.Location = New System.Drawing.Point(517, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 207
        Me.Label6.Text = "Chq No"
        '
        'txtChqNo
        '
        Me.txtChqNo.Location = New System.Drawing.Point(515, 546)
        Me.txtChqNo.Multiline = True
        Me.txtChqNo.Name = "txtChqNo"
        Me.txtChqNo.Size = New System.Drawing.Size(246, 31)
        Me.txtChqNo.TabIndex = 206
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(569, 621)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 20)
        Me.TextBox1.TabIndex = 211
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(465, 621)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(98, 20)
        Me.TextBox2.TabIndex = 210
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(336, 621)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox1.TabIndex = 209
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 621)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(318, 21)
        Me.ComboBox2.TabIndex = 208
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.BackColor = System.Drawing.Color.White
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(780, 333)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox3.TabIndex = 212
        '
        'frmBonusBankDr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 702)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtChqNo)
        Me.Controls.Add(Me.lblvouno1)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbFreightSubGroup)
        Me.Controls.Add(Me.cmbFreightGroup)
        Me.Controls.Add(Me.cmbvtype1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCr)
        Me.Controls.Add(Me.txtDr)
        Me.Controls.Add(Me.cmbFrightCode)
        Me.Controls.Add(Me.cmbFreightHead)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtnarr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblvouno)
        Me.Controls.Add(Me.dgvoucher)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmBonusBankDr"
        Me.Text = "frmBonusBankDr"
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblvouno As System.Windows.Forms.TextBox
    Public WithEvents dgvoucher As System.Windows.Forms.DataGridView
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dramount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subgrp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCr As System.Windows.Forms.TextBox
    Friend WithEvents txtDr As System.Windows.Forms.TextBox
    Friend WithEvents cmbFrightCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFreightHead As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnarr As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbvtype1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFreightGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFreightSubGroup As System.Windows.Forms.ComboBox
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblvouno1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
End Class
