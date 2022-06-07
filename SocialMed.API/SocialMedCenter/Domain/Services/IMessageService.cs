using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

namespace SocialMed.API.SocialMedCenter.Domain.Services;

public interface IMessageService
{
    Task<IEnumerable<Message>> ListAsync();
    Task<MessageResponse> SaveAsync(Message message);
    Task<MessageResponse> UpdateAsync(int id, Message message);
    Task<MessageResponse> DeleteAsync(int id);

}