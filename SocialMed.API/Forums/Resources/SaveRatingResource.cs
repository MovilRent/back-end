using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.Forums.Resources;

public class SaveRatingResource
{
    [Required]
    public int Rate { get; set; }
    //relationsship
    [Required]
    public string ForumId { get; set; }
}