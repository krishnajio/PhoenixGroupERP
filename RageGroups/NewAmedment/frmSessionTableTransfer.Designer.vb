<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSessionTableTransfer
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
        Me.cmbCompanyName = New System.Windows.Forms.ComboBox()
        Me.cmdCompanyCode = New System.Windows.Forms.ComboBox()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.cmbSeesionNew = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SlateBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1281, 36)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "Session Table Transfer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCompanyName.FormattingEnabled = True
        Me.cmbCompanyName.Location = New System.Drawing.Point(12, 42)
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Size = New System.Drawing.Size(367, 410)
        Me.cmbCompanyName.TabIndex = 210
        '
        'cmdCompanyCode
        '
        Me.cmdCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmdCompanyCode.FormattingEnabled = True
        Me.cmdCompanyCode.Location = New System.Drawing.Point(385, 42)
        Me.cmdCompanyCode.Name = "cmdCompanyCode"
        Me.cmdCompanyCode.Size = New System.Drawing.Size(121, 410)
        Me.cmdCompanyCode.TabIndex = 211
        '
        'cmbSession
        '
        Me.cmbSession.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSession.ForeColor = System.Drawing.Color.Black
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Location = New System.Drawing.Point(510, 65)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(154, 24)
        Me.cmbSession.TabIndex = 212
        '
        'cmbSeesionNew
        '
        Me.cmbSeesionNew.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmbSeesionNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeesionNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeesionNew.ForeColor = System.Drawing.Color.Black
        Me.cmbSeesionNew.FormattingEnabled = True
        Me.cmbSeesionNew.Location = New System.Drawing.Point(510, 122)
        Me.cmbSeesionNew.Name = "cmbSeesionNew"
        Me.cmbSeesionNew.Size = New System.Drawing.Size(154, 24)
        Me.cmbSeesionNew.TabIndex = 213
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(510, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "Old Session"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(510, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "New Session"
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(510, 175)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(154, 26)
        Me.btnlogin.TabIndex = 216
        Me.btnlogin.Text = "&Transfer"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(670, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 377)
        Me.DataGridView1.TabIndex = 217
        '
        'frmSessionTableTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1281, 457)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSeesionNew)
        Me.Controls.Add(Me.cmbSession)
        Me.Controls.Add(Me.cmdCompanyCode)
        Me.Controls.Add(Me.cmbCompanyName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSessionTableTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSessionTableTransfer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCompanyCode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSession As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSeesionNew As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
