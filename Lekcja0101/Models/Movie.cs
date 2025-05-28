using System.ComponentModel.DataAnnotations;

namespace Lekcja0101.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public string Summary { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
