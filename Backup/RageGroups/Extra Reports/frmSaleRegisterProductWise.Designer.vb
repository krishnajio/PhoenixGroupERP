<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleRegisterProductWise
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbProduct = New System.Windows.Forms.ComboBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.d1 = New System.Windows.Forms.DateTimePicker
        Me.d2 = New System.Windows.Forms.DateTimePicker
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.voutype = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbArea = New System.Windows.Forms.ComboBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.listgrp = New System.Windows.Forms.CheckedListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1175, 31)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "SALE REGISTER PRODUCT WISE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(600, 114)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 160
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(480, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(306, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Hatch From :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Select Product:"
        '
        'cmbProduct
        '
        Me.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(315, 39)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(253, 21)
        Me.cmbProduct.TabIndex = 164
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 157)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1175, 535)
        Me.CrystalReportViewer1.TabIndex = 165
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'd1
        '
        Me.d1.CustomFormat = "dd/MMM/yy"
        Me.d1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d1.Location = New System.Drawing.Point(399, 59)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(83, 20)
        Me.d1.TabIndex = 166
        '
        'd2
        '
        Me.d2.CustomFormat = "dd/MMM/yy"
        Me.d2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d2.Location = New System.Drawing.Point(509, 59)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(81, 20)
        Me.d2.TabIndex = 167
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(0, 35)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(218, 28)
        Me.CheckBox1.TabIndex = 168
        Me.CheckBox1.Text = "Area Wise Summary"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'voutype
        '
        Me.voutype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.voutype.FormattingEnabled = True
        Me.voutype.Location = New System.Drawing.Point(179, 62)
        Me.voutype.Name = "voutype"
        Me.voutype.Size = New System.Drawing.Size(121, 21)
        Me.voutype.TabIndex = 170
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Voucher Type:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbArea)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Location = New System.Drawing.Point(315, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 44)
        Me.Panel1.TabIndex = 176
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(82, 3)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(193, 21)
        Me.cmbArea.TabIndex = 170
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(3, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "Select Area"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'listgrp
        '
        Me.listgrp.CheckOnClick = True
        Me.listgrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listgrp.FormattingEnabled = True
        Me.listgrp.Location = New System.Drawing.Point(677, 36)
        Me.listgrp.Name = "listgrp"
        Me.listgrp.Size = New System.Drawing.Size(196, 72)
        Me.listgrp.TabIndex = 177
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(664, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 28)
        Me.Button1.TabIndex = 178
        Me.Button1.Text = "&Show Filter Area"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSaleRegisterProductWise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 692)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listgrp)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.voutype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaleRegisterProductWise"
        Me.Text = "frmSaleRegisterProductWise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents d1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents d2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents voutype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents listgrp As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
