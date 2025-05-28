using System.ComponentModel.DataAnnotations;

namespace Lekcja0101.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
    }
}
