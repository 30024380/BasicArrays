using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: To prompt the user to add 5 names to the array
namespace Arrays_Re_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names = new string[5];
            
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter A Name To Add To Array");
                names[i] = Console.ReadLine();
            }
        }
    }
}
