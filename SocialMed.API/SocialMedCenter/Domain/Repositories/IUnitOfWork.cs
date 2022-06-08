namespace SocialMed.API.SocialMedCenter.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}