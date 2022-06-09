using SocialMed.API.Security.Domain.Models;
using SocialMed.API.Security.Domain.Services.Communication;

namespace SocialMed.API.SocialMedCenter.Domain.Services;

public interface IUserService
{
    Task<IEnumerable<User>> ListAsync();
    Task<User> FindByIdAsync(int id);
    Task<User> FindByEmailAsync(string email);
    Task<UserResponse> SaveAsync(User user);
    Task<UserResponse> UpdateAsync(int id, User user);
    Task<UserResponse> DeleteAsync(int id);
}