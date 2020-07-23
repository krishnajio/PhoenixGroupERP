select * from dbo.INVINFO_PHFE_0809 where acc_head_code='**PU0004'  
and vou_type='PURCHASE' ORDER BY CAST(VOU_NO AS BIGINT)
select * from dbo.VENTRY_PHFE_0809   where   acc_head_code='**PU0004' and vou_type='PURCHASE'  ORDER BY CAST(VOU_NO AS BIGINT)


select distinct vou_no from INVINFO_PHFE_0809  v  where   acc_head_code='**PU0008' and  AMOUNT not in (
select DRAMT from VENTRY_PHFE_0809  i where acc_head_code='**PU0008' and v.vou_no=i.vou_no
and v.acc_head_code=i.acc_head_code
) and vou_type='PURCHASE' ORDER BY CAST(VOU_NO AS BIGINT)

select * from  VENTRY_PHFE_0809   v  where   acc_head_code='**PU0008' and  vou_no not in (
select vou_no from INVINFO_PHFE_0809  i where acc_head_code='**PU0008' and v.vou_no=i.vou_no
and v.acc_head_code=i.acc_head_code
) and vou_type='PURCHASE' ORDER BY CAST(VOU_NO AS BIGINT)


select * from  INVINFO_PHFE_0809    v  where   acc_head_code='**PU0008' and  vou_no not in (
select vou_no from  VENTRY_PHFE_0809 i where acc_head_code='**PU0008' and v.vou_no=i.vou_no
and v.acc_head_code=i.acc_head_code
) and vou_type='PURCHASE' ORDER BY CAST(VOU_NO AS BIGINT)



select * from dbo.INVINFO_PHFE_0809 where vou_no='96' and vou_type='PURCHASE'
select * from dbo.VENTRY_PHFE_0809 where vou_no='96' and vou_type='PURCHASE'
select sum(amount) from dbo.INVINFO_PHFE_0809 where vou_no='978' and vou_type='PURCHASE'

UPDATE INVINFO_PHFE_0809 SET AMOUNT=10654.00  where vou_no='373' and vou_type='PURCHASE'

select * from dbo.VENTRY_PHFE_0809 where vou_no='1219' and vou_type='PURCHASE'

print 92712452.00-92644952.00

DELETE FROM INVINFO_PHFE_0809 where vou_no='683' and vou_type='PURCHASE' AND ACC_HEAD_CODE='**PU0004'
delete from INVINFO_PHFE_0809 where vou_no='96' and vou_type='PURCHASE' and isnull(hatch_date,0)=0

insert into tfeed
select sum(amount),vou_no from dbo.INVINFO_PHFE_0809  
where acc_head_code='**PU0002' group by vou_no


select * from tfeed v where amt not in (
select DRAMT from VENTRY_PHFE_0809  i where acc_head_code='**PU0002' and v.v=i.vou_no)

