using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Surprise_test
{
   /* 4.	Write code to display numbers between 1 to 50 if number is even then display 
    * Its square and if it is odd then display number in negative.*/
    internal class Even_odd
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 50; i++)
            {
                if(i%2 == 0)
                {
                    int sqr = i * i;
                    Console.WriteLine(sqr);
                }
                else
                {
                    int num = (-1) * i;
                    Console.WriteLine(num);
                }
            }
        }
    }
}
