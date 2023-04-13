using Core.Domain.Models;
using Core.Utility;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Question> Questions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Difficulty> Difficulties { get; set; }
    
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>().ToTable("questions");
        modelBuilder.Entity<Question>().HasKey(q => q.Id);
        modelBuilder.Entity<Question>().Property(q => q.Id).HasColumnName("id");
        modelBuilder.Entity<Question>().Property(q => q.QuestionText).HasColumnName("question_text");
        modelBuilder.Entity<Question>().Property(q => q.AnswerOptions).HasColumnName("answer_options");
        modelBuilder.Entity<Question>().Property(q => q.CorrectAnswer).HasColumnName("correct_answer");
        modelBuilder.Entity<Question>().Property(q => q.CategoryId).HasColumnName("category_id");
        modelBuilder.Entity<Question>().Property(q => q.DifficultyId).HasColumnName("difficulty_id");
        modelBuilder.Entity<Question>()
            .HasMany(q => q.Tags)
            .WithMany(c => c.Questions)
            .UsingEntity<QuestionTag>().ToTable("question_tags");
    
        modelBuilder.Entity<Category>().ToTable("categories");
        modelBuilder.Entity<Category>().HasKey(c => c.Id);
        modelBuilder.Entity<Category>().Property(c => c.Id).HasColumnName("id");
        modelBuilder.Entity<Category>().Property(c => c.Value).HasColumnName("value");
        modelBuilder.Entity<Category>().Property(c => c.DisplayText).HasColumnName("display_text");
        
        modelBuilder.Entity<Difficulty>().ToTable("difficulties");
        modelBuilder.Entity<Difficulty>().HasKey(d => d.Id);
        modelBuilder.Entity<Difficulty>().Property(d => d.Id).HasColumnName("id");
        modelBuilder.Entity<Difficulty>().Property(d => d.DisplayText).HasColumnName("display_text");
        
        modelBuilder.Entity<Tag>().ToTable("tags");
        modelBuilder.Entity<Tag>().HasKey(  t => t.Id);
        modelBuilder.Entity<Tag>().Property(t => t.Id).HasColumnName("id");
        modelBuilder.Entity<Tag>().Property(t => t.Value).HasColumnName("value");
        modelBuilder.Entity<Tag>().Property(t => t.DisplayText).HasColumnName("display_text");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        AppConfig.LoadEnv();
        
        string? host = Environment.GetEnvironmentVariable("PG_HOST");
        string? port = Environment.GetEnvironmentVariable("PG_PORT");
        string? user = Environment.GetEnvironmentVariable("PG_USER");
        string? password = Environment.GetEnvironmentVariable("PG_PASSWORD");
        string? db = Environment.GetEnvironmentVariable("PG_DATABASE");
        
        options.UseNpgsql($"Host={host};Port={port};Username={user};Password={password};Database={db};");
    }
}
