using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

namespace SocialMed.API.SocialMedCenter.Domain.Services;

public interface IRatingService
{
    Task<IEnumerable<Rating>> ListAsync();
    Task<RatingResponse> SaveAsync(Rating rating);
    Task<RatingResponse> UpdateAsync(int id, Rating rating);
    Task<RatingResponse> DeleteAsync(int id);

}