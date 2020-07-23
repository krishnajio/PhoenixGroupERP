<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmacheadlist
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
        Me.panelachead = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbgroup = New System.Windows.Forms.ComboBox
        Me.cmbacheadlist = New System.Windows.Forms.ComboBox
        Me.cmbAreaName = New System.Windows.Forms.ComboBox
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.panelachead.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelachead
        '
        Me.panelachead.BackColor = System.Drawing.Color.Wheat
        Me.panelachead.Controls.Add(Me.Label1)
        Me.panelachead.Controls.Add(Me.cmbgroup)
        Me.panelachead.Controls.Add(Me.cmbacheadlist)
        Me.panelachead.Controls.Add(Me.cmbAreaName)
        Me.panelachead.Controls.Add(Me.cmbAreaCode)
        Me.panelachead.Controls.Add(Me.Label5)
        Me.panelachead.Location = New System.Drawing.Point(1, 1)
        Me.panelachead.Name = "panelachead"
        Me.panelachead.Size = New System.Drawing.Size(386, 437)
        Me.panelachead.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Select Group"
        '
        'cmbgroup
        '
        Me.cmbgroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbgroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgroup.BackColor = System.Drawing.Color.White
        Me.cmbgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgroup.FormattingEnabled = True
        Me.cmbgroup.Location = New System.Drawing.Point(123, 52)
        Me.cmbgroup.Name = "cmbgroup"
        Me.cmbgroup.Size = New System.Drawing.Size(250, 21)
        Me.cmbgroup.TabIndex = 1
        '
        'cmbacheadlist
        '
        Me.cmbacheadlist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmbacheadlist.AllowDrop = True
        Me.cmbacheadlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbacheadlist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbacheadlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbacheadlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbacheadlist.Location = New System.Drawing.Point(8, 84)
        Me.cmbacheadlist.Name = "cmbacheadlist"
        Me.cmbacheadlist.Size = New System.Drawing.Size(365, 345)
        Me.cmbacheadlist.TabIndex = 0
        '
        'cmbAreaName
        '
        Me.cmbAreaName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaName.BackColor = System.Drawing.Color.White
        Me.cmbAreaName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaName.FormattingEnabled = True
        Me.cmbAreaName.Location = New System.Drawing.Point(123, 25)
        Me.cmbAreaName.Name = "cmbAreaName"
        Me.cmbAreaName.Size = New System.Drawing.Size(250, 21)
        Me.cmbAreaName.TabIndex = 2
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAreaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAreaCode.BackColor = System.Drawing.Color.White
        Me.cmbAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(8, 25)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(109, 21)
        Me.cmbAreaCode.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 15)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Account Head (Code/Name)  :"
        '
        'frmacheadlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 440)
        Me.Controls.Add(Me.panelachead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmacheadlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Heads"
        Me.panelachead.ResumeLayout(False)
        Me.panelachead.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelachead As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents cmbAreaName As System.Windows.Forms.ComboBox
    Public WithEvents cmbAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbacheadlist As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cmbgroup As System.Windows.Forms.ComboBox
End Class
