using Microsoft.AspNetCore.Mvc;
using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Models;

namespace TehnDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PublisherController : ControllerBase
{
    private readonly IPublisherService _publisherService;

    public PublisherController(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return Ok(_publisherService.GetAll());
    }

    [HttpPost]
    public IActionResult Create([FromBody] PublisherDto publisher)
    {
        _publisherService.Create(publisher);

        return Ok();
    }
}
