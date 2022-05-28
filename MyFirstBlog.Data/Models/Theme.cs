using System.ComponentModel.DataAnnotations;

namespace MyFirstBlog.Data.Models
{
    public class Theme
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Header { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual IEnumerable<Blog> Blogs { get; set; } = new HashSet<Blog>();


    }
}
