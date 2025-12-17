<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btsave = New System.Windows.Forms.Button()
        Me.dtHdatedate = New System.Windows.Forms.DateTimePicker()
        Me.cmbChickType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbhatchery = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 106)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1102, 501)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNote)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btsave)
        Me.GroupBox1.Controls.Add(Me.dtHdatedate)
        Me.GroupBox1.Controls.Add(Me.cmbChickType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbhatchery)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1102, 106)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(92, 56)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(479, 20)
        Me.txtNote.TabIndex = 51
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(937, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox1.TabIndex = 49
        Me.CheckBox1.Text = "ALL"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.BackColor = System.Drawing.Color.Silver
        Me.btsave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btsave.FlatAppearance.BorderSize = 2
        Me.btsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Beige
        Me.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsave.Location = New System.Drawing.Point(988, 16)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(60, 26)
        Me.btsave.TabIndex = 48
        Me.btsave.Text = "&Show"
        Me.btsave.UseVisualStyleBackColor = False
        '
        'dtHdatedate
        '
        Me.dtHdatedate.CustomFormat = "dd/MMM/yyyy"
        Me.dtHdatedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHdatedate.Location = New System.Drawing.Point(92, 22)
        Me.dtHdatedate.Name = "dtHdatedate"
        Me.dtHdatedate.Size = New System.Drawing.Size(111, 20)
        Me.dtHdatedate.TabIndex = 46
        '
        'cmbChickType
        '
        Me.cmbChickType.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbChickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChickType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChickType.FormattingEnabled = True
        Me.cmbChickType.Location = New System.Drawing.Point(754, 17)
        Me.cmbChickType.Name = "cmbChickType"
        Me.cmbChickType.Size = New System.Drawing.Size(176, 24)
        Me.cmbChickType.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(665, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Chicks Type"
        '
        'cmbhatchery
        '
        Me.cmbhatchery.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbhatchery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbhatchery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbhatchery.FormattingEnabled = True
        Me.cmbhatchery.Location = New System.Drawing.Point(301, 23)
        Me.cmbhatchery.Name = "cmbhatchery"
        Me.cmbhatchery.Size = New System.Drawing.Size(357, 24)
        Me.cmbhatchery.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(219, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 15)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Hatcheries"
        '
        'frmScheduleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 607)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmScheduleReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScheduleReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btsave As System.Windows.Forms.Button
    Friend WithEvents dtHdatedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbChickType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbhatchery As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
