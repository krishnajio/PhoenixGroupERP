<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemManagementRCM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemManagementRCM))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpItemInfo = New System.Windows.Forms.GroupBox()
        Me.txtopeningstock = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmblivetype = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCostName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAcName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCostCode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAcNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSubHeadingNo = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtprdothref = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtprdsuffix = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbprdgrp = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.cmbItemCategory = New System.Windows.Forms.ComboBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtHS = New System.Windows.Forms.TextBox()
        Me.txtBasicExcise = New System.Windows.Forms.TextBox()
        Me.txtExciseNo = New System.Windows.Forms.TextBox()
        Me.txtEDU = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtLedgerNo = New System.Windows.Forms.TextBox()
        Me.txtOther2 = New System.Windows.Forms.TextBox()
        Me.txtentrytax = New System.Windows.Forms.TextBox()
        Me.txtSurcharge = New System.Windows.Forms.TextBox()
        Me.txtCST = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblExciseNo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSurcharge = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLedgerPageNo = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.lblSubHeadingNo = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemType = New System.Windows.Forms.Label()
        Me.lblItemCategory = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.grpItemInfo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeading.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(704, 38)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Product Creaation"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.Controls.Add(Me.grpItemInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 332)
        Me.Panel1.TabIndex = 1
        '
        'grpItemInfo
        '
        Me.grpItemInfo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpItemInfo.Controls.Add(Me.txtopeningstock)
        Me.grpItemInfo.Controls.Add(Me.Label18)
        Me.grpItemInfo.Controls.Add(Me.cmblivetype)
        Me.grpItemInfo.Controls.Add(Me.Label17)
        Me.grpItemInfo.Controls.Add(Me.txtCostName)
        Me.grpItemInfo.Controls.Add(Me.Label16)
        Me.grpItemInfo.Controls.Add(Me.txtAcName)
        Me.grpItemInfo.Controls.Add(Me.Label15)
        Me.grpItemInfo.Controls.Add(Me.txtCostCode)
        Me.grpItemInfo.Controls.Add(Me.Label14)
        Me.grpItemInfo.Controls.Add(Me.txtAcNo)
        Me.grpItemInfo.Controls.Add(Me.Label13)
        Me.grpItemInfo.Controls.Add(Me.txtSubHeadingNo)
        Me.grpItemInfo.Controls.Add(Me.Label35)
        Me.grpItemInfo.Controls.Add(Me.txtprdothref)
        Me.grpItemInfo.Controls.Add(Me.Label12)
        Me.grpItemInfo.Controls.Add(Me.txtprdsuffix)
        Me.grpItemInfo.Controls.Add(Me.Label11)
        Me.grpItemInfo.Controls.Add(Me.cmbprdgrp)
        Me.grpItemInfo.Controls.Add(Me.Label10)
        Me.grpItemInfo.Controls.Add(Me.cmbUnit)
        Me.grpItemInfo.Controls.Add(Me.cmbItemType)
        Me.grpItemInfo.Controls.Add(Me.cmbItemCategory)
        Me.grpItemInfo.Controls.Add(Me.lblUnit)
        Me.grpItemInfo.Controls.Add(Me.txtVAT)
        Me.grpItemInfo.Controls.Add(Me.txtHS)
        Me.grpItemInfo.Controls.Add(Me.txtBasicExcise)
        Me.grpItemInfo.Controls.Add(Me.txtExciseNo)
        Me.grpItemInfo.Controls.Add(Me.txtEDU)
        Me.grpItemInfo.Controls.Add(Me.txtRate)
        Me.grpItemInfo.Controls.Add(Me.txtLedgerNo)
        Me.grpItemInfo.Controls.Add(Me.txtOther2)
        Me.grpItemInfo.Controls.Add(Me.txtentrytax)
        Me.grpItemInfo.Controls.Add(Me.txtSurcharge)
        Me.grpItemInfo.Controls.Add(Me.txtCST)
        Me.grpItemInfo.Controls.Add(Me.Label6)
        Me.grpItemInfo.Controls.Add(Me.Label4)
        Me.grpItemInfo.Controls.Add(Me.lblExciseNo)
        Me.grpItemInfo.Controls.Add(Me.Label9)
        Me.grpItemInfo.Controls.Add(Me.Label5)
        Me.grpItemInfo.Controls.Add(Me.Label3)
        Me.grpItemInfo.Controls.Add(Me.Label8)
        Me.grpItemInfo.Controls.Add(Me.Label7)
        Me.grpItemInfo.Controls.Add(Me.lblSurcharge)
        Me.grpItemInfo.Controls.Add(Me.Label2)
        Me.grpItemInfo.Controls.Add(Me.lblLedgerPageNo)
        Me.grpItemInfo.Controls.Add(Me.txtItemName)
        Me.grpItemInfo.Controls.Add(Me.lblSubHeadingNo)
        Me.grpItemInfo.Controls.Add(Me.lblItemName)
        Me.grpItemInfo.Controls.Add(Me.lblItemType)
        Me.grpItemInfo.Controls.Add(Me.lblItemCategory)
        Me.grpItemInfo.Controls.Add(Me.Label1)
        Me.grpItemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpItemInfo.Location = New System.Drawing.Point(3, 3)
        Me.grpItemInfo.Name = "grpItemInfo"
        Me.grpItemInfo.Size = New System.Drawing.Size(698, 326)
        Me.grpItemInfo.TabIndex = 0
        Me.grpItemInfo.TabStop = False
        '
        'txtopeningstock
        '
        Me.txtopeningstock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtopeningstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtopeningstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtopeningstock.Location = New System.Drawing.Point(155, 279)
        Me.txtopeningstock.Name = "txtopeningstock"
        Me.txtopeningstock.Size = New System.Drawing.Size(132, 22)
        Me.txtopeningstock.TabIndex = 51
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 281)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 16)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Opening Stock :"
        '
        'cmblivetype
        '
        Me.cmblivetype.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmblivetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblivetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblivetype.FormattingEnabled = True
        Me.cmblivetype.Items.AddRange(New Object() {"Lab Testing", "Direct"})
        Me.cmblivetype.Location = New System.Drawing.Point(154, 253)
        Me.cmblivetype.MaxLength = 50
        Me.cmblivetype.Name = "cmblivetype"
        Me.cmblivetype.Size = New System.Drawing.Size(131, 24)
        Me.cmblivetype.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(49, 255)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 16)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "In Through :"
        '
        'txtCostName
        '
        Me.txtCostName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtCostName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostName.Location = New System.Drawing.Point(555, 293)
        Me.txtCostName.MaxLength = 5
        Me.txtCostName.Name = "txtCostName"
        Me.txtCostName.Size = New System.Drawing.Size(134, 22)
        Me.txtCostName.TabIndex = 47
        Me.txtCostName.Text = "-"
        Me.txtCostName.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(400, 303)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 16)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Job No/ Cost Name :"
        Me.Label16.Visible = False
        '
        'txtAcName
        '
        Me.txtAcName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtAcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcName.Location = New System.Drawing.Point(555, 247)
        Me.txtAcName.MaxLength = 5
        Me.txtAcName.Name = "txtAcName"
        Me.txtAcName.Size = New System.Drawing.Size(134, 22)
        Me.txtAcName.TabIndex = 43
        Me.txtAcName.Text = "-"
        Me.txtAcName.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(471, 254)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Ac/Name :"
        Me.Label15.Visible = False
        '
        'txtCostCode
        '
        Me.txtCostCode.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtCostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostCode.Location = New System.Drawing.Point(555, 270)
        Me.txtCostCode.MaxLength = 5
        Me.txtCostCode.Name = "txtCostCode"
        Me.txtCostCode.Size = New System.Drawing.Size(134, 22)
        Me.txtCostCode.TabIndex = 45
        Me.txtCostCode.Text = "-"
        Me.txtCostCode.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(404, 279)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 16)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Job No/ Cost Code :"
        Me.Label14.Visible = False
        '
        'txtAcNo
        '
        Me.txtAcNo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtAcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcNo.Location = New System.Drawing.Point(555, 224)
        Me.txtAcNo.MaxLength = 5
        Me.txtAcNo.Name = "txtAcNo"
        Me.txtAcNo.Size = New System.Drawing.Size(134, 22)
        Me.txtAcNo.TabIndex = 41
        Me.txtAcNo.Text = "-"
        Me.txtAcNo.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(488, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 16)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Ac/No. :"
        Me.Label13.Visible = False
        '
        'txtSubHeadingNo
        '
        Me.txtSubHeadingNo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSubHeadingNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubHeadingNo.FormattingEnabled = True
        Me.txtSubHeadingNo.Items.AddRange(New Object() {"", "BATCH", "MONO"})
        Me.txtSubHeadingNo.Location = New System.Drawing.Point(154, 106)
        Me.txtSubHeadingNo.MaxLength = 20
        Me.txtSubHeadingNo.Name = "txtSubHeadingNo"
        Me.txtSubHeadingNo.Size = New System.Drawing.Size(174, 24)
        Me.txtSubHeadingNo.TabIndex = 10
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label35.Location = New System.Drawing.Point(138, 68)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(14, 10)
        Me.Label35.TabIndex = 6
        Me.Label35.Text = "*"
        '
        'txtprdothref
        '
        Me.txtprdothref.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtprdothref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprdothref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprdothref.Location = New System.Drawing.Point(154, 60)
        Me.txtprdothref.MaxLength = 30
        Me.txtprdothref.Name = "txtprdothref"
        Me.txtprdothref.Size = New System.Drawing.Size(174, 22)
        Me.txtprdothref.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Product Other ref: :"
        '
        'txtprdsuffix
        '
        Me.txtprdsuffix.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtprdsuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprdsuffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprdsuffix.Location = New System.Drawing.Point(154, 37)
        Me.txtprdsuffix.MaxLength = 2
        Me.txtprdsuffix.Name = "txtprdsuffix"
        Me.txtprdsuffix.Size = New System.Drawing.Size(174, 22)
        Me.txtprdsuffix.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Product Suffix :"
        '
        'cmbprdgrp
        '
        Me.cmbprdgrp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmbprdgrp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbprdgrp.FormattingEnabled = True
        Me.cmbprdgrp.Location = New System.Drawing.Point(154, 12)
        Me.cmbprdgrp.MaxLength = 20
        Me.cmbprdgrp.Name = "cmbprdgrp"
        Me.cmbprdgrp.Size = New System.Drawing.Size(174, 24)
        Me.cmbprdgrp.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Product Group :"
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(154, 205)
        Me.cmbUnit.MaxLength = 50
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(131, 24)
        Me.cmbUnit.TabIndex = 18
        '
        'cmbItemType
        '
        Me.cmbItemType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Items.AddRange(New Object() {"Sale", "Purchase"})
        Me.cmbItemType.Location = New System.Drawing.Point(154, 157)
        Me.cmbItemType.MaxLength = 50
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(174, 24)
        Me.cmbItemType.TabIndex = 14
        '
        'cmbItemCategory
        '
        Me.cmbItemCategory.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cmbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemCategory.FormattingEnabled = True
        Me.cmbItemCategory.Location = New System.Drawing.Point(154, 132)
        Me.cmbItemCategory.MaxLength = 20
        Me.cmbItemCategory.Name = "cmbItemCategory"
        Me.cmbItemCategory.Size = New System.Drawing.Size(174, 24)
        Me.cmbItemCategory.TabIndex = 12
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(97, 208)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(43, 16)
        Me.lblUnit.TabIndex = 17
        Me.lblUnit.Text = "Unit :"
        '
        'txtVAT
        '
        Me.txtVAT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.Location = New System.Drawing.Point(555, 109)
        Me.txtVAT.MaxLength = 5
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(134, 22)
        Me.txtVAT.TabIndex = 31
        Me.txtVAT.Text = "0.00"
        '
        'txtHS
        '
        Me.txtHS.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHS.Location = New System.Drawing.Point(555, 86)
        Me.txtHS.MaxLength = 5
        Me.txtHS.Name = "txtHS"
        Me.txtHS.Size = New System.Drawing.Size(134, 22)
        Me.txtHS.TabIndex = 29
        Me.txtHS.Text = "0.00"
        Me.txtHS.Visible = False
        '
        'txtBasicExcise
        '
        Me.txtBasicExcise.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtBasicExcise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBasicExcise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBasicExcise.Location = New System.Drawing.Point(555, 40)
        Me.txtBasicExcise.MaxLength = 5
        Me.txtBasicExcise.Name = "txtBasicExcise"
        Me.txtBasicExcise.Size = New System.Drawing.Size(134, 22)
        Me.txtBasicExcise.TabIndex = 25
        Me.txtBasicExcise.Text = "0.00"
        '
        'txtExciseNo
        '
        Me.txtExciseNo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtExciseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExciseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExciseNo.Location = New System.Drawing.Point(555, 17)
        Me.txtExciseNo.MaxLength = 30
        Me.txtExciseNo.Name = "txtExciseNo"
        Me.txtExciseNo.Size = New System.Drawing.Size(134, 22)
        Me.txtExciseNo.TabIndex = 23
        '
        'txtEDU
        '
        Me.txtEDU.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtEDU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEDU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEDU.Location = New System.Drawing.Point(555, 63)
        Me.txtEDU.MaxLength = 5
        Me.txtEDU.Name = "txtEDU"
        Me.txtEDU.Size = New System.Drawing.Size(134, 22)
        Me.txtEDU.TabIndex = 27
        Me.txtEDU.Text = "0.00"
        Me.txtEDU.Visible = False
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(154, 230)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(132, 22)
        Me.txtRate.TabIndex = 20
        '
        'txtLedgerNo
        '
        Me.txtLedgerNo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtLedgerNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLedgerNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLedgerNo.Location = New System.Drawing.Point(154, 182)
        Me.txtLedgerNo.Name = "txtLedgerNo"
        Me.txtLedgerNo.Size = New System.Drawing.Size(174, 22)
        Me.txtLedgerNo.TabIndex = 16
        '
        'txtOther2
        '
        Me.txtOther2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtOther2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOther2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOther2.Location = New System.Drawing.Point(555, 201)
        Me.txtOther2.MaxLength = 5
        Me.txtOther2.Name = "txtOther2"
        Me.txtOther2.Size = New System.Drawing.Size(134, 22)
        Me.txtOther2.TabIndex = 39
        Me.txtOther2.Text = "0.00"
        '
        'txtentrytax
        '
        Me.txtentrytax.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtentrytax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtentrytax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtentrytax.Location = New System.Drawing.Point(555, 178)
        Me.txtentrytax.MaxLength = 5
        Me.txtentrytax.Name = "txtentrytax"
        Me.txtentrytax.Size = New System.Drawing.Size(134, 22)
        Me.txtentrytax.TabIndex = 37
        Me.txtentrytax.Text = "0.00"
        '
        'txtSurcharge
        '
        Me.txtSurcharge.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSurcharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSurcharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurcharge.Location = New System.Drawing.Point(555, 155)
        Me.txtSurcharge.MaxLength = 5
        Me.txtSurcharge.Name = "txtSurcharge"
        Me.txtSurcharge.Size = New System.Drawing.Size(134, 22)
        Me.txtSurcharge.TabIndex = 35
        Me.txtSurcharge.Text = "0.00"
        '
        'txtCST
        '
        Me.txtCST.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtCST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCST.Location = New System.Drawing.Point(555, 132)
        Me.txtCST.MaxLength = 5
        Me.txtCST.Name = "txtCST"
        Me.txtCST.Size = New System.Drawing.Size(134, 22)
        Me.txtCST.TabIndex = 33
        Me.txtCST.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(471, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "SGST(%) :"
        Me.Label6.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(481, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "GST(%) :"
        '
        'lblExciseNo
        '
        Me.lblExciseNo.AutoSize = True
        Me.lblExciseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExciseNo.Location = New System.Drawing.Point(475, 22)
        Me.lblExciseNo.Name = "lblExciseNo"
        Me.lblExciseNo.Size = New System.Drawing.Size(76, 16)
        Me.lblExciseNo.TabIndex = 21
        Me.lblExciseNo.Text = "HSN No. :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(95, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(477, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "IGST(%) :"
        Me.Label5.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Ledger Page No. :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(463, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Other 1(%) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(470, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Entry Tax :"
        '
        'lblSurcharge
        '
        Me.lblSurcharge.AutoSize = True
        Me.lblSurcharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurcharge.Location = New System.Drawing.Point(441, 159)
        Me.lblSurcharge.Name = "lblSurcharge"
        Me.lblSurcharge.Size = New System.Drawing.Size(110, 16)
        Me.lblSurcharge.TabIndex = 34
        Me.lblSurcharge.Text = "Surcharge(%) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "IGST(%) :"
        '
        'lblLedgerPageNo
        '
        Me.lblLedgerPageNo.AutoSize = True
        Me.lblLedgerPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLedgerPageNo.Location = New System.Drawing.Point(482, 113)
        Me.lblLedgerPageNo.Name = "lblLedgerPageNo"
        Me.lblLedgerPageNo.Size = New System.Drawing.Size(70, 16)
        Me.lblLedgerPageNo.TabIndex = 30
        Me.lblLedgerPageNo.Text = "GST(%) :"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(154, 83)
        Me.txtItemName.MaxLength = 100
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(314, 22)
        Me.txtItemName.TabIndex = 8
        '
        'lblSubHeadingNo
        '
        Me.lblSubHeadingNo.AutoSize = True
        Me.lblSubHeadingNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeadingNo.Location = New System.Drawing.Point(22, 111)
        Me.lblSubHeadingNo.Name = "lblSubHeadingNo"
        Me.lblSubHeadingNo.Size = New System.Drawing.Size(118, 16)
        Me.lblSubHeadingNo.TabIndex = 9
        Me.lblSubHeadingNo.Text = "Item No. Name :"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(26, 84)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(114, 16)
        Me.lblItemName.TabIndex = 7
        Me.lblItemName.Text = "Product Name :"
        '
        'lblItemType
        '
        Me.lblItemType.AutoSize = True
        Me.lblItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemType.Location = New System.Drawing.Point(55, 162)
        Me.lblItemType.Name = "lblItemType"
        Me.lblItemType.Size = New System.Drawing.Size(85, 16)
        Me.lblItemType.TabIndex = 13
        Me.lblItemType.Text = "Item Type :"
        '
        'lblItemCategory
        '
        Me.lblItemCategory.AutoSize = True
        Me.lblItemCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCategory.Location = New System.Drawing.Point(28, 134)
        Me.lblItemCategory.Name = "lblItemCategory"
        Me.lblItemCategory.Size = New System.Drawing.Size(112, 16)
        Me.lblItemCategory.TabIndex = 11
        Me.lblItemCategory.Text = "Item Category :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "-"
        Me.Label1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnModify)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Location = New System.Drawing.Point(0, 376)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 50)
        Me.Panel2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(456, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 42)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(365, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 42)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(276, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 42)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(185, 5)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(89, 42)
        Me.btnModify.TabIndex = 2
        Me.btnModify.Text = "&Modify"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(94, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 42)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Location = New System.Drawing.Point(0, 432)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.ReadOnly = True
        Me.dgvItem.Size = New System.Drawing.Size(736, 193)
        Me.dgvItem.TabIndex = 3
        '
        'frmItemManagementRCM
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(704, 637)
        Me.Controls.Add(Me.dgvItem)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmItemManagementRCM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Management"
        Me.Panel1.ResumeLayout(False)
        Me.grpItemInfo.ResumeLayout(False)
        Me.grpItemInfo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblLedgerPageNo As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblItemCategory As System.Windows.Forms.Label
    Friend WithEvents cmbItemCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubHeadingNo As System.Windows.Forms.Label
    Friend WithEvents cmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents txtHS As System.Windows.Forms.TextBox
    Friend WithEvents txtBasicExcise As System.Windows.Forms.TextBox
    Friend WithEvents txtExciseNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEDU As System.Windows.Forms.TextBox
    Friend WithEvents txtLedgerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblExciseNo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblItemType As System.Windows.Forms.Label
    Friend WithEvents txtOther2 As System.Windows.Forms.TextBox
    Friend WithEvents txtentrytax As System.Windows.Forms.TextBox
    Friend WithEvents txtCST As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtSurcharge As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSurcharge As System.Windows.Forms.Label
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents txtprdsuffix As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbprdgrp As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtSubHeadingNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtprdothref As System.Windows.Forms.TextBox
    Friend WithEvents txtCostName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAcName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCostCode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAcNo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmblivetype As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtopeningstock As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
