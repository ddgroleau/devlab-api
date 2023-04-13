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
        _questionService.GetDifficulties().Returns(Task.FromResult(mockDifficulties));
        Assert.That(((OkObjectResult) await _questionController.GetDifficulties()).StatusCode,Is.EqualTo(200));
    }
    
    [Test]
    public async Task GetDifficulties_WithException_ReturnsBadRequest()
    {
        _questionService.GetDifficulties().ThrowsAsync(new Exception());
        Assert.That(((BadRequestResult) await _questionController.GetDifficulties()).StatusCode,Is.EqualTo(400));
    }

    [TestCase(true)]
    [TestCase(false)]
    public async Task GetCategories_WithAnyResultCount_Returns200(bool isEmpty)
    {
        List<Category> mockCategories =
            isEmpty ? new List<Category>() : new List<Category> { new Category() };
        _questionService.GetCategories().Returns(Task.FromResult(mockCategories));
        Assert.That(((OkObjectResult) await _questionController.GetCategories()).StatusCode,Is.EqualTo(200));
    }
    
    [Test]
    public async Task GetCategories_WithException_ReturnsBadRequest()
    {
        _questionService.GetCategories().ThrowsAsync(new Exception());
        Assert.That(((BadRequestResult) await _questionController.GetCategories()).StatusCode,Is.EqualTo(400));
    }

    [Test]
    public async Task GetQuestions_WithInvalidArguments_ReturnsBadRequest()
    {
        _questionService.GetQuestions(Arg.Any<int>(), Arg.Any<string>(), Arg.Any<List<int>>())
            .ThrowsAsync(new ArgumentException());
        Assert.That(((BadRequestResult) await _questionController.GetQuestions(0,null,null)).StatusCode,Is.EqualTo(400));
    }
    
    [Test]
    public async Task GetQuestions_WithValidArguments_ReturnsOk()
    {
        _questionService.GetQuestions(Arg.Any<int>(), Arg.Any<string>(), Arg.Any<List<int>>())
            .Returns(Task.FromResult(new List<Question>()));
        Assert.That(((OkObjectResult) await _questionController.GetQuestions(1,"easy",new List<int>())).StatusCode,Is.EqualTo(200));
    }
}