using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            Owns = new HashSet<Own>();
            PhoneNumbers = new HashSet<PhoneNumber>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Own> Owns { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
