using SocialMed.API.Notifications.Domain.Models;

namespace SocialMed.API.Notifications.Domain.Repositories;

public interface INotificationRepository
{
    Task<IEnumerable<Notification>> ListAsync();
    Task AddAsync(Notification notification);
    Task<Notification> FindByIdAsync(int id);
    void Update(Notification notification);
    void Remove(Notification notification);
}