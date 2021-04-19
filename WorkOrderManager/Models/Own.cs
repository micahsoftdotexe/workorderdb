using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class Own
    {
        public int CustomerId { get; set; }
        public int AutomobileId { get; set; }

        public virtual Automobile Automobile { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
