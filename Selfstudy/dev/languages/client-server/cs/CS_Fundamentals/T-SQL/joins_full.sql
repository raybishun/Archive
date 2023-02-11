-- full Join
use SwDevFun
go
select * from Customers
select * from Orders

select id, [name], amount, [date]
from [dbo].[Customers]
full join [dbo].[Orders]
on Customers.id = Orders.Customer_ID
order by name, Amount