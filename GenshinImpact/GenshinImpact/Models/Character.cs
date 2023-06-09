using System.ComponentModel.DataAnnotations;

namespace GenshinImpact.Models;

public class Character
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public string? Vision { get; set; }
    public string? Weapon { get; set; }
    public CharacterNation Nation { get; set; }
}

public enum CharacterNation { }