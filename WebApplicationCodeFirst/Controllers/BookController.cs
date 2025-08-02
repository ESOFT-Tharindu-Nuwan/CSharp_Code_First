using Microsoft.AspNetCore.Mvc;

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
    }
}
