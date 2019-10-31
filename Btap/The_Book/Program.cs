using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace The_Book
{
    class Program
    {
        static void Main(string[] args)
        {
           Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
           Console.WriteLine(ahTeck);  // Author's toString()

           Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
           Console.WriteLine(dummyBook);  // Test Book's toString()

// Test Getters and Setters
        dummyBook.SetPrice(29.95);
        dummyBook.SetQty(28);
        Console.WriteLine("name is: " + dummyBook.GetName());
        Console.WriteLine("price is: " + dummyBook.GetPrice());
        Console.WriteLine("qty is: " + dummyBook.GetQty());
        Console.WriteLine("Author is: " + dummyBook.GetAuthor());  // Author's toString()
        Console.WriteLine("Author's name is: " + dummyBook.GetAuthor().GetName());
        Console.WriteLine("Author's email is: " + dummyBook.GetAuthor().GetEmail());

// Use an anonymous instance of Author to construct a Book instance
        Book anotherBook = new Book("more Java", 
        new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
        Console.WriteLine(anotherBook);  // toString()
        }
    }
}
