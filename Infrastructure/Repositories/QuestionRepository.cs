﻿using Core.Domain.Models;
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
    
    public async Task<List<Difficulty>> GetDifficulties()
    {
        return await _context.Difficulties.ToListAsync();
    }

    public async Task<List<Category>> GetCategories()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<List<Tag>> GetTags(int? categoryId, int? difficultyId)
    {
        return new List<Tag>();
    }

    public async Task<List<Question>> GetQuestions(int categoryId, string difficultyId, List<int> tags)
    {
        return await _context.Questions
            .Include(q => q.Difficulty)
            .Include(q => q.Category)
            .Include(q => q.Tags)
            .Where(q => 
                q.Category.Id.Equals(categoryId) && 
                q.Difficulty.Id.Equals(difficultyId) &&
                q.Tags.Select(t=>t.Id).Contains<IEnumerable<int>>(tags)
                ).ToListAsync();
    }
}