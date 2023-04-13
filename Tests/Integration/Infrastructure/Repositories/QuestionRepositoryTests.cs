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
    
    [TestCase(0,"easy","0")]
    [TestCase(1,"","0")]
    [TestCase(1,null,"0")]
    public async Task GetQuestions_WithInvalidArguments_ReturnsEmptyCategoriesList(int categoryId, string difficultyId,string tags) =>
        Assert.That(await _questionRepository.GetQuestions(categoryId,difficultyId,tags.Split(",").Select(t=>Convert.ToInt32(t)).ToList()), Is.Empty);
}