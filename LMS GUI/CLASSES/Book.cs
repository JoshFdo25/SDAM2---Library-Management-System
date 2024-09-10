using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_GUI
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int bookID, string title, string author, string isbn, bool isAvailable)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = isAvailable;
        }
    }
}
