namespace Core.Domain.Models;

public abstract class Permutable
{
    public DateTime CreatedUtc { get; set; }
    
    public DateTime ModifiedUtc { get; set; }
    
    public string CreatedBy { get; set; }
    
    public string ModifiedBy { get; set; }
    
    public Permutable()
    {
        CreatedBy = "initial_create";
        ModifiedBy = "initial_create";
        CreatedUtc = DateTime.UtcNow;
        ModifiedUtc = DateTime.UtcNow;
    }
}