using LibraryTerminalMidterm;





Console.WriteLine("Hello. Welcome To The Online Library Rental System");
Console.WriteLine("What would you like to do? (Choose 1-5");
Console.WriteLine("1. Display All Books");
Console.WriteLine("2. Search By Author");
Console.WriteLine("3. Search By Title");
Console.WriteLine("4. Return a Book");
Console.WriteLine("5. Exit");

//books

Book.BookList.Add(new Book("Elf", "Family"));
Book.BookList.Add(new Book("The Matrix", "John Doe"));
Book.BookList.Add(new Book("The Bible", "Jesus Christ"));
Book.BookList.Add(new Book("Jumanji", "Robin Williams"));
Book.BookList.Add(new Book("Green Eggs and Ham", "Dr. Seuss"));
Book.BookList.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
Book.BookList.Add(new Book("Wrestling with Acting", "The Rock"));
Book.BookList.Add(new Book("Fool Me Once", "George Bush"));
Book.BookList.Add(new Book("If i Did it and Why", "O.J. Simpson"));
Book.BookList.Add(new Book("Lord Of The Rings", "J.R. Tolkien"));
Book.BookList.Add(new Book("Harry Potter", "J.K. Rowling"));
Book.BookList.Add(new Book("How To Rap", "John Blaze"));
Book.BookList.Add(new Book("Teacher Who Barge In And Save Us From Mistakes", "Cassly Tremaine"));





int input = Int32.Parse(Console.ReadLine());

switch (input)
{
    case 1: 
        Book.DisplayBooks();
        break;
    case 2:
        Console.WriteLine("Search by auth"); //display method
        break;
    case 3:
        Console.WriteLine("search by title"); //display method
        break;
    case 4:
        Console.WriteLine("return bookd"); //display method
        break;
    case 5:
        break;
    default: Console.WriteLine("Please enter a valid number");
        break;
}

