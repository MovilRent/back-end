using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Resources;

public class ChatResource
{
    public int Id { get; set; }
    
    //relationsships
    public UserResource User1 { get; set; }
    public UserResource User2 { get; set; }
}