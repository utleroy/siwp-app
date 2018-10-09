using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using siwp_app.Models;

namespace siwp_app.Pages.Screens
{
    public class IndexModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public IndexModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        public IList<Screen> Screens { get;set; }

        public async Task OnGetAsync(string searchString)
{
    var screens = from m in _context.Screens
                 select m;

    if (!String.IsNullOrEmpty(searchString))
    {
        screens = screens.Where(
            s => s.ScreenName.Contains(searchString) || s.ScreenLocation.Contains(searchString));
    }

    Screens = await screens.ToListAsync();
}
    }
}
