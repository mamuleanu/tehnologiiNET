using TehnDotNet.Entities;

namespace TehnDotNet.Infrastructure.Interfaces;

public interface IAuthorRepository
{
    void Create(Author author);
    List<Author> GetAll();
    Author Get(long id);
    void Update(Author author);
}
