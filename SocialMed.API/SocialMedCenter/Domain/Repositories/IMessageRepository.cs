using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Repositories;

public interface IMessageRepository
{
    Task<IEnumerable<Message>> ListAsync();
    Task AddAsync(Message message);
    Task<Message> FindByIdAsync(int id);
    Task<IEnumerable<Message>> ListByChatIdAsync(int id);
    Task<IEnumerable<Message>> ListByChatIdAndUserIdAsync(int id);

    void Update(Message message);
    void Remove(Message message);
}