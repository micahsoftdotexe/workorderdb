using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            PhoneNumbers = new HashSet<PhoneNumber>();
        }

        public int PhoneType1 { get; set; }
        public string PhoneDescription { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
