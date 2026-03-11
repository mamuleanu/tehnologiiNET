using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TehnDotNet.Entities;

public class Book
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int Pages { get; set; }
    public string Category { get; set; }
    public  int YearOfPublication { get; set; }
    public string Description { get; set; }
    public string URL { get; set; }

    public bool IsDamaged { get; set; }

    [ForeignKey("PublisherId")]
    public long PublisherId { get; set; }

    public virtual Publisher Publisher { get; set; }

}
