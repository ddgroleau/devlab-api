using Core.Domain.Models;

namespace Core.Services;

public interface IQuestionService
{
    Task<List<Difficulty>> GetDifficulties();

    Task<List<Category>> GetCategories();

    Task<List<Tag>> GetTags(int? categoryId, string? difficultyId);

    Task<List<Question>> GetQuestions(int categoryId, string difficultyId, List<int> tagIds);
}