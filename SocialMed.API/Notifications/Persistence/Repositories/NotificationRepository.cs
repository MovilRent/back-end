using Microsoft.EntityFrameworkCore;
using SocialMed.API.Notifications.Domain.Models;
using SocialMed.API.Notifications.Domain.Repositories;
using SocialMed.API.SocialMedCenter.Persistence.Context;
using SocialMed.API.SocialMedCenter.Persistence.Repositories;

namespace SocialMed.API.Notifications.Persistence.Repositories;

public class NotificationRepository: BaseRepository, INotificationRepository
{
    public NotificationRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Notification>> ListAsync()
    {
        return await _context.Notifications.ToListAsync();
    }

    public async Task AddAsync(Notification notification)
    {
        await _context.AddAsync(notification);
    }

    public async Task<Notification> FindByIdAsync(int id)
    {
        return await _context.Notifications
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public void Update(Notification notification)
    {
        _context.Notifications.Update(notification);
    }

    public void Remove(Notification notification)
    {
        _context.Notifications.Remove(notification);
    }
}