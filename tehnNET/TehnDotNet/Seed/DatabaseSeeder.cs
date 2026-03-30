using TehnDotNet.Entities;

namespace TehnDotNet.Seed;

public static class DatabaseSeeder
{
    public static void SeedAuthorsAndPublishers(DatabaseContext context)
    {
        if (!context.Authors.Any())
        {
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

            context.Authors.AddRange(authors);
        }

        if (!context.Publishers.Any())
        {
            var publishers = new List<Publisher>
            {
                new() { Name = "Penguin Random House" },
                new() { Name = "HarperCollins" },
                new() { Name = "Simon & Schuster" },
                new() { Name = "Macmillan Publishers" },
                new() { Name = "Hachette Livre" },
                new() { Name = "Oxford University Press" },
                new() { Name = "Cambridge University Press" },
                new() { Name = "Scholastic" },
                new() { Name = "Pearson" },
                new() { Name = "Bloomsbury" },
                new() { Name = "Springer" },
                new() { Name = "Wiley" }
            };

            context.Publishers.AddRange(publishers);
        }

        context.SaveChanges();
    }
}