using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class AcceptName
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            for(int i = 0; i < names.Length; i++)
            {
                names[i]=Console.ReadLine();
            }
            for(int i=0; i < names.Length; i++)
            {
                Console.WriteLine($"names[{i}]="+names[i]);
            }
        }
    }
}
