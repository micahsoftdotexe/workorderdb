using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class Address
    {
        public int CustomerId { get; set; }
        public int AddressType { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }

        public virtual AddressType AddressTypeNavigation { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
