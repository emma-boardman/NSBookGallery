using System;
namespace NSBooks.Models
{
    public class NSBook
    {       
            public int Id { get; set; }
            public string SeriesTitle { get; set; }
            public int IssueNumber { get; set; }
            public string DescriptionHtml { get; set; }
            public Author[] Authors { get; set; }
            public bool Favourite { get; set; }

    }
}
