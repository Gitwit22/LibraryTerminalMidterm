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

        public static List<Book> BookList { get; set; } = new List<Book>();



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

        public Book()
        {

        }

        public void DisplayBooks()
        {
            int counter = 1;

            foreach (var book in BookList)
            {

                Console.WriteLine($"{counter}. {book.Title} by {book.Author}");
                counter++;

            }
            Console.WriteLine("Enter the number of the book you want to checkout.");

            int input = Int32.Parse( Console.ReadLine() );

            BookList[input - 1].IsCheckedOut = true;



        }
    }
}
