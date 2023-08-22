using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Writen_test
{
    internal class Run2
    {
        static void Main(string[] args)
        {
            Employee3 e1 = new Employee3(33, "surya", 80000);
            Employee3 e2 = new Employee3(34, "suyog", 70000);
            Console.WriteLine( "number of employee="+Employee3.Getemployee());
            e1.CalculateGross();
            Console.WriteLine(e1.Display());

            Product p1 = new Product() { Id = 6, Name = "fan", Price = 5000 };
            Console.WriteLine( "before discount"+p1.Display());
            p1.Discount(10);
            Console.WriteLine("after discount"+p1.Display());
          /*
            Student4 s1= new Student4();
            s1.Rollno = 88;
            s1.Name = "swati";
            s1.Per = 88.90;
            Console.WriteLine($"{s1.Rollno}-{s1.Name}-{s1.Per}");
            //Console.WriteLine(s1.Print());*/
        }
    }
}
