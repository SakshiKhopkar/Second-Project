using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Surprise_test
{
    public class run
    {
        static void Main(string[] args)
        {
            Constructor_overload c1= new Constructor_overload();
            Constructor_overload c2= new Constructor_overload(88,"sakshi",98.0);
            Console.WriteLine(c1.Display());
            Console.WriteLine(c2.Display());
        }
    }
}
