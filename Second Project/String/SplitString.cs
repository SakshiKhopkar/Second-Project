using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.String
{
    internal class SplitString
    {
        static void Main(string[] args)
        {
            string MSG = "HELLO#WORLD";
            string[] strarry = MSG.Split('#');
            //Console.WriteLine(strarry[0]);
            //Console.WriteLine(strarry[1]);
            //Write a C# program to find first occurrence of a character in a given string.
           // Console.WriteLine(MSG.IndexOf('o'));
            //4.	Write a C# program to trim leading white space characters in a string.
            char[] ch = MSG.ToCharArray();
            Console.WriteLine(ch);
            // Console.WriteLine("character trim"+MSG.Trim(ch));
            //Write a C# program to count total number of words in a string. 
            //Console.WriteLine("count of words"+strarry.Length);
            //7.Write a C# program to remove all occurrences of a character from string.
            //8.Write a C# program to toggle case of each character of a string. 
                string temp = strarry[0];
                strarry[0] = strarry[1];
                strarry[1] = temp;
            Console.WriteLine(strarry[0]);
            Console.WriteLine(strarry[1]);
          
            




        }
    }
}
