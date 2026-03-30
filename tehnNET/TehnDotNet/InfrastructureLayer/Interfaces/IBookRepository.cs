using TehnDotNet.Entities;

namespace TehnDotNet.Infrastructure.Interfaces;

public interface IBookRepository
{
    void Add(Book book);
    void Update(Book book);
    Book GetById(long Id);
    IQueryable<Book> GetAll();
}
