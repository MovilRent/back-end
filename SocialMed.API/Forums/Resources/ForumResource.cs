using SocialMed.API.SocialMedCenter.Resources;

namespace SocialMed.API.Forums.Resources;

public class ForumResource
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateOnly Date { get; set; }
    
    //relationsship
 
    public UserResource User { get; set; }
}