using TehnDotNet.Entities;
using TehnDotNet.Models;

namespace TehnDotNet.ApplicationLayer.Dto;

public class BookDto
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int Pages { get; set; }
    public string Category { get; set; }
    public  int YearOfPublication { get; set; }
    public string Description { get; set; }
    public string URL { get; set; }

    public long AuthorId { get; set; }
    public long PublisherId { get; set; }

    public List<AuthorDto> Authors { get; set; }

}
