using SocialMed.API.Shared.Domain.Services.Comunication;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Domain.Services.Comunication;

public class ReportResponse : BaseResponse<Report>
{
    public ReportResponse(string message) : base(message)
    {
    }

    public ReportResponse(Report resource) : base(resource)
    {
    } 
}