<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillDetialsSale
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lblsp = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inovice /Receipt Detials Sale "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblsp)
        Me.Panel1.Controls.Add(Me.cmbacheadname)
        Me.Panel1.Controls.Add(Me.cmbacheadcode)
        Me.Panel1.Controls.Add(Me.dtto)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnshow)
        Me.Panel1.Controls.Add(Me.dtfrom)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 65)
        Me.Panel1.TabIndex = 98
        '
        'cmbacheadname
        '
        Me.cmbacheadname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbacheadname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(301, 8)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(243, 21)
        Me.cmbacheadname.TabIndex = 98
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(548, 8)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(152, 21)
        Me.cmbacheadcode.TabIndex = 99
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(440, 35)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(104, 22)
        Me.dtto.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(411, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "To"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(108, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(547, 34)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(53, 26)
        Me.btnshow.TabIndex = 102
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(301, 35)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 22)
        Me.dtfrom.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Date From :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 101)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1028, 586)
        Me.CrystalReportViewer1.TabIndex = 99
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'lblsp
        '
        Me.lblsp.AutoSize = True
        Me.lblsp.Location = New System.Drawing.Point(23, 15)
        Me.lblsp.Name = "lblsp"
        Me.lblsp.Size = New System.Drawing.Size(10, 13)
        Me.lblsp.TabIndex = 106
        Me.lblsp.Text = "-"
        '
        'frmBillDetialsSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1028, 687)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmBillDetialsSale"
        Me.Text = "frmBillDetialsSale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Public WithEvents lblsp As System.Windows.Forms.Label
End Class
