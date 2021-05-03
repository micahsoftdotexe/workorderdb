using System;
using System.Collections.Generic;

#nullable disable

namespace WorkOrderManager.Models
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            Labors = new HashSet<Labor>();
            Parts = new HashSet<Part>();
        }

        public int WorkOrderId { get; set; }
        public int CustomerId { get; set; }
        public int AutomobileId { get; set; }
        public DateTime Date { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public string WorkOrderNotes { get; set; }
        public decimal AmountPaid { get; set; }
        public byte[] PaidInFull { get; set; }
        public string fullinfo{
            get
            {
                //return Customer.FirstName;
                // firstname,lastname,[PhoneNumbers], [Vin numbers]
                string returnvalue = "";
                returnvalue += Customer.FirstName + " " + Customer.LastName + " ";
                foreach(var num in Customer.PhoneNumbers){
                    //Console.WriteLine("Phone Number: " + num.PhoneNumber1);
                    returnvalue += num.PhoneNumber1 + " ";
                }
                foreach(var vin in Customer.Owns){
                    //Console.WriteLine("VIN: " + vin.Automobile.Vin);
                    returnvalue += vin.Automobile.Vin + " "; 
                }
                //Console.WriteLine(returnvalue);
                return returnvalue;
            }
        }

        public virtual Automobile Automobile { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Labor> Labors { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}
