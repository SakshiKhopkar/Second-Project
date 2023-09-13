using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.String
{
    internal class ReverseOfWorld
    {
        static void Main(string[] args)
        {
            //11.Write a C# program to reverse order of words in a given string.
            string s = "India is the best";
            string str = "";
            string[] st = s.Split(' ');
            for(int i=0; i<st.Length; i++)
            {
                string word = st[i];
                string rev = "";
                for(int j=word.Length-1; j>=0; j--)
                {
                    rev = rev+ word[j];
                }
                str=str+" "+rev;               
            }
            Console.WriteLine(str);
            
           

        }
    }
}
