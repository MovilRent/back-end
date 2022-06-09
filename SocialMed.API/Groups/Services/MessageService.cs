using SocialMed.API.Groups.Domain.Models;
using SocialMed.API.Groups.Domain.Services;
using SocialMed.API.Groups.Domain.Services.Communication;

namespace SocialMed.API.Groups.Services;

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