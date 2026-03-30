using TehnDotNet.Entities;
using TehnDotNet.Models;

namespace TehnDotNet.ApplicationLayer.Services.Interfaces;

public interface IAuthorService
{
    void Create(AuthorDto author);
    void Update(AuthorDto author);
    List<Author> GetAll();
    AuthorDto GetById(long id);

}
