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
    public class IndexModel : PageModel
    {
        private readonly WorkOrderManager.Models.WorkOrderContext _context;

        public IndexModel(WorkOrderManager.Models.WorkOrderContext context)
        {
            _context = context;
        }

        public IList<WorkOrder> WorkOrder { get;set; }

        public async Task OnGetAsync()
        {
            WorkOrder = await _context.WorkOrders
                .Include(w => w.Automobile)
                .Include(w => w.Customer).ToListAsync();
        }
    }
}
