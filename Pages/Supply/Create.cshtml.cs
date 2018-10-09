using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using siwp_app.Models;

namespace siwp_app.Pages.Supply
{
    public class CreateModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public CreateModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Supplies Supply { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Supply.Add(Supply);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}