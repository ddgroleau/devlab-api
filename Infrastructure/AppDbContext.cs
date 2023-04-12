using Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Question>? Questions { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Difficulty>? Difficulties { get; set; }
    public DbSet<Tag>? Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>().HasKey(q => q.Id);
        modelBuilder.Entity<Category>().HasKey(c => c.Id);
        modelBuilder.Entity<Difficulty>().HasKey(c => c.Id);
        modelBuilder.Entity<Tag>().HasKey(c => c.Id);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string? host = Environment.GetEnvironmentVariable("PG_HOST");
        string? port = Environment.GetEnvironmentVariable("PG_PORT");
        string? user = Environment.GetEnvironmentVariable("PG_USER");
        string? password = Environment.GetEnvironmentVariable("PG_PASSWORD");
        string? db = Environment.GetEnvironmentVariable("PG_DATABASE");
        
        options.UseNpgsql($"Host={host};Port={port};Username={user};Password={password};Database={db};");
    }
}