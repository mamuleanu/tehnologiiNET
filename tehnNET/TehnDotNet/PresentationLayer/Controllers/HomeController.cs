using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TehnDotNet.ApplicationLayer.Dto;
using TehnDotNet.ApplicationLayer.Services.Interfaces;

namespace TehnDotNet.Controllers;

[ApiController]
[Route("api/books")]
public class HomeController : ControllerBase
{
    private readonly IBooksService _booksService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(IBooksService booksService,
        ILogger<HomeController> logger)
    {
        _booksService = booksService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var books = _booksService.GetAll();
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(long id)
    {
        var book = _booksService.GetById(id);
        return Ok(book);
    }

    [HttpPost]
    public IActionResult Create([FromBody] BookDto book)
    {
        _booksService.Create(book);
        return Ok();
    }
}
