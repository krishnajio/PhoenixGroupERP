<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchqbook
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtentryid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cmbbankcode = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtbookno = New System.Windows.Forms.TextBox
        Me.txtchqnofrom = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtchqnoto = New System.Windows.Forms.TextBox
        Me.dgchequebook = New System.Windows.Forms.DataGridView
        Me.ruleid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbbankname = New System.Windows.Forms.ComboBox
        Me.Dtentry = New System.Windows.Forms.DateTimePicker
        CType(Me.dgchequebook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(601, 34)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Cheque Book Receiving" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtentryid
        '
        Me.txtentryid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtentryid.Location = New System.Drawing.Point(230, 42)
        Me.txtentryid.Name = "txtentryid"
        Me.txtentryid.ReadOnly = True
        Me.txtentryid.Size = New System.Drawing.Size(47, 21)
        Me.txtentryid.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Bank Code/Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Cmbbankcode
        '
        Me.Cmbbankcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbbankcode.FormattingEnabled = True
        Me.Cmbbankcode.Location = New System.Drawing.Point(229, 69)
        Me.Cmbbankcode.Name = "Cmbbankcode"
        Me.Cmbbankcode.Size = New System.Drawing.Size(108, 23)
        Me.Cmbbankcode.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(156, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Book No  :"
        '
        'txtbookno
        '
        Me.txtbookno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookno.Location = New System.Drawing.Point(229, 95)
        Me.txtbookno.Name = "txtbookno"
        Me.txtbookno.Size = New System.Drawing.Size(150, 21)
        Me.txtbookno.TabIndex = 4
        '
        'txtchqnofrom
        '
        Me.txtchqnofrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchqnofrom.Location = New System.Drawing.Point(229, 119)
        Me.txtchqnofrom.Name = "txtchqnofrom"
        Me.txtchqnofrom.Size = New System.Drawing.Size(85, 21)
        Me.txtchqnofrom.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Cheque No From:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "to"
        '
        'txtchqnoto
        '
        Me.txtchqnoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchqnoto.Location = New System.Drawing.Point(347, 119)
        Me.txtchqnoto.Name = "txtchqnoto"
        Me.txtchqnoto.Size = New System.Drawing.Size(93, 21)
        Me.txtchqnoto.TabIndex = 6
        '
        'dgchequebook
        '
        Me.dgchequebook.AllowUserToAddRows = False
        Me.dgchequebook.AllowUserToDeleteRows = False
        Me.dgchequebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgchequebook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ruleid, Me.Descr, Me.Column4, Me.Column1, Me.Rate, Me.Column2, Me.Column3})
        Me.dgchequebook.Location = New System.Drawing.Point(3, 199)
        Me.dgchequebook.Name = "dgchequebook"
        Me.dgchequebook.ReadOnly = True
        Me.dgchequebook.Size = New System.Drawing.Size(589, 264)
        Me.dgchequebook.TabIndex = 49
        '
        'ruleid
        '
        Me.ruleid.HeaderText = " Entry ID"
        Me.ruleid.Name = "ruleid"
        Me.ruleid.ReadOnly = True
        Me.ruleid.Width = 50
        '
        'Descr
        '
        Me.Descr.HeaderText = "Bank Code"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        Me.Descr.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Bank Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column1
        '
        DataGridViewCellStyle2.Format = "dd/MM/yy"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Receiving Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Rate
        '
        Me.Rate.HeaderText = "Book No"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cheque No From"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cheque No To"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnmodify)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(118, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 46)
        Me.Panel1.TabIndex = 50
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(280, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(66, 31)
        Me.btnclose.TabIndex = 11
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(210, 6)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(66, 31)
        Me.btnreset.TabIndex = 10
        Me.btnreset.Text = "&Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(141, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(66, 31)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnmodify
        '
        Me.btnmodify.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(74, 5)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(66, 31)
        Me.btnmodify.TabIndex = 8
        Me.btnmodify.Text = "&Modify"
        Me.btnmodify.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(4, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(66, 31)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Receiving Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbbankname
        '
        Me.cmbbankname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankname.FormattingEnabled = True
        Me.cmbbankname.Location = New System.Drawing.Point(343, 69)
        Me.cmbbankname.Name = "cmbbankname"
        Me.cmbbankname.Size = New System.Drawing.Size(201, 23)
        Me.cmbbankname.TabIndex = 3
        '
        'Dtentry
        '
        Me.Dtentry.CustomFormat = "dd/MM/yy"
        Me.Dtentry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtentry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtentry.Location = New System.Drawing.Point(230, 42)
        Me.Dtentry.Name = "Dtentry"
        Me.Dtentry.Size = New System.Drawing.Size(85, 21)
        Me.Dtentry.TabIndex = 1
        '
        'frmchqbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(601, 467)
        Me.Controls.Add(Me.Dtentry)
        Me.Controls.Add(Me.cmbbankname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgchequebook)
        Me.Controls.Add(Me.txtchqnoto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtchqnofrom)
        Me.Controls.Add(Me.txtbookno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cmbbankcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtentryid)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmchqbook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmchqbook"
        CType(Me.dgchequebook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtentryid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmbbankcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbookno As System.Windows.Forms.TextBox
    Friend WithEvents txtchqnofrom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtchqnoto As System.Windows.Forms.TextBox
    Friend WithEvents dgchequebook As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbbankname As System.Windows.Forms.ComboBox
    Friend WithEvents Dtentry As System.Windows.Forms.DateTimePicker
    Friend WithEvents ruleid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
