using SocialMed.API.Notifications.Domain.Models;
using SocialMed.API.Notifications.Domain.Repositories;
using SocialMed.API.Notifications.Domain.Services;
using SocialMed.API.Notifications.Domain.Services.Communication;
using SocialMed.API.SocialMedCenter.Domain.Repositories;

namespace SocialMed.API.Notifications.Services;

public class NotificationService: INotificationService
{
    private readonly INotificationRepository _notificationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public NotificationService(INotificationRepository notificationRepository, IUnitOfWork unitOfWork)
    {
        _notificationRepository = notificationRepository;
        _unitOfWork = unitOfWork;
    }


    public async Task<IEnumerable<Notification>> ListAsync()
    {
        return await _notificationRepository.ListAsync();
    }

    public async Task<NotificationResponse> SaveAsync(Notification notification)
    {
        var existingNotificationWithTitleAndUser =
            await _notificationRepository.FindByTitleAndUserId(notification.Title, notification.UserId);
        if (existingNotificationWithTitleAndUser != null)
            return new NotificationResponse($"Notification {notification.Title} from user {notification.UserId} already exists.");
        try
        {
            await _notificationRepository.AddAsync(notification);
            await _unitOfWork.CompleteAsync();
            return new NotificationResponse(notification);
        }
        catch (Exception e)
        {
            return new NotificationResponse($"An error occurred while saving notification: {e.Message}");
        }
    }
    
    public async Task<NotificationResponse> DeleteAsync(int id)
    {
        var existingNotification = await _notificationRepository.FindByIdAsync(id);
        if (existingNotification == null)
            return new NotificationResponse("Notification not found.");
        try
        {
            _notificationRepository.Remove(existingNotification);
            await _unitOfWork.CompleteAsync();
            return new NotificationResponse(existingNotification);
        }
        catch (Exception e)
        {
            return new NotificationResponse($"An error ocurred while deleting notification: {e.Message}");
        }
    }
}