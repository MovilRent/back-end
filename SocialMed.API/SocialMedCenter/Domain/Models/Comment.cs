namespace SocialMed.API.SocialMedCenter.Domain.Models;

public class Comment
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public string Content { get; set; }
    //relationsship
    public int UserId { get; set; }
    public User User { get; set; } 
    public int ForumId { get; set; }
    public Forum Forum { get; set; }
}