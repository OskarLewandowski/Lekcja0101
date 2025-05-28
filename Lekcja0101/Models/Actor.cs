using System.ComponentModel.DataAnnotations;

namespace Lekcja0101.Models
{
    public class Actor
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
