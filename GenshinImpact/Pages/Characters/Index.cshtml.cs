using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GenshinImpact.Data;
using GenshinImpact.Models;

namespace GenshinImpact.Pages.Characters
{
    public class IndexModel : PageModel
    {
        private readonly GenshinImpact.Data.GenshinImpactContext _context;

        public IndexModel(GenshinImpact.Data.GenshinImpactContext context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Character != null)
            {
                Character = await _context.Character.ToListAsync();
            }
        }
    }
}
