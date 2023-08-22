using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Inheretance_Assignment
{
    public class Employee2:IPrintable2
    {
        protected int id;
        protected string name;
        protected double HRA, DA, Pf, TA, Gross, salary;

        public Employee2(int id,string name, double salary)
        {
            this.id = id;  
            this.name = name;
            this.salary = salary;  
        }
        public virtual void Salarycal()
        {
            HRA = salary * 0.50;
            DA = salary * 0.40;
            TA = salary * 0.30;
            Pf = salary * 0.12;
            Gross = (salary + HRA + DA + TA) - Pf;
        }
        public string Print()
        {
            return $"employee id={id}-employee name {name}-salary ={salary}-Gross salary={Gross}";
        }

    }
    public class Manager : Employee2,IPrintable2
    {
        private double foodallow;

        public Manager(double foodallow, int id, string name, double salary) :base(id,name,salary)
        {
            this.foodallow = foodallow;
        }
        public override void Salarycal()
        {
            HRA = salary * 0.50;
            DA = salary * 0.40;
            TA = salary * 0.30;
            Pf = salary * 0.12;
            Gross = (salary + HRA + DA + TA+foodallow) - Pf;
        }
        public string Print()
        {
            return $"manager id={id}-manager name {name}-salary ={salary}-Gross salary={Gross}";
        }
    }
}
