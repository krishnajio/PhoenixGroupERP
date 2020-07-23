select * from dbo.VENTRY_PHHA_0809 
where Acc_head_code='**IM0006'


select * from VENTRY_PHHA_0809  v
where Group_name not in 
(select group_name from ACC_HEAD_PHHA_0809 a where a.account_code=v.Acc_head_code )