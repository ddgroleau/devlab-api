using Core.Domain.Models;
using Core.Enums;

namespace Infrastructure.Data;

public static class SeedCategories
{
    public static IEnumerable<Category> Execute()
    {
        return new Category[]
        {
            new Category { Id = (int)Categories.COMPUTER_SCIENCE, DisplayText = "computer science" },
            new Category { Id = (int)Categories.BACKEND, DisplayText = "backend" },
            new Category { Id = (int)Categories.FRONTEND, DisplayText = "frontend" },
            new Category { Id = (int)Categories.DATABASES, DisplayText = "databases" },
            new Category { Id = (int)Categories.OBJECT_ORIENTED, DisplayText = "object-oriented" },
        };
    }
}