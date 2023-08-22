using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class SecondHighest
    {
        static void Main(string[] args)
        {
            int[] arr = { 12,35,23,15,34,10 };
            int  first, second;

            // There should be atleast two elements
            if (arr.Length < 2)
            {
                Console.WriteLine(" Invalid Input ");
                return;
            }

            first = second = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                // If current element is smaller than
                // first then update both first and second
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }

                // If arr[i] is in between first
                // and second then update second
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }

            if (second == int.MinValue)
                Console.Write("There is no second largest"
                              + " element\n");
            else
                Console.Write("The second largest element"
                              + " is "+" " + second);
            Console.WriteLine(" ");
        }
    }
}
