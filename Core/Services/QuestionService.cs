using Core.Domain.Models;
using Core.RepositoryInterfaces;
using Core.Utility;

namespace Core.Services;

public class QuestionService : IQuestionService
{
   private readonly IQuestionRepository _questionRepository;

   public QuestionService(IQuestionRepository questionRepository)
   {
      _questionRepository = questionRepository;
   }
   
   public async Task<IEnumerable<Difficulty>> GetDifficulties()
   {
      return await _questionRepository.GetDifficulties();
   }

   public async Task<IEnumerable<Category>> GetCategories()
   {
      return await _questionRepository.GetCategories();
   }

   public async Task<IEnumerable<Tag>> GetTags(int[]? categoryIds, string? difficultyId)
   {
      return await _questionRepository.GetTags(categoryIds, difficultyId);
   }

   public async Task<IEnumerable<Question>> GetQuestions(IEnumerable<int> categoryIds, int difficultyId, int questionCount, IEnumerable<int> tagIds)
   {
      if (difficultyId.Equals(0) || questionCount.Equals(0))
         throw new BusinessException("Invalid question filters.");
      
      return await _questionRepository.GetQuestions(categoryIds, difficultyId, questionCount, tagIds);
   }
}