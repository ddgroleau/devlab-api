using Core.Domain.Models;
using Core.Utility;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        ApplyMigrations();
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        ApplyMigrations();
    }

    private void ApplyMigrations()
    {
        // Database.EnsureDeleted();
        // Database.Migrate();
    }
    
    public DbSet<Question> Questions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Difficulty> Difficulties { get; set; }
    
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasKey(c => c.Id);
        modelBuilder.Entity<Category>().Property(c => c.DisplayText).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.CreatedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.ModifiedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.CreatedUtc).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.ModifiedUtc).IsRequired();
        modelBuilder.Entity<Category>().HasData(SeedCategories.Execute());
        
        modelBuilder.Entity<Difficulty>().HasKey(d => d.Id);
        modelBuilder.Entity<Difficulty>().Property(d => d.DisplayText).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Difficulty>().HasIndex(d => d.DisplayText).IsUnique();
        modelBuilder.Entity<Difficulty>().Property(d => d.CreatedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Difficulty>().Property(d => d.ModifiedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Difficulty>().Property(d => d.CreatedUtc).IsRequired();
        modelBuilder.Entity<Difficulty>().Property(d => d.ModifiedUtc).IsRequired();
        modelBuilder.Entity<Difficulty>().HasData(SeedDifficulties.Execute());
        
        modelBuilder.Entity<Question>().HasKey(q => q.Id);
        modelBuilder.Entity<Question>().Property(q => q.QuestionText).HasMaxLength(2000).IsRequired();
        modelBuilder.Entity<Question>().HasIndex(q => q.QuestionText).IsUnique();
        modelBuilder.Entity<Question>().Property(q => q.AnswerOptions).HasColumnType("character varying[]").IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CorrectAnswer).HasMaxLength(200).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CategoryId).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.DifficultyId).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CreatedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.ModifiedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CreatedUtc).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.ModifiedUtc).IsRequired();
        modelBuilder.Entity<Question>().HasData(SeedQuestions.Execute());
         
        modelBuilder.Entity<Tag>().HasKey(  t => t.Id);
        modelBuilder.Entity<Tag>().Property(t => t.Value).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.DisplayText).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.CreatedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.ModifiedBy).HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.CreatedUtc).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.ModifiedUtc).IsRequired();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        ConfigureOptions(options);
    }

    internal static void ConfigureOptions(DbContextOptionsBuilder options)
    {
        AppConfig.LoadEnv();
        
        var host = Environment.GetEnvironmentVariable("PG_HOST");
        var port = Environment.GetEnvironmentVariable("PG_PORT");
        var user = Environment.GetEnvironmentVariable("PG_USER");
        var password = Environment.GetEnvironmentVariable("PG_PASSWORD");
        var db = Environment.GetEnvironmentVariable("PG_DATABASE");
        
        options.UseNpgsql($"Host={host};Port={port};Username={user};Password={password};Database={db};");
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    }
}
