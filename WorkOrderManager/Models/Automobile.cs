using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class Automobile
    {
        public Automobile()
        {
            Owns = new HashSet<Own>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int AutomobileId { get; set; }
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }

        public string Description { 
            get
            {
                return Convert.ToString(Year) + " " + Make + " " + Model + " " + "VIN: " + Vin;
            }
        }


        public virtual ICollection<Own> Owns { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
