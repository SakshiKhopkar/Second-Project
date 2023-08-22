using Second_Project.Inheretance_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class DuplicateNum
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 2, 4, 1, 4,1 };
          
            //int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i-1; k >=0; k--)
                {
                    if (num[k] == num[i])
                    {
                        
                        isvisited = true;
                        break;
                    }
                    
                }
                if(isvisited==false)
                {
                   for(int j=i+1; j<num.Length; j++)
                    {
                        if (num[i] == num[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(count+"times"+num[i]);
                      
                    }
                }
               
            }
           // Console.WriteLine("total duplicate numbers are " +count);

        }
    }
}
