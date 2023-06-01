using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminalMidterm
{
    public  class BookMethods : Book 
    {


        public string DisplayBooks()
        {
            int counter = 1;

            foreach (var book in BookList)
            {

                Console.WriteLine($"{counter}. {book.Title} by {book.Author}");
                

            }




        }




}
}
