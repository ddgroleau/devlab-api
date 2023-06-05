using Core.Domain.Models;

namespace Core.Services;

public interface IQuestionService
{
    Task<IEnumerable<Difficulty>> GetDifficulties();
    Task<IEnumerable<Category>> GetCategories();

    Task<IEnumerable<Tag>> GetTags(int? categoryId, string? difficultyId);

    Task<IEnumerable<Question>> GetQuestions(int categoryId, int difficultyId, int questionCount, List<int> tagIds);
}