namespace SocialMed.API.SocialMedCenter.Domain.Models;

public class Chat
{ 
    public int Id { get; set; }
    
    //relationsships
    public int UserId { get; set; }
    public User User { get; set; }
    public int UserDestinyId { get; set; }
    public User UserDestiny { get; set; }
    public IList<Message> MyMessages { get; set; } = new List<Message>();
    //public IList<Message> OtherMessages { get; set; } = new List<Message>();
}