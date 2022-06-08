using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Repositories;

public interface IRatingRepository
{
    Task<IEnumerable<Rating>> ListAsync();
    Task AddAsync(Rating rating);
    Task<Rating> FindByIdAsync(int id);
    Task<IEnumerable<Rating>> ListByForumIdAsync(int id);
    void Update(Rating rating);
    void Remove(Rating rating);
}