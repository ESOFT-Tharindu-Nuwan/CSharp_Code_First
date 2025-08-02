using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplicationCodeFirst.Models
{
    public class Book
    {
        public int id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public string Author { get; set; }
        [DisplayName("date_of_publish")]
        public DateTime DateOfPublish { get; set; }
        [DisplayName("date_of_release")]
        public DateTime? DateOfRelease { get; set; }
    }
}
