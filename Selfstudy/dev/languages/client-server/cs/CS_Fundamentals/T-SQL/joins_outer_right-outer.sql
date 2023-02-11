-- right (outer) join
use SwDevFun
go
select * from Customers
select * from Orders

select oid, [name], amount
from Customers
right join Orders
on Customers.id = Orders.Customer_ID
order by OID, Name, Amount