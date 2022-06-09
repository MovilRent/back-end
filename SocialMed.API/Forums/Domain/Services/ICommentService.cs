using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Domain.Services.Communication;

namespace SocialMed.API.Forums.Domain.Services;

public interface ICommentService
{
    Task<IEnumerable<Comment>> ListAsync();
    Task<IEnumerable<Comment>> ListByUserIdAsync(int userId);
    Task<IEnumerable<Comment>> ListByForumIdAsync(int forumId);


    Task<CommentResponse> SaveAsync(Comment comment);
    Task<CommentResponse> UpdateAsync(int id, Comment commnent);
    Task<CommentResponse> DeleteAsync(int id);
}