using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;
using TehnDotNet.Models;

namespace TehnDotNet.ApplicationLayer.Services;

public class PublisherService: IPublisherService
{
    private readonly IPublisherRepository _repository;

    public PublisherService(IPublisherRepository repository)
    {
        _repository = repository;
    }

    public void Create(PublisherDto publisher)
    {
        var publisherToCreate = new Publisher()
        {
            Name = publisher.Name
        };
        _repository.Create(publisherToCreate);
    }

    public List<Publisher> GetAll()
    {
        return _repository.GetAll().ToList();
    }
}
