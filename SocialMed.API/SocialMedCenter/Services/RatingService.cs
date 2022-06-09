﻿using SocialMed.API.Forums.Domain.Models;
using SocialMed.API.Forums.Domain.Services;
using SocialMed.API.Forums.Domain.Services.Communication;
namespace SocialMed.API.SocialMedCenter.Services;

public class RatingService : IRatingService
{
    private IRatingService _ratingServiceImplementation;
    public Task<IEnumerable<Rating>> ListAsync()
    {
        return _ratingServiceImplementation.ListAsync();
    }

    public Task<RatingResponse> SaveAsync(Rating rating)
    {
        return _ratingServiceImplementation.SaveAsync(rating);
    }

    public Task<RatingResponse> UpdateAsync(int id, Rating rating)
    {
        return _ratingServiceImplementation.UpdateAsync(id, rating);
    }

    public Task<RatingResponse> DeleteAsync(int id)
    {
        return _ratingServiceImplementation.DeleteAsync(id);
    }
}