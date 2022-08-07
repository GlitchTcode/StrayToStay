using System.ComponentModel.DataAnnotations;

namespace StrayToStay.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        [Required]
        public string Title { get; set; }
        public string Breed { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Description { get; set; }

        public byte[]? Image { get; set; }

    }
}
