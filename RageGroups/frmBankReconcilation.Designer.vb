<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankReconcilation
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmbsubgrpname = New System.Windows.Forms.ComboBox
        Me.cmbgrpname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.cmbacheadname = New System.Windows.Forms.ComboBox
        Me.cmbacheadcode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CrViewerBankrec = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dg = New System.Windows.Forms.DataGridView
        Me.Head = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chqno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnprint = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbsubgrpname
        '
        Me.cmbsubgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsubgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubgrpname.BackColor = System.Drawing.Color.White
        Me.cmbsubgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbsubgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubgrpname.FormattingEnabled = True
        Me.cmbsubgrpname.Location = New System.Drawing.Point(524, 84)
        Me.cmbsubgrpname.Name = "cmbsubgrpname"
        Me.cmbsubgrpname.Size = New System.Drawing.Size(110, 24)
        Me.cmbsubgrpname.TabIndex = 5
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(280, 84)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(237, 24)
        Me.cmbgrpname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 15)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Group / Subroup : "
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(352, 34)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(165, 21)
        Me.cmbAreaName.TabIndex = 1
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(280, 34)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(67, 21)
        Me.cmbAreaCode.TabIndex = 0
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
        Me.Label1.Size = New System.Drawing.Size(804, 31)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Reconcilation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Area :"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(537, 111)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(64, 23)
        Me.btnshow.TabIndex = 8
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(281, 110)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 20)
        Me.dtfrom.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(198, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Date From :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "To"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "dd/MMM/yy"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(417, 111)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(104, 20)
        Me.dtTo.TabIndex = 7
        '
        'cmbacheadname
        '
        Me.cmbacheadname.BackColor = System.Drawing.Color.White
        Me.cmbacheadname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadname.FormattingEnabled = True
        Me.cmbacheadname.Location = New System.Drawing.Point(280, 59)
        Me.cmbacheadname.Name = "cmbacheadname"
        Me.cmbacheadname.Size = New System.Drawing.Size(238, 21)
        Me.cmbacheadname.TabIndex = 3
        '
        'cmbacheadcode
        '
        Me.cmbacheadcode.BackColor = System.Drawing.Color.White
        Me.cmbacheadcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadcode.FormattingEnabled = True
        Me.cmbacheadcode.Location = New System.Drawing.Point(524, 59)
        Me.cmbacheadcode.Name = "cmbacheadcode"
        Me.cmbacheadcode.Size = New System.Drawing.Size(110, 21)
        Me.cmbacheadcode.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(84, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 15)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Account Head (Code/Name)  :"
        '
        'CrViewerBankrec
        '
        Me.CrViewerBankrec.ActiveViewIndex = -1
        Me.CrViewerBankrec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerBankrec.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerBankrec.Location = New System.Drawing.Point(0, 190)
        Me.CrViewerBankrec.Name = "CrViewerBankrec"
        Me.CrViewerBankrec.SelectionFormula = ""
        Me.CrViewerBankrec.Size = New System.Drawing.Size(804, 362)
        Me.CrViewerBankrec.TabIndex = 122
        Me.CrViewerBankrec.ViewTimeSelectionFormula = ""
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Head, Me.rdate, Me.chqno, Me.amt})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle4
        Me.dg.Location = New System.Drawing.Point(0, 204)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(792, 362)
        Me.dg.TabIndex = 123
        '
        'Head
        '
        Me.Head.HeaderText = "Head"
        Me.Head.Name = "Head"
        Me.Head.ReadOnly = True
        Me.Head.Width = 300
        '
        'rdate
        '
        DataGridViewCellStyle2.Format = "dd/MM/yy"
        Me.rdate.DefaultCellStyle = DataGridViewCellStyle2
        Me.rdate.HeaderText = "Date"
        Me.rdate.Name = "rdate"
        Me.rdate.ReadOnly = True
        '
        'chqno
        '
        Me.chqno.HeaderText = "Cheque No"
        Me.chqno.Name = "chqno"
        Me.chqno.ReadOnly = True
        '
        'amt
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.amt.DefaultCellStyle = DataGridViewCellStyle3
        Me.amt.HeaderText = "Amount"
        Me.amt.Name = "amt"
        Me.amt.ReadOnly = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(607, 111)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(64, 23)
        Me.btnprint.TabIndex = 124
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(124, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmBankReconcilation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(804, 552)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.CrViewerBankrec)
        Me.Controls.Add(Me.cmbacheadname)
        Me.Controls.Add(Me.cmbacheadcode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbsubgrpname)
        Me.Controls.Add(Me.cmbgrpname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAreaName)
        Me.Controls.Add(Me.cmbAreaCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmBankReconcilation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBankReconcilation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbsubgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbacheadname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CrViewerBankrec As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Head As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chqno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
