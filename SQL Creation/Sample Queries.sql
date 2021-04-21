--Sample Queries:

select c.FirstName, w.date, l.LaborDesc, P. PartDescription
from customer c, WorkOrder w, labor l, part p
where w.customerID = c.customerID and l.WorkOrderID = w.WorkOrderID and p.WorkOrderID = w.WorkOrderID

--determine how many work orders each customer has
select c.FirstName, count(*)
from customer c, WorkOrder w
where w.CustomerID = c.CustomerID
group by c.FirstName
