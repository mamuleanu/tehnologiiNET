using Microsoft.EntityFrameworkCore;
using TehnDotNet.Entities;

namespace TehnDotNet;

public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        #warning Sensitive data here. Please move it to appsettings.json.
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=libraryv2;Username=postgres;Password=");
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Author> Authors { get; set; }

}
