using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: Learn Arrays
namespace Arrays_Ex_01
{
   public class Program
    {
        public static void Main(string[] args)
        {
            string[] medalwinners = new string[3];

            Console.WriteLine("Enter the Gold Medalists name");
            medalwinners[0] = Console.ReadLine();

            Console.WriteLine("Enter the Silver Medalists name");
            medalwinners[1] = Console.ReadLine();

            Console.WriteLine("Enter the Bronze Medalists name");
            medalwinners[2] = Console.ReadLine();

            Console.WriteLine("\nWhich medal winner would you like to see?\n1 - Gold \n2 - Silver \n3 - Bronze");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($" Medal Winner is: {medalwinners[input - 1]}");
            Console.ReadLine();
        }
    }
}
