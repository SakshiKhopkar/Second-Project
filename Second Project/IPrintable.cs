using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public interface IPrintable
    {
        string print();
    }
    public class User : IPrintable
    {
        public string print()
        {
            return $"user details";
        }
    }
    public class Printing
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.WriteLine( u.print());
        }
    }
}
