set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go




ALTER function [dbo].[getAging](@entrydate datetime,@depo varchar(10))
returns @rettab table(acc_code varchar(20),acc_name varchar(100),entrydate datetime,dramt real,crdays int,invoice_no varchar(50),invoice_date datetime,
				duedate datetime,net_amt real,due_amt real,bal0to30 real,bal31to60 real ,bal90 real)
as
begin
declare @acc_code varchar(10),@accname varchar(100),@dramt real
if @depo='-1'
	set @depo='%'
declare c cursor for
	select q.acc_code,q.acname, DrAmt = 
	case when  ((isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr))  > 0 
	then  (isnull(p.dramt,0) + q.odr) - (isnull(p.cramt,0) + q.ocr) 
	else 0 end 
	 from ( select isnull(sum(dramt),0) dramt ,
	isnull(sum(cramt),0) cramt,acc_code from VENTRY_nage_1011  
	where vou_date<=@entrydate group by acc_code ) p  Right Join  
	( select acc_code,acc_name acname ,group_code, 
	isnull(opening_dr,0) odr  ,  isnull(opening_cr,0) ocr 
	from ACC_HEAD_nage_1011 where right(group_code,4)='0604' and remark1 like @depo ) q  on 
	p.acc_code=q.acc_code   where ((isnull(p.dramt,0) + q.odr) <> 
	(isnull(p.cramt,0) + q.ocr)) and ((isnull(p.dramt,0) + q.odr)-
	(isnull(p.cramt,0) + q.ocr))  >0 order by q.acname

open c
	fetch next from c into @acc_code,@accname,@dramt
while @@fetch_status=0
begin	
	insert into @rettab select @acc_code,@accname,@entrydate,@dramt,crdays ,invoice_no ,invoice_date ,
				duedate ,net_amt ,due_amt ,bal0to30 ,bal31to60 ,bal90 
		from getBalanceSlot(@entrydate,@acc_code,@dramt)

fetch next from c into @acc_code,@accname,@dramt
end
close c
deallocate c

return
end


--select * from getaging('09/20/2010','-1')
