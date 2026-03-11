using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TehnDotNet.ApplicationLayer.Dto;
using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;
using TehnDotNet.Models;
using TehnDotNet.Infrastructure.Repositories;

namespace TehnDotNet.Controllers;


public class HomeController : Controller
{
    private readonly IBooksService _booksService;

    public HomeController(IBooksService booksService)
    {
        _booksService = booksService;
    }

    public IActionResult Index()
    {

        var books = _booksService.GetAll();

        return Ok(books);
    }


    // [HttpPost]
    // public IActionResult Create([FromBody] Book book)
    // {
    //     _bookRepository.Add(book);
    //     return Ok();
    // }
    //
    // [HttpPut]
    // public IActionResult Update([FromBody] Book book)
    // {
    //     var bookFromDb = _bookRepository.GetById(book.Id);
    //     if (bookFromDb == null)
    //     {
    //         return NotFound();
    //     }
    //
    //     if (ModelState.IsValid)
    //     {
    //         _bookRepository.Update(book);
    //     }
    //     else
    //     {
    //          var errorList = ModelState.Values.SelectMany(v => v.Errors)
    //             .Select(e => e.ErrorMessage)
    //             .ToList();
    //          return NotFound(errorList);
    //     }
    //
    //     return Ok();
    // }


    // public IActionResult Add()
    // {
    //     var bookToBeAdded = new Book
    //     {
    //         Title = "Don Quixote",
    //         Author = "Miguel de Cervantes",
    //         ISBN = "978-0060934347",
    //         Pages = 992,
    //         Category = "Fiction",
    //         YearOfPublication = 1605,
    //         Description = "The adventures of a nobleman who loses his sanity and decides to become a knight-errant.",
    //         URL = "bla bla"
    //     };
    //     _bookRepository.Add(bookToBeAdded);
    //
    //     return Ok();
    // }
    // public IActionResult Filter([FromQuery] int year, string category)
    // {
    //     var books = _bookRepository.GetAll();
    //     // books = toate cartile din baza noastra de date fictiva
    //     var filteredBooksByYear = books.
    //         Where(x => x.YearOfPublication > year).ToList();
    //
    //     if(!string.IsNullOrEmpty(category))
    //     {
    //         filteredBooksByYear = filteredBooksByYear.Where(x => x.Category == category).ToList();
    //     }
    //
    //     // Dependency Injection
    //
    //
    //
    //     return Ok(filteredBooksByYear);
    // }
}
