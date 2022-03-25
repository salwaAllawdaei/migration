#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using migration.Model;

namespace migration.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly GameStoreContext _context;

        public IndexModel(GameStoreContext context)
        {
            _context = context;
        }

        public IList<Game> Games { get; set; }

        public async Task OnGetAsync()
        {
            Games = await _context.Game.ToListAsync();
        }
    }
}
