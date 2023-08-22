using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.String
{
    internal class HeighestFre
    {
        static void Main(string[] args)
        {
            //12.Write a C# program to find highest frequency character in a string.
            string message = "good morning";
            char[] ch1 = message.ToCharArray();
            int count = 0;
            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] == 'g')
                {
                    count++;
                }
            }
            Console.WriteLine("character count is" + " " + count);
        }
    }
}
