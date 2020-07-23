SELECT Acc_head_code,Acc_head, sum(amount) from dbo.INVINFO_PHFE_0809
where vou_type='PURCHASE' and  vou_date <= '6/14/2008' 
 group by Acc_head_code,Acc_head 

select Acc_head_code,Acc_head  ,sum(dramt) from VENTRY_PHFE_0809 where group_name='PURCHASE' 
 and vou_date <= '6/14/2008'  group by Acc_head_code,Acc_head 

select v.Acc_head_code,v.Acc_head,i.itemname from VENTRY_PHFE_0809 v 
left join  INVINFO_PHFE_0809 i on 
v.Acc_head_code=i.Acc_head_code and v.acc_head=i.acc_head 
where v.vou_type='PURCHASE'  group by v.Acc_head_code,v.Acc_head,i.itemname


select * from INVINFO_PHFE_0809 where vou_type='PURCHASE'  v 
inner join  INVINFO_PHFE_0809 i on 
v.Acc_head_code=i.Acc_head_code and v.acc_head=i.acc_head 
where v.group_name='PURCHASE'  and v.vou_date<='6/30/08'
order by  cast(v.vou_no as bigint)
--update INVINFO_PHFE_0809 set amount = round(Amount,0) where vou_type='PURCHASE'

select * from  VENTRY_PHFE_0809  where vou_type='PURCHASE' and vou_date='6/14/2008'
and acc_head_code='**PU0007'  order by  cast(vou_no as bigint)

select * from  INVINFO_PHFE_0809  where vou_type='PURCHASE'  and  vou_date='6/14/2008'
and acc_head_code='**PU0007'  order by  cast(vou_no as bigint)



select * from  INVINFO_PHFE_0809  where vou_type='PURCHASE' and vou_date='6/11/08'
and acc_head_code='**PU0002'  and  amount not in 
(select dramt from VENTRY_PHFE_0809 where vou_type='PURCHASE' and  vou_date='6/11/08'
and acc_head_code='**PU0002' )

select distinct vou_date from VENTRY_PHFE_0809 where vou_type='PURCHASE' and month(vou_date)=6 


select * from  INVINFO_PHFE_0809  where VOU_NO=134
UPDATE  INVINFO_PHFE_0809  set acc_head_code='**PU0002',acc_head='FEED PURCHASE(W-S)'
 where VOU_NO=158 and vou_type='PURCHASE'