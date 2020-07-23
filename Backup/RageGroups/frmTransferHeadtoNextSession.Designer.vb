<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferHeadtoNextSession
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSession = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbSessionTo = New System.Windows.Forms.ComboBox
        Me.dgCurrentSession = New System.Windows.Forms.DataGridView
        Me.sno = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbGroups = New System.Windows.Forms.ComboBox
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.chkwithzero = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        CType(Me.dgCurrentSession, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(1028, 30)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Transfer Accont To Next Session"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Current Session"
        '
        'cmbSession
        '
        Me.cmbSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Location = New System.Drawing.Point(132, 34)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(162, 24)
        Me.cmbSession.TabIndex = 99
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(300, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "To Session  :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(485, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 101
        '
        'cmbSessionTo
        '
        Me.cmbSessionTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSessionTo.FormattingEnabled = True
        Me.cmbSessionTo.Location = New System.Drawing.Point(396, 33)
        Me.cmbSessionTo.Name = "cmbSessionTo"
        Me.cmbSessionTo.Size = New System.Drawing.Size(162, 24)
        Me.cmbSessionTo.TabIndex = 102
        '
        'dgCurrentSession
        '
        Me.dgCurrentSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCurrentSession.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sno, Me.code, Me.name, Me.dr, Me.cr})
        Me.dgCurrentSession.Location = New System.Drawing.Point(12, 127)
        Me.dgCurrentSession.Name = "dgCurrentSession"
        Me.dgCurrentSession.Size = New System.Drawing.Size(730, 586)
        Me.dgCurrentSession.TabIndex = 103
        '
        'sno
        '
        Me.sno.FalseValue = "0"
        Me.sno.HeaderText = "S.NO"
        Me.sno.Name = "sno"
        Me.sno.TrueValue = "1"
        '
        'code
        '
        Me.code.HeaderText = "Code"
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        Me.code.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name
        '
        Me.name.HeaderText = "Name"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        Me.name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name.Width = 250
        '
        'dr
        '
        Me.dr.HeaderText = "Closing Dr."
        Me.dr.Name = "dr"
        Me.dr.ReadOnly = True
        Me.dr.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cr
        '
        Me.cr.HeaderText = "Closing Cr."
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(857, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbGroups
        '
        Me.cmbGroups.FormattingEnabled = True
        Me.cmbGroups.Location = New System.Drawing.Point(670, 36)
        Me.cmbGroups.Name = "cmbGroups"
        Me.cmbGroups.Size = New System.Drawing.Size(165, 21)
        Me.cmbGroups.TabIndex = 108
        Me.cmbGroups.Text = "cmbGroups"
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Location = New System.Drawing.Point(574, 38)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectAll.TabIndex = 109
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'chkwithzero
        '
        Me.chkwithzero.AutoSize = True
        Me.chkwithzero.Location = New System.Drawing.Point(52, 69)
        Me.chkwithzero.Name = "chkwithzero"
        Me.chkwithzero.Size = New System.Drawing.Size(73, 17)
        Me.chkwithzero.TabIndex = 110
        Me.chkwithzero.Text = "With Zero"
        Me.chkwithzero.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(132, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 27)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Transfer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(670, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox1.TabIndex = 112
        '
        'frmTransferHeadtoNextSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chkwithzero)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.cmbGroups)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgCurrentSession)
        Me.Controls.Add(Me.cmbSessionTo)
        Me.Controls.Add(Me.cmbSession)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        'Me.name = "frmTransferHeadtoNextSession"
        Me.Text = "frmTransferHeadtoNextSession"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCurrentSession, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSessionTo As System.Windows.Forms.ComboBox
    Friend WithEvents dgCurrentSession As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbGroups As System.Windows.Forms.ComboBox
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkwithzero As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents sno As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
