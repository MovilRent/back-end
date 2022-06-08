using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

namespace SocialMed.API.SocialMedCenter.Domain.Services;

public interface IReportService
{
    Task<IEnumerable<Report>> ListAsync();
    Task<IEnumerable<Report>> ListByUserIdAsync(int userId);
    Task<Report> GetByIdAsync(int id);


    Task<ReportResponse> SaveAsync(Report report);
    Task<ReportResponse> UpdateAsync(int id, Report report);
    Task<ReportResponse> DeleteAsync(int id);
}