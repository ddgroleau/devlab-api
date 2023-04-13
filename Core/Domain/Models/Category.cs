namespace Core.Domain.Models;

public class Category
{
    public int Id { get; set; }
    public string Value { get; set; } = "";
    public string DisplayText { get; set; } = "";
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}