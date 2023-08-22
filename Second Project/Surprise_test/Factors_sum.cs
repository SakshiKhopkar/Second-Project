using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Surprise_test
{
    internal class Factors_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            double num=Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
               
                if(num%i == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            double avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
