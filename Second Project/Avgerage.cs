using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Avgerage
    {
        public static string Average(int[] array)
        {
           
            int sum = 0;
            int count = 0;
            int avg;
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                count++;

            }
            avg = sum / count;
            return$"average is {avg}";
        }
        public static string Average(double[]array)
        {
            double avg,sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = (double)sum + array[i];
                count++;
            }
            avg = (double) sum / count;
            return$"average is {avg}";
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            Console.WriteLine(Average(array1));
            double[] array2 = new double[3];
            Console.WriteLine(Average(array2));

        }
    }
    
}
