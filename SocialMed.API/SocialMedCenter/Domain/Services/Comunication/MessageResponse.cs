using SocialMed.API.Shared.Domain.Services.Comunication;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

public class MessageResponse : BaseResponse<Message>
{
    public MessageResponse(string message) : base(message)
    {
    }

    public MessageResponse(Message resource) : base(resource)
    {
    }
}