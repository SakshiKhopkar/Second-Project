using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class evensum
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int sum = 0;
            for(int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0)
                {
                    sum = sum + array[i];

                }
                
            }
            Console.WriteLine("sum of even"+" "+sum);
        }
    }
}
