Public Class frmMISsalepurexp_rep

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sql, sqlinst, cmp, cn, up As String, i As Integer
        GMod.SqlExecuteNonQuery("delete from tmpSalePurExp")
        sql = "select * from dbo.Company where cmp_id like '%P%'"
        GMod.DataSetRet(sql, "CMP")


        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            sqlinst = "insert into dbo.tmpSalePurExp(cmpname) values('" & cn.ToString & "')"
            GMod.SqlExecuteNonQuery(sqlinst)
        Next

        sql = "select * from dbo.Company where cmp_id like '%P%'"
        GMod.DataSetRet(sql, "CMP")

        'SALE
        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)

            sql = "select isnull(sum(cramt),0) - isnull(sum(dramt),0) from " & cmp & " v" _
                  & " where group_name in (" _
                  & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
                  & " and dr_cr='Cr')  and vou_no not in ( select vou_no from  " & cmp & " v1 where group_name in  ('INTERNAL PARTY','PARTNER CAPITAL')" _
                  & " and  v.vou_type=v1.vou_type)" _
                  & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

            GMod.DataSetRet(sql, "sale")
            If GMod.ds.Tables("sale").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set sale = '" & GMod.ds.Tables("sale").Rows(0)(0) & "' where cmpname='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If

            'PURCHASE
            sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " & cmp & " v" _
            & " where group_name in (" _
            & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
            & " and dr_cr='Dr' and group_name='PURCHASE') and vou_no not in ( select vou_no from  " & cmp & " v1 where group_name in  ('INTERNAL PARTY','PARTNER CAPITAL')" _
            & " and  v.vou_type=v1.vou_type)" _
            & "   and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"



            GMod.DataSetRet(sql, "purchase")
            If GMod.ds.Tables("purchase").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set purchase = '" & GMod.ds.Tables("purchase").Rows(0)(0) & "' where cmpname='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If
            'Eepenses 
            sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " & cmp & " v" _
            & " where group_name in (" _
            & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
            & " and dr_cr='Dr'  and group_name<>'PURCHASE') and vou_no not in ( select vou_no from  " & cmp & " v1 where group_name in  ('INTERNAL PARTY','PARTNER CAPITAL')" _
            & " and  v.vou_type=v1.vou_type)" _
            & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"


            GMod.DataSetRet(sql, "expenses")
            If GMod.ds.Tables("expenses").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set expenses = '" & GMod.ds.Tables("expenses").Rows(0)(0) & "' where cmpname='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If
        Next


        '---------------------------------------
        'Try
        '    GMod.ds.Tables("CMP").Clear()
        'Catch ex As Exception
        'End Try

        'sql = "select * from dbo.Company where cmp_id = 'JAHA'"
        'GMod.DataSetRet(sql, "CMP")
        'cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
        'cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(0)("Cmp_id") & "_" & GMod.Getsession(Now.Date)

        'sqlinst = "insert into dbo.tmpSalePurExp(cmpname) values('" & cn.ToString & "')"
        'GMod.SqlExecuteNonQuery(sqlinst)
        ''SALE
        'For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
        '    cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
        '    cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
        '    sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " _
        '               & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
        '                & " and vou_type<>'BANKREC' and Group_name in (select Group_name from Groups where cmp_id='PHOE' and BS_PL='PL'and Dr_Cr='Cr')"
        '    GMod.DataSetRet(sql, "sale")
        '    If GMod.ds.Tables("sale").Rows.Count > 0 Then
        '        up = "update  tmpSalePurExp set sale = '" & GMod.ds.Tables("sale").Rows(0)(0) & "' where cmpname='" & cn & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '    End If
        '    'PURCHASE
        '    sql = "select sum(dramt) - sum(cramt),Group_name from " _
        '                   & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
        '                    & " and vou_type<>'BANKREC' and Group_name='PURCHASE' " _
        '                   & " group by  Group_name "
        '    GMod.DataSetRet(sql, "purchase")
        '    If GMod.ds.Tables("purchase").Rows.Count > 0 Then
        '        up = "update  tmpSalePurExp set purchase = '" & GMod.ds.Tables("purchase").Rows(0)(0) & "' where cmpname='" & cn & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '    End If
        '    'Eepenses 
        '    sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " _
        '                  & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
        '                   & " and vou_type<>'BANKREC' and Group_name in (select Group_name from Groups where cmp_id='PHOE' and BS_PL='PL'and Dr_Cr='Dr' and group_name<>'PURCHASE')"
        '    GMod.DataSetRet(sql, "expenses")
        '    If GMod.ds.Tables("expenses").Rows.Count > 0 Then
        '        up = "update  tmpSalePurExp set expenses = '" & GMod.ds.Tables("expenses").Rows(0)(0) & "' where cmpname='" & cn & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '    End If
        'Next

        sql = "select * from tmpSalePurExp"
        GMod.DataSetRet(sql, "tmpSalePurExp")
        Dim r As New CrMISPur_Sale_Expen
        r.SetDataSource(GMod.ds.Tables("tmpSalePurExp"))
        ' r.SetParameterValue("subhead", "Over Amount :" & txtamt.Text)
        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtTo.Text & "(" & Button1.Text & ")")
        CrViewerGenralLedger.ReportSource = r
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'With  internal party
        Dim sql, sqlinst, cmp, cn, up As String, i As Integer
        GMod.SqlExecuteNonQuery("delete from tmpSalePurExp")
        sql = "select * from dbo.Company where cmp_id like '%P%'"
        GMod.DataSetRet(sql, "CMP")


        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            sqlinst = "insert into dbo.tmpSalePurExp(cmpname) values('" & cn.ToString & "')"
            GMod.SqlExecuteNonQuery(sqlinst)
        Next

        sql = "select * from dbo.Company where cmp_id like '%P%'"
        GMod.DataSetRet(sql, "CMP")

        'SALE
        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)

            sql = "select isnull(sum(cramt),0) - isnull(sum(dramt),0) from " & cmp & " v" _
                  & " where group_name in (" _
                  & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
                  & " and dr_cr='Cr')  " _
                  & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

            GMod.DataSetRet(sql, "sale")
            If GMod.ds.Tables("sale").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set sale = '" & GMod.ds.Tables("sale").Rows(0)(0) & "' where cmpname='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If

            'PURCHASE
            sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " & cmp & " v" _
            & " where group_name in (" _
            & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
            & " and dr_cr='Dr' and group_name='PURCHASE') " _
            & "   and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"



            GMod.DataSetRet(sql, "purchase")
            If GMod.ds.Tables("purchase").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set purchase = '" & GMod.ds.Tables("purchase").Rows(0)(0) & "' where cmpname='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If
            'Eepenses 
            sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " & cmp & " v" _
            & " where group_name in (" _
            & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
            & " and dr_cr='Dr'  and group_name<>'PURCHASE') " _
            & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"


            GMod.DataSetRet(sql, "expenses")
            If GMod.ds.Tables("expenses").Rows.Count > 0 Then
                up = "update  tmpSalePurExp set expenses = '" & GMod.ds.Tables("expenses").Rows(0)(0) & "' where cmpname='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If
        Next


        '---------------------------------------
        'Try
        '    GMod.ds.Tables("CMP").Clear()
        'Catch ex As Exception
        'End Try

        'sql = "select * from dbo.Company where cmp_id = 'JAHA'"
        'GMod.DataSetRet(sql, "CMP")
        'cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
        'cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(0)("Cmp_id") & "_" & GMod.Getsession(Now.Date)

        'sqlinst = "insert into dbo.tmpSalePurExp(cmpname) values('" & cn.ToString & "')"
        'GMod.SqlExecuteNonQuery(sqlinst)
        ''SALE
        'For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
        '    cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
        '    cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
        '    sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " _
        '               & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
        '                & " and vou_type<>'BANKREC' and Group_name in (select Group_name from Groups where cmp_id='PHOE' and BS_PL='PL'and Dr_Cr='Cr')"
        '    GMod.DataSetRet(sql, "sale")
        '    If GMod.ds.Tables("sale").Rows.Count > 0 Then
        '        up = "update  tmpSalePurExp set sale = '" & GMod.ds.Tables("sale").Rows(0)(0) & "' where cmpname='" & cn & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '    End If
        '    'PURCHASE
        '    sql = "select sum(dramt) - sum(cramt),Group_name from " _
        '                   & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
        '                    & " and vou_type<>'BANKREC' and Group_name='PURCHASE' " _
        '                   & " group by  Group_name "
        '    GMod.DataSetRet(sql, "purchase")
        '    If GMod.ds.Tables("purchase").Rows.Count > 0 Then
        '        up = "update  tmpSalePurExp set purchase = '" & GMod.ds.Tables("purchase").Rows(0)(0) & "' where cmpname='" & cn & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '    End If
        '    'Eepenses 
        '    sql = "select isnull(sum(dramt),0) - isnull(sum(cramt),0) from " _
        '                  & cmp & " where  Vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'" _
        '                   & " and vou_type<>'BANKREC' and Group_name in (select Group_name from Groups where cmp_id='PHOE' and BS_PL='PL'and Dr_Cr='Dr' and group_name<>'PURCHASE')"
        '    GMod.DataSetRet(sql, "expenses")
        '    If GMod.ds.Tables("expenses").Rows.Count > 0 Then
        '        up = "update  tmpSalePurExp set expenses = '" & GMod.ds.Tables("expenses").Rows(0)(0) & "' where cmpname='" & cn & "'"
        '        GMod.SqlExecuteNonQuery(up)
        '    End If
        'Next

        sql = "select * from tmpSalePurExp"
        GMod.DataSetRet(sql, "tmpSalePurExp")
        Dim r As New CrMISPur_Sale_Expen
        r.SetDataSource(GMod.ds.Tables("tmpSalePurExp"))
        ' r.SetParameterValue("subhead", "Over Amount :" & txtamt.Text)
        r.SetParameterValue("subhead", "Date from :" & dtfrom.Text & " to " & dtTo.Text & "(" & Button2.Text & ")")
        CrViewerGenralLedger.ReportSource = r

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        'CEHA        'GAPO
        'JAHA        'LWMI
        'LWSS        'PEPO
        'PHAG        'PHBR
        'PHBU        'PHCH
        'PHFA        'PHFE
        'PHFO        'PHHA
        'PHLU        'PHOE
        'PHPO        'PHSO
        'RAFI        'SHVI
        'SMAN        'UNTH
        'UNWE        'VIAS
        'WEPH
        Dim sql, sqlinst, cmp, cn, up As String, i As Integer
        GMod.SqlExecuteNonQuery("delete from tmpTrial4date")
        sql = "select * from dbo.Company where cmp_id like '%P%' or cmp_id like '%J%'  and cmp_id<>'GAPO'"
        GMod.DataSetRet(sql, "CMP")
        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            sqlinst = "insert into dbo.tmpTrial4date(account_head_name) values('" & cn.ToString & "')"
            GMod.SqlExecuteNonQuery(sqlinst)
        Next
        sql = "select * from dbo.Company where cmp_id like '%P%' or cmp_id like '%J%'  and cmp_id<>'GAPO'"
        GMod.DataSetRet(sql, "CMP")
        'SALE
        Dim saleamt As Double = 0.0
        Dim temp As Double = 0.0
        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            If GMod.ds.Tables("CMP").Rows(i)("Cmp_id") = "PHHA" Or GMod.ds.Tables("CMP").Rows(i)("Cmp_id") = "PHOE" Or GMod.ds.Tables("CMP").Rows(i)("Cmp_id") = "WEPH" Then
                'sql = "select isnull(sum(cramt),0) - isnull(sum(dramt),0)  from " & cmp & " v " _
                '& " inner Join " _
                '& " printdata p on v.vou_no=p.vou_no where session='" & GMod.Session & "' and " _
                '& " p.cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and v.vou_type='SALE' and  v.cramt>0 " _
                '& " and billdate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Productname not in ('DISCOUNT AMOUNT','N.E.E.C AMOUNT') and left(acccode,4) not in ('**IP','**PC')"

                sql = "select round(isnull(sum(amount),0),0) from printdata where session='" & GMod.Session & "' and cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "'" _
                & " and billdate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Productname not in ('DISCOUNT AMOUNT','N.E.E.C AMOUNT')"
                '& " and left(acccode,4) not in ('**IP','**PC') " _
                GMod.DataSetRet(sql, "sale")


                sql = " select round(isnull(sum(cramt),0) - isnull(sum(dramt),0),0) from " & cmp & " v" _
                & " where group_name in (" _
                & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
                & " and dr_cr='Cr' and group_name not in ('DISCOUNT','SALE') )  " _
                & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
                GMod.DataSetRet(sql, "misssale")

                ' MsgBox(GMod.ds.Tables("misssale").Rows(0)(0).ToString + cmp)
                temp = Val(GMod.ds.Tables("sale").Rows(0)(0)) + Val(GMod.ds.Tables("misssale").Rows(0)(0))



                If GMod.ds.Tables("sale").Rows.Count > 0 Then
                    up = "update  tmpTrial4date set odr = '" & temp & "' where account_head_name='" & cn & "'"
                    saleamt = CDbl(GMod.ds.Tables("sale").Rows(0)(0))
                    GMod.SqlExecuteNonQuery(up)
                End If


            Else
                sql = " select round(isnull(sum(cramt),0) - isnull(sum(dramt),0),0) from " & cmp & " v" _
                & " where group_name in (" _
                & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
                & " and dr_cr='Cr' and group_name<>'DISCOUNT')  " _
                & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

                GMod.DataSetRet(sql, "sale")
                If GMod.ds.Tables("sale").Rows.Count > 0 Then
                    up = "update  tmpTrial4date set odr = '" & GMod.ds.Tables("sale").Rows(0)(0) & "' where account_head_name='" & cn & "'"
                    saleamt = CDbl(GMod.ds.Tables("sale").Rows(0)(0))
                    GMod.SqlExecuteNonQuery(up)
                End If



            End If



            'Internal party Sale 
            If GMod.ds.Tables("CMP").Rows(i)("Cmp_id").ToString.ToUpper = "PHHA" Or GMod.ds.Tables("CMP").Rows(i)("Cmp_id") = "PHOE" Or GMod.ds.Tables("CMP").Rows(i)("Cmp_id") = "WEPH" Then
                ' MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id").ToString.ToUpper)
                'sql = "select isnull(sum(cramt),0) - isnull(sum(dramt),0)  from " & cmp & " v " _
                '& " inner Join " _
                '& " printdata p on v.vou_no=p.vou_no where session='" & GMod.Session & "' and " _
                '& " p.cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and v.vou_type='SALE' and  v.cramt>0 " _
                '& " and billdate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Productname not in ('DISCOUNT AMOUNT','N.E.E.C AMOUNT') and left(acccode,4) in ('**IP','**PC') "
                sql = "select round(isnull(sum(amount),0),0) from printdata where session='" & GMod.Session & "' and cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "'" _
                & " and left(acccode,4) in ('**IP','**PC') " _
                & " and billdate between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and Productname not in ('DISCOUNT AMOUNT','N.E.E.C AMOUNT')"
            Else
                'sql = "select isnull(sum(cramt),0) - isnull(sum(dramt),0) from " & cmp & " v" _
                '& " where group_name in (" _
                '& " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
                '& " and dr_cr='Cr' and group_name<>'DISCOUNT')  " _
                '& " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

                sql = "select round(isnull(sum(dramt),0),0) from " & cmp & " where group_name='INTERNAL PARTY'" _
                & " and vou_type='sale' and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"
            End If
            GMod.DataSetRet(sql, "cr")
            If GMod.ds.Tables("cr").Rows.Count > 0 Then
                If GMod.ds.Tables("cr").Rows(0)(0).ToString <> "" Then
                    saleamt = saleamt - CDbl(GMod.ds.Tables("cr").Rows(0)(0).ToString)
                Else
                    saleamt = 0
                End If
                up = "update  tmpTrial4date set [2dr] = '" & GMod.ds.Tables("cr").Rows(0)(0) & "' where account_head_name='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If


            sql = " Select round(isnull(sum(cramt), 0),0)  " _
                      & " from " & cmp & " where group_name in ('CUSTOMER','CASH COLL','INCOME') " _
                      & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "' and vou_type in ('CR VOUCHER','BANK TRANS','CASH COLL')"
            GMod.DataSetRet(sql, "ct")
            If GMod.ds.Tables("ct").Rows.Count > 0 Then
                saleamt = CDbl(GMod.ds.Tables("ct").Rows(0)(0)) - saleamt
                up = "update  tmpTrial4date set [1dr] = '" & saleamt & "' where account_head_name='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If
        Next
        up = "update  tmpTrial4date set [ocr]=[odr]-abs([2dr]) "
        GMod.SqlExecuteNonQuery(up)

        up = "update  tmpTrial4date set [2cr]=[ocr]-abs([1dr]) where [1dr]<0"
        GMod.SqlExecuteNonQuery(up)

        up = "update  tmpTrial4date set [2cr]=[ocr]+ abs([1dr]) where [1dr]>0"
        GMod.SqlExecuteNonQuery(up)

        sql = "select * from tmpTrial4date where ([odr]>0 or [1dr]>0 or [2dr]>0)"
        GMod.DataSetRet(sql, "tmpTrial4date")
        Dim r As New CrCustDrCrCashrecsaletoCustSaletoIP
        r.SetDataSource(GMod.ds.Tables("tmpTrial4date"))
        ' r.SetParameterValue("subhead", "Over Amount :" & txtamt.Text)
        r.SetParameterValue("0", "Date from :" & dtfrom.Text & " to " & dtTo.Text)
        CrViewerGenralLedger.ReportSource = r
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sql, sqlinst, cmp, cn, up As String, i As Integer
        GMod.SqlExecuteNonQuery("delete from tmpTrial4date")
        sql = "select * from dbo.Company where cmp_id like '%P%'"
        GMod.DataSetRet(sql, "CMP")


        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            'MsgBox(GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date))
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            sqlinst = "insert into dbo.tmpTrial4date(account_head_name) values('" & cn.ToString & "')"
            GMod.SqlExecuteNonQuery(sqlinst)
        Next

        sql = "select * from dbo.Company where cmp_id like '%PAHA%'"
        GMod.DataSetRet(sql, "CMP")

        'INCOME
        For i = 0 To GMod.ds.Tables("CMP").Rows.Count - 1
            cn = GMod.ds.Tables("CMP").Rows(i)("Cmpname")
            cmp = "VENTRY_" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "_" & GMod.Getsession(Now.Date)

            sql = "select isnull(sum(cramt),0) - isnull(sum(dramt),0) from " & cmp & " v" _
                  & " where group_name in (" _
                  & " select group_name from groups where cmp_id='" & GMod.ds.Tables("CMP").Rows(i)("Cmp_id") & "' and bs_pl='PL'" _
                  & " and dr_cr='Cr' and group_name<>'DISCOUNT')  " _
                  & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

            GMod.DataSetRet(sql, "sale")
            If GMod.ds.Tables("sale").Rows.Count > 0 Then
                up = "update  tmpTrial4date set odr = '" & GMod.ds.Tables("sale").Rows(0)(0) & "' where account_head_name='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If

            'CUSTOMER Dr/Cr
            sql = " Select isnull(sum(cramt), 0) - isnull(sum(dramt), 0) " _
            & " from " & cmp & " where group_name='CUSTOMER' " _
            & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

            GMod.DataSetRet(sql, "ct")
            If GMod.ds.Tables("ct").Rows.Count > 0 Then
                up = "update  tmpTrial4date set [1dr] = '" & GMod.ds.Tables("ct").Rows(0)(0) & "' where account_head_name='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If


            'sql = "select sum(cramt) cr from " & cmp & "" _
            '& " where vou_type in ('CR VOUCHER','BANK TRANS','CASH COLL') " _
            '& " and group_name  in ('CUSTOMER','CASH COLL','INCOME') " _
            '& " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

            sql = "select isnull(sum(cramt),0) from " & cmp _
                  & " where group_name='SALE' " _
                  & " and vou_no  in ( " _
                  & " select vou_no from " & cmp & " " _
                  & " where group_name='INTERNAL PARTY' and vou_type='SALE') " _
                  & " and vou_date between '" & dtfrom.Value.ToShortDateString & "' and '" & dtTo.Value.ToShortDateString & "'"

            GMod.DataSetRet(sql, "cr")
            If GMod.ds.Tables("cr").Rows.Count > 0 Then
                up = "update  tmpTrial4date set [2dr] = '" & GMod.ds.Tables("cr").Rows(0)(0) & "' where account_head_name='" & cn & "'"
                GMod.SqlExecuteNonQuery(up)
            End If
        Next
        sql = "select * from tmpTrial4date"
        GMod.DataSetRet(sql, "tmpTrial4date")
        Dim r As New CrCustDrCrCashrecsaletoCustSaletoIP
        r.SetDataSource(GMod.ds.Tables("tmpTrial4date"))
        ' r.SetParameterValue("subhead", "Over Amount :" & txtamt.Text)
        r.SetParameterValue("0", "Date from :" & dtfrom.Text & " to " & dtTo.Text & "(" & Button2.Text & ")")
        CrViewerGenralLedger.ReportSource = r
    End Sub
End Class