<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRTGSchqPrint
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtAmt = New System.Windows.Forms.TextBox
        Me.label = New System.Windows.Forms.Label
        Me.Dtpchqdate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtChqNo = New System.Windows.Forms.TextBox
        Me.chqsetup = New System.Windows.Forms.PageSetupDialog
        Me.chqdocument = New System.Drawing.Printing.PrintDocument
        Me.chqprintpreview = New System.Windows.Forms.PrintDialog
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtSrNo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 43)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Voucher and Cheque print"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(129, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 23)
        Me.Button2.TabIndex = 186
        Me.Button2.Text = "Cheque Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Cheque Date :"
        '
        'TxtAmt
        '
        Me.TxtAmt.Location = New System.Drawing.Point(110, 112)
        Me.TxtAmt.Name = "TxtAmt"
        Me.TxtAmt.Size = New System.Drawing.Size(214, 20)
        Me.TxtAmt.TabIndex = 188
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(12, 112)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(90, 18)
        Me.label.TabIndex = 189
        Me.label.Text = "Cheque Amt :"
        '
        'Dtpchqdate
        '
        Me.Dtpchqdate.CustomFormat = "dd/MM/yyyy"
        Me.Dtpchqdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtpchqdate.Location = New System.Drawing.Point(110, 74)
        Me.Dtpchqdate.Name = "Dtpchqdate"
        Me.Dtpchqdate.Size = New System.Drawing.Size(100, 20)
        Me.Dtpchqdate.TabIndex = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Cheque No. :"
        '
        'TxtChqNo
        '
        Me.TxtChqNo.Location = New System.Drawing.Point(110, 147)
        Me.TxtChqNo.Name = "TxtChqNo"
        Me.TxtChqNo.Size = New System.Drawing.Size(214, 20)
        Me.TxtChqNo.TabIndex = 192
        '
        'chqsetup
        '
        Me.chqsetup.Document = Me.chqdocument
        '
        'chqdocument
        '
        '
        'chqprintpreview
        '
        Me.chqprintpreview.Document = Me.chqdocument
        Me.chqprintpreview.UseEXDialog = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Sr. No. :"
        '
        'TxtSrNo
        '
        Me.TxtSrNo.Location = New System.Drawing.Point(110, 175)
        Me.TxtSrNo.Name = "TxtSrNo"
        Me.TxtSrNo.Size = New System.Drawing.Size(214, 20)
        Me.TxtSrNo.TabIndex = 194
        '
        'FrmRTGSchqPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 254)
        Me.Controls.Add(Me.TxtSrNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtChqNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dtpchqdate)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.TxtAmt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRTGSchqPrint"
        Me.Text = "FrmRTGSchqPrint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtAmt As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Dtpchqdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtChqNo As System.Windows.Forms.TextBox
    Friend WithEvents chqsetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents chqdocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents chqprintpreview As System.Windows.Forms.PrintDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtSrNo As System.Windows.Forms.TextBox
End Class
