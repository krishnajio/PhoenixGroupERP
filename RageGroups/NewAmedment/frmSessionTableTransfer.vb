Public Class frmSessionTableTransfer

    Private Sub frmSessionTableTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GMod.DataSetRet("select * from SessionMaster  where uname='admin' order by SessionId desc", "SessionMaster1")
        cmbSession.DataSource = GMod.ds.Tables("SessionMaster1")
        cmbSession.DisplayMember = "session"

        GMod.DataSetRet("select * from SessionMaster  where uname='admin' order by SessionId desc", "SessionMaster2")
        cmbSeesionNew.DataSource = GMod.ds.Tables("SessionMaster2")
        cmbSeesionNew.DisplayMember = "session"


        GMod.DataSetRet("select * from Company order by Cmpname", "SessTrfCmp")
        cmbCompanyName.DataSource = GMod.ds.Tables("SessTrfCmp")
        cmbCompanyName.DisplayMember = "Cmpname"

        cmdCompanyCode.DataSource = GMod.ds.Tables("SessTrfCmp")
        cmdCompanyCode.DisplayMember = "Cmp_id"

        FillGrid()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        CreateSessionTableds()
        FillGrid()
    End Sub
    Dim tablename As String, sql As String, sqlresult As String
    Private Sub CreateSessionTableds()
        Try

            tablename = "ACC_HEAD" & "_" & cmdCompanyCode.Text & "_" & cmbSeesionNew.Text
            sql = "CREATE TABLE " & tablename & "("
            sql &= "  [Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-'),"
            sql &= "  [account_code] [varchar](18)  NOT NULL DEFAULT ('-'),"
            sql &= "  [account_head_name] [varchar](100)  NOT NULL DEFAULT ('-'),"
            sql &= "  [group_name] [varchar](40)  NOT NULL DEFAULT ('-'),"
            sql &= "  [sub_group_name] [varchar](60)  NOT NULL DEFAULT ('-'),"
            sql &= "  [credit_days] [varchar](50)  NOT NULL DEFAULT ('-'),"
            sql &= "  [credit_limit] [varchar](50)  NOT NULL DEFAULT ('-'),"
            sql &= "  [opening_dr] [numeric](18, 2) NOT NULL DEFAULT ((0)),"
            sql &= "  [opening_cr] [numeric](18, 2) NOT NULL DEFAULT ((0)),"
            sql &= "  [account_type] [varchar](50)  NOT NULL DEFAULT ('-'),"
            sql &= "  [address] [varchar](100)  NOT NULL DEFAULT ('-'),"
            sql &= "  [city] [varchar](30)  NOT NULL DEFAULT ('-'),"
            sql &= "  [state] [varchar](30)  NOT NULL DEFAULT ('-'),"
            sql &= "  [phone] [varchar](20)  NOT NULL DEFAULT ('-'),"
            sql &= "  [pan_no] [varchar](20)  NOT NULL DEFAULT ('-'),"
            sql &= "  [rate_of_interest] [varchar](50)  NOT NULL DEFAULT ('-'),"
            sql &= "  [interest_rule_id] [varchar](50)  NULL DEFAULT ('-'),"
            sql &= "  [Area_code] [varchar](2)  NULL DEFAULT ('-'),"
            sql &= "  [remark1] [varchar](100)  NOT NULL DEFAULT ('-'),"
            sql &= "  [remark2] [varchar](100)  NOT NULL DEFAULT ('-'),"
            sql &= "  [remark3] [varchar](100)  NOT NULL DEFAULT ('-'),"
            sql &= "  [entry_date] [datetime] DEFAULT GETDATE(),"
            sql &= "  PRIMARY KEY CLUSTERED "
            sql &= "  ("
            sql &= "     [account_code] Asc"
            sql &= " ) WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]"
            sql &= " ) ON [PRIMARY]"
            GMod.SqlExecuteNonQuery(sql)


            tablename = "VENTRY" & "_" & cmdCompanyCode.Text & "_" & cmbSeesionNew.Text
            sql = "  CREATE TABLE " & tablename & "( "
            sql &= " [Cmp_id] [varchar](5)  NOT NULL DEFAULT ('-'),"
            sql &= " [Uname] [varchar](15)  NOT NULL DEFAULT ('-'),"
            sql &= " [Entry_id] [numeric](18, 2) NOT NULL DEFAULT ((0)),"
            sql &= " [Vou_no] [varchar](12)  NOT NULL DEFAULT ('-'),"
            sql &= " [Vou_type] [varchar](20)  NOT NULL DEFAULT ('-'),"
            sql &= " [Vou_date] [datetime] NOT NULL,"
            sql &= " [Acc_head_code] [varchar](18)  NOT NULL DEFAULT ('-'),"
            sql &= " [Acc_head] [varchar](100)  NOT NULL DEFAULT ('-'),"
            sql &= " [dramt] [numeric](18, 2) NOT NULL DEFAULT ((0)),"
            sql &= " [cramt] [numeric](18, 2) NOT NULL DEFAULT ((0)),"
            sql &= " [Pay_mode] [varchar](20)  NOT NULL DEFAULT ('-'),"
            sql &= " [Cheque_no] [varchar](15)  NOT NULL  DEFAULT ('-'),"
            sql &= " [Narration] [varchar](max)  NOT NULL DEFAULT ('-'),"
            sql &= " [Group_name] [varchar](40)  NOT NULL DEFAULT ('-'),"
            sql &= " [Sub_group_name] [varchar](60)  NOT NULL DEFAULT ('-'),"
            sql &= " [Ch_issue_date] [datetime] NULL,"
            sql &= " [Ch_date] [datetime] NULL,"
            sql &= " [id] [bigint] IDENTITY(1,1) NOT NULL,"
            sql &= " [VoucherTax] [varchar](50)  NULL,"
            sql &= " [TaxPer] [numeric](18, 2) NULL,"
            sql &= " [TaxType] [varchar](50)  NULL,"
            sql &= " [WinOut] [varchar](50)  NULL,"
            sql &= " [exp_date] [datetime] NULL,"
            sql &= " [item_name] [varchar](50)  NULL,"
            sql &= " [entry_date] [datetime] DEFAULT GETDATE() )"
            GMod.SqlExecuteNonQuery(sql)

            sql = " create TRIGGER trdel_" & cmdCompanyCode.Text & "_" & cmbSeesionNew.Text & " ON  [dbo].[VENTRY_" & cmdCompanyCode.Text & "_" & cmbSeesionNew.Text & "] for DELETE,update AS  BEGIN  declare @update_userid varchar(20) "
            sql &= " select @update_userid=Uname from inserted  insert into ventrytrgg (Cmp_id, Uname, Entry_id, "
            sql &= " Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt,  cramt, Pay_mode, Cheque_no, "
            sql &= " Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date, Update_date, Un) "
            sql &= " select Cmp_id, Uname, Entry_id, Vou_no, Vou_type, Vou_date, Acc_head_code, Acc_head, dramt, "
            sql &= "cramt, Pay_mode, Cheque_no, Narration, Group_name, Sub_group_name, Ch_issue_date, Ch_date ,"
            sql &= " getdate(),@update_userid from deleted  End   "
            GMod.SqlExecuteNonQuery(sql)

            'Groups Transfer
            sql = "insert Into Groups(Group_name, Suffix, BS_PL, Amount, Sqorder, Cmp_id, Dr_Cr, EffectsIN, session)"
            sql &= " select Group_name, Suffix, BS_PL, Amount, Sqorder, Cmp_id, Dr_Cr, EffectsIN, '" & cmbSeesionNew.Text & "'"
            sql &= " from Groups where cmp_id='" & cmdCompanyCode.Text & "' and session = '" & cmbSession.Text & "'"
            GMod.SqlExecuteNonQuery(sql)

            'Sub Groups Transfer
            sql = " insert into Sub_Group(Sub_group_name, Group_name, Sqorder, Group_level, Balances, Shedules, Cmp_id, session, Suffix)"
            sql &= " select Sub_group_name, Group_name, Sqorder, Group_level, Balances, Shedules, Cmp_id, '" & cmbSeesionNew.Text & "', Suffix"
            sql &= " from dbo.Sub_Group where cmp_id ='" & cmdCompanyCode.Text & "' and session ='" & cmbSession.Text & "'"
            GMod.SqlExecuteNonQuery(sql)

            'Voucher Type Transfer
            sql = "insert into vtype(Cmp_id, Vtype, Seqorder, Vou_no_seq, vprefix, vgrp, Session )"
            sql &= " select Cmp_id, Vtype, Seqorder, Vou_no_seq, vprefix, vgrp, '" & cmbSeesionNew.Text & "' from vtype "
            sql &= " where cmp_id='" & cmdCompanyCode.Text & "' and session ='" & cmbSession.Text & "'"
            GMod.SqlExecuteNonQuery(sql)

            'Head Transfer
            sql = "insert into ACC_HEAD_" & cmdCompanyCode.Text & "_" & cmbSeesionNew.Text & "([Cmp_id], [account_code], [account_head_name], [group_name], [sub_group_name], [credit_days], [credit_limit], [opening_dr], [opening_cr], [account_type], [address], [city], [state], [phone], [pan_no], [rate_of_interest], [interest_rule_id], [Area_code], [remark1], [remark2], [remark3]) "
            sql &= " select Cmp_id, account_code, account_head_name, group_name, sub_group_name, "
            sql &= " credit_days, credit_limit, '0', '0', account_type, address, "
            sql &= " city, state, phone, pan_no, rate_of_interest, interest_rule_id, Area_code, remark1, remark2, remark3"
            sql &= " from ACC_HEAD_" & cmdCompanyCode.Text & "_" & cmbSession.Text
            GMod.SqlExecuteNonQuery(sql)


            sql = "insert into [dbo].[SessionTrasferData]([CmpCode], [CmpName], [OldSession], [NewSession]) values("
            sql &= "'" & cmdCompanyCode.Text & "',"
            sql &= "'" & cmbCompanyName.Text & "',"
            sql &= "'" & cmbSession.Text & "',"
            sql &= "'" & cmbSeesionNew.Text & "')"
            MsgBox(GMod.SqlExecuteNonQuery(sql))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FillGrid()
        sql = "select * from [SessionTrasferData]"
        GMod.DataSetRet(sql, "SessionTrasferData")

        DataGridView1.DataSource = GMod.ds.Tables("SessionTrasferData")
    End Sub
End Class