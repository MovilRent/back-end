using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Domain.Services.Communication;

namespace SocialMed.API.Forums.Domain.Services;

public interface IForumService
{
    Task<IEnumerable<Forum>> ListAsync();
    Task<ForumResponse> SaveAsync(Forum Forum);
    Task<ForumResponse> UpdateAsync(int id, Forum forum);
    Task<ForumResponse> DeleteAsync(int id);

}