using System.ComponentModel.DataAnnotations;

namespace WebApplicationCodeFirst.Models
{
    public class Lecturer
    {
        [Key]
        public int RegNo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Contact { get; set; }

        public string? Address { get; set; } // ? mark used for make the column nullable in the DB
    }
}
