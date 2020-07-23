<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTdsModification
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbvtype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVouNo = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.dgTdsEntry = New System.Windows.Forms.DataGridView()
        CType(Me.dgTdsEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Teal
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1198, 31)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Tds Updation Form"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Honeydew
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Voucher No:"
        '
        'cmbvtype
        '
        Me.cmbvtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbvtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbvtype.BackColor = System.Drawing.Color.White
        Me.cmbvtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvtype.FormattingEnabled = True
        Me.cmbvtype.Location = New System.Drawing.Point(105, 46)
        Me.cmbvtype.Name = "cmbvtype"
        Me.cmbvtype.Size = New System.Drawing.Size(170, 21)
        Me.cmbvtype.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Honeydew
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Voucher Type:"
        '
        'txtVouNo
        '
        Me.txtVouNo.Location = New System.Drawing.Point(373, 47)
        Me.txtVouNo.Name = "txtVouNo"
        Me.txtVouNo.Size = New System.Drawing.Size(100, 20)
        Me.txtVouNo.TabIndex = 164
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(480, 47)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 165
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'dgTdsEntry
        '
        Me.dgTdsEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTdsEntry.Location = New System.Drawing.Point(12, 90)
        Me.dgTdsEntry.Name = "dgTdsEntry"
        Me.dgTdsEntry.Size = New System.Drawing.Size(1174, 332)
        Me.dgTdsEntry.TabIndex = 166
        '
        'frmTdsModification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 526)
        Me.Controls.Add(Me.dgTdsEntry)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtVouNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbvtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Name = "frmTdsModification"
        Me.Text = "frmTdsModification"
        CType(Me.dgTdsEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbvtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVouNo As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents dgTdsEntry As System.Windows.Forms.DataGridView
End Class
