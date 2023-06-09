using System.ComponentModel.DataAnnotations;
namespace GenshinImpact.Models;

public class Character
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Vision { get; set; }
    public string? Weapon { get; set; } 
    public string? Nation { get; set; }
}