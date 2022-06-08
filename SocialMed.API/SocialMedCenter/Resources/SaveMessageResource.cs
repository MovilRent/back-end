using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.SocialMedCenter.Resources;

public class SaveMessageResource
{
    [Required]
    public int UserId { get; set; }
    
    [Required]
    public int UserDestinyId { get; set; }
    [Required]
    public string Content { get; set; }
}