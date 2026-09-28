<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeedTransfer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbVoucherType = New System.Windows.Forms.ComboBox()
        Me.dtpPostingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbIuList = New System.Windows.Forms.ComboBox()
        Me.dgIUTRFList = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgIUTRFList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(870, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Feed Transfer Post To Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbVoucherType
        '
        Me.cmbVoucherType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbVoucherType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVoucherType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVoucherType.FormattingEnabled = True
        Me.cmbVoucherType.Location = New System.Drawing.Point(269, 69)
        Me.cmbVoucherType.Name = "cmbVoucherType"
        Me.cmbVoucherType.Size = New System.Drawing.Size(236, 24)
        Me.cmbVoucherType.TabIndex = 41
        '
        'dtpPostingDate
        '
        Me.dtpPostingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPostingDate.Location = New System.Drawing.Point(143, 67)
        Me.dtpPostingDate.Name = "dtpPostingDate"
        Me.dtpPostingDate.Size = New System.Drawing.Size(120, 26)
        Me.dtpPostingDate.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Posting Date :"
        '
        'cmbIuList
        '
        Me.cmbIuList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbIuList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIuList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIuList.FormattingEnabled = True
        Me.cmbIuList.Location = New System.Drawing.Point(132, 37)
        Me.cmbIuList.Name = "cmbIuList"
        Me.cmbIuList.Size = New System.Drawing.Size(236, 24)
        Me.cmbIuList.TabIndex = 42
        '
        'dgIUTRFList
        '
        Me.dgIUTRFList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIUTRFList.Location = New System.Drawing.Point(5, 103)
        Me.dgIUTRFList.Name = "dgIUTRFList"
        Me.dgIUTRFList.Size = New System.Drawing.Size(852, 150)
        Me.dgIUTRFList.TabIndex = 43
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(374, 37)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 26)
        Me.btnShow.TabIndex = 44
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.Location = New System.Drawing.Point(592, 69)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(75, 26)
        Me.btnPost.TabIndex = 45
        Me.btnPost.Text = "POST"
        Me.btnPost.UseVisualStyleBackColor = True
        Me.btnPost.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(511, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "POST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Bill Number:"
        '
        'frmFeedTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dgIUTRFList)
        Me.Controls.Add(Me.cmbIuList)
        Me.Controls.Add(Me.cmbVoucherType)
        Me.Controls.Add(Me.dtpPostingDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmFeedTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmFeedTransfer"
        CType(Me.dgIUTRFList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbVoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpPostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbIuList As System.Windows.Forms.ComboBox
    Friend WithEvents dgIUTRFList As System.Windows.Forms.DataGridView
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
