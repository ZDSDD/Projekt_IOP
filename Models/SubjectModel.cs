using System.ComponentModel.DataAnnotations;

namespace StudSentials.Models
{
    public class SubjectModel
    {
        [Key]
        public int Id { get; set; }
        public string? SubjectName { get; set; }
        public string? Description { get; set; }
        public string? UserID { get; set; }
    }
}
