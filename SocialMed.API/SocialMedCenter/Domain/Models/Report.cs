namespace SocialMed.API.SocialMedCenter.Domain.Models;

public class Report
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateOnly Date { get; set; }

    //relationsship
    public int UserId { get; set; }
    public User User { get; set; } 

}