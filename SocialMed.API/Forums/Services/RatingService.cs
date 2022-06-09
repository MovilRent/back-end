using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Domain.Services;
using SocialMed.API.Forums.Domain.Services.Communication;

namespace SocialMed.API.Forums.Services;

public class RatingService : IRatingService
{
    private IRatingService _ratingService;
    public Task<IEnumerable<Rating>> ListAsync()
    {
        return _ratingService.ListAsync();
    }

    public Task<RatingResponse> SaveAsync(Rating rating)
    {
        return _ratingService.SaveAsync(rating);
    }

    public Task<RatingResponse> UpdateAsync(int id, Rating rating)
    {
        return _ratingService.UpdateAsync(id, rating);
    }

    public Task<RatingResponse> DeleteAsync(int id)
    {
        return _ratingService.DeleteAsync(id);
    }
}