using SocialMed.API.Notifications.Domain.Models;
using SocialMed.API.Shared.Domain.Services.Comunication;

namespace SocialMed.API.Notifications.Domain.Services.Communication;

public class NotificationResponse: BaseResponse<Notification>
{
    public NotificationResponse(string message) : base(message)
    {
    }

    public NotificationResponse(Notification resource) : base(resource)
    {
        
    }
}