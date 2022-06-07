using SocialMed.API.Shared.Domain.Services.Comunication;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

public class RatingResponse : BaseResponse<Rating>
{
    public RatingResponse(string message) : base(message)
    {
    }

    public RatingResponse(Rating resource) : base(resource)
    {
    } 
}