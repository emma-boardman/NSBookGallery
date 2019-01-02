using System;
using NSBooks.Models;

namespace NSBooks.Data
{
    public class NSBookRepo
    
    {
        private static NSBook[] _nsBooks = new NSBook[]
        {
            new NSBook()

            {
                SeriesTitle = "Kanji Practice",
                JlptLevel = 4,
                DescriptionHtml = "<b>Info Info Info</b>",
                Authors = new Author[]
              {
                    new Author() { Name = "Writer 1", Role = "Writing 1"},
                    new Author() { Name = "Writer 2", Role = "Writing 2"}
              }
            },

            new NSBook()

            {
                SeriesTitle = "Human Rights in Japan",
                JlptLevel = 1,
                DescriptionHtml = "<b>Info Info Info</b>",
                Authors = new Author[]
              {
                    new Author() { Name = "Writer 1", Role = "Writing 1"},
                    new Author() { Name = "Writer 2", Role = "Writing 2"}
              }
            },

             new NSBook()

            {
                SeriesTitle = "News Phrases",
                JlptLevel = 1,
                DescriptionHtml = "<b>Info Info Info</b>",
                Authors = new Author[]
              {
                    new Author() { Name = "Writer 1", Role = "Writing 1"},
                    new Author() { Name = "Writer 2", Role = "Writing 2"}
              }
            },


    };


        public NSBook GetNSBook(int id)
        {
            NSBook nsBookToReturn = null;

            foreach (var nsBook in _nsBooks)
            {
                if (nsBook.Id == id)
                {
                    nsBookToReturn = nsBook;
                    break;
                }
            }

            return nsBookToReturn;

        }
    }
}
