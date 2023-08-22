using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Printeven
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("even numbers are=" + numbers[i]);
                }
            }
        }
    }
}
