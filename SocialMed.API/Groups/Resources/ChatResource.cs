using SocialMed.API.Security.Resources;

namespace SocialMed.API.Groups.Resources;

public class ChatResource
{
    public int Id { get; set; }
    
    //relationships
    public UserResource User1 { get; set; }
    public UserResource User2 { get; set; }
}