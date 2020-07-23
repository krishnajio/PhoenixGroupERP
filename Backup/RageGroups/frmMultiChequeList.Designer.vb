<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiChequeList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgMultiple = New System.Windows.Forms.DataGridView
        Me.chq_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbfavourof = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rtno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chq_Date1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VouNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgMultipleM = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.favourofm = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chq_Date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VouNoM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnok = New System.Windows.Forms.Button
        Me.lblrect_type = New System.Windows.Forms.Label
        CType(Me.dgMultiple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMultipleM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMultiple
        '
        Me.dgMultiple.AllowUserToAddRows = False
        Me.dgMultiple.AllowUserToDeleteRows = False
        Me.dgMultiple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMultiple.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chq_no, Me.cmbfavourof, Me.rtno, Me.Amount, Me.Chq_Date1, Me.VouNo})
        Me.dgMultiple.Location = New System.Drawing.Point(0, 0)
        Me.dgMultiple.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgMultiple.Name = "dgMultiple"
        Me.dgMultiple.Size = New System.Drawing.Size(599, 310)
        Me.dgMultiple.TabIndex = 0
        '
        'chq_no
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.chq_no.DefaultCellStyle = DataGridViewCellStyle1
        Me.chq_no.HeaderText = "Cheque No"
        Me.chq_no.MaxInputLength = 15
        Me.chq_no.Name = "chq_no"
        Me.chq_no.ReadOnly = True
        '
        'cmbfavourof
        '
        Me.cmbfavourof.HeaderText = "Favour of"
        Me.cmbfavourof.MaxInputLength = 100
        Me.cmbfavourof.Name = "cmbfavourof"
        Me.cmbfavourof.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbfavourof.Width = 275
        '
        'rtno
        '
        Me.rtno.HeaderText = "Recpt No"
        Me.rtno.MaxInputLength = 20
        Me.rtno.Name = "rtno"
        Me.rtno.Visible = False
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.MaxInputLength = 18
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 75
        '
        'Chq_Date1
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Format = "dd-MMM-yy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Chq_Date1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Chq_Date1.HeaderText = "Chq Date"
        Me.Chq_Date1.Name = "Chq_Date1"
        '
        'VouNo
        '
        Me.VouNo.HeaderText = "Vou No"
        Me.VouNo.Name = "VouNo"
        Me.VouNo.ReadOnly = True
        Me.VouNo.Visible = False
        Me.VouNo.Width = 150
        '
        'dgMultipleM
        '
        Me.dgMultipleM.AllowUserToAddRows = False
        Me.dgMultipleM.AllowUserToDeleteRows = False
        Me.dgMultipleM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMultipleM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.favourofm, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Chq_Date, Me.VouNoM})
        Me.dgMultipleM.Location = New System.Drawing.Point(0, 58)
        Me.dgMultipleM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgMultipleM.Name = "dgMultipleM"
        Me.dgMultipleM.Size = New System.Drawing.Size(599, 293)
        Me.dgMultipleM.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cheque No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'favourofm
        '
        Me.favourofm.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.favourofm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.favourofm.HeaderText = "Favour of"
        Me.favourofm.Name = "favourofm"
        Me.favourofm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.favourofm.Width = 275
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Recpt No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'Chq_Date
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.Format = "dd-MMM-yyyy"
        Me.Chq_Date.DefaultCellStyle = DataGridViewCellStyle3
        Me.Chq_Date.HeaderText = "Chq Date"
        Me.Chq_Date.Name = "Chq_Date"
        '
        'VouNoM
        '
        Me.VouNoM.HeaderText = "Vou No"
        Me.VouNoM.Name = "VouNoM"
        Me.VouNoM.ReadOnly = True
        Me.VouNoM.Visible = False
        Me.VouNoM.Width = 150
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(524, 357)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 25)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "&Continue"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'lblrect_type
        '
        Me.lblrect_type.AutoSize = True
        Me.lblrect_type.Location = New System.Drawing.Point(548, 147)
        Me.lblrect_type.Name = "lblrect_type"
        Me.lblrect_type.Size = New System.Drawing.Size(51, 15)
        Me.lblrect_type.TabIndex = 3
        Me.lblrect_type.Text = "Label1"
        '
        'frmMultiChequeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(606, 383)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.dgMultipleM)
        Me.Controls.Add(Me.dgMultiple)
        Me.Controls.Add(Me.lblrect_type)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMultiChequeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMultiChequeList"
        CType(Me.dgMultiple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMultipleM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgMultiple As System.Windows.Forms.DataGridView
    Friend WithEvents dgMultipleM As System.Windows.Forms.DataGridView
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents lblrect_type As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents favourofm As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chq_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VouNoM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chq_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbfavourof As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chq_Date1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VouNo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
