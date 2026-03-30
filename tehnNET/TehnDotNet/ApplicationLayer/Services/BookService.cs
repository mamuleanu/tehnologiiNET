using Microsoft.EntityFrameworkCore;
using TehnDotNet.ApplicationLayer.Dto;
using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;
using TehnDotNet.Models;

namespace TehnDotNet.ApplicationLayer.Services;

public class BookService: IBooksService
{
    private readonly IBookRepository _bookRepository;
    private readonly IAuthorRepository _authorRepository;

    public BookService(IBookRepository bookRepository, IAuthorRepository authorRepository)
    {
        _bookRepository = bookRepository;
        _authorRepository = authorRepository;
    }

    public List<BookDto> GetAll()
    {
        return _bookRepository.GetAll().Select(x => new BookDto()
        {
            Title = x.Title,
            ISBN = x.ISBN,
            Pages = x.Pages,
            Category = x.Category,
            YearOfPublication =  x.YearOfPublication,
            Description = x.Description,
            URL = x.URL
        }).ToList();
    }

    public void Create(BookDto book)
    {
        var bookToAdd = new Book()
        {
            Category =  book.Category,
            Description = book.Description,
            ISBN = book.ISBN,
            Pages = book.Pages,
            Title = book.Title,
            URL = book.URL,
            YearOfPublication = book.YearOfPublication,
            PublisherId = book.PublisherId
        };

        var author = _authorRepository.GetAll().FirstOrDefault(x => x.Id == book.AuthorId);

        if (author != null)
        {
            bookToAdd.Authors.Add(author);
            _bookRepository.Add(bookToAdd);
        }
    }

    public BookDto GetById(long id)
    {
        var book = _bookRepository.GetAll()
            .Include(x => x.Authors)
            .FirstOrDefault(x => x.Id == id);

        var authorsList = book.Authors.Select(x => new AuthorDto()
        {
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            Phone = x.Phone
        }).ToList();
        return new BookDto()
        {
            Title = book.Title,
            ISBN = book.ISBN,
            Pages = book.Pages,
            Category = book.Category,
            YearOfPublication = book.YearOfPublication,
            Description = book.Description,
            URL = book.URL,
            Authors = authorsList
        };
    }
}
