﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Author_Book_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            Author[] authors = new Author[2];
         authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
         authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

// Declare and allocate a Book instance
        Book javaDummy = new Book("Java for Dummy", authors, 19.99, 99);
        Console.WriteLine(javaDummy);  // toString()
        }
    }
}
