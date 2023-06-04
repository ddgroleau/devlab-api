using Core.Domain.Models;
using Core.Enums;

namespace Infrastructure.Data;

public static class SeedDifficulties
{
    public static IEnumerable<Difficulty> Execute()
    {
        return new Difficulty[]
        {
            new Difficulty { Id = (int)Difficulties.EASY, DisplayText = "easy" },
            new Difficulty { Id = (int)Difficulties.MEDIUM, DisplayText = "medium" },
            new Difficulty { Id = (int)Difficulties.HARD, DisplayText = "hard" },
        };
    }
}