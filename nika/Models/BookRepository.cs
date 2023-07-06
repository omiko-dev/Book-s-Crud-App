using System.Reflection.Metadata.Ecma335;

namespace nika.Models
{
    public class BookRepository : IBookRepository
    {

        private List<Book> Books;
        public BookRepository()
        {
                Books = new List<Book>()
                {
                    new Book() { Name="Jon", Description="Best Book", Author=Enums.Author.Author_1, Publicher=Enums.Publisher.Publicher_1, Language=Enums.Language.English, Genre=Enums.Genre.Genre_1, Shelf=Enums.Shelf.Shelf_1 },

                    new Book() { Name="Anna", Description="Good Book", Author=Enums.Author.Author_3, Publicher=Enums.Publisher.Publicher_2, Language=Enums.Language.Latin, Genre=Enums.Genre.Genre_2, Shelf=Enums.Shelf.Shelf_2 }
                };
        }
        public IEnumerable<Book> GetAllBook()
        {

            return Books;
        }

        public Book Geet(Book book)
        {
            throw new NotImplementedException();
        }

        public Book DeleteBook(string Name)
        {
            var _book = Books.FirstOrDefault(x => x.Name == Name);

            if (_book == null)
                return null;

            Books.Remove(_book);

            return _book;

        }

        public Book SetBook(Book book)
        {
            Books.Add(book);

            return book;
        }

        public Book UpdateBook(string name, Book book)
        {
            var _book = Books.FirstOrDefault(d => d.Name == name);

            if (_book != null)
            {
                _book.Name = book.Name;
                _book.Description = book.Description;
                _book.Author = book.Author;
                _book.Shelf = book.Shelf;
                _book.Publicher = book.Publicher;
                _book.Language = book.Language;
                _book.Genre = book.Genre;
            }

            return _book;
        }
    }
}
