using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Resources;

public class MessageResource
{
    public int Id { get; set; }
    
    public UserResource User { get; set; }
    
    public UserResource UserDestiny { get; set; }
    public string Content { get; set; }
}