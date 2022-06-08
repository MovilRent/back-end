using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.Forums.Resources;

public class SaveForumResource
{
    [Required]
    [MaxLength(50)]
    public string Title { get; set; }
    
    [Required]
    public string Content { get; set; }
    [Required]
    public DateOnly Date { get; set; }
    
    //relationsship
    
    [Required]
    public string UserId { get; set; }

}