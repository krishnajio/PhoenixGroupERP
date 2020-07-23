<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalancesheetMonthly
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
        Me.CrViewerGenralLedger = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtto = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdpl = New System.Windows.Forms.RadioButton
        Me.rdbal = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtclosing = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtopen = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CrViewerGenralLedger
        '
        Me.CrViewerGenralLedger.ActiveViewIndex = -1
        Me.CrViewerGenralLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewerGenralLedger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrViewerGenralLedger.Location = New System.Drawing.Point(0, 151)
        Me.CrViewerGenralLedger.Name = "CrViewerGenralLedger"
        Me.CrViewerGenralLedger.SelectionFormula = ""
        Me.CrViewerGenralLedger.Size = New System.Drawing.Size(1053, 469)
        Me.CrViewerGenralLedger.TabIndex = 119
        Me.CrViewerGenralLedger.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(566, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 28)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtto
        '
        Me.dtto.CustomFormat = "dd/MMM/yy"
        Me.dtto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtto.Location = New System.Drawing.Point(385, 48)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(104, 20)
        Me.dtto.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "To"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(492, 93)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(68, 28)
        Me.btnshow.TabIndex = 106
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'dtfrom
        '
        Me.dtfrom.CustomFormat = "dd/MMM/yy"
        Me.dtfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfrom.Location = New System.Drawing.Point(248, 48)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(104, 20)
        Me.dtfrom.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(160, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Date From :"
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
        Me.Label1.Size = New System.Drawing.Size(1053, 31)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Monthly  Profit && Loss"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rdpl
        '
        Me.rdpl.AutoSize = True
        Me.rdpl.Checked = True
        Me.rdpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdpl.Location = New System.Drawing.Point(364, 28)
        Me.rdpl.Name = "rdpl"
        Me.rdpl.Size = New System.Drawing.Size(106, 19)
        Me.rdpl.TabIndex = 121
        Me.rdpl.TabStop = True
        Me.rdpl.Text = "Profit && Loss"
        Me.rdpl.UseVisualStyleBackColor = True
        '
        'rdbal
        '
        Me.rdbal.AutoSize = True
        Me.rdbal.Enabled = False
        Me.rdbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbal.Location = New System.Drawing.Point(247, 28)
        Me.rdbal.Name = "rdbal"
        Me.rdbal.Size = New System.Drawing.Size(118, 19)
        Me.rdbal.TabIndex = 120
        Me.rdbal.Text = "Balance Sheet"
        Me.rdbal.UseVisualStyleBackColor = True
        Me.rdbal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Unit:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All", "Feed", "Pariyat", "Layer", "Broiler", "Gourha", "Mansar", "Raipur Feed", "Tilda", "WB"})
        Me.ComboBox1.Location = New System.Drawing.Point(248, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 123
        '
        'txtclosing
        '
        Me.txtclosing.Location = New System.Drawing.Point(455, 71)
        Me.txtclosing.Name = "txtclosing"
        Me.txtclosing.Size = New System.Drawing.Size(100, 20)
        Me.txtclosing.TabIndex = 131
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(355, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Closing Stock"
        '
        'txtopen
        '
        Me.txtopen.Location = New System.Drawing.Point(248, 71)
        Me.txtopen.Name = "txtopen"
        Me.txtopen.Size = New System.Drawing.Size(100, 20)
        Me.txtopen.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Opening Stock"
        '
        'frmBalancesheetMonthly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1053, 620)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtclosing)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtopen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdpl)
        Me.Controls.Add(Me.rdbal)
        Me.Controls.Add(Me.CrViewerGenralLedger)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtfrom)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmBalancesheetMonthly"
        Me.Text = "Profit & Loss"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrViewerGenralLedger As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdpl As System.Windows.Forms.RadioButton
    Friend WithEvents rdbal As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtclosing As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtopen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
