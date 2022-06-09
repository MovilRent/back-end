using AutoMapper;
using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Resources;
using SocialMed.API.Notifications.Domain.Models;
using SocialMed.API.Notifications.Resources;
using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Resources;

namespace SocialMed.API.SocialMedCenter.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Chat, ChatResource>();
        CreateMap<Comment, CommentResource>();
        CreateMap<Forum, ForumResource>();
        CreateMap<Message, MessageResource>();
        CreateMap<Rating, RatingResource>();
        CreateMap<User, UserResource>();

        CreateMap<Notification, NotificationResource>();
        
    }
}