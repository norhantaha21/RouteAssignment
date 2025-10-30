using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Adv03
{

    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

 
        public Book(string isbn, string title, List<string> authors,  DateTime publicationDate , decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public override string ToString()
        {
            string allAuthors = string.Join(", ", Authors);
            return $"{Title} by {allAuthors} | Price : {Price} | ISBN : {ISBN} | Published : {PublicationDate:yyyy-MM-dd}";
        }

    }
}
