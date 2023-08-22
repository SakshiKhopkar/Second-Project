using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.method_Assignment
{
    public class Useref
    {
        static void swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
        static void Main(string[] args)
        {
            int a = 23; int b = 43;
            swap(ref a,ref b);
            Console.WriteLine($"a={a},b={b}");
        }
    }
}
