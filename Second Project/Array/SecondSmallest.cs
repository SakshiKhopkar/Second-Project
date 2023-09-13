using Second_Project.Inheretance_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class SecondSmallest
    {
        static void Main(string[] args)
        {


            //WAP to find the second smallest element in an array.
            int[] arr = { 1, 2, 5, 7, 9 };
            int small = int.MaxValue;
            int small2=int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < small)
                {
                    small2 = small;
                    small = arr[i];
                }
                else if (arr[i] > small && arr[i]<small2)
                {
                    small2 = arr[i];
                }
            }
            Console.WriteLine($"second smallest no:"+small2);
        }
    }
}
