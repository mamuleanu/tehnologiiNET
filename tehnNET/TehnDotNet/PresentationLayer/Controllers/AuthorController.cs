using Microsoft.AspNetCore.Mvc;
using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Models;

namespace TehnDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    /// <summary>
    /// Returns all authors
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(_authorService.GetAll());
    }

    /// <summary>
    /// Creates an author
    /// </summary>
    /// <param name="author"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Create([FromBody] AuthorDto author)
    {
        _authorService.Create(author);
        return Ok();
    }
}
