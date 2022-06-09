using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SocialMed.API.Forums.Domain.Repositories;
using SocialMed.API.Forums.Domain.Services;
using SocialMed.API.Forums.Persistence.Repositories;
using SocialMed.API.Forums.Services;
using SocialMed.API.Groups.Domain.Repositories;
using SocialMed.API.Groups.Domain.Services;
using SocialMed.API.Groups.Persistence.Repositories;
using SocialMed.API.Groups.Services;
using SocialMed.API.Security.Domain.Repositories;
using SocialMed.API.Security.Domain.Services;
using SocialMed.API.Security.Persistence.Repositories;
using SocialMed.API.Security.Services;
using SocialMed.API.Shared.Domain.Repositories;
using SocialMed.API.Shared.Mapping;
using SocialMed.API.Shared.Persistence.Context;
using SocialMed.API.Shared.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());


builder.Services.AddRouting(options => options.LowercaseUrls = true);



//////////

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IForumRepository,ForumRepository>();
builder.Services.AddScoped<IForumService, ForumService>();

builder.Services.AddScoped<ICommentRepository,CommentRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();

builder.Services.AddScoped<IChatRepository,ChatRepository>();
builder.Services.AddScoped<IChatService, ChatService>();

builder.Services.AddScoped<IMessageRepository,MessageRepository>();
builder.Services.AddScoped<IMessageService, MessageService>();

builder.Services.AddScoped<IRatingRepository,RatingRepository>();
builder.Services.AddScoped<IRatingService, RatingService>();



builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();



// AutoMapper Configuration

builder.Services.AddAutoMapper(
    typeof(ModelToResourceProfile), 
    typeof(ResourceToModelProfile));




var app = builder.Build();






// Validation for ensuring Database Objects are created


using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<AppDbContext>())
{
    context.Database.EnsureCreated();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();