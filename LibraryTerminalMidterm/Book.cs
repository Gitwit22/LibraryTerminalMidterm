using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
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
        public DateTime Date { get; } = DateTime.Now;





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

        public Book(DateTime date) 
        {
            Date = date;

        }

    }
}

