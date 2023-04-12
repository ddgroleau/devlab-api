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
        _questionRepository.GetDifficulties().Returns(Task.FromResult(new List<Difficulty> { new Difficulty() }));
        Assert.That(await _questionService.GetDifficulties(), Is.Not.Empty);
    }
    
    [Test]
    public async Task GetCategories_ReturnsCategories()
    { 
        _questionRepository.GetCategories().Returns(Task.FromResult(new List<Category> { new Category() }));
        Assert.That(await _questionService.GetCategories(), Is.Not.Empty);
    }

    [TestCase(0, "easy", "")]
    [TestCase(1, "", "")]
    [TestCase(1, null, "")]
    public void GetQuestions_WithInvalidArguments_ReturnsEmptyCategoriesList(int categoryId, string difficultyId,
        string tags) =>
        Assert.ThrowsAsync<ArgumentException>(async ()=> await _questionService.GetQuestions(categoryId, difficultyId, tags.Split(",").ToList()));
    
    [Test]
    public async Task GetQuestions_WithValidArguments_ReturnsList()
    {
        _questionRepository.GetQuestions(Arg.Any<int>(), Arg.Any<string>(), Arg.Any<List<string>>())
            .Returns(Task.FromResult(new List<Question> { new Question() }));
        Assert.That(await _questionService.GetQuestions(1,"easy",new List<string>()),Is.Not.Empty);
    }
}