using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkOrderManager.Models;

namespace WorkOrderManager.Pages_Customers
{
    public class DetailsModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public DetailsModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }
        public PhoneType PhoneType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*PhoneType = await _context.PhoneTypes
            .Include(x => x.PhoneType1)
            .Include(x => x.PhoneDescription)
            .ToListAsync();*/

            Customer = await _context.Customers
            .Include(m => m.PhoneNumbers)
            .Include(m => m.Owns)
            .Include(m => m.WorkOrders)
            .FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
