<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalePurchasedata
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdPoultrySale = New System.Windows.Forms.RadioButton()
        Me.rsOtherSale = New System.Windows.Forms.RadioButton()
        Me.rdPoultryPurchase = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdPoultryPurchase)
        Me.Panel1.Controls.Add(Me.rsOtherSale)
        Me.Panel1.Controls.Add(Me.rdPoultrySale)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 37)
        Me.Panel1.TabIndex = 0
        '
        'rdPoultrySale
        '
        Me.rdPoultrySale.AutoSize = True
        Me.rdPoultrySale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPoultrySale.Location = New System.Drawing.Point(65, 13)
        Me.rdPoultrySale.Name = "rdPoultrySale"
        Me.rdPoultrySale.Size = New System.Drawing.Size(93, 17)
        Me.rdPoultrySale.TabIndex = 0
        Me.rdPoultrySale.TabStop = True
        Me.rdPoultrySale.Text = "Poultry Sale"
        Me.rdPoultrySale.UseVisualStyleBackColor = True
        '
        'rsOtherSale
        '
        Me.rsOtherSale.AutoSize = True
        Me.rsOtherSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rsOtherSale.Location = New System.Drawing.Point(164, 13)
        Me.rsOtherSale.Name = "rsOtherSale"
        Me.rsOtherSale.Size = New System.Drawing.Size(128, 17)
        Me.rsOtherSale.TabIndex = 1
        Me.rsOtherSale.TabStop = True
        Me.rsOtherSale.Text = "Poultry Other Sale"
        Me.rsOtherSale.UseVisualStyleBackColor = True
        '
        'rdPoultryPurchase
        '
        Me.rdPoultryPurchase.AutoSize = True
        Me.rdPoultryPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPoultryPurchase.Location = New System.Drawing.Point(314, 13)
        Me.rdPoultryPurchase.Name = "rdPoultryPurchase"
        Me.rdPoultryPurchase.Size = New System.Drawing.Size(121, 17)
        Me.rdPoultryPurchase.TabIndex = 2
        Me.rdPoultryPurchase.TabStop = True
        Me.rdPoultryPurchase.Text = "Poultry Purchase"
        Me.rdPoultryPurchase.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1151, 570)
        Me.DataGridView1.TabIndex = 1
        '
        'frmSalePurchasedata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 607)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSalePurchasedata"
        Me.Text = "frmSalePurchasedata"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdPoultryPurchase As System.Windows.Forms.RadioButton
    Friend WithEvents rsOtherSale As System.Windows.Forms.RadioButton
    Friend WithEvents rdPoultrySale As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
