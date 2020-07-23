<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendBulkSms
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.dgvoucher = New System.Windows.Forms.DataGridView
        Me.mobno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.od = New System.Windows.Forms.OpenFileDialog
        Me.btnShow = New System.Windows.Forms.Button
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Honeydew
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 409)
        Me.TextBox1.MaxLength = 500
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(810, 102)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cornsilk
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 517)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(810, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Send"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(535, 310)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'dgvoucher
        '
        Me.dgvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mobno})
        Me.dgvoucher.Location = New System.Drawing.Point(12, 1)
        Me.dgvoucher.Name = "dgvoucher"
        Me.dgvoucher.Size = New System.Drawing.Size(240, 402)
        Me.dgvoucher.TabIndex = 3
        '
        'mobno
        '
        Me.mobno.HeaderText = "mobno"
        Me.mobno.Name = "mobno"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Button2.Location = New System.Drawing.Point(365, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 119
        Me.Button2.Text = "Import"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'od
        '
        Me.od.FileName = "OpenFileDialog1"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.btnShow.Location = New System.Drawing.Point(471, 180)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(100, 23)
        Me.btnShow.TabIndex = 120
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmSendBulkSms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 570)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvoucher)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSendBulkSms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSendBulkSms"
        CType(Me.dgvoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents dgvoucher As System.Windows.Forms.DataGridView
    Friend WithEvents mobno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents od As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
