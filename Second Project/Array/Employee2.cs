using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    public class Employee2
    {
        int id;
        string name;
        int salary;
        public Employee2(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return$"{id} {name} {salary}";
        }
    }
    public class RunEmp2
    {
        static void Main(string[] args)
        {
            Employee2[] emp = new Employee2[3];
            for(int i=0;i<emp.Length;i++)
            {
                Console.WriteLine("Enter Id");
                int eid=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                string ename=Console.ReadLine();
                Console.WriteLine("Enter salary");
                int esalary=Convert.ToInt32(Console.ReadLine());
                emp[i]=new Employee2(eid,ename,esalary);
                    if (esalary > 4000)
                    {
                        Console.WriteLine(emp[i]);
                    }
                
            }
            
        }
    }
}
