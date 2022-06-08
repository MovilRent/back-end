using Microsoft.EntityFrameworkCore;
using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Repositories;
using SocialMed.API.SocialMedCenter.Persistence.Context;

namespace SocialMed.API.SocialMedCenter.Persistence.Repositories;

public class ReportRepository : BaseRepository, IReportRepository
{
    public ReportRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Report>> ListAsync()//**
    {
        return await _context.Reports.
            Include(p => p.User).
            Include(p => p.Title).
            ToListAsync();
    }

    public async Task AddAsync(Report report)//**
    {
        await _context.Reports.AddAsync(report);
    }

    public async Task<Report> FindByIdAsync(int id)//***
    {
        return await _context.Reports
            .Include(p => p.Title)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Report>> ListByUserIdAsync(int id)//**
    {
        return await _context.Reports
            .Where(p => p.UserId == id)
            .Include(p => p.User)
            .ToListAsync();
    }



    public void Update(Report report)//***
    {
        _context.Reports.Update(report);
    }

    public void Remove(Report report)//***
    {
        _context.Reports.Remove(report);
    }
}