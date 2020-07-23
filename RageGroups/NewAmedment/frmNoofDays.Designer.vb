<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoofDays
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
        Me.Cramt = New System.Windows.Forms.Label
        Me.txtCrmat = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cramt
        '
        Me.Cramt.AutoSize = True
        Me.Cramt.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cramt.Location = New System.Drawing.Point(54, 9)
        Me.Cramt.Name = "Cramt"
        Me.Cramt.Size = New System.Drawing.Size(75, 18)
        Me.Cramt.TabIndex = 157
        Me.Cramt.Text = "No of Days"
        '
        'txtCrmat
        '
        Me.txtCrmat.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrmat.Location = New System.Drawing.Point(54, 30)
        Me.txtCrmat.Name = "txtCrmat"
        Me.txtCrmat.Size = New System.Drawing.Size(71, 24)
        Me.txtCrmat.TabIndex = 156
        Me.txtCrmat.Text = "0.0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 158
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmNoofDays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 97)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cramt)
        Me.Controls.Add(Me.txtCrmat)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNoofDays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNoofDays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cramt As System.Windows.Forms.Label
    Friend WithEvents txtCrmat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
