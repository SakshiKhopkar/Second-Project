using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Writen_test
{
    public  class Employee3
    {
        private int id;
        private string name;
        private double bsalary,HRA,TA,Pf,Gross;
        private static int count;

        
        public Employee3(int id,string name,double bsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.bsalary = bsalary;
        }
        public static int Getemployee()
        {
            return count;
        }

        public void CalculateGross()
        {
            HRA = bsalary * 0.40;
            TA = bsalary * 0.20;
            Pf = bsalary * 0.12;
            Gross = (bsalary + HRA + TA) - Pf;
        }

        public string Display()
        {
            return $"name of employee{name}-salary of employee{bsalary}-gross salary of eployee-{Gross}";
        }
    }
}
