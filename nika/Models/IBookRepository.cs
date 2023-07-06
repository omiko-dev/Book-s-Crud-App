namespace nika.Models
{
    public interface IBookRepository
    {

        public IEnumerable<Book> GetAllBook();


        public Book DeleteBook(string Name);

        public Book SetBook(Book book);

        public Book UpdateBook(string name, Book book);

    }
}
