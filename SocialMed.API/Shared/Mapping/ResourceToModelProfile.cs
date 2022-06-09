using AutoMapper;
using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Resources;
using SocialMed.API.Groups.Domain.Models;
using SocialMed.API.Groups.Resources;
using SocialMed.API.Medical_Interconsultation.Domain.Models;
using SocialMed.API.Medical_Interconsultation.Resources;
using SocialMed.API.Security.Domain.Models;
using SocialMed.API.Security.Resources;

namespace SocialMed.API.Shared.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<ChatResource, Chat>();
        CreateMap<CommentResource, Comment>();
        CreateMap<MessageResource, Message>();
        CreateMap<RatingResource, Rating>();
        CreateMap<UserResource, User>();

        CreateMap<SaveForumResource, Forum>();
        CreateMap<SaveNotificationResource, Notification>();
    }
    
}