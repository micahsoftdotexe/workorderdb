using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkOrderManager.Models;

namespace WorkOrderManager.Pages_Automobiles
{
    public class EditModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public EditModel(WorkOrderManager.Models.WorkOrderContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Automobile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomobileExists(Automobile.AutomobileId))
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

        private bool AutomobileExists(int id)
        {
            return _context.Automobiles.Any(e => e.AutomobileId == id);
        }
    }
}
