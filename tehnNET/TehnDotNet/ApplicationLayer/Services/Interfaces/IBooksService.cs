using TehnDotNet.ApplicationLayer.Dto;

namespace TehnDotNet.ApplicationLayer.Services.Interfaces;

public interface IBooksService
{
    List<BookDto> GetAll();
    void Create(BookDto book);
    BookDto GetById(long id);
}
