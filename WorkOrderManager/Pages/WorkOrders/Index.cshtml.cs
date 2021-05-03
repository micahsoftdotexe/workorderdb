
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
    public class IndexModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public IndexModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }
        public IList<WorkOrder> WorkOrder { get;set; }
        [BindProperty(SupportsGet = true)]
        public string fullinfostring { get; set; } //Name search string
        public SelectList Names {get; set;}
        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(fullinfostring)){
                WorkOrder = _context.WorkOrders
                .Include(w => w.Customer)
                .ThenInclude(w => w.PhoneNumbers)
                .Include(w => w.Customer)
                .ThenInclude(w=> w.Owns)
                .ThenInclude(w => w.Automobile)
                .AsEnumerable()
                .Where(s =>(( s.fullinfo.IndexOf(fullinfostring, StringComparison.OrdinalIgnoreCase) != -1)))
                .ToList();

            }
            else{
                WorkOrder = await _context.WorkOrders
                .Include(w => w.Automobile)
                .Include(w => w.Customer).ToListAsync();
                // .Include(w => w.Part).ToListAsync();
            }
        }
    }
}
