namespace Core.Domain.Models;

public class Tag
{
    public int Id { get; set; }
    public string Value { get; set; } = "";
    public string DisplayText { get; set; } = "";
    public ICollection<Question> Questions { get; set; } = new List<Question>();
}