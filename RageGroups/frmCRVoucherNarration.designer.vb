<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRVoucherNarration
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
        Me.dtTrDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTRNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdCash = New System.Windows.Forms.RadioButton()
        Me.rdDD = New System.Windows.Forms.RadioButton()
        Me.rdCheque = New System.Windows.Forms.RadioButton()
        Me.txtDDChqNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtHatchDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbpaymenttype = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdRTGS = New System.Windows.Forms.RadioButton()
        Me.rdNeft = New System.Windows.Forms.RadioButton()
        Me.rdTrans = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Narration Creation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtTrDate
        '
        Me.dtTrDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTrDate.CustomFormat = "dd/MMM/yy"
        Me.dtTrDate.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTrDate.Location = New System.Drawing.Point(241, 34)
        Me.dtTrDate.Name = "dtTrDate"
        Me.dtTrDate.Size = New System.Drawing.Size(101, 25)
        Me.dtTrDate.TabIndex = 1
        '
        'txtTRNo
        '
        Me.txtTRNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.txtTRNo.Location = New System.Drawing.Point(53, 34)
        Me.txtTRNo.MaxLength = 40
        Me.txtTRNo.Name = "txtTRNo"
        Me.txtTRNo.Size = New System.Drawing.Size(128, 22)
        Me.txtTRNo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(189, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Dated:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TR No."
        '
        'rdCash
        '
        Me.rdCash.AutoSize = True
        Me.rdCash.Checked = True
        Me.rdCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCash.Location = New System.Drawing.Point(3, 60)
        Me.rdCash.Name = "rdCash"
        Me.rdCash.Size = New System.Drawing.Size(57, 19)
        Me.rdCash.TabIndex = 2
        Me.rdCash.TabStop = True
        Me.rdCash.Text = "Cash"
        Me.rdCash.UseVisualStyleBackColor = True
        '
        'rdDD
        '
        Me.rdDD.AutoSize = True
        Me.rdDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDD.Location = New System.Drawing.Point(64, 60)
        Me.rdDD.Name = "rdDD"
        Me.rdDD.Size = New System.Drawing.Size(49, 19)
        Me.rdDD.TabIndex = 3
        Me.rdDD.Text = "DD "
        Me.rdDD.UseVisualStyleBackColor = True
        '
        'rdCheque
        '
        Me.rdCheque.AutoSize = True
        Me.rdCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCheque.Location = New System.Drawing.Point(116, 60)
        Me.rdCheque.Name = "rdCheque"
        Me.rdCheque.Size = New System.Drawing.Size(74, 19)
        Me.rdCheque.TabIndex = 4
        Me.rdCheque.Text = "Cheque"
        Me.rdCheque.UseVisualStyleBackColor = True
        '
        'txtDDChqNO
        '
        Me.txtDDChqNO.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDDChqNO.Location = New System.Drawing.Point(194, 81)
        Me.txtDDChqNO.MaxLength = 40
        Me.txtDDChqNO.Name = "txtDDChqNO"
        Me.txtDDChqNO.Size = New System.Drawing.Size(128, 21)
        Me.txtDDChqNO.TabIndex = 5
        Me.txtDDChqNO.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "DD/Chq No./RTGS/NEFT"
        Me.Label2.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(276, 160)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(41, 23)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(323, 160)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(51, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(192, 81)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 21)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(194, 106)
        Me.TextBox2.MaxLength = 40
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 22)
        Me.TextBox2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "By:"
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Hatch Date:"
        '
        'dtHatchDate
        '
        Me.dtHatchDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHatchDate.CustomFormat = "dd/MMM/yyyy"
        Me.dtHatchDate.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHatchDate.Location = New System.Drawing.Point(137, 158)
        Me.dtHatchDate.Name = "dtHatchDate"
        Me.dtHatchDate.Size = New System.Drawing.Size(127, 25)
        Me.dtHatchDate.TabIndex = 8
        Me.dtHatchDate.Value = New Date(2000, 1, 1, 17, 7, 0, 0)
        '
        'cmbpaymenttype
        '
        Me.cmbpaymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpaymenttype.FormattingEnabled = True
        Me.cmbpaymenttype.Items.AddRange(New Object() {"OLD PAYMENT", "ADVANCE PAYMENT", "CURRENT PAYMENT"})
        Me.cmbpaymenttype.Location = New System.Drawing.Point(192, 132)
        Me.cmbpaymenttype.Name = "cmbpaymenttype"
        Me.cmbpaymenttype.Size = New System.Drawing.Size(127, 21)
        Me.cmbpaymenttype.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Payment Type:"
        Me.Label7.Visible = False
        '
        'rdRTGS
        '
        Me.rdRTGS.AutoSize = True
        Me.rdRTGS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdRTGS.Location = New System.Drawing.Point(190, 60)
        Me.rdRTGS.Name = "rdRTGS"
        Me.rdRTGS.Size = New System.Drawing.Size(62, 19)
        Me.rdRTGS.TabIndex = 21
        Me.rdRTGS.Text = "RTGS"
        Me.rdRTGS.UseVisualStyleBackColor = True
        '
        'rdNeft
        '
        Me.rdNeft.AutoSize = True
        Me.rdNeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNeft.Location = New System.Drawing.Point(255, 60)
        Me.rdNeft.Name = "rdNeft"
        Me.rdNeft.Size = New System.Drawing.Size(60, 19)
        Me.rdNeft.TabIndex = 22
        Me.rdNeft.Text = "NEFT"
        Me.rdNeft.UseVisualStyleBackColor = True
        '
        'rdTrans
        '
        Me.rdTrans.AutoSize = True
        Me.rdTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTrans.Location = New System.Drawing.Point(312, 60)
        Me.rdTrans.Name = "rdTrans"
        Me.rdTrans.Size = New System.Drawing.Size(78, 19)
        Me.rdTrans.TabIndex = 23
        Me.rdTrans.Text = "Transfer"
        Me.rdTrans.UseVisualStyleBackColor = True
        '
        'frmCRVoucherNarration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(393, 196)
        Me.Controls.Add(Me.rdTrans)
        Me.Controls.Add(Me.rdNeft)
        Me.Controls.Add(Me.rdRTGS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbpaymenttype)
        Me.Controls.Add(Me.dtHatchDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtDDChqNO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdCheque)
        Me.Controls.Add(Me.rdDD)
        Me.Controls.Add(Me.rdCash)
        Me.Controls.Add(Me.dtTrDate)
        Me.Controls.Add(Me.txtTRNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCRVoucherNarration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCRVoucherNarration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtTrDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTRNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdCash As System.Windows.Forms.RadioButton
    Friend WithEvents rdDD As System.Windows.Forms.RadioButton
    Friend WithEvents rdCheque As System.Windows.Forms.RadioButton
    Friend WithEvents txtDDChqNO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtHatchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbpaymenttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rdRTGS As System.Windows.Forms.RadioButton
    Friend WithEvents rdNeft As System.Windows.Forms.RadioButton
    Friend WithEvents rdTrans As System.Windows.Forms.RadioButton
End Class
