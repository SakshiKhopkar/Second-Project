using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.method_Assignment
{
    internal class Run
    {
        static void Main(string[] args)
        {
            /** Console.WriteLine("hello");
            student3 s2= new student3();
             s2.Display(66, "shravani");**/

            /* Satics s2 = new Satics();
             s2.show();
             Satics.Output();*/



            /* static void swap(int a, int b)
             {
                 int temp;
                 temp = a;
                 a = b;
                 b = temp;

             }
             static void Main(string[] args)
             {
                 int a = 23; int b = 43;
                 swap(a, b);
                 Console.WriteLine($"a={a},b={b}");
             }*/
            Digitaldevice device= new Digitaldevice();
            device.ConnectBluetooth();
            device.ConnectWifi();

            Baseclass obj = new Childclass();
            Console.WriteLine( obj.Print());

            Car car = new Car("red","i8","tata");
            car.Start();

            Team t1 = new Team("village", 77);
            Team t2 = new Team("city", 90);
            Console.WriteLine( t1.DisplayTeam());
            Console.WriteLine(t2.DisplayTeam());
            Team.DisplayTotalteam();
    }   }
}
