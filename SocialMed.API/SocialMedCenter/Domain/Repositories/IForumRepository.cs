using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Repositories;

public interface IForumRepository
{
    Task<IEnumerable<Forum>> ListAsync();
    Task AddAsync(Forum forum);
    Task<Forum> FindByIdAsync(int id);
    Task<IEnumerable<Forum>> ListByUserIdAsync(int id);

    void Update(Forum forum);
    void Remove(Forum forum);
}