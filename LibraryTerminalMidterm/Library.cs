using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
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

            Console.WriteLine("Here is the list of books in the catalog:");

            foreach (Book book in BookList)
            {
                Console.WriteLine($"{counter}. {book.Title} by {book.Author}");
                counter++;
            }
            Console.WriteLine();

            try
            {
                Console.Write("Enter the number of the book you want to checkout: ");
                int input = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                if (BookList[input - 1].IsCheckedOut == false)
                {
                    BookList[input - 1].IsCheckedOut = true;
                    DateTime dueDate = today.AddDays(14);
                    Console.WriteLine($"You have successfully checked out {BookList[input - 1].Title}. It is to be returned on {dueDate}.");
                    Console.WriteLine();
                }
                else if (BookList[input - 1].IsCheckedOut == true)
                {
                    Console.WriteLine($"{BookList[input - 1].Title} is already checked out by another person.");
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct response. Try again.");
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You did not enter a correct response. Try again.");
                Console.WriteLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("You did not enter a correct response. Try again.");
                Console.WriteLine();
            }
        }

        public static void SearchByAuthor()
        {
            DateTime today = DateTime.Now;

            Console.Write("Enter an author's name (ie: Stephen King): ");
            string input = Console.ReadLine();
            bool isNotInCatalog = false;

            List<Book> searchBookByAuthor = new List<Book>();


            foreach (Book book in BookList)
            {
                if (book.Author == input.ToLower())
                {
                    searchBookByAuthor.Add(book);
                }
            }

            if (searchBookByAuthor.Count == 0)
            {
                Console.WriteLine($"Sorry, we do not have any books in the catalog for {input}");
                Console.WriteLine();
            }
            else
            {
                int counter = 1;

                foreach (Book book in searchBookByAuthor)
                {
                    Console.WriteLine($"{counter}. {book.Title}");
                    counter++;
                }

            try
            {
                Console.Write("Enter the number of the book you wish to check out: ");
                int intInput = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                if (searchBookByAuthor[intInput - 1].IsCheckedOut == false)
                {
                    BookList[intInput - 1].IsCheckedOut = true;
                    DateTime dueDate = today.AddDays(14);
                    Console.WriteLine($"Thank you. The book {searchBookByAuthor[intInput - 1].Title} is now checked out and it is to be returned to the library by {dueDate}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("This book is not available, now you gotta do it all over again!");
                    Console.WriteLine();
                }
            }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter a correct response. Try again.");
                    Console.WriteLine();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You did not enter a correct response. Try again.");
                    Console.WriteLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You did not enter a correct response. Try again.");
                    Console.WriteLine();
                }
            }     
        }

        public static void SearchByTitleKeyword()
        {
            Console.Write("Enter a keyword to search through the list of titles: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            DateTime today = DateTime.Now;
            List<Book> searchResults = new List<Book>();

            foreach (Book book in BookList)
            {
                if (book.Title.Contains(input))
                {
                    searchResults.Add(book);
                }
            }

            if (searchResults.Count == 0)
            {
                Console.WriteLine($"We did not find any titles with the word {input}.");
                Console.WriteLine();
            }
            else
            {
                int count = searchResults.Count;
                int counter = 1;

                foreach (Book book in searchResults)
                {
                    Console.WriteLine($"{counter}. {book.Title}");
                    counter++;
                }
                Console.WriteLine();
                try
                {
                    Console.Write("Enter the number of the book you wish to check out: ");
                    int intInput = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (searchResults[intInput - 1].IsCheckedOut == false)
                    {
                        BookList[intInput - 1].IsCheckedOut = true;
                        DateTime dueDate = today.AddDays(14);
                        Console.WriteLine($"Thank you. The book {searchResults[intInput - 1].Title} is now checked out and it is to be returned to the library by {dueDate}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("This book is not available, now you gotta do it all over again!");
                        Console.WriteLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter a correct response. Try again.");
                    Console.WriteLine();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You did not enter a correct response. Try again.");
                    Console.WriteLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You did not enter a correct response. Try again.");
                    Console.WriteLine();
                }
            }            
        }

        public static void ReturnBook()
        {
            Console.WriteLine("Below is the list of books you can choose to return:");
            Console.WriteLine();

            List<Book> currentlyCheckedOutBooks = new List<Book>();

            foreach (Book book in BookList)
            {
                if (book.IsCheckedOut == true)
                {
                    currentlyCheckedOutBooks.Add(book);
                }
            }

            int counter = 1;
            foreach (Book book in currentlyCheckedOutBooks)
            {
                Console.WriteLine($"{counter}. {book.Title}");
                counter++;
            }

            try
            {
                Console.Write("Enter the number of the book you want to return: ");
                int input = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                currentlyCheckedOutBooks[input - 1].IsCheckedOut = true;

                Console.WriteLine($"Thank you for returning {currentlyCheckedOutBooks[input - 1].Title}");
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct response. Try again.");
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You did not enter a correct response. Try again.");
                Console.WriteLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("You did not enter a correct response. Try again.");
                Console.WriteLine();
            }
        }
    }
}