using System.ComponentModel.DataAnnotations;

namespace TehnDotNet.Entities;

public class Author
{
    public Author()
    {
        this.Books = new HashSet<Book>();
    }
    [Key]
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}
