using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Loops
{
    internal class Logic1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "hello loops");
            Logic2 l=new Logic2();
            l.show();
        }
    }
    class Logic2
    {
        public void show()
        {
            Console.WriteLine(  "thois is show...");
        }
            
    }
}
