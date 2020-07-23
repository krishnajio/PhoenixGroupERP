<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRtgsLayout
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
        Me.txtlength = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtheight = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btninfav1 = New System.Windows.Forms.Button
        Me.btndate = New System.Windows.Forms.Button
        Me.btnbranch = New System.Windows.Forms.Button
        Me.btnamt = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbFormat = New System.Windows.Forms.ComboBox
        Me.btnbrowse = New System.Windows.Forms.Button
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbbank = New System.Windows.Forms.ComboBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbbankcode = New System.Windows.Forms.ComboBox
        Me.btnAmtInWrd = New System.Windows.Forms.Button
        Me.btnConfirmAcc = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BtnBeneAccNo = New System.Windows.Forms.Button
        Me.BtnBank = New System.Windows.Forms.Button
        Me.BtnBeneAdd = New System.Windows.Forms.Button
        Me.btncity = New System.Windows.Forms.Button
        Me.Btncheqe = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtlength
        '
        Me.txtlength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlength.Location = New System.Drawing.Point(162, 58)
        Me.txtlength.Name = "txtlength"
        Me.txtlength.Size = New System.Drawing.Size(48, 21)
        Me.txtlength.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Size of Cheque :"
        '
        'txtheight
        '
        Me.txtheight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtheight.Location = New System.Drawing.Point(293, 59)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(48, 21)
        Me.txtheight.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        '
        'btninfav1
        '
        Me.btninfav1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninfav1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninfav1.Location = New System.Drawing.Point(86, 44)
        Me.btninfav1.Name = "btninfav1"
        Me.btninfav1.Size = New System.Drawing.Size(157, 24)
        Me.btninfav1.TabIndex = 5
        Me.btninfav1.Text = "In Favoure of -1"
        Me.btninfav1.UseVisualStyleBackColor = True
        '
        'btndate
        '
        Me.btndate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndate.Location = New System.Drawing.Point(512, 8)
        Me.btndate.Name = "btndate"
        Me.btndate.Size = New System.Drawing.Size(125, 32)
        Me.btndate.TabIndex = 6
        Me.btndate.Text = "DD-MMM-YY"
        Me.btndate.UseVisualStyleBackColor = True
        '
        'btnbranch
        '
        Me.btnbranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbranch.Location = New System.Drawing.Point(265, 128)
        Me.btnbranch.Name = "btnbranch"
        Me.btnbranch.Size = New System.Drawing.Size(157, 22)
        Me.btnbranch.TabIndex = 7
        Me.btnbranch.Text = "Benefi bank branch"
        Me.btnbranch.UseVisualStyleBackColor = True
        '
        'btnamt
        '
        Me.btnamt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamt.Location = New System.Drawing.Point(388, 44)
        Me.btnamt.Name = "btnamt"
        Me.btnamt.Size = New System.Drawing.Size(149, 32)
        Me.btnamt.TabIndex = 8
        Me.btnamt.Text = "Amount"
        Me.btnamt.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbFormat)
        Me.Panel1.Controls.Add(Me.btnbrowse)
        Me.Panel1.Controls.Add(Me.txtFilename)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbbank)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtheight)
        Me.Panel1.Controls.Add(Me.txtlength)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbbankcode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 103)
        Me.Panel1.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(525, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Layout Name:"
        '
        'cmbFormat
        '
        Me.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Items.AddRange(New Object() {"MULTI CITY", "LOCAL"})
        Me.cmbFormat.Location = New System.Drawing.Point(625, 7)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormat.TabIndex = 21
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(528, 30)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnbrowse.TabIndex = 20
        Me.btnbrowse.Text = "B&rowse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(86, 33)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(436, 20)
        Me.txtFilename.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "File Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(238, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Width"
        '
        'cmbbank
        '
        Me.cmbbank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbbank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbank.FormattingEnabled = True
        Me.cmbbank.Location = New System.Drawing.Point(86, 7)
        Me.cmbbank.Name = "cmbbank"
        Me.cmbbank.Size = New System.Drawing.Size(336, 24)
        Me.cmbbank.TabIndex = 12
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(591, 59)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(57, 31)
        Me.btnclose.TabIndex = 14
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(528, 59)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(57, 31)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bank :"
        '
        'cmbbankcode
        '
        Me.cmbbankcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbankcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankcode.FormattingEnabled = True
        Me.cmbbankcode.Location = New System.Drawing.Point(421, 7)
        Me.cmbbankcode.Name = "cmbbankcode"
        Me.cmbbankcode.Size = New System.Drawing.Size(101, 24)
        Me.cmbbankcode.TabIndex = 17
        '
        'btnAmtInWrd
        '
        Me.btnAmtInWrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmtInWrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmtInWrd.Location = New System.Drawing.Point(86, 74)
        Me.btnAmtInWrd.Name = "btnAmtInWrd"
        Me.btnAmtInWrd.Size = New System.Drawing.Size(157, 24)
        Me.btnAmtInWrd.TabIndex = 10
        Me.btnAmtInWrd.Text = "Amt In words"
        Me.btnAmtInWrd.UseVisualStyleBackColor = True
        '
        'btnConfirmAcc
        '
        Me.btnConfirmAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmAcc.Location = New System.Drawing.Point(87, 158)
        Me.btnConfirmAcc.Name = "btnConfirmAcc"
        Me.btnConfirmAcc.Size = New System.Drawing.Size(156, 22)
        Me.btnConfirmAcc.TabIndex = 11
        Me.btnConfirmAcc.Text = "Confirm Acc No"
        Me.btnConfirmAcc.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnBeneAccNo
        '
        Me.BtnBeneAccNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBeneAccNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBeneAccNo.Location = New System.Drawing.Point(86, 104)
        Me.BtnBeneAccNo.Name = "BtnBeneAccNo"
        Me.BtnBeneAccNo.Size = New System.Drawing.Size(157, 24)
        Me.BtnBeneAccNo.TabIndex = 12
        Me.BtnBeneAccNo.Text = "Beneficiary Acc No"
        Me.BtnBeneAccNo.UseVisualStyleBackColor = True
        '
        'BtnBank
        '
        Me.BtnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBank.Location = New System.Drawing.Point(86, 131)
        Me.BtnBank.Name = "BtnBank"
        Me.BtnBank.Size = New System.Drawing.Size(157, 24)
        Me.BtnBank.TabIndex = 13
        Me.BtnBank.Text = "Beneficiary Bank"
        Me.BtnBank.UseVisualStyleBackColor = True
        '
        'BtnBeneAdd
        '
        Me.BtnBeneAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBeneAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBeneAdd.Location = New System.Drawing.Point(87, 186)
        Me.BtnBeneAdd.Name = "BtnBeneAdd"
        Me.BtnBeneAdd.Size = New System.Drawing.Size(156, 22)
        Me.BtnBeneAdd.TabIndex = 14
        Me.BtnBeneAdd.Text = "Beneficiary address"
        Me.BtnBeneAdd.UseVisualStyleBackColor = True
        '
        'btncity
        '
        Me.btncity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncity.Location = New System.Drawing.Point(481, 130)
        Me.btncity.Name = "btncity"
        Me.btncity.Size = New System.Drawing.Size(156, 22)
        Me.btncity.TabIndex = 15
        Me.btncity.Text = "city"
        Me.btncity.UseVisualStyleBackColor = True
        '
        'Btncheqe
        '
        Me.Btncheqe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncheqe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncheqe.Location = New System.Drawing.Point(87, 214)
        Me.Btncheqe.Name = "Btncheqe"
        Me.Btncheqe.Size = New System.Drawing.Size(156, 22)
        Me.Btncheqe.TabIndex = 16
        Me.Btncheqe.Text = "cheque No"
        Me.Btncheqe.UseVisualStyleBackColor = True
        '
        'frmRtgsLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(947, 414)
        Me.Controls.Add(Me.Btncheqe)
        Me.Controls.Add(Me.btncity)
        Me.Controls.Add(Me.BtnBeneAdd)
        Me.Controls.Add(Me.BtnBank)
        Me.Controls.Add(Me.BtnBeneAccNo)
        Me.Controls.Add(Me.btnConfirmAcc)
        Me.Controls.Add(Me.btnAmtInWrd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnamt)
        Me.Controls.Add(Me.btnbranch)
        Me.Controls.Add(Me.btndate)
        Me.Controls.Add(Me.btninfav1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRtgsLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cgeque Layout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtlength As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtheight As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btninfav1 As System.Windows.Forms.Button
    Friend WithEvents btndate As System.Windows.Forms.Button
    Friend WithEvents btnbranch As System.Windows.Forms.Button
    Friend WithEvents btnamt As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbbank As System.Windows.Forms.ComboBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbbankcode As System.Windows.Forms.ComboBox
    Friend WithEvents btnAmtInWrd As System.Windows.Forms.Button
    Friend WithEvents btnConfirmAcc As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnBeneAccNo As System.Windows.Forms.Button
    Friend WithEvents BtnBank As System.Windows.Forms.Button
    Friend WithEvents BtnBeneAdd As System.Windows.Forms.Button
    Friend WithEvents btncity As System.Windows.Forms.Button
    Friend WithEvents Btncheqe As System.Windows.Forms.Button

End Class
