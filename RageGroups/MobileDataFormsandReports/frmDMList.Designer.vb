<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDMList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkisCm = New System.Windows.Forms.CheckBox()
        Me.ChkisDm = New System.Windows.Forms.CheckBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtAreaCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Auth = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1300, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DM Post To Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkisCm
        '
        Me.ChkisCm.AutoSize = True
        Me.ChkisCm.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkisCm.Location = New System.Drawing.Point(291, 31)
        Me.ChkisCm.Name = "ChkisCm"
        Me.ChkisCm.Size = New System.Drawing.Size(51, 24)
        Me.ChkisCm.TabIndex = 67
        Me.ChkisCm.Text = "CM"
        Me.ChkisCm.UseVisualStyleBackColor = True
        '
        'ChkisDm
        '
        Me.ChkisDm.AutoSize = True
        Me.ChkisDm.Checked = True
        Me.ChkisDm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkisDm.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkisDm.Location = New System.Drawing.Point(228, 31)
        Me.ChkisDm.Name = "ChkisDm"
        Me.ChkisDm.Size = New System.Drawing.Size(53, 24)
        Me.ChkisDm.TabIndex = 66
        Me.ChkisDm.Text = "DM"
        Me.ChkisDm.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(359, 31)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 26)
        Me.btnShow.TabIndex = 65
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtAreaCode
        '
        Me.txtAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaCode.Location = New System.Drawing.Point(88, 29)
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(125, 26)
        Me.txtAreaCode.TabIndex = 64
        Me.txtAreaCode.Text = "GSPR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Area :"
        '
        'dg
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auth})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg.Location = New System.Drawing.Point(12, 83)
        Me.dg.Name = "dg"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg.Size = New System.Drawing.Size(1292, 493)
        Me.dg.TabIndex = 68
        '
        'Auth
        '
        Me.Auth.FalseValue = "0"
        Me.Auth.HeaderText = "Auth"
        Me.Auth.Name = "Auth"
        Me.Auth.TrueValue = "1"
        '
        'frmDMList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 588)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.ChkisCm)
        Me.Controls.Add(Me.ChkisDm)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtAreaCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDMList"
        Me.Text = "frmDMList"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkisCm As System.Windows.Forms.CheckBox
    Friend WithEvents ChkisDm As System.Windows.Forms.CheckBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Auth As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
