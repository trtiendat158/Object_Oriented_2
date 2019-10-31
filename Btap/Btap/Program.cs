using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Author
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author a = new Author("Tran Tien Dat", "tiendat.tr158@gmail.com", 'm');
            //Console.WriteLine(a.ToString());
            //Console.ReadLine();

            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            Console.WriteLine(ahTeck);  // Test toString()
            ahTeck.SetEmail("paulTan@nowhere.com");  // Test setter
            Console.WriteLine("name is: " + ahTeck.GetName());     // Test getter
            Console.WriteLine("eamil is: " + ahTeck.GetEmail());   // Test getter
            Console.WriteLine("gender is: " + ahTeck.GetGender()); // Test gExerciseOOP_MyPolynomial.pngetter
        }
    }
}
