using SocialMed.API.Notifications.Domain.Models;
using SocialMed.API.Notifications.Domain.Services.Communication;

namespace SocialMed.API.Notifications.Domain.Services;

public interface INotificationService
{
    Task<IEnumerable<Notification>> ListAsync();
    Task<NotificationResponse> SaveAsync(Notification notification);
   Task<NotificationResponse> DeleteAsync(int id);
}