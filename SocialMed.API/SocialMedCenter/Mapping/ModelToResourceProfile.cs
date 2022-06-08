using AutoMapper;
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
        CreateMap<Report, ReportResource>();

    }
}