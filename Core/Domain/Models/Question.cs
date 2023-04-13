namespace Core.Domain.Models;

public class Question
{
    public int Id { get; set; }
    public string QuestionText { get; set; } = "";
    public List<string> AnswerOptions { get; set; } = new();
    public string CorrectAnswer { get; set; } = "";
    public string DifficultyId { get; set; } = "";
    public int CategoryId { get; set; }
    public virtual Difficulty Difficulty { get; set; } = new();
    public virtual Category Category { get; set; } = new();
    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}