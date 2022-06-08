using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Services;
using SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

namespace SocialMed.API.SocialMedCenter.Services;

public class MessageService: IMessageService
{
    public Task<IEnumerable<Message>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MessageResponse> SaveAsync(Message message)
    {
        throw new NotImplementedException();
    }

    public Task<MessageResponse> UpdateAsync(int id, Message message)
    {
        throw new NotImplementedException();
    }

    public Task<MessageResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}