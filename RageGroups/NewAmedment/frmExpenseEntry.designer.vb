<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenseEntry
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDBpcl = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDCash = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDMt = New System.Windows.Forms.TextBox()
        Me.txtTotalkm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.detadd = New System.Windows.Forms.Button()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.txtDeisel = New System.Windows.Forms.TextBox()
        Me.txtda = New System.Windows.Forms.TextBox()
        Me.txtDriverName = New System.Windows.Forms.TextBox()
        Me.txtLA = New System.Windows.Forms.TextBox()
        Me.txtToll = New System.Windows.Forms.TextBox()
        Me.txtNoChicks = New System.Windows.Forms.TextBox()
        Me.dtpHatchDt = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dgexpenses = New System.Windows.Forms.DataGridView()
        Me.HatchDAte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofChicks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deisel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TollTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LAUl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalKm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dieselLtrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverNAme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcHead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DieselCash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DieselBPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAcName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvou_type = New System.Windows.Forms.TextBox()
        Me.txtvou_no = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtNarration = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgexpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDBpcl)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDCash)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDMt)
        Me.GroupBox1.Controls.Add(Me.txtTotalkm)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.detadd)
        Me.GroupBox1.Controls.Add(Me.txtarea)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtOther)
        Me.GroupBox1.Controls.Add(Me.txtDeisel)
        Me.GroupBox1.Controls.Add(Me.txtda)
        Me.GroupBox1.Controls.Add(Me.txtDriverName)
        Me.GroupBox1.Controls.Add(Me.txtLA)
        Me.GroupBox1.Controls.Add(Me.txtToll)
        Me.GroupBox1.Controls.Add(Me.txtNoChicks)
        Me.GroupBox1.Controls.Add(Me.dtpHatchDt)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehiicle Detials"
        '
        'txtDBpcl
        '
        Me.txtDBpcl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDBpcl.Location = New System.Drawing.Point(654, 64)
        Me.txtDBpcl.Name = "txtDBpcl"
        Me.txtDBpcl.Size = New System.Drawing.Size(116, 20)
        Me.txtDBpcl.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(571, 65)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 227
        Me.Label7.Text = "Diesel Bpcl:"
        '
        'txtDCash
        '
        Me.txtDCash.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDCash.Location = New System.Drawing.Point(655, 40)
        Me.txtDCash.Name = "txtDCash"
        Me.txtDCash.Size = New System.Drawing.Size(116, 20)
        Me.txtDCash.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(571, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 225
        Me.Label4.Text = "Diesel Cash:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(576, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 224
        Me.Label6.Text = "Diesel MT:"
        '
        'txtDMt
        '
        Me.txtDMt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDMt.Location = New System.Drawing.Point(654, 16)
        Me.txtDMt.Name = "txtDMt"
        Me.txtDMt.Size = New System.Drawing.Size(116, 20)
        Me.txtDMt.TabIndex = 9
        '
        'txtTotalkm
        '
        Me.txtTotalkm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalkm.Location = New System.Drawing.Point(492, 59)
        Me.txtTotalkm.Name = "txtTotalkm"
        Me.txtTotalkm.Size = New System.Drawing.Size(74, 20)
        Me.txtTotalkm.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(423, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 223
        Me.Label5.Text = "Total Km:"
        '
        'detadd
        '
        Me.detadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detadd.Location = New System.Drawing.Point(655, 127)
        Me.detadd.Name = "detadd"
        Me.detadd.Size = New System.Drawing.Size(73, 28)
        Me.detadd.TabIndex = 13
        Me.detadd.Text = "&Add"
        Me.detadd.UseVisualStyleBackColor = True
        '
        'txtarea
        '
        Me.txtarea.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtarea.Location = New System.Drawing.Point(95, 40)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(118, 20)
        Me.txtarea.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(52, 45)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 17)
        Me.Label24.TabIndex = 217
        Me.Label24.Text = "Area:"
        '
        'txtOther
        '
        Me.txtOther.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOther.Location = New System.Drawing.Point(492, 35)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(74, 20)
        Me.txtOther.TabIndex = 7
        '
        'txtDeisel
        '
        Me.txtDeisel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDeisel.Location = New System.Drawing.Point(305, 18)
        Me.txtDeisel.Name = "txtDeisel"
        Me.txtDeisel.Size = New System.Drawing.Size(86, 20)
        Me.txtDeisel.TabIndex = 3
        '
        'txtda
        '
        Me.txtda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtda.Location = New System.Drawing.Point(305, 62)
        Me.txtda.Name = "txtda"
        Me.txtda.Size = New System.Drawing.Size(86, 20)
        Me.txtda.TabIndex = 5
        '
        'txtDriverName
        '
        Me.txtDriverName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDriverName.Location = New System.Drawing.Point(654, 91)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(116, 20)
        Me.txtDriverName.TabIndex = 12
        '
        'txtLA
        '
        Me.txtLA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLA.Location = New System.Drawing.Point(492, 12)
        Me.txtLA.Name = "txtLA"
        Me.txtLA.Size = New System.Drawing.Size(74, 20)
        Me.txtLA.TabIndex = 6
        '
        'txtToll
        '
        Me.txtToll.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtToll.Location = New System.Drawing.Point(305, 39)
        Me.txtToll.Name = "txtToll"
        Me.txtToll.Size = New System.Drawing.Size(86, 20)
        Me.txtToll.TabIndex = 4
        '
        'txtNoChicks
        '
        Me.txtNoChicks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNoChicks.Location = New System.Drawing.Point(95, 65)
        Me.txtNoChicks.Name = "txtNoChicks"
        Me.txtNoChicks.Size = New System.Drawing.Size(118, 20)
        Me.txtNoChicks.TabIndex = 2
        '
        'dtpHatchDt
        '
        Me.dtpHatchDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpHatchDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHatchDt.Location = New System.Drawing.Point(95, 16)
        Me.dtpHatchDt.Name = "dtpHatchDt"
        Me.dtpHatchDt.Size = New System.Drawing.Size(118, 20)
        Me.dtpHatchDt.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(239, 65)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 17)
        Me.Label22.TabIndex = 213
        Me.Label22.Text = "D.A. Amt:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(566, 92)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 212
        Me.Label11.Text = "Driver Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(391, 15)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 17)
        Me.Label12.TabIndex = 215
        Me.Label12.Text = "L.A/U.L.Amt :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 17)
        Me.Label13.TabIndex = 214
        Me.Label13.Text = "Hatch Date:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(415, 38)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 17)
        Me.Label17.TabIndex = 209
        Me.Label17.Text = "Other Amt:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(218, 43)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 17)
        Me.Label18.TabIndex = 208
        Me.Label18.Text = "Toll Tax Amt:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(230, 19)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 17)
        Me.Label19.TabIndex = 211
        Me.Label19.Text = "Diesel Amt:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 65)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 17)
        Me.Label20.TabIndex = 210
        Me.Label20.Text = "No. of chicks:"
        '
        'dgexpenses
        '
        Me.dgexpenses.AllowUserToAddRows = False
        Me.dgexpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgexpenses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HatchDAte, Me.Area, Me.NoofChicks, Me.Deisel, Me.TollTax, Me.DA, Me.LAUl, Me.Other, Me.TotalKm, Me.dieselLtrs, Me.DriverNAme, Me.AcHead, Me.AcCode, Me.DieselCash, Me.DieselBPCL})
        Me.dgexpenses.Location = New System.Drawing.Point(12, 231)
        Me.dgexpenses.Name = "dgexpenses"
        Me.dgexpenses.ReadOnly = True
        Me.dgexpenses.Size = New System.Drawing.Size(778, 217)
        Me.dgexpenses.TabIndex = 5
        '
        'HatchDAte
        '
        Me.HatchDAte.DataPropertyName = " "
        Me.HatchDAte.HeaderText = "Hatch Date"
        Me.HatchDAte.Name = "HatchDAte"
        Me.HatchDAte.ReadOnly = True
        '
        'Area
        '
        Me.Area.DataPropertyName = " "
        Me.Area.HeaderText = "Area"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        '
        'NoofChicks
        '
        Me.NoofChicks.DataPropertyName = " "
        Me.NoofChicks.HeaderText = "No of Chicks"
        Me.NoofChicks.Name = "NoofChicks"
        Me.NoofChicks.ReadOnly = True
        '
        'Deisel
        '
        Me.Deisel.DataPropertyName = " "
        Me.Deisel.HeaderText = "Deisel"
        Me.Deisel.Name = "Deisel"
        Me.Deisel.ReadOnly = True
        '
        'TollTax
        '
        Me.TollTax.DataPropertyName = " "
        Me.TollTax.HeaderText = "TollTax"
        Me.TollTax.Name = "TollTax"
        Me.TollTax.ReadOnly = True
        '
        'DA
        '
        Me.DA.DataPropertyName = " "
        Me.DA.HeaderText = "D.A"
        Me.DA.Name = "DA"
        Me.DA.ReadOnly = True
        '
        'LAUl
        '
        Me.LAUl.DataPropertyName = " "
        Me.LAUl.HeaderText = "LA/UL"
        Me.LAUl.Name = "LAUl"
        Me.LAUl.ReadOnly = True
        '
        'Other
        '
        Me.Other.DataPropertyName = " "
        Me.Other.HeaderText = "Other"
        Me.Other.Name = "Other"
        Me.Other.ReadOnly = True
        '
        'TotalKm
        '
        Me.TotalKm.DataPropertyName = " "
        Me.TotalKm.HeaderText = "TotalKm"
        Me.TotalKm.Name = "TotalKm"
        Me.TotalKm.ReadOnly = True
        '
        'dieselLtrs
        '
        Me.dieselLtrs.DataPropertyName = " "
        Me.dieselLtrs.HeaderText = "Diesel MT"
        Me.dieselLtrs.Name = "dieselLtrs"
        Me.dieselLtrs.ReadOnly = True
        '
        'DriverNAme
        '
        Me.DriverNAme.DataPropertyName = " "
        Me.DriverNAme.HeaderText = "DriverName"
        Me.DriverNAme.Name = "DriverNAme"
        Me.DriverNAme.ReadOnly = True
        '
        'AcHead
        '
        Me.AcHead.DataPropertyName = " "
        Me.AcHead.HeaderText = "AcHead"
        Me.AcHead.Name = "AcHead"
        Me.AcHead.ReadOnly = True
        '
        'AcCode
        '
        Me.AcCode.DataPropertyName = " "
        Me.AcCode.HeaderText = "AcCode"
        Me.AcCode.Name = "AcCode"
        Me.AcCode.ReadOnly = True
        '
        'DieselCash
        '
        Me.DieselCash.HeaderText = "DieselCash"
        Me.DieselCash.Name = "DieselCash"
        Me.DieselCash.ReadOnly = True
        '
        'DieselBPCL
        '
        Me.DieselBPCL.HeaderText = "DieselBPCL"
        Me.DieselBPCL.Name = "DieselBPCL"
        Me.DieselBPCL.ReadOnly = True
        '
        'txtAcName
        '
        Me.txtAcName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAcName.Enabled = False
        Me.txtAcName.Location = New System.Drawing.Point(114, 14)
        Me.txtAcName.Name = "txtAcName"
        Me.txtAcName.ReadOnly = True
        Me.txtAcName.Size = New System.Drawing.Size(316, 20)
        Me.txtAcName.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Voucher Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "A/c Name:"
        '
        'txtvou_type
        '
        Me.txtvou_type.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtvou_type.Enabled = False
        Me.txtvou_type.Location = New System.Drawing.Point(114, 40)
        Me.txtvou_type.Name = "txtvou_type"
        Me.txtvou_type.ReadOnly = True
        Me.txtvou_type.Size = New System.Drawing.Size(116, 20)
        Me.txtvou_type.TabIndex = 101
        '
        'txtvou_no
        '
        Me.txtvou_no.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtvou_no.Enabled = False
        Me.txtvou_no.Location = New System.Drawing.Point(320, 41)
        Me.txtvou_no.Name = "txtvou_no"
        Me.txtvou_no.ReadOnly = True
        Me.txtvou_no.Size = New System.Drawing.Size(110, 20)
        Me.txtvou_no.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "Voucher No:"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcode.Location = New System.Drawing.Point(434, 17)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(12, 17)
        Me.lblcode.TabIndex = 217
        Me.lblcode.Text = "-"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(746, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(656, 453)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtNarration
        '
        Me.txtNarration.Location = New System.Drawing.Point(12, 457)
        Me.txtNarration.Name = "txtNarration"
        Me.txtNarration.ReadOnly = True
        Me.txtNarration.Size = New System.Drawing.Size(487, 20)
        Me.txtNarration.TabIndex = 218
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(504, 459)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(146, 20)
        Me.txtTotal.TabIndex = 219
        '
        'frmExpenseEntry
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 502)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtNarration)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtvou_no)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtvou_type)
        Me.Controls.Add(Me.txtAcName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgexpenses)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmExpenseEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgexpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents detadd As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtarea As System.Windows.Forms.TextBox
    Public WithEvents txtOther As System.Windows.Forms.TextBox
    Public WithEvents txtDeisel As System.Windows.Forms.TextBox
    Public WithEvents txtda As System.Windows.Forms.TextBox
    Public WithEvents txtDriverName As System.Windows.Forms.TextBox
    Public WithEvents txtLA As System.Windows.Forms.TextBox
    Public WithEvents txtToll As System.Windows.Forms.TextBox
    Public WithEvents txtNoChicks As System.Windows.Forms.TextBox
    Public WithEvents dtpHatchDt As System.Windows.Forms.DateTimePicker
    Public WithEvents txtAcName As System.Windows.Forms.TextBox
    Public WithEvents txtvou_type As System.Windows.Forms.TextBox
    Public WithEvents txtvou_no As System.Windows.Forms.TextBox
    Public WithEvents lblcode As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents dgexpenses As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents txtDMt As System.Windows.Forms.TextBox
    Public WithEvents txtTotalkm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNarration As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtDCash As System.Windows.Forms.TextBox
    Public WithEvents txtDBpcl As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HatchDAte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoofChicks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deisel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TollTax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LAUl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Other As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalKm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dieselLtrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverNAme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcHead As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DieselCash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DieselBPCL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
