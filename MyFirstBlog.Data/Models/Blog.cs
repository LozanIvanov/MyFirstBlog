using System.ComponentModel.DataAnnotations;

namespace MyFirstBlog.Data.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Header { get; set; }

        public int ThemeId { get; set; }

        public virtual Theme Theme { get; set; }

        [Required]
        [StringLength(10000)]
        public string Content { get; set; }

        public string ImagePath { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
