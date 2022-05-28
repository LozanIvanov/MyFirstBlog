using System.ComponentModel.DataAnnotations;

namespace MyFirstBlog.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Username { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        public virtual IEnumerable<Blog> Blogs { get; set; } = new HashSet<Blog>();

        public virtual IEnumerable<Theme> Themes { get; set; } = new HashSet<Theme>();
    }
}
