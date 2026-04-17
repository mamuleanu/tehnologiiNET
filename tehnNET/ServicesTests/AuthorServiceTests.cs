using Moq;
using TehnDotNet.ApplicationLayer.Services;
using TehnDotNet.ApplicationLayer.Services.Interfaces;
using TehnDotNet.Entities;
using TehnDotNet.Infrastructure.Interfaces;

namespace ServicesTests;

public class AuthorServiceTests
{
    private readonly Mock<IAuthorRepository> _authorRepositoryMock;
    private readonly IAuthorService _authorService;

    public AuthorServiceTests()
    {
        _authorRepositoryMock = new Mock<IAuthorRepository>();
        _authorService = new AuthorService(_authorRepositoryMock.Object);
    }

    [Fact]
    public void AuthorService_GetAll_Should_Return_List_of_Authors()
    {
        // Arrange
        var authors = new List<Author>
        {
            new() { FirstName = "Jane", LastName = "Austen", Email = "jane.austen@library.local", Phone = "+40-721-000-101" },
            new() { FirstName = "George", LastName = "Orwell", Email = "george.orwell@library.local", Phone = "+40-721-000-102" },
            new() { FirstName = "Virginia", LastName = "Woolf", Email = "virginia.woolf@library.local", Phone = "+40-721-000-103" },
            new() { FirstName = "Leo", LastName = "Tolstoy", Email = "leo.tolstoy@library.local", Phone = "+40-721-000-104" },
            new() { FirstName = "Fyodor", LastName = "Dostoevsky", Email = "fyodor.dostoevsky@library.local", Phone = "+40-721-000-105" },
            new() { FirstName = "Gabriel", LastName = "Garcia Marquez", Email = "gabriel.marquez@library.local", Phone = "+40-721-000-106" },
            new() { FirstName = "Haruki", LastName = "Murakami", Email = "haruki.murakami@library.local", Phone = "+40-721-000-107" },
            new() { FirstName = "Margaret", LastName = "Atwood", Email = "margaret.atwood@library.local", Phone = "+40-721-000-108" },
            new() { FirstName = "Ernest", LastName = "Hemingway", Email = "ernest.hemingway@library.local", Phone = "+40-721-000-109" },
            new() { FirstName = "Toni", LastName = "Morrison", Email = "toni.morrison@library.local", Phone = "+40-721-000-110" },
            new() { FirstName = "Isabel", LastName = "Allende", Email = "isabel.allende@library.local", Phone = "+40-721-000-111" },
            new() { FirstName = "Kazuo", LastName = "Ishiguro", Email = "kazuo.ishiguro@library.local", Phone = "+40-721-000-112" }
        };
        _authorRepositoryMock.Setup(x => x.GetAll()).Returns(authors);
        // Act
        var result = _authorService.GetAll();
        // Assert
        Assert.IsType<List<Author>>(result);
    }

    [Fact]
    public void AuthorService_GetAll_Should_Return_All_Authors()
    {
        // Arrange
        var authors = new List<Author>
        {
            new() { FirstName = "Jane", LastName = "Austen", Email = "jane.austen@library.local", Phone = "+40-721-000-101" },
            new() { FirstName = "George", LastName = "Orwell", Email = "george.orwell@library.local", Phone = "+40-721-000-102" },
            new() { FirstName = "Virginia", LastName = "Woolf", Email = "virginia.woolf@library.local", Phone = "+40-721-000-103" },
            new() { FirstName = "Leo", LastName = "Tolstoy", Email = "leo.tolstoy@library.local", Phone = "+40-721-000-104" },
            new() { FirstName = "Fyodor", LastName = "Dostoevsky", Email = "fyodor.dostoevsky@library.local", Phone = "+40-721-000-105" },
            new() { FirstName = "Gabriel", LastName = "Garcia Marquez", Email = "gabriel.marquez@library.local", Phone = "+40-721-000-106" },
            new() { FirstName = "Haruki", LastName = "Murakami", Email = "haruki.murakami@library.local", Phone = "+40-721-000-107" },
            new() { FirstName = "Margaret", LastName = "Atwood", Email = "margaret.atwood@library.local", Phone = "+40-721-000-108" },
            new() { FirstName = "Ernest", LastName = "Hemingway", Email = "ernest.hemingway@library.local", Phone = "+40-721-000-109" },
            new() { FirstName = "Toni", LastName = "Morrison", Email = "toni.morrison@library.local", Phone = "+40-721-000-110" },
            new() { FirstName = "Isabel", LastName = "Allende", Email = "isabel.allende@library.local", Phone = "+40-721-000-111" },
            new() { FirstName = "Kazuo", LastName = "Ishiguro", Email = "kazuo.ishiguro@library.local", Phone = "+40-721-000-112" }
        };
        _authorRepositoryMock.Setup(x => x.GetAll()).Returns(authors);
        // Act
        var result = _authorService.GetAll();
        // Assert
        Assert.Equal(authors.Count, result.Count);
    }

    [Fact]
    public void AuthorService_GetById_Should_Return_Author()
    {
        // IMPORTANT: Acest test nu va trece cu succes. Metoda respectiva nu este implementata.
        // Arrange
        var authors = new List<Author>
        {
            new() { Id = 1, FirstName = "Jane", LastName = "Austen", Email = "jane.austen@library.local", Phone = "+40-721-000-101" },
            new() { Id = 2, FirstName = "George", LastName = "Orwell", Email = "george.orwell@library.local", Phone = "+40-721-000-102" },
            new() { Id = 3, FirstName = "Virginia", LastName = "Woolf", Email = "virginia.woolf@library.local", Phone = "+40-721-000-103" },
            new() { Id = 4, FirstName = "Leo", LastName = "Tolstoy", Email = "leo.tolstoy@library.local", Phone = "+40-721-000-104" },
            new() { Id = 5, FirstName = "Fyodor", LastName = "Dostoevsky", Email = "fyodor.dostoevsky@library.local", Phone = "+40-721-000-105" },
            new() { Id = 6, FirstName = "Gabriel", LastName = "Garcia Marquez", Email = "gabriel.marquez@library.local", Phone = "+40-721-000-106" },
            new() { Id = 7, FirstName = "Haruki", LastName = "Murakami", Email = "haruki.murakami@library.local", Phone = "+40-721-000-107" },
            new() { Id = 8, FirstName = "Margaret", LastName = "Atwood", Email = "margaret.atwood@library.local", Phone = "+40-721-000-108" },
            new() { Id = 9, FirstName = "Ernest", LastName = "Hemingway", Email = "ernest.hemingway@library.local", Phone = "+40-721-000-109" },
            new() { Id = 10, FirstName = "Toni", LastName = "Morrison", Email = "toni.morrison@library.local", Phone = "+40-721-000-110" },
            new() { Id = 11, FirstName = "Isabel", LastName = "Allende", Email = "isabel.allende@library.local", Phone = "+40-721-000-111" },
            new() { Id = 12, FirstName = "Kazuo", LastName = "Ishiguro", Email = "kazuo.ishiguro@library.local", Phone = "+40-721-000-112" }
        };
        _authorRepositoryMock.Setup(x => x.GetAll()).Returns(authors);
        // Act
        var author = _authorService.GetById(7);
        // Assert
        Assert.NotNull(author);
    }
}
