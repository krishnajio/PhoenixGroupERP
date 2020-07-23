<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashBook
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
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdscreen = New System.Windows.Forms.RadioButton
        Me.rdprint = New System.Windows.Forms.RadioButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Narration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChqNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cramt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 97)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(804, 448)
        Me.CrViewerGenralLedger.TabIndex = 77
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(731, 38)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(67, 24)
        Me.btnclose.TabIndex = 83
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(659, 37)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(66, 25)
        Me.btnshow.TabIndex = 82
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(126, 38)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(128, 20)
        Me.dtfrom.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 80
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
        Me.Label1.Size = New System.Drawing.Size(804, 31)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Cash Book"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(282, 36)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(128, 20)
        Me.dtto.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "to"
        '
        'rdscreen
        '
        Me.rdscreen.AutoSize = True
        Me.rdscreen.Checked = True
        Me.rdscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdscreen.Location = New System.Drawing.Point(524, 40)
        Me.rdscreen.Name = "rdscreen"
        Me.rdscreen.Size = New System.Drawing.Size(70, 19)
        Me.rdscreen.TabIndex = 86
        Me.rdscreen.TabStop = True
        Me.rdscreen.Text = "Screen"
        Me.rdscreen.UseVisualStyleBackColor = True
        '
        'rdprint
        '
        Me.rdprint.AutoSize = True
        Me.rdprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdprint.Location = New System.Drawing.Point(600, 40)
        Me.rdprint.Name = "rdprint"
        Me.rdprint.Size = New System.Drawing.Size(55, 19)
        Me.rdprint.TabIndex = 87
        Me.rdprint.Text = "Print"
        Me.rdprint.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date1, Me.Narration, Me.ChqNo, Me.Dramt, Me.cramt, Me.Balance})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(804, 415)
        Me.DataGridView1.TabIndex = 88
        '
        'date1
        '
        Me.date1.DataPropertyName = "Vou_date"
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = "-"
        Me.date1.DefaultCellStyle = DataGridViewCellStyle1
        Me.date1.HeaderText = "Date"
        Me.date1.Name = "date1"
        Me.date1.ReadOnly = True
        Me.date1.Width = 75
        '
        'Narration
        '
        Me.Narration.DataPropertyName = "narration"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Narration.DefaultCellStyle = DataGridViewCellStyle2
        Me.Narration.HeaderText = "Narration"
        Me.Narration.Name = "Narration"
        Me.Narration.ReadOnly = True
        Me.Narration.Width = 350
        '
        'ChqNo
        '
        Me.ChqNo.DataPropertyName = "Cheque_no"
        Me.ChqNo.HeaderText = "Chq No"
        Me.ChqNo.Name = "ChqNo"
        Me.ChqNo.ReadOnly = True
        Me.ChqNo.Visible = False
        '
        'Dramt
        '
        Me.Dramt.DataPropertyName = "dramt"
        Me.Dramt.HeaderText = "Dr. Amt"
        Me.Dramt.Name = "Dramt"
        Me.Dramt.ReadOnly = True
        '
        'cramt
        '
        Me.cramt.DataPropertyName = "cramt"
        Me.cramt.HeaderText = "Cr. Amt"
        Me.cramt.Name = "cramt"
        Me.cramt.ReadOnly = True
        '
        'Balance
        '
        Me.Balance.DataPropertyName = "Balance"
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(422, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 25)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCashBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(804, 545)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdprint)
        Me.Controls.Add(Me.rdscreen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Name = "frmCashBook"
        Me.Text = "Cash Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdscreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdprint As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents date1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Narration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChqNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cramt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
