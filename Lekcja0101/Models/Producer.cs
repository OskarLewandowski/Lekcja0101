using System.ComponentModel.DataAnnotations;

namespace Lekcja0101.Models
{
    public class Producer
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
