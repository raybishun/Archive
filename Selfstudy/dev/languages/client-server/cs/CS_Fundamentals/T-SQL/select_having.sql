select * from sys.objects

select name, count(*) as 'How_Many'
from sys.objects
where name like 'plan%'
group by name
having count(*) = 1
order by name desc