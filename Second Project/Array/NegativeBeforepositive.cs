using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class NegativeBeforepositive
    {
        //WAP to arrange the elements of an given array of integers
        //where all negative integers appear before all the positive integers.
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("enter the list");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            for(int j=0;j< array.Length; j++)
            {
                if (array[j] > 0) 
                {
                    Console.WriteLine(array[j]);
                }
            }
        }
    }
}
