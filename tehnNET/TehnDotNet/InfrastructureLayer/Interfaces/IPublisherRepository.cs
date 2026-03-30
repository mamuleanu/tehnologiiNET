using TehnDotNet.Entities;

namespace TehnDotNet.Infrastructure.Interfaces;

public interface IPublisherRepository
{
    void Create(Publisher publisher);
    List<Publisher> GetAll();
}
