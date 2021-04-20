using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WorkOrderManager.Models;

namespace WorkOrderManager.Pages.WorkOrders
{
    public class CreateModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public CreateModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AutomobileId"] = new SelectList(_context.Automobiles, "AutomobileId", "Make");
        ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FirstName");
            return Page();
        }

        [BindProperty]
        public WorkOrder WorkOrder { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WorkOrders.Add(WorkOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
