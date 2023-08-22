using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.String
{
    internal class CheakNullOrEmpty
    {
        static void Main(string[] args)
        {
            string str = "";
            if(string.IsNullOrEmpty(str))
            {
                Console.WriteLine("string is empty");
            }
            Console.WriteLine(str);
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                Console.WriteLine("Hello"+" " + name);
            }
        }
    }
}
