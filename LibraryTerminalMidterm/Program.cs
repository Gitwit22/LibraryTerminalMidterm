/* Grand Circus Midterm
 * April After Hours C# 2023
 * John Steele
 * Adriana Garmo
 */

using LibraryTerminalMidterm;
using System.Collections.Generic;

Library.BookList.Add(new Book("elf", "james gunn"));
Library.BookList.Add(new Book("santa", "james gunn"));
Library.BookList.Add(new Book("mrs. clause", "james gunn"));
Library.BookList.Add(new Book("the matrix", "john doe", true));
Library.BookList.Add(new Book("the matrix 2", "john doe", true));
Library.BookList.Add(new Book("the matrix 3", "john doe"));
Library.BookList.Add(new Book("the bible", "jesus christ"));
Library.BookList.Add(new Book("jumanji", "robin williams", true));
Library.BookList.Add(new Book("green eggs and ham", "dr. seuss"));
Library.BookList.Add(new Book("the great gatsby", "f. scott fitzgerald"));
Library.BookList.Add(new Book("wrestling with acting", "the rock"));
Library.BookList.Add(new Book("acting with dancing", "the rock"));
Library.BookList.Add(new Book("fool me once", "george bush", true));
Library.BookList.Add(new Book("if i did it and why", "o.j. simpson"));
Library.BookList.Add(new Book("lord of the rings", "j.r. tolkien"));
Library.BookList.Add(new Book("harry potter", "j.k. rowling", true));
Library.BookList.Add(new Book("how to rap", "john blaze"));
Library.BookList.Add(new Book("teacher who barge in and save us from mistakes", "cassly tremaine"));

//how is this capitalization handled in the real world on both sides (user input and dev data)

Console.WriteLine("Hello. Welcome To The Library Catalog!");

bool startOver = true;

while (startOver == true)
{
    Console.WriteLine("1. Display All Books");
    Console.WriteLine("2. Search By Author");
    Console.WriteLine("3. Search By Title Keyword");
    Console.WriteLine("4. Return a Book");
    Console.WriteLine("5. Exit");
    Console.WriteLine();

    try
    {
        Console.Write("What would you like to do? (Choose 1-5): ");
        int input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (input)
        {
            case 1:
                Library.DisplayBooks();
                break;
            case 2:
                Library.SearchByAuthor();
                break;
            case 3:
                Library.SearchByTitleKeyword();
                break;
            case 4:
                Library.ReturnBook();
                break;
            case 5:
                startOver = false;
                Console.WriteLine("Thank you for attempting to read the book. Please be kind and rewind before returning");
                break;
            default:
                Console.WriteLine("You did not enter a valid number. Try again.");
                Console.WriteLine();
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("You did not enter a correct response. Try again.");
        Console.WriteLine();
    }
}