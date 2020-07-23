<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMisMactchEntryList
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
        Me.dgVentry = New System.Windows.Forms.DataGridView
        Me.dgInventory = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdname = New System.Windows.Forms.RadioButton
        Me.rdcode = New System.Windows.Forms.RadioButton
        Me.txtVouno = New System.Windows.Forms.TextBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.dgVentry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVentry
        '
        Me.dgVentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentry.Location = New System.Drawing.Point(12, 27)
        Me.dgVentry.Name = "dgVentry"
        Me.dgVentry.Size = New System.Drawing.Size(1004, 269)
        Me.dgVentry.TabIndex = 0
        '
        'dgInventory
        '
        Me.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInventory.Location = New System.Drawing.Point(12, 396)
        Me.dgInventory.Name = "dgInventory"
        Me.dgInventory.Size = New System.Drawing.Size(1004, 271)
        Me.dgInventory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ventry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inventory"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rdname
        '
        Me.rdname.AutoSize = True
        Me.rdname.Location = New System.Drawing.Point(122, 4)
        Me.rdname.Name = "rdname"
        Me.rdname.Size = New System.Drawing.Size(68, 17)
        Me.rdname.TabIndex = 4
        Me.rdname.TabStop = True
        Me.rdname.Text = "By Name"
        Me.rdname.UseVisualStyleBackColor = True
        '
        'rdcode
        '
        Me.rdcode.AutoSize = True
        Me.rdcode.Location = New System.Drawing.Point(209, 4)
        Me.rdcode.Name = "rdcode"
        Me.rdcode.Size = New System.Drawing.Size(65, 17)
        Me.rdcode.TabIndex = 5
        Me.rdcode.TabStop = True
        Me.rdcode.Text = "By Code"
        Me.rdcode.UseVisualStyleBackColor = True
        '
        'txtVouno
        '
        Me.txtVouno.Location = New System.Drawing.Point(15, 342)
        Me.txtVouno.Name = "txtVouno"
        Me.txtVouno.Size = New System.Drawing.Size(100, 20)
        Me.txtVouno.TabIndex = 6
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(122, 339)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Update Hatch Date"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(470, 344)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(576, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmMisMactchEntryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1016, 666)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtVouno)
        Me.Controls.Add(Me.rdcode)
        Me.Controls.Add(Me.rdname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgInventory)
        Me.Controls.Add(Me.dgVentry)
        Me.Name = "frmMisMactchEntryList"
        Me.Text = "frmMisMactchEntryList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgVentry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgVentry As System.Windows.Forms.DataGridView
    Friend WithEvents dgInventory As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdname As System.Windows.Forms.RadioButton
    Friend WithEvents rdcode As System.Windows.Forms.RadioButton
    Friend WithEvents txtVouno As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
