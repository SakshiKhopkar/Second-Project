using Second_Project.Inheretance_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class Euality_Of_Array
    {
        static void Main(string[] args)
        {
            int[] array1 =  { 12, 22, 32, 42, 52, 62 };
            int[] array2 = { 52, 22, 62, 32, 42, 12 };
           
            bool isequal = true;
            if(array1.Length != array2.Length)
            {
                isequal = false;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        int temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }

            }
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = i + 1; j < array2.Length; j++)
                {
                    if (array2[i] > array2[j])
                    {
                        int temp = array2[i];
                        array2[i] = array2[j];
                        array2[j] = temp;

                    }
                }
            }
          
            for (int i = 0, j=0; i<array1.Length || j<array2.Length; i++,j++)
            {
             
                {
                    if (array1[i] != array2[j])
                    {
                        isequal = false;
                        break;
                        
                    }

                }
            }

            if(isequal)
            {
                Console.WriteLine("array are equal");
            }
            else
            {
                Console.WriteLine("array are not equal");
            }

        }
    }
}
