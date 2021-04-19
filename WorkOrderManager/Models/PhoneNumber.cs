using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class PhoneNumber
    {
        public int CustomerId { get; set; }
        public int PhoneType { get; set; }
        public string PhoneNumber1 { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PhoneType PhoneTypeNavigation { get; set; }
    }
}
