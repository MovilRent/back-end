using Microsoft.EntityFrameworkCore;
using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Repositories;
using SocialMed.API.SocialMedCenter.Persistence.Context;

namespace SocialMed.API.SocialMedCenter.Persistence.Repositories;

public class RatingRepository : BaseRepository, IRatingRepository
{
    public RatingRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Rating>> ListAsync()
    {
        return await _context.Ratings.
            Include(p=>p.Forum).
            ToListAsync();
    }

    public async Task AddAsync(Rating rating)
    {
        await _context.Ratings.AddAsync(rating);
    }

    public async Task<Rating> FindByIdAsync(int id)
    {
        return await _context.Ratings
            .Include(p => p.Forum)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Rating>> ListByForumIdAsync(int id)
    {
        return await _context.Ratings
            .Where(p => p.ForumId == id)
            .Include(p => p.Forum)
            .ToListAsync();
    }

    public void Update(Rating rating)
    {
        _context.Ratings.Update(rating);
    }

    public void Remove(Rating rating)
    {
        _context.Ratings.Remove(rating);
    }
}