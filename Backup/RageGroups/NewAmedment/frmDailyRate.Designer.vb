<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyRate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyRate))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbItemName = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtraye = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.dgdaily = New System.Windows.Forms.DataGridView
        Me.btnModify = New System.Windows.Forms.Button
        CType(Me.dgdaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Daily Rate"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MM/yyyy"
        Me.dtpdate.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(81, 75)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(98, 24)
        Me.dtpdate.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Date:"
        '
        'cmbItemName
        '
        Me.cmbItemName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbItemName.DropDownWidth = 580
        Me.cmbItemName.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.IntegralHeight = False
        Me.cmbItemName.Location = New System.Drawing.Point(81, 44)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(235, 25)
        Me.cmbItemName.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(2, 48)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 18)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Rate:"
        '
        'txtraye
        '
        Me.txtraye.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtraye.Location = New System.Drawing.Point(81, 102)
        Me.txtraye.Name = "txtraye"
        Me.txtraye.Size = New System.Drawing.Size(98, 24)
        Me.txtraye.TabIndex = 20
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(81, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 36)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgdaily
        '
        Me.dgdaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdaily.Location = New System.Drawing.Point(7, 186)
        Me.dgdaily.Name = "dgdaily"
        Me.dgdaily.Size = New System.Drawing.Size(309, 171)
        Me.dgdaily.TabIndex = 24
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(161, 132)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(90, 36)
        Me.btnModify.TabIndex = 27
        Me.btnModify.Text = "&Modify"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'frmDailyRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(321, 377)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.dgdaily)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtraye)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbItemName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmDailyRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDailyRate"
        CType(Me.dgdaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbItemName As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtraye As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgdaily As System.Windows.Forms.DataGridView
    Friend WithEvents btnModify As System.Windows.Forms.Button
End Class
