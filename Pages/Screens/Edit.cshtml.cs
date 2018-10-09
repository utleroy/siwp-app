using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using siwp_app.Models;

namespace siwp_app.Pages.Screens
{
    public class EditModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public EditModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Screen Screens { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Screens = await _context.Screens.SingleOrDefaultAsync(m => m.ID == id);

            if (Screens == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Screens).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
