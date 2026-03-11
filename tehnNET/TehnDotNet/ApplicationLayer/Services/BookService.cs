using TehnDotNet.ApplicationLayer.Dto;
using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Infrastructure.Interfaces;

namespace TehnDotNet.ApplicationLayer.Services;

public class BookService: IBooksService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public List<BookDto> GetAll()
    {
        return _bookRepository.GetAll().Select(x => new BookDto()
        {
            Title = x.Title,
            Author = x.Author,
            ISBN = x.ISBN,
            Pages = x.Pages,
            Category = x.Category,
            YearOfPublication =  x.YearOfPublication,
            Description = x.Description,
            URL = x.URL
        }).ToList();
    }
}
