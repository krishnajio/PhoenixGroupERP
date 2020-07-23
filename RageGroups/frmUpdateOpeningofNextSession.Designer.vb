<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateOpeningofNextSession
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
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.chkwithzero = New System.Windows.Forms.CheckBox
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.cmbGroups = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbSession = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgCurrentSession = New System.Windows.Forms.DataGridView
        Me.sno = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cmbSessionTo = New System.Windows.Forms.ComboBox
        Me.dtfrom = New System.Windows.Forms.DateTimePicker
        Me.dgnew = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgCurrentSession, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgnew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cr
        '
        Me.cr.HeaderText = "Closing Cr."
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dr
        '
        Me.dr.HeaderText = "Closing Dr."
        Me.dr.Name = "dr"
        Me.dr.ReadOnly = True
        Me.dr.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(121, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 27)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chkwithzero
        '
        Me.chkwithzero.AutoSize = True
        Me.chkwithzero.Location = New System.Drawing.Point(41, 75)
        Me.chkwithzero.Name = "chkwithzero"
        Me.chkwithzero.Size = New System.Drawing.Size(73, 17)
        Me.chkwithzero.TabIndex = 122
        Me.chkwithzero.Text = "With Zero"
        Me.chkwithzero.UseVisualStyleBackColor = True
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Location = New System.Drawing.Point(563, 44)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectAll.TabIndex = 121
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'cmbGroups
        '
        Me.cmbGroups.FormattingEnabled = True
        Me.cmbGroups.Location = New System.Drawing.Point(659, 42)
        Me.cmbGroups.Name = "cmbGroups"
        Me.cmbGroups.Size = New System.Drawing.Size(165, 21)
        Me.cmbGroups.TabIndex = 120
        Me.cmbGroups.Text = "cmbGroups"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(846, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 119
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'code
        '
        Me.code.HeaderText = "Code"
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        Me.code.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cmbSession
        '
        Me.cmbSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Location = New System.Drawing.Point(121, 40)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(162, 24)
        Me.cmbSession.TabIndex = 114
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(289, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "To Session  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Current Session"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Pink
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 30)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Update Opening"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgCurrentSession
        '
        Me.dgCurrentSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCurrentSession.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sno, Me.code, Me.name, Me.dr, Me.cr})
        Me.dgCurrentSession.Location = New System.Drawing.Point(4, 115)
        Me.dgCurrentSession.Name = "dgCurrentSession"
        Me.dgCurrentSession.Size = New System.Drawing.Size(435, 586)
        Me.dgCurrentSession.TabIndex = 118
        '
        'sno
        '
        Me.sno.HeaderText = "S.NO"
        Me.sno.Name = "sno"
        '
        'cmbSessionTo
        '
        Me.cmbSessionTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSessionTo.FormattingEnabled = True
        Me.cmbSessionTo.Location = New System.Drawing.Point(385, 39)
        Me.cmbSessionTo.Name = "cmbSessionTo"
        Me.cmbSessionTo.Size = New System.Drawing.Size(162, 24)
        Me.cmbSessionTo.TabIndex = 117
        '
        'dtfrom
        '
        Me.dtfrom.Location = New System.Drawing.Point(169, 77)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(81, 20)
        Me.dtfrom.TabIndex = 116
        '
        'dgnew
        '
        Me.dgnew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgnew.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgnew.Location = New System.Drawing.Point(493, 115)
        Me.dgnew.Name = "dgnew"
        Me.dgnew.Size = New System.Drawing.Size(523, 586)
        Me.dgnew.TabIndex = 124
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "S.NO"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Closing Dr."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Closing Cr."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmUpdateOpeningofNextSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.dgnew)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chkwithzero)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.cmbGroups)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbSession)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgCurrentSession)
        Me.Controls.Add(Me.cmbSessionTo)
        Me.Controls.Add(Me.dtfrom)
        'Me.name = "frmUpdateOpeningofNextSession"
        Me.Text = "frmUpdateOpeningofNextSession"
        CType(Me.dgCurrentSession, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgnew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chkwithzero As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents cmbGroups As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbSession As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgCurrentSession As System.Windows.Forms.DataGridView
    Friend WithEvents sno As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbSessionTo As System.Windows.Forms.ComboBox
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgnew As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
