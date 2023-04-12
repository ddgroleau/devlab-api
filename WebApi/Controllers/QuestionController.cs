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
        
        [HttpGet("difficulties")]
        public async Task<IActionResult> GetDifficulties()
        {
            return Ok();
        }
        
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            return Ok();
        }
        
        [HttpGet("tags")]
        public async Task<IActionResult> GetTags(int? categoryId, string? difficultyId)
        {
            return Ok();
        }
        
        [HttpGet("questions")]
        public async Task<IActionResult> GetQuestions(int categoryId, string difficultyId, List<string> tags)
        {
            return Ok();
        }
    }
}
