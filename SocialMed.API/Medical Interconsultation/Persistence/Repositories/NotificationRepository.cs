using Microsoft.EntityFrameworkCore;
using SocialMed.API.Medical_Interconsultation.Domain.Models;
using SocialMed.API.Medical_Interconsultation.Domain.Repositories;
using SocialMed.API.Shared.Persistence.Context;
using SocialMed.API.Shared.Persistence.Repositories;

namespace SocialMed.API.Medical_Interconsultation.Persistence.Repositories;

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
        return await _context.Notifications.FindAsync(id);
    }

    public async Task<Notification> FindByTitleAndUserId(string title, int userId)
    {
        return await _context.Notifications
            .FirstOrDefaultAsync(p => p.Title.ToLower() == title.ToLower() && p.UserId == userId);
    }

    public void Remove(Notification notification)
    {
        _context.Notifications.Remove(notification);
    }
}