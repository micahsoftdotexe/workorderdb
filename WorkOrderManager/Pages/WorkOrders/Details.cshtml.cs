using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkOrderManager.Models;

namespace WorkOrderManager.Pages.WorkOrders
{
    public class DetailsModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public DetailsModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        public WorkOrder WorkOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WorkOrder = await _context.WorkOrders
                .Include(w => w.Automobile)
                .Include(w => w.Customer).FirstOrDefaultAsync(m => m.WorkOrderId == id);

            if (WorkOrder == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
