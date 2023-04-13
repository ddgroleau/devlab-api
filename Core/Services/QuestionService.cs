﻿using Core.Domain.Models;
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
      return await _questionRepository.GetDifficulties();
   }

   public async Task<List<Category>> GetCategories()
   {
      return await _questionRepository.GetCategories();
   }

   public async Task<List<Tag>> GetTags(int? categoryId, string? difficultyId)
   {
      return await _questionRepository.GetTags(categoryId, difficultyId);
   }

   public async Task<List<Question>> GetQuestions(int categoryId, string difficultyId, List<int> tagIds)
   {
      if (categoryId.Equals(0) || string.IsNullOrWhiteSpace(difficultyId))
         throw new ArgumentException("Invalid arguments");
      
      return await _questionRepository.GetQuestions(categoryId, difficultyId, tagIds);
   }
}