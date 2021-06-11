<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupply
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Auth = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtAreaCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dm1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dm2 = New System.Windows.Forms.TextBox()
        Me.dgDetials = New System.Windows.Forms.DataGridView()
        Me.ChkisDm = New System.Windows.Forms.CheckBox()
        Me.ChkisCm = New System.Windows.Forms.CheckBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auth})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle11
        Me.dg.Location = New System.Drawing.Point(-4, 124)
        Me.dg.Name = "dg"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dg.Size = New System.Drawing.Size(1249, 339)
        Me.dg.TabIndex = 15
        '
        'Auth
        '
        Me.Auth.FalseValue = "0"
        Me.Auth.HeaderText = "Auth"
        Me.Auth.Name = "Auth"
        Me.Auth.TrueValue = "1"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(611, 58)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 29)
        Me.btnShow.TabIndex = 13
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-23, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1281, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Area Wise Supply Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(692, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "AUTH."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL AREA", "SELECTED AREA"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'txtAreaCode
        '
        Me.txtAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaCode.Location = New System.Drawing.Point(267, 55)
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(125, 26)
        Me.txtAreaCode.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Area :"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(529, 96)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton1.TabIndex = 52
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "On Screen"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(611, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 180)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1233, 283)
        Me.CrystalReportViewer1.TabIndex = 54
        '
        'dm1
        '
        Me.dm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dm1.Location = New System.Drawing.Point(267, 90)
        Me.dm1.Name = "dm1"
        Me.dm1.Size = New System.Drawing.Size(125, 26)
        Me.dm1.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "DM No :"
        '
        'dm2
        '
        Me.dm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dm2.Location = New System.Drawing.Point(398, 92)
        Me.dm2.Name = "dm2"
        Me.dm2.Size = New System.Drawing.Size(125, 26)
        Me.dm2.TabIndex = 57
        '
        'dgDetials
        '
        Me.dgDetials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetials.Location = New System.Drawing.Point(12, 482)
        Me.dgDetials.Name = "dgDetials"
        Me.dgDetials.Size = New System.Drawing.Size(1210, 220)
        Me.dgDetials.TabIndex = 58
        '
        'ChkisDm
        '
        Me.ChkisDm.AutoSize = True
        Me.ChkisDm.Checked = True
        Me.ChkisDm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkisDm.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkisDm.Location = New System.Drawing.Point(409, 57)
        Me.ChkisDm.Name = "ChkisDm"
        Me.ChkisDm.Size = New System.Drawing.Size(53, 24)
        Me.ChkisDm.TabIndex = 59
        Me.ChkisDm.Text = "DM"
        Me.ChkisDm.UseVisualStyleBackColor = True
        '
        'ChkisCm
        '
        Me.ChkisCm.AutoSize = True
        Me.ChkisCm.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkisCm.Location = New System.Drawing.Point(472, 57)
        Me.ChkisCm.Name = "ChkisCm"
        Me.ChkisCm.Size = New System.Drawing.Size(51, 24)
        Me.ChkisCm.TabIndex = 60
        Me.ChkisCm.Text = "CM"
        Me.ChkisCm.UseVisualStyleBackColor = True
        '
        'FormSupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 749)
        Me.Controls.Add(Me.ChkisCm)
        Me.Controls.Add(Me.ChkisDm)
        Me.Controls.Add(Me.dgDetials)
        Me.Controls.Add(Me.dm2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dm1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtAreaCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormSupply"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSupply"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Auth As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dm1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dm2 As System.Windows.Forms.TextBox
    Friend WithEvents dgDetials As System.Windows.Forms.DataGridView
    Friend WithEvents ChkisDm As System.Windows.Forms.CheckBox
    Friend WithEvents ChkisCm As System.Windows.Forms.CheckBox
End Class
