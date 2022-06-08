using SocialMed.API.Shared.Domain.Services.Comunication;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

public class ChatResponse : BaseResponse<Chat>
{
    public ChatResponse(string message) : base(message)
    {
    }

    public ChatResponse(Chat resource) : base(resource)
    {
    }
}