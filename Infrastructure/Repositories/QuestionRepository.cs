using Core.Domain.Models;
using Core.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class QuestionRepository : IQuestionRepository
{
    private readonly AppDbContext _context;

    public QuestionRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Difficulty>> GetDifficulties()
    {
        return await _context.Difficulties.ToListAsync();
    }

    public async Task<IEnumerable<Category>> GetCategories()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<IEnumerable<Tag>> GetTags(int[]? categoryIds, string? difficultyId)
    {
        return await Task.FromResult(Array.Empty<Tag>());
    }

    public async Task<IEnumerable<Question>> GetQuestions(IEnumerable<int> categoryIds, int difficultyId, int questionCount, IEnumerable<int> tagIds)
    {
        var questions = await _context.Questions
            .Include(q => q.Category)
            .Include(q => q.Difficulty)
            .AsNoTracking()
            .Where(q =>
                q.Difficulty.Id.Equals(difficultyId) &&
                (!categoryIds.Any() || categoryIds.Contains(q.CategoryId)) &&
                (!tagIds.Any() || q.Tags.All(t => tagIds.Contains(t.Id)))
            )
            .OrderBy(q => EF.Functions.Random())
            .Take(questionCount)
            .ToListAsync();
            
            return questions.Select(q =>
            {
                q.AnswerOptions = q.AnswerOptions.OrderBy(_ => new Random().Next()).ToArray();
                return q;
            });
    }
}