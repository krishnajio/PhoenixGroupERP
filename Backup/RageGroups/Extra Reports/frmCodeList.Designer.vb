<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodeList
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnshow = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.cmbgroupsuffix = New System.Windows.Forms.ComboBox
        Me.cmbgrpname = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgaccounthead = New System.Windows.Forms.DataGridView
        Me.acheadcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.accname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subgrp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Ivory
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(958, 41)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "Code List"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Date From:"
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(392, 7)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(58, 28)
        Me.btnshow.TabIndex = 136
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.cmbgroupsuffix)
        Me.GroupBox1.Controls.Add(Me.cmbgrpname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnshow)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 65)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Se&arch :"
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(111, 37)
        Me.txtsearch.MaxLength = 40
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(275, 22)
        Me.txtsearch.TabIndex = 140
        '
        'cmbgroupsuffix
        '
        Me.cmbgroupsuffix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgroupsuffix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroupsuffix.BackColor = System.Drawing.Color.White
        Me.cmbgroupsuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgroupsuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroupsuffix.FormattingEnabled = True
        Me.cmbgroupsuffix.Location = New System.Drawing.Point(305, 10)
        Me.cmbgroupsuffix.Name = "cmbgroupsuffix"
        Me.cmbgroupsuffix.Size = New System.Drawing.Size(79, 21)
        Me.cmbgroupsuffix.TabIndex = 138
        '
        'cmbgrpname
        '
        Me.cmbgrpname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbgrpname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrpname.BackColor = System.Drawing.Color.White
        Me.cmbgrpname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgrpname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrpname.FormattingEnabled = True
        Me.cmbgrpname.Location = New System.Drawing.Point(111, 10)
        Me.cmbgrpname.Name = "cmbgrpname"
        Me.cmbgrpname.Size = New System.Drawing.Size(190, 21)
        Me.cmbgrpname.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Select Group :"
        '
        'dgaccounthead
        '
        Me.dgaccounthead.AllowUserToAddRows = False
        Me.dgaccounthead.AllowUserToDeleteRows = False
        Me.dgaccounthead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaccounthead.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acheadcode, Me.accname, Me.grp, Me.subgrp, Me.dr, Me.cr})
        Me.dgaccounthead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgaccounthead.Location = New System.Drawing.Point(0, 106)
        Me.dgaccounthead.Name = "dgaccounthead"
        Me.dgaccounthead.ReadOnly = True
        Me.dgaccounthead.Size = New System.Drawing.Size(958, 491)
        Me.dgaccounthead.TabIndex = 139
        '
        'acheadcode
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acheadcode.DefaultCellStyle = DataGridViewCellStyle2
        Me.acheadcode.HeaderText = "Account Head Code"
        Me.acheadcode.Name = "acheadcode"
        Me.acheadcode.ReadOnly = True
        Me.acheadcode.Width = 80
        '
        'accname
        '
        Me.accname.HeaderText = "Account Head Name"
        Me.accname.Name = "accname"
        Me.accname.ReadOnly = True
        Me.accname.Width = 300
        '
        'grp
        '
        Me.grp.HeaderText = "Group"
        Me.grp.Name = "grp"
        Me.grp.ReadOnly = True
        Me.grp.Width = 80
        '
        'subgrp
        '
        Me.subgrp.HeaderText = "Sub Group"
        Me.subgrp.Name = "subgrp"
        Me.subgrp.ReadOnly = True
        Me.subgrp.Width = 80
        '
        'dr
        '
        Me.dr.HeaderText = "Opening Dr"
        Me.dr.Name = "dr"
        Me.dr.ReadOnly = True
        Me.dr.Width = 75
        '
        'cr
        '
        Me.cr.HeaderText = "Opening Cr"
        Me.cr.Name = "cr"
        Me.cr.ReadOnly = True
        Me.cr.Width = 75
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 106)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(958, 491)
        Me.CrystalReportViewer1.TabIndex = 140
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'frmCodeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(958, 597)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.dgaccounthead)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Name = "frmCodeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCodeList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgaccounthead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbgroupsuffix As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgaccounthead As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents acheadcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subgrp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
