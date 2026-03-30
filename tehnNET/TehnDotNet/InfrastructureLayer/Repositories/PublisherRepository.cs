using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;

namespace TehnDotNet.Infrastructure.Repositories;

public class PublisherRepository: IPublisherRepository
{
    private readonly DatabaseContext _context;
    private readonly ILogger<PublisherRepository> _logger;

    public PublisherRepository(DatabaseContext context,
        ILogger<PublisherRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void Create(Publisher publisher)
    {
        try
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            _logger.LogError("Error ocurred while adding a new publisher. See the message below:");
            _logger.LogError(e.Message);
        }
    }

    public List<Publisher> GetAll()
    {
        return _context.Publishers.ToList();
    }
}
