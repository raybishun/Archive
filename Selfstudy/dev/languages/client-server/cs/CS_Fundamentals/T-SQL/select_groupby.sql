select * from sys.objects

select distinct schema_id
from sys.objects

select top 10 schema_id
from sys.objects

select schema_id, count(schema_id) as 'How_Many'
from sys.objects
group by schema_id

select schema_id, count(schema_id) as 'How_Many'
from sys.objects
where type_desc like '%sys%'
group by schema_id