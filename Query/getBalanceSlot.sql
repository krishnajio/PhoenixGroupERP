set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER function [dbo].[getBalanceSlot](@entrydate datetime,@partycode varchar(30),@balanceamt real)
returns @rettab table (crdays int,invoice_no varchar(50),acc_code varchar(20),invoice_date datetime,
				duedate datetime,net_amt real,due_amt real,bal0to30 real,bal31to60 real ,bal90 real)
as
begin
	declare @bal0to30 real,@bal31to60 real,@bal90 real
	declare @crdays int,@invoice_no varchar(50),@invoice_date datetime,
				@duedate datetime,@net_amt real,@due_amt real
	declare @datediff int;
	declare cur cursor for
		select crdays,si.invoice_no,si.invoice_date,duedate,net_amt from SALE_INVOICE_NAGE_1011 si 
		inner join CreditLimit cl on cl.invoice_no=si.invoice_no and cl.session='1011'
		where acc_code=@partycode and si.invoice_date<=@entrydate order by si.invoice_date desc
	
	open cur
	fetch next from cur into @crdays,@invoice_no,@invoice_date,@duedate,@net_amt
	while @@fetch_status=0 and @balanceamt>0
	begin
		set @due_amt=0;	
		select @bal0to30 =0,@bal31to60 =0,@bal90 =0;	
		if @duedate<@entrydate
		begin
			if @balanceamt<@net_amt 
				set @due_amt=@balanceamt;
			else
				set @due_amt=@net_amt;
			
			set @datediff=datediff(day,@duedate,@entrydate) ;
			--set @datediff=@crdays;
			if @datediff <=30
				set @bal0to30=@due_amt;
			else if @datediff <=60
				set @bal31to60=@due_amt;
			else 
				set @bal90=@due_amt;
		end

		set @balanceamt=@balanceamt-@due_amt;
		
		insert into @rettab values (@crdays,@invoice_no,@partycode,@invoice_date,@duedate,@net_amt,@due_amt,
									@bal0to30 ,@bal31to60 ,@bal90)
		
	fetch next from cur into @crdays,@invoice_no,@invoice_date,@duedate,@net_amt
	end
	close cur
	deallocate cur	
		
return
end
