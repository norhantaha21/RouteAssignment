namespace C_Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> {
           new Book(  "111" , "C# Basics" , new List<string> {"John Smith" }, new DateTime(2020 , 5, 1) , 1350) ,
           new Book( "222" , "Advanced C#" , new List<string> {"Jan Doe" } ,  new DateTime(2022 , 3, 15) , 790) ,
           new Book( "333" ,"Design Patterns" , new List<string> {"Robert Martin" } ,  new DateTime(2021 , 11, 10) , 1099)

           };

            Console.WriteLine("===== (a) Using User Defined Delegate ====");
            LibraryEngine.ProcessBooks<Book, string>(books, BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks<Book, string>(books, BookFunctions.GetAuthors);
            

            Console.WriteLine("===== (b) Using BCL Delegate (Func<Book , string>) ====");
            LibraryEngine.ProcessBooksBCL<Book, string>(books, BookFunctions.GetISBN);
            LibraryEngine.ProcessBooksBCL<Book, string>(books, BookFunctions.GetPrice);
            

            Console.WriteLine("==== (c) Using Anonymous Method  (GetISBN) ====");
            LibraryEngine.ProcessBooks<Book, string>(books, delegate (Book b)
            {
                return b.ISBN;
            });


            Console.WriteLine("==== (d) Using Lambda Expression (GetPublicationDate) ====");
            LibraryEngine.ProcessBooksBCL<Book , string>(books , b => b.PublicationDate.ToShortDateString() );
            
        }
    }
}
