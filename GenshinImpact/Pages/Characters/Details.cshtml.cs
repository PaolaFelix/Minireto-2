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
    public class DetailsModel : PageModel
    {
        private readonly GenshinImpact.Data.GenshinImpactContext _context;

        public DetailsModel(GenshinImpact.Data.GenshinImpactContext context)
        {
            _context = context;
        }

      public Character Character { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Character == null)
            {
                return NotFound();
            }

            var character = await _context.Character.FirstOrDefaultAsync(m => m.Id == id);
            if (character == null)
            {
                return NotFound();
            }
            else 
            {
                Character = character;
            }
            return Page();
        }
    }
}
