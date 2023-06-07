using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace devlab_api.Controllers
{
    [Route("api/questions")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly ILogger<QuestionController> _logger;
        private readonly IQuestionService _questionService;

        public QuestionController(ILogger<QuestionController> logger, IQuestionService questionService)
        {
            _logger = logger;
            _questionService = questionService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetQuestions(string categories, int difficulty, int questionCount, string? tags)
        {
            var tagIds = string.IsNullOrWhiteSpace(tags) ? Array.Empty<int>() : tags.Split(",").Select(t => Convert.ToInt32(t)).ToArray();
            var categoryIds = string.IsNullOrWhiteSpace(categories) ? Array.Empty<int>() : categories.Split(",").Select(t => Convert.ToInt32(t)).ToArray();
            return Ok(await _questionService.GetQuestions(categoryIds,difficulty, questionCount, tagIds));
        }
        
        [HttpGet("difficulties")]
        public async Task<IActionResult> GetDifficulties()
        {
            return Ok(await _questionService.GetDifficulties());
        }
        
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(await _questionService.GetCategories());
        }
        
        [HttpGet("tags")]
        public async Task<IActionResult> GetTags(string categories, string? difficultyId)
        {
            var categoryIds = string.IsNullOrWhiteSpace(categories) ? Array.Empty<int>() : categories.Split(",").Select(t => Convert.ToInt32(t)).ToArray();
            return Ok(await _questionService.GetTags(categoryIds,difficultyId));
        }
        
    }
}
