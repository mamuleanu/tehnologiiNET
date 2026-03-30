using System.Text.Json.Serialization;

namespace TehnDotNet.Entities;

public class Publisher
{
    public Publisher()
    {
        this.Books = new HashSet<Book>();
    }
    public long Id { get; set; }
    public string Name { get; set; }

    public ICollection<Book> Books { get; set; }
}
