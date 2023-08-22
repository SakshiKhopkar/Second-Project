using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Second_Project.method_Assignment
{
    public class student3
    {
        private int rollNo,id;
        private string Name, branch;
        private double math, phy, science, percentage, total;

        public void Display(int id, int roll,string name)
        {
            this.id = id;
            rollNo = roll;
            Name = name;
            Console.WriteLine(roll);
            Console.WriteLine(name);
            this.Getid();
        }
        public string Getid()
        {
            return $"{id}";
        }


    }
}
