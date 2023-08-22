using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Inheretance_Assignment
{
    internal class Run
    {
        static void Main(string[] args)
        {
            /*Area a=new Area();
            a.Areas(44.4);
            a.Areas(22);
            a.Areas(44, 88);
            a.Areas(22, 7.5);*/
            /*
                        Student s1 = new Student(44, "sapna", 66, 77, 87);
                        s1.Calculateper();
                        Console.WriteLine(s1.Print());
                        Employee2 e1 = new Employee2(16, "sudhir", 87906);
                        e1.Salarycal();
                        Console.WriteLine(e1.Print());
                        Manager m1 = new Manager(7000, 17, "sandip", 96000);
                        m1.Salarycal();
                        Console.WriteLine(m1.Print());*/

            /*Laptop lap=new Laptop();
            lap.noOfUSBPort = 4;
            lap.Processor = 3.5;
            Console.WriteLine($"number of port={lap.noOfUSBPort} Processor speed is{lap.Processor}");*/

            /*IPLTeam p1 = new CSK(77, 12, 5,2009);
            p1.Play();
            Console.WriteLine(p1.Play());
            IPLTeam p2 = new RCB(66, 10, 3, 2009);
            Console.WriteLine(p2.Play());*/

            Strawberry b1 = new Strawberry();
            Console.WriteLine(b1.Bake());
            BlackForest b2 = new BlackForest();
            Console.WriteLine(b2.Bake());
        }
    }
}
