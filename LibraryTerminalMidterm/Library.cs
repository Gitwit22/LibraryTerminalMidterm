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
            DateTime today = DateTime.Now;
            int counter = 1;

            foreach (var book in BookList)
            {
                Console.WriteLine($"{counter}. {book.Title} by {book.Author}");
                counter++;

            }

            Console.WriteLine("Enter the number of the book you want to checkout.");
            int input = Int32.Parse(Console.ReadLine());

            if (BookList[input - 1].IsCheckedOut == false)
            {
                BookList[input - 1].IsCheckedOut = true;
                DateTime dueDate = today.AddDays(14);
                Console.WriteLine($"Thank you. The book {BookList[input - 1].Title} is now checked out and it is to be returned to the library by {dueDate}");
            }
            else
            {
                Console.WriteLine("This book is not available, now you gotta do it all over again!");
            }
           



            // Linq


        }
        public static void SearchByAuthor()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Enter authors name.");
            string input = Console.ReadLine();
            bool isNotInCatalog = false;
        
            foreach (Book book in BookList)
            {
                if (book.Author == input.ToLower() && book.IsCheckedOut == false)
                {
                    isNotInCatalog = true;
                    book.IsCheckedOut = true;
                    DateTime dueDate = today.AddDays(14);
                    Console.WriteLine($"Thank you. The book {book.Title} is now checked out and it is to be returned to the library by {dueDate}");
                    break;

                }
                else if (book.Author == input.ToLower() && book.IsCheckedOut == true)
                {
                    isNotInCatalog = true;
                    Console.WriteLine("This book is checked out");
                    break;
                }
            }

            if (isNotInCatalog == false)
            {
               Console.WriteLine("Now you know good and well that author aint on the list, now you gotta start all over again!");
            }         
        }

        public static void SearchByTitle()
        {
            Console.WriteLine("Enter title.");
            string input = Console.ReadLine();
            bool isNotInCatalog = false;
            DateTime today = DateTime.Now;

            foreach (Book book in BookList)
            {





                if (book.Title == input.ToLower() && book.IsCheckedOut == false)
                {
                    isNotInCatalog = true;
                    book.IsCheckedOut = true;
                    DateTime dueDate = today.AddDays(14);
                    Console.WriteLine($"Thank you. The book {book.Title} is now checked out and it is to be returned to the library by {dueDate}");
                    break;

                }
                else if (book.Title == input.ToLower() && book.IsCheckedOut == true)
                {
                    isNotInCatalog = true;
                    Console.WriteLine("This book is checked out");
                    break;
                }


            }

            if (isNotInCatalog == false)
            {

                Console.WriteLine("Now you know good and well that author aint on the list, now you gotta start all over again!");

            }
        }



            ////    foreach (Book book in BookList)
            ////    {

            ////        if (book.Title == input.ToLower() && book.IsCheckedOut == false)
            ////        {
            ////            Console.WriteLine(book); //call checkout method
            ////        }
            ////        else if (book.Title == input.ToLower() && book.IsCheckedOut == true)
            ////        {
            ////            Console.WriteLine("This book is checked out.");
            ////        }
            ////        //else
            ////        //{
            ////        //    Console.WriteLine("This book is not in library");
            ////        //}
            ////    }
            ////      //should we make our methods in a class by itself or within the class it corresponds with?
            ////}



            public static void ReturnBook()
        {
            Console.WriteLine("Type the ttile of the book");
            string input = Console.ReadLine();

            foreach (Book book in BookList)
            {
                if (book.Title == input.ToLower())
                {
                    book.IsCheckedOut = false;
                    Console.WriteLine("Thank you for returning the book.");
                    
                }
            }
        }

        public static void Checkout()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Enter the number of the book you want to checkout.");

            int input = Int32.Parse(Console.ReadLine());

            BookList[input - 1].IsCheckedOut = true;
            DateTime dueDate = today.AddDays(14);

            Console.WriteLine($"Thank you. The book is now checked out and it is to be returned to the library by {dueDate}");
            
           

        }


      

    }
}
