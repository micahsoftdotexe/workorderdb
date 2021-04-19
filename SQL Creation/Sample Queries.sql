--Sample Queries:

select c.FirstName, w.date, l.LaborDesc, P. PartDescription
from customer c, WorkOrder w, labor l, part p
where w.customerID = c.customerID and l.WorkOrderID = w.WorkOrderID and p.WorkOrderID = w.WorkOrderID

