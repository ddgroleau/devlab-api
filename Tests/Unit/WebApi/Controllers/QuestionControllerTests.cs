using Core.Domain.Models;
using Core.Services;
using devlab_api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace Tests.Unit.WebApi.Controllers;

[TestFixture]
public class QuestionControllerTests
{
    private QuestionController _questionController;
    private ILogger<QuestionController> _logger;
    private IQuestionService _questionService;

    [SetUp]
    public void BeforeEach()
    {
        _questionService = Substitute.For<IQuestionService>();
        _logger = Substitute.For<ILogger<QuestionController>>();
        _questionController = new QuestionController(_logger,_questionService);
    }

    [TestCase(true)]
    [TestCase(false)]
    public async Task GetDifficulties_WithAnyResultCount_Returns200(bool isEmpty)
    {
        List<Difficulty> mockDifficulties =
            isEmpty ? new List<Difficulty>() : new List<Difficulty> { new Difficulty() };
        _questionService.GetDifficulties().Returns(Task.FromResult(mockDifficulties.AsEnumerable()));
        Assert.That(((OkObjectResult) await _questionController.GetDifficulties()).StatusCode,Is.EqualTo(200));
    }

    [TestCase(true)]
    [TestCase(false)]
    public async Task GetCategories_WithAnyResultCount_Returns200(bool isEmpty)
    {
        List<Category> mockCategories =
            isEmpty ? new List<Category>() : new List<Category> { new Category() };
        _questionService.GetCategories().Returns(Task.FromResult(mockCategories.AsEnumerable()));
        Assert.That(((OkObjectResult) await _questionController.GetCategories()).StatusCode,Is.EqualTo(200));
    }
    
    [Test]
    public async Task GetQuestions_WithValidArguments_Returns200()
    {
        _questionService.GetQuestions(Arg.Any<int>(), Arg.Any<int>(), Arg.Any<int>(),Arg.Any<List<int>>())
            .Returns(Task.FromResult(new List<Question>().AsEnumerable()));
        Assert.That(((OkObjectResult) await _questionController.GetQuestions(1,1,1,"1")).StatusCode,Is.EqualTo(200));
    }
}