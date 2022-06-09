using SocialMed.API.Security.Domain.Models;
using SocialMed.API.Security.Domain.Services.Communication;

namespace SocialMed.API.Security.Domain.Services;

public interface IUserService
{
    Task<IEnumerable<User>> ListAsync();
    Task<UserResponse> SaveAsync(User user);
    Task<UserResponse> UpdateAsync(int id, User user);
    Task<UserResponse> DeleteAsync(int id);
}