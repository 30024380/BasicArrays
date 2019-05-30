using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: Learning Arrays
namespace Arrays_Ex_03
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string[] english = {"Hello Singular person formal","Hello Singular person informal","Hello 2 people formal","Hello Many People Formal"};
            string[] maori = {"Tena Koe", "Kia Ora", "Tena Korua", "Tena Koutou" };

            for(int i = 0; i < maori.Length; i++)
            {
                Console.WriteLine($"{i+1}.{english[i]}");
            }

            Console.Write("\nWhich word would you like translated\n");
            int input = int.Parse(Console.ReadLine());

            Console.Write($"This {english[input - 1]} translates into {maori[input - 1]}");
            Console.ReadLine();
        }
    }
}
