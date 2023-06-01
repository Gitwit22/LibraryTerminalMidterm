using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminalMidterm
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsCheckedOut { get; set; } = false;
        //write method for due date if checked out 

        public static List<Book> BookList { get; set; } = new List<Book>()

        {
            new Book("The Matrix", "John Doe"),
            new Book("The Bible", "Jesus Christ"),
            new Book("Jumanji", "Robin Williams"),
            new Book("Green Eggs and Ham", "Dr. Seuss"),
            new Book("The Great Gatsby", "F. Scott Fitzgerald"),
            new Book("Wrestling with Acting", "The Rock"),
            new Book("Fool Me Once", "George Bush"),
            new Book("If i Did it and Why", "O.J. Simpson"),
            new Book("Lord Of The Rings", "J.R. Tolkien"),
            new Book("Harry Potter", "J.K. Rowling"),
            new Book("How To Rap", "John Blaze"),
            new Book("Teacher Who Barge In And Save Us From Mistakes", "Cassly Tremaine")




        };

        public Book(string title, string author)
        {
            Title = title;
            Author = author;

        }

        public Book(string title, string author, bool isCheckedOut)
        {
            Title = title;
            Author = author;
            IsCheckedOut = isCheckedOut;
        }
       









    }
}
