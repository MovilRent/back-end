﻿using SocialMed.API.Forums.Domain.Services.Communication;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Services;

public interface IForumService
{
    Task<IEnumerable<Forum>> ListAsync();
    Task<ForumResponse> SaveAsync(Forum forum);
    Task<Forum> FindByIdAsync(int id);
    Task<IEnumerable<Forum>> ListByUserIdAsync(int userId);

    Task<ForumResponse> UpdateAsync(int id, Forum forum);
    Task<ForumResponse> DeleteAsync(int id);

}