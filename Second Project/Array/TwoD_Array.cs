using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class TwoD_Array
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 5];
           /* {
                {1,2,3,4,5 },
                {6,7,8,9,10},
                {11,12,13,14,15},
                {16,17,18,19,20}
            };*/
            for(int i=0;i<array.GetLength(0);i++)
            {
               for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"array[{i},{j}]={array[i,j]}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
