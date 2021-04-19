using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class Labor
    {
        public int LaborId { get; set; }
        public int WorkOrderId { get; set; }
        public string LaborDesc { get; set; }
        public string LaborNotes { get; set; }
        public decimal LaborPrice { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }
    }
}
