namespace Core.Domain.Models;

public class Category : Permutable
{
    public int Id { get; set; }
    public string DisplayText { get; set; }
    public ICollection<Question> Questions { get; set; }

    public Category()
    {
        DisplayText = "";
        Questions = new List<Question>();
    }
}