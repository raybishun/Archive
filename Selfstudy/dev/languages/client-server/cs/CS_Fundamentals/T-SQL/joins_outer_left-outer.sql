-- left (outer) join
use SwDevFun
go
select * from Customers
select * from Orders

select id, [name], amount, [date]
from Customers
left join Orders
on Customers.id = Orders.Customer_ID
order by Name, Amount