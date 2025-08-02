using Microsoft.EntityFrameworkCore;
using WebApplicationCodeFirst.Models;

namespace WebApplicationCodeFirst
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {

        }

        public DbSet<StudentModel> Students { get; set; }

        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
