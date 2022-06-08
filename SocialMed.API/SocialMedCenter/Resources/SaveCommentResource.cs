using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.SocialMedCenter.Resources;

public class SaveCommentResource
{
    [Required]
    public DateOnly Date { get; set; }
    
    [Required]
    public string Content { get; set; }
    
    [Required]
    public int UserId { get; set; }
    [Required]
    public int ForumId { get; set; }
}