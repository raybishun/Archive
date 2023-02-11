--use SwDevFun
--go
--create procedure [dbo].[GetCustomers]
--	@Name varchar(50),
--	@Age int
--as
--	set nocount on
--	select [Name], [Age], [Address], [Salary]
--	from [SwDevFun].[dbo].[Customers]
--	where [Name] = @Name and [Age] = @Age

exec [dbo].[GetCustomers] "Muffy", 24
exec [dbo].[GetCustomers] @Name='Muffy', @Age=24