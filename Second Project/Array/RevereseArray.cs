using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class RevereseArray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine($"array[{i}] =" + array[i]);
            }
            Console.WriteLine("reverse array is");
            for (int i = array.Length- 1; i >0; i--)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine("\n");
        }
    }
}
