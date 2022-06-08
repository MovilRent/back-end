using AutoMapper;
using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Resources;

namespace SocialMed.API.SocialMedCenter.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveChatResource, Chat>();
        CreateMap<SaveCommentResource, Comment>();
        CreateMap<SaveForumResource, Forum>();
        CreateMap<SaveMessageResource, Message>();
        CreateMap<SaveRatingResource, Rating>();
        CreateMap<SaveUserResource, User>();
    }
    
}