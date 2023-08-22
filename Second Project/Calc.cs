using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public partial class Calc
    {
        public int ADD(int x, int y)
        {
            return x + y;
        }
        partial void Squareroot(int a);
    }
    public partial class Calc
    {
        public int sqr(int x)
        {
            Squareroot(x);
         return x * x;
        }
        partial void Squareroot(int x)
        {
            Console.WriteLine("square root is"+Math.Sqrt(x));
        }

    }
    public partial class Calc
    {
        public double ADD(double x, double y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }

        
    }
}
