using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

namespace SocialMed.API.SocialMedCenter.Domain.Services;

public interface IChatService
{
    Task<IEnumerable<Chat>> ListAsync();
    Task<IEnumerable<Chat>> ListByUserIdAsync(int userId);
    Task<Chat> GetByIdAsync(int id);

    Task<ChatResponse> SaveAsync(Chat chat);
    Task<ChatResponse> UpdateAsync(int id, Chat chat);
    Task<ChatResponse> DeleteAsync(int id);
    
}