using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class PrimeEle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int num=Convert.ToInt32(Console.ReadLine());
            int[] array=new int[num];
            for(int i=0; i<array.Length; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }
            for(int i=0; i<array.Length;i++)
            {
                bool isprime = true;
                for (int j = 2; j < array[i];j++)
                {                 
                    if (array[i] % j == 0)
                    {
                       isprime = false;
                       break;
                    }     
                }
                if (isprime)
                {
                    Console.WriteLine("prime no"+array[i]);
                }

            }
        }
    }
}
