using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class QuestionTag
{
    [Key,Column("id")]
    public int Id { get; set; }
    [Column("question_id")]
    public int QuestionId { get; set; }
    [Column("tag_id")]
    public int TagId { get; set; }
}