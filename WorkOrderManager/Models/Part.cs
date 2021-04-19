using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class Part
    {
        public int PartId { get; set; }
        public int WorkOrderId { get; set; }
        public decimal PartPrice { get; set; }
        public decimal PartMargin { get; set; }
        public string PartDescription { get; set; }
        public string PartNumber { get; set; }

        public virtual WorkOrder WorkOrder { get; set; }
    }
}
