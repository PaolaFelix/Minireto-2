using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenshinImpact.Models;
using GenshinImpact.Services;

namespace GenshinImpact.Pages
{
    public class CharacterListModel : PageModel
    {
        private readonly CharacterService _service;
        public IList<Character> CharacterList { get; set; } = default!;
        public CharacterListModel(CharacterService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            CharacterList=_service.GetCharacters();
        }
    }
}
