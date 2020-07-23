<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdayBookAuth
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.listgrp = New System.Windows.Forms.CheckedListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.btnAuth = New System.Windows.Forms.Button()
        Me.rdPrint = New System.Windows.Forms.RadioButton()
        Me.rdOnscreen = New System.Windows.Forms.RadioButton()
        Me.dgAuth = New System.Windows.Forms.DataGridView()
        CType(Me.dgAuth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 112)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1240, 621)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1240, 31)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Authorization"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(991, 34)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(82, 28)
        Me.btnclose.TabIndex = 75
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(793, 34)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(61, 28)
        Me.btnshow.TabIndex = 74
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'listgrp
        '
        Me.listgrp.CheckOnClick = True
        Me.listgrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listgrp.FormattingEnabled = True
        Me.listgrp.Location = New System.Drawing.Point(23, 34)
        Me.listgrp.Name = "listgrp"
        Me.listgrp.Size = New System.Drawing.Size(212, 72)
        Me.listgrp.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(249, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Voucher No:"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(337, 35)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(65, 20)
        Me.txtFrom.TabIndex = 106
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(408, 34)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(65, 20)
        Me.txtTo.TabIndex = 107
        '
        'btnAuth
        '
        Me.btnAuth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuth.Location = New System.Drawing.Point(860, 34)
        Me.btnAuth.Name = "btnAuth"
        Me.btnAuth.Size = New System.Drawing.Size(125, 28)
        Me.btnAuth.TabIndex = 108
        Me.btnAuth.Text = "&Authorization"
        Me.btnAuth.UseVisualStyleBackColor = True
        '
        'rdPrint
        '
        Me.rdPrint.AutoSize = True
        Me.rdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPrint.Location = New System.Drawing.Point(571, 37)
        Me.rdPrint.Name = "rdPrint"
        Me.rdPrint.Size = New System.Drawing.Size(55, 19)
        Me.rdPrint.TabIndex = 110
        Me.rdPrint.Text = "Print"
        Me.rdPrint.UseVisualStyleBackColor = True
        '
        'rdOnscreen
        '
        Me.rdOnscreen.AutoSize = True
        Me.rdOnscreen.Checked = True
        Me.rdOnscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOnscreen.Location = New System.Drawing.Point(491, 37)
        Me.rdOnscreen.Name = "rdOnscreen"
        Me.rdOnscreen.Size = New System.Drawing.Size(70, 19)
        Me.rdOnscreen.TabIndex = 109
        Me.rdOnscreen.TabStop = True
        Me.rdOnscreen.Text = "Screen"
        Me.rdOnscreen.UseVisualStyleBackColor = True
        '
        'dgAuth
        '
        Me.dgAuth.AllowUserToAddRows = False
        Me.dgAuth.AllowUserToDeleteRows = False
        Me.dgAuth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAuth.Location = New System.Drawing.Point(0, 116)
        Me.dgAuth.Name = "dgAuth"
        Me.dgAuth.ReadOnly = True
        Me.dgAuth.Size = New System.Drawing.Size(1228, 558)
        Me.dgAuth.TabIndex = 111
        '
        'frmdayBookAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1240, 733)
        Me.Controls.Add(Me.dgAuth)
        Me.Controls.Add(Me.rdPrint)
        Me.Controls.Add(Me.rdOnscreen)
        Me.Controls.Add(Me.btnAuth)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.listgrp)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmdayBookAuth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgAuth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents listgrp As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents btnAuth As System.Windows.Forms.Button
    Friend WithEvents rdPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnscreen As System.Windows.Forms.RadioButton
    Friend WithEvents dgAuth As System.Windows.Forms.DataGridView
End Class
