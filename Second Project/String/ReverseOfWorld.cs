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
            string Call = "Hii Everybody";
             string[] strarray = Call.Split(' ');
             string msg="";
             string MSG2 = "";
             msg = strarray[0];
             MSG2 = strarray[1];
             char[] ch=msg.ToCharArray();
             for(int i=ch.Length-1; i>=0; i--)
             {
                 Console.Write(ch[i]);
             }
             Console.WriteLine();
             char[] ch2 = MSG2.ToCharArray();
             for (int i = ch2.Length - 1; i >= 0; i--)
             {
                 Console.Write(ch2[i]);
             }
             Console.WriteLine();
           

        }
    }
}
