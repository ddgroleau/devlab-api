namespace Core.Domain.Models;

public class Question : Permutable
{
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public List<string> AnswerOptions { get; set; }
    public string CorrectAnswer { get; set; }
    public int DifficultyId { get; set; }
    public int CategoryId { get; set; }
    public Difficulty Difficulty { get; set; }
    public Category Category { get; set; }
    public ICollection<Tag> Tags { get; set; }
    public Question()
    {
        QuestionText = "";
        AnswerOptions = new();
        CorrectAnswer = "";
        Difficulty = new();
        Category = new();
        Tags = new List<Tag>();
    }
}