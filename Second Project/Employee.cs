using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double HRA, DA, Pf, TA, Gross, salary;
        private static int count;



        public Employee(string name,double salary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;
        }
        public static int Getemploycount()
        {
            return count;
        }
        public virtual void CalculateSalary()
        {
            HRA = salary * 0.40;
            DA = salary * 0.20;
            TA = salary * 0.10;
            Pf = salary * 0.12;
            Gross = (salary + HRA + DA + TA) - Pf;
        }
        public virtual string Print()
        {
            return $"Empoyee salary: name={name}-Gross Salary={Gross}";
        }
    }

    public class Saleemployee:Employee
    {
        private double bonus, comm;

        public Saleemployee(double bonus, double comm,string name,double salary):base(name,salary)
        {
            this.bonus = bonus;
            this.comm = comm;
        }

        public override void CalculateSalary()
        {
            HRA = salary * 0.40;
            DA = salary * 0.20;
            TA = salary * 0.10;
            Pf = salary * 0.12;
            Gross = (salary + HRA + DA + TA) - Pf;
        }
        public override string Print()
        {
            return$"saleemployee:- {name}-{Gross}-{bonus}-{salary}";
        }
    }
}
