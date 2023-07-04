using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public TodoStatus Status { get; set; }
        public int AuthorId { get;set; }
        public Author Author { get; set; }
    
    }
}
