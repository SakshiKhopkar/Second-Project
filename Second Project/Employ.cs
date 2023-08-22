using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Second_Project
{
    public class Employ
    {
        private int id ;
        private string Employname, department;
        private double HRA, DA, Pf, TA, Gross, salary;
        private static int count;

        public Employ()
        {
           // id = 300;
            Employname = "sanyogita";
            department = "Accountant";
            salary = 70000;
        }
        
        public Employ( string ename, string dname, int esalary)
        {
            count++;
            this.id = count;
            Employname = ename;
            department = dname;
             salary = esalary;
        }
        public static int Getemploycount()
        {
            return count;
        }
        public void CalculateSalary()
        {
            HRA = salary * 0.40;
            DA = salary * 0.20;
            TA = salary * 0.10;
            Pf = salary * 0.12;
            Gross = (salary + HRA + DA + TA) - Pf;
        }
        public string PrintEmploy()
        {
            return $"Empoyee:{id}\n{Employname}\n{department}\n{salary}\n Gross Salary={Gross}";
        }
    }
}
