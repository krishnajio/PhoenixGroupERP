select * from printdata where cmp_id='PHHA' 
and vou_no='9759'


select * from VENTRY_PHHA_0809  where cmp_id='PHHA' 
and vou_no='9759' and vou_type='SALE' and Group_name='CUSTOMER'


update printdata set acccode='' , accname='' where vou_no='' and cmp_id='PHHA' and session='0809'


select * from log_table where vou_no='296' and vou_type='SALE'

select * from printdata p where vou_type='SALE' and cmp_id='PHHA' and type='P'  
and Acccode not in ( select Acc_head_code from dbo.VENTRY_PHHA_0809 v where vou_type='SALE' 
 and p.Acccode=v.Acc_head_code and p.vou_no=v.vou_no )

select * from printdata p where vou_type='SALE' and cmp_id='PHHA' and type='P'  
and Acccode not in ( select account_code from dbo.ACC_HEAD_PHha_0809 v  
 where p.Acccode=v.account_code )

update printdata set acccode='MHCU0009' , accname='SANJAY RAI' where vou_no='296' and cmp_id='PHHA' and session='0809'