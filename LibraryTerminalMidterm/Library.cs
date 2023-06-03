using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminalMidterm
{
    public class Library 
    {
        public static List<Book> BookList { get; set; } = new List<Book>();

        public static void DisplayBooks()
        {
            int counter = 1;

            foreach (var book in BookList)
            {
                Console.WriteLine($"{counter}. {book.Title} by {book.Author}");
                counter++;

            }
        }
        public static void SearchByAuthor()
        {
            Console.WriteLine("Enter authors name.");
            string input = Console.ReadLine();


            foreach (Book book in BookList)
            {

                if (book.Author == input.ToLower() && book.IsCheckedOut == false)
                {
                    Console.WriteLine(book); //call checkout method
                }
                else if (book.Author == input.ToLower() && book.IsCheckedOut == true)
                {
                    Console.WriteLine("This book is checked out.");
                }
                else
                {
                    Console.WriteLine("This book is not in library");
                }

            }

        }

        public static void SearchByTitle()
        {
            Console.WriteLine("Enter title.");
            string input = Console.ReadLine();


            foreach (Book book in BookList)
            {

                if (book.Title == input.ToLower() && book.IsCheckedOut == false)
                {
                    Console.WriteLine(book); //call checkout method
                }
                else if (book.Title == input.ToLower() && book.IsCheckedOut == true)
                {
                    Console.WriteLine("This book is checked out.");
                }
                else
                {
                    Console.WriteLine("This book is not in library");
                }
            }
              //should we make our methods in a class by itself or within the class it corresponds with?
        }



        public static void ReturnBook()
        {
            Console.WriteLine("Type the ttile of the book");
            string input = Console.ReadLine();

            foreach (Book book in BookList)
            {
                if (book.Title == input.ToLower())
                {
                    book.IsCheckedOut = false;
                    
                }
            }
        }

        public static void Checkout(List<Book> book, DateTime date)
        {
            Console.WriteLine("Enter the number of the book you want to checkout.");

            int input = Int32.Parse(Console.ReadLine());

            BookList[input - 1].IsCheckedOut = true;
            DateTime dueDate = date.AddDays(14);

            Console.WriteLine($"Thank you. The book is now checked out and it is to be returned to the library by {dueDate}");
            
            //DateTime dueDate = Date.AddDays
            //BookList[input - 1].Date = ;

        }


      

    }
}
