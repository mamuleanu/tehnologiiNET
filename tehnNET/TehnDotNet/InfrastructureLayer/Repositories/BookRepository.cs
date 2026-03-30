using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;

namespace TehnDotNet.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
   private readonly DatabaseContext _context;

   public BookRepository(DatabaseContext context)
   {
      _context = context;
   }

   public void Add(Book book)
   {
      _context.Books.Add(book);
      _context.SaveChanges();
   }

   public void Update(Book book)
   {
      var existingBook = _context.Books.FirstOrDefault(x => x.Id == book.Id);

      if (existingBook != null)
      {
         existingBook.Title = book.Title;
         existingBook.Description = book.Description;
         existingBook.ISBN = book.ISBN;
         existingBook.Pages = book.Pages;
         existingBook.Category = book.Category;
         existingBook.YearOfPublication = book.YearOfPublication;
         existingBook.URL = book.URL;
         _context.SaveChanges();
      }

   }

   public Book GetById(long Id)
   {
      return _context.Books.FirstOrDefault(x => x.Id == Id);
   }

   public IQueryable<Book> GetAll()
   {
      return _context.Books.AsQueryable();
   }
}
