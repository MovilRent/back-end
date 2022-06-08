using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Repositories;

public interface IReportRepository
{
    Task<IEnumerable<Report>> ListAsync();
    Task AddAsync(Report report);
    Task<Report> FindByIdAsync(int id);
    Task<IEnumerable<Report>> ListByUserIdAsync(int id);

    void Update(Report report);
    void Remove(Report report);
}