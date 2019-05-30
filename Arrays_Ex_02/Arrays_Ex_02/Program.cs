using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: Learning Arrays
namespace Arrays_Ex_02
{
   public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[5];

            Console.WriteLine("Enter In The First Name");
            names[0] = Console.ReadLine();

            Console.WriteLine("Enter In The Second Name");
            names[1] = Console.ReadLine();

            Console.WriteLine("Enter In The Third Name");
            names[2] = Console.ReadLine();

            Console.WriteLine("Enter In The Fourth Name");
            names[3] = Console.ReadLine();

            Console.WriteLine("Enter In The Fifth Name");
            names[4] = Console.ReadLine();

            Console.WriteLine($"First Name in the Array: {names[0]}");
            Console.WriteLine($"Last Name in the Array: {names[4]}");

            Console.ReadLine();
        }
    }
}
