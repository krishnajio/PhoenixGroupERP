<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDailyBalance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCompanyCode = New System.Windows.Forms.Label()
        Me.txtCompanyCode = New System.Windows.Forms.TextBox()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.txtSession = New System.Windows.Forms.TextBox()
        Me.lblCmpId = New System.Windows.Forms.Label()
        Me.txtCmpId = New System.Windows.Forms.TextBox()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.btnLoadAccounts = New System.Windows.Forms.Button()
        Me.lblAccounts = New System.Windows.Forms.Label()
        Me.clbAccountHeads = New System.Windows.Forms.CheckedListBox()
        Me.btnGetReport = New System.Windows.Forms.Button()
        Me.btnExportCsv = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCompanyCode
        '
        Me.lblCompanyCode.AutoSize = True
        Me.lblCompanyCode.Location = New System.Drawing.Point(15, 15)
        Me.lblCompanyCode.Name = "lblCompanyCode"
        Me.lblCompanyCode.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyCode.TabIndex = 0
        Me.lblCompanyCode.Text = "Company Code:"
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.Location = New System.Drawing.Point(110, 12)
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.Size = New System.Drawing.Size(80, 20)
        Me.txtCompanyCode.TabIndex = 1
        Me.txtCompanyCode.Text = "PHOE"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Location = New System.Drawing.Point(210, 15)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(47, 13)
        Me.lblSession.TabIndex = 2
        Me.lblSession.Text = "Session:"
        '
        'txtSession
        '
        Me.txtSession.Location = New System.Drawing.Point(275, 12)
        Me.txtSession.Name = "txtSession"
        Me.txtSession.Size = New System.Drawing.Size(80, 20)
        Me.txtSession.TabIndex = 3
        Me.txtSession.Text = "2627"
        '
        'lblCmpId
        '
        Me.lblCmpId.AutoSize = True
        Me.lblCmpId.Location = New System.Drawing.Point(375, 15)
        Me.lblCmpId.Name = "lblCmpId"
        Me.lblCmpId.Size = New System.Drawing.Size(43, 13)
        Me.lblCmpId.TabIndex = 4
        Me.lblCmpId.Text = "Cmp Id:"
        '
        'txtCmpId
        '
        Me.txtCmpId.Location = New System.Drawing.Point(435, 12)
        Me.txtCmpId.Name = "txtCmpId"
        Me.txtCmpId.Size = New System.Drawing.Size(80, 20)
        Me.txtCmpId.TabIndex = 5
        Me.txtCmpId.Text = "PHOE"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(15, 50)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(59, 13)
        Me.lblFromDate.TabIndex = 6
        Me.lblFromDate.Text = "From Date:"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(110, 46)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(130, 20)
        Me.dtpFromDate.TabIndex = 7
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(260, 50)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(49, 13)
        Me.lblToDate.TabIndex = 8
        Me.lblToDate.Text = "To Date:"
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(325, 46)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(130, 20)
        Me.dtpToDate.TabIndex = 9
        '
        'btnLoadAccounts
        '
        Me.btnLoadAccounts.Location = New System.Drawing.Point(475, 45)
        Me.btnLoadAccounts.Name = "btnLoadAccounts"
        Me.btnLoadAccounts.Size = New System.Drawing.Size(160, 23)
        Me.btnLoadAccounts.TabIndex = 10
        Me.btnLoadAccounts.Text = "Load Account Heads"
        Me.btnLoadAccounts.UseVisualStyleBackColor = True
        '
        'lblAccounts
        '
        Me.lblAccounts.AutoSize = True
        Me.lblAccounts.Location = New System.Drawing.Point(15, 85)
        Me.lblAccounts.Name = "lblAccounts"
        Me.lblAccounts.Size = New System.Drawing.Size(384, 13)
        Me.lblAccounts.TabIndex = 11
        Me.lblAccounts.Text = "Account Heads (check the ones you want; leave all unchecked = all accounts):"
        '
        'clbAccountHeads
        '
        Me.clbAccountHeads.CheckOnClick = True
        Me.clbAccountHeads.FormattingEnabled = True
        Me.clbAccountHeads.Location = New System.Drawing.Point(15, 105)
        Me.clbAccountHeads.Name = "clbAccountHeads"
        Me.clbAccountHeads.Size = New System.Drawing.Size(620, 139)
        Me.clbAccountHeads.TabIndex = 12
        '
        'btnGetReport
        '
        Me.btnGetReport.Location = New System.Drawing.Point(655, 105)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(150, 35)
        Me.btnGetReport.TabIndex = 13
        Me.btnGetReport.Text = "Get Daily Balance"
        Me.btnGetReport.UseVisualStyleBackColor = True
        '
        'btnExportCsv
        '
        Me.btnExportCsv.Location = New System.Drawing.Point(655, 150)
        Me.btnExportCsv.Name = "btnExportCsv"
        Me.btnExportCsv.Size = New System.Drawing.Size(150, 35)
        Me.btnExportCsv.TabIndex = 14
        Me.btnExportCsv.Text = "Export CSV"
        Me.btnExportCsv.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Location = New System.Drawing.Point(15, 255)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(900, 20)
        Me.lblStatus.TabIndex = 15
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResult.Location = New System.Drawing.Point(15, 280)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.Size = New System.Drawing.Size(905, 320)
        Me.dgvResult.TabIndex = 16
        '
        'frmDailyBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 613)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExportCsv)
        Me.Controls.Add(Me.btnGetReport)
        Me.Controls.Add(Me.clbAccountHeads)
        Me.Controls.Add(Me.lblAccounts)
        Me.Controls.Add(Me.btnLoadAccounts)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.txtCmpId)
        Me.Controls.Add(Me.lblCmpId)
        Me.Controls.Add(Me.txtSession)
        Me.Controls.Add(Me.lblSession)
        Me.Controls.Add(Me.txtCompanyCode)
        Me.Controls.Add(Me.lblCompanyCode)
        Me.Name = "frmDailyBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Balance Report"
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCompanyCode As System.Windows.Forms.Label
    Friend WithEvents txtCompanyCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents txtSession As System.Windows.Forms.TextBox
    Friend WithEvents lblCmpId As System.Windows.Forms.Label
    Friend WithEvents txtCmpId As System.Windows.Forms.TextBox
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLoadAccounts As System.Windows.Forms.Button
    Friend WithEvents lblAccounts As System.Windows.Forms.Label
    Friend WithEvents clbAccountHeads As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnGetReport As System.Windows.Forms.Button
    Friend WithEvents btnExportCsv As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView

End Class
