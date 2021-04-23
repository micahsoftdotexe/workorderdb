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
    public class DeleteModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public DeleteModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Automobile Automobile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Automobile = await _context.Automobiles.FirstOrDefaultAsync(m => m.AutomobileId == id);

            if (Automobile == null)
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

            Automobile = await _context.Automobiles.FindAsync(id);

            if (Automobile != null)
            {
                _context.Automobiles.Remove(Automobile);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
