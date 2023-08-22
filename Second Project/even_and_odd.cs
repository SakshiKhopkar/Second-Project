using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class even_and_odd
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[5];
            int[] numbers2 = new int[5];
            int[] numbers3 = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0; i < numbers.Length; i++)
            {
                
                if (numbers[i] % 2 == 0)
                {
                    numbers2[i]= numbers[i];
                }
                else
                {
                    numbers3[i]= numbers[i];
                }
            }
            Console.WriteLine("even array");
            for (int i = 0; i < numbers2.Length; i++)
            {
                
                if(numbers2[i] > 0)
                {
                    Console.WriteLine(numbers2[i]);

                }
            }
            Console.WriteLine("odd array");
            for (int i = 0; i < numbers3.Length; i++)
            {

                if (numbers3[i] > 0)
                {
                    Console.WriteLine(numbers3[i]);
                }
            }
        }
    }
}
