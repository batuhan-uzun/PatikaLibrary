using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    internal class Library // Class: Contains properties and behavior of an object. Veriables, methods or constructors containing methods can be defined inside classes
    {
        // Constructor: A special method that is automatically invoked when creating a new object of a class. It can be used by default, but it also allows us to perform different operations with alternative constructors
        public Library() // Default Constructor with no parameters
        {
            RegistrationDate = DateTime.Now;
        }

        public Library(string bookName, string writerName, string writerSurname, int pageCount, string publisher) // Alternative Constructor that takes parameters
        {
            RegistrationDate = DateTime.Now;
            BookName = bookName;
            WriterName = writerName;
            WriterSurname = writerSurname;
            PageCount = pageCount;
            Publisher = publisher;
        }

        // Property: Objects that store the data of a class and determine the type of access. Properties are defined as get set
        public string BookName { get; set; } // We get set the book name,writer name and surname, page count, publisher and registration date properties
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
