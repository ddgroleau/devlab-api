using Core.Domain.Models;

namespace Core.RepositoryInterfaces;

public interface IQuestionRepository
{
    Task<IEnumerable<Difficulty>> GetDifficulties();

    Task<IEnumerable<Category>> GetCategories();

    Task<IEnumerable<Tag>> GetTags(int? categoryId, string? difficultyId);

    Task<IEnumerable<Question>> GetQuestions(int categoryId, int difficultyId, int questionCount, List<int> tagIds);
}