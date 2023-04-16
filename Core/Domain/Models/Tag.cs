namespace Core.Domain.Models;

public class Tag : Permutable
{
    public int Id { get; set; }
    public string Value { get; set; }
    public string DisplayText { get; set; }
    public ICollection<Question> Questions { get; set; }
    public Tag()
    {
        Value = "";
        DisplayText = "";
        Questions = new List<Question>();
    }
}