using System.ComponentModel.DataAnnotations;

namespace SocialMed.API.Notifications.Resources;

public class SaveNotificationResource
{
    [Required]
    [MaxLength(30)]
    public string Title { get; set; }
    
    [Required]
    public int UserId { get; set; }
}