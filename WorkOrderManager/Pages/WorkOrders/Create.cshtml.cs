using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WorkOrderManager.Models;
using Microsoft.EntityFrameworkCore;

namespace WorkOrderManager.Pages.WorkOrders
{
    public class CreateModel : PageModel
    {
        
        // public List<SelectListItem> Customers { get; set; }
        // public List<SelectListItem> Automobiles { get; set; }

        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        [BindProperty(SupportsGet = true)]
        public int CustomerId {get; set;}

        public CreateModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        class autoDisplay
        {
            public int id {get; set;}
            public string name {get; set;}
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


       
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FirstName");
            //ViewData["AutomobileId"] = new SelectList(_context.Automobiles, "AutomobileId","Description");
            
            return Page();
        }

        [BindProperty]
        public WorkOrder WorkOrder { get; set; }

        //public IList<Automobile> Automobile { get;set; }

        public IList<Automobile> Automobiles { get; set; }
        public JsonResult OnGetSubCategories()
        {
            Console.WriteLine("getting automobiles: " + CustomerId);

            
            //var vehicles = new List<
            //foreach
            //Automobiles = 

             var Customer = _context.Customers.Where(x => x.CustomerId == CustomerId).Include(x => x.Owns).ThenInclude(x => x.Automobile).FirstOrDefault();
             var OwnsList = Customer.Owns.ToList();
             List<Automobile> AutoList = new List<Automobile>();
             foreach(var o in OwnsList){
                 AutoList.Add(o.Automobile);
             }
             Automobiles = AutoList;
             //_context.Automobiles.Select(a => a.Description).ToList();
//                 .Where(s => s.Owns.CustomerId.IndexOf(SearchString, StringComparison.OrdinalIgnoreCase) != -1)


            List<autoDisplay> autos = new List<autoDisplay>();
            foreach (var auto in Automobiles){

                autoDisplay auto1 = new autoDisplay(){
                    id = auto.AutomobileId,
                    name = auto.Description
                };
                autos.Add(auto1);
                
            }
             

            return new JsonResult(autos);
            //return new JsonResult(Automobiles.Select(a => a.Description));
            //return new JsonResult(_context.Automobiles.Select(a => a.Description));
                // .Where(a => a.AutomobileID == 1));
                    
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
