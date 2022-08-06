using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entityframework.Models
{
    [Table("Task")]
    public class Task
    {
        private string title;

        [Key]
        public Guid TaskId { get; set; }

        [ForeignKey("CategoryId")]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get => title; set => title = value; }
        public string? Description { get; set; }
        public Priority? PriorityTask { get; set; }
        public DateTime? DateCreation { get; set; }
        public virtual Category? Category { get; set; }

        [NotMapped]
        public string? Resume { get; set; }
    }

    public enum Priority
    {
        Low,
        Medium,
        Large
    }
}