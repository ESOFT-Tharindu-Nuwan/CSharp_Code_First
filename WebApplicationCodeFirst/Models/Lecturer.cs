using System.ComponentModel.DataAnnotations;

namespace WebApplicationCodeFirst.Models
{
    public class Lecturer
    {
        [Key]
        public int RegNo { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
