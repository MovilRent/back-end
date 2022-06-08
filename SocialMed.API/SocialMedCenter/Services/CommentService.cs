﻿using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Repositories;
using SocialMed.API.SocialMedCenter.Domain.Services;
using SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

namespace SocialMed.API.SocialMedCenter.Services;

public class CommentService: ICommentService
{
    private readonly ICommentRepository _commentRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;
    private readonly IForumRepository _forumRepository;

    public CommentService(ICommentRepository commentRepository, 
        IUnitOfWork unitOfWork, IUserRepository userRepository, IForumRepository forumRepository)
    {
        _commentRepository = commentRepository;
        _forumRepository = forumRepository;
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }
    public async Task<IEnumerable<Comment>> ListAsync()
    {
        return await  _commentRepository.ListAsync();
    }

    public async Task<IEnumerable<Comment>> ListByUserIdAsync(int userId)
    {
        return await _commentRepository.ListByUserIdAsync(userId);
    }

    public async Task<IEnumerable<Comment>> ListByForumIdAsync(int forumId)
    {
        return await _commentRepository.ListByForumIdAsync(forumId);
    }

    public async Task<CommentResponse> SaveAsync(Comment comment)
    {
        // Validate user id

        var existingUser = await _userRepository.FindByIdAsync(comment.UserId);

        if (existingUser == null)
            return new CommentResponse("Invalid User");
        
        // Validate Title

        var existingForum = await _forumRepository.FindByIdAsync(comment.ForumId);

        if (existingForum == null)
            return new CommentResponse("Forum not exist.");
        try
        {
            // Add Tutorial
            await _commentRepository.AddAsync(comment);
            
            // Complete Transaction
            await _unitOfWork.CompleteAsync();
            
            // Return response
            return new CommentResponse(comment);

        }
        catch (Exception e)
        {
            // Error Handling
            return new CommentResponse($"An error occurred while saving the new comment: {e.Message}");
        }
    }

    public async Task<CommentResponse> UpdateAsync(int id, Comment commnent)
    {
        var existingComment = await _commentRepository.FindByIdAsync(id);
        
        if (existingComment == null)
            return new CommentResponse("User not found.");


        var existingForum = await _forumRepository.FindByIdAsync(commnent.ForumId);
        var existingUser = await _forumRepository.FindByIdAsync(commnent.ForumId);
        if (existingForum == null||existingUser==null)
            return new CommentResponse("Invalid Forum o User not exist");
        

        // Modify Fields
        existingComment.Content = commnent.Content;

        try
        {
            _commentRepository.Update(existingComment);
            await _unitOfWork.CompleteAsync();

            return new CommentResponse(existingComment);
            
        }
        catch (Exception e)
        {
            // Error Handling
            return new CommentResponse($"An error occurred while updating the comment: {e.Message}");
        }
    }

    public async Task<CommentResponse> DeleteAsync(int id)
    {
        var existingComment = await _commentRepository.FindByIdAsync(id);
        
        // Validate chat

        if (existingComment== null)
            return new CommentResponse("Comment not found.");
        
        try
        {
            _commentRepository.Remove(existingComment);
            await _unitOfWork.CompleteAsync();

            return new CommentResponse(existingComment);
            
        }
        catch (Exception e)
        {
            // Error Handling
            return new CommentResponse($"An error occurred while deleting the Comment: {e.Message}");
        }
    }
}