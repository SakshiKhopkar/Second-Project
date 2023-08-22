using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.String
{
    internal class StringFunction
    {
        static void Main(string[] args)
        {
            string message = "  hello everyone  ";
            string message2 = "Hi all  ";
            string message3 = "  Good day";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());//return the address location of variable
            message = message + "Good Morning";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
            string str1 = string.Concat(message.Trim(),"", message2.TrimEnd(),message3.TrimStart());
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message2.ToLower());
            Console.WriteLine("index -"+message.IndexOf('l'));
            Console.WriteLine("last Index -" + message.LastIndexOf('l'));
            // Conver string to array
            string[] strarray = message2.Split(' ');
            //Convert string to char array
            char[] ch=message.ToCharArray();
            //Convert char array to a string
            string str=new string(ch);
            Console.WriteLine(str);
            foreach(char c in ch) Console.WriteLine(c);
            //Console.WriteLine(strarray[0]);
            //Console.WriteLine(strarray[1]);
            foreach(string s in strarray) Console.WriteLine(s);
            for (int i = 0; i < message3.Length; i++) { Console.WriteLine(message3[i]); }
        }
    }
}
