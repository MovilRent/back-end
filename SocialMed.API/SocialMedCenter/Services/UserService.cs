using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Services;
using SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

namespace SocialMed.API.SocialMedCenter.Services;

public class UserService : IUserService
{
    public Task<IEnumerable<User>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> SaveAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> UpdateAsync(int id, User user)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}