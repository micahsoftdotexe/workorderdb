using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            Addresses = new HashSet<Address>();
        }

        public int AddressType1 { get; set; }
        public string AddressDescription { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
