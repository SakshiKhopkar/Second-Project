using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.String
{
    internal class CharacterOccure
    {
        static void Main(string[] args)
        {
            // 3.Write a C# program to count occurrences of a character in given string.
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
            Console.WriteLine("character count is"+" "+count);
        }
    }
}
