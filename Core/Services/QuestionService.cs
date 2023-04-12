using Core.Domain.Models;
using Core.RepositoryInterfaces;

namespace Core.Services;

public class QuestionService : IQuestionService
{
   private readonly IQuestionRepository _questionRepository;

   public QuestionService(IQuestionRepository questionRepository)
   {
      _questionRepository = questionRepository;
   }
   
   public async Task<List<Difficulty>> GetDifficulties()
   {
      return new List<Difficulty>();
   }

   public async Task<List<Category>> GetCategories()
   {
      return new List<Category>();
   }

   public async Task<List<Tag>> GetTags(int? categoryId, string? difficultyId)
   {
      return new List<Tag>();
   }

   public async Task<List<Question>> GetQuestions(int categoryId, string difficultyId, List<string> tags)
   {
      return new List<Question>();
   }
}