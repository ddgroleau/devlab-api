using Core.Domain.Models;

namespace Core.Services;

public interface IQuestionService
{
    Task<IEnumerable<Difficulty>> GetDifficulties();
    Task<IEnumerable<Category>> GetCategories();

    Task<IEnumerable<Tag>> GetTags(int[]? categoryIds, string? difficultyId);

    Task<IEnumerable<Question>> GetQuestions(IEnumerable<int> categoryIds, int difficultyId, int questionCount, IEnumerable<int> tagIds);
}