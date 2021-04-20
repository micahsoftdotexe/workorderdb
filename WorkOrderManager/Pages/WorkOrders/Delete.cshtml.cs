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
    public class DeleteModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public DeleteModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WorkOrder = await _context.WorkOrders.FindAsync(id);

            if (WorkOrder != null)
            {
                _context.WorkOrders.Remove(WorkOrder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
