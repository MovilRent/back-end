using Microsoft.EntityFrameworkCore;
using SocialMed.API.SocialMedCenter.Domain.Repositories;
using SocialMed.API.SocialMedCenter.Domain.Services;
using SocialMed.API.SocialMedCenter.Mapping;
using SocialMed.API.SocialMedCenter.Persistence.Context;
using SocialMed.API.SocialMedCenter.Persistence.Repositories;
using SocialMed.API.SocialMedCenter.Services;

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