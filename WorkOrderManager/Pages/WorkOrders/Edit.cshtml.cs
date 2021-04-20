using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkOrderManager.Models;

namespace WorkOrderManager.Pages.WorkOrders
{
    public class EditModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public EditModel(WorkOrderManager.Models.WorkOrderContext context)
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
           ViewData["AutomobileId"] = new SelectList(_context.Automobiles, "AutomobileId", "Make");
           ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FirstName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(WorkOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkOrderExists(WorkOrder.WorkOrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WorkOrderExists(int id)
        {
            return _context.WorkOrders.Any(e => e.WorkOrderId == id);
        }
    }
}
