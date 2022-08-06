using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entityframework.Models
{
    [Table("Category")]
    public class Category
    {
        private string name;

        [Key]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get => name; set => name = value; }
        public string? Description { get; set; }

        public int Effor { get; set; }

        public virtual ICollection<Task>? Tasks { get; set; }
    }
}