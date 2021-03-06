using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkOrderManager.Models;

namespace WorkOrderManager.Pages_Customers
{
    public class IndexModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public IndexModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CustomerName { get; set; }

        public string NumWorkOrders {get; set;}

        public async Task OnGetAsync()
        {

            if (!string.IsNullOrEmpty(SearchString))
            {
                Customer = _context.Customers
                .Include(w => w.WorkOrders)
                .Include(w => w.PhoneNumbers)
                .AsEnumerable()
                .Where(s => (s.FullName.IndexOf(SearchString, StringComparison.OrdinalIgnoreCase) != -1))            
                .ToList();

                // if(Customer.Count == 0){
                //     //check for phone number number
                //     Customer = _context.Customers
                //     .Include(w=>w.WorkOrders)
                //     .Include(w=>w.PhoneNumbers)
                //     .AsEnumerable()
                //     .Where(s => s.PhoneNumbers.PhoneNumber)
                //     .ToLi
                //}
            }else{
                Customer = await _context.Customers
                .Include(w => w.WorkOrders)
                .Include(w => w.PhoneNumbers)
                .ToListAsync();
            }

        }
    }
}
