using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.method_Assignment
{
    public class Satics
    {
        private int x;
        private static int y;

        public void show()
        {
            Console.WriteLine(x+""+y);
        }
        public static void Output()
        {
            Satics s1= new Satics();
            Console.WriteLine(s1.x+""+y);
           
        }
    }
}
