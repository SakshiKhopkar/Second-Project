using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    abstract public class Shape
    {
        public abstract string Draw(string name);
        public abstract void Area();
        public string Display()
        {
            return $"this is the shape class";
        }

    }
    public class Reactangle : Shape
    {
        private int area;
        private int l,w;

        public Reactangle(int l,int w)
        {
            this.l= l;
            this.w= w;
        }
        public override string Draw(string name)
        {
            return name;
        }
        public override void Area()
        {
            area = l * w;
        }
        public string Print()
        {
            return $"Area is {area}";
        }
    }
    public class Circle : Shape
    {
        private double area,r;
        private const double pi=3.14;

        public Circle( double r)
        {
            this.r= r;
        }
        public override string Draw(string name)
        {
            return name;
        }
        public override void Area()
        {
            area = pi * r * r;
        }
        public string Print()
        {
            return $"area of circle is{area}";
        }

    }
}
