using AutoMapper;
using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Resources;
using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Resources;

namespace SocialMed.API.SocialMedCenter.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<ChatResource, Chat>();
        CreateMap<CommentResource, Comment>();
        CreateMap<ForumResource, Forum>();
        CreateMap<MessageResource, Message>();
        CreateMap<RatingResource, Rating>();
        CreateMap<UserResource, User>();
    }
    
}