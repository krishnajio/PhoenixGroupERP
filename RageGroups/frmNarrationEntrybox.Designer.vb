<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNarrationEntrybox
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
        Me.txtNarrationEntrty = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtNarrationEntrty
        '
        Me.txtNarrationEntrty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarrationEntrty.Location = New System.Drawing.Point(0, 0)
        Me.txtNarrationEntrty.MaxLength = 180
        Me.txtNarrationEntrty.Multiline = True
        Me.txtNarrationEntrty.Name = "txtNarrationEntrty"
        Me.txtNarrationEntrty.Size = New System.Drawing.Size(364, 108)
        Me.txtNarrationEntrty.TabIndex = 0
        '
        'frmNarrationEntrybox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 112)
        Me.Controls.Add(Me.txtNarrationEntrty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNarrationEntrybox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Narration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNarrationEntrty As System.Windows.Forms.TextBox
End Class
