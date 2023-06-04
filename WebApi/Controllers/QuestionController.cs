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
        public async Task<IActionResult> GetQuestions(int category, int difficulty, int questionCount, string? tags)
        {
            try
            {
                var tagIds = string.IsNullOrWhiteSpace(tags) ? new() : tags.Split(",").Select(t => Convert.ToInt32(t)).ToList();
                return Ok(await _questionService.GetQuestions(category,difficulty, questionCount, tagIds));
            }
            catch (Exception e)
            {
                _logger.LogError("Exception thrown at QuestionController:GetQuestions, Message: {0}",e.Message);
                return BadRequest();
            }
        }
        
        [HttpGet("difficulties")]
        public async Task<IActionResult> GetDifficulties()
        {
            try
            {
                return Ok(await _questionService.GetDifficulties());
            }
            catch (Exception e)
            {
                _logger.LogError("Exception thrown at QuestionController:GetDifficulties, Message: {0}",e.Message);
                return BadRequest();
            }
        }
        
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                return Ok(await _questionService.GetCategories());
            }
            catch (Exception e)
            {
                _logger.LogError("Exception thrown at QuestionController:GetCategories, Message: {0}",e.Message);
                return BadRequest();
            }
        }
        
        [HttpGet("tags")]
        public async Task<IActionResult> GetTags(int? categoryId, string? difficultyId)
        {
            try
            {
                return Ok(await _questionService.GetTags(categoryId,difficultyId));
            }
            catch (Exception e)
            {
                _logger.LogError("Exception thrown at QuestionController:GetTags, Message: {0}",e.Message);
                return BadRequest();
            }
        }
        
    }
}
