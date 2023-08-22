using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Abstraction_assignment
{
   public abstract class Cheak_Wifi_access
    {
        public abstract string Display();
    }
    public class EmployeeRoom : Cheak_Wifi_access
    {
        public override string Display()
        {
            return $"the wifi is accessible in the Employee Room";
        }
        
    }
    public class Admin_staffroom : Cheak_Wifi_access
    {
        public override string Display()
        {
            return $"wifi accesible in staffRoom";
        }
    }
    public class Run2
    {
        static void Main(string[] args)
        {
            EmployeeRoom e1 = new EmployeeRoom();
            Console.WriteLine(e1.Display());
            Admin_staffroom a1 = new Admin_staffroom();
            Console.WriteLine(a1.Display());
        }
    }
}
