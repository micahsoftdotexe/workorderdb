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
        
        // public List<SelectListItem> Customers { get; set; }
        // public List<SelectListItem> Automobiles { get; set; }

        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public int CustomerId {get; set;}

        public CreateModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            // Customers = _context.Customers.Select(a => 
            //     new SelectListItem 
            //     {
            //         Value = a.CustomerId.ToString(),
            //         Text =  a.FullName
            //     }).ToList();

            // Automobiles = _context.Automobiles.Select(a => 
            //     new SelectListItem 
            //     {
            //         Value = a.AutomobileId.ToString(),
            //         Text =  a.Make
            //     }).Where().ToList();

        ViewData["AutomobileId"] = new SelectList(_context.Automobiles, "AutomobileId","Make", "Model");
       
        ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FirstName");
        // ViewData[""]
            return Page();
        }

        [BindProperty]
        public WorkOrder WorkOrder { get; set; }


        public JsonResult OnGetSubCategories()
        {
            Console.WriteLine("test");
            return new JsonResult(_context.Automobiles.Select(a => a.Make));
        }

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
