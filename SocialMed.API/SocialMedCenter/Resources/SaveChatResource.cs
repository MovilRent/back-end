using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.SocialMedCenter.Resources;

public class SaveChatResource
{
    [Required]
    public int User1Id { get; set; }
    [Required]
    public int User2Id { get; set; }
    
}