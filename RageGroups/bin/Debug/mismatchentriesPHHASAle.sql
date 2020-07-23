select * from dbo.VENTRY_PHHA_0809 where vou_type='SALE' order by cast(vou_no as bigint)

select * from printdata p where vou_type='SALE' and cmp_id='PHHA' and type='P'  
and Acccode not in ( select Acc_head_code from dbo.VENTRY_PHHA_0809 v where vou_type='SALE' 
 and p.Acccode=v.Acc_head_code and p.vou_no=v.vou_no )
 