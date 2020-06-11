using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();
            Console.WriteLine($"There are {authors.Count()} total authors");
            Console.WriteLine($"with {authors.SelectMany(a => a.Books).Count()} total books");

            Console.WriteLine("=======================================");
            Console.WriteLine("How many books are collaborations (have more than one author)?");

            var collaborations = authors.SelectMany(book => book.Books)
                                 .GroupBy(id => id.ID)
                                 .Where(dup => dup.Count() > 1)
                                 .Select(bk => bk)
                                 .ToList();

            Console.WriteLine($"{collaborations.Count()} are collaborations");
            Console.WriteLine("=======================================");
            Console.WriteLine("Which book has the most authors (and how many)?");

            var mostAuthors = authors.SelectMany(book => book.Books)
                                     .GroupBy(id => id.ID)
                                     .OrderBy(x => x.Count())
                                     .Select(y => y)
                                     .ToList()
                                     .LastOrDefault();

            var bookTitle = mostAuthors.Select(x => x.Title)
                                        .ToList()
                                        .FirstOrDefault();

            var numOfAuthors = mostAuthors.Count();

            Console.WriteLine($"The book {bookTitle} has most  authors.({numOfAuthors})");
            Console.WriteLine("=======================================");
            Console.WriteLine("What author wrote most collaborations?");

            var allBooks = authors.SelectMany(book => book.Books)
                                  .ToList();

            var collaborationsIds = collaborations.Select(x => x.Key)
                                                  .ToList();

            var listOfColl = allBooks.Where(book => collaborationsIds
                                     .Any(bk => bk == book.ID))
                                       .ToList();

            var maxColl = authors.Select(q => q.Books
                                .Where(w => listOfColl
                                .Any(r => r.ID == w.ID))
                                .Count())
                                .Max();

            var authorMax = authors.Where(bk => bk.Books
                                   .Where(x => listOfColl
                                   .Any(id => id.ID == x.ID))
                                   .Count() == maxColl)
                                   .FirstOrDefault();


            Console.WriteLine($"{authorMax.Name} wrote most the collaborations {maxColl}");
            Console.WriteLine("=======================================");
            Console.ReadLine();
        }
    }
}
