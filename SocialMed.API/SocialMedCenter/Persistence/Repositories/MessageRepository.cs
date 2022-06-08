﻿using Microsoft.EntityFrameworkCore;
using SocialMed.API.SocialMedCenter.Domain.Models;
using SocialMed.API.SocialMedCenter.Domain.Repositories;
using SocialMed.API.SocialMedCenter.Persistence.Context;

namespace SocialMed.API.SocialMedCenter.Persistence.Repositories;

public class MessageRepository :BaseRepository, IMessageRepository
{
    public MessageRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Message>> ListAsync()//***
    {
        return await _context.Messages.
            Include(p=>p.Chat).
            ToListAsync();
    }

    public async Task AddAsync(Message message)//***
    {
        await _context.Messages.AddAsync(message);
    }

    public async Task<Message> FindByIdAsync(int id)
    {
        return await _context.Messages
            .Include(p => p.Chat)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Message>> ListByChatIdAsync(int id)
    {
        return await _context.Messages
            .Where(p => p.ChatId == id)
            .Include(p => p.Chat)
            .ToListAsync();
    }

    public Task<IEnumerable<Message>> ListByChatIdAndUserIdAsync(int id)// aun no clarro, proceso, debido a la utilidad de acceso de datos
    {
        throw new NotImplementedException();
    }

    public void Update(Message message)
    {
        _context.Messages.Update(message);
    }

    public void Remove(Message message)
    {
        _context.Messages.Remove(message);
    }
}