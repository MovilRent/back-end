using SocialMed.API.SocialMedCenter.Persistence.Context;

namespace SocialMed.API.SocialMedCenter.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}