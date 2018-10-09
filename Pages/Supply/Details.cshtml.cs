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
    public class DetailsModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public DetailsModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        public Supplies Supply { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supply = await _context.Supply.SingleOrDefaultAsync(m => m.ID == id);

            if (Supply == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
