using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Shared.Domain.Services.Communication;

namespace SocialMed.API.Forums.Domain.Services.Communication;

public class ForumResponse : BaseResponse<Forum>
{
    public ForumResponse(string message) : base(message)
    {
    }

    public ForumResponse(Forum resource) : base(resource)
    {
    }
}