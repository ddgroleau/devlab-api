﻿using Core.Utility;
using Infrastructure;
using Infrastructure.Repositories;

namespace Tests.Integration.Infrastructure.Repositories;

[TestFixture]
public class QuestionRepositoryTests
{
    private QuestionRepository _questionRepository;

    [OneTimeSetUp]
    public void BeforeAll()
    {
        AppConfig.LoadEnv();
        _questionRepository = new QuestionRepository(new AppDbContext());
    }
    
    [Test]
    public async Task GetDifficulties_ReturnsDifficulties() =>
        Assert.That(await _questionRepository.GetDifficulties(), Is.Not.Empty);
    
    [Test]
    public async Task GetCategories_ReturnsCategories() =>
        Assert.That(await _questionRepository.GetCategories(), Is.Not.Empty);
    
    [TestCase("1",0,"1")]
    public async Task GetQuestions_WithInvalidArguments_ReturnsEmptyCategoriesList(string categoryIds, int difficultyId,string tags) =>
        Assert.That(await _questionRepository.GetQuestions(categoryIds.Split(",").Select(t=>Convert.ToInt32(t)).ToList(),difficultyId,1,tags.Split(",").Select(t=>Convert.ToInt32(t)).ToList()), Is.Empty);
}