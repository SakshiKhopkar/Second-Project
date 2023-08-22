using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Rupee
    {
        private double Doller;
        public void RtoD(double rs)
        {
            Doller = rs / 69.7;
            Console.WriteLine(Doller);
        }
    }
}
