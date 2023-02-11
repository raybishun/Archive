--select * from sys.columns
select * from sys.objects
-- where schema_id = 1
-- where schema_id <> 1
-- where object_id = 3 or object_id = 4
-- where object_id > 5 and object_id < 26
-- where object_id between 5 and 26
-- where object_id in (3,5,6,7,8,9)
-- where type_desc = 'SYSTEM_TABLE'
-- where type_desc like 'SYS%'
-- where type_desc not like 'SYS%'
where type_desc like 'S_S%'
-- where create_date between '2003-01-01' and '2003-12-31'
order by object_id