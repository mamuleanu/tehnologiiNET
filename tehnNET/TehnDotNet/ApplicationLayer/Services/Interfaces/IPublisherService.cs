using TehnDotNet.Entities;
using TehnDotNet.Models;

namespace TehnDotNet.ApplicationLayer.Services.Interfaces;

public interface IPublisherService
{
    void Create(PublisherDto publisher);
    List<Publisher> GetAll();
}
