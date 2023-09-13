using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    public enum Department { Entc, Mech,Electrical,Cs,IT };
    public class EnumProgram
    {
        private int RollNo;
        private string name;
        private double Per;
        public Department department;

        public EnumProgram(int RollNo, string name, double Per, Department department)
        {
            this.RollNo = RollNo;
            this.name = name;
            this.Per = Per;
            this.department = department;
        }
        public override string ToString()
        {
            return$"{RollNo}-{name}-{Per}-{department}";
        }
    }
    public class RunEnum
    {
        static void Main(string[] args)
        {
            EnumProgram[] e1 = new EnumProgram[3]
            {
              new EnumProgram(23, "sakshi", 88.9,Department.Mech),
              new EnumProgram(24, "joya", 77.9, Department.Electrical),
              new EnumProgram(25, "sarika", 89.9, Department.Entc),
            };
            foreach (EnumProgram e in e1)
            {
                Console.WriteLine(e);
            }
        }
    }
}
