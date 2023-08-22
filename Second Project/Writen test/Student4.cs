using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Writen_test
{
    public class Student4
    {
        //private int rollno;
        //private string name;
        //private double per;

        public int Rollno
        { get; set; }
        public string Name { get; set; }
        public double Per { get; set; }

        /*public string Print()
        {
            return $"{rollno}-{name}-{per}";
        }*/
    }
    public class important
    {
        static void Main(string[] args)
        {


            Student4 s1 = new Student4();
            s1.Rollno = 88;
            s1.Name = "swati";
            s1.Per = 88.90;
            Console.WriteLine($"{s1.Rollno}-{s1.Name}-{s1.Per}");
        }
    }
}
