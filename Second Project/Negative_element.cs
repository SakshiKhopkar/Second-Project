using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Negative_element
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] num=new int[10];
            for(int i=0; i<num.Length; i++)
            {
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0 ; i<num.Length ; i++)
            {
                if (num[i]< 0)
                {
                    Console.WriteLine("negative number=" + num[i]);
                    count++;
                }
            }
            Console.WriteLine("total negative numbers are" + count);
        }
    }
}
