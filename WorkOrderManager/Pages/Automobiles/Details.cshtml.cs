using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkOrderManager.Models;

namespace WorkOrderManager.Pages_Automobiles
{
    public class DetailsModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public DetailsModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        public Automobile Automobile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Automobile = await _context.Automobiles
            .Include(m => m.Owns).ThenInclude(y => y.Customer)
            .Include(m => m.WorkOrders)
            .FirstOrDefaultAsync(m => m.AutomobileId == id);

            if (Automobile == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
