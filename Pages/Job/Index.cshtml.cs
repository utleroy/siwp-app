using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using siwp_app.Models;

namespace siwp_app.Pages.Job
{
    public class IndexModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public IndexModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        public IList<Jobs> Job { get;set; }

        public async Task OnGetAsync()
        {
            Job = await _context.Job.ToListAsync();
        }
    }
}
