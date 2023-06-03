using LibraryTerminalMidterm;
using System.Collections.Generic;

Library.BookList.Add(new Book("elf", "family"));
Library.BookList.Add(new Book("the matrix", "john doe", true));
Library.BookList.Add(new Book("the bible", "jesus christ"));
Library.BookList.Add(new Book("jumanji", "robin williams", true));
Library.BookList.Add(new Book("green eggs and ham", "dr. seuss"));
Library.BookList.Add(new Book("the great gatsby", "f. scott fitzgerald"));
Library.BookList.Add(new Book("wrestling with acting", "the rock"));
Library.BookList.Add(new Book("fool me once", "george bush", true));
Library.BookList.Add(new Book("if i did it and why", "o.j. simpson"));
Library.BookList.Add(new Book("lord of the rings", "j.r. tolkien"));
Library.BookList.Add(new Book("harry potter", "j.k. rowling", true));
Library.BookList.Add(new Book("how to rap", "john blaze"));
Library.BookList.Add(new Book("teacher who barge in and save us from mistakes", "cassly tremaine"));

//Start Program

Console.WriteLine("Hello. Welcome To The Online Library Rental System");


Console.WriteLine("What would you like to do? (Choose 1-5");

Console.WriteLine("1. Display All Books");
Console.WriteLine("2. Search By Author");
Console.WriteLine("3. Search By Title");
Console.WriteLine("4. Return a Book");
Console.WriteLine("5. Exit");

//books







int input = Int32.Parse(Console.ReadLine());

switch (input)
{
    case 1:
        Library.DisplayBooks();
        //added checkout to the display case
        //Library.Checkout();
        break;
    case 2:
        Library.SearchByAuthor(); 
        break;
    case 3:
        Library.SearchByTitle(); 
        break;
    case 4:
        Library.ReturnBook(); 
        break;
    case 5:
        
        break;
    default: Console.WriteLine("Please enter a valid number");
        break;
}

