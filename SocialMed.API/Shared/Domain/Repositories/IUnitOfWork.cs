﻿namespace SocialMed.API.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}