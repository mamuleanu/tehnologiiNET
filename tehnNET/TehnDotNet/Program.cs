using Microsoft.EntityFrameworkCore;
using TehnDotNet;
using TehnDotNet.ApplicationLayer.Services;
using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Infrastructure.Interfaces;
using TehnDotNet.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBooksService, BookService>();
#warning Sensitive data here. Please move it to appsettings.json.
builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=libraryv2;Username=postgres;Password=replaceme"));





var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    context.Database.Migrate();
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
