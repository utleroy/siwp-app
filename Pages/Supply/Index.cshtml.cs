using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using siwp_app.Models;

namespace siwp_app.Pages.Supply
{
    public class IndexModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public IndexModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        public IList<Supplies> Supply { get;set; }

        public async Task OnGetAsync()
        {
            Supply = await _context.Supply.ToListAsync();
        }
    }
}
