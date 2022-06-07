using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Resources;

public class CommentResource
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public string Content { get; set; }

    public UserResource User { get; set; }
    public ForumResource Forum { get; set; }
}