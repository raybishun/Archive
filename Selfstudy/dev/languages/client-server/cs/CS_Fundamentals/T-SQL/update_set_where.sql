select * from tblEmployee

update [dbo].[tblEmployee]
set [EmployeeLastName] = 'Doe'
where [EmployeeLastName] = 'Smith'

select * from tblEmployee