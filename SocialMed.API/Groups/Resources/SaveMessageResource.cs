using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.Groups.Resources;

public class SaveMessageResource
{
    [Required]
    public string UserId { get; set; }
    
    [Required]
    public string UserDestinyId { get; set; }
    [Required]
    public string Content { get; set; }
}