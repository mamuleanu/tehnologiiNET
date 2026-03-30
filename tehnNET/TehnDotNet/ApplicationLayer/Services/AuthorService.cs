using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;
using TehnDotNet.Models;

namespace TehnDotNet.ApplicationLayer.Services;

public class AuthorService: IAuthorService
{
    private readonly IAuthorRepository _repository;

    public AuthorService(IAuthorRepository repository)
    {
        _repository = repository;
    }

    public void Create(AuthorDto author)
    {
        var author_to_save = new Author()
        {
            FirstName = author.FirstName,
            LastName = author.LastName,
            Email = author.Email,
            Phone = author.Phone
        };
        _repository.Create(author_to_save);
    }

    public void Update(AuthorDto author)
    {
        throw new NotImplementedException();
    }

    public List<Author> GetAll()
    {
        return _repository.GetAll();
    }

    public AuthorDto GetById(long id)
    {
        throw new NotImplementedException();
    }
}
