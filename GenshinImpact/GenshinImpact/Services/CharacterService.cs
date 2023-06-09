using GenshinImpact.Data;
using GenshinImpact.Models;

namespace GenshinImpact.Services
{
    public class CharacterService
    {
        private readonly CharacterContext _context = default!;
        public CharacterService(CharacterContext context) 
        {
            _context = context;
        }
        public IList<Character> GetCharacters()
        {
            if(_context.Characters != null)
            {
                return _context.Characters.ToList();
            }
            return new List<Character>();
        }
        public void AddCharacter(Character character)
        {
            if(_context.Characters != null)
            {
                _context.Characters.Add(character);
                _context.SaveChanges();
            }
        }
        public void RemoveCharacter(int id) 
        {
            if (_context.Characters != null)
            {
                var character = _context.Characters.Find(id);
                if (character != null)
                {
                    _context.Characters.Remove(character);
                    _context.SaveChanges();
                }
            }
        }
    }
}
