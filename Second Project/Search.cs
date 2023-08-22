using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Search
    {
        static void Main(string[] args)
        {
            int[] num= new int[5] {1,2,3,4,5};
           /* for(int i=0; i<num.Length; i++)
            {
                num[i]=Convert.ToInt32(Console.ReadLine());
            }*/
            Console.WriteLine("enter the number want to search");
            int s=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num.Length;i++)
            {
                if (num[i] == s)
                {
                    Console.WriteLine("number found and index is"+i);
                }
            }
        }
    }
}
