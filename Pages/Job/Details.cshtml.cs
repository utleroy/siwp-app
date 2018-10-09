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
    public class DetailsModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public DetailsModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        public Jobs Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job = await _context.Job.SingleOrDefaultAsync(m => m.ID == id);

            if (Job == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
