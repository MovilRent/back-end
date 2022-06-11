using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.SocialMedCenter.Resources;

public class SaveReportResource
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