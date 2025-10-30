using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Adv03
{
    internal class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public static string GetAuthors(Book b)
        {
            return string.Join(",", b.Authors);
        }

        public static string GetPrice(Book b)
        {
            return b.Price.ToString($"0.00 EGP ");
        }
        public static string GetISBN(Book b)
        {
            return b.ISBN;
        }

        public static string PublicationDate(Book b)
        {
            return b.PublicationDate.ToShortDateString();
        }

    }
}
