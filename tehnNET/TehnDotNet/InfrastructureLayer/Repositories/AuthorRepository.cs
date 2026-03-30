using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;

namespace TehnDotNet.Infrastructure.Repositories;

public class AuthorRepository: IAuthorRepository
{
    private readonly DatabaseContext _context;
    private readonly ILogger<AuthorRepository> _logger;

    public AuthorRepository(DatabaseContext context,
        ILogger<AuthorRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void Create(Author author)
    {
        try
        {
            _context.Add(author);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
        }
    }

    public List<Author> GetAll()
    {
        return _context.Authors.ToList();
    }

    public Author Get(long id)
    {
        return _context.Authors.FirstOrDefault(x => x.Id == id);

    }

    public void Update(Author author)
    {
        _context.Update(author);
        _context.SaveChanges();
    }
}
