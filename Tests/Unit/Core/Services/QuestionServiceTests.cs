using Core.Domain.Models;
using Core.RepositoryInterfaces;
using Core.Services;
using NSubstitute;

namespace Tests.Unit.Core.Services;

[TestFixture]
public class QuestionServiceTests
{
    private QuestionService _questionService;
    private IQuestionRepository _questionRepository;

    [SetUp]
    public void BeforeEach()
    {
        _questionRepository = Substitute.For<IQuestionRepository>();
        _questionService = new QuestionService(_questionRepository);
    }
    
    [Test]
    public async Task GetDifficulties_ReturnsDifficulties()
    {
        _questionRepository.GetDifficulties().Returns(Task.FromResult(new List<Difficulty> { new Difficulty() }.AsEnumerable()));
        Assert.That(await _questionService.GetDifficulties(), Is.Not.Empty);
    }
    
    [Test]
    public async Task GetCategories_ReturnsCategories()
    { 
        _questionRepository.GetCategories().Returns(Task.FromResult(new List<Category> { new Category() }.AsEnumerable()));
        Assert.That(await _questionService.GetCategories(), Is.Not.Empty);
    }

    [TestCase(0,1,1, "1")]
    [TestCase(1,0,1, "1")]
    [TestCase(1,1,0, "1")]
    public void GetQuestions_WithInvalidArguments_ReturnsEmptyCategoriesList(int categoryId, int difficultyId, int questionCount,
        string tags) =>
        Assert.ThrowsAsync<ArgumentException>(async ()=> await _questionService.GetQuestions(categoryId, difficultyId,questionCount, tags.Split(",").Select(t=>int.Parse(t)).ToList()));
    
    [Test]
    public async Task GetQuestions_WithValidArguments_ReturnsList()
    {
        _questionRepository.GetQuestions(Arg.Any<int>(), Arg.Any<int>(), Arg.Any<int>(), Arg.Any<List<int>>())
            .Returns(Task.FromResult(new List<Question> { new Question() }.AsEnumerable()));
        Assert.That(await _questionService.GetQuestions(1,1,1, new List<int>()),Is.Not.Empty);
    }
}