namespace SocialMed.API.Notifications.Domain.Models;

public class Notification
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int UserId { get; set; }
    public string ActionsCodes { get; set; }
}