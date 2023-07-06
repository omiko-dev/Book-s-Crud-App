using Microsoft.AspNetCore.Mvc;

namespace nika.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {

            IEnumerable<Book> books = _bookRepository.GetAllBook();

            return View(books);
        }

        [HttpPost]
        public IActionResult Index(Book book)
        {
            var allBook = _bookRepository.GetAllBook();



            IEnumerable<Book> fillterBook =  
                allBook.Where(b =>
                   b.Name == book.Name ||
                   b.Description == book.Description ||
                   b.Shelf == book.Shelf ||
                   b.Publicher == book.Publicher ||
                   b.Author == book.Author ||
                   b.Genre == book.Genre
                );

            if(fillterBook == null) 
                return RedirectToAction("Index");


            return View(fillterBook.ToList());
        }

        [HttpPost]
        public IActionResult Delete(string name)
        {
            _bookRepository.DeleteBook(name);

            return RedirectToAction("Index");
        }



        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                var _book = _bookRepository.SetBook(book);
                TempData["Add"] = "Add";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet("{name}")]
        public IActionResult UpdateBook(string name)
        {
            return View();
        }

        [HttpPost("{id}")]
        public IActionResult UpdateBook(string id, Book book)
        {

            if (ModelState.IsValid)
            {
                _bookRepository.UpdateBook(id, book);

                return RedirectToAction("Index");
            }

            return View();

        }


    }
}
