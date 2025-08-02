using Microsoft.AspNetCore.Mvc;
using WebApplicationCodeFirst.Models;

namespace WebApplicationCodeFirst.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDBContext _context;

        public BookController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        // GET: Book/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return View();
        }
    }
}
