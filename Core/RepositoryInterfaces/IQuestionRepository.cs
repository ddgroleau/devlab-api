using Core.Domain.Models;

namespace Core.RepositoryInterfaces;

public interface IQuestionRepository
{
    Task<List<Difficulty>> GetDifficulties();

    Task<List<Category>> GetCategories();

    Task<List<Tag>> GetTags(int? categoryId, string? difficultyId);

    Task<List<Question>> GetQuestions(int categoryId, int difficultyId, int questionCount, List<int> tagIds);
}