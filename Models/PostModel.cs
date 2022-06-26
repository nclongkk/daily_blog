using System.ComponentModel.DataAnnotations;

namespace daily_blog.Models
{
    public class PostModel : BaseModel
    {

        [StringLength(50)]
        public string? Title { get; set; }

        [StringLength(100)]
        public string? Image { get; set; }

        public int? AuthorId { get; set; }

        public virtual UserModel? Author { get; set; }

        //override ToString()
        public override string ToString()
        {
            return $"{Id} - {Title} - {Image} - {AuthorId} - {CreatedAt}";
        }
    }
}