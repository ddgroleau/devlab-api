using Core.Domain.Models;
using Core.Utility;
using Infrastructure.Data;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        Database.Migrate();

        SeedData.CreatePlPgSqlProcedure_InsertQuestion(Database);
        SeedData.SeedQuestions(Database);
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }
    
    public DbSet<Question> Questions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Difficulty> Difficulties { get; set; }
    
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>().ToTable("questions");
        modelBuilder.Entity<Question>().HasKey(q => q.Id);
        modelBuilder.Entity<Question>().Property(q => q.Id).HasColumnName("id");
        modelBuilder.Entity<Question>().Property(q => q.QuestionText).HasColumnName("question_text").HasMaxLength(2000).IsRequired();
        modelBuilder.Entity<Question>().HasIndex(q => q.QuestionText).IsUnique();
        modelBuilder.Entity<Question>().Property(q => q.AnswerOptions).HasColumnName("answer_options").HasColumnType("character varying[]").IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CorrectAnswer).HasColumnName("correct_answer").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CategoryId).HasColumnName("category_id").IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.DifficultyId).HasColumnName("difficulty_id").IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CreatedBy).HasColumnName("created_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.ModifiedBy).HasColumnName("modified_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.CreatedUtc).HasColumnName("created_utc").IsRequired();
        modelBuilder.Entity<Question>().Property(q => q.ModifiedUtc).HasColumnName("modified_utc").IsRequired();
        modelBuilder.Entity<Question>()
            .HasMany(q => q.Tags)
            .WithMany(c => c.Questions)
            .UsingEntity<QuestionTag>().ToTable("question_tags").HasKey(qt=>qt.Id).HasAnnotation("ColumnName","id");
    
        modelBuilder.Entity<Category>().ToTable("categories");
        modelBuilder.Entity<Category>().HasKey(c => c.Id);
        modelBuilder.Entity<Category>().Property(c => c.Id).HasColumnName("id");
        modelBuilder.Entity<Category>().Property(c => c.Value).HasColumnName("value").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Category>().HasIndex(c => c.Value).IsUnique();
        modelBuilder.Entity<Category>().Property(c => c.DisplayText).HasColumnName("display_text").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.CreatedBy).HasColumnName("created_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.ModifiedBy).HasColumnName("modified_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.CreatedUtc).HasColumnName("created_utc").IsRequired();
        modelBuilder.Entity<Category>().Property(c => c.ModifiedUtc).HasColumnName("modified_utc").IsRequired();
        modelBuilder.Entity<Category>().HasData(SeedData.SeedCategories());
        
        modelBuilder.Entity<Difficulty>().ToTable("difficulties");
        modelBuilder.Entity<Difficulty>().HasKey(d => d.Id);
        modelBuilder.Entity<Difficulty>().Property(d => d.Id).HasColumnName("id");
        modelBuilder.Entity<Difficulty>().Property(d => d.DisplayText).HasColumnName("display_text").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Difficulty>().HasIndex(d => d.DisplayText).IsUnique();
        modelBuilder.Entity<Difficulty>().Property(d => d.CreatedBy).HasColumnName("created_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Difficulty>().Property(d => d.ModifiedBy).HasColumnName("modified_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Difficulty>().Property(d => d.CreatedUtc).HasColumnName("created_utc").IsRequired();
        modelBuilder.Entity<Difficulty>().Property(d => d.ModifiedUtc).HasColumnName("modified_utc").IsRequired();
        modelBuilder.Entity<Difficulty>().HasData(SeedData.SeedDifficulties());
        
        modelBuilder.Entity<Tag>().ToTable("tags");
        modelBuilder.Entity<Tag>().HasKey(  t => t.Id);
        modelBuilder.Entity<Tag>().Property(t => t.Id).HasColumnName("id");
        modelBuilder.Entity<Tag>().Property(t => t.Value).HasColumnName("value").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.DisplayText).HasColumnName("display_text").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.CreatedBy).HasColumnName("created_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.ModifiedBy).HasColumnName("modified_by").HasMaxLength(90).IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.CreatedUtc).HasColumnName("created_utc").IsRequired();
        modelBuilder.Entity<Tag>().Property(t => t.ModifiedUtc).HasColumnName("modified_utc").IsRequired();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        ConfigureOptions(options);
    }

    internal static void ConfigureOptions(DbContextOptionsBuilder options)
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
