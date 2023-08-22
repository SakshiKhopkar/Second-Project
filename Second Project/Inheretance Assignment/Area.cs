using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Inheretance_Assignment
{
    public class Area
    {
        private double areacir, areasqr, areatri, arearea;
        private double pi = 3.14;
        public void Areas(int r)
        {
            areacir = pi * r * r;
            Console.WriteLine("area of circle"+areacir);
        }
        public void Areas(double side)
        {
           areasqr= side* side;
            Console.WriteLine("area of square"+areasqr);
        }
        public void Areas(int l,int b)
        {
            arearea = l * b;
            Console.WriteLine("area of reactangle"+arearea);
        }
        public void Areas(int h,double b)
        {
            areatri = 0.5 * h * b;
            Console.WriteLine("area of triangle" + areatri);
        }
    }
}
