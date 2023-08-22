using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.String
{
    internal class ReverseOfStr
    {
        static void Main(string[] args)
        {
            //10.Write a C# program to find reverse of a string.
            string MSG = "Hii EveryBody";
            char[] ch= MSG.ToCharArray();
            for (int i=ch.Length-1; i>=0; i--)
            {
                Console.Write( ch[i]);
            }
            Console.WriteLine("\n");

        }
    }
}
