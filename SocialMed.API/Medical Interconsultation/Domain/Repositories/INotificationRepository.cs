using SocialMed.API.Medical_Interconsultation.Domain.Models;

namespace SocialMed.API.Medical_Interconsultation.Domain.Repositories;

public interface INotificationRepository
{
    Task<IEnumerable<Notification>> ListAsync();
    Task AddAsync(Notification notification);
    Task<Notification> FindByIdAsync(int id);
    Task<Notification> FindByTitleAndUserId(string title, int userId);
    void Remove(Notification notification);
}