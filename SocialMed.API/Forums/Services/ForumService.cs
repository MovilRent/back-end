using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Domain.Repositories;
using SocialMed.API.Forums.Domain.Services;
using SocialMed.API.Forums.Domain.Services.Comunication;
using SocialMed.API.SocialMedCenter.Domain.Repositories;

namespace SocialMed.API.Forums.Services;

public class ForumService: IForumService
{
    private IForumRepository _forumRepository;
    private IUnitOfWork _unitOfWork;

    public ForumService(IUnitOfWork unitOfWork, IForumRepository forumRepository)
    {
        _unitOfWork = unitOfWork;
        _forumRepository = forumRepository;
    }

    public async Task<IEnumerable<Forum>> ListAsync()
    {
        return await _forumRepository.ListAsync();
    }

    public async Task<ForumResponse> SaveAsync(Forum forum)
    {
        var existingForumWithTitle = await _forumRepository.FindByTitleAsync(forum.Title);
        if (existingForumWithTitle != null)
            return new ForumResponse($"Forum with title {forum.Title} already exists.");
            
        try
        {
            await _forumRepository.AddAsync(forum);
            await _unitOfWork.CompleteAsync();
            return new ForumResponse(forum);
        }
        catch (Exception e)
        {
            return new ForumResponse($"An error ocurred while saving forum: {e.Message}");
        }
    }

    public async Task<ForumResponse> UpdateAsync(int id, Forum forum)
    {
        var existingForum = await _forumRepository.FindByIdAsync(id);
        if (existingForum == null)
            return new ForumResponse("Forum not found.");
        
        var existingForumWithTitle = await _forumRepository.FindByTitleAsync(forum.Title);
        if (existingForumWithTitle != null)
            return new ForumResponse($"Forum with title {forum.Title} already exists.");

        existingForum.Title = forum.Title;
        existingForum.Content = forum.Content;
        
        try
        {
            _forumRepository.Update(existingForum);
            await _unitOfWork.CompleteAsync();
            return new ForumResponse(existingForum);
        }
        catch (Exception e)
        {
            return new ForumResponse($"An error occurred while updating forum: {e.Message}");
        }
        
    }

    public async Task<ForumResponse> DeleteAsync(int id)
    {
        var existingForum = await _forumRepository.FindByIdAsync(id);
        if (existingForum == null)
            return new ForumResponse("Forum not found.");

        try
        {
            _forumRepository.Remove(existingForum);
            await _unitOfWork.CompleteAsync();
            return new ForumResponse(existingForum);
        }
        catch (Exception e)
        {
            return new ForumResponse($"An error occurred while deleting the forum: {e.Message}");
        }
        
    }
}