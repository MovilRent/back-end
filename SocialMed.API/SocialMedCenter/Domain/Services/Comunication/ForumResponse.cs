using SocialMed.API.Shared.Domain.Services.Comunication;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

public class ForumResponse : BaseResponse<Forum>
{
    public ForumResponse(string message) : base(message)
    {
    }

    public ForumResponse(Forum resource) : base(resource)
    {
    }
}