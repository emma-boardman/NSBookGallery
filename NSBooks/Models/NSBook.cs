using System;
namespace NSBooks.Models
{
    public class NSBook
    {       
            public int Id { get; set; }
            public string SeriesTitle { get; set; }
            public int JlptLevel { get; set; }
            public string DescriptionHtml { get; set; }
            public Author[] Authors { get; set; }
            public bool Favourite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + JlptLevel;
            }
        }

        //series-title-issuenumber.jpg

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + JlptLevel + ".jpg";
            }
        }

    }
}
