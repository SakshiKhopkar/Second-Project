using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.method_Assignment
{
    //Use of base keyword in single code
    public class Vehicle
    {
        protected string vehiclecompany;

        public Vehicle(string vehiclecompany)
        {
            this.vehiclecompany = vehiclecompany;
        }
     public virtual void Start()
     {
            Console.WriteLine("Vehicle started");
     }
    }
    public class Car : Vehicle
    {
        private string color, modelname;
        public Car(string color, string modelname,string vehiclecompany) : base(vehiclecompany)
        {
            this.color = color;
            this.modelname = modelname;
        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine("car started");
        }
    }
}
