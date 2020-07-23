<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNarrationUpdate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtvdate = New System.Windows.Forms.DateTimePicker()
        Me.txtvono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbcptype = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtOldNarration = New System.Windows.Forms.TextBox()
        Me.txtnewnarration = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1182, 35)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Narration Updation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtvdate
        '
        Me.dtvdate.CustomFormat = "dd/MMM/yy"
        Me.dtvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtvdate.Location = New System.Drawing.Point(477, 37)
        Me.dtvdate.Name = "dtvdate"
        Me.dtvdate.Size = New System.Drawing.Size(89, 20)
        Me.dtvdate.TabIndex = 73
        '
        'txtvono
        '
        Me.txtvono.Location = New System.Drawing.Point(379, 38)
        Me.txtvono.Name = "txtvono"
        Me.txtvono.Size = New System.Drawing.Size(92, 20)
        Me.txtvono.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Voucher Type"
        '
        'cmbcptype
        '
        Me.cmbcptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcptype.FormattingEnabled = True
        Me.cmbcptype.Items.AddRange(New Object() {"Bank", "Cash", "Journal"})
        Me.cmbcptype.Location = New System.Drawing.Point(102, 38)
        Me.cmbcptype.Name = "cmbcptype"
        Me.cmbcptype.Size = New System.Drawing.Size(184, 21)
        Me.cmbcptype.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Voucher No"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 208)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 209)
        Me.DataGridView1.TabIndex = 75
        '
        'txtOldNarration
        '
        Me.txtOldNarration.Location = New System.Drawing.Point(4, 80)
        Me.txtOldNarration.Multiline = True
        Me.txtOldNarration.Name = "txtOldNarration"
        Me.txtOldNarration.Size = New System.Drawing.Size(540, 122)
        Me.txtOldNarration.TabIndex = 76
        '
        'txtnewnarration
        '
        Me.txtnewnarration.Location = New System.Drawing.Point(550, 80)
        Me.txtnewnarration.Multiline = True
        Me.txtnewnarration.Name = "txtnewnarration"
        Me.txtnewnarration.Size = New System.Drawing.Size(513, 122)
        Me.txtnewnarration.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Old Narration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label5.Location = New System.Drawing.Point(550, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 15)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "New Narration"
        '
        'btnshow
        '
        Me.btnshow.Location = New System.Drawing.Point(572, 37)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(75, 23)
        Me.btnshow.TabIndex = 80
        Me.btnshow.Text = "&Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(1069, 80)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 81
        Me.btnupdate.Text = "&Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'frmNarrationUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1182, 425)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnewnarration)
        Me.Controls.Add(Me.txtOldNarration)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtvdate)
        Me.Controls.Add(Me.txtvono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbcptype)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNarrationUpdate"
        Me.Text = "frmNarrationUpdate"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtvono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbcptype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtOldNarration As System.Windows.Forms.TextBox
    Friend WithEvents txtnewnarration As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
