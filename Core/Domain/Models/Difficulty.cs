namespace Core.Domain.Models;

public class Difficulty : Permutable
{
    public int Id { get; set; }
    public string DisplayText { get; set; }
    public ICollection<Question> Questions { get; set; }

    public Difficulty()
    {
        DisplayText = "";
        Questions = new List<Question>();
    }

}