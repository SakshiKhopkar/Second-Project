using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Surprise_test
{
    internal class First_last_digitsum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num >= 10)
            {
                num = num /10;
            }
            Console.WriteLine(num);
            int firstdigit = num;
            int lastdigit=temp%10;
            sum= firstdigit+lastdigit;
            Console.WriteLine("sum of last digit and first digit is="+sum);



        }
    }
}
