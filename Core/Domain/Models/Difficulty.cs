namespace Core.Domain.Models;

public class Difficulty
{
    public string Id { get; set; }
    public string DisplayText { get; set; } = "";
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

}