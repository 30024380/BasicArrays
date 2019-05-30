using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: Find the average of 10 randomly generated numbers 

namespace Arrays_Re_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rand = new Random();
            double total = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);
                total += nums[i];
            }

            Console.WriteLine($"Average {total/nums.Length}");
            Console.ReadLine();
        }
    }
}
