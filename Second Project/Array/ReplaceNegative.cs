using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class ReplaceNegative
    {
        static void Main(string[] args)
        {


            //14.	WAP to replace all negative value with its immediate left elements square.
            int[] array = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] < 0)
                {
                      
                    array[i] = array[i - 1] * array[i - 1];

                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
