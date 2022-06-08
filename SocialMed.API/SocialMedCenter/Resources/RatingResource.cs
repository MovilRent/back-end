using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Resources;

public class RatingResource
{
    public int Id { get; set; }
    public int Rate { get; set; }
    //relationsship
    public ForumResource Forum { get; set; }

}