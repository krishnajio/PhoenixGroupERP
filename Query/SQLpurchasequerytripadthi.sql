select sum(qty) qty ,item_code,month(vou_date) month ,
for_where,sum(amt),sum(amt)/sum(qty) rate
 from purchase_data 
group by item_code,month(vou_date),for_where having item_code='**PF0115'  
and month(vou_date)=4



select * from dbo.ACC_HEAD_phha_1011  
where len(address)>1