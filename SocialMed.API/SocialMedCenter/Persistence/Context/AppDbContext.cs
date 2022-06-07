using Microsoft.EntityFrameworkCore;
using SocialMed.API.Shared.Extensions;
using SocialMed.API.SocialMedCenter.Domain.Models;

namespace SocialMed.API.SocialMedCenter.Persistence.Context;

public class AppDbContext : DbContext
{
    public DbSet<Chat> Chats { get; set; }  // review logical
    public DbSet<Message> Messages { get; set; }
    
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Forum> Forums { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().ToTable("Users");
        builder.Entity<User>().HasKey(p => p.Id);
        builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(p => p.Name).IsRequired().HasMaxLength(50);
        builder.Entity<User>().Property(p => p.LastName).IsRequired().HasMaxLength(50);
        builder.Entity<User>().Property(p => p.Age).IsRequired();
        builder.Entity<User>().Property(p => p.Image).IsRequired();
        builder.Entity<User>().Property(p => p.Email).IsRequired().HasMaxLength(200);
        builder.Entity<User>().Property(p => p.Specialist).IsRequired().HasMaxLength(70);
        builder.Entity<User>().Property(p => p.Recommendation).IsRequired();
        builder.Entity<User>().Property(p => p.WorkPlace).IsRequired();
        builder.Entity<User>().Property(p => p.Password).IsRequired().HasMaxLength(80);
        builder.Entity<User>().Property(p => p.Biography).IsRequired();
        
        // Relationships
        builder.Entity<User>()
            .HasMany(p => p.Forums)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
        
        builder.Entity<User>()
            .HasMany(p => p.Chats)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
        
        builder.Entity<User>()
            .HasMany(p => p.Comments)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);
        
        
        ///////////////////////////////////////////
        builder.Entity<Comment>().ToTable("Comments");
        builder.Entity<Comment>().HasKey(p => p.Id);
        builder.Entity<Comment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Comment>().Property(p => p.Date).IsRequired();
        builder.Entity<Comment>().Property(p => p.Content).HasMaxLength(500);
        ///////////////////////////////////////////
        builder.Entity<Forum>().ToTable("Forums");
        builder.Entity<Forum>().HasKey(p => p.Id);
        builder.Entity<Forum>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Forum>().Property(p => p.Date).IsRequired();
        builder.Entity<Forum>().Property(p => p.Content).HasMaxLength(500);
        builder.Entity<Forum>().Property(p => p.Title).HasMaxLength(200);
        
        builder.Entity<Forum>()
            .HasMany(p => p.Comments)
            .WithOne(p => p.Forum)
            .HasForeignKey(p => p.ForumId);
        
        builder.Entity<Forum>()
            .HasMany(p => p.Ratings)
            .WithOne(p => p.Forum)
            .HasForeignKey(p => p.ForumId);
        
        /////////////////////////////////////////////////////
        builder.Entity<Rating>().ToTable("Ratings");
        builder.Entity<Rating>().HasKey(p => p.Id);
        builder.Entity<Rating>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

        
        // Apply Snake Case Naming Convention
        
        builder.UseSnakeCaseNamingConvention();
    }
}